
namespace project
{
    partial class SubscribtionForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnsubscribtionmembers = new System.Windows.Forms.Button();
            this.lblClose = new System.Windows.Forms.Label();
            this.btnAddNewSubscription = new System.Windows.Forms.Button();
            this.dataGridViewSubscriptions = new System.Windows.Forms.DataGridView();
            this.memberNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberAgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberGenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subscribtionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblEditType = new System.Windows.Forms.Label();
            this.lblEdit_Price = new System.Windows.Forms.Label();
            this.txtEditPrice = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.comboBoxSearchType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSearchSubscripers = new System.Windows.Forms.ComboBox();
            this.dataGridViewSub = new System.Windows.Forms.DataGridView();
            this.typeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubscribtionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subscribtionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Search = new System.Windows.Forms.Button();
            this.panelshowmembersuscription = new System.Windows.Forms.Panel();
            this.panelAddSub = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblAddSubscriptionSystemSuccess = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtType = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.subscribtionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubscriptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subscribtionBindingSource1)).BeginInit();
            this.panelshowmembersuscription.SuspendLayout();
            this.panelAddSub.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subscribtionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplementBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(105)))));
            this.panel1.Controls.Add(this.btnsubscribtionmembers);
            this.panel1.Controls.Add(this.lblClose);
            this.panel1.Controls.Add(this.btnAddNewSubscription);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(965, 36);
            this.panel1.TabIndex = 4;
            // 
            // btnsubscribtionmembers
            // 
            this.btnsubscribtionmembers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(105)))));
            this.btnsubscribtionmembers.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnsubscribtionmembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsubscribtionmembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubscribtionmembers.ForeColor = System.Drawing.Color.White;
            this.btnsubscribtionmembers.Location = new System.Drawing.Point(213, 0);
            this.btnsubscribtionmembers.Name = "btnsubscribtionmembers";
            this.btnsubscribtionmembers.Size = new System.Drawing.Size(213, 36);
            this.btnsubscribtionmembers.TabIndex = 4;
            this.btnsubscribtionmembers.Text = "Subscription";
            this.btnsubscribtionmembers.UseVisualStyleBackColor = false;
            this.btnsubscribtionmembers.Click += new System.EventHandler(this.btnsubscribtionmembers_Click);
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.Red;
            this.lblClose.Location = new System.Drawing.Point(932, 8);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(21, 20);
            this.lblClose.TabIndex = 3;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // btnAddNewSubscription
            // 
            this.btnAddNewSubscription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(105)))));
            this.btnAddNewSubscription.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddNewSubscription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewSubscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewSubscription.ForeColor = System.Drawing.Color.White;
            this.btnAddNewSubscription.Location = new System.Drawing.Point(0, 0);
            this.btnAddNewSubscription.Name = "btnAddNewSubscription";
            this.btnAddNewSubscription.Size = new System.Drawing.Size(213, 36);
            this.btnAddNewSubscription.TabIndex = 1;
            this.btnAddNewSubscription.Text = "Add Subscription";
            this.btnAddNewSubscription.UseVisualStyleBackColor = false;
            this.btnAddNewSubscription.Click += new System.EventHandler(this.btnAddNewSubscription_Click);
            // 
            // dataGridViewSubscriptions
            // 
            this.dataGridViewSubscriptions.AutoGenerateColumns = false;
            this.dataGridViewSubscriptions.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.dataGridViewSubscriptions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewSubscriptions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSubscriptions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewSubscriptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSubscriptions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.memberNameDataGridViewTextBoxColumn,
            this.memberAgeDataGridViewTextBoxColumn,
            this.memberGenderDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.subscribtionIDDataGridViewTextBoxColumn,
            this.memberIDDataGridViewTextBoxColumn});
            this.dataGridViewSubscriptions.DataSource = this.memberBindingSource;
            this.dataGridViewSubscriptions.EnableHeadersVisualStyles = false;
            this.dataGridViewSubscriptions.GridColor = System.Drawing.Color.White;
            this.dataGridViewSubscriptions.Location = new System.Drawing.Point(482, 323);
            this.dataGridViewSubscriptions.Name = "dataGridViewSubscriptions";
            this.dataGridViewSubscriptions.ReadOnly = true;
            this.dataGridViewSubscriptions.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewSubscriptions.RowHeadersVisible = false;
            this.dataGridViewSubscriptions.RowHeadersWidth = 600;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewSubscriptions.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewSubscriptions.Size = new System.Drawing.Size(406, 194);
            this.dataGridViewSubscriptions.TabIndex = 4;
            // 
            // memberNameDataGridViewTextBoxColumn
            // 
            this.memberNameDataGridViewTextBoxColumn.DataPropertyName = "MemberName";
            this.memberNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.memberNameDataGridViewTextBoxColumn.Name = "memberNameDataGridViewTextBoxColumn";
            this.memberNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // memberAgeDataGridViewTextBoxColumn
            // 
            this.memberAgeDataGridViewTextBoxColumn.DataPropertyName = "MemberAge";
            this.memberAgeDataGridViewTextBoxColumn.HeaderText = "Age";
            this.memberAgeDataGridViewTextBoxColumn.Name = "memberAgeDataGridViewTextBoxColumn";
            this.memberAgeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // memberGenderDataGridViewTextBoxColumn
            // 
            this.memberGenderDataGridViewTextBoxColumn.DataPropertyName = "MemberGender";
            this.memberGenderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.memberGenderDataGridViewTextBoxColumn.Name = "memberGenderDataGridViewTextBoxColumn";
            this.memberGenderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subscribtionIDDataGridViewTextBoxColumn
            // 
            this.subscribtionIDDataGridViewTextBoxColumn.DataPropertyName = "SubscribtionID";
            this.subscribtionIDDataGridViewTextBoxColumn.HeaderText = "SubscribtionID";
            this.subscribtionIDDataGridViewTextBoxColumn.Name = "subscribtionIDDataGridViewTextBoxColumn";
            this.subscribtionIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.subscribtionIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // memberIDDataGridViewTextBoxColumn
            // 
            this.memberIDDataGridViewTextBoxColumn.DataPropertyName = "MemberID";
            this.memberIDDataGridViewTextBoxColumn.HeaderText = "MemberID";
            this.memberIDDataGridViewTextBoxColumn.Name = "memberIDDataGridViewTextBoxColumn";
            this.memberIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.memberIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataSource = typeof(project.Member);
            // 
            // lblEditType
            // 
            this.lblEditType.AutoSize = true;
            this.lblEditType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditType.ForeColor = System.Drawing.Color.White;
            this.lblEditType.Location = new System.Drawing.Point(34, 92);
            this.lblEditType.Name = "lblEditType";
            this.lblEditType.Size = new System.Drawing.Size(43, 20);
            this.lblEditType.TabIndex = 7;
            this.lblEditType.Text = "Type";
            // 
            // lblEdit_Price
            // 
            this.lblEdit_Price.AutoSize = true;
            this.lblEdit_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdit_Price.ForeColor = System.Drawing.Color.White;
            this.lblEdit_Price.Location = new System.Drawing.Point(34, 167);
            this.lblEdit_Price.Name = "lblEdit_Price";
            this.lblEdit_Price.Size = new System.Drawing.Size(44, 20);
            this.lblEdit_Price.TabIndex = 8;
            this.lblEdit_Price.Text = "Price";
            // 
            // txtEditPrice
            // 
            this.txtEditPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditPrice.Location = new System.Drawing.Point(120, 165);
            this.txtEditPrice.Name = "txtEditPrice";
            this.txtEditPrice.Size = new System.Drawing.Size(175, 24);
            this.txtEditPrice.TabIndex = 10;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnEdit.Location = new System.Drawing.Point(359, 92);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(127, 38);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(359, 143);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(127, 38);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // comboBoxSearchType
            // 
            this.comboBoxSearchType.FormattingEnabled = true;
            this.comboBoxSearchType.Location = new System.Drawing.Point(120, 95);
            this.comboBoxSearchType.Name = "comboBoxSearchType";
            this.comboBoxSearchType.Size = new System.Drawing.Size(175, 21);
            this.comboBoxSearchType.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(83, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Find Subscripers";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBoxSearchSubscripers
            // 
            this.comboBoxSearchSubscripers.FormattingEnabled = true;
            this.comboBoxSearchSubscripers.Location = new System.Drawing.Point(87, 368);
            this.comboBoxSearchSubscripers.Name = "comboBoxSearchSubscripers";
            this.comboBoxSearchSubscripers.Size = new System.Drawing.Size(219, 21);
            this.comboBoxSearchSubscripers.TabIndex = 19;
            this.comboBoxSearchSubscripers.SelectedIndexChanged += new System.EventHandler(this.comboBoxSearchSubscripers_SelectedIndexChanged);
            // 
            // dataGridViewSub
            // 
            this.dataGridViewSub.AutoGenerateColumns = false;
            this.dataGridViewSub.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.dataGridViewSub.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewSub.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSub.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewSub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSub.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeDataGridViewTextBoxColumn1,
            this.priceDataGridViewTextBoxColumn1,
            this.SubscribtionID});
            this.dataGridViewSub.DataSource = this.subscribtionBindingSource1;
            this.dataGridViewSub.EnableHeadersVisualStyles = false;
            this.dataGridViewSub.GridColor = System.Drawing.Color.White;
            this.dataGridViewSub.Location = new System.Drawing.Point(584, 78);
            this.dataGridViewSub.Name = "dataGridViewSub";
            this.dataGridViewSub.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewSub.RowHeadersVisible = false;
            this.dataGridViewSub.RowHeadersWidth = 600;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewSub.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewSub.Size = new System.Drawing.Size(304, 150);
            this.dataGridViewSub.TabIndex = 20;
            this.dataGridViewSub.SelectionChanged += new System.EventHandler(this.dataGridViewSub_SelectionChanged);
            // 
            // typeDataGridViewTextBoxColumn1
            // 
            this.typeDataGridViewTextBoxColumn1.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn1.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn1.Name = "typeDataGridViewTextBoxColumn1";
            this.typeDataGridViewTextBoxColumn1.Width = 150;
            // 
            // priceDataGridViewTextBoxColumn1
            // 
            this.priceDataGridViewTextBoxColumn1.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn1.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
            this.priceDataGridViewTextBoxColumn1.Width = 150;
            // 
            // SubscribtionID
            // 
            this.SubscribtionID.DataPropertyName = "SubscribtionID";
            this.SubscribtionID.HeaderText = "SubscribtionID";
            this.SubscribtionID.Name = "SubscribtionID";
            this.SubscribtionID.Visible = false;
            // 
            // subscribtionBindingSource1
            // 
            this.subscribtionBindingSource1.DataSource = typeof(project.Subscribtion);
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Search.Location = new System.Drawing.Point(183, 415);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(123, 33);
            this.Search.TabIndex = 21;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // panelshowmembersuscription
            // 
            this.panelshowmembersuscription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.panelshowmembersuscription.Controls.Add(this.panelAddSub);
            this.panelshowmembersuscription.Controls.Add(this.Search);
            this.panelshowmembersuscription.Controls.Add(this.dataGridViewSub);
            this.panelshowmembersuscription.Controls.Add(this.comboBoxSearchSubscripers);
            this.panelshowmembersuscription.Controls.Add(this.label1);
            this.panelshowmembersuscription.Controls.Add(this.comboBoxSearchType);
            this.panelshowmembersuscription.Controls.Add(this.btnDelete);
            this.panelshowmembersuscription.Controls.Add(this.btnEdit);
            this.panelshowmembersuscription.Controls.Add(this.txtEditPrice);
            this.panelshowmembersuscription.Controls.Add(this.lblEdit_Price);
            this.panelshowmembersuscription.Controls.Add(this.lblEditType);
            this.panelshowmembersuscription.Controls.Add(this.dataGridViewSubscriptions);
            this.panelshowmembersuscription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelshowmembersuscription.Location = new System.Drawing.Point(0, 36);
            this.panelshowmembersuscription.Name = "panelshowmembersuscription";
            this.panelshowmembersuscription.Size = new System.Drawing.Size(965, 529);
            this.panelshowmembersuscription.TabIndex = 7;
            this.panelshowmembersuscription.Paint += new System.Windows.Forms.PaintEventHandler(this.panelshowmembersuscription_Paint);
            // 
            // panelAddSub
            // 
            this.panelAddSub.Controls.Add(this.pictureBox2);
            this.panelAddSub.Controls.Add(this.txtPrice);
            this.panelAddSub.Controls.Add(this.lblAddSubscriptionSystemSuccess);
            this.panelAddSub.Controls.Add(this.btnReset);
            this.panelAddSub.Controls.Add(this.btnAdd);
            this.panelAddSub.Controls.Add(this.txtType);
            this.panelAddSub.Controls.Add(this.label5);
            this.panelAddSub.Controls.Add(this.label2);
            this.panelAddSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAddSub.Location = new System.Drawing.Point(0, 0);
            this.panelAddSub.Name = "panelAddSub";
            this.panelAddSub.Size = new System.Drawing.Size(965, 529);
            this.panelAddSub.TabIndex = 22;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::project.Properties.Resources._614_6142229_gym_clipart_muscular_strength_gym_muscular_strength_dumbbells__1_;
            this.pictureBox2.Location = new System.Drawing.Point(543, 65);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(381, 327);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(270, 162);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(203, 26);
            this.txtPrice.TabIndex = 21;
            // 
            // lblAddSubscriptionSystemSuccess
            // 
            this.lblAddSubscriptionSystemSuccess.AutoSize = true;
            this.lblAddSubscriptionSystemSuccess.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddSubscriptionSystemSuccess.ForeColor = System.Drawing.Color.Green;
            this.lblAddSubscriptionSystemSuccess.Location = new System.Drawing.Point(234, 345);
            this.lblAddSubscriptionSystemSuccess.Name = "lblAddSubscriptionSystemSuccess";
            this.lblAddSubscriptionSystemSuccess.Size = new System.Drawing.Size(215, 23);
            this.lblAddSubscriptionSystemSuccess.TabIndex = 20;
            this.lblAddSubscriptionSystemSuccess.Text = "Data Added Successfully";
            this.lblAddSubscriptionSystemSuccess.Visible = false;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReset.Location = new System.Drawing.Point(370, 262);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(116, 37);
            this.btnReset.TabIndex = 19;
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
            this.btnAdd.Location = new System.Drawing.Point(213, 262);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(116, 37);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtType
            // 
            this.txtType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtType.Location = new System.Drawing.Point(270, 95);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(203, 26);
            this.txtType.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(141, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 21);
            this.label5.TabIndex = 16;
            this.label5.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(141, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "Type";
            // 
            // subscribtionBindingSource
            // 
            this.subscribtionBindingSource.DataSource = typeof(project.Subscribtion);
            // 
            // supplementBindingSource
            // 
            this.supplementBindingSource.DataSource = typeof(project.Supplement);
            // 
            // SubscribtionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 565);
            this.Controls.Add(this.panelshowmembersuscription);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SubscribtionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SubscribtionForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubscriptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subscribtionBindingSource1)).EndInit();
            this.panelshowmembersuscription.ResumeLayout(false);
            this.panelshowmembersuscription.PerformLayout();
            this.panelAddSub.ResumeLayout(false);
            this.panelAddSub.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subscribtionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplementBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnsubscribtionmembers;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Button btnAddNewSubscription;
        private System.Windows.Forms.DataGridView dataGridViewSubscriptions;
        private System.Windows.Forms.Label lblEditType;
        private System.Windows.Forms.Label lblEdit_Price;
        private System.Windows.Forms.TextBox txtEditPrice;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox comboBoxSearchType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSearchSubscripers;
        private System.Windows.Forms.DataGridView dataGridViewSub;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Panel panelshowmembersuscription;
        private System.Windows.Forms.Panel panelAddSub;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblAddSubscriptionSystemSuccess;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.BindingSource subscribtionBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubscribtionID;
        private System.Windows.Forms.BindingSource subscribtionBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberAgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberGenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subscribtionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private System.Windows.Forms.BindingSource supplementBindingSource;
    }
}