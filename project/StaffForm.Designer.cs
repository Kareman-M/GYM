
namespace project
{
    partial class StaffForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblClose = new System.Windows.Forms.Label();
            this.btnFindMember = new System.Windows.Forms.Button();
            this.btnAddNewWorker = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.comboBoxPosition = new System.Windows.Forms.ComboBox();
            this.comboBoxShift = new System.Windows.Forms.ComboBox();
            this.dateTimePickerBirthdate = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblAddWorkerSuccess = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelAddWorker = new System.Windows.Forms.Panel();
            this.panelFindWorker = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxSearchBuPosition = new System.Windows.Forms.ComboBox();
            this.comboBoxEditShift = new System.Windows.Forms.ComboBox();
            this.comboBoxEditPosition = new System.Windows.Forms.ComboBox();
            this.txtEditSalary = new System.Windows.Forms.TextBox();
            this.txtEditPhone = new System.Windows.Forms.TextBox();
            this.txtEditName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewShowStaff = new System.Windows.Forms.DataGridView();
            this.workerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hireDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birhtdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Search = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelAddWorker.SuspendLayout();
            this.panelFindWorker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowStaff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(105)))));
            this.panel1.Controls.Add(this.lblClose);
            this.panel1.Controls.Add(this.btnFindMember);
            this.panel1.Controls.Add(this.btnAddNewWorker);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1016, 36);
            this.panel1.TabIndex = 4;
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
            this.btnFindMember.Text = "Find Worker";
            this.btnFindMember.UseVisualStyleBackColor = false;
            this.btnFindMember.Click += new System.EventHandler(this.btnFindMember_Click);
            // 
            // btnAddNewWorker
            // 
            this.btnAddNewWorker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(105)))));
            this.btnAddNewWorker.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddNewWorker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewWorker.ForeColor = System.Drawing.Color.White;
            this.btnAddNewWorker.Location = new System.Drawing.Point(0, 0);
            this.btnAddNewWorker.Name = "btnAddNewWorker";
            this.btnAddNewWorker.Size = new System.Drawing.Size(213, 36);
            this.btnAddNewWorker.TabIndex = 1;
            this.btnAddNewWorker.Text = "Add Worker";
            this.btnAddNewWorker.UseVisualStyleBackColor = false;
            this.btnAddNewWorker.Click += new System.EventHandler(this.btnAddNewWorker_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(129, 131);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 21);
            this.label13.TabIndex = 38;
            this.label13.Text = "Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(559, 327);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 21);
            this.label12.TabIndex = 39;
            this.label12.Text = "Birthdate";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(129, 234);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 21);
            this.label11.TabIndex = 40;
            this.label11.Text = "Phone";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(126, 333);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 21);
            this.label10.TabIndex = 41;
            this.label10.Text = "Shift";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(562, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 21);
            this.label9.TabIndex = 42;
            this.label9.Text = "Position";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(562, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 21);
            this.label8.TabIndex = 43;
            this.label8.Text = "Salary";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(244, 131);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(203, 26);
            this.txtName.TabIndex = 44;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(244, 227);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(203, 28);
            this.txtPhone.TabIndex = 45;
            // 
            // txtSalary
            // 
            this.txtSalary.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.Location = new System.Drawing.Point(677, 126);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(203, 28);
            this.txtSalary.TabIndex = 46;
            // 
            // comboBoxPosition
            // 
            this.comboBoxPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPosition.FormattingEnabled = true;
            this.comboBoxPosition.Items.AddRange(new object[] {
            "Coffee Worker",
            "Trainer",
            " Janitor",
            "Receptionist"});
            this.comboBoxPosition.Location = new System.Drawing.Point(677, 222);
            this.comboBoxPosition.Name = "comboBoxPosition";
            this.comboBoxPosition.Size = new System.Drawing.Size(203, 28);
            this.comboBoxPosition.TabIndex = 48;
            this.comboBoxPosition.MouseDown += new System.Windows.Forms.MouseEventHandler(this.comboBoxPosition_MouseDown);
            // 
            // comboBoxShift
            // 
            this.comboBoxShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxShift.FormattingEnabled = true;
            this.comboBoxShift.Items.AddRange(new object[] {
            "Morning",
            "Night"});
            this.comboBoxShift.Location = new System.Drawing.Point(244, 328);
            this.comboBoxShift.Name = "comboBoxShift";
            this.comboBoxShift.Size = new System.Drawing.Size(203, 28);
            this.comboBoxShift.TabIndex = 49;
            // 
            // dateTimePickerBirthdate
            // 
            this.dateTimePickerBirthdate.Location = new System.Drawing.Point(677, 327);
            this.dateTimePickerBirthdate.Name = "dateTimePickerBirthdate";
            this.dateTimePickerBirthdate.Size = new System.Drawing.Size(203, 20);
            this.dateTimePickerBirthdate.TabIndex = 50;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(148)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdd.Location = new System.Drawing.Point(411, 426);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(116, 37);
            this.btnAdd.TabIndex = 51;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReset.Location = new System.Drawing.Point(568, 426);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(116, 37);
            this.btnReset.TabIndex = 52;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblAddWorkerSuccess
            // 
            this.lblAddWorkerSuccess.AutoSize = true;
            this.lblAddWorkerSuccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddWorkerSuccess.ForeColor = System.Drawing.Color.LightGreen;
            this.lblAddWorkerSuccess.Location = new System.Drawing.Point(447, 493);
            this.lblAddWorkerSuccess.Name = "lblAddWorkerSuccess";
            this.lblAddWorkerSuccess.Size = new System.Drawing.Size(0, 20);
            this.lblAddWorkerSuccess.TabIndex = 53;
            this.lblAddWorkerSuccess.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::project.Properties.Resources.icons8_coworking_48;
            this.pictureBox1.Location = new System.Drawing.Point(501, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 50);
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // panelAddWorker
            // 
            this.panelAddWorker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.panelAddWorker.Controls.Add(this.panelFindWorker);
            this.panelAddWorker.Controls.Add(this.pictureBox1);
            this.panelAddWorker.Controls.Add(this.lblAddWorkerSuccess);
            this.panelAddWorker.Controls.Add(this.btnReset);
            this.panelAddWorker.Controls.Add(this.btnAdd);
            this.panelAddWorker.Controls.Add(this.dateTimePickerBirthdate);
            this.panelAddWorker.Controls.Add(this.comboBoxShift);
            this.panelAddWorker.Controls.Add(this.comboBoxPosition);
            this.panelAddWorker.Controls.Add(this.txtSalary);
            this.panelAddWorker.Controls.Add(this.txtPhone);
            this.panelAddWorker.Controls.Add(this.txtName);
            this.panelAddWorker.Controls.Add(this.label8);
            this.panelAddWorker.Controls.Add(this.label9);
            this.panelAddWorker.Controls.Add(this.label10);
            this.panelAddWorker.Controls.Add(this.label11);
            this.panelAddWorker.Controls.Add(this.label12);
            this.panelAddWorker.Controls.Add(this.label13);
            this.panelAddWorker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAddWorker.Location = new System.Drawing.Point(0, 36);
            this.panelAddWorker.Name = "panelAddWorker";
            this.panelAddWorker.Size = new System.Drawing.Size(1016, 536);
            this.panelAddWorker.TabIndex = 5;
            // 
            // panelFindWorker
            // 
            this.panelFindWorker.Controls.Add(this.label5);
            this.panelFindWorker.Controls.Add(this.comboBoxSearchBuPosition);
            this.panelFindWorker.Controls.Add(this.comboBoxEditShift);
            this.panelFindWorker.Controls.Add(this.comboBoxEditPosition);
            this.panelFindWorker.Controls.Add(this.txtEditSalary);
            this.panelFindWorker.Controls.Add(this.txtEditPhone);
            this.panelFindWorker.Controls.Add(this.txtEditName);
            this.panelFindWorker.Controls.Add(this.label1);
            this.panelFindWorker.Controls.Add(this.label2);
            this.panelFindWorker.Controls.Add(this.label3);
            this.panelFindWorker.Controls.Add(this.label4);
            this.panelFindWorker.Controls.Add(this.label6);
            this.panelFindWorker.Controls.Add(this.btnEdit);
            this.panelFindWorker.Controls.Add(this.button1);
            this.panelFindWorker.Controls.Add(this.dataGridViewShowStaff);
            this.panelFindWorker.Controls.Add(this.Search);
            this.panelFindWorker.Controls.Add(this.panel4);
            this.panelFindWorker.Controls.Add(this.txtSearchName);
            this.panelFindWorker.Controls.Add(this.label7);
            this.panelFindWorker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFindWorker.Location = new System.Drawing.Point(0, 0);
            this.panelFindWorker.Name = "panelFindWorker";
            this.panelFindWorker.Size = new System.Drawing.Size(1016, 536);
            this.panelFindWorker.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(568, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 20);
            this.label5.TabIndex = 59;
            this.label5.Text = "Search by Position";
            // 
            // comboBoxSearchBuPosition
            // 
            this.comboBoxSearchBuPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSearchBuPosition.FormattingEnabled = true;
            this.comboBoxSearchBuPosition.Items.AddRange(new object[] {
            "All",
            "Coffee Worker",
            "Trainer",
            " Janitor",
            "Receptionist"});
            this.comboBoxSearchBuPosition.Location = new System.Drawing.Point(714, 59);
            this.comboBoxSearchBuPosition.Name = "comboBoxSearchBuPosition";
            this.comboBoxSearchBuPosition.Size = new System.Drawing.Size(203, 28);
            this.comboBoxSearchBuPosition.TabIndex = 58;
            this.comboBoxSearchBuPosition.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBoxEditShift
            // 
            this.comboBoxEditShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEditShift.FormattingEnabled = true;
            this.comboBoxEditShift.Items.AddRange(new object[] {
            "Night",
            "Morning"});
            this.comboBoxEditShift.Location = new System.Drawing.Point(133, 414);
            this.comboBoxEditShift.Name = "comboBoxEditShift";
            this.comboBoxEditShift.Size = new System.Drawing.Size(203, 28);
            this.comboBoxEditShift.TabIndex = 56;
            // 
            // comboBoxEditPosition
            // 
            this.comboBoxEditPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEditPosition.FormattingEnabled = true;
            this.comboBoxEditPosition.Items.AddRange(new object[] {
            "Coffee Worker",
            "Trainer",
            " Janitor",
            "Receptionist"});
            this.comboBoxEditPosition.Location = new System.Drawing.Point(133, 346);
            this.comboBoxEditPosition.Name = "comboBoxEditPosition";
            this.comboBoxEditPosition.Size = new System.Drawing.Size(203, 28);
            this.comboBoxEditPosition.TabIndex = 55;
            // 
            // txtEditSalary
            // 
            this.txtEditSalary.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditSalary.Location = new System.Drawing.Point(133, 212);
            this.txtEditSalary.Name = "txtEditSalary";
            this.txtEditSalary.Size = new System.Drawing.Size(203, 28);
            this.txtEditSalary.TabIndex = 53;
            // 
            // txtEditPhone
            // 
            this.txtEditPhone.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditPhone.Location = new System.Drawing.Point(133, 284);
            this.txtEditPhone.Name = "txtEditPhone";
            this.txtEditPhone.Size = new System.Drawing.Size(203, 28);
            this.txtEditPhone.TabIndex = 52;
            // 
            // txtEditName
            // 
            this.txtEditName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditName.Location = new System.Drawing.Point(133, 143);
            this.txtEditName.Name = "txtEditName";
            this.txtEditName.Size = new System.Drawing.Size(203, 26);
            this.txtEditName.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 21);
            this.label1.TabIndex = 50;
            this.label1.Text = "Salary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 21);
            this.label2.TabIndex = 49;
            this.label2.Text = "Position";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 419);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 21);
            this.label3.TabIndex = 48;
            this.label3.Text = "Shift";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(18, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 21);
            this.label4.TabIndex = 47;
            this.label4.Text = "Phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(18, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 21);
            this.label6.TabIndex = 45;
            this.label6.Text = "Name";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Green;
            this.btnEdit.Location = new System.Drawing.Point(714, 449);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(128, 40);
            this.btnEdit.TabIndex = 44;
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
            this.button1.Location = new System.Drawing.Point(533, 449);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 40);
            this.button1.TabIndex = 43;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewShowStaff
            // 
            this.dataGridViewShowStaff.AllowUserToOrderColumns = true;
            this.dataGridViewShowStaff.AutoGenerateColumns = false;
            this.dataGridViewShowStaff.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.dataGridViewShowStaff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewShowStaff.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewShowStaff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewShowStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShowStaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.workerNameDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn,
            this.shiftDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.hireDateDataGridViewTextBoxColumn,
            this.birhtdateDataGridViewTextBoxColumn,
            this.workerIDDataGridViewTextBoxColumn});
            this.dataGridViewShowStaff.DataSource = this.workerBindingSource;
            this.dataGridViewShowStaff.EnableHeadersVisualStyles = false;
            this.dataGridViewShowStaff.GridColor = System.Drawing.Color.White;
            this.dataGridViewShowStaff.Location = new System.Drawing.Point(342, 134);
            this.dataGridViewShowStaff.Name = "dataGridViewShowStaff";
            this.dataGridViewShowStaff.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewShowStaff.RowHeadersVisible = false;
            this.dataGridViewShowStaff.RowHeadersWidth = 60;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewShowStaff.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewShowStaff.Size = new System.Drawing.Size(664, 271);
            this.dataGridViewShowStaff.TabIndex = 42;
            this.dataGridViewShowStaff.SelectionChanged += new System.EventHandler(this.dataGridViewShowStaff_SelectionChanged);
            // 
            // workerNameDataGridViewTextBoxColumn
            // 
            this.workerNameDataGridViewTextBoxColumn.DataPropertyName = "WorkerName";
            this.workerNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.workerNameDataGridViewTextBoxColumn.Name = "workerNameDataGridViewTextBoxColumn";
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "Salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "Salary";
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "Position";
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            // 
            // shiftDataGridViewTextBoxColumn
            // 
            this.shiftDataGridViewTextBoxColumn.DataPropertyName = "Shift";
            this.shiftDataGridViewTextBoxColumn.HeaderText = "Shift";
            this.shiftDataGridViewTextBoxColumn.Name = "shiftDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // hireDateDataGridViewTextBoxColumn
            // 
            this.hireDateDataGridViewTextBoxColumn.DataPropertyName = "HireDate";
            this.hireDateDataGridViewTextBoxColumn.HeaderText = "HireDate";
            this.hireDateDataGridViewTextBoxColumn.Name = "hireDateDataGridViewTextBoxColumn";
            this.hireDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // birhtdateDataGridViewTextBoxColumn
            // 
            this.birhtdateDataGridViewTextBoxColumn.DataPropertyName = "Birhtdate";
            this.birhtdateDataGridViewTextBoxColumn.HeaderText = "Birhtdate";
            this.birhtdateDataGridViewTextBoxColumn.Name = "birhtdateDataGridViewTextBoxColumn";
            this.birhtdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // workerIDDataGridViewTextBoxColumn
            // 
            this.workerIDDataGridViewTextBoxColumn.DataPropertyName = "WorkerID";
            this.workerIDDataGridViewTextBoxColumn.HeaderText = "WorkerID";
            this.workerIDDataGridViewTextBoxColumn.Name = "workerIDDataGridViewTextBoxColumn";
            this.workerIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // workerBindingSource
            // 
            this.workerBindingSource.DataSource = typeof(project.Worker);
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Search.Location = new System.Drawing.Point(370, 54);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(125, 33);
            this.Search.TabIndex = 41;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.panel4.Location = new System.Drawing.Point(103, 83);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(247, 3);
            this.panel4.TabIndex = 40;
            // 
            // txtSearchName
            // 
            this.txtSearchName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.txtSearchName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtSearchName.Location = new System.Drawing.Point(104, 46);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(247, 19);
            this.txtSearchName.TabIndex = 39;
            this.txtSearchName.Text = "   Enter Name....";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(45, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 38;
            this.label7.Text = "Name";
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 572);
            this.Controls.Add(this.panelAddWorker);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StaffForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelAddWorker.ResumeLayout(false);
            this.panelAddWorker.PerformLayout();
            this.panelFindWorker.ResumeLayout(false);
            this.panelFindWorker.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowStaff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Button btnFindMember;
        private System.Windows.Forms.Button btnAddNewWorker;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.TextBox txtPhone;
        public System.Windows.Forms.TextBox txtSalary;
        public System.Windows.Forms.ComboBox comboBoxPosition;
        public System.Windows.Forms.ComboBox comboBoxShift;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblAddWorkerSuccess;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelAddWorker;
        private System.Windows.Forms.Panel panelFindWorker;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox comboBoxSearchBuPosition;
        public System.Windows.Forms.ComboBox comboBoxEditShift;
        public System.Windows.Forms.ComboBox comboBoxEditPosition;
        public System.Windows.Forms.TextBox txtEditSalary;
        public System.Windows.Forms.TextBox txtEditPhone;
        public System.Windows.Forms.TextBox txtEditName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.DataGridView dataGridViewShowStaff;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shiftDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hireDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birhtdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource workerBindingSource;
    }
}