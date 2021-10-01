
namespace project
{
    partial class income
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblClose = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Search = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbltNetProfit = new System.Windows.Forms.Label();
            this.lblNet = new System.Windows.Forms.Label();
            this.lblTotalExpenses = new System.Windows.Forms.Label();
            this.lblExpenses = new System.Windows.Forms.Label();
            this.lblTotalRevenue = new System.Windows.Forms.Label();
            this.lblRevenue = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtEBill = new System.Windows.Forms.TextBox();
            this.txtGBill = new System.Windows.Forms.TextBox();
            this.txtWBill = new System.Windows.Forms.TextBox();
            this.txtRepairs = new System.Windows.Forms.TextBox();
            this.txtCoffee = new System.Windows.Forms.TextBox();
            this.txtOther = new System.Windows.Forms.TextBox();
            this.txtSub = new System.Windows.Forms.TextBox();
            this.comboBoxEditShift = new System.Windows.Forms.ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panelFind = new System.Windows.Forms.Panel();
            this.comboBoxSearchShift = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFindSub = new System.Windows.Forms.TextBox();
            this.txtFindOther = new System.Windows.Forms.TextBox();
            this.txtFindCofe = new System.Windows.Forms.TextBox();
            this.txtFindRepairs = new System.Windows.Forms.TextBox();
            this.txtFindWB = new System.Windows.Forms.TextBox();
            this.txtFindGB = new System.Windows.Forms.TextBox();
            this.txtFindEB = new System.Windows.Forms.TextBox();
            this.lblFingNet = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dateTimePickerFind = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panelAdd.SuspendLayout();
            this.panelFind.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(105)))));
            this.panel1.Controls.Add(this.btnFind);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.lblClose);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(981, 36);
            this.panel1.TabIndex = 6;
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.GridColor = System.Drawing.Color.White;
            this.dataGridView2.Location = new System.Drawing.Point(90, 141);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 600;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle6;
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
            // panelAdd
            // 
            this.panelAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.panelAdd.Controls.Add(this.panelFind);
            this.panelAdd.Controls.Add(this.button2);
            this.panelAdd.Controls.Add(this.panel5);
            this.panelAdd.Controls.Add(this.lbltNetProfit);
            this.panelAdd.Controls.Add(this.lblNet);
            this.panelAdd.Controls.Add(this.lblTotalExpenses);
            this.panelAdd.Controls.Add(this.lblExpenses);
            this.panelAdd.Controls.Add(this.lblTotalRevenue);
            this.panelAdd.Controls.Add(this.lblRevenue);
            this.panelAdd.Controls.Add(this.panel3);
            this.panelAdd.Controls.Add(this.txtEBill);
            this.panelAdd.Controls.Add(this.txtGBill);
            this.panelAdd.Controls.Add(this.txtWBill);
            this.panelAdd.Controls.Add(this.txtRepairs);
            this.panelAdd.Controls.Add(this.txtCoffee);
            this.panelAdd.Controls.Add(this.txtOther);
            this.panelAdd.Controls.Add(this.txtSub);
            this.panelAdd.Controls.Add(this.comboBoxEditShift);
            this.panelAdd.Controls.Add(this.panel6);
            this.panelAdd.Controls.Add(this.label10);
            this.panelAdd.Controls.Add(this.label14);
            this.panelAdd.Controls.Add(this.label15);
            this.panelAdd.Controls.Add(this.label16);
            this.panelAdd.Controls.Add(this.label17);
            this.panelAdd.Controls.Add(this.label18);
            this.panelAdd.Controls.Add(this.label19);
            this.panelAdd.Controls.Add(this.label20);
            this.panelAdd.Controls.Add(this.pictureBox1);
            this.panelAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAdd.Location = new System.Drawing.Point(0, 36);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(981, 510);
            this.panelAdd.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.button2.Location = new System.Drawing.Point(278, 417);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 43);
            this.button2.TabIndex = 159;
            this.button2.Text = "Submit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Maroon;
            this.panel5.ForeColor = System.Drawing.Color.Transparent;
            this.panel5.Location = new System.Drawing.Point(683, 60);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(3, 28);
            this.panel5.TabIndex = 152;
            // 
            // lbltNetProfit
            // 
            this.lbltNetProfit.AutoSize = true;
            this.lbltNetProfit.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltNetProfit.ForeColor = System.Drawing.Color.White;
            this.lbltNetProfit.Location = new System.Drawing.Point(854, 144);
            this.lbltNetProfit.Name = "lbltNetProfit";
            this.lbltNetProfit.Size = new System.Drawing.Size(65, 23);
            this.lbltNetProfit.TabIndex = 157;
            this.lbltNetProfit.Text = "15698";
            this.lbltNetProfit.Visible = false;
            // 
            // lblNet
            // 
            this.lblNet.AutoSize = true;
            this.lblNet.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNet.ForeColor = System.Drawing.Color.White;
            this.lblNet.Location = new System.Drawing.Point(744, 145);
            this.lblNet.Name = "lblNet";
            this.lblNet.Size = new System.Drawing.Size(90, 20);
            this.lblNet.TabIndex = 156;
            this.lblNet.Text = "Net profit :";
            this.lblNet.Visible = false;
            // 
            // lblTotalExpenses
            // 
            this.lblTotalExpenses.AutoSize = true;
            this.lblTotalExpenses.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalExpenses.ForeColor = System.Drawing.Color.White;
            this.lblTotalExpenses.Location = new System.Drawing.Point(844, 60);
            this.lblTotalExpenses.Name = "lblTotalExpenses";
            this.lblTotalExpenses.Size = new System.Drawing.Size(65, 23);
            this.lblTotalExpenses.TabIndex = 155;
            this.lblTotalExpenses.Text = "15698";
            this.lblTotalExpenses.Visible = false;
            // 
            // lblExpenses
            // 
            this.lblExpenses.AutoSize = true;
            this.lblExpenses.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpenses.ForeColor = System.Drawing.Color.White;
            this.lblExpenses.Location = new System.Drawing.Point(711, 63);
            this.lblExpenses.Name = "lblExpenses";
            this.lblExpenses.Size = new System.Drawing.Size(128, 20);
            this.lblExpenses.TabIndex = 154;
            this.lblExpenses.Text = "Total Expenses :";
            this.lblExpenses.Visible = false;
            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.AutoSize = true;
            this.lblTotalRevenue.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRevenue.ForeColor = System.Drawing.Color.White;
            this.lblTotalRevenue.Location = new System.Drawing.Point(603, 63);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Size = new System.Drawing.Size(65, 23);
            this.lblTotalRevenue.TabIndex = 153;
            this.lblTotalRevenue.Text = "15698";
            this.lblTotalRevenue.Visible = false;
            // 
            // lblRevenue
            // 
            this.lblRevenue.AutoSize = true;
            this.lblRevenue.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevenue.ForeColor = System.Drawing.Color.White;
            this.lblRevenue.Location = new System.Drawing.Point(469, 63);
            this.lblRevenue.Name = "lblRevenue";
            this.lblRevenue.Size = new System.Drawing.Size(128, 20);
            this.lblRevenue.TabIndex = 151;
            this.lblRevenue.Text = "Total Revenue  :";
            this.lblRevenue.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Maroon;
            this.panel3.ForeColor = System.Drawing.Color.Transparent;
            this.panel3.Location = new System.Drawing.Point(435, 69);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2, 391);
            this.panel3.TabIndex = 150;
            // 
            // txtEBill
            // 
            this.txtEBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.txtEBill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEBill.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEBill.ForeColor = System.Drawing.Color.White;
            this.txtEBill.Location = new System.Drawing.Point(164, 421);
            this.txtEBill.Name = "txtEBill";
            this.txtEBill.Size = new System.Drawing.Size(69, 32);
            this.txtEBill.TabIndex = 149;
            // 
            // txtGBill
            // 
            this.txtGBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.txtGBill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGBill.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGBill.ForeColor = System.Drawing.Color.White;
            this.txtGBill.Location = new System.Drawing.Point(164, 293);
            this.txtGBill.Name = "txtGBill";
            this.txtGBill.Size = new System.Drawing.Size(69, 32);
            this.txtGBill.TabIndex = 148;
            // 
            // txtWBill
            // 
            this.txtWBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.txtWBill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWBill.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWBill.ForeColor = System.Drawing.Color.White;
            this.txtWBill.Location = new System.Drawing.Point(164, 335);
            this.txtWBill.Name = "txtWBill";
            this.txtWBill.Size = new System.Drawing.Size(69, 32);
            this.txtWBill.TabIndex = 147;
            // 
            // txtRepairs
            // 
            this.txtRepairs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.txtRepairs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRepairs.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepairs.ForeColor = System.Drawing.Color.White;
            this.txtRepairs.Location = new System.Drawing.Point(164, 380);
            this.txtRepairs.Name = "txtRepairs";
            this.txtRepairs.Size = new System.Drawing.Size(69, 32);
            this.txtRepairs.TabIndex = 146;
            // 
            // txtCoffee
            // 
            this.txtCoffee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.txtCoffee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCoffee.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCoffee.ForeColor = System.Drawing.Color.White;
            this.txtCoffee.Location = new System.Drawing.Point(164, 162);
            this.txtCoffee.Name = "txtCoffee";
            this.txtCoffee.Size = new System.Drawing.Size(69, 32);
            this.txtCoffee.TabIndex = 145;
            // 
            // txtOther
            // 
            this.txtOther.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.txtOther.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOther.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOther.ForeColor = System.Drawing.Color.White;
            this.txtOther.Location = new System.Drawing.Point(164, 212);
            this.txtOther.Name = "txtOther";
            this.txtOther.Size = new System.Drawing.Size(69, 32);
            this.txtOther.TabIndex = 144;
            // 
            // txtSub
            // 
            this.txtSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.txtSub.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSub.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSub.ForeColor = System.Drawing.Color.White;
            this.txtSub.Location = new System.Drawing.Point(164, 114);
            this.txtSub.Name = "txtSub";
            this.txtSub.Size = new System.Drawing.Size(69, 32);
            this.txtSub.TabIndex = 143;
            // 
            // comboBoxEditShift
            // 
            this.comboBoxEditShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEditShift.FormattingEnabled = true;
            this.comboBoxEditShift.Items.AddRange(new object[] {
            "Night",
            "Morning"});
            this.comboBoxEditShift.Location = new System.Drawing.Point(90, 35);
            this.comboBoxEditShift.Name = "comboBoxEditShift";
            this.comboBoxEditShift.Size = new System.Drawing.Size(203, 24);
            this.comboBoxEditShift.TabIndex = 137;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Maroon;
            this.panel6.ForeColor = System.Drawing.Color.Transparent;
            this.panel6.Location = new System.Drawing.Point(12, 271);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(401, 2);
            this.panel6.TabIndex = 142;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(42, 216);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 19);
            this.label10.TabIndex = 141;
            this.label10.Text = "Other";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(35, 36);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 23);
            this.label14.TabIndex = 140;
            this.label14.Text = "Shift";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(42, 166);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 19);
            this.label15.TabIndex = 139;
            this.label15.Text = "Coffee";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(42, 118);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(103, 19);
            this.label16.TabIndex = 138;
            this.label16.Text = "Subscribtions";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(35, 384);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 19);
            this.label17.TabIndex = 136;
            this.label17.Text = "Repairs";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(34, 425);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(107, 19);
            this.label18.TabIndex = 135;
            this.label18.Text = "Electricity Bills";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(35, 339);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(83, 19);
            this.label19.TabIndex = 134;
            this.label19.Text = "Water Bills";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(35, 301);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(67, 19);
            this.label20.TabIndex = 133;
            this.label20.Text = "Gas Bills";
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(105)))));
            this.btnFind.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.Location = new System.Drawing.Point(213, 0);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(213, 36);
            this.btnFind.TabIndex = 30;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(105)))));
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(0, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(213, 36);
            this.btnAdd.TabIndex = 29;
            this.btnAdd.Text = "Add ";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panelFind
            // 
            this.panelFind.Controls.Add(this.label11);
            this.panelFind.Controls.Add(this.pictureBox2);
            this.panelFind.Controls.Add(this.btnSearch);
            this.panelFind.Controls.Add(this.dateTimePickerFind);
            this.panelFind.Controls.Add(this.panel8);
            this.panelFind.Controls.Add(this.lblFingNet);
            this.panelFind.Controls.Add(this.label12);
            this.panelFind.Controls.Add(this.txtFindEB);
            this.panelFind.Controls.Add(this.txtFindGB);
            this.panelFind.Controls.Add(this.txtFindWB);
            this.panelFind.Controls.Add(this.txtFindRepairs);
            this.panelFind.Controls.Add(this.txtFindCofe);
            this.panelFind.Controls.Add(this.txtFindOther);
            this.panelFind.Controls.Add(this.txtFindSub);
            this.panelFind.Controls.Add(this.label2);
            this.panelFind.Controls.Add(this.label3);
            this.panelFind.Controls.Add(this.label4);
            this.panelFind.Controls.Add(this.label5);
            this.panelFind.Controls.Add(this.label6);
            this.panelFind.Controls.Add(this.label7);
            this.panelFind.Controls.Add(this.label9);
            this.panelFind.Controls.Add(this.comboBoxSearchShift);
            this.panelFind.Controls.Add(this.label1);
            this.panelFind.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFind.Location = new System.Drawing.Point(0, 0);
            this.panelFind.Name = "panelFind";
            this.panelFind.Size = new System.Drawing.Size(981, 510);
            this.panelFind.TabIndex = 160;
            this.panelFind.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // comboBoxSearchShift
            // 
            this.comboBoxSearchShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSearchShift.FormattingEnabled = true;
            this.comboBoxSearchShift.Items.AddRange(new object[] {
            "Night",
            "Morning"});
            this.comboBoxSearchShift.Location = new System.Drawing.Point(86, 70);
            this.comboBoxSearchShift.Name = "comboBoxSearchShift";
            this.comboBoxSearchShift.Size = new System.Drawing.Size(203, 24);
            this.comboBoxSearchShift.TabIndex = 141;
            this.comboBoxSearchShift.SelectedIndexChanged += new System.EventHandler(this.comboBoxSearchShift_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 23);
            this.label1.TabIndex = 142;
            this.label1.Text = "Shift";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(396, 337);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 19);
            this.label9.TabIndex = 150;
            this.label9.Text = "Gas Bills";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(396, 375);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 19);
            this.label7.TabIndex = 151;
            this.label7.Text = "Water Bills";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(395, 461);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 19);
            this.label6.TabIndex = 152;
            this.label6.Text = "Electricity Bills";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(396, 420);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 19);
            this.label5.TabIndex = 153;
            this.label5.Text = "Repairs";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(96, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 19);
            this.label4.TabIndex = 154;
            this.label4.Text = "Subscribtions";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(96, 395);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 155;
            this.label3.Text = "Coffee";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(96, 445);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 156;
            this.label2.Text = "Other";
            // 
            // txtFindSub
            // 
            this.txtFindSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.txtFindSub.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFindSub.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFindSub.ForeColor = System.Drawing.Color.White;
            this.txtFindSub.Location = new System.Drawing.Point(218, 343);
            this.txtFindSub.Name = "txtFindSub";
            this.txtFindSub.ReadOnly = true;
            this.txtFindSub.Size = new System.Drawing.Size(69, 32);
            this.txtFindSub.TabIndex = 158;
            // 
            // txtFindOther
            // 
            this.txtFindOther.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.txtFindOther.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFindOther.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFindOther.ForeColor = System.Drawing.Color.White;
            this.txtFindOther.Location = new System.Drawing.Point(218, 441);
            this.txtFindOther.Name = "txtFindOther";
            this.txtFindOther.ReadOnly = true;
            this.txtFindOther.Size = new System.Drawing.Size(69, 32);
            this.txtFindOther.TabIndex = 159;
            // 
            // txtFindCofe
            // 
            this.txtFindCofe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.txtFindCofe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFindCofe.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFindCofe.ForeColor = System.Drawing.Color.White;
            this.txtFindCofe.Location = new System.Drawing.Point(218, 391);
            this.txtFindCofe.Name = "txtFindCofe";
            this.txtFindCofe.ReadOnly = true;
            this.txtFindCofe.Size = new System.Drawing.Size(69, 32);
            this.txtFindCofe.TabIndex = 160;
            // 
            // txtFindRepairs
            // 
            this.txtFindRepairs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.txtFindRepairs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFindRepairs.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFindRepairs.ForeColor = System.Drawing.Color.White;
            this.txtFindRepairs.Location = new System.Drawing.Point(525, 416);
            this.txtFindRepairs.Name = "txtFindRepairs";
            this.txtFindRepairs.ReadOnly = true;
            this.txtFindRepairs.Size = new System.Drawing.Size(69, 32);
            this.txtFindRepairs.TabIndex = 161;
            // 
            // txtFindWB
            // 
            this.txtFindWB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.txtFindWB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFindWB.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFindWB.ForeColor = System.Drawing.Color.White;
            this.txtFindWB.Location = new System.Drawing.Point(525, 371);
            this.txtFindWB.Name = "txtFindWB";
            this.txtFindWB.ReadOnly = true;
            this.txtFindWB.Size = new System.Drawing.Size(69, 32);
            this.txtFindWB.TabIndex = 162;
            // 
            // txtFindGB
            // 
            this.txtFindGB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.txtFindGB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFindGB.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFindGB.ForeColor = System.Drawing.Color.White;
            this.txtFindGB.Location = new System.Drawing.Point(525, 329);
            this.txtFindGB.Name = "txtFindGB";
            this.txtFindGB.ReadOnly = true;
            this.txtFindGB.Size = new System.Drawing.Size(69, 32);
            this.txtFindGB.TabIndex = 163;
            // 
            // txtFindEB
            // 
            this.txtFindEB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.txtFindEB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFindEB.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFindEB.ForeColor = System.Drawing.Color.White;
            this.txtFindEB.Location = new System.Drawing.Point(525, 457);
            this.txtFindEB.Name = "txtFindEB";
            this.txtFindEB.ReadOnly = true;
            this.txtFindEB.Size = new System.Drawing.Size(69, 32);
            this.txtFindEB.TabIndex = 164;
            // 
            // lblFingNet
            // 
            this.lblFingNet.AutoSize = true;
            this.lblFingNet.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFingNet.ForeColor = System.Drawing.Color.White;
            this.lblFingNet.Location = new System.Drawing.Point(298, 257);
            this.lblFingNet.Name = "lblFingNet";
            this.lblFingNet.Size = new System.Drawing.Size(21, 23);
            this.lblFingNet.TabIndex = 166;
            this.lblFingNet.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(188, 258);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 20);
            this.label12.TabIndex = 165;
            this.label12.Text = "Net profit :";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Maroon;
            this.panel8.ForeColor = System.Drawing.Color.Transparent;
            this.panel8.Location = new System.Drawing.Point(151, 308);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(401, 2);
            this.panel8.TabIndex = 167;
            // 
            // dateTimePickerFind
            // 
            this.dateTimePickerFind.Location = new System.Drawing.Point(82, 113);
            this.dateTimePickerFind.Name = "dateTimePickerFind";
            this.dateTimePickerFind.Size = new System.Drawing.Size(207, 20);
            this.dateTimePickerFind.TabIndex = 168;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSearch.Location = new System.Drawing.Point(312, 104);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(125, 33);
            this.btnSearch.TabIndex = 169;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::project.Properties.Resources.funny_clipart_no_money;
            this.pictureBox2.Location = new System.Drawing.Point(586, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(289, 232);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 170;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::project.Properties.Resources._375_3757409_earning_interest_graph_money_cartoon_clipart__2_;
            this.pictureBox1.Location = new System.Drawing.Point(465, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(503, 362);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 158;
            this.pictureBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label11.Location = new System.Drawing.Point(582, 262);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(316, 20);
            this.label11.TabIndex = 171;
            this.label11.Text = "Found no data  for that shift or the day :( ";
            this.label11.Visible = false;
            // 
            // income
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 546);
            this.Controls.Add(this.panelAdd);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "income";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "income";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            this.panelFind.ResumeLayout(false);
            this.panelFind.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbltNetProfit;
        private System.Windows.Forms.Label lblNet;
        private System.Windows.Forms.Label lblTotalExpenses;
        private System.Windows.Forms.Label lblExpenses;
        private System.Windows.Forms.Label lblTotalRevenue;
        private System.Windows.Forms.Label lblRevenue;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.TextBox txtEBill;
        public System.Windows.Forms.TextBox txtGBill;
        public System.Windows.Forms.TextBox txtWBill;
        public System.Windows.Forms.TextBox txtRepairs;
        public System.Windows.Forms.TextBox txtCoffee;
        public System.Windows.Forms.TextBox txtOther;
        public System.Windows.Forms.TextBox txtSub;
        public System.Windows.Forms.ComboBox comboBoxEditShift;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panelFind;
        public System.Windows.Forms.TextBox txtFindEB;
        public System.Windows.Forms.TextBox txtFindGB;
        public System.Windows.Forms.TextBox txtFindWB;
        public System.Windows.Forms.TextBox txtFindRepairs;
        public System.Windows.Forms.TextBox txtFindCofe;
        public System.Windows.Forms.TextBox txtFindOther;
        public System.Windows.Forms.TextBox txtFindSub;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.ComboBox comboBoxSearchShift;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerFind;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lblFingNet;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label11;
    }
}