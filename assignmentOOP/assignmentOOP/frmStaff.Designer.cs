namespace assignmentOOP
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
            this.txtSeat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMember = new System.Windows.Forms.CheckBox();
            this.dgvFood = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnbook = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnCombine = new System.Windows.Forms.Button();
            this.btnprintfood = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.cmbnumber = new System.Windows.Forms.ComboBox();
            this.btnPrintbill = new System.Windows.Forms.Button();
            this.txtTotalAmont = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.lbSum = new System.Windows.Forms.Label();
            this.txtmember = new System.Windows.Forms.TextBox();
            this.lbSeat = new System.Windows.Forms.Label();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.lbdate = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtSearchFood = new System.Windows.Forms.TextBox();
            this.cmFoodCate = new System.Windows.Forms.ComboBox();
            this.dgvFoodSelected = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flpSeat = new System.Windows.Forms.FlowLayoutPanel();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodSelected)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(829, 25);
            this.panel1.TabIndex = 0;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.txtSeat);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.cbMember);
            this.panel.Controls.Add(this.dgvFood);
            this.panel.Controls.Add(this.btnbook);
            this.panel.Controls.Add(this.btnChange);
            this.panel.Controls.Add(this.btnCombine);
            this.panel.Controls.Add(this.btnprintfood);
            this.panel.Controls.Add(this.label8);
            this.panel.Controls.Add(this.label7);
            this.panel.Controls.Add(this.txtNote);
            this.panel.Controls.Add(this.cmbnumber);
            this.panel.Controls.Add(this.btnPrintbill);
            this.panel.Controls.Add(this.txtTotalAmont);
            this.panel.Controls.Add(this.label6);
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.txtDiscount);
            this.panel.Controls.Add(this.txtSum);
            this.panel.Controls.Add(this.lbSum);
            this.panel.Controls.Add(this.txtmember);
            this.panel.Controls.Add(this.lbSeat);
            this.panel.Controls.Add(this.dtp);
            this.panel.Controls.Add(this.lbdate);
            this.panel.Controls.Add(this.btnDelete);
            this.panel.Controls.Add(this.txtSearchFood);
            this.panel.Controls.Add(this.cmFoodCate);
            this.panel.Controls.Add(this.dgvFoodSelected);
            this.panel.Controls.Add(this.flpSeat);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 25);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(829, 407);
            this.panel.TabIndex = 1;
            // 
            // txtSeat
            // 
            this.txtSeat.Enabled = false;
            this.txtSeat.Location = new System.Drawing.Point(528, 18);
            this.txtSeat.Name = "txtSeat";
            this.txtSeat.Size = new System.Drawing.Size(32, 20);
            this.txtSeat.TabIndex = 33;
            this.txtSeat.TextChanged += new System.EventHandler(this.txtSeat_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(482, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Bàn số";
            // 
            // cbMember
            // 
            this.cbMember.AutoSize = true;
            this.cbMember.Location = new System.Drawing.Point(281, 66);
            this.cbMember.Name = "cbMember";
            this.cbMember.Size = new System.Drawing.Size(80, 17);
            this.cbMember.TabIndex = 31;
            this.cbMember.Text = "Thành viên";
            this.cbMember.UseVisualStyleBackColor = true;
            this.cbMember.CheckedChanged += new System.EventHandler(this.cbMember_CheckedChanged);
            // 
            // dgvFood
            // 
            this.dgvFood.AllowUserToAddRows = false;
            this.dgvFood.AllowUserToDeleteRows = false;
            this.dgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFood.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.PRICE});
            this.dgvFood.Location = new System.Drawing.Point(647, 144);
            this.dgvFood.Name = "dgvFood";
            this.dgvFood.RowHeadersVisible = false;
            this.dgvFood.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFood.Size = new System.Drawing.Size(172, 247);
            this.dgvFood.TabIndex = 30;
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
            // btnbook
            // 
            this.btnbook.AllowDrop = true;
            this.btnbook.Location = new System.Drawing.Point(11, 359);
            this.btnbook.Name = "btnbook";
            this.btnbook.Size = new System.Drawing.Size(75, 23);
            this.btnbook.TabIndex = 29;
            this.btnbook.Text = "Đặt bàn";
            this.btnbook.UseVisualStyleBackColor = true;
            this.btnbook.Click += new System.EventHandler(this.btnbook_Click);
            this.btnbook.DragDrop += new System.Windows.Forms.DragEventHandler(this.btnbook_DragDrop);
            this.btnbook.DragEnter += new System.Windows.Forms.DragEventHandler(this.btnbook_DragEnter);
            this.btnbook.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnbook_MouseDown);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(11, 337);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 28;
            this.btnChange.Text = "Chuyển bàn";
            this.btnChange.UseVisualStyleBackColor = true;
            // 
            // btnCombine
            // 
            this.btnCombine.AllowDrop = true;
            this.btnCombine.Location = new System.Drawing.Point(11, 313);
            this.btnCombine.Name = "btnCombine";
            this.btnCombine.Size = new System.Drawing.Size(75, 23);
            this.btnCombine.TabIndex = 27;
            this.btnCombine.Text = "Gộp bàn";
            this.btnCombine.UseVisualStyleBackColor = true;
            this.btnCombine.DragDrop += new System.Windows.Forms.DragEventHandler(this.btnCombine_DragDrop);
            this.btnCombine.DragEnter += new System.Windows.Forms.DragEventHandler(this.btnCombine_DragEnter);
            this.btnCombine.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnCombine_MouseUp);
            // 
            // btnprintfood
            // 
            this.btnprintfood.Location = new System.Drawing.Point(351, 103);
            this.btnprintfood.Name = "btnprintfood";
            this.btnprintfood.Size = new System.Drawing.Size(75, 23);
            this.btnprintfood.TabIndex = 26;
            this.btnprintfood.Text = "In chế biến";
            this.btnprintfood.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(654, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Số lượng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(655, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Ghi chú";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(705, 110);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(114, 20);
            this.txtNote.TabIndex = 23;
            // 
            // cmbnumber
            // 
            this.cmbnumber.FormattingEnabled = true;
            this.cmbnumber.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbnumber.Location = new System.Drawing.Point(746, 74);
            this.cmbnumber.Name = "cmbnumber";
            this.cmbnumber.Size = new System.Drawing.Size(59, 21);
            this.cmbnumber.TabIndex = 22;
            // 
            // btnPrintbill
            // 
            this.btnPrintbill.Location = new System.Drawing.Point(269, 311);
            this.btnPrintbill.Name = "btnPrintbill";
            this.btnPrintbill.Size = new System.Drawing.Size(75, 23);
            this.btnPrintbill.TabIndex = 21;
            this.btnPrintbill.Text = "In bill";
            this.btnPrintbill.UseVisualStyleBackColor = true;
            this.btnPrintbill.Click += new System.EventHandler(this.btnPrintbill_Click);
            // 
            // txtTotalAmont
            // 
            this.txtTotalAmont.Location = new System.Drawing.Point(508, 371);
            this.txtTotalAmont.Name = "txtTotalAmont";
            this.txtTotalAmont.Size = new System.Drawing.Size(125, 20);
            this.txtTotalAmont.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(375, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Tổng cộng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(382, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Giảm giá";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(508, 337);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(125, 20);
            this.txtDiscount.TabIndex = 17;
            // 
            // txtSum
            // 
            this.txtSum.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSum.Location = new System.Drawing.Point(508, 305);
            this.txtSum.Name = "txtSum";
            this.txtSum.Size = new System.Drawing.Size(125, 20);
            this.txtSum.TabIndex = 16;
            this.txtSum.Text = "0";
            // 
            // lbSum
            // 
            this.lbSum.AutoSize = true;
            this.lbSum.Location = new System.Drawing.Point(382, 308);
            this.lbSum.Name = "lbSum";
            this.lbSum.Size = new System.Drawing.Size(52, 13);
            this.lbSum.TabIndex = 15;
            this.lbSum.Text = "Tổng tiền";
            // 
            // txtmember
            // 
            this.txtmember.Location = new System.Drawing.Point(367, 64);
            this.txtmember.Name = "txtmember";
            this.txtmember.Size = new System.Drawing.Size(192, 20);
            this.txtmember.TabIndex = 14;
            this.txtmember.TextChanged += new System.EventHandler(this.txtmember_TextChanged);
            // 
            // lbSeat
            // 
            this.lbSeat.AutoSize = true;
            this.lbSeat.Location = new System.Drawing.Point(497, 24);
            this.lbSeat.Name = "lbSeat";
            this.lbSeat.Size = new System.Drawing.Size(0, 13);
            this.lbSeat.TabIndex = 12;
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(329, 18);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(87, 20);
            this.dtp.TabIndex = 11;
            // 
            // lbdate
            // 
            this.lbdate.AutoSize = true;
            this.lbdate.Location = new System.Drawing.Point(278, 24);
            this.lbdate.Name = "lbdate";
            this.lbdate.Size = new System.Drawing.Size(32, 13);
            this.lbdate.TabIndex = 10;
            this.lbdate.Text = "Ngày";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(269, 103);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 21);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtSearchFood
            // 
            this.txtSearchFood.Location = new System.Drawing.Point(705, 13);
            this.txtSearchFood.Name = "txtSearchFood";
            this.txtSearchFood.Size = new System.Drawing.Size(114, 20);
            this.txtSearchFood.TabIndex = 5;
            this.txtSearchFood.TextChanged += new System.EventHandler(this.txtSearchFood_TextChanged);
            // 
            // cmFoodCate
            // 
            this.cmFoodCate.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmFoodCate.FormattingEnabled = true;
            this.cmFoodCate.Items.AddRange(new object[] {
            "Tất Cả"});
            this.cmFoodCate.Location = new System.Drawing.Point(705, 47);
            this.cmFoodCate.Name = "cmFoodCate";
            this.cmFoodCate.Size = new System.Drawing.Size(114, 21);
            this.cmFoodCate.TabIndex = 4;
            this.cmFoodCate.SelectedIndexChanged += new System.EventHandler(this.cmFoodCate_SelectedIndexChanged);
            // 
            // dgvFoodSelected
            // 
            this.dgvFoodSelected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoodSelected.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvFoodSelected.Location = new System.Drawing.Point(257, 134);
            this.dgvFoodSelected.Name = "dgvFoodSelected";
            this.dgvFoodSelected.RowHeadersVisible = false;
            this.dgvFoodSelected.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFoodSelected.Size = new System.Drawing.Size(384, 164);
            this.dgvFoodSelected.TabIndex = 2;
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
            // flpSeat
            // 
            this.flpSeat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.flpSeat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flpSeat.Location = new System.Drawing.Point(11, 13);
            this.flpSeat.Name = "flpSeat";
            this.flpSeat.Size = new System.Drawing.Size(240, 285);
            this.flpSeat.TabIndex = 1;
            // 
            // frmStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 432);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmStaff";
            this.Load += new System.EventHandler(this.frmStaff_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodSelected)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnCombine;
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
    }
}