﻿namespace assignmentOOP
{
    partial class frmStaff
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbdate = new System.Windows.Forms.Label();
            this.dgvFoodSelected = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.txtSeat = new System.Windows.Forms.TextBox();
            this.lbSeat = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmember = new System.Windows.Forms.TextBox();
            this.cbMember = new System.Windows.Forms.CheckBox();
            this.lbSum = new System.Windows.Forms.Label();
            this.btnprintfood = new System.Windows.Forms.Button();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.btnPrintbill = new System.Windows.Forms.Button();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtTotalAmont = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtSearchFood = new System.Windows.Forms.TextBox();
            this.cmFoodCate = new System.Windows.Forms.ComboBox();
            this.cmbnumber = new System.Windows.Forms.ComboBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvFood = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flpSeat = new System.Windows.Forms.FlowLayoutPanel();
            this.btnbook = new System.Windows.Forms.Button();
            this.cbDiscount = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnInfomation = new System.Windows.Forms.Button();
            this.btnCreateCusTomerAcount = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodSelected)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(829, 0);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.panel5);
            this.panel.Controls.Add(this.panel4);
            this.panel.Controls.Add(this.panel3);
            this.panel.Controls.Add(this.cbDiscount);
            this.panel.Controls.Add(this.label6);
            this.panel.Location = new System.Drawing.Point(0, 27);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(829, 404);
            this.panel.TabIndex = 1;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.lbdate);
            this.panel5.Controls.Add(this.dgvFoodSelected);
            this.panel5.Controls.Add(this.btnDelete);
            this.panel5.Controls.Add(this.dtp);
            this.panel5.Controls.Add(this.txtSeat);
            this.panel5.Controls.Add(this.lbSeat);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.txtmember);
            this.panel5.Controls.Add(this.cbMember);
            this.panel5.Controls.Add(this.lbSum);
            this.panel5.Controls.Add(this.btnprintfood);
            this.panel5.Controls.Add(this.txtSum);
            this.panel5.Controls.Add(this.btnPrintbill);
            this.panel5.Controls.Add(this.txtDiscount);
            this.panel5.Controls.Add(this.txtTotalAmont);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(253, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(391, 396);
            this.panel5.TabIndex = 31;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // lbdate
            // 
            this.lbdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbdate.AutoSize = true;
            this.lbdate.Location = new System.Drawing.Point(23, 10);
            this.lbdate.Name = "lbdate";
            this.lbdate.Size = new System.Drawing.Size(32, 13);
            this.lbdate.TabIndex = 10;
            this.lbdate.Text = "Ngày";
            this.lbdate.Click += new System.EventHandler(this.lbdate_Click);
            // 
            // dgvFoodSelected
            // 
            this.dgvFoodSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFoodSelected.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFoodSelected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoodSelected.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvFoodSelected.Location = new System.Drawing.Point(2, 120);
            this.dgvFoodSelected.Name = "dgvFoodSelected";
            this.dgvFoodSelected.RowHeadersVisible = false;
            this.dgvFoodSelected.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFoodSelected.Size = new System.Drawing.Size(384, 159);
            this.dgvFoodSelected.TabIndex = 2;
            this.dgvFoodSelected.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFoodSelected_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "None";
            this.Column1.HeaderText = "Mặt hàng";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Số lượng";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Giá";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Ghi chú";
            this.Column4.Name = "Column4";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDelete.Location = new System.Drawing.Point(49, 88);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 21);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dtp
            // 
            this.dtp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtp.Location = new System.Drawing.Point(74, 4);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(87, 20);
            this.dtp.TabIndex = 11;
            this.dtp.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            // 
            // txtSeat
            // 
            this.txtSeat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSeat.Enabled = false;
            this.txtSeat.Location = new System.Drawing.Point(273, 4);
            this.txtSeat.Name = "txtSeat";
            this.txtSeat.Size = new System.Drawing.Size(32, 20);
            this.txtSeat.TabIndex = 33;
            this.txtSeat.TextChanged += new System.EventHandler(this.txtSeat_TextChanged);
            // 
            // lbSeat
            // 
            this.lbSeat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbSeat.AutoSize = true;
            this.lbSeat.Location = new System.Drawing.Point(242, 10);
            this.lbSeat.Name = "lbSeat";
            this.lbSeat.Size = new System.Drawing.Size(0, 13);
            this.lbSeat.TabIndex = 12;
            this.lbSeat.Click += new System.EventHandler(this.lbSeat_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Bàn số";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtmember
            // 
            this.txtmember.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtmember.Location = new System.Drawing.Point(112, 50);
            this.txtmember.Name = "txtmember";
            this.txtmember.Size = new System.Drawing.Size(192, 20);
            this.txtmember.TabIndex = 14;
            this.txtmember.TextChanged += new System.EventHandler(this.txtmember_TextChanged);
            // 
            // cbMember
            // 
            this.cbMember.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbMember.AutoSize = true;
            this.cbMember.Location = new System.Drawing.Point(26, 52);
            this.cbMember.Name = "cbMember";
            this.cbMember.Size = new System.Drawing.Size(80, 17);
            this.cbMember.TabIndex = 31;
            this.cbMember.Text = "Thành viên";
            this.cbMember.UseVisualStyleBackColor = true;
            this.cbMember.CheckedChanged += new System.EventHandler(this.cbMember_CheckedChanged);
            // 
            // lbSum
            // 
            this.lbSum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbSum.AutoSize = true;
            this.lbSum.Location = new System.Drawing.Point(127, 289);
            this.lbSum.Name = "lbSum";
            this.lbSum.Size = new System.Drawing.Size(52, 13);
            this.lbSum.TabIndex = 15;
            this.lbSum.Text = "Tổng tiền";
            this.lbSum.Click += new System.EventHandler(this.lbSum_Click);
            // 
            // btnprintfood
            // 
            this.btnprintfood.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnprintfood.Location = new System.Drawing.Point(167, 88);
            this.btnprintfood.Name = "btnprintfood";
            this.btnprintfood.Size = new System.Drawing.Size(75, 23);
            this.btnprintfood.TabIndex = 26;
            this.btnprintfood.Text = "In chế biến";
            this.btnprintfood.UseVisualStyleBackColor = true;
            this.btnprintfood.Click += new System.EventHandler(this.btnprintfood_Click);
            // 
            // txtSum
            // 
            this.txtSum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSum.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSum.Location = new System.Drawing.Point(230, 286);
            this.txtSum.Name = "txtSum";
            this.txtSum.Size = new System.Drawing.Size(156, 20);
            this.txtSum.TabIndex = 16;
            this.txtSum.Text = "0";
            this.txtSum.TextChanged += new System.EventHandler(this.txtSum_TextChanged);
            // 
            // btnPrintbill
            // 
            this.btnPrintbill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrintbill.Location = new System.Drawing.Point(14, 292);
            this.btnPrintbill.Name = "btnPrintbill";
            this.btnPrintbill.Size = new System.Drawing.Size(75, 23);
            this.btnPrintbill.TabIndex = 21;
            this.btnPrintbill.Text = "In bill";
            this.btnPrintbill.UseVisualStyleBackColor = true;
            this.btnPrintbill.Click += new System.EventHandler(this.btnPrintbill_Click);
            // 
            // txtDiscount
            // 
            this.txtDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDiscount.Location = new System.Drawing.Point(230, 318);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(100, 20);
            this.txtDiscount.TabIndex = 17;
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            // 
            // txtTotalAmont
            // 
            this.txtTotalAmont.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTotalAmont.Location = new System.Drawing.Point(230, 352);
            this.txtTotalAmont.Name = "txtTotalAmont";
            this.txtTotalAmont.Size = new System.Drawing.Size(156, 20);
            this.txtTotalAmont.TabIndex = 20;
            this.txtTotalAmont.TextChanged += new System.EventHandler(this.txtTotalAmont_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(127, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Giảm giá";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.txtSearchFood);
            this.panel4.Controls.Add(this.cmFoodCate);
            this.panel4.Controls.Add(this.cmbnumber);
            this.panel4.Controls.Add(this.txtNote);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.dgvFood);
            this.panel4.Location = new System.Drawing.Point(649, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(179, 400);
            this.panel4.TabIndex = 36;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // txtSearchFood
            // 
            this.txtSearchFood.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtSearchFood.Location = new System.Drawing.Point(62, 2);
            this.txtSearchFood.Name = "txtSearchFood";
            this.txtSearchFood.Size = new System.Drawing.Size(114, 20);
            this.txtSearchFood.TabIndex = 5;
            this.txtSearchFood.TextChanged += new System.EventHandler(this.txtSearchFood_TextChanged);
            // 
            // cmFoodCate
            // 
            this.cmFoodCate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cmFoodCate.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmFoodCate.FormattingEnabled = true;
            this.cmFoodCate.Items.AddRange(new object[] {
            "Tất Cả"});
            this.cmFoodCate.Location = new System.Drawing.Point(60, 36);
            this.cmFoodCate.Name = "cmFoodCate";
            this.cmFoodCate.Size = new System.Drawing.Size(114, 21);
            this.cmFoodCate.TabIndex = 4;
            this.cmFoodCate.SelectedIndexChanged += new System.EventHandler(this.cmFoodCate_SelectedIndexChanged);
            // 
            // cmbnumber
            // 
            this.cmbnumber.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cmbnumber.FormattingEnabled = true;
            this.cmbnumber.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbnumber.Location = new System.Drawing.Point(101, 63);
            this.cmbnumber.Name = "cmbnumber";
            this.cmbnumber.Size = new System.Drawing.Size(59, 21);
            this.cmbnumber.TabIndex = 22;
            this.cmbnumber.SelectedIndexChanged += new System.EventHandler(this.cmbnumber_SelectedIndexChanged);
            // 
            // txtNote
            // 
            this.txtNote.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtNote.Location = new System.Drawing.Point(60, 99);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(114, 20);
            this.txtNote.TabIndex = 23;
            this.txtNote.TextChanged += new System.EventHandler(this.txtNote_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Ghi chú";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Số lượng";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // dgvFood
            // 
            this.dgvFood.AllowUserToAddRows = false;
            this.dgvFood.AllowUserToDeleteRows = false;
            this.dgvFood.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFood.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.PRICE});
            this.dgvFood.Location = new System.Drawing.Point(2, 133);
            this.dgvFood.Name = "dgvFood";
            this.dgvFood.RowHeadersVisible = false;
            this.dgvFood.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFood.Size = new System.Drawing.Size(172, 247);
            this.dgvFood.TabIndex = 30;
            this.dgvFood.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFood_CellContentClick);
            this.dgvFood.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFood_CellContentDoubleClick);
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Mặt hàng";
            this.Name.Name = "Name";
            // 
            // PRICE
            // 
            this.PRICE.DataPropertyName = "PRICE";
            this.PRICE.HeaderText = "Giá";
            this.PRICE.Name = "PRICE";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.panel3.Controls.Add(this.flpSeat);
            this.panel3.Controls.Add(this.btnbook);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(248, 402);
            this.panel3.TabIndex = 35;
            // 
            // flpSeat
            // 
            this.flpSeat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.flpSeat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flpSeat.Location = new System.Drawing.Point(3, 3);
            this.flpSeat.Name = "flpSeat";
            this.flpSeat.Size = new System.Drawing.Size(240, 336);
            this.flpSeat.TabIndex = 1;
            this.flpSeat.Paint += new System.Windows.Forms.PaintEventHandler(this.flpSeat_Paint_1);
            // 
            // btnbook
            // 
            this.btnbook.AllowDrop = true;
            this.btnbook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnbook.Location = new System.Drawing.Point(3, 350);
            this.btnbook.Name = "btnbook";
            this.btnbook.Size = new System.Drawing.Size(240, 23);
            this.btnbook.TabIndex = 29;
            this.btnbook.Text = "Đặt bàn";
            this.btnbook.UseVisualStyleBackColor = true;
            this.btnbook.Click += new System.EventHandler(this.btnbook_Click);
            this.btnbook.DragDrop += new System.Windows.Forms.DragEventHandler(this.btnbook_DragDrop);
            this.btnbook.DragEnter += new System.Windows.Forms.DragEventHandler(this.btnbook_DragEnter);
            this.btnbook.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnbook_MouseDown);
            // 
            // cbDiscount
            // 
            this.cbDiscount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbDiscount.FormattingEnabled = true;
            this.cbDiscount.Items.AddRange(new object[] {
            "Không",
            "Nhập Mã"});
            this.cbDiscount.Location = new System.Drawing.Point(591, 332);
            this.cbDiscount.Name = "cbDiscount";
            this.cbDiscount.Size = new System.Drawing.Size(50, 21);
            this.cbDiscount.TabIndex = 34;
            this.cbDiscount.SelectedIndexChanged += new System.EventHandler(this.cbDiscount_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(375, 373);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Tổng cộng";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Controls.Add(this.btnInfomation);
            this.panel2.Controls.Add(this.btnCreateCusTomerAcount);
            this.panel2.Location = new System.Drawing.Point(0, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(829, 24);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogout.Location = new System.Drawing.Point(754, 3);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnInfomation
            // 
            this.btnInfomation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfomation.FlatAppearance.BorderSize = 0;
            this.btnInfomation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfomation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInfomation.Location = new System.Drawing.Point(121, -1);
            this.btnInfomation.Name = "btnInfomation";
            this.btnInfomation.Size = new System.Drawing.Size(103, 23);
            this.btnInfomation.TabIndex = 1;
            this.btnInfomation.Text = "Thông tin cá nhân";
            this.btnInfomation.UseVisualStyleBackColor = true;
            this.btnInfomation.Click += new System.EventHandler(this.btnInfomation_Click);
            // 
            // btnCreateCusTomerAcount
            // 
            this.btnCreateCusTomerAcount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateCusTomerAcount.FlatAppearance.BorderSize = 0;
            this.btnCreateCusTomerAcount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateCusTomerAcount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCreateCusTomerAcount.Location = new System.Drawing.Point(2, 0);
            this.btnCreateCusTomerAcount.Name = "btnCreateCusTomerAcount";
            this.btnCreateCusTomerAcount.Size = new System.Drawing.Size(123, 23);
            this.btnCreateCusTomerAcount.TabIndex = 0;
            this.btnCreateCusTomerAcount.Text = "Đăng kí thành viên";
            this.btnCreateCusTomerAcount.UseVisualStyleBackColor = true;
            this.btnCreateCusTomerAcount.Click += new System.EventHandler(this.btnCreateCusTomerAcount_Click);
            this.btnCreateCusTomerAcount.MouseLeave += new System.EventHandler(this.btnCreateCusTomerAcount_MouseLeave);
            this.btnCreateCusTomerAcount.MouseHover += new System.EventHandler(this.btnCreateCusTomerAcount_MouseHover);
            // 
            // frmStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.ClientSize = new System.Drawing.Size(829, 432);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmStaff_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodSelected)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.FlowLayoutPanel flpSeat;
        private System.Windows.Forms.DataGridView dgvFoodSelected;
        private System.Windows.Forms.Label lbSeat;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.Label lbdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtSearchFood;
        private System.Windows.Forms.ComboBox cmFoodCate;
        private System.Windows.Forms.TextBox txtmember;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.ComboBox cmbnumber;
        private System.Windows.Forms.Button btnPrintbill;
        private System.Windows.Forms.TextBox txtTotalAmont;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.Label lbSum;
        private System.Windows.Forms.Button btnbook;
        private System.Windows.Forms.Button btnprintfood;
        private System.Windows.Forms.DataGridView dgvFood;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.CheckBox cbMember;
        private System.Windows.Forms.TextBox txtSeat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDiscount;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnInfomation;
        private System.Windows.Forms.Button btnCreateCusTomerAcount;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
    }
}