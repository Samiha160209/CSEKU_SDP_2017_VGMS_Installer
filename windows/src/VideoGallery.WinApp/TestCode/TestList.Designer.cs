namespace VideoGallery.WinApp
{
    partial class TestList
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
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.txtName = new Telerik.WinControls.UI.RadTextBox();
            this.txtRoll = new Telerik.WinControls.UI.RadTextBox();
            this.txtGpa = new Telerik.WinControls.UI.RadTextBox();
            this.gvStudent = new Telerik.WinControls.UI.RadGridView();
            this.btnAdd = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGpa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStudent.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(52, 32);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(36, 18);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Name";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(52, 80);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(25, 18);
            this.radLabel2.TabIndex = 1;
            this.radLabel2.Text = "Roll";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(52, 134);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(28, 18);
            this.radLabel3.TabIndex = 2;
            this.radLabel3.Text = "GPA";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(166, 29);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(184, 20);
            this.txtName.TabIndex = 3;
            // 
            // txtRoll
            // 
            this.txtRoll.Location = new System.Drawing.Point(166, 80);
            this.txtRoll.Name = "txtRoll";
            this.txtRoll.Size = new System.Drawing.Size(184, 20);
            this.txtRoll.TabIndex = 4;
            // 
            // txtGpa
            // 
            this.txtGpa.Location = new System.Drawing.Point(166, 131);
            this.txtGpa.Name = "txtGpa";
            this.txtGpa.Size = new System.Drawing.Size(184, 20);
            this.txtGpa.TabIndex = 5;
            // 
            // gvStudent
            // 
            this.gvStudent.Location = new System.Drawing.Point(52, 181);
            // 
            // 
            // 
            this.gvStudent.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.gvStudent.Name = "gvStudent";
            this.gvStudent.Size = new System.Drawing.Size(516, 221);
            this.gvStudent.TabIndex = 6;
            this.gvStudent.Text = "radGridView1";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(418, 75);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 50);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // TestList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 437);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gvStudent);
            this.Controls.Add(this.txtGpa);
            this.Controls.Add(this.txtRoll);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Name = "TestList";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Student";
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGpa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStudent.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadTextBox txtName;
        private Telerik.WinControls.UI.RadTextBox txtRoll;
        private Telerik.WinControls.UI.RadTextBox txtGpa;
        private Telerik.WinControls.UI.RadGridView gvStudent;
        private Telerik.WinControls.UI.RadButton btnAdd;
    }
}
