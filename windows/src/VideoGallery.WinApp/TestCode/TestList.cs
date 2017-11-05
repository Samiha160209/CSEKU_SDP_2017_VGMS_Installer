using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using VideoGallery.WinApp.Utils;

namespace VideoGallery.WinApp
{
    public partial class TestList : Telerik.WinControls.UI.RadForm
    {
        List<Student> stdlist = new List<Student>();
        public TestList()
        {
            InitializeComponent();
        }

        bool IsValidToAdd()
        {

            if (txtName.Text == "")
            {
                MessageBox.Show("Type Name!");
                return false;
            }

            if (txtRoll.Text == "")
            {
                MessageBox.Show("Type roll!");
                return false;
            }
            if (txtGpa.Text == "")
            {
                MessageBox.Show("Type Gpa!");
                return false;
            }

            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Student std = new Student();
           
            if (IsValidToAdd())
            {

                
                std.name = txtName.Text;

                int x = 0;
                Int32.TryParse(txtRoll.Text, out x);
                std.roll = x;

                float y = 0;
                float.TryParse(txtGpa.Text, out y);

                std.gpa = y;
               
            }

            //make unique
            //if same name or class roll exist, srudent wil not add
            if (!stdlist.Any(x=>x.name==std.name || x.roll==std.roll))
            {
                stdlist.Add(std);
                //gvStudent.Rows.Clear();
                gvStudent.DataSource = null;

                gvStudent.DataSource = stdlist;

            }


        }
    }
}
