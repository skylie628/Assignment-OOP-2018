using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using RestaurantBus;
using RestaurantDAL;
using RestaurantEntity;

namespace assignmentOOP
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        public static string user;
        public static string pass;
        string strConn = "Data Source=DESKTOP-EP5NS0J;Initial Catalog=DATA;Integrated Security=True";
        SqlConnection conn = null;
        BUS_Login BusLogin = new BUS_Login();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //Xử lí sự kiện Thoát
        private void btnExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có muốn thoát chương trình không?", "Thoát",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text;
            string password = txtPass.Text;
            user = username;
            pass = password;
            if (BusLogin.Check_Manager(username, password) == true)
            {
                frmAdmin admin = new frmAdmin();
                this.Hide();
                admin.ShowDialog();
                this.Show();
            }
            else if (BusLogin.Check_Staff(username, password) == true)
            {
                frmStaff staff = new frmStaff();
                this.Hide();
                staff.ShowDialog();
                this.Show();
            }
            else
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu.");

        }


        private void btnExit_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, btnExit.ClientRectangle,
    SystemColors.ControlLightLight, 3, ButtonBorderStyle.Outset,
    SystemColors.ControlLightLight, 3, ButtonBorderStyle.Outset,
    SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
    SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset);
        }

        private void btnLogin_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, btnLogin.ClientRectangle,
           SystemColors.ControlLightLight, 3, ButtonBorderStyle.Outset,
           SystemColors.ControlLightLight, 3, ButtonBorderStyle.Outset,
           SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,
           SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset);
        }
    }
}
