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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {

            InitializeComponent();
        }
        string strConn = "Data Source=DESKTOP-EP5NS0J;Initial Catalog=DATA;Integrated Security=True";
        SqlConnection conn = null;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbStatistic.SelectedIndex == 3) {
                dtpStatistic1.Enabled = true;
                dtpStatistic2.Enabled = true;
            }
            else{
                dtpStatistic1.Enabled = false;
                dtpStatistic2.Enabled = false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void btnThongKe_Click(object sender, EventArgs e)
        {
        }

        //================================================================================//
        EC_TableFood etTable = new EC_TableFood();
        BUS_TableFood busTable = new BUS_TableFood();

        void LockTableControl()
        {
            txtSeatNumber.Enabled = false;
            btnSeatAdd.Enabled = true;
            btnSeatDelete.Enabled = false;
            btnSeatSave.Enabled = true;
        }
        void UnlockTableControl()
        {
            txtSeatNumber.Enabled = true;
            btnSeatAdd.Enabled = true;
            btnSeatDelete.Enabled = true;
            btnSeatSave.Enabled = true;
        }
        void ShowTable()
        {
            flpSeat.Controls.Clear();
            DataTable dt = busTable.CreateData("");
            int count = dt.Rows.Count;
            for (int i = 0; i < count; i++)
            {
                Button Seat = new Button();
                Seat.Size = new Size(50, 50);
                Seat.Text = "Bàn " + dt.Rows[i][0];
                Seat.Name = dt.Rows[i][0] + "";
                Seat.Click += new EventHandler(Seat_Click);
                flpSeat.Controls.Add(Seat);
            }
        }
        protected void Seat_Click(object sender, EventArgs e)
        {
            UnlockTableControl();
            Button button = sender as Button;
            txtSeatNumber.Text = button.Name;
        }
        private void btnSeatLoad_Click(object sender, EventArgs e)
        {
            etTable.Id = txtSeatNumber.Text;
            try
            {
                DataTable dt = busTable.CreateData("where Id=" + etTable.Id);
                if (dt.Rows.Count > 0) MessageBox.Show("Số bàn đã tồn tại");
                else
                {
                    busTable.AddTableFood(etTable);
                }
            }
            catch
            {
                LockTableControl();
                MessageBox.Show("Xảy ra lỗi không thể thêm bàn! ");

            }
            ShowTable();
            LockTableControl();
        }

        private void btnSeatAdd_Click(object sender, EventArgs e)
        {
            txtSeatNumber.Enabled = true;
            btnSeatDelete.Enabled = false;
        }

        private void btnSeatDelete_Click(object sender, EventArgs e)
        {
            try
            {
                etTable.Id = txtSeatNumber.Text;
                busTable.DeleteTableFood(etTable);
                ShowTable();
            }
            catch
            {
                MessageBox.Show("Không thể thêm bàn");
            }
        }


        private void btnFoodLoad_Click(object sender, EventArgs e)
        {
        }
        public int addIdFood()
        {
            if (conn == null) conn = new SqlConnection(strConn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from FOOD", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count <= 0)
            {
                return 0;
            }
            else return dt.Rows.Count;
        }
        /* public int getIDcat()
         {
             if (conn == null) conn = new SqlConnection(strConn);
             if (conn.State == ConnectionState.Closed) conn.Open();
             SqlCommand command = new SqlCommand();
             command.CommandType = CommandType.Text;
             command.CommandText = "Select * from FOODCATEGORY where Name=" + cmbCat.Selected;
             command.Connection = conn;
             SqlDataReader reader = command.ExecuteReader();
             if (reader.Read())
             {
                 return reader.GetInt32(0);
             }
             else return 0;
         } */


        private void cmbCat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void frmAdmin_Load(object sender, EventArgs e)
        {
            if (conn == null) conn = new SqlConnection(strConn);
            if (conn.State == ConnectionState.Closed) conn.Open();


        }


        private void lvFood_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void lvCountant_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer3_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        //=================================================================================//
        EC_FoodCategory etFoodCate = new EC_FoodCategory();
        BUS_FoodCate busFoodCate = new BUS_FoodCate();
        bool AddFoodCateFlag;
        private void tcThongke_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tcAdmin.SelectedIndex == 2)
            {
                LockFoodCateControl();
                ShowFoodCate();
            }
            else if (tcAdmin.SelectedIndex == 3)
            {
                LockTableControl();
                ShowTable();
            }
            else if (tcAdmin.SelectedIndex == 4)
            {
                ShowCustomer("");
                LockFilterCustomer();
                LockUpdateCustomer();
            }
            else if (tcAdmin.SelectedIndex == 5)
            {
                ShowStaff("");
                LockStaffUpdate();
                SetStaffNull();
                txtSearchStaff.Enabled = false;
            }
            else if (tcAdmin.SelectedIndex == 1)
            {
                LockFood();
                CmbFoodCateFill();
                ShowFood("");
            }
            else if (tcAdmin.SelectedIndex == 6)
            {
                ShowCode();
                LockCodeControl();
            }
        }

        void LockFoodCateControl()
        {
            txtFoodCateID.Text = "";
            txtFoodCateName.Text = "";
            txtFoodCateID.Enabled = false;
            txtFoodCateName.Enabled = false;
            btnFoodcateAdd.Enabled = true;
            btnFoodCateDelete.Enabled = false;
            btnFoodCateEdit.Enabled = false;
            btnFoodCateSave.Enabled = false;
        }
        void UnlockFoodCateControl()
        {
            txtFoodCateID.Enabled = false;
            txtFoodCateName.Enabled = true;
            btnFoodcateAdd.Enabled = true;
            btnFoodCateDelete.Enabled = true;
            btnFoodCateEdit.Enabled = true;
            btnFoodCateSave.Enabled = true;
        }
        string SetIdFoodCate()
        {
            DataTable dt = busFoodCate.CreateData("");
            if (dt.Rows.Count < 1) return "FC00";
            else
            {
                string s = Convert.ToString(dt.Rows[dt.Rows.Count - 1][0]);
                int id = Convert.ToInt32(s.Remove(0, 2)) + 1;
                if (id < 10) return "FC0" + id;
                else return "FC" + id;
            }
        }
        void setNullFoodCate()
        {
            txtFoodCateID.Text = "";
            txtFoodCateID.Text = "";
        }
        void ShowFoodCate()
        {
            dgFoodCate.DataSource = busFoodCate.CreateData("");
        }
        private void tcAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if(tcAdmin.SelectedIndex == 2)
            {
                MessageBox.Show("aaaaa");
                LockFoodCateControl();
                ShowFoodCate();
            }
            else if(tcAdmin.SelectedIndex == 3)
            {
                MessageBox.Show("aaaaa");
                LockTableControl();
                ShowTable();
            } */
        }



        private void btnFoodcateAdd_Click(object sender, EventArgs e)
        {
            UnlockFoodCateControl();
            setNullFoodCate();
            AddFoodCateFlag = true;
            txtFoodCateID.Enabled = false;
            txtFoodCateID.Text = SetIdFoodCate();
        }

        private void btnFoodCateEdit_Click(object sender, EventArgs e)
        {
            UnlockFoodCateControl();
            txtFoodCateID.Enabled = false;
            AddFoodCateFlag = false;

        }

        private void btnFoodCateDelete_Click(object sender, EventArgs e)
        {

            etFoodCate.Id = txtFoodCateID.Text;
            DataTable dt = busFood.CreateData("where ID_CATEGORY =N'" + etFoodCate.Id + "'");
            if (dt.Rows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa các mặt hàng tương ứng ? ", "Confirmation", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        etFood.Id = dt.Rows[i][0] + "";
                        busFood.DeleteFood(etFood);
                    }
                }
                else if (result == DialogResult.No)
                {
                    return;
                }
                else
                {
                    return;
                }
            }
            busFoodCate.DeleteFoodCate(etFoodCate);
            MessageBox.Show("Đã xóa thành công");
            LockFoodCateControl();
            setNullFoodCate();
            ShowFoodCate();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtFoodCateName.Text == "")
            {
                MessageBox.Show("Bạn cần nhập đủ nội dung!");
                return;
            }
            if (AddFoodCateFlag == true)
            {
                try
                {
                    etFoodCate.Id = txtFoodCateID.Text;
                    etFoodCate.Name = txtFoodCateName.Text;
                    busFoodCate.AddFoodCate(etFoodCate);
                    MessageBox.Show("Đã thêm thành công " + etFoodCate.Name);
                    setNullFoodCate();
                    LockFoodCateControl();
                    ShowFoodCate();
                }
                catch
                {
                    MessageBox.Show("Lỗi không thể thêm");
                    return;
                }
            }
            else
            {
                try
                {

                    etFoodCate.Id = txtFoodCateID.Text;
                    etFoodCate.Name = txtFoodCateName.Text;
                    busFoodCate.UpdateFoodCate(etFoodCate);
                    MessageBox.Show("Đã cập nhật thành công ");
                    setNullFoodCate();
                    LockFoodCateControl();
                    ShowFoodCate();
                }
                catch
                {
                    MessageBox.Show("Lỗi không thể Cập Nhật");
                    return;
                }
            }
        }

        private void dgFoodCate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgFoodCate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                UnlockFoodCateControl();
                DataGridViewRow dv = dgFoodCate.Rows[e.RowIndex];
                txtFoodCateID.Text = dv.Cells[0].Value + "";
                txtFoodCateName.Text = dv.Cells[1].Value + "";
            }
            catch
            {
                MessageBox.Show("Lỗi ABCXYZ");
            }
        }
        //===========================================================================//
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
            btnDeleteMember.Enabled = false;
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
            btnDeleteMember.Enabled = true;
            btnCustomerSave.Enabled = true;
            btnEditMember.Enabled = true;
            btnAddMember.Enabled = true;
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
            btnDeleteMember.Enabled = false;
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

        private void btnDeleteMember_Click(object sender, EventArgs e)
        {
            etCustomer.Id = txtIdMember.Text;
            busCustomer.DeleteCustomer(etCustomer);
            ShowCustomer("");
            LockUpdateCustomer();
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
                ShowCustomer("");
                LockUpdateCustomer();
            }
            else
            {
                etCustomer.Id = txtIdMember.Text;
                busCustomer.UpdateCustomer(etCustomer);
                ShowCustomer("");
                LockUpdateCustomer();
            }
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

        //=================================================================================//
        EC_Staff etStaff = new EC_Staff();
        BUS_Staff busStaff = new BUS_Staff();
        bool AddStaffFlag;
        void SetStaffNull()
        {
            txtIDStaff.Text = "";
            txtNameStaff.Text = "";
            txtUserNameStaff.Text = "";
            txtPasswordStaff.Text = "";
            rdStaffMale.Checked = true;
        }
        void LockStaffUpdate()
        {
            txtIDStaff.Enabled = false;
            txtNameStaff.Enabled = false;
            txtPhoneNumberStaff.Enabled = false;
            txtUserNameStaff.Enabled = false;
            txtPasswordStaff.Enabled = false;
            btnCreateStaff.Enabled = true;
            btnEditStaff.Enabled = false;
            btnDeleteStaff.Enabled = false;
            btnSaveStaff.Enabled = true;
        }
        void UnlockStaffUpdate()
        {
            txtIDStaff.Enabled = false;
            txtNameStaff.Enabled = true;
            txtPhoneNumberStaff.Enabled = true;
            txtUserNameStaff.Enabled = true;
            txtPasswordStaff.Enabled = true;
            btnCreateStaff.Enabled = true;
            btnEditStaff.Enabled = true;
            btnDeleteStaff.Enabled = true;
            btnSaveStaff.Enabled = true;
        }

        string SetIdStaff()
        {
            DataTable dt = busStaff.CreateData("");
            if (dt.Rows.Count < 1) return "STA0000";
            else
            {
                string s = Convert.ToString(dt.Rows[dt.Rows.Count - 1][0]);
                int id = Convert.ToInt32(s.Remove(0, 3)) + 1;
                if (id < 10) return "STA000" + id;
                else if (id < 100) return "STA00" + id;
                else if (id < 1000) return "STA0" + id;
                else return "STA" + id;
            }
        }
        void ShowStaff(string Condition)
        {
            dgvStaff.DataSource = busStaff.CreateData(Condition);
        }

        private void dgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UnlockStaffUpdate();
            DataGridViewRow dg = dgvStaff.Rows[e.RowIndex];
            try
            {
                txtIDStaff.Text = dg.Cells[0].Value + "";
                txtNameStaff.Text = dg.Cells[1].Value + "";
                dtpStaff.Value = Convert.ToDateTime(dg.Cells[2].Value);
                if (dg.Cells[3].Value.ToString() == "nam")
                {
                    rdStaffMale.Checked = true;
                }
                else
                {
                    rdStaffWomen.Checked = true;
                }
                txtPhoneNumberStaff.Text = dg.Cells[6].Value + "";
            }
            catch { }
        }

        private void cmbSearchStaff_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbSearchStaff.SelectedItem.ToString() == "Tất cả") { txtSearchStaff.Enabled = false; }
            else
            {
                txtSearchStaff.Enabled = true;
            }
        }

        private void btnFilterStaff_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbSearchStaff.SelectedItem.ToString() == "Tên")
                {
                    ShowStaff("where Name =N'" + txtSearchStaff.Text + "'");
                }
                else if (cmbSearchStaff.SelectedItem.ToString() == "Số điện thoại")
                {
                    ShowStaff("where PhoneNumber =N'" + txtSearchStaff.Text + "'");
                }
                else if (cmbSearchStaff.SelectedItem.ToString() == "Tất cả")
                {
                    ShowStaff("");
                }
            }
            catch
            {
                MessageBox.Show("Lọc không thành công");
            }
        }

        private void btnCreateStaff_Click(object sender, EventArgs e)
        {
            AddStaffFlag = true;
            SetStaffNull();
            txtIDStaff.Text = SetIdStaff();
            UnlockStaffUpdate();
        }

        private void btnEditStaff_Click(object sender, EventArgs e)
        {
            AddStaffFlag = false;
            btnCreateStaff.Enabled = false;
            btnDeleteStaff.Enabled = false;
        }

        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            try
            {
                etStaff.Id = txtIDStaff.Text;
                busStaff.DeleteStaff(etStaff);
                ShowStaff("");
            }
            catch
            {
                MessageBox.Show("Delete không thành công");
            }
        }

        private void btnSaveStaff_Click(object sender, EventArgs e)
        {
            etStaff.Id = txtIDStaff.Text;
            etStaff.Name = txtNameStaff.Text;
            etStaff.DOB = dtpStaff.Text;
            if (rdStaffMale.Checked == true) etStaff.Sex = "nam";
            else etStaff.Sex = "nữ";
            etStaff.Phone = txtPhoneNumberStaff.Text;
            etStaff.UserName = txtUserNameStaff.Text;
            etStaff.Password = txtPasswordStaff.Text;
            if (AddStaffFlag == true)
            {
                busStaff.AddStaff(etStaff);
                ShowStaff("");
                LockStaffUpdate();
                SetStaffNull();
            }
            else
            {
                busStaff.UpdateStaff(etStaff);
                ShowStaff("");
                LockStaffUpdate();
                SetStaffNull();
            }
        }

        // =================================================================================
        EC_Food etFood = new EC_Food();
        BUS_Food busFood = new BUS_Food();
        bool AddFoodFlag;

        void LockFood()
        {
            txtIDFood.Enabled = false;
            txtFood.Enabled = false;
            txtPrice.Enabled = false;
            btnFoodDelete.Enabled = false;
            btnFoodSave.Enabled = true;
            btnFoodAdd.Enabled = true;
            btnFoodEdit.Enabled = false;

        }
        void UnlockFood()
        {
            txtIDFood.Enabled = false;
            txtFood.Enabled = true;
            txtPrice.Enabled = true;
            btnFoodDelete.Enabled = true;
            btnFoodSave.Enabled = true;
            btnFoodAdd.Enabled = true;
            btnFoodEdit.Enabled = true;
        }
        void SetFoodNull()
        {
            txtIDFood.Text = "";
            txtFood.Text = "";
            txtPrice.Text = "";
        }
        string SetIdFood()
        {
            DataTable dt = busFood.CreateData("");
            if (dt.Rows.Count < 1) return "FO000";
            else
            {
                string s = Convert.ToString(dt.Rows[dt.Rows.Count - 1][0]);
                int id = Convert.ToInt32(s.Remove(0, 2)) + 1;
                if (id < 10) return "FO00" + id;
                else if (id < 100) return "FO0" + id;
                else return "FO" + id;
            }
        }

        private void dgvFood_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                UnlockFood();
                DataGridViewRow dv = dgvFood.Rows[e.RowIndex];
                txtIDFood.Text = dv.Cells[0].Value + "";
                txtFood.Text = dv.Cells[1].Value + "";
                txtPrice.Text = dv.Cells[2].Value + "";
                cmbCat.Text = dv.Cells[3].Value + "";
            }
            catch { }
        }
        public void CmbFoodCateFill()
        {
            DataTable dt = busFoodCate.CreateData("");
            cmbCat.DataSource = dt;
            cmbCat.DisplayMember = "Name";
            cmbCat.ValueMember = "Id";
        }
        public void ShowFood(string conn)
        {
            dgvFood.Rows.Clear();
            dgvFood.Refresh();
            DataTable dt = busFood.CreateData(conn);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataGridViewRow dvr = new DataGridViewRow();
                dvr.CreateCells(dgvFood);
                dvr.Cells[0].Value = dt.Rows[i][0] + "";
                dvr.Cells[1].Value = dt.Rows[i][1] + "";
                dvr.Cells[2].Value = dt.Rows[i][2] + "";
                string temp = dt.Rows[i][3].ToString();
                dvr.Cells[3].Value = busFoodCate.GetValue("where ID= N'" + temp + "'", 1);
                dgvFood.Rows.Add(dvr);
            }
        }
        private void btnFoodAdd_Click(object sender, EventArgs e)
        {
            SetFoodNull();
            UnlockFood();
            ShowFood("");
            txtIDFood.Text = SetIdFood();
            AddFoodFlag = true;
            btnFoodDelete.Enabled = false;
            txtFoodSearch.Enabled = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (AddFoodFlag)
            {
                etFood.Id = txtIDFood.Text;
                etFood.Name = txtFood.Text;
                etFood.Price = (float)Convert.ToDouble(txtPrice.Text);
                etFood.Cate = cmbCat.SelectedValue + "";
                busFood.AddFood(etFood);
                ShowFood("");
            }
            else
            {
                etFood.Id = txtIDFood.Text;
                etFood.Name = txtFood.Text;
                etFood.Price = (float)Convert.ToDouble(txtPrice.Text);
                etFood.Cate = cmbCat.SelectedValue + "";
                busFood.UpdateFood(etFood);
                ShowFood("");
            }
            LockFood();
            SetFoodNull();
        }

        private void btnFoodDelete_Click(object sender, EventArgs e)
        {
            etFood.Id = txtIDFood.Text;
            busFood.DeleteFood(etFood);
            ShowFood("");
        }

        private void btnFoodEdit_Click(object sender, EventArgs e)
        {
            AddFoodFlag = false;
        }

        private void btnsearchfood_Click(object sender, EventArgs e)
        {
            if (txtFoodSearch.Text == "") ShowFood("");
            else
            {
                etFood.Name = txtFoodSearch.Text;
                ShowFood("where Name=N'" + etFood.Name + "'");
            }
        }

        //=================================CODE==============================================

        EC_CODE etCode = new EC_CODE();
        BUS_Code busCode = new BUS_Code();
        bool FlagAddCode;
        void ShowCode()
        {
            dgvCode.DataSource = busCode.CreateData("");
        }
        void setNullCode()
        {
            txtIdCode.Text = "";
            txtNameCode.Text = "";
            txtAmountCode.Text = "";
        }
        void LockCodeControl()
        {
            setNullCode();
            txtIdCode.Enabled = false;
            txtAmountCode.Enabled = false;
            txtNameCode.Enabled = false;
            rdValid.Checked = true;
            btnDeleteCode.Enabled = false;
            btnSaveCode.Enabled = true;
            btnAddCode.Enabled = true;
            btnEditCode.Enabled = false;
        }
        void UnlockCodeControl()
        {
            txtIdCode.Enabled = false;
            txtAmountCode.Enabled = true;
            txtNameCode.Enabled = true;
            rdValid.Checked = true;
            btnDeleteCode.Enabled = true;
            btnSaveCode.Enabled = true;
            btnAddCode.Enabled = true;
            btnEditCode.Enabled = true;
        }
        string SetIdCode()
        {
            DataTable dt = busCode.CreateData("");
            if (dt.Rows.Count < 1) return "CO000";
            else
            {
                string s = Convert.ToString(dt.Rows[dt.Rows.Count - 1][0]);
                int id = Convert.ToInt32(s.Remove(0, 2)) + 1;
                if (id < 10) return "CO00" + id;
                else if (id < 100) return "CO0";
                else return "CO" + id;
            }
        }
        private void dgvCode_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                UnlockCodeControl();
                DataGridViewRow dgv = dgvCode.Rows[e.RowIndex];
                txtIdCode.Text = dgv.Cells[0].Value + "";
                txtNameCode.Text = dgv.Cells[1].Value + "";
                txtAmountCode.Text = dgv.Cells[2].Value + "";
                if (dgv.Cells[3].Value + "" == "1")
                {
                    rdValid.Checked = true;
                }
                else
                {
                    rdInvalid.Checked = true;
                }
            }
            catch{ }
        }

        private void btnAddCode_Click(object sender, EventArgs e)
        {
            UnlockCodeControl();
            setNullCode();
            txtIdCode.Text = SetIdCode();
            FlagAddCode = true;
        }

        private void btnEditCode_Click(object sender, EventArgs e)
        {
            FlagAddCode = false;
        }

        private void btnSaveCode_Click(object sender, EventArgs e)
        {
            etCode.ID = txtIdCode.Text;
            etCode.NameCode = txtNameCode.Text;
            etCode.Amount = int.Parse(txtAmountCode.Text);
            if (rdValid.Checked == true)
            {
                etCode.Status = 1;
            }
            else
            {
                etCode.Status = 0;
            }
            if (FlagAddCode)
            {
                busCode.AddCode(etCode);
            }
            else
            {
                busCode.UpdateCode(etCode);
            }
            ShowCode();
            LockCodeControl();
        }

        private void btnDeleteCode_Click(object sender, EventArgs e)
        {
            etCode.ID = txtIdCode.Text;
            busCode.DeleteCode(etCode);
            ShowCode();
            setNullCode();
            LockCodeControl();
        }
        //==============================Statistic=================================================
        BUS_BILL busBill = new BUS_BILL();
        EC_Bill etBill = new EC_Bill();
        void ShowStatistic(string condition)
        {
            DataTable dt = busBill.CreateData(condition);
            dt.Columns.RemoveAt(3);
            dt.Columns.RemoveAt(3);
            dgvStatistic.DataSource = dt;
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            if (cbStatistic.SelectedIndex == 0)
            {
                DateTime dt = DateTime.Now;
                DateTime dt1 = dt.AddDays(-1);
                string s = dt.ToString("MM-dd-yyyy HH:mm:ss");
                string s1 = dt1.ToString("MM-dd-yyyy HH:mm:ss");
                ShowStatistic("where DateBill between N'" + s1 + "' and N'" + s + "'");
            }
            else if (cbStatistic.SelectedIndex == 1)
            {
                DateTime dt = DateTime.Now;
                DateTime dt1 = dt.AddDays(-7);
                string s = dt.ToString("MM-dd-yyyy HH:mm:ss");
                string s1 = dt1.ToString("MM-dd-yyyy HH:mm:ss");
                ShowStatistic("where DateBill between N'" + s1 + "' and N'" + s + "'");
            }
            else if (cbStatistic.SelectedIndex == 2)
            {
                DateTime dt = DateTime.Now;
                DateTime dt1 = dt.AddDays(-30);
                string s = dt.ToString("MM-dd-yyyy HH:mm:ss");
                MessageBox.Show(s + "");
                string s1 = dt1.ToString("MM-dd-yyyy HH:mm:ss");
                ShowStatistic("where DateBill between N'" + s1 + "' and N'" + s + "'");
            }
            else if (cbStatistic.SelectedIndex == 3)
            {
                string s = dtpStatistic1.Value.ToString("MM-dd-yyyy") + " 00:00:00";
                string s1 = dtpStatistic2.Value.ToString("MM-dd-yyyy") + " 00:00:00";
                MessageBox.Show(s + "");
                ShowStatistic("where DateBill between N'" + s + "' and N'" + s1 + "'");
            }
            double revenue = RevenueSum();
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
            decimal value = decimal.Parse(Convert.ToString(revenue), System.Globalization.NumberStyles.AllowThousands);
            txtRevenue.Text = String.Format(culture, "{0:N0}", value);
            txtAmountBill.Text = dgvStatistic.Rows.Count-1+"";
        }
        double RevenueSum()
        {
            double price = 0;
            for (int i = 0; i < dgvStatistic.Rows.Count; i++)
            {
                DataGridViewRow dvr = dgvStatistic.Rows[i];
                price +=  Convert.ToDouble(dvr.Cells[3].Value);
            }
            return price;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbSearchCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void txtMemberSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }  
}
