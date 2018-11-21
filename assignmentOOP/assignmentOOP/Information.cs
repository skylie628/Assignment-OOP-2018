using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using RestaurantBus;
using RestaurantDAL;
using RestaurantEntity;

namespace assignmentOOP
{
    public partial class Information : Form
    {
        public Information()
        {
            InitializeComponent();
            ShowInformation(username, password);
            LockUpdateCustomer();

        }
        public string username = frmLogin.user;
        public string password = frmLogin.pass;
        string strConn = "Data Source=DESKTOP-EP5NS0J;Initial Catalog=DATA;Integrated Security=True";
        SqlConnection conn = null;
        EC_Staff etStaff = new EC_Staff();
        BUS_Staff busStaff = new BUS_Staff();
       
        void LockUpdateCustomer()
        {
            txtNameStaff.Enabled = false;
            txtPasswordStaff.Enabled = false;
            txtPhoneNumberStaff.Enabled = false;
            txtUserNameStaff.Enabled = false;
            dtpStaff.Enabled = false;
            rdStaffMale.Enabled = false;
            rdStaffWomen.Enabled = false;
            btnEditStaff.Enabled = true;
            btnSaveStaff.Enabled = false;
        }
        void UnlockUpdateCustomer()
        {
            txtNameStaff.Enabled = true;
            txtPasswordStaff.Enabled = true;
            txtPhoneNumberStaff.Enabled = true;
            txtUserNameStaff.Enabled = true;
            dtpStaff.Enabled = true;
            rdStaffMale.Enabled = true;
            rdStaffWomen.Enabled = true;
            btnEditStaff.Enabled = true;
            btnSaveStaff.Enabled = true;
        }
        void ShowInformation(string user,string pass)
        {
            UnlockUpdateCustomer();
             DataTable dt = busStaff.CreateData("Where UserName = N'"+ user +"' AND Password = N'"+ pass+"'");
             if (dt.Rows.Count > 0)
             {
                 txtNameStaff.Text = dt.Rows[0][1].ToString();
                 dtpStaff.Value = Convert.ToDateTime(dt.Rows[0][2].ToString());
                if (dt.Rows[0][3].ToString() == "nam")
                    rdStaffMale.Checked = true;
                else if (dt.Rows[0][3].ToString() == "nữ")
                    rdStaffWomen.Checked = true;
                txtPasswordStaff.Text = dt.Rows[0][5].ToString();
                txtUserNameStaff.Text = dt.Rows[0][4].ToString();
                txtPhoneNumberStaff.Text = dt.Rows[0][6].ToString();
             }
             else
                 MessageBox.Show("Da xay ra loi");
        }

        private void btnEditStaff_Click(object sender, EventArgs e)
        {
            UnlockUpdateCustomer();
        }
        void Update_User_Pass(string user,string pass)
        {
            this.username = user;
            this.password = pass;
        }
        private void btnSaveStaff_Click(object sender, EventArgs e)
        {
            string ID = busStaff.GetValue("Where username = N'" + username + "'",0);
            etStaff.Id = ID;
            etStaff.Name = txtNameStaff.Text;
            etStaff.DOB = dtpStaff.Text;
            if (rdStaffMale.Checked == true) etStaff.Sex = "nam";
            else etStaff.Sex = "nữ";
            etStaff.Phone = txtPhoneNumberStaff.Text;
            etStaff.UserName = txtUserNameStaff.Text;
            etStaff.Password = txtPasswordStaff.Text;
            Update_User_Pass(txtUserNameStaff.Text, txtPasswordStaff.Text);
            busStaff.UpdateAllStaff(etStaff);
           
            ShowInformation(username,password);
            LockUpdateCustomer();
        }
    }
}
