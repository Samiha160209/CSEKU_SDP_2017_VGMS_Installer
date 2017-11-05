namespace VideoGallery.WinApp.Documents.RentManager
{
    partial class FrmReturnProduct
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.ddlCustomer = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel17 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.lblReturned = new Telerik.WinControls.UI.RadLabel();
            this.lblRented = new Telerik.WinControls.UI.RadLabel();
            this.lblUnreturnted = new Telerik.WinControls.UI.RadLabel();
            this.gvProduct = new Telerik.WinControls.UI.RadGridView();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.btnAllUnreturned = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.ddlCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblReturned)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblRented)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblUnreturnted)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProduct.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAllUnreturned)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // ddlCustomer
            // 
            this.ddlCustomer.AutoSize = false;
            this.ddlCustomer.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlCustomer.Location = new System.Drawing.Point(166, 38);
            this.ddlCustomer.Name = "ddlCustomer";
            this.ddlCustomer.NullText = "Type Customer Title to Search";
            this.ddlCustomer.Size = new System.Drawing.Size(258, 26);
            this.ddlCustomer.TabIndex = 45;
            this.ddlCustomer.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.ddlCustomer_SelectedIndexChanged);
            // 
            // radLabel17
            // 
            this.radLabel17.BackColor = System.Drawing.Color.Transparent;
            this.radLabel17.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel17.ForeColor = System.Drawing.Color.White;
            this.radLabel17.Location = new System.Drawing.Point(57, 38);
            this.radLabel17.Name = "radLabel17";
            this.radLabel17.Size = new System.Drawing.Size(86, 26);
            this.radLabel17.TabIndex = 44;
            this.radLabel17.Text = "Customer : ";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(74, 159);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(118, 26);
            this.radLabel1.TabIndex = 46;
            this.radLabel1.Text = "Total Returned :";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(89, 92);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(103, 26);
            this.radLabel2.TabIndex = 46;
            this.radLabel2.Text = "Total Rented :";
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel3.Location = new System.Drawing.Point(57, 125);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(135, 26);
            this.radLabel3.TabIndex = 46;
            this.radLabel3.Text = "Total Unreturned :";
            // 
            // lblReturned
            // 
            this.lblReturned.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturned.Location = new System.Drawing.Point(216, 159);
            this.lblReturned.Name = "lblReturned";
            this.lblReturned.Size = new System.Drawing.Size(26, 26);
            this.lblReturned.TabIndex = 46;
            this.lblReturned.Text = "00";
            // 
            // lblRented
            // 
            this.lblRented.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRented.Location = new System.Drawing.Point(216, 92);
            this.lblRented.Name = "lblRented";
            this.lblRented.Size = new System.Drawing.Size(26, 26);
            this.lblRented.TabIndex = 46;
            this.lblRented.Text = "00";
            // 
            // lblUnreturnted
            // 
            this.lblUnreturnted.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnreturnted.Location = new System.Drawing.Point(216, 125);
            this.lblUnreturnted.Name = "lblUnreturnted";
            this.lblUnreturnted.Size = new System.Drawing.Size(26, 26);
            this.lblUnreturnted.TabIndex = 46;
            this.lblUnreturnted.Text = "00";
            // 
            // gvProduct
            // 
            this.gvProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gvProduct.Cursor = System.Windows.Forms.Cursors.Default;
            this.gvProduct.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold);
            this.gvProduct.ForeColor = System.Drawing.Color.Black;
            this.gvProduct.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gvProduct.Location = new System.Drawing.Point(12, 216);
            // 
            // 
            // 
            this.gvProduct.MasterTemplate.AllowAddNewRow = false;
            this.gvProduct.MasterTemplate.AllowCellContextMenu = false;
            this.gvProduct.MasterTemplate.AllowDeleteRow = false;
            this.gvProduct.MasterTemplate.AllowDragToGroup = false;
            this.gvProduct.MasterTemplate.AllowEditRow = false;
            this.gvProduct.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "CName";
            gridViewTextBoxColumn1.HeaderText = "Customer";
            gridViewTextBoxColumn1.Name = "CName";
            gridViewTextBoxColumn1.Width = 129;
            gridViewTextBoxColumn2.FieldName = "PTitle";
            gridViewTextBoxColumn2.HeaderText = "Product Name";
            gridViewTextBoxColumn2.Name = "PTitle";
            gridViewTextBoxColumn2.Width = 152;
            gridViewTextBoxColumn3.FieldName = "Quantity";
            gridViewTextBoxColumn3.HeaderText = "Quantity";
            gridViewTextBoxColumn3.Name = "Quantity";
            gridViewTextBoxColumn3.Width = 70;
            gridViewTextBoxColumn4.FieldName = "RentDate";
            gridViewTextBoxColumn4.HeaderText = "Rent Date";
            gridViewTextBoxColumn4.Name = "RentDate";
            gridViewTextBoxColumn4.Width = 94;
            gridViewTextBoxColumn5.FieldName = "ReturnDate";
            gridViewTextBoxColumn5.HeaderText = "Return Date";
            gridViewTextBoxColumn5.Name = "ReturnDate";
            gridViewTextBoxColumn5.Width = 94;
            gridViewTextBoxColumn6.FieldName = "RentAmount";
            gridViewTextBoxColumn6.HeaderText = "Rent Amount";
            gridViewTextBoxColumn6.Name = "RentAmount";
            gridViewTextBoxColumn6.Width = 94;
            this.gvProduct.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6});
            this.gvProduct.MasterTemplate.EnableGrouping = false;
            this.gvProduct.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.gvProduct.Name = "gvProduct";
            this.gvProduct.ReadOnly = true;
            this.gvProduct.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gvProduct.Size = new System.Drawing.Size(648, 243);
            this.gvProduct.TabIndex = 47;
            this.gvProduct.Text = "radGridView1";
            // 
            // radButton1
            // 
            this.radButton1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radButton1.Location = new System.Drawing.Point(470, 155);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(142, 42);
            this.radButton1.TabIndex = 48;
            this.radButton1.Text = "Receive";
            this.radButton1.Click += new System.EventHandler(this.btnReturnProduct_Click);
            // 
            // btnAllUnreturned
            // 
            this.btnAllUnreturned.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllUnreturned.Location = new System.Drawing.Point(470, 38);
            this.btnAllUnreturned.Name = "btnAllUnreturned";
            this.btnAllUnreturned.Size = new System.Drawing.Size(142, 41);
            this.btnAllUnreturned.TabIndex = 49;
            this.btnAllUnreturned.Text = "All Unreturned";
            this.btnAllUnreturned.Click += new System.EventHandler(this.btnAllUnreturned_Click);
            // 
            // FrmReturnProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(672, 471);
            this.Controls.Add(this.btnAllUnreturned);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.gvProduct);
            this.Controls.Add(this.lblUnreturnted);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.lblRented);
            this.Controls.Add(this.lblReturned);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.ddlCustomer);
            this.Controls.Add(this.radLabel17);
            this.Name = "FrmReturnProduct";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "FrmReturnProduct";
            this.Load += new System.EventHandler(this.FrmReturnProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ddlCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblReturned)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblRented)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblUnreturnted)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProduct.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAllUnreturned)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadDropDownList ddlCustomer;
        private Telerik.WinControls.UI.RadLabel radLabel17;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel lblReturned;
        private Telerik.WinControls.UI.RadLabel lblRented;
        private Telerik.WinControls.UI.RadLabel lblUnreturnted;
        private Telerik.WinControls.UI.RadGridView gvProduct;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadButton btnAllUnreturned;
    }
}
