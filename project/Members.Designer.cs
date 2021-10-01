
namespace project
{
    partial class Members
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAddNewMember = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblClose = new System.Windows.Forms.Label();
            this.btnFindMember = new System.Windows.Forms.Button();
            this.panelAddMemeber = new System.Windows.Forms.Panel();
            this.panelFindMember = new System.Windows.Forms.Panel();
            this.dataGridViewShowMembers = new System.Windows.Forms.DataGridView();
            this.memberNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberAgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberGenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemainingAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubscribtionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxEditGender = new System.Windows.Forms.ComboBox();
            this.txtEditPaid = new System.Windows.Forms.TextBox();
            this.txtEditAge = new System.Windows.Forms.TextBox();
            this.txtEditPhone = new System.Windows.Forms.TextBox();
            this.txtEditName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.btnGetBarcode = new System.Windows.Forms.Button();
            this.lblAddmemberSuccess = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.comboBoxSubscribtion = new System.Windows.Forms.ComboBox();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.txtPaid = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelAddMemeber.SuspendLayout();
            this.panelFindMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddNewMember
            // 
            this.btnAddNewMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(105)))));
            this.btnAddNewMember.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddNewMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewMember.ForeColor = System.Drawing.Color.White;
            this.btnAddNewMember.Location = new System.Drawing.Point(0, 0);
            this.btnAddNewMember.Name = "btnAddNewMember";
            this.btnAddNewMember.Size = new System.Drawing.Size(213, 36);
            this.btnAddNewMember.TabIndex = 1;
            this.btnAddNewMember.Text = "Add Member";
            this.btnAddNewMember.UseVisualStyleBackColor = false;
            this.btnAddNewMember.Click += new System.EventHandler(this.btnAddNewMember_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(105)))));
            this.panel1.Controls.Add(this.lblClose);
            this.panel1.Controls.Add(this.btnFindMember);
            this.panel1.Controls.Add(this.btnAddNewMember);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1016, 36);
            this.panel1.TabIndex = 3;
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.Red;
            this.lblClose.Location = new System.Drawing.Point(971, 9);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(21, 20);
            this.lblClose.TabIndex = 3;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // btnFindMember
            // 
            this.btnFindMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(105)))));
            this.btnFindMember.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnFindMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindMember.ForeColor = System.Drawing.Color.White;
            this.btnFindMember.Location = new System.Drawing.Point(213, 0);
            this.btnFindMember.Name = "btnFindMember";
            this.btnFindMember.Size = new System.Drawing.Size(213, 36);
            this.btnFindMember.TabIndex = 2;
            this.btnFindMember.Text = "FindMember";
            this.btnFindMember.UseVisualStyleBackColor = false;
            this.btnFindMember.Click += new System.EventHandler(this.btnFindMember_Click);
            // 
            // panelAddMemeber
            // 
            this.panelAddMemeber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.panelAddMemeber.Controls.Add(this.panelFindMember);
            this.panelAddMemeber.Controls.Add(this.btnGetBarcode);
            this.panelAddMemeber.Controls.Add(this.lblAddmemberSuccess);
            this.panelAddMemeber.Controls.Add(this.btnReset);
            this.panelAddMemeber.Controls.Add(this.btnAdd);
            this.panelAddMemeber.Controls.Add(this.comboBoxSubscribtion);
            this.panelAddMemeber.Controls.Add(this.comboBoxGender);
            this.panelAddMemeber.Controls.Add(this.txtPaid);
            this.panelAddMemeber.Controls.Add(this.txtAge);
            this.panelAddMemeber.Controls.Add(this.txtPhone);
            this.panelAddMemeber.Controls.Add(this.txtName);
            this.panelAddMemeber.Controls.Add(this.label6);
            this.panelAddMemeber.Controls.Add(this.label5);
            this.panelAddMemeber.Controls.Add(this.label4);
            this.panelAddMemeber.Controls.Add(this.label3);
            this.panelAddMemeber.Controls.Add(this.label2);
            this.panelAddMemeber.Controls.Add(this.label1);
            this.panelAddMemeber.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panelAddMemeber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAddMemeber.Location = new System.Drawing.Point(0, 36);
            this.panelAddMemeber.Name = "panelAddMemeber";
            this.panelAddMemeber.Size = new System.Drawing.Size(1016, 536);
            this.panelAddMemeber.TabIndex = 4;
            // 
            // panelFindMember
            // 
            this.panelFindMember.Controls.Add(this.dataGridViewShowMembers);
            this.panelFindMember.Controls.Add(this.label7);
            this.panelFindMember.Controls.Add(this.comboBoxEditGender);
            this.panelFindMember.Controls.Add(this.txtEditPaid);
            this.panelFindMember.Controls.Add(this.txtEditAge);
            this.panelFindMember.Controls.Add(this.txtEditPhone);
            this.panelFindMember.Controls.Add(this.txtEditName);
            this.panelFindMember.Controls.Add(this.label8);
            this.panelFindMember.Controls.Add(this.label9);
            this.panelFindMember.Controls.Add(this.label11);
            this.panelFindMember.Controls.Add(this.label12);
            this.panelFindMember.Controls.Add(this.label13);
            this.panelFindMember.Controls.Add(this.btnEdit);
            this.panelFindMember.Controls.Add(this.button1);
            this.panelFindMember.Controls.Add(this.Search);
            this.panelFindMember.Controls.Add(this.panel3);
            this.panelFindMember.Controls.Add(this.txtSearchName);
            this.panelFindMember.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panelFindMember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFindMember.Location = new System.Drawing.Point(0, 0);
            this.panelFindMember.Name = "panelFindMember";
            this.panelFindMember.Size = new System.Drawing.Size(1016, 536);
            this.panelFindMember.TabIndex = 14;
            this.panelFindMember.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFindMember_Paint);
            // 
            // dataGridViewShowMembers
            // 
            this.dataGridViewShowMembers.AutoGenerateColumns = false;
            this.dataGridViewShowMembers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.dataGridViewShowMembers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewShowMembers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewShowMembers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewShowMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShowMembers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.memberNameDataGridViewTextBoxColumn,
            this.memberAgeDataGridViewTextBoxColumn,
            this.memberGenderDataGridViewTextBoxColumn,
            this.paidDataGridViewTextBoxColumn,
            this.RemainingAmount,
            this.phoneDataGridViewTextBoxColumn,
            this.SubscribtionID,
            this.MemberID});
            this.dataGridViewShowMembers.DataSource = this.memberBindingSource;
            this.dataGridViewShowMembers.EnableHeadersVisualStyles = false;
            this.dataGridViewShowMembers.GridColor = System.Drawing.Color.White;
            this.dataGridViewShowMembers.Location = new System.Drawing.Point(306, 173);
            this.dataGridViewShowMembers.Name = "dataGridViewShowMembers";
            this.dataGridViewShowMembers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewShowMembers.RowHeadersVisible = false;
            this.dataGridViewShowMembers.RowHeadersWidth = 600;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewShowMembers.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewShowMembers.Size = new System.Drawing.Size(698, 246);
            this.dataGridViewShowMembers.TabIndex = 39;
            this.dataGridViewShowMembers.SelectionChanged += new System.EventHandler(this.dataGridViewShowMembers_SelectionChanged_1);
            // 
            // memberNameDataGridViewTextBoxColumn
            // 
            this.memberNameDataGridViewTextBoxColumn.DataPropertyName = "MemberName";
            this.memberNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.memberNameDataGridViewTextBoxColumn.Name = "memberNameDataGridViewTextBoxColumn";
            this.memberNameDataGridViewTextBoxColumn.Width = 120;
            // 
            // memberAgeDataGridViewTextBoxColumn
            // 
            this.memberAgeDataGridViewTextBoxColumn.DataPropertyName = "MemberAge";
            this.memberAgeDataGridViewTextBoxColumn.HeaderText = "Age";
            this.memberAgeDataGridViewTextBoxColumn.Name = "memberAgeDataGridViewTextBoxColumn";
            // 
            // memberGenderDataGridViewTextBoxColumn
            // 
            this.memberGenderDataGridViewTextBoxColumn.DataPropertyName = "MemberGender";
            this.memberGenderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.memberGenderDataGridViewTextBoxColumn.Name = "memberGenderDataGridViewTextBoxColumn";
            this.memberGenderDataGridViewTextBoxColumn.Width = 120;
            // 
            // paidDataGridViewTextBoxColumn
            // 
            this.paidDataGridViewTextBoxColumn.DataPropertyName = "Paid";
            this.paidDataGridViewTextBoxColumn.HeaderText = "Paid";
            this.paidDataGridViewTextBoxColumn.Name = "paidDataGridViewTextBoxColumn";
            this.paidDataGridViewTextBoxColumn.Width = 90;
            // 
            // RemainingAmount
            // 
            this.RemainingAmount.DataPropertyName = "RemainingAmount";
            this.RemainingAmount.HeaderText = "Remaining Amount";
            this.RemainingAmount.Name = "RemainingAmount";
            this.RemainingAmount.Width = 150;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.Width = 130;
            // 
            // SubscribtionID
            // 
            this.SubscribtionID.DataPropertyName = "SubscribtionID";
            this.SubscribtionID.HeaderText = "SubscribtionID";
            this.SubscribtionID.Name = "SubscribtionID";
            this.SubscribtionID.Visible = false;
            // 
            // MemberID
            // 
            this.MemberID.DataPropertyName = "MemberID";
            this.MemberID.HeaderText = "MemberID";
            this.MemberID.Name = "MemberID";
            this.MemberID.Visible = false;
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataSource = typeof(project.Member);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(439, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 45;
            this.label7.Text = "Name";
            // 
            // comboBoxEditGender
            // 
            this.comboBoxEditGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEditGender.FormattingEnabled = true;
            this.comboBoxEditGender.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.comboBoxEditGender.Location = new System.Drawing.Point(87, 347);
            this.comboBoxEditGender.Name = "comboBoxEditGender";
            this.comboBoxEditGender.Size = new System.Drawing.Size(203, 28);
            this.comboBoxEditGender.TabIndex = 35;
            // 
            // txtEditPaid
            // 
            this.txtEditPaid.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditPaid.Location = new System.Drawing.Point(87, 404);
            this.txtEditPaid.Name = "txtEditPaid";
            this.txtEditPaid.Size = new System.Drawing.Size(203, 28);
            this.txtEditPaid.TabIndex = 34;
            // 
            // txtEditAge
            // 
            this.txtEditAge.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditAge.Location = new System.Drawing.Point(87, 209);
            this.txtEditAge.Name = "txtEditAge";
            this.txtEditAge.Size = new System.Drawing.Size(203, 28);
            this.txtEditAge.TabIndex = 33;
            // 
            // txtEditPhone
            // 
            this.txtEditPhone.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditPhone.Location = new System.Drawing.Point(87, 281);
            this.txtEditPhone.Name = "txtEditPhone";
            this.txtEditPhone.Size = new System.Drawing.Size(203, 28);
            this.txtEditPhone.TabIndex = 32;
            // 
            // txtEditName
            // 
            this.txtEditName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditName.Location = new System.Drawing.Point(87, 140);
            this.txtEditName.Name = "txtEditName";
            this.txtEditName.Size = new System.Drawing.Size(203, 26);
            this.txtEditName.TabIndex = 31;
            this.txtEditName.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(9, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 21);
            this.label8.TabIndex = 30;
            this.label8.Text = "Age";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(6, 347);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 21);
            this.label9.TabIndex = 29;
            this.label9.Text = "Gender";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(9, 294);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 21);
            this.label11.TabIndex = 27;
            this.label11.Text = "Phone";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(9, 407);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 21);
            this.label12.TabIndex = 26;
            this.label12.Text = "paid";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(9, 146);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 21);
            this.label13.TabIndex = 25;
            this.label13.Text = "Name";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Green;
            this.btnEdit.Location = new System.Drawing.Point(736, 457);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(126, 40);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(554, 458);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Search.Location = new System.Drawing.Point(797, 70);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(125, 33);
            this.Search.TabIndex = 3;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.panel3.Location = new System.Drawing.Point(530, 99);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(247, 3);
            this.panel3.TabIndex = 2;
            // 
            // txtSearchName
            // 
            this.txtSearchName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.txtSearchName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtSearchName.Location = new System.Drawing.Point(532, 73);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(247, 19);
            this.txtSearchName.TabIndex = 1;
            this.txtSearchName.Text = "   Enter Name....";
            this.txtSearchName.Click += new System.EventHandler(this.txtSearchName_Click);
            // 
            // btnGetBarcode
            // 
            this.btnGetBarcode.BackColor = System.Drawing.Color.Transparent;
            this.btnGetBarcode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetBarcode.ForeColor = System.Drawing.Color.White;
            this.btnGetBarcode.Location = new System.Drawing.Point(767, 476);
            this.btnGetBarcode.Name = "btnGetBarcode";
            this.btnGetBarcode.Size = new System.Drawing.Size(155, 30);
            this.btnGetBarcode.TabIndex = 17;
            this.btnGetBarcode.Text = "Get Barcode";
            this.btnGetBarcode.UseVisualStyleBackColor = false;
            this.btnGetBarcode.Visible = false;
            this.btnGetBarcode.Click += new System.EventHandler(this.btnGetBarcode_Click);
            // 
            // lblAddmemberSuccess
            // 
            this.lblAddmemberSuccess.AutoSize = true;
            this.lblAddmemberSuccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddmemberSuccess.ForeColor = System.Drawing.Color.LightGreen;
            this.lblAddmemberSuccess.Location = new System.Drawing.Point(410, 386);
            this.lblAddmemberSuccess.Name = "lblAddmemberSuccess";
            this.lblAddmemberSuccess.Size = new System.Drawing.Size(0, 20);
            this.lblAddmemberSuccess.TabIndex = 15;
            this.lblAddmemberSuccess.Visible = false;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReset.Location = new System.Drawing.Point(531, 319);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(116, 37);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(148)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdd.Location = new System.Drawing.Point(374, 319);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(116, 37);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // comboBoxSubscribtion
            // 
            this.comboBoxSubscribtion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSubscribtion.FormattingEnabled = true;
            this.comboBoxSubscribtion.Location = new System.Drawing.Point(659, 129);
            this.comboBoxSubscribtion.Name = "comboBoxSubscribtion";
            this.comboBoxSubscribtion.Size = new System.Drawing.Size(203, 28);
            this.comboBoxSubscribtion.TabIndex = 11;
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.comboBoxGender.Location = new System.Drawing.Point(659, 61);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(203, 28);
            this.comboBoxGender.TabIndex = 10;
            // 
            // txtPaid
            // 
            this.txtPaid.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaid.Location = new System.Drawing.Point(659, 200);
            this.txtPaid.Name = "txtPaid";
            this.txtPaid.Size = new System.Drawing.Size(203, 28);
            this.txtPaid.TabIndex = 9;
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(261, 128);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(203, 28);
            this.txtAge.TabIndex = 8;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(261, 200);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(203, 28);
            this.txtPhone.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(261, 59);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(203, 26);
            this.txtName.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(132, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(527, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(527, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Subscribtion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(132, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(527, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "paid";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(132, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // Members
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 572);
            this.Controls.Add(this.panelAddMemeber);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Members";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Members";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelAddMemeber.ResumeLayout(false);
            this.panelAddMemeber.PerformLayout();
            this.panelFindMember.ResumeLayout(false);
            this.panelFindMember.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowMembers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddNewMember;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Button btnFindMember;
        private System.Windows.Forms.Panel panelAddMemeber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSubscribtion;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.TextBox txtPaid;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panelFindMember;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Label lblAddmemberSuccess;
        private System.Windows.Forms.Button btnGetBarcode;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEdit;
        public System.Windows.Forms.ComboBox comboBoxEditGender;
        public System.Windows.Forms.TextBox txtEditPaid;
        public System.Windows.Forms.TextBox txtEditAge;
        public System.Windows.Forms.TextBox txtEditPhone;
        public System.Windows.Forms.TextBox txtEditName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dataGridViewShowMembers;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn remainingAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberAgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberGenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RemainingAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubscribtionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberID;
        private System.Windows.Forms.Label label7;
    }
}