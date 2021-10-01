
namespace project
{
    partial class SupplementsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblClose = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddSupp = new System.Windows.Forms.Button();
            this.btnFindSupp = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Search = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panelSearchSupp = new System.Windows.Forms.Panel();
            this.panelAddSupp = new System.Windows.Forms.Panel();
            this.lblAddSuccess = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.comboBoxTime = new System.Windows.Forms.ComboBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.MaskedTextBox();
            this.txtName = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxSearch = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxEditTime = new System.Windows.Forms.ComboBox();
            this.comboBoxEditType = new System.Windows.Forms.ComboBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtEditPrice = new System.Windows.Forms.MaskedTextBox();
            this.txtEditName = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewShowSupp = new System.Windows.Forms.DataGridView();
            this.supplementNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplementIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplementBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panelSearchSupp.SuspendLayout();
            this.panelAddSupp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowSupp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplementBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.Red;
            this.lblClose.Location = new System.Drawing.Point(935, 9);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(21, 20);
            this.lblClose.TabIndex = 3;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(105)))));
            this.panel1.Controls.Add(this.btnAddSupp);
            this.panel1.Controls.Add(this.lblClose);
            this.panel1.Controls.Add(this.btnFindSupp);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(968, 36);
            this.panel1.TabIndex = 5;
            // 
            // btnAddSupp
            // 
            this.btnAddSupp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(105)))));
            this.btnAddSupp.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddSupp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSupp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSupp.ForeColor = System.Drawing.Color.White;
            this.btnAddSupp.Location = new System.Drawing.Point(213, 0);
            this.btnAddSupp.Name = "btnAddSupp";
            this.btnAddSupp.Size = new System.Drawing.Size(213, 36);
            this.btnAddSupp.TabIndex = 30;
            this.btnAddSupp.Text = "Add New Supplement";
            this.btnAddSupp.UseVisualStyleBackColor = false;
            this.btnAddSupp.Click += new System.EventHandler(this.btnAddSupp_Click);
            // 
            // btnFindSupp
            // 
            this.btnFindSupp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(105)))));
            this.btnFindSupp.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnFindSupp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindSupp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindSupp.ForeColor = System.Drawing.Color.White;
            this.btnFindSupp.Location = new System.Drawing.Point(0, 0);
            this.btnFindSupp.Name = "btnFindSupp";
            this.btnFindSupp.Size = new System.Drawing.Size(213, 36);
            this.btnFindSupp.TabIndex = 29;
            this.btnFindSupp.Text = "Search Supplement";
            this.btnFindSupp.UseVisualStyleBackColor = false;
            this.btnFindSupp.Click += new System.EventHandler(this.btnFindSupp_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView2);
            this.panel4.Controls.Add(this.Search);
            this.panel4.Controls.Add(this.comboBox1);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(0, 36);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(834, 473);
            this.panel4.TabIndex = 28;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.GridColor = System.Drawing.Color.White;
            this.dataGridView2.Location = new System.Drawing.Point(90, 141);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 600;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.Size = new System.Drawing.Size(504, 213);
            this.dataGridView2.TabIndex = 5;
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Search.Location = new System.Drawing.Point(445, 53);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(125, 33);
            this.Search.TabIndex = 4;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(161, 61);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(265, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(95, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "LevelId";
            // 
            // panelSearchSupp
            // 
            this.panelSearchSupp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.panelSearchSupp.Controls.Add(this.panelAddSupp);
            this.panelSearchSupp.Controls.Add(this.comboBoxSearch);
            this.panelSearchSupp.Controls.Add(this.label2);
            this.panelSearchSupp.Controls.Add(this.comboBoxEditTime);
            this.panelSearchSupp.Controls.Add(this.comboBoxEditType);
            this.panelSearchSupp.Controls.Add(this.btnEdit);
            this.panelSearchSupp.Controls.Add(this.btnDelete);
            this.panelSearchSupp.Controls.Add(this.btnSearch);
            this.panelSearchSupp.Controls.Add(this.txtEditPrice);
            this.panelSearchSupp.Controls.Add(this.txtEditName);
            this.panelSearchSupp.Controls.Add(this.label6);
            this.panelSearchSupp.Controls.Add(this.label5);
            this.panelSearchSupp.Controls.Add(this.label4);
            this.panelSearchSupp.Controls.Add(this.label3);
            this.panelSearchSupp.Controls.Add(this.dataGridViewShowSupp);
            this.panelSearchSupp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSearchSupp.Location = new System.Drawing.Point(0, 36);
            this.panelSearchSupp.Name = "panelSearchSupp";
            this.panelSearchSupp.Size = new System.Drawing.Size(968, 539);
            this.panelSearchSupp.TabIndex = 29;
            // 
            // panelAddSupp
            // 
            this.panelAddSupp.Controls.Add(this.lblAddSuccess);
            this.panelAddSupp.Controls.Add(this.btnReset);
            this.panelAddSupp.Controls.Add(this.btnAdd);
            this.panelAddSupp.Controls.Add(this.comboBoxTime);
            this.panelAddSupp.Controls.Add(this.comboBoxType);
            this.panelAddSupp.Controls.Add(this.txtPrice);
            this.panelAddSupp.Controls.Add(this.txtName);
            this.panelAddSupp.Controls.Add(this.label7);
            this.panelAddSupp.Controls.Add(this.label9);
            this.panelAddSupp.Controls.Add(this.label10);
            this.panelAddSupp.Controls.Add(this.label11);
            this.panelAddSupp.Controls.Add(this.pictureBox1);
            this.panelAddSupp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAddSupp.Location = new System.Drawing.Point(0, 0);
            this.panelAddSupp.Name = "panelAddSupp";
            this.panelAddSupp.Size = new System.Drawing.Size(968, 539);
            this.panelAddSupp.TabIndex = 51;
            // 
            // lblAddSuccess
            // 
            this.lblAddSuccess.AutoSize = true;
            this.lblAddSuccess.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddSuccess.ForeColor = System.Drawing.Color.Green;
            this.lblAddSuccess.Location = new System.Drawing.Point(110, 460);
            this.lblAddSuccess.Name = "lblAddSuccess";
            this.lblAddSuccess.Size = new System.Drawing.Size(215, 23);
            this.lblAddSuccess.TabIndex = 65;
            this.lblAddSuccess.Text = "Data Added Successfully";
            this.lblAddSuccess.Visible = false;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReset.Location = new System.Drawing.Point(232, 387);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(116, 37);
            this.btnReset.TabIndex = 64;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(148)))));
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdd.Location = new System.Drawing.Point(75, 387);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(116, 37);
            this.btnAdd.TabIndex = 63;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // comboBoxTime
            // 
            this.comboBoxTime.FormattingEnabled = true;
            this.comboBoxTime.Items.AddRange(new object[] {
            "Before Training",
            "After Training"});
            this.comboBoxTime.Location = new System.Drawing.Point(161, 312);
            this.comboBoxTime.Name = "comboBoxTime";
            this.comboBoxTime.Size = new System.Drawing.Size(187, 21);
            this.comboBoxTime.TabIndex = 62;
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Cutting",
            "Bulking"});
            this.comboBoxType.Location = new System.Drawing.Point(161, 185);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(187, 21);
            this.comboBoxType.TabIndex = 61;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(161, 246);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(187, 20);
            this.txtPrice.TabIndex = 56;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(161, 115);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(187, 20);
            this.txtName.TabIndex = 55;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(79, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 19);
            this.label7.TabIndex = 54;
            this.label7.Text = "Time";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(79, 246);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 19);
            this.label9.TabIndex = 53;
            this.label9.Text = "Price";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(79, 187);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 19);
            this.label10.TabIndex = 52;
            this.label10.Text = "Type";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(79, 115);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 19);
            this.label11.TabIndex = 51;
            this.label11.Text = "Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::project.Properties.Resources.unnamed;
            this.pictureBox1.Location = new System.Drawing.Point(445, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 384);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 66;
            this.pictureBox1.TabStop = false;
            // 
            // comboBoxSearch
            // 
            this.comboBoxSearch.FormattingEnabled = true;
            this.comboBoxSearch.Items.AddRange(new object[] {
            "Bulking",
            "Cutting"});
            this.comboBoxSearch.Location = new System.Drawing.Point(364, 94);
            this.comboBoxSearch.Name = "comboBoxSearch";
            this.comboBoxSearch.Size = new System.Drawing.Size(189, 21);
            this.comboBoxSearch.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(297, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 49;
            this.label2.Text = "Name";
            // 
            // comboBoxEditTime
            // 
            this.comboBoxEditTime.FormattingEnabled = true;
            this.comboBoxEditTime.Items.AddRange(new object[] {
            "Before Training",
            "After Training"});
            this.comboBoxEditTime.Location = new System.Drawing.Point(99, 360);
            this.comboBoxEditTime.Name = "comboBoxEditTime";
            this.comboBoxEditTime.Size = new System.Drawing.Size(187, 21);
            this.comboBoxEditTime.TabIndex = 48;
            // 
            // comboBoxEditType
            // 
            this.comboBoxEditType.FormattingEnabled = true;
            this.comboBoxEditType.Items.AddRange(new object[] {
            "Cutting",
            "Bulking"});
            this.comboBoxEditType.Location = new System.Drawing.Point(99, 304);
            this.comboBoxEditType.Name = "comboBoxEditType";
            this.comboBoxEditType.Size = new System.Drawing.Size(187, 21);
            this.comboBoxEditType.TabIndex = 47;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Green;
            this.btnEdit.Location = new System.Drawing.Point(687, 430);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(128, 40);
            this.btnEdit.TabIndex = 46;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.Location = new System.Drawing.Point(510, 430);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(128, 40);
            this.btnDelete.TabIndex = 45;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSearch.Location = new System.Drawing.Point(576, 86);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(125, 33);
            this.btnSearch.TabIndex = 21;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtEditPrice
            // 
            this.txtEditPrice.Location = new System.Drawing.Point(99, 249);
            this.txtEditPrice.Name = "txtEditPrice";
            this.txtEditPrice.Size = new System.Drawing.Size(187, 20);
            this.txtEditPrice.TabIndex = 13;
            // 
            // txtEditName
            // 
            this.txtEditName.Location = new System.Drawing.Point(99, 201);
            this.txtEditName.Name = "txtEditName";
            this.txtEditName.Size = new System.Drawing.Size(187, 20);
            this.txtEditName.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(35, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(40, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(40, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Type";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(40, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Name";
            // 
            // dataGridViewShowSupp
            // 
            this.dataGridViewShowSupp.AllowUserToOrderColumns = true;
            this.dataGridViewShowSupp.AutoGenerateColumns = false;
            this.dataGridViewShowSupp.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.dataGridViewShowSupp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewShowSupp.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewShowSupp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewShowSupp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShowSupp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.supplementNameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.timingDataGridViewTextBoxColumn,
            this.supplementIDDataGridViewTextBoxColumn});
            this.dataGridViewShowSupp.DataSource = this.supplementBindingSource1;
            this.dataGridViewShowSupp.EnableHeadersVisualStyles = false;
            this.dataGridViewShowSupp.GridColor = System.Drawing.Color.White;
            this.dataGridViewShowSupp.Location = new System.Drawing.Point(433, 185);
            this.dataGridViewShowSupp.Name = "dataGridViewShowSupp";
            this.dataGridViewShowSupp.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewShowSupp.RowHeadersVisible = false;
            this.dataGridViewShowSupp.RowHeadersWidth = 60;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewShowSupp.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewShowSupp.Size = new System.Drawing.Size(440, 223);
            this.dataGridViewShowSupp.TabIndex = 52;
            this.dataGridViewShowSupp.SelectionChanged += new System.EventHandler(this.dataGridViewShowSupp_SelectionChanged_1);
            // 
            // supplementNameDataGridViewTextBoxColumn
            // 
            this.supplementNameDataGridViewTextBoxColumn.DataPropertyName = "SupplementName";
            this.supplementNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.supplementNameDataGridViewTextBoxColumn.Name = "supplementNameDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // timingDataGridViewTextBoxColumn
            // 
            this.timingDataGridViewTextBoxColumn.DataPropertyName = "Timing";
            this.timingDataGridViewTextBoxColumn.HeaderText = "Timing";
            this.timingDataGridViewTextBoxColumn.Name = "timingDataGridViewTextBoxColumn";
            // 
            // supplementIDDataGridViewTextBoxColumn
            // 
            this.supplementIDDataGridViewTextBoxColumn.DataPropertyName = "SupplementID";
            this.supplementIDDataGridViewTextBoxColumn.HeaderText = "SupplementID";
            this.supplementIDDataGridViewTextBoxColumn.Name = "supplementIDDataGridViewTextBoxColumn";
            this.supplementIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // supplementBindingSource1
            // 
            this.supplementBindingSource1.DataSource = typeof(project.Supplement);
            // 
            // SupplementsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 575);
            this.Controls.Add(this.panelSearchSupp);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SupplementsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SupplementsForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panelSearchSupp.ResumeLayout(false);
            this.panelSearchSupp.PerformLayout();
            this.panelAddSupp.ResumeLayout(false);
            this.panelAddSupp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowSupp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplementBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddSupp;
        private System.Windows.Forms.Button btnFindSupp;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panelSearchSupp;
        private System.Windows.Forms.MaskedTextBox txtEditPrice;
        private System.Windows.Forms.MaskedTextBox txtEditName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox comboBoxEditTime;
        private System.Windows.Forms.ComboBox comboBoxEditType;
        private System.Windows.Forms.ComboBox comboBoxSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelAddSupp;
        private System.Windows.Forms.ComboBox comboBoxTime;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.MaskedTextBox txtPrice;
        private System.Windows.Forms.MaskedTextBox txtName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAddSuccess;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.DataGridView dataGridViewShowSupp;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplementNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplementIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource supplementBindingSource1;
    }
}