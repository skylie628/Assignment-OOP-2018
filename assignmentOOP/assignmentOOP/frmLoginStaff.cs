using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignmentOOP
{
    public partial class frmLoginStaff : Form
    {
        public frmLoginStaff()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if((txtUser.Text == frmLogin.user)&(txtPass.Text == frmLogin.pass))
            {
                Information info = new Information();
                this.Close();
                info.Show();
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
