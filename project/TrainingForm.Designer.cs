
namespace project
{
    partial class TrainingForm
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
            this.panel1tranin = new System.Windows.Forms.Panel();
            this.lblClose = new System.Windows.Forms.Label();
            this.btnSearchProgrm = new System.Windows.Forms.Button();
            this.btnAddProgram = new System.Windows.Forms.Button();
            this.panelSearchTraining = new System.Windows.Forms.Panel();
            this.panelAddNewProgram = new System.Windows.Forms.Panel();
            this.lblAddSuccess = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAddPic = new System.Windows.Forms.Button();
            this.txtAddDesc = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtAddGroups = new System.Windows.Forms.TextBox();
            this.txtAddRepatation = new System.Windows.Forms.TextBox();
            this.txtAddMuscle = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.comboBoxChooseLevel = new System.Windows.Forms.ComboBox();
            this.comboBoxChooseDay = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtGroups = new System.Windows.Forms.TextBox();
            this.txtEditRepataion = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtEditMuscle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxEditDay = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.comboBoxSearchByLevel = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridViewShowTraining = new System.Windows.Forms.DataGridView();
            this.DayName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Muscle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Groups = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Repatation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.image = new System.Windows.Forms.DataGridViewImageColumn();
            this.pictureBoxAdd = new System.Windows.Forms.PictureBox();
            this.trainingDayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1tranin.SuspendLayout();
            this.panelSearchTraining.SuspendLayout();
            this.panelAddNewProgram.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowTraining)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingDayBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1tranin
            // 
            this.panel1tranin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(105)))));
            this.panel1tranin.Controls.Add(this.lblClose);
            this.panel1tranin.Controls.Add(this.btnSearchProgrm);
            this.panel1tranin.Controls.Add(this.btnAddProgram);
            this.panel1tranin.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1tranin.Location = new System.Drawing.Point(0, 0);
            this.panel1tranin.Name = "panel1tranin";
            this.panel1tranin.Size = new System.Drawing.Size(981, 36);
            this.panel1tranin.TabIndex = 1;
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
            // btnSearchProgrm
            // 
            this.btnSearchProgrm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(105)))));
            this.btnSearchProgrm.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSearchProgrm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchProgrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnSearchProgrm.ForeColor = System.Drawing.Color.White;
            this.btnSearchProgrm.Location = new System.Drawing.Point(213, 0);
            this.btnSearchProgrm.Name = "btnSearchProgrm";
            this.btnSearchProgrm.Size = new System.Drawing.Size(213, 36);
            this.btnSearchProgrm.TabIndex = 1;
            this.btnSearchProgrm.Text = "Search Training Program";
            this.btnSearchProgrm.UseVisualStyleBackColor = false;
            this.btnSearchProgrm.Click += new System.EventHandler(this.btnSearchProgram_Click);
            // 
            // btnAddProgram
            // 
            this.btnAddProgram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(105)))));
            this.btnAddProgram.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddProgram.ForeColor = System.Drawing.Color.White;
            this.btnAddProgram.Location = new System.Drawing.Point(0, 0);
            this.btnAddProgram.Name = "btnAddProgram";
            this.btnAddProgram.Size = new System.Drawing.Size(213, 36);
            this.btnAddProgram.TabIndex = 0;
            this.btnAddProgram.Text = "AddTraining Program";
            this.btnAddProgram.UseVisualStyleBackColor = false;
            this.btnAddProgram.Click += new System.EventHandler(this.btnAddProgram_Click);
            // 
            // panelSearchTraining
            // 
            this.panelSearchTraining.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.panelSearchTraining.Controls.Add(this.panelAddNewProgram);
            this.panelSearchTraining.Controls.Add(this.btnDelete);
            this.panelSearchTraining.Controls.Add(this.btnEdit);
            this.panelSearchTraining.Controls.Add(this.txtGroups);
            this.panelSearchTraining.Controls.Add(this.txtEditRepataion);
            this.panelSearchTraining.Controls.Add(this.txtDesc);
            this.panelSearchTraining.Controls.Add(this.txtEditMuscle);
            this.panelSearchTraining.Controls.Add(this.label6);
            this.panelSearchTraining.Controls.Add(this.label5);
            this.panelSearchTraining.Controls.Add(this.label4);
            this.panelSearchTraining.Controls.Add(this.label3);
            this.panelSearchTraining.Controls.Add(this.label2);
            this.panelSearchTraining.Controls.Add(this.comboBoxEditDay);
            this.panelSearchTraining.Controls.Add(this.btnSearch);
            this.panelSearchTraining.Controls.Add(this.comboBoxSearchByLevel);
            this.panelSearchTraining.Controls.Add(this.label8);
            this.panelSearchTraining.Controls.Add(this.dataGridViewShowTraining);
            this.panelSearchTraining.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSearchTraining.Location = new System.Drawing.Point(0, 36);
            this.panelSearchTraining.Name = "panelSearchTraining";
            this.panelSearchTraining.Size = new System.Drawing.Size(981, 539);
            this.panelSearchTraining.TabIndex = 28;
            // 
            // panelAddNewProgram
            // 
            this.panelAddNewProgram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.panelAddNewProgram.Controls.Add(this.lblAddSuccess);
            this.panelAddNewProgram.Controls.Add(this.btnReset);
            this.panelAddNewProgram.Controls.Add(this.btnAdd);
            this.panelAddNewProgram.Controls.Add(this.btnAddPic);
            this.panelAddNewProgram.Controls.Add(this.txtAddDesc);
            this.panelAddNewProgram.Controls.Add(this.label16);
            this.panelAddNewProgram.Controls.Add(this.pictureBoxAdd);
            this.panelAddNewProgram.Controls.Add(this.txtAddGroups);
            this.panelAddNewProgram.Controls.Add(this.txtAddRepatation);
            this.panelAddNewProgram.Controls.Add(this.txtAddMuscle);
            this.panelAddNewProgram.Controls.Add(this.label17);
            this.panelAddNewProgram.Controls.Add(this.label18);
            this.panelAddNewProgram.Controls.Add(this.label19);
            this.panelAddNewProgram.Controls.Add(this.label20);
            this.panelAddNewProgram.Controls.Add(this.label21);
            this.panelAddNewProgram.Controls.Add(this.label22);
            this.panelAddNewProgram.Controls.Add(this.comboBoxChooseLevel);
            this.panelAddNewProgram.Controls.Add(this.comboBoxChooseDay);
            this.panelAddNewProgram.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panelAddNewProgram.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAddNewProgram.Location = new System.Drawing.Point(0, 0);
            this.panelAddNewProgram.Name = "panelAddNewProgram";
            this.panelAddNewProgram.Size = new System.Drawing.Size(981, 539);
            this.panelAddNewProgram.TabIndex = 36;
            this.panelAddNewProgram.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAddNewProgram_Paint);
            // 
            // lblAddSuccess
            // 
            this.lblAddSuccess.AutoSize = true;
            this.lblAddSuccess.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddSuccess.ForeColor = System.Drawing.Color.Green;
            this.lblAddSuccess.Location = new System.Drawing.Point(390, 457);
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
            this.btnReset.Location = new System.Drawing.Point(522, 400);
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
            this.btnAdd.Location = new System.Drawing.Point(365, 400);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(116, 37);
            this.btnAdd.TabIndex = 52;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAddPic
            // 
            this.btnAddPic.BackColor = System.Drawing.Color.LightGray;
            this.btnAddPic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnAddPic.Location = new System.Drawing.Point(656, 311);
            this.btnAddPic.Name = "btnAddPic";
            this.btnAddPic.Size = new System.Drawing.Size(176, 33);
            this.btnAddPic.TabIndex = 51;
            this.btnAddPic.Text = "Add";
            this.btnAddPic.UseVisualStyleBackColor = false;
            this.btnAddPic.Click += new System.EventHandler(this.btnAddPic_Click);
            // 
            // txtAddDesc
            // 
            this.txtAddDesc.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddDesc.Location = new System.Drawing.Point(273, 319);
            this.txtAddDesc.Multiline = true;
            this.txtAddDesc.Name = "txtAddDesc";
            this.txtAddDesc.Size = new System.Drawing.Size(250, 20);
            this.txtAddDesc.TabIndex = 50;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(655, 155);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(113, 20);
            this.label16.TabIndex = 49;
            this.label16.Text = "Choose Image";
            // 
            // txtAddGroups
            // 
            this.txtAddGroups.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddGroups.Location = new System.Drawing.Point(273, 228);
            this.txtAddGroups.Name = "txtAddGroups";
            this.txtAddGroups.Size = new System.Drawing.Size(250, 27);
            this.txtAddGroups.TabIndex = 47;
            // 
            // txtAddRepatation
            // 
            this.txtAddRepatation.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddRepatation.Location = new System.Drawing.Point(273, 274);
            this.txtAddRepatation.Name = "txtAddRepatation";
            this.txtAddRepatation.Size = new System.Drawing.Size(250, 27);
            this.txtAddRepatation.TabIndex = 46;
            // 
            // txtAddMuscle
            // 
            this.txtAddMuscle.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddMuscle.Location = new System.Drawing.Point(273, 186);
            this.txtAddMuscle.Name = "txtAddMuscle";
            this.txtAddMuscle.Size = new System.Drawing.Size(250, 27);
            this.txtAddMuscle.TabIndex = 44;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(136, 318);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(96, 21);
            this.label17.TabIndex = 43;
            this.label17.Text = "Description";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(132, 277);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(100, 21);
            this.label18.TabIndex = 42;
            this.label18.Text = "Repatations";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(136, 230);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 21);
            this.label19.TabIndex = 41;
            this.label19.Text = "Groups";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(134, 185);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(118, 21);
            this.label20.TabIndex = 40;
            this.label20.Text = "Target Muscle";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(321, 85);
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
            this.label22.Location = new System.Drawing.Point(321, 38);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(105, 20);
            this.label22.TabIndex = 38;
            this.label22.Text = "Choose Level";
            // 
            // comboBoxChooseLevel
            // 
            this.comboBoxChooseLevel.FormattingEnabled = true;
            this.comboBoxChooseLevel.Location = new System.Drawing.Point(450, 38);
            this.comboBoxChooseLevel.Name = "comboBoxChooseLevel";
            this.comboBoxChooseLevel.Size = new System.Drawing.Size(214, 21);
            this.comboBoxChooseLevel.TabIndex = 37;
            this.comboBoxChooseLevel.SelectedIndexChanged += new System.EventHandler(this.comboBoxChooseLevel_SelectedIndexChanged);
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
            this.comboBoxChooseDay.Location = new System.Drawing.Point(450, 85);
            this.comboBoxChooseDay.Name = "comboBoxChooseDay";
            this.comboBoxChooseDay.Size = new System.Drawing.Size(214, 21);
            this.comboBoxChooseDay.TabIndex = 36;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(680, 472);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(127, 38);
            this.btnDelete.TabIndex = 32;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnEdit.Location = new System.Drawing.Point(533, 472);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(127, 38);
            this.btnEdit.TabIndex = 31;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtGroups
            // 
            this.txtGroups.Location = new System.Drawing.Point(123, 278);
            this.txtGroups.Name = "txtGroups";
            this.txtGroups.Size = new System.Drawing.Size(148, 20);
            this.txtGroups.TabIndex = 30;
            // 
            // txtEditRepataion
            // 
            this.txtEditRepataion.Location = new System.Drawing.Point(123, 318);
            this.txtEditRepataion.Name = "txtEditRepataion";
            this.txtEditRepataion.Size = new System.Drawing.Size(148, 20);
            this.txtEditRepataion.TabIndex = 29;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(123, 359);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(148, 20);
            this.txtDesc.TabIndex = 28;
            // 
            // txtEditMuscle
            // 
            this.txtEditMuscle.Location = new System.Drawing.Point(123, 235);
            this.txtEditMuscle.Name = "txtEditMuscle";
            this.txtEditMuscle.Size = new System.Drawing.Size(148, 20);
            this.txtEditMuscle.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(14, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Repatations";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Groups";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Target Muscle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Day";
            // 
            // comboBoxEditDay
            // 
            this.comboBoxEditDay.FormattingEnabled = true;
            this.comboBoxEditDay.Items.AddRange(new object[] {
            "Saturday",
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "",
            ""});
            this.comboBoxEditDay.Location = new System.Drawing.Point(123, 194);
            this.comboBoxEditDay.Name = "comboBoxEditDay";
            this.comboBoxEditDay.Size = new System.Drawing.Size(148, 21);
            this.comboBoxEditDay.TabIndex = 15;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSearch.Location = new System.Drawing.Point(617, 59);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(125, 33);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // comboBoxSearchByLevel
            // 
            this.comboBoxSearchByLevel.FormattingEnabled = true;
            this.comboBoxSearchByLevel.Location = new System.Drawing.Point(329, 65);
            this.comboBoxSearchByLevel.Name = "comboBoxSearchByLevel";
            this.comboBoxSearchByLevel.Size = new System.Drawing.Size(265, 21);
            this.comboBoxSearchByLevel.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(209, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "choose Level";
            // 
            // dataGridViewShowTraining
            // 
            this.dataGridViewShowTraining.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.dataGridViewShowTraining.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewShowTraining.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewShowTraining.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewShowTraining.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShowTraining.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DayName,
            this.Muscle,
            this.Groups,
            this.Repatation,
            this.Desc,
            this.image});
            this.dataGridViewShowTraining.EnableHeadersVisualStyles = false;
            this.dataGridViewShowTraining.GridColor = System.Drawing.Color.White;
            this.dataGridViewShowTraining.Location = new System.Drawing.Point(306, 193);
            this.dataGridViewShowTraining.Name = "dataGridViewShowTraining";
            this.dataGridViewShowTraining.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewShowTraining.RowHeadersVisible = false;
            this.dataGridViewShowTraining.RowHeadersWidth = 600;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewShowTraining.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewShowTraining.Size = new System.Drawing.Size(675, 261);
            this.dataGridViewShowTraining.TabIndex = 37;
            this.dataGridViewShowTraining.SelectionChanged += new System.EventHandler(this.dataGridViewShowTraining_SelectionChanged_1);
            // 
            // DayName
            // 
            this.DayName.HeaderText = "Day Name";
            this.DayName.Name = "DayName";
            // 
            // Muscle
            // 
            this.Muscle.HeaderText = "Target Muscle";
            this.Muscle.Name = "Muscle";
            // 
            // Groups
            // 
            this.Groups.HeaderText = "Groups";
            this.Groups.Name = "Groups";
            // 
            // Repatation
            // 
            this.Repatation.HeaderText = "Repatation";
            this.Repatation.Name = "Repatation";
            // 
            // Desc
            // 
            this.Desc.HeaderText = "Descraption";
            this.Desc.Name = "Desc";
            // 
            // image
            // 
            this.image.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.image.HeaderText = "Image";
            this.image.Name = "image";
            // 
            // pictureBoxAdd
            // 
            this.pictureBoxAdd.Location = new System.Drawing.Point(656, 192);
            this.pictureBoxAdd.Name = "pictureBoxAdd";
            this.pictureBoxAdd.Size = new System.Drawing.Size(176, 116);
            this.pictureBoxAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAdd.TabIndex = 48;
            this.pictureBoxAdd.TabStop = false;
            // 
            // trainingDayBindingSource
            // 
            this.trainingDayBindingSource.DataSource = typeof(project.TrainingDay);
            // 
            // TrainingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 575);
            this.Controls.Add(this.panelSearchTraining);
            this.Controls.Add(this.panel1tranin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TrainingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrainingForm";
            this.panel1tranin.ResumeLayout(false);
            this.panel1tranin.PerformLayout();
            this.panelSearchTraining.ResumeLayout(false);
            this.panelSearchTraining.PerformLayout();
            this.panelAddNewProgram.ResumeLayout(false);
            this.panelAddNewProgram.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowTraining)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingDayBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1tranin;
        private System.Windows.Forms.Button btnSearchProgrm;
        private System.Windows.Forms.Button btnAddProgram;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Panel panelSearchTraining;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox comboBoxSearchByLevel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtGroups;
        private System.Windows.Forms.TextBox txtEditRepataion;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtEditMuscle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxEditDay;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn targetMuscleDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource trainingDayBindingSource;
        private System.Windows.Forms.Panel panelAddNewProgram;
        private System.Windows.Forms.Button btnAddPic;
        private System.Windows.Forms.TextBox txtAddDesc;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox pictureBoxAdd;
        private System.Windows.Forms.TextBox txtAddGroups;
        private System.Windows.Forms.TextBox txtAddRepatation;
        private System.Windows.Forms.TextBox txtAddMuscle;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox comboBoxChooseLevel;
        private System.Windows.Forms.ComboBox comboBoxChooseDay;
        private System.Windows.Forms.Label lblAddSuccess;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridViewShowTraining;
        private System.Windows.Forms.DataGridViewTextBoxColumn DayName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Muscle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Groups;
        private System.Windows.Forms.DataGridViewTextBoxColumn Repatation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desc;
        private System.Windows.Forms.DataGridViewImageColumn image;
    }
}