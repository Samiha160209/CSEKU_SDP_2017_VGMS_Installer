namespace VideoGallery.WinApp.Documents.Bill_Report_Manager
{
    partial class FrmReportPdf1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvReportPdf = new System.Windows.Forms.DataGridView();
            this.InvoiceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qualtity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblProfit = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblItemSold = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnShow = new Telerik.WinControls.UI.RadButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dTPickerStart = new Telerik.WinControls.UI.RadDateTimePicker();
            this.dTPickerEnd = new Telerik.WinControls.UI.RadDateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportPdf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTPickerStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTPickerEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReportPdf
            // 
            this.dgvReportPdf.AllowUserToAddRows = false;
            this.dgvReportPdf.AllowUserToDeleteRows = false;
            this.dgvReportPdf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportPdf.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InvoiceId,
            this.ProductId,
            this.PName,
            this.Qualtity,
            this.TotalPrice,
            this.Date});
            this.dgvReportPdf.Location = new System.Drawing.Point(51, 190);
            this.dgvReportPdf.Name = "dgvReportPdf";
            this.dgvReportPdf.ReadOnly = true;
            this.dgvReportPdf.Size = new System.Drawing.Size(646, 260);
            this.dgvReportPdf.TabIndex = 41;
            // 
            // InvoiceId
            // 
            this.InvoiceId.DataPropertyName = "InvoiceId";
            this.InvoiceId.HeaderText = "InvoiceId";
            this.InvoiceId.Name = "InvoiceId";
            this.InvoiceId.ReadOnly = true;
            // 
            // ProductId
            // 
            this.ProductId.DataPropertyName = "PId";
            this.ProductId.HeaderText = "ProductId";
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            // 
            // PName
            // 
            this.PName.DataPropertyName = "PTitle";
            this.PName.HeaderText = "Product Name";
            this.PName.Name = "PName";
            this.PName.ReadOnly = true;
            // 
            // Qualtity
            // 
            this.Qualtity.DataPropertyName = "Quantity";
            this.Qualtity.HeaderText = "Quantity";
            this.Qualtity.Name = "Qualtity";
            this.Qualtity.ReadOnly = true;
            // 
            // TotalPrice
            // 
            this.TotalPrice.DataPropertyName = "TotalPrice";
            this.TotalPrice.HeaderText = "Price";
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "SaleDate";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.Location = new System.Drawing.Point(221, 140);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(52, 28);
            this.lblTotalCost.TabIndex = 33;
            this.lblTotalCost.Text = "0.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(76, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 28);
            this.label4.TabIndex = 34;
            this.label4.Text = "Total Item Cost :";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.PaleGreen;
            this.lblTotalPrice.Location = new System.Drawing.Point(456, 100);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(52, 28);
            this.lblTotalPrice.TabIndex = 35;
            this.lblTotalPrice.Text = "0.00";
            // 
            // lblProfit
            // 
            this.lblProfit.AutoSize = true;
            this.lblProfit.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfit.ForeColor = System.Drawing.Color.Red;
            this.lblProfit.Location = new System.Drawing.Point(446, 140);
            this.lblProfit.Name = "lblProfit";
            this.lblProfit.Size = new System.Drawing.Size(52, 28);
            this.lblProfit.TabIndex = 36;
            this.lblProfit.Text = "0.00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(329, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 28);
            this.label9.TabIndex = 37;
            this.label9.Text = "Total Profit :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.PaleGreen;
            this.label7.Location = new System.Drawing.Point(329, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 28);
            this.label7.TabIndex = 38;
            this.label7.Text = "Total Cash In :";
            // 
            // lblItemSold
            // 
            this.lblItemSold.AutoSize = true;
            this.lblItemSold.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemSold.Location = new System.Drawing.Point(227, 100);
            this.lblItemSold.Name = "lblItemSold";
            this.lblItemSold.Size = new System.Drawing.Size(24, 28);
            this.lblItemSold.TabIndex = 39;
            this.lblItemSold.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 28);
            this.label3.TabIndex = 40;
            this.label3.Text = "Total Item Sold :";
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(593, 60);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(110, 46);
            this.btnShow.TabIndex = 32;
            this.btnShow.Text = "Create Pdf";
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(344, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 28;
            this.label2.Text = "End Date :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 29;
            this.label1.Text = "Start Date :";
            // 
            // dTPickerStart
            // 
            this.dTPickerStart.CustomFormat = "dd-MM-yyyy";
            this.dTPickerStart.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPickerStart.Location = new System.Drawing.Point(119, 56);
            this.dTPickerStart.Name = "dTPickerStart";
            this.dTPickerStart.Size = new System.Drawing.Size(203, 25);
            this.dTPickerStart.TabIndex = 30;
            this.dTPickerStart.TabStop = false;
            this.dTPickerStart.Text = "09-04-2017";
            this.dTPickerStart.Value = new System.DateTime(2017, 4, 9, 23, 17, 29, 469);
            // 
            // dTPickerEnd
            // 
            this.dTPickerEnd.CustomFormat = "dd-MM-yyyy";
            this.dTPickerEnd.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPickerEnd.Location = new System.Drawing.Point(420, 58);
            this.dTPickerEnd.Name = "dTPickerEnd";
            this.dTPickerEnd.Size = new System.Drawing.Size(147, 25);
            this.dTPickerEnd.TabIndex = 31;
            this.dTPickerEnd.TabStop = false;
            this.dTPickerEnd.Text = "09-04-2017";
            this.dTPickerEnd.Value = new System.DateTime(2017, 4, 9, 23, 17, 29, 479);
            // 
            // FrmReportPdf1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(740, 464);
            this.Controls.Add(this.dgvReportPdf);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblProfit);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblItemSold);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dTPickerStart);
            this.Controls.Add(this.dTPickerEnd);
            this.Name = "FrmReportPdf1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "FrmReportPdf1";
            this.Load += new System.EventHandler(this.FrmReportPdf1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportPdf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTPickerStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTPickerEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReportPdf;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblProfit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblItemSold;
        private System.Windows.Forms.Label label3;
        private Telerik.WinControls.UI.RadButton btnShow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadDateTimePicker dTPickerStart;
        private Telerik.WinControls.UI.RadDateTimePicker dTPickerEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qualtity;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
    }
}
