using System;
using System.Linq;
using System.Windows.Forms;
using VideoGallery.WinApp.Data;

namespace VideoGallery.WinApp
{
    public partial class FrmTest : Form
    {

        public enum GenderEnum
        {
            Male=0,
            Female=1,
            Other=2
        }
        public FrmTest()
        {
            InitializeComponent();
           

        }
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            ddlGender.DataSource = Enum.GetValues(typeof(GenderEnum)); 
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if(txtName.Text=="")
            {
                MessageBox.Show("Type Name!");
                return;
            }

            if (txtEmail.Text == "")
            {
                MessageBox.Show("Type Email!");
                return;
            }
            if(!txtEmail.Text.Contains("@")||!txtEmail.Text.Contains("."))
            {
                MessageBox.Show("Invalid Email!");
                return;
            }

            if(txtPass.Text=="")
            {
                MessageBox.Show("Type Password!");
                return;
            }

            if(txtPass.Text!=txtRePass.Text)
            {
                MessageBox.Show("Password not matched!!");
                return;
            }

            if(txtMobile.Text=="")
            {
                MessageBox.Show("Type Mobile number!");
                return;
            }

            if(dtpDob.Value>=DateTime.Now)
            {
                MessageBox.Show("Invalid DOB!");
                return;
            }

           
            //data save to userinfo
            UserInfo userInfo = new UserInfo();

            userInfo.FullName = txtName.Text;
            userInfo.UserName = txtUserName.Text;
            userInfo.Password = txtPass.Text;
            userInfo.Email = txtEmail.Text;
            userInfo.Mobile = txtMobile.Text;
            userInfo.Dob = dtpDob.Value;

            GenderEnum gender = (GenderEnum)ddlGender.SelectedItem;
            userInfo.GenderEnumId = (int)gender;
            //data save to database
            VgmsDbContext vgmsDb = new VgmsDbContext();
            vgmsDb.UserInfo.Add(userInfo);
            vgmsDb.SaveChanges();


            MessageBox.Show("Saved");

        }
    }
}
