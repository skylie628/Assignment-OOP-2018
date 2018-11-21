namespace assignmentOOP
{
    partial class frmCreateCustomerAccount
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label30 = new System.Windows.Forms.Label();
            this.txtIdMember = new System.Windows.Forms.TextBox();
            this.btnCustomerSave = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.rdMemberWomen = new System.Windows.Forms.RadioButton();
            this.rdMemberMan = new System.Windows.Forms.RadioButton();
            this.dtpMember = new System.Windows.Forms.DateTimePicker();
            this.txtPhoneMember = new System.Windows.Forms.TextBox();
            this.txtNameMember = new System.Windows.Forms.TextBox();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.btnEditMember = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbSearchCustomer = new System.Windows.Forms.ComboBox();
            this.txtMemberSearch = new System.Windows.Forms.TextBox();
            this.btnSearchMember = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label30);
            this.panel2.Controls.Add(this.txtIdMember);
            this.panel2.Controls.Add(this.btnCustomerSave);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.rdMemberWomen);
            this.panel2.Controls.Add(this.rdMemberMan);
            this.panel2.Controls.Add(this.dtpMember);
            this.panel2.Controls.Add(this.txtPhoneMember);
            this.panel2.Controls.Add(this.txtNameMember);
            this.panel2.Controls.Add(this.btnAddMember);
            this.panel2.Controls.Add(this.btnEditMember);
            this.panel2.Location = new System.Drawing.Point(1, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(265, 489);
            this.panel2.TabIndex = 19;
            // 
            // label30
            // 
            this.label30.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(30, 15);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(18, 13);
            this.label30.TabIndex = 32;
            this.label30.Text = "ID";
            // 
            // txtIdMember
            // 
            this.txtIdMember.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtIdMember.Location = new System.Drawing.Point(32, 40);
            this.txtIdMember.Name = "txtIdMember";
            this.txtIdMember.Size = new System.Drawing.Size(185, 20);
            this.txtIdMember.TabIndex = 31;
            // 
            // btnCustomerSave
            // 
            this.btnCustomerSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCustomerSave.Location = new System.Drawing.Point(79, 395);
            this.btnCustomerSave.Name = "btnCustomerSave";
            this.btnCustomerSave.Size = new System.Drawing.Size(75, 32);
            this.btnCustomerSave.TabIndex = 30;
            this.btnCustomerSave.Text = "Lưu";
            this.btnCustomerSave.UseVisualStyleBackColor = true;
            this.btnCustomerSave.Click += new System.EventHandler(this.btnCustomerSave_Click);
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(30, 235);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "Số điện thoại";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(34, 178);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Giới tính";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(34, 113);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Ngày sinh";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(34, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Tên";
            // 
            // rdMemberWomen
            // 
            this.rdMemberWomen.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rdMemberWomen.AutoSize = true;
            this.rdMemberWomen.Location = new System.Drawing.Point(136, 200);
            this.rdMemberWomen.Name = "rdMemberWomen";
            this.rdMemberWomen.Size = new System.Drawing.Size(39, 17);
            this.rdMemberWomen.TabIndex = 25;
            this.rdMemberWomen.TabStop = true;
            this.rdMemberWomen.Text = "Nữ";
            this.rdMemberWomen.UseVisualStyleBackColor = true;
            // 
            // rdMemberMan
            // 
            this.rdMemberMan.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rdMemberMan.AutoSize = true;
            this.rdMemberMan.Location = new System.Drawing.Point(37, 200);
            this.rdMemberMan.Name = "rdMemberMan";
            this.rdMemberMan.Size = new System.Drawing.Size(47, 17);
            this.rdMemberMan.TabIndex = 24;
            this.rdMemberMan.TabStop = true;
            this.rdMemberMan.Text = "Nam";
            this.rdMemberMan.UseVisualStyleBackColor = true;
            // 
            // dtpMember
            // 
            this.dtpMember.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpMember.CustomFormat = "yyyy-MM-dd";
            this.dtpMember.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMember.Location = new System.Drawing.Point(33, 141);
            this.dtpMember.Name = "dtpMember";
            this.dtpMember.Size = new System.Drawing.Size(185, 20);
            this.dtpMember.TabIndex = 23;
            // 
            // txtPhoneMember
            // 
            this.txtPhoneMember.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPhoneMember.Location = new System.Drawing.Point(33, 260);
            this.txtPhoneMember.Name = "txtPhoneMember";
            this.txtPhoneMember.Size = new System.Drawing.Size(185, 20);
            this.txtPhoneMember.TabIndex = 22;
            // 
            // txtNameMember
            // 
            this.txtNameMember.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNameMember.Location = new System.Drawing.Point(32, 84);
            this.txtNameMember.Name = "txtNameMember";
            this.txtNameMember.Size = new System.Drawing.Size(185, 20);
            this.txtNameMember.TabIndex = 21;
            // 
            // btnAddMember
            // 
            this.btnAddMember.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddMember.Location = new System.Drawing.Point(79, 309);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(75, 32);
            this.btnAddMember.TabIndex = 19;
            this.btnAddMember.Text = "Thêm";
            this.btnAddMember.UseVisualStyleBackColor = true;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // btnEditMember
            // 
            this.btnEditMember.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditMember.Location = new System.Drawing.Point(79, 351);
            this.btnEditMember.Name = "btnEditMember";
            this.btnEditMember.Size = new System.Drawing.Size(75, 32);
            this.btnEditMember.TabIndex = 18;
            this.btnEditMember.Text = "Sửa";
            this.btnEditMember.UseVisualStyleBackColor = true;
            this.btnEditMember.Click += new System.EventHandler(this.btnEditMember_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.cmbSearchCustomer);
            this.panel1.Controls.Add(this.txtMemberSearch);
            this.panel1.Controls.Add(this.btnSearchMember);
            this.panel1.Location = new System.Drawing.Point(270, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 76);
            this.panel1.TabIndex = 20;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(21, 11);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 13);
            this.label16.TabIndex = 7;
            this.label16.Text = "Tìm Kiếm";
            // 
            // cmbSearchCustomer
            // 
            this.cmbSearchCustomer.FormattingEnabled = true;
            this.cmbSearchCustomer.Items.AddRange(new object[] {
            "Tên",
            "Số điện thoại",
            "Tất cả"});
            this.cmbSearchCustomer.Location = new System.Drawing.Point(24, 36);
            this.cmbSearchCustomer.Name = "cmbSearchCustomer";
            this.cmbSearchCustomer.Size = new System.Drawing.Size(145, 21);
            this.cmbSearchCustomer.TabIndex = 6;
            // 
            // txtMemberSearch
            // 
            this.txtMemberSearch.Location = new System.Drawing.Point(205, 36);
            this.txtMemberSearch.Name = "txtMemberSearch";
            this.txtMemberSearch.Size = new System.Drawing.Size(172, 20);
            this.txtMemberSearch.TabIndex = 5;
            // 
            // btnSearchMember
            // 
            this.btnSearchMember.Location = new System.Drawing.Point(409, 36);
            this.btnSearchMember.Name = "btnSearchMember";
            this.btnSearchMember.Size = new System.Drawing.Size(75, 23);
            this.btnSearchMember.TabIndex = 4;
            this.btnSearchMember.Text = "Lọc";
            this.btnSearchMember.UseVisualStyleBackColor = true;
            this.btnSearchMember.Click += new System.EventHandler(this.btnSearchMember_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.dgvCustomer);
            this.panel3.Location = new System.Drawing.Point(269, 86);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(529, 420);
            this.panel3.TabIndex = 21;
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvCustomer.Location = new System.Drawing.Point(2, 2);
            this.dgvCustomer.MultiSelect = false;
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.ReadOnly = true;
            this.dgvCustomer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomer.Size = new System.Drawing.Size(525, 416);
            this.dgvCustomer.TabIndex = 5;
            this.dgvCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellClick_1);
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "ID_CUSTOMER";
            this.Column3.HeaderText = "ID";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "Name";
            this.Column4.HeaderText = "Tên";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "DateOfBirth";
            this.Column5.HeaderText = "Ngày sinh";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "Sex";
            this.Column6.HeaderText = "Giới tính";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.DataPropertyName = "PhoneNumber";
            this.Column7.HeaderText = "Số điện thoại";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // frmCreateCustomerAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 527);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "frmCreateCustomerAccount";
            this.Text = "frmCreateCustomerAccount";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox txtIdMember;
        private System.Windows.Forms.Button btnCustomerSave;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton rdMemberWomen;
        private System.Windows.Forms.RadioButton rdMemberMan;
        private System.Windows.Forms.DateTimePicker dtpMember;
        private System.Windows.Forms.TextBox txtPhoneMember;
        private System.Windows.Forms.TextBox txtNameMember;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.Button btnEditMember;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmbSearchCustomer;
        private System.Windows.Forms.TextBox txtMemberSearch;
        private System.Windows.Forms.Button btnSearchMember;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}