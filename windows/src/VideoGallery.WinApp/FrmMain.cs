using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using VideoGallery.WinApp.Data;
using VideoGallery.WinApp.Documents.Bill_Report_Manager;
using VideoGallery.WinApp.Documents.CustomerManager;
using VideoGallery.WinApp.Documents.ProductManager;
using VideoGallery.WinApp.Documents.RentManager;
using VideoGallery.WinApp.Documents.ReportManager;
using VideoGallery.WinApp.Documents.SellManager;
using VideoGallery.WinApp.Documents.UserManager;

namespace VideoGallery.WinApp
{
    public partial class FrmMain : Telerik.WinControls.UI.RadForm
    {

        public FrmMain()
        {
            InitializeComponent();
            this.miAddCdDvd.Click += this.miAddCdDvd_Click;
            this.miCdDvdList.Click += miCdDvdList_Click;
            //this.miCustomerAdd.Click += miCustomerAdd_Click;
            //this.miCustomerList.Click += miCustomerList_Click;
            this.miUserAdd.Click += miUserAdd_Click;
            this.miUserSearch.Click += miUserSearch_Click;
            miMonthlyIncome.Click += MiMonthlyIncome_Click;
            miExit.Click += MiExit_Click;
            //miBill.Click += MiBill_Click;
            miMonthlyReport.Click += MiMonthlyReport_Click;
            miAddEditCustomer.Click += MiAddEditCustomer_Click;
            miCoustomerList.Click += MiCustomerList_Click;

        }


        private void MiExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmTest_Load(object sender, EventArgs e)
        {
            if (_App.CurrentUser.Type == UserInfo.TypeEnum.SubAdmin)
            {
                btnReport.Enabled = false;
                miUserAdd.Enabled = false;
                miMonthlyIncome.Enabled = false;
            }
            if (_App.CurrentUser.Type == UserInfo.TypeEnum.SalesMan)
            {
                btnReport.Enabled = false;
                miUserAdd.Enabled = false;
                miUserSearch.Enabled = false;
                miMonthlyIncome.Enabled = false;
                btnAddCdDvd.Enabled = false;
                miAddCdDvd.Enabled = false;
            }

            var productList = _App.VgmsDb.Product.OrderByDescending(x => x.CreateDate).ToList();
            ddlProductSearch.DataSource = productList;
            ddlProductSearch.DisplayMember = "Title";
            ddlProductSearch.ValueMember = "Id";

            ddlProductSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
            ddlProductSearch.SelectedIndex = -1;
            this.ddlProductSearch.SelectedIndexChanged += this.ddlProductSearch_SelectedIndexChanged;


            //movList.DataSource = productList;

            LoadMovieList(productList);

        }
        private void btnAll_Click(object sender, EventArgs e)
        {
            var productList = _App.VgmsDb.Product.OrderByDescending(x => x.CreateDate).ToList();
            LoadMovieList(productList);
        }

        private void btnRecent_Click(object sender, EventArgs e)
        {
            var productList = _App.VgmsDb.Product.OrderByDescending(x => x.CreateDate).Take(10).ToList();
            LoadMovieList(productList);
        }

        private void btnPopular_Click(object sender, EventArgs e)
        {
            var productList = _App.VgmsDb.Product.OrderByDescending(x => x.TotalSold).Take(10).ToList();
            LoadMovieList(productList);
        }
        /**************************/
        #region Load Move List
        private void LoadMovieList(List<Product> movList)
        {
            this.movList.Items.Clear();

            foreach (Product product in movList)
            {
                this.movList.Items.Add(this.CreateItem(product));
            }
            this.movList.SelectedIndex = 0;
        }
        private ListViewDataItem CreateItem(Product product)
        {
            ListViewDataItem item = new ListViewDataItem();
            var imagePath = AppDomain.CurrentDomain.BaseDirectory + product.ImagePath;
            Image image;
            if (File.Exists(imagePath))
            {
                image = Image.FromFile(imagePath);
            }
            else
            {
                image = VideoGallery.WinApp.Properties.Resources.BlankImage;
            }
            item.Image = image.GetThumbnailImage(200, 100, null, IntPtr.Zero);
            item.Text = product.Title;
            item.Tag = product;

            return item;
        }
        private void movList_VisualItemFormatting(object sender, ListViewVisualItemEventArgs e)
        {
            SimpleListViewVisualItem item = e.VisualItem as SimpleListViewVisualItem;

            Product product = item.Data.Tag as Product;
            string color = "#681406";

            item.Data.Text = "<html>" +
                   "<span style=\"font-size:14.5pt;font-family:Segoe UI Semibold;\">  " + product.Title + "</span>" +
                   "<br><span style=\"font-size:12px;\"><i>    Total: " + product.TotalItem + "      Available: " + product.Avaiable + "</i></span>" +
                   "<br><span style=\"font-size:15pt;\"> </span>" +
                   "<span style=\"color:" + color + ";font-size:14.5pt;\">  BDT " + product.SellingPrice + "</span>";

            item.ImageLayout = ImageLayout.Center;
            item.ImageAlignment = ContentAlignment.MiddleLeft;

        }

        private void movList_ItemMouseClick(object sender, ListViewItemEventArgs e)
        {
            // e.Item.Tag as Product;

            if (e.Item != null)
            {
                var product = e.Item.Tag as Product;
                if (product != null)
                {
                    LoadProductSearch(product);
                }
                else
                {
                    EmptyProduct();
                }
            }
        }

        #endregion


        /******************************/
        private void ddlProductSearch_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {

            if (ddlProductSearch.SelectedIndex != -1 && ddlProductSearch.SelectedItem.DataBoundItem != null)
            {
                var product = ddlProductSearch.SelectedItem.DataBoundItem as Product;
                if (product != null)
                {
                    LoadProductSearch(product);
                }
                else
                {
                    EmptyProduct();
                }
            }
        }

        void LoadProductSearch(Product product)
        {
            //set other property
            lblTitle.Text = product.Title;
            lblActor.Text = product.Actors;
            lblDirector.Text = product.Directors;
            lblProduser.Text = product.Producers;
            lblReleaseDate.Text = product.ReleaseDate.ToString("dd/MM/yyyy");
            lblPrice.Text = product.SellingPrice.ToString();
            lblAvaiable.Text = product.Avaiable.ToString();
            var imagePath = AppDomain.CurrentDomain.BaseDirectory + product.ImagePath;

            if (File.Exists(imagePath))
            {
                pbProductImage.BackgroundImage = null;
                pbProductImage.ImageLocation = imagePath;
            }
            // else
            // {
            //    pbProductImage.BackgroundImage = null;
            //    pbProductImage.ImageLocation = "";
            // }

        }

        void EmptyProduct()
        {
            lblTitle.Text = "none";
            lblActor.Text = "none";
            lblDirector.Text = "none";
            lblProduser.Text = "none";
            lblReleaseDate.Text = "none";
            lblPrice.Text = "none";
            lblAvaiable.Text = "none";

            //var imagePath1 = Properties.Resources.BlankImage;

            pbProductImage.BackgroundImage = null;
            pbProductImage.Image = Properties.Resources.BlankImage;
        }

        private void FrmTest_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void miCustomerAdd_Click(object sender, EventArgs e)
        {
            new FrmAddEditCustomer().Show(this);

        }

        private void miCustomerList_Click(object sender, EventArgs e)
        {
            FrmCustomerList frm = new FrmCustomerList();
            frm.Show(this);
        }


        private void miAddCdDvd_Click(object sender, EventArgs e)
        {
            FrmAddEditProduct pro = new FrmAddEditProduct();
            pro.Show(this);
        }

        private void miCdDvdList_Click(object sender, EventArgs e)
        {
            FrmProductList list = new FrmProductList();
            list.Show(this);
        }

        private void miUserAdd_Click(object sender, EventArgs e)
        {
            FrmAddEditUser frmUser = new FrmAddEditUser();
            frmUser.Show(this);

        }

        private void miUserSearch_Click(object sender, EventArgs e)
        {
            FrmUserList frmUserList = new FrmUserList();
            frmUserList.Show(this);

        }
        private void MiMonthlyReport_Click(object sender, EventArgs e)
        {
            FrmReportPdf1 frmReportPdf = new FrmReportPdf1();
            frmReportPdf.Show(this);

        }
        private void MiMonthlyIncome_Click(object sender, EventArgs e)
        {
            new FrmMonthlyIncomeReport().Show(this);
        }
        private void MiAddEditCustomer_Click(object sender, EventArgs e)
        {
            new FrmAddEditCustomer().Show(this);
        }
        private void MiCustomerList_Click(object sender, EventArgs e)
        {
            new FrmCustomerList().Show(this);
        }

        private void btnAddCdDvd_Click(object sender, EventArgs e)
        {
            new FrmAddEditProduct().Show(this);
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            new FrmSaleProduct().Show(this);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            FrmMonthlyIncomeReport report = new FrmMonthlyIncomeReport();
            report.Show(this);
        }

        private void ddlProductSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ddlProductSearch.Text))
            {
                EmptyProduct();
            }
        }

        private void btnRentProduct_Click(object sender, EventArgs e)
        {
            FrmRentProduct rent = new FrmRentProduct();
            rent.Show(this);
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
          new FrmReturnProduct().Show(this);
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            FrmAddEditCustomer customer = new FrmAddEditCustomer();
            customer.Show(this);
        }
    }
}
