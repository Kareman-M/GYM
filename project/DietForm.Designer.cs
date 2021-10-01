
namespace project
{
    partial class DietForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1tranin = new System.Windows.Forms.Panel();
            this.lblClose = new System.Windows.Forms.Label();
            this.btnSearchDiet = new System.Windows.Forms.Button();
            this.btnAddDiet = new System.Windows.Forms.Button();
            this.panelAddNewDiet = new System.Windows.Forms.Panel();
            this.panelSearchDiet = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dataGridViewShowDiet = new System.Windows.Forms.DataGridView();
            this.dayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.breakfastDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snack1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lunchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snack2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dinnerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dietDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mealIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dietIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mealBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.Search = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtEditDinner = new System.Windows.Forms.TextBox();
            this.txtSnack2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSnack1 = new System.Windows.Forms.TextBox();
            this.txtEditLunch = new System.Windows.Forms.TextBox();
            this.txtEditBreakfast = new System.Windows.Forms.TextBox();
            this.comboBoxSearchDiet = new System.Windows.Forms.ComboBox();
            this.txtDinner = new System.Windows.Forms.TextBox();
            this.txtSecondSnack = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblBreakfast = new System.Windows.Forms.Label();
            this.txtDietName = new System.Windows.Forms.TextBox();
            this.lblAddSuccess = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtFirstSnack = new System.Windows.Forms.TextBox();
            this.txtLunch = new System.Windows.Forms.TextBox();
            this.txtBreakfast = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.comboBoxChooseDay = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1tranin.SuspendLayout();
            this.panelAddNewDiet.SuspendLayout();
            this.panelSearchDiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowDiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mealBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1tranin
            // 
            this.panel1tranin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(105)))));
            this.panel1tranin.Controls.Add(this.lblClose);
            this.panel1tranin.Controls.Add(this.btnSearchDiet);
            this.panel1tranin.Controls.Add(this.btnAddDiet);
            this.panel1tranin.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1tranin.Location = new System.Drawing.Point(0, 0);
            this.panel1tranin.Name = "panel1tranin";
            this.panel1tranin.Size = new System.Drawing.Size(982, 36);
            this.panel1tranin.TabIndex = 2;
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.Red;
            this.lblClose.Location = new System.Drawing.Point(948, 8);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(21, 20);
            this.lblClose.TabIndex = 4;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // btnSearchDiet
            // 
            this.btnSearchDiet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(105)))));
            this.btnSearchDiet.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSearchDiet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchDiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnSearchDiet.ForeColor = System.Drawing.Color.White;
            this.btnSearchDiet.Location = new System.Drawing.Point(213, 0);
            this.btnSearchDiet.Name = "btnSearchDiet";
            this.btnSearchDiet.Size = new System.Drawing.Size(213, 36);
            this.btnSearchDiet.TabIndex = 1;
            this.btnSearchDiet.Text = "Search Diet";
            this.btnSearchDiet.UseVisualStyleBackColor = false;
            this.btnSearchDiet.Click += new System.EventHandler(this.btnSearchDiet_Click);
            // 
            // btnAddDiet
            // 
            this.btnAddDiet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(105)))));
            this.btnAddDiet.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddDiet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddDiet.ForeColor = System.Drawing.Color.White;
            this.btnAddDiet.Location = new System.Drawing.Point(0, 0);
            this.btnAddDiet.Name = "btnAddDiet";
            this.btnAddDiet.Size = new System.Drawing.Size(213, 36);
            this.btnAddDiet.TabIndex = 0;
            this.btnAddDiet.Text = "Add Diet";
            this.btnAddDiet.UseVisualStyleBackColor = false;
            this.btnAddDiet.Click += new System.EventHandler(this.btnAddDiet_Click);
            // 
            // panelAddNewDiet
            // 
            this.panelAddNewDiet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.panelAddNewDiet.Controls.Add(this.panelSearchDiet);
            this.panelAddNewDiet.Controls.Add(this.txtDinner);
            this.panelAddNewDiet.Controls.Add(this.txtSecondSnack);
            this.panelAddNewDiet.Controls.Add(this.label14);
            this.panelAddNewDiet.Controls.Add(this.label13);
            this.panelAddNewDiet.Controls.Add(this.label12);
            this.panelAddNewDiet.Controls.Add(this.label11);
            this.panelAddNewDiet.Controls.Add(this.lblBreakfast);
            this.panelAddNewDiet.Controls.Add(this.txtDietName);
            this.panelAddNewDiet.Controls.Add(this.lblAddSuccess);
            this.panelAddNewDiet.Controls.Add(this.btnReset);
            this.panelAddNewDiet.Controls.Add(this.btnAdd);
            this.panelAddNewDiet.Controls.Add(this.txtFirstSnack);
            this.panelAddNewDiet.Controls.Add(this.txtLunch);
            this.panelAddNewDiet.Controls.Add(this.txtBreakfast);
            this.panelAddNewDiet.Controls.Add(this.label21);
            this.panelAddNewDiet.Controls.Add(this.label22);
            this.panelAddNewDiet.Controls.Add(this.comboBoxChooseDay);
            this.panelAddNewDiet.Controls.Add(this.pictureBox1);
            this.panelAddNewDiet.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panelAddNewDiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAddNewDiet.Location = new System.Drawing.Point(0, 36);
            this.panelAddNewDiet.Name = "panelAddNewDiet";
            this.panelAddNewDiet.Size = new System.Drawing.Size(982, 537);
            this.panelAddNewDiet.TabIndex = 37;
            this.panelAddNewDiet.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAddNewProgram_Paint);
            // 
            // panelSearchDiet
            // 
            this.panelSearchDiet.Controls.Add(this.pictureBox2);
            this.panelSearchDiet.Controls.Add(this.dataGridViewShowDiet);
            this.panelSearchDiet.Controls.Add(this.Search);
            this.panelSearchDiet.Controls.Add(this.btnEdit);
            this.panelSearchDiet.Controls.Add(this.button1);
            this.panelSearchDiet.Controls.Add(this.txtEditDinner);
            this.panelSearchDiet.Controls.Add(this.txtSnack2);
            this.panelSearchDiet.Controls.Add(this.label2);
            this.panelSearchDiet.Controls.Add(this.label3);
            this.panelSearchDiet.Controls.Add(this.label4);
            this.panelSearchDiet.Controls.Add(this.label5);
            this.panelSearchDiet.Controls.Add(this.label6);
            this.panelSearchDiet.Controls.Add(this.txtSnack1);
            this.panelSearchDiet.Controls.Add(this.txtEditLunch);
            this.panelSearchDiet.Controls.Add(this.txtEditBreakfast);
            this.panelSearchDiet.Controls.Add(this.comboBoxSearchDiet);
            this.panelSearchDiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSearchDiet.Location = new System.Drawing.Point(0, 0);
            this.panelSearchDiet.Name = "panelSearchDiet";
            this.panelSearchDiet.Size = new System.Drawing.Size(982, 537);
            this.panelSearchDiet.TabIndex = 64;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::project.Properties.Resources.kissclipart_plate_setting_clipart_table_setting_clip_art_9c79bfc5336a398f;
            this.pictureBox2.Location = new System.Drawing.Point(319, 47);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 78;
            this.pictureBox2.TabStop = false;
            // 
            // dataGridViewShowDiet
            // 
            this.dataGridViewShowDiet.AllowUserToOrderColumns = true;
            this.dataGridViewShowDiet.AutoGenerateColumns = false;
            this.dataGridViewShowDiet.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.dataGridViewShowDiet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewShowDiet.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewShowDiet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewShowDiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShowDiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dayDataGridViewTextBoxColumn,
            this.breakfastDataGridViewTextBoxColumn,
            this.snack1DataGridViewTextBoxColumn,
            this.lunchDataGridViewTextBoxColumn,
            this.snack2DataGridViewTextBoxColumn,
            this.dinnerDataGridViewTextBoxColumn,
            this.dietDataGridViewTextBoxColumn,
            this.mealIDDataGridViewTextBoxColumn,
            this.dietIDDataGridViewTextBoxColumn});
            this.dataGridViewShowDiet.DataSource = this.mealBindingSource2;
            this.dataGridViewShowDiet.EnableHeadersVisualStyles = false;
            this.dataGridViewShowDiet.GridColor = System.Drawing.Color.White;
            this.dataGridViewShowDiet.Location = new System.Drawing.Point(349, 151);
            this.dataGridViewShowDiet.Name = "dataGridViewShowDiet";
            this.dataGridViewShowDiet.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewShowDiet.RowHeadersVisible = false;
            this.dataGridViewShowDiet.RowHeadersWidth = 60;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewShowDiet.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewShowDiet.Size = new System.Drawing.Size(630, 271);
            this.dataGridViewShowDiet.TabIndex = 77;
            this.dataGridViewShowDiet.SelectionChanged += new System.EventHandler(this.dataGridViewShowDiet_SelectionChanged);
            // 
            // dayDataGridViewTextBoxColumn
            // 
            this.dayDataGridViewTextBoxColumn.DataPropertyName = "Day";
            this.dayDataGridViewTextBoxColumn.HeaderText = "Day";
            this.dayDataGridViewTextBoxColumn.Name = "dayDataGridViewTextBoxColumn";
            // 
            // breakfastDataGridViewTextBoxColumn
            // 
            this.breakfastDataGridViewTextBoxColumn.DataPropertyName = "Breakfast";
            this.breakfastDataGridViewTextBoxColumn.HeaderText = "Breakfast";
            this.breakfastDataGridViewTextBoxColumn.Name = "breakfastDataGridViewTextBoxColumn";
            // 
            // snack1DataGridViewTextBoxColumn
            // 
            this.snack1DataGridViewTextBoxColumn.DataPropertyName = "Snack1";
            this.snack1DataGridViewTextBoxColumn.HeaderText = "First Snack";
            this.snack1DataGridViewTextBoxColumn.Name = "snack1DataGridViewTextBoxColumn";
            this.snack1DataGridViewTextBoxColumn.Width = 130;
            // 
            // lunchDataGridViewTextBoxColumn
            // 
            this.lunchDataGridViewTextBoxColumn.DataPropertyName = "Lunch";
            this.lunchDataGridViewTextBoxColumn.HeaderText = "Lunch";
            this.lunchDataGridViewTextBoxColumn.Name = "lunchDataGridViewTextBoxColumn";
            // 
            // snack2DataGridViewTextBoxColumn
            // 
            this.snack2DataGridViewTextBoxColumn.DataPropertyName = "Snack2";
            this.snack2DataGridViewTextBoxColumn.HeaderText = "Second Snack";
            this.snack2DataGridViewTextBoxColumn.Name = "snack2DataGridViewTextBoxColumn";
            this.snack2DataGridViewTextBoxColumn.Width = 130;
            // 
            // dinnerDataGridViewTextBoxColumn
            // 
            this.dinnerDataGridViewTextBoxColumn.DataPropertyName = "Dinner";
            this.dinnerDataGridViewTextBoxColumn.HeaderText = "Dinner";
            this.dinnerDataGridViewTextBoxColumn.Name = "dinnerDataGridViewTextBoxColumn";
            // 
            // dietDataGridViewTextBoxColumn
            // 
            this.dietDataGridViewTextBoxColumn.DataPropertyName = "Diet";
            this.dietDataGridViewTextBoxColumn.HeaderText = "Diet";
            this.dietDataGridViewTextBoxColumn.Name = "dietDataGridViewTextBoxColumn";
            this.dietDataGridViewTextBoxColumn.Visible = false;
            // 
            // mealIDDataGridViewTextBoxColumn
            // 
            this.mealIDDataGridViewTextBoxColumn.DataPropertyName = "MealID";
            this.mealIDDataGridViewTextBoxColumn.HeaderText = "MealID";
            this.mealIDDataGridViewTextBoxColumn.Name = "mealIDDataGridViewTextBoxColumn";
            this.mealIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // dietIDDataGridViewTextBoxColumn
            // 
            this.dietIDDataGridViewTextBoxColumn.DataPropertyName = "DietID";
            this.dietIDDataGridViewTextBoxColumn.HeaderText = "DietID";
            this.dietIDDataGridViewTextBoxColumn.Name = "dietIDDataGridViewTextBoxColumn";
            this.dietIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // mealBindingSource2
            // 
            this.mealBindingSource2.DataSource = typeof(project.Meal);
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Search.Location = new System.Drawing.Point(651, 45);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(125, 43);
            this.Search.TabIndex = 76;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Green;
            this.btnEdit.Location = new System.Drawing.Point(672, 459);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(128, 40);
            this.btnEdit.TabIndex = 75;
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
            this.button1.Location = new System.Drawing.Point(491, 459);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 40);
            this.button1.TabIndex = 74;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtEditDinner
            // 
            this.txtEditDinner.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditDinner.Location = new System.Drawing.Point(109, 370);
            this.txtEditDinner.Name = "txtEditDinner";
            this.txtEditDinner.Size = new System.Drawing.Size(234, 27);
            this.txtEditDinner.TabIndex = 72;
            // 
            // txtSnack2
            // 
            this.txtSnack2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSnack2.Location = new System.Drawing.Point(109, 327);
            this.txtSnack2.Name = "txtSnack2";
            this.txtSnack2.Size = new System.Drawing.Size(234, 27);
            this.txtSnack2.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
            this.label2.TabIndex = 70;
            this.label2.Text = "Dinner";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 19);
            this.label3.TabIndex = 69;
            this.label3.Text = "Second Snack";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(2, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 19);
            this.label4.TabIndex = 68;
            this.label4.Text = "Lunch";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 19);
            this.label5.TabIndex = 67;
            this.label5.Text = "First Snack";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 19);
            this.label6.TabIndex = 66;
            this.label6.Text = "Breakfast";
            // 
            // txtSnack1
            // 
            this.txtSnack1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSnack1.Location = new System.Drawing.Point(109, 242);
            this.txtSnack1.Name = "txtSnack1";
            this.txtSnack1.Size = new System.Drawing.Size(234, 27);
            this.txtSnack1.TabIndex = 65;
            // 
            // txtEditLunch
            // 
            this.txtEditLunch.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditLunch.Location = new System.Drawing.Point(109, 285);
            this.txtEditLunch.Name = "txtEditLunch";
            this.txtEditLunch.Size = new System.Drawing.Size(234, 27);
            this.txtEditLunch.TabIndex = 64;
            // 
            // txtEditBreakfast
            // 
            this.txtEditBreakfast.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditBreakfast.Location = new System.Drawing.Point(109, 196);
            this.txtEditBreakfast.Name = "txtEditBreakfast";
            this.txtEditBreakfast.Size = new System.Drawing.Size(234, 27);
            this.txtEditBreakfast.TabIndex = 63;
            // 
            // comboBoxSearchDiet
            // 
            this.comboBoxSearchDiet.FormattingEnabled = true;
            this.comboBoxSearchDiet.Location = new System.Drawing.Point(381, 54);
            this.comboBoxSearchDiet.Name = "comboBoxSearchDiet";
            this.comboBoxSearchDiet.Size = new System.Drawing.Size(250, 21);
            this.comboBoxSearchDiet.TabIndex = 2;
            // 
            // txtDinner
            // 
            this.txtDinner.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDinner.Location = new System.Drawing.Point(213, 305);
            this.txtDinner.Name = "txtDinner";
            this.txtDinner.Size = new System.Drawing.Size(250, 27);
            this.txtDinner.TabIndex = 62;
            // 
            // txtSecondSnack
            // 
            this.txtSecondSnack.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecondSnack.Location = new System.Drawing.Point(213, 419);
            this.txtSecondSnack.Name = "txtSecondSnack";
            this.txtSecondSnack.Size = new System.Drawing.Size(250, 27);
            this.txtSecondSnack.TabIndex = 61;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(97, 311);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 19);
            this.label14.TabIndex = 60;
            this.label14.Text = "Dinner";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(97, 419);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 19);
            this.label13.TabIndex = 59;
            this.label13.Text = "Second Snack";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(97, 367);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 19);
            this.label12.TabIndex = 58;
            this.label12.Text = "Lunch";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(97, 257);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 19);
            this.label11.TabIndex = 57;
            this.label11.Text = "First Snack";
            // 
            // lblBreakfast
            // 
            this.lblBreakfast.AutoSize = true;
            this.lblBreakfast.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBreakfast.ForeColor = System.Drawing.Color.White;
            this.lblBreakfast.Location = new System.Drawing.Point(97, 196);
            this.lblBreakfast.Name = "lblBreakfast";
            this.lblBreakfast.Size = new System.Drawing.Size(73, 19);
            this.lblBreakfast.TabIndex = 56;
            this.lblBreakfast.Text = "Breakfast";
            // 
            // txtDietName
            // 
            this.txtDietName.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDietName.Location = new System.Drawing.Point(395, 52);
            this.txtDietName.Name = "txtDietName";
            this.txtDietName.Size = new System.Drawing.Size(214, 27);
            this.txtDietName.TabIndex = 55;
            // 
            // lblAddSuccess
            // 
            this.lblAddSuccess.AutoSize = true;
            this.lblAddSuccess.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddSuccess.ForeColor = System.Drawing.Color.Green;
            this.lblAddSuccess.Location = new System.Drawing.Point(630, 476);
            this.lblAddSuccess.Name = "lblAddSuccess";
            this.lblAddSuccess.Size = new System.Drawing.Size(215, 23);
            this.lblAddSuccess.TabIndex = 54;
            this.lblAddSuccess.Text = "Data Added Successfully";
            this.lblAddSuccess.Visible = false;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReset.Location = new System.Drawing.Point(762, 419);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(116, 37);
            this.btnReset.TabIndex = 53;
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
            this.btnAdd.Location = new System.Drawing.Point(605, 419);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(116, 37);
            this.btnAdd.TabIndex = 52;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtFirstSnack
            // 
            this.txtFirstSnack.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstSnack.Location = new System.Drawing.Point(213, 251);
            this.txtFirstSnack.Name = "txtFirstSnack";
            this.txtFirstSnack.Size = new System.Drawing.Size(250, 27);
            this.txtFirstSnack.TabIndex = 47;
            // 
            // txtLunch
            // 
            this.txtLunch.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLunch.Location = new System.Drawing.Point(213, 367);
            this.txtLunch.Name = "txtLunch";
            this.txtLunch.Size = new System.Drawing.Size(250, 27);
            this.txtLunch.TabIndex = 46;
            // 
            // txtBreakfast
            // 
            this.txtBreakfast.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBreakfast.Location = new System.Drawing.Point(213, 190);
            this.txtBreakfast.Name = "txtBreakfast";
            this.txtBreakfast.Size = new System.Drawing.Size(250, 27);
            this.txtBreakfast.TabIndex = 44;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(266, 101);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(109, 20);
            this.label21.TabIndex = 39;
            this.label21.Text = "Choose a Day";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(266, 55);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(51, 20);
            this.label22.TabIndex = 38;
            this.label22.Text = "Name";
            // 
            // comboBoxChooseDay
            // 
            this.comboBoxChooseDay.FormattingEnabled = true;
            this.comboBoxChooseDay.Items.AddRange(new object[] {
            "Saturday",
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday"});
            this.comboBoxChooseDay.Location = new System.Drawing.Point(395, 101);
            this.comboBoxChooseDay.Name = "comboBoxChooseDay";
            this.comboBoxChooseDay.Size = new System.Drawing.Size(214, 21);
            this.comboBoxChooseDay.TabIndex = 36;
            this.comboBoxChooseDay.SelectedIndexChanged += new System.EventHandler(this.comboBoxChooseDay_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::project.Properties.Resources.c453b0fface991648dde2bf1c0ede5b3;
            this.pictureBox1.Location = new System.Drawing.Point(576, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(369, 342);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // DietForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 573);
            this.Controls.Add(this.panelAddNewDiet);
            this.Controls.Add(this.panel1tranin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DietForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DietForm";
            this.panel1tranin.ResumeLayout(false);
            this.panel1tranin.PerformLayout();
            this.panelAddNewDiet.ResumeLayout(false);
            this.panelAddNewDiet.PerformLayout();
            this.panelSearchDiet.ResumeLayout(false);
            this.panelSearchDiet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowDiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mealBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1tranin;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Button btnSearchDiet;
        private System.Windows.Forms.Button btnAddDiet;
        private System.Windows.Forms.Panel panelAddNewDiet;
        private System.Windows.Forms.Label lblAddSuccess;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtFirstSnack;
        private System.Windows.Forms.TextBox txtLunch;
        private System.Windows.Forms.TextBox txtBreakfast;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox comboBoxChooseDay;
        private System.Windows.Forms.TextBox txtSecondSnack;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblBreakfast;
        private System.Windows.Forms.TextBox txtDietName;
        private System.Windows.Forms.TextBox txtDinner;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelSearchDiet;
        private System.Windows.Forms.TextBox txtEditDinner;
        private System.Windows.Forms.TextBox txtSnack2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSnack1;
        private System.Windows.Forms.TextBox txtEditLunch;
        private System.Windows.Forms.TextBox txtEditBreakfast;
        private System.Windows.Forms.ComboBox comboBoxSearchDiet;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Search;
        public System.Windows.Forms.DataGridView dataGridViewShowDiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn breakfastDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn snack1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lunchDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn snack2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dinnerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dietDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mealIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dietIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource mealBindingSource2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}