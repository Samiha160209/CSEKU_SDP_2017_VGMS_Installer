using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Linq;
using VideoGallery.WinApp.Data;
using VideoGallery.WinApp.Utils;

namespace VideoGallery.WinApp.Documents.RentManager
{
    public partial class FrmReturnProduct : Telerik.WinControls.UI.RadForm
    {
        //int totalRented = 0;
        //int totalRetuned = 0;
        //int totalUnRetuned = 0;
        public FrmReturnProduct()
        {
            InitializeComponent();
        }

        private void FrmReturnProduct_Load(object sender, EventArgs e)
        {
            ddlCustomer.DataSource = _App.VgmsDb.Customer.ToList();
            ddlCustomer.DisplayMember = "Name";
            ddlCustomer.ValueMember = "Id";
            ddlCustomer.AutoCompleteMode = AutoCompleteMode.Suggest;
            ddlCustomer.SelectedIndex = -1;
        }

        private void ddlCustomer_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            ClaculateData();
        }

        void ClaculateData()
        {
            lblRented.Text = ""; ;
            lblReturned.Text = ""; ;
            lblUnreturnted.Text = ""; ;
            gvProduct.DataSource = null;
            if (ddlCustomer.SelectedIndex == -1)
            {
                return;
            }
            var customer = ddlCustomer.SelectedItem.DataBoundItem as Customer;

         
            if (customer != null)
            {
                lblRented.Text = _App.VgmsDb.Rented.Count(x => x.CustomerId == customer.Id).ToString();
                lblReturned.Text = _App.VgmsDb.Rented.Count(x => x.CustomerId == customer.Id && x.IsReturned).ToString();
                lblUnreturnted.Text = _App.VgmsDb.Rented.Count(x => x.CustomerId == customer.Id && !x.IsReturned).ToString();

                gvProduct.DataSource = _App.VgmsDb.Rented.Include("Customer").Include("Product")
                    .Where(x => x.CustomerId == customer.Id).OrderBy(x => x.IsReturned).ToList();
                //dgvReportPdf.DataSource = _App.VgmsDb.Sold.Include("Product").ToList();
            }

        }

        //private void gvProduct_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        //{
        //    if (gvProduct.SelectedRows != null && gvProduct.SelectedRows.Count >= 1)
        //    {
        //        var saleItem = gvProduct.SelectedRows[0].DataBoundItem as Rented;
        //        if (saleItem != null)
        //        {

        //        }
        //    }
        //}
        private void btnReturnProduct_Click(object sender, EventArgs e)
        {
            if (gvProduct.SelectedRows != null && gvProduct.SelectedRows.Count >= 1)
            {
                var rented = gvProduct.SelectedRows[0].DataBoundItem as Rented;
                if (rented != null)
                {
                    //DialogResult res = MessageBox.Show(this, "Are you sure, you want to remove item?", "Attention!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    //if (res == DialogResult.Yes)
                    {
                        rented.IsReturned = true;
                        var product = _App.VgmsDb.Product.SingleOrDefault(x => x.Id == rented.ProductId);
                        if (product != null)
                        {
                            product.TotalRented -= rented.Quantity;
                        }
                        _App.VgmsDb.SaveChanges();
                        ClaculateData();
                        //MessageBox.Show(this, "Customer Deleted!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
        }

        private void btnAllUnreturned_Click(object sender, EventArgs e)
        {
            var unretnedList = _App.VgmsDb.Rented.Include("Customer").Include("Product")
                    .Where(x=>!x.IsReturned).OrderBy(x => x.IsReturned).ToList();
            if (unretnedList.Count<=0)
            {
                MessageBox.Show("There is no unretuned product");
                return;
            }
            gvProduct.DataSource = unretnedList;

        }
    }
}
