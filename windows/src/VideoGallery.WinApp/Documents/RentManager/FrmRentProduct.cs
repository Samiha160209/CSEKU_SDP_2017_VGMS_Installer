using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using VideoGallery.WinApp.Data;
using VideoGallery.WinApp.Utils;

namespace VideoGallery.WinApp.Documents.SellManager
{
    public partial class FrmRentProduct : Telerik.WinControls.UI.RadForm

    {
        public Invoice invoice;
        double rentPrice = 0.00;
        int totalInvoiceItem = 0;
        double totalInvoicePrice = 0.00;
        List<SaleItem> rentItemList = new List<SaleItem>();
        int quantity
        {
            get { return (int)numQuantity.Value; }
            set { numQuantity.Value = value; }
        }


        public FrmRentProduct()
        {
            InitializeComponent();
        }
        #region Common Functions 
        void SelectedItem(Product product)
        {
            rentPrice = product.RentPrice;
            lblUnitPrice.Text = rentPrice.ToString();

            lblProductId.Text = product.Id.ToString();
            lblUnitPrice.Text = product.RentPrice.ToString();
            lblAvailable.Text = product.Avaiable.ToString();
            lblTotalItem.Text = product.TotalItem.ToString();
            lblTotalSold.Text = product.TotalSold.ToString();


            txtTotalPrice.Text = (quantity * rentPrice).ToString();
        }

        void UpdateItem()
        {
            if (ddlProductSearch.SelectedIndex != -1 && ddlProductSearch.SelectedItem.DataBoundItem != null)
            {
                var product = ddlProductSearch.SelectedItem.DataBoundItem as Product;
                if (product != null && quantity > 0)
                {
                    if (product.Avaiable <= 0 || product.Avaiable < quantity)
                    {
                        MessageBox.Show("Sorry Product Not Aval!!");
                        return;
                    }
                    SaleItem saleItem = rentItemList.SingleOrDefault(x => x.Id == product.Id);
                    if (saleItem == null)
                    {
                        saleItem = new SaleItem();
                        rentItemList.Add(saleItem);
                        saleItem.Id = product.Id;
                        saleItem.Title = product.Title;

                    }

                    saleItem.Unit_Price = product.RentPrice;
                    saleItem.Quantity = quantity;
                    saleItem.Total_Price = quantity * product.RentPrice;

                    gvProduct.DataSource = null;
                    gvProduct.DataSource = rentItemList;
                    UpdateTotal();
                }
            }

        }
        void UpdateTotal()
        {
            totalInvoiceItem = 0;
            totalInvoicePrice = 0.00;
            if (rentItemList.Count > 0)
            {
                foreach (var item in rentItemList)
                {
                    totalInvoiceItem += item.Quantity;
                    totalInvoicePrice += item.Total_Price;
                }
            }

            lblTotalInvoiceItem.Text = totalInvoiceItem.ToString();
            lblTotalInvoicePrice.Text = totalInvoicePrice.ToString();
            numCash.Value = (decimal)totalInvoicePrice;
            lblChange.Text = "0.00";

        }
        void NewInvoice()
        {
            rentItemList = new List<SaleItem>();
            invoice = null;
            gvProduct.DataSource = null;
            gvProduct.DataSource = rentItemList;
            ddlProductSearch.SelectedIndex = -1;
            lblInvoice.Text = GetNewInvoiceId().ToString();
            UpdateTotal();

        }
        int GetNewInvoiceId()
        {
            var maxId = 0;
            if (_App.VgmsDb.Invoice.Any())
            {
                maxId = _App.VgmsDb.Invoice.Max(x => x.Id);
            }
            return maxId + 1;

        }
        #endregion
        private void FrmSaleProduct_Load(object sender, EventArgs e)
        {
            lblUserName.Text = _App.CurrentUser.FullName;
            lblUserID.Text = _App.CurrentUser.UserName;
            lblInvoice.Text = GetNewInvoiceId().ToString();

            gvProduct.DataSource = rentItemList;

            ddlProductSearch.DataSource = _App.VgmsDb.Product.ToList();
            ddlProductSearch.DisplayMember = "Title";
            ddlProductSearch.ValueMember = "Id";

            ddlProductSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
            ddlProductSearch.SelectedIndex = -1;
            this.ddlProductSearch.SelectedIndexChanged += this.ddlProductSearch_SelectedIndexChanged;

            ddlCustomer.DataSource = _App.VgmsDb.Customer.ToList();
            ddlCustomer.DisplayMember = "Name";
            ddlCustomer.ValueMember = "Id";
            ddlCustomer.AutoCompleteMode = AutoCompleteMode.Suggest;
            ddlCustomer.SelectedIndex = -1;
        }
        private void ddlProductSearch_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (ddlProductSearch.SelectedIndex != -1 && ddlProductSearch.SelectedItem.DataBoundItem != null)
            {
                var product = ddlProductSearch.SelectedItem.DataBoundItem as Product;
                if (product != null)
                {
                    SelectedItem(product);
                }
            }
        }

        private void numQuantity_ValueChanged(object sender, EventArgs e)
        {

            txtTotalPrice.Text = (quantity * rentPrice).ToString();

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            UpdateItem();
        }

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            if (gvProduct.SelectedRows != null && gvProduct.SelectedRows.Count >= 1)
            {
                var saleItem = gvProduct.SelectedRows[0].DataBoundItem as SaleItem;
                if (saleItem != null)
                {
                    DialogResult res = MessageBox.Show(this, "Are you sure, you want to remove item?", "Attention!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (res == DialogResult.Yes)
                    {
                        var objectToSave = rentItemList.SingleOrDefault(y => y.Id == saleItem.Id);
                        if (objectToSave != null)
                        {
                            rentItemList.Remove(objectToSave);
                            gvProduct.DataSource = null;
                            gvProduct.DataSource = rentItemList;
                            UpdateTotal();

                        }

                        //MessageBox.Show(this, "Customer Deleted!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
        }

        private void btnNewTranjection_Click(object sender, EventArgs e)
        {
            NewInvoice();
        }

        private void gvProduct_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (gvProduct.SelectedRows != null && gvProduct.SelectedRows.Count >= 1)
            {
                var saleItem = gvProduct.SelectedRows[0].DataBoundItem as SaleItem;
                if (saleItem != null)
                {
                    ddlProductSearch.SelectedIndex = -1;
                    numQuantity.Value = saleItem.Quantity;
                    txtTotalPrice.Text = (saleItem.Quantity * saleItem.Unit_Price).ToString();

                    ddlProductSearch.SelectedValue = saleItem.Id;
                }
            }
        }

        private void btnPayInvoice_Click(object sender, EventArgs e)
        {
            var customer = ddlCustomer.SelectedItem.DataBoundItem as Customer;
            if (customer == null)
            {
                MessageBox.Show("Please select a Customer to Rent!");
                return;
            }
                if (rentItemList.Count <= 0)
            {
                MessageBox.Show("Please add a product in Cart!");
                return;
            }

            try
            {
                using (var scope = _App.VgmsDb.Database.BeginTransaction())
                {
                    if (invoice == null)
                    {
                        invoice = new Invoice();
                    }
                  
                    invoice.TotalItem = totalInvoiceItem;
                    invoice.TotalSellingPrice = (float)totalInvoicePrice;
                    invoice.InRent = true;
                    invoice.CreateById = _App.CurrentUser.Id;
                    invoice.CreateDate = DateTime.Now;
                    invoice.UpdateById = _App.CurrentUser.Id;
                    invoice.UpdateDate = DateTime.Now;
                    _App.VgmsDb.Invoice.Add(invoice);
                    _App.VgmsDb.SaveChanges();
                    var totalBuyPrice = 0.00;
                    foreach (var item in rentItemList)
                    {
                        var product = _App.VgmsDb.Product.SingleOrDefault(x => x.Id == item.Id);
                        if (product != null)
                        {
                            Rented rent = new Rented();
                            rent.CustomerId = customer.Id;
                            rent.InvoiceId = invoice.Id;
                            rent.ProductId = item.Id;
                            rent.Quantity = item.Quantity;
                            rent.RentAmount = (float)item.Unit_Price;
                            //rent.TotalPrice = (float)item.Total_Price;
                            rent.RentDate = DateTime.Now;
                            rent.ReturnDate = DateTime.Now.AddDays(product.AllowedRentDays);

                            _App.VgmsDb.Rented.Add(rent);
                            totalBuyPrice += item.Quantity * product.BuyPrice;
                            product.TotalRented += item.Quantity;
                        }
                    }

                    _App.VgmsDb.SaveChanges();
                    scope.Commit();
                    NewInvoice();
                }


                //open a billing form pass invoice id
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error!" + ex.GetBaseException());

            }

        }

        private void numCash_ValueChanged(object sender, EventArgs e)
        {

            lblChange.Text = (numCash.Value - (decimal)totalInvoicePrice).ToString();
        }

    }
}

