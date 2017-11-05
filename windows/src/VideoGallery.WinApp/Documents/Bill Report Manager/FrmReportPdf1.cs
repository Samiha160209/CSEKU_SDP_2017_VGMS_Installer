using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace VideoGallery.WinApp.Documents.Bill_Report_Manager
{
    public partial class FrmReportPdf1 : Telerik.WinControls.UI.RadForm
    {
        public FrmReportPdf1()
        {
            InitializeComponent();
           
        }

        int totalItem = 0;
        double totalCost = 0.00;
        double totalPrice = 0.00;
        double totalProfit = 0.00;


        private void FrmReportPdf1_Load(object sender, EventArgs e)
        {
            StartDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            EndtDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59);


            dgvReportPdf.AutoGenerateColumns = false;
            //dgvReportPdf.DataSource = _App.VgmsDb.Product.ToList();//Where(x => x.Title.Contains(search) || x.Id.ToString() == search).ToList();
            //dgvReportPdf.DataSource = _App.VgmsDb.Sold.Include("Product").ToList();
            //dgvReportPdf.bi

            //LoadReport();
        }

        DateTime StartDate
        {
            get
            {
                return new DateTime(dTPickerStart.Value.Year, dTPickerStart.Value.Month, dTPickerStart.Value.Day, 0, 0, 1);
            }
            set
            {
                dTPickerStart.Value = value;
            }
        }
        DateTime EndtDate
        {
            get
            {
                return new DateTime(dTPickerEnd.Value.Year, dTPickerEnd.Value.Month, dTPickerEnd.Value.Day, 23, 59, 59);
            }
            set
            {
                dTPickerEnd.Value = value;
            }
        }

        void LoadReport()
        {
            //var invoiceList = _App.VgmsDb.Invoice.Where(x => x.CreateDate >= dTPickerStart.Value && x.CreateDate <= dTPickerEnd.Value).ToList();

            var productSoldList = _App.VgmsDb.Sold.Include("Product")
                              .Where(x => x.SaleDate >= StartDate && x.SaleDate <= EndtDate).OrderByDescending(x => x.InvoiceId).ToList();

           /* int totalItem = 0;
            var totalCost = 0.00;
            var totalPrice = 0.00;
            var totalProfit = 0.00;*/

            foreach (var item in productSoldList)
            {
                totalItem += item.Quantity;
                if (item.Product != null)
                {
                    totalCost += item.Quantity * item.Product.BuyPrice;
                }

                totalPrice += item.TotalPrice;
            }
            totalProfit = totalPrice - totalCost;

            lblItemSold.Text = totalItem.ToString();
            lblTotalCost.Text = totalCost.ToString();
            lblTotalPrice.Text = totalPrice.ToString();
            lblProfit.Text = totalProfit.ToString();

             dgvReportPdf.DataSource = null;
            dgvReportPdf.DataSource = productSoldList;
        }

        public void update()
        {
            /*dgvReportPdf.ColumnCount = 6;
            dgvReportPdf.Columns[0].Name = " Invoice Id";
            dgvReportPdf.Columns[1].Name = " Product id";
            dgvReportPdf.Columns[2].Name = " Name";
            dgvReportPdf.Columns[3].Name = " Quantity";
            dgvReportPdf.Columns[4].Name = " Total price";
            dgvReportPdf.Columns[5].Name = " Date";*/


        }

        void CreatPdf()
        {
            var pdfPath = "D://monthly_report.pdf";
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 20, 20, 50, 45);
           PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(pdfPath, FileMode.Create));
           doc.Open();
           Paragraph parag = new Paragraph("                                    REPORT OF SOLD PRODUCTS AND PROFITS\r\r\n\r"+"Start Date :" + dTPickerStart.Value + "             End Date :" + dTPickerEnd.Value + "\rSold item : "+totalItem+"\r"+"Total Profit : "+totalProfit+"\r\n\r\r");



            doc.Add(parag);

            PdfPTable table = new PdfPTable(dgvReportPdf.Columns.Count);

            for (int j = 0; j < dgvReportPdf.Columns.Count; j++)
            {
                table.AddCell(new Phrase(dgvReportPdf.Columns[j].HeaderText));
            }
            table.HeaderRows = 1;
            for(int i=0;i< dgvReportPdf.Rows.Count;i++)
            {
                for (int k = 0; k < dgvReportPdf.Columns.Count; k++)
                {
                    if (dgvReportPdf[k, i].Value != null)
                    {
                        table.AddCell(new Phrase(dgvReportPdf[k, i].Value.ToString()));
                    }
                }
            }

            doc.Add(table);
            doc.Close();
           System.Diagnostics.Process.Start(pdfPath);

        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            LoadReport();
            CreatPdf();
        }
    }
}
