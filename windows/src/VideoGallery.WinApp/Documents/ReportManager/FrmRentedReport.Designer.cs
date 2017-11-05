namespace VideoGallery.WinApp.Documents.ReportManager
{
    partial class FrmRentedReport
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.gvProduct = new Telerik.WinControls.UI.RadGridView();
            this.ddlCustomer = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel17 = new Telerik.WinControls.UI.RadLabel();
            this.radDropDownList1 = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProduct.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // gvProduct
            // 
            this.gvProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvProduct.BackColor = System.Drawing.Color.White;
            this.gvProduct.Cursor = System.Windows.Forms.Cursors.Default;
            this.gvProduct.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold);
            this.gvProduct.ForeColor = System.Drawing.Color.Black;
            this.gvProduct.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gvProduct.Location = new System.Drawing.Point(61, 125);
            // 
            // 
            // 
            this.gvProduct.MasterTemplate.AllowAddNewRow = false;
            this.gvProduct.MasterTemplate.AllowCellContextMenu = false;
            this.gvProduct.MasterTemplate.AllowDeleteRow = false;
            this.gvProduct.MasterTemplate.AllowDragToGroup = false;
            this.gvProduct.MasterTemplate.AllowEditRow = false;
            this.gvProduct.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.gvProduct.MasterTemplate.EnableGrouping = false;
            this.gvProduct.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.gvProduct.Name = "gvProduct";
            this.gvProduct.ReadOnly = true;
            this.gvProduct.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gvProduct.Size = new System.Drawing.Size(519, 245);
            this.gvProduct.TabIndex = 50;
            this.gvProduct.Text = "radGridView1";
            // 
            // ddlCustomer
            // 
            this.ddlCustomer.AutoSize = false;
            this.ddlCustomer.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlCustomer.Location = new System.Drawing.Point(182, 30);
            this.ddlCustomer.Name = "ddlCustomer";
            this.ddlCustomer.NullText = "Type Customer Title to Search";
            this.ddlCustomer.Size = new System.Drawing.Size(258, 26);
            this.ddlCustomer.TabIndex = 49;
            // 
            // radLabel17
            // 
            this.radLabel17.BackColor = System.Drawing.Color.Transparent;
            this.radLabel17.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel17.ForeColor = System.Drawing.Color.White;
            this.radLabel17.Location = new System.Drawing.Point(73, 30);
            this.radLabel17.Name = "radLabel17";
            this.radLabel17.Size = new System.Drawing.Size(86, 26);
            this.radLabel17.TabIndex = 48;
            this.radLabel17.Text = "Customer : ";
            // 
            // radDropDownList1
            // 
            this.radDropDownList1.AutoSize = false;
            this.radDropDownList1.Location = new System.Drawing.Point(182, 76);
            this.radDropDownList1.Name = "radDropDownList1";
            this.radDropDownList1.Size = new System.Drawing.Size(165, 26);
            this.radDropDownList1.TabIndex = 51;
            this.radDropDownList1.Text = "radDropDownList1";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.ForeColor = System.Drawing.Color.White;
            this.radLabel1.Location = new System.Drawing.Point(110, 76);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(49, 26);
            this.radLabel1.TabIndex = 52;
            this.radLabel1.Text = "Type :";
            // 
            // FrmRentedReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(646, 398);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.radDropDownList1);
            this.Controls.Add(this.gvProduct);
            this.Controls.Add(this.ddlCustomer);
            this.Controls.Add(this.radLabel17);
            this.Name = "FrmRentedReport";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "FrmRentedReport";
            ((System.ComponentModel.ISupportInitialize)(this.gvProduct.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView gvProduct;
        private Telerik.WinControls.UI.RadDropDownList ddlCustomer;
        private Telerik.WinControls.UI.RadLabel radLabel17;
        private Telerik.WinControls.UI.RadDropDownList radDropDownList1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
    }
}
