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
    public partial class frmCreateCustomerAccount : Form
    {
        public frmCreateCustomerAccount()
        {

            InitializeComponent();
            LockUpdateCustomer();
        }
        string strConn = "Data Source=DESKTOP-EP5NS0J;Initial Catalog=DATA;Integrated Security=True";
        SqlConnection conn = null;
        EC_Customer etCustomer = new EC_Customer();
        BUS_Customer busCustomer = new BUS_Customer();
        bool AddCustomerFlag;
        void LockFilterCustomer()
        {
            txtMemberSearch.Enabled = false;
        }
        void LockUpdateCustomer()
        {
            txtNameMember.Text = "";
            txtPhoneMember.Text = "";
            txtIdMember.Enabled = false;
            txtNameMember.Enabled = false;
            txtPhoneMember.Enabled = false;
            btnCustomerSave.Enabled = true;
            btnEditMember.Enabled = false;
            btnAddMember.Enabled = true;
        }

        void UnlockFilerCustomer()
        {
            txtMemberSearch.Enabled = true;
        }
        void UnlockUpdateCustomer()
        {
            txtNameMember.Enabled = true;
            txtPhoneMember.Enabled = true;
            btnCustomerSave.Enabled = true;
            btnEditMember.Enabled = true;
            btnAddMember.Enabled = true;
            btnSearchMember.Enabled = true;
        }
        void ShowCustomer(string condition)
        {
            dgvCustomer.DataSource = busCustomer.CreateData(condition);
        }
        string SetIdCustomer()
        {
            DataTable dt = busCustomer.CreateData("");
            if (dt.Rows.Count < 1) return "CUS00000";
            else
            {
                string s = Convert.ToString(dt.Rows[dt.Rows.Count - 1][0]);
                int id = Convert.ToInt32(s.Remove(0, 3)) + 1;
                if (id < 10) return "CUS0000" + id;
                else if (id < 100) return "CUS00" + id;
                else if (id < 1000) return "CUS0" + id;
                else return "CUS" + id;
            }
        }
        private void btnAddMember_Click(object sender, EventArgs e)
        {
            btnEditMember.Enabled = false;
            txtIdMember.Text = SetIdCustomer();
            AddCustomerFlag = true;
            UnlockUpdateCustomer();
        }

        private void btnEditMember_Click(object sender, EventArgs e)
        {
            AddCustomerFlag = false;
            UnlockUpdateCustomer();
        }

        private void btnCustomerSave_Click(object sender, EventArgs e)
        {
            etCustomer.Id = txtIdMember.Text;
            etCustomer.Name = txtNameMember.Text;
            etCustomer.DOB = dtpMember.Text;
            if (rdMemberMan.Checked == true) etCustomer.Sex = "nam";
            else etCustomer.Sex = "nữ";
            etCustomer.Phone = txtPhoneMember.Text;
            if (AddCustomerFlag == true)
            {
                etCustomer.Id = txtIdMember.Text;
                etCustomer.Name = txtNameMember.Text;
                etCustomer.DOB = dtpMember.Text;
                if (rdMemberMan.Checked == true) etCustomer.Sex = "nam";
                else etCustomer.Sex = "nữ";
                etCustomer.Phone = txtPhoneMember.Text;
                busCustomer.AddCustomer(etCustomer);
                ShowCustomer("where PhoneNumber =N'" + txtPhoneMember.Text + "'");
                LockUpdateCustomer();
            }
           /* else
            {
                etCustomer.Id = txtIdMember.Text;
                busCustomer.UpdateCustomer(etCustomer);
                ShowCustomer("");
                LockUpdateCustomer();
            }*/
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                UnlockUpdateCustomer();
                DataGridViewRow dv = dgvCustomer.Rows[e.RowIndex];
                txtIdMember.Text = dv.Cells[0].Value + "";
                txtNameMember.Text = dv.Cells[1].Value + "";
                dtpMember.Value = Convert.ToDateTime(dv.Cells[2].Value);
                if (dv.Cells[3].Value.ToString() == "nam")
                {
                    rdMemberMan.Checked = true;
                }
                else
                {
                    rdMemberWomen.Checked = true;
                }
                txtPhoneMember.Text = dv.Cells[4].Value + "";
            }
            catch { }
        }

        private void cmbSearchCustomer_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbSearchCustomer.SelectedItem.ToString() == "Tất cả") { txtMemberSearch.Enabled = false; }
            else
            {
                txtMemberSearch.Enabled = true;
            }

        }

        private void btnSearchMember_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbSearchCustomer.SelectedItem.ToString() == "Tên")
                {
                    ShowCustomer("where Name =N'" + txtMemberSearch.Text + "'");
                }
                else if (cmbSearchCustomer.SelectedItem.ToString() == "Số điện thoại")
                {
                    ShowCustomer("where PhoneNumber =N'" + txtMemberSearch.Text + "'");
                }
                else if (cmbSearchCustomer.SelectedItem.ToString() == "Tất cả")
                {
                    ShowCustomer("");
                }
            }
            catch { MessageBox.Show("xảy ra lỗi khi lọc"); }

        }

        private void dgvCustomer_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                UnlockUpdateCustomer();
                DataGridViewRow dv = dgvCustomer.Rows[e.RowIndex];
                txtIdMember.Text = dv.Cells[0].Value + "";
                txtNameMember.Text = dv.Cells[1].Value + "";
                dtpMember.Value = Convert.ToDateTime(dv.Cells[2].Value);
                if (dv.Cells[3].Value.ToString() == "nam")
                {
                    rdMemberMan.Checked = true;
                }
                else
                {
                    rdMemberWomen.Checked = true;
                }
                txtPhoneMember.Text = dv.Cells[4].Value + "";
            }
            catch { }
        }
    }
}
