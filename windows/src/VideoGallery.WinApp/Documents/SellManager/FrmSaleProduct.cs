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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;


namespace VideoGallery.WinApp.Documents.SellManager
{
    public partial class FrmSaleProduct : Telerik.WinControls.UI.RadForm

    {
        public int billId;
        public int billTotalItem;
        public double billTotalPrice;
        public double billCashPaid;
        public decimal billChange;



        public Invoice invoice;
        double sellingPrice = 0.00;
        int totalInvoiceItem = 0;
        double totalInvoicePrice = 0.00;
        List<SaleItem> saleItemList = new List<SaleItem>();
        int quantity {
            get {return (int)numQuantity.Value; }
            set { numQuantity.Value = value; }
        }
       

        public FrmSaleProduct()
        {
            InitializeComponent();
        }
        #region Common Functions 
        void SelectedItem(Product product)
        {
            sellingPrice = product.SellingPrice;
            lblUnitPrice.Text = sellingPrice.ToString();

            lblProductId.Text = product.Id.ToString();
            lblUnitPrice.Text = product.SellingPrice.ToString();
            lblAvailable.Text = product.Avaiable.ToString();
            lblTotalItem.Text = product.TotalItem.ToString();
            lblTotalSold.Text = product.TotalSold.ToString();


            txtTotalPrice.Text = (quantity * sellingPrice).ToString();
            
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
                    SaleItem saleItem = saleItemList.SingleOrDefault(x => x.Id == product.Id);
                    if (saleItem == null)
                    {
                        saleItem = new SaleItem();
                        saleItemList.Add(saleItem);
                        saleItem.Id = product.Id;
                        saleItem.Title = product.Title;

                    }

                    saleItem.Unit_Price = product.SellingPrice;
                    saleItem.Quantity = quantity;
                    saleItem.Total_Price = quantity * product.SellingPrice;

                    gvProduct.DataSource = null;
                    gvProduct.DataSource = saleItemList;
                    UpdateTotal();
                }
            }

        }
        void UpdateTotal()
        {
            totalInvoiceItem = 0;
            totalInvoicePrice = 0.00;
            if (saleItemList.Count > 0)
            {
                foreach (var item in saleItemList)
                {
                    totalInvoiceItem += item.Quantity;
                    totalInvoicePrice += item.Total_Price;
                }
            }

            lblTotalInvoiceItem.Text = totalInvoiceItem.ToString();
            lblTotalInvoicePrice.Text = totalInvoicePrice.ToString();
            //billll
            billTotalPrice = totalInvoicePrice;
            numCash.Value = (decimal)totalInvoicePrice;
            lblChange.Text = "0.00";
            //billlllll
            billTotalItem = totalInvoiceItem;

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
        void NewInvoice()
        {
            saleItemList = new List<SaleItem>();
            invoice = null;
            gvProduct.DataSource = null;
            gvProduct.DataSource = saleItemList;
            ddlProductSearch.SelectedIndex = -1;
            lblInvoice.Text= GetNewInvoiceId().ToString();

            UpdateTotal();

        }
        #endregion
        private void FrmSaleProduct_Load(object sender, EventArgs e)
        {
            lblUserName.Text = _App.CurrentUser.FullName;
            lblUserID.Text = _App.CurrentUser.UserName;
          
            lblInvoice.Text = GetNewInvoiceId().ToString();
   
            gvProduct.DataSource = saleItemList;

            ddlProductSearch.DataSource = _App.VgmsDb.Product.ToList();
            ddlProductSearch.DisplayMember = "Title";
            ddlProductSearch.ValueMember = "Id";

            ddlProductSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
            ddlProductSearch.SelectedIndex = -1;
            this.ddlProductSearch.SelectedIndexChanged += this.ddlProductSearch_SelectedIndexChanged;
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
           
            txtTotalPrice.Text = (quantity * sellingPrice).ToString();

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
                        var objectToSave = saleItemList.SingleOrDefault(y => y.Id == saleItem.Id);
                        if (objectToSave != null)
                        {
                            saleItemList.Remove(objectToSave);
                            gvProduct.DataSource = null;
                            gvProduct.DataSource = saleItemList;
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
            
            if (saleItemList.Count <= 0)
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
                    invoice.TotalSellingPrice =(float) totalInvoicePrice;
                   
                    invoice.CreateById = _App.CurrentUser.Id;
                    invoice.CreateDate = DateTime.Now;
                    invoice.UpdateById = _App.CurrentUser.Id;
                    invoice.UpdateDate = DateTime.Now;
                    _App.VgmsDb.Invoice.Add(invoice);
                    _App.VgmsDb.SaveChanges();
                    var totalBuyPrice = 0.00;
                    foreach (var item in saleItemList)
                    {
                        var product = _App.VgmsDb.Product.SingleOrDefault(x => x.Id == item.Id);
                        if (product != null)
                        {
                            Sold sold = new Sold();
                            sold.InvoiceId = invoice.Id;
                            sold.ProductId = item.Id;
                            sold.Quantity = item.Quantity;
                            sold.UnitSellingPrice = (float)item.Unit_Price;
                            sold.TotalPrice = (float)item.Total_Price;
                            sold.SaleDate = DateTime.Now;

                            _App.VgmsDb.Sold.Add(sold);
                            totalBuyPrice += item.Quantity * product.BuyPrice;
                            product.TotalSold += item.Quantity;
                        }
                    }
                   
                    _App.VgmsDb.SaveChanges();
                    scope.Commit();
                    CreatPdf();
                    NewInvoice();
                }
               

                //open a billing form pass invoice id
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error!" + ex.GetBaseException());

            }

        

        }

        void CreatPdf()
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 20, 20, 50, 45);
            var pdfPath = "D://Bill.pdf";
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(pdfPath, FileMode.Create));
            doc.Open();
            Paragraph parag = new Paragraph("                                    Video Gallery Management System\r\r\n\r" + "                                    Transection Details \r\r\n\r" +
               "\rInvoice No : "+ invoice.Id+  "\rTotal Products :" + billTotalItem + "\rTotal Price : " + billTotalPrice +"\rCash Paid : "+billCashPaid + "\rChange :" +billChange );


            doc.Add(parag);
            doc.Close();
            System.Diagnostics.Process.Start(pdfPath);
        }

        private void numCash_ValueChanged(object sender, EventArgs e)
        {
         
            lblChange.Text = (numCash.Value -(decimal)totalInvoicePrice).ToString();
            //billl
            billCashPaid = (double)numCash.Value;
            //billlll
            billChange = (numCash.Value - (decimal)totalInvoicePrice);
        }
    }
}

