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
    public partial class frmStaff : Form
    {
        public frmStaff()
        {
            InitializeComponent();
            this.btnbook.DragDrop += new
           System.Windows.Forms.DragEventHandler(this.btnbook_DragDrop);
        }
        string strConn = "Data Source = DESKTOP-Q9KMPT9; Database = DATA; Integrated Security = True ";
        SqlConnection conn = null;
        EC_TableFood etTable = new EC_TableFood();
        BUS_TableFood busTable = new BUS_TableFood();
        EC_FoodCategory etFoodcate = new EC_FoodCategory();
        BUS_FoodCate busFoodcate = new BUS_FoodCate();
        EC_Food etFood = new EC_Food();
        BUS_Food busFood = new BUS_Food();
        EC_Customer etCus = new EC_Customer();
        BUS_Customer busCus = new BUS_Customer();
        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }
        void showTable()
        {
            flpSeat.Controls.Clear();
            DataTable dt = busTable.CreateData("");
            int count = dt.Rows.Count;
            for (int i = 0; i < count; i++)
            {
                Button Seat = new Button();
                Seat.AllowDrop = true;
                Seat.Tag = dt.Rows[i][0];
                Seat.Text = "Bàn " + dt.Rows[i][0];
                Seat.Name = "btnSeat" + dt.Rows[i][0];
                Seat.Name = dt.Rows[i][0] + "";
                Seat.FlatAppearance.BorderSize = 0;
                Seat.Click += new EventHandler(Seat_Click);
                Seat.DragEnter += new DragEventHandler(Seat_DragEnter);
                Seat.DragDrop += new DragEventHandler(Seat_DragDrop);
                Seat.MouseDown += new MouseEventHandler(Seat_MouseDown);
                Seat.FlatAppearance.BorderColor = Color.FromArgb(1, 120, 120, 120);
                if (IsTableNotAvailable(dt.Rows[i][0]+""))
                {
                    Seat.BackColor = Color.Red;
                }
                else { Seat.BackColor = Color.Blue; }
                flpSeat.Controls.Add(Seat);
            }
        }
        protected void Seat_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            setEnable();
            setNulladd();
            txtSeat.Text = button.Name;
        }
       protected void Seat_MouseDown(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.DoDragDrop(button.Tag, DragDropEffects.Copy);
        }
        protected void Seat_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
        protected void Seat_DragDrop(object sender, DragEventArgs e)
        {
            Button button = sender as Button;
            string src = (string)e.Data.GetData(DataFormats.Text);
            String des = button.Tag+"";
            //MessageBox.Show(src + " " + des + " ");
            if (src == des)
            {
                setEnable();
                setNulladd();
                txtSeat.Text = button.Name;
            }
            else
            {
                if (IsTableNotAvailable(src) && IsTableNotAvailable(des))
                {
                    MessageBox.Show("aaaaaa");
                    combineSeat(src, des);
                }
                else if (IsTableNotAvailable(src) && !IsTableNotAvailable(des))
                {
                    MessageBox.Show(src + " " + des);
                    moveSeat(src, des);
                }
            }
        }
        private void frmStaff_Load(object sender, EventArgs e)
        {
            showTable();
            cmFoodCate_Fill();
            setDisable();
        }
        private void cmFoodCate_Fill()
        {
            DataTable dt = busFoodcate.CreateData("");
            DataRow row = dt.NewRow();
            row[0] = "";
            row[1] = "Tất cả";
            dt.Rows.InsertAt(row, 0);
            cmFoodCate.DataSource = dt;
            cmFoodCate.DisplayMember = "Name";
            cmFoodCate.ValueMember = "ID";
            this.cmFoodCate.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.cmFoodCate.AutoCompleteSource = AutoCompleteSource.ListItems;

        }

        private void cmFoodCate_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvFood.Controls.Clear();
            DataTable dt;
            if (cmFoodCate.SelectedValue == "") dt = busFood.CreateData("");
            else dt = busFood.CreateData("where ID_CATEGORY= N'" + cmFoodCate.SelectedValue + "'");
            dt.Columns.RemoveAt(0);
            dt.Columns.RemoveAt(2);
            dgvFood.DataSource = dt;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = busFood.CreateData("where contains (Name,N'" + txtSearchFood.Text + "')");
            dgvFood.DataSource = dt;
        }
        private void txtSearchFood_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgvFood.Controls.Clear();
                DataTable dt;
                if (txtSearchFood.Text == "") dt = busFood.CreateData("");
                else dt = busFood.CreateData("where contains (Name,N'" + txtSearchFood.Text + "')");
                dt.Columns.RemoveAt(0);
                dt.Columns.RemoveAt(2);
                dgvFood.DataSource = dt;
            }
            catch { }
        }
        void setNulladd()
        {
            cmbnumber.SelectedIndex = 0;
            txtNote.Text = "";
        }
        void setDisable()
        {
            btnCombine.Enabled = false;
            btnChange.Enabled = false;
            btnbook.Enabled = false;
            btnPrintbill.Enabled = false;
            btnDelete.Enabled = false;
            btnprintfood.Enabled = false;
            txtmember.Enabled = false;
            txtSum.Enabled = false;
            txtDiscount.Enabled = false;
            txtTotalAmont.Enabled = false;
            txtSearchFood.Enabled = false;
            txtNote.Enabled = false;
            cmbnumber.Enabled = false;
        }
        void setEnable()
        {
            btnCombine.Enabled = true;
            btnbook.Enabled = true;
            btnPrintbill.Enabled = true;
            btnDelete.Enabled = true;
            btnprintfood.Enabled = true;
            txtmember.Enabled = true;
            txtSum.Enabled = false;
            txtDiscount.Enabled = true;
            txtTotalAmont.Enabled = false;
            txtSearchFood.Enabled = true;
            txtNote.Enabled = true;
            cmbnumber.Enabled = true;
        }
        private void dgvFood_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow dv = dgvFood.Rows[e.RowIndex];
            DataGridViewRow dvr = new DataGridViewRow();
            dvr.CreateCells(dgvFoodSelected);
            dvr.Cells[0].Value = dv.Cells[0].Value + "";
            dvr.Cells[1].Value = cmbnumber.Text;
            dvr.Cells[2].Value = dv.Cells[1].Value + "";
            dvr.Cells[3].Value = txtNote.Text;
            dgvFoodSelected.Rows.Add(dvr);
            if (IsTableNotAvailable(txtSeat.Text))
            {
                etBillInfo.Id = setIdBillInfo();
                string table = txtSeat.Text;
                etBillInfo.IdBill = getIDbillfromTable(table);
                etBillInfo.Count = int.Parse(dvr.Cells[1].Value + "");
                etBillInfo.IdFood = busFood.GetValue("where Name=N'" + dvr.Cells[0].Value + "'", 0);
                etBillInfo.Note = dvr.Cells[3].Value + "";
                busBillInfo.AddBill(etBillInfo);
            }
            updatePrice();
            setNulladd();
        }
    bool IsTableNotAvailable(string i)
        {
            DataTable dt = busBill.CreateData("where IDTable= N'" + i + "' and Status = 0");
            if (dt.Rows.Count < 1) return false;
            else return true;
        }
        string getIDbillfromTable(string table) {
            DataTable dt = busBill.CreateData("where IDTable= N'" + table + "' and Status = 0");
            if (dt.Rows.Count < 1) return "";
            else return dt.Rows[0][0].ToString();
        } 
        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            {
                int index = dgvFoodSelected.CurrentCell.RowIndex;
                if (IsTableNotAvailable(txtSeat.Text))
                {
                    string table = txtSeat.Text;
                    etBillInfo.IdFood = busFood.GetValue("where Name=N'" + dgvFoodSelected.Rows[index].Cells[0].Value + "'", 0);
                    etBillInfo.Id = busBillInfo.GetValue("where IDBill=N'" + getIDbillfromTable(table) + "' and IdFood=N'" + etBillInfo.IdFood + "'",0);
                    busBillInfo.DeleteBill(etBillInfo);
                }
                txtSum.Text = Convert.ToDouble(txtSum.Text) - Convert.ToDouble(dgvFoodSelected.Rows[index].Cells[1].Value) * Convert.ToDouble(dgvFoodSelected.Rows[index].Cells[2].Value) + "";
                dgvFoodSelected.Rows.RemoveAt(index);
                updatePrice();
            }
        }

        private void txtmember_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = busCus.CreateData("where PhoneNumber=N'" + txtmember.Text + "'");
            if (dt.Rows.Count < 1) { txtmember.BackColor = Color.Red; }
            else { txtmember.BackColor = Color.BlueViolet; }
        }

        private void cbMember_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMember.Checked == false)
            {
                txtmember.Enabled = false;
                txtmember.Text = "";
            }
            else txtmember.Enabled = true;
        }
       //---------------------Book Click------------------------------//
       EC_BillInfo etBillInfo= new EC_BillInfo();
        BUS_BillInfo busBillInfo = new BUS_BillInfo();
        EC_Bill etBill = new EC_Bill();
        BUS_BILL busBill = new BUS_BILL();
        string setIdBillInfo()
        {
                DataTable dt = busBillInfo.CreateData("");
                if (dt.Rows.Count < 1) return "BI0000";
                else
                {
                    string s = Convert.ToString(dt.Rows[dt.Rows.Count - 1][0]);
                    int id = Convert.ToInt32(s.Remove(0, 2)) + 1;
                    if (id < 10) return "BI000" + id;
                else if (id < 100) return "BI00" + id;
                else if (id < 1000) return "BI0" + id;
                else  return "BI" + id;
                }
        }
        string setIdBill()
        {
            DataTable dt = busBill.CreateData("");
            if (dt.Rows.Count < 1) return "B0000";
            else
            {
                string s = Convert.ToString(dt.Rows[dt.Rows.Count - 1][0]);
                int id = Convert.ToInt32(s.Remove(0, 2)) + 1;
                if (id < 10) return "B000" + id;
                else if (id < 100) return "B00" + id;
                else if (id < 1000) return "B0" + id;
                else return "B" + id;
            }
        }
        
        private void btnbook_Click(object sender, EventArgs e)
        {
            if (!IsTableNotAvailable(txtSeat.Text))
            {
                {
                    etBill.Id = setIdBill();
                    etBill.IdTable = txtSeat.Text;
                    etBill.Status = 0 + "";
                    DateTime datevalue = DateTime.Now;
                    etBill.DateBill = datevalue.ToString("MM-dd-yyyy HH:mm:ss");
                    MessageBox.Show(etBill.DateBill);
                    busBill.AddBill(etBill);

                    for (int i = 0; i < dgvFoodSelected.Rows.Count - 1; i++)
                    {
                        etBillInfo.Id = setIdBillInfo();
                        etBillInfo.IdBill = etBill.Id;
                        DataTable dt = busFood.CreateData("where Name =N'" + dgvFoodSelected.Rows[i].Cells[0].Value + "'");
                        etBillInfo.IdFood = dt.Rows[0][0] + "";
                        etBillInfo.Count = int.Parse(dgvFoodSelected.Rows[i].Cells[1].Value + "");
                        etBillInfo.Note = dgvFoodSelected.Rows[i].Cells[3].Value + "";
                        busBillInfo.AddBill(etBillInfo);
                    }
                }
                showTable();
            }
            else { MessageBox.Show("Bàn đang có người"); }
        }

        private void btnPrintbill_Click(object sender, EventArgs e)
        {
            string table = txtSeat.Text;
            etBill.Id = getIDbillfromTable(table);
            DateTime datevalue = DateTime.Now;
            etBill.DateBill = datevalue.ToString("MM-dd-yyyy HH:mm:ss");
            etBill.IdTable = txtSeat.Text;
            etBill.Status = 1+"";
            busBill.UpdateBill(etBill);
            showTable();
        }
       
        private void txtSeat_TextChanged(object sender, EventArgs e)
        {
            dgvFoodSelected.Rows.Clear();
            dgvFoodSelected.Refresh();
            if (IsTableNotAvailable(txtSeat.Text))
            {
                showSelectedFood();
            }
        }
        void showSelectedFood() {
            string table = txtSeat.Text;
            string IDBill = getIDbillfromTable(table);
            DataTable dt = busBillInfo.CreateData("where IDBill= N'" + IDBill + "'");
            double price = 0;
            for(int i = 0; i < dt.Rows.Count ; i++)
            {
                DataGridViewRow dvr = new DataGridViewRow();
                dvr.CreateCells(dgvFoodSelected);
                dvr.Cells[0].Value = busFood.GetValue("where ID=N'" + dt.Rows[i][2]+"'",1);
                dvr.Cells[1].Value = dt.Rows[i][4] + "";
                dvr.Cells[2].Value = busFood.GetValue("where ID=N'" + dt.Rows[i][2] + "'", 2);
                dvr.Cells[3].Value = dt.Rows[i][3] + "";
                price += Convert.ToDouble(dvr.Cells[1].Value) * Convert.ToDouble(dvr.Cells[2].Value);
                dgvFoodSelected.Rows.Add(dvr);
            }
            updatePrice();
        }
        void updatePrice()
        {
            double price = 0;
            for(int i = 0; i < dgvFoodSelected.Rows.Count; i++)
            {
                DataGridViewRow dvr = dgvFoodSelected.Rows[i];
                price += Convert.ToDouble(dvr.Cells[1].Value) * Convert.ToDouble(dvr.Cells[2].Value);
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                decimal value = decimal.Parse(Convert.ToString(price), System.Globalization.NumberStyles.AllowThousands);
                txtSum.Text = String.Format(culture, "{0:N0}", value);
                txtSum.Select(txtSum.Text.Length, 0);
            }
        }

        private void btnbook_DragDrop(object sender, DragEventArgs e)
        {
        }

        private void btnCombine_MouseUp(object sender, MouseEventArgs e)
        {
        }

        private void btnbook_MouseDown(object sender, MouseEventArgs e)
        {
        }
        private void btnbook_DragEnter(object sender, DragEventArgs e)
        {
        }

        private void btnCombine_DragDrop(object sender, DragEventArgs e)
        {
        }

        private void btnCombine_DragEnter(object sender, DragEventArgs e)
        {
        }
        void combineSeat(string src, string dest)
        {
            string IdBillsrc = getIDbillfromTable(src);
            string IdBilldst = getIDbillfromTable(dest);
            DataTable dt = busBillInfo.CreateData("where IdBill= N'" + IdBillsrc + "'");
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                etBillInfo.Id = dt.Rows[i][0]+"";
                etBillInfo.IdBill = IdBilldst;
                etBillInfo.IdFood = dt.Rows[i][2] + "";
                etBillInfo.Note = dt.Rows[i][3] + "";
                etBillInfo.Count = int.Parse(dt.Rows[i][4]+"");
                busBillInfo.UpdateBill(etBillInfo);
            }
            etBill.Id = IdBillsrc;
            busBill.DeleteBill(etBill);
            showTable();
            showSelectedFood();
        }
        void moveSeat(string src, string dest)
        {
            string IdBillsrc = getIDbillfromTable(src);
            DataTable dt = busBill.CreateData("where ID=N'" + IdBillsrc + "'");
            etBill.Id = IdBillsrc;
            etBill.IdTable = dest;
            etBill.Status = dt.Rows[0][3]+"";
            DateTime d = Convert.ToDateTime(dt.Rows[0][1]);
            string s1 = d.ToString("MM-dd-yyyy HH:mm:ss");
            etBill.DateBill = s1;
            busBill.UpdateBill(etBill);
            MessageBox.Show(etBill.Id + " " + etBill.IdTable + " " + etBill.Status + " " + etBill.DateBill);
            showTable();
            showSelectedFood();
        }
    }
}
