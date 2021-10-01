using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class TrainingForm : Form
    {
        GYMEntities2 context = new GYMEntities2();
        public TrainingForm()
        {
            InitializeComponent();
            FillComboBox();
            FillDataGridView();
            UnEnableData();
        }
        public void FillComboBox() {
            comboBoxSearchByLevel.DataSource = context.TrainingLevels.Select(d => d).ToList();
            comboBoxSearchByLevel.DisplayMember = "LevelName";
            comboBoxSearchByLevel.ValueMember = "LevelID";
            comboBoxChooseLevel.DataSource = context.TrainingLevels.Select(d => d).ToList();
            comboBoxChooseLevel.DisplayMember = "LevelName";
            comboBoxChooseLevel.ValueMember = "LevelID";
        }
        public void UnEnableData()
        {
            comboBoxChooseDay.Enabled = false;
            txtAddDesc.Enabled = false;
            txtAddGroups.Enabled = false;
            txtAddMuscle.Enabled = false;
            txtAddRepatation.Enabled = false;
            btnAdd.Enabled = false;
            btnAddPic.Enabled = false;
            btnReset.Enabled = false;
        }
        public void EnableData()
        {
            comboBoxChooseDay.Enabled = true;
            txtAddDesc.Enabled = true;
            txtAddGroups.Enabled = true;
            txtAddMuscle.Enabled = true;
            txtAddRepatation.Enabled = true;
            btnAdd.Enabled = true;
            btnAddPic.Enabled = true;
            btnReset.Enabled = true;
        }
        public Image ConvertToImage(byte[] data)
        {
            MemoryStream ms = new MemoryStream(data);
            return Image.FromStream(ms);
        }
        public void FillDataGridView()
        {
            //BindingSource _source = new BindingSource();
              var _source =context.TrainingDays.Select(m => m);
            //dataGridViewShowTraining.DataSource = _source;
            foreach (var item in _source)
            {
                image.ImageLayout = DataGridViewImageCellLayout.Stretch;
                dataGridViewShowTraining.RowTemplate.Height = 150;
                dataGridViewShowTraining.Rows.Add(item.DayName, item.TargetMuscle, item.Groups, item.Repetations, item.TrainingDesc, ConvertToImage(item.Image));
            }
        }

        private void dataGridViewShowTraining_SelectionChanged(object sender, EventArgs e)
        {

            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            DialogResult sure = MessageBox.Show("Are you sure You want to Edit data ? ", "Confirm", MessageBoxButtons.YesNo);
            if (sure == DialogResult.Yes)
            {
                if(dataGridViewShowTraining.Rows.Count > 0)
                {

                dataGridViewShowTraining.CurrentRow.Cells[0].Value = comboBoxEditDay.Text;
                dataGridViewShowTraining.CurrentRow.Cells[1].Value = txtEditMuscle.Text;
                dataGridViewShowTraining.CurrentRow.Cells[2].Value = txtGroups.Text;
                dataGridViewShowTraining.CurrentRow.Cells[3].Value = txtEditRepataion.Text; 
                dataGridViewShowTraining.CurrentRow.Cells[4].Value = txtDesc.Text;
                context.SaveChanges();
                }
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            DialogResult sure = MessageBox.Show("Are you sure ? ", "Confirm", MessageBoxButtons.YesNo);
            if (sure == DialogResult.Yes)
            {
                if(dataGridViewShowTraining.Rows.Count > 0)
                {
                dataGridViewShowTraining.Rows.RemoveAt(dataGridViewShowTraining.CurrentCell.RowIndex);
                context.SaveChanges();

                }
                else
                {
                    MessageBox.Show("Can't be deleted");
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BindingSource _source = new BindingSource();
            _source.DataSource = context.TrainingDays.Where(m=> m.LevelID == (int)comboBoxSearchByLevel.SelectedValue).Select(m => new { m.DayName, m.TargetMuscle, m.Groups, m.Repetations, m.Image, m.TrainingDesc }).ToList();
            dataGridViewShowTraining.DataSource = _source;
        }

        private void comboBoxChooseLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableData();
        }

        private void btnAddPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            //   MemoryStream ms = new MemoryStream();
            op.Filter = "JPG Files(*.jpg)|*.jpg|GIF Files(*gif)|*.gif|AllFiles(*.*)|*.*,*.bmp";
            op.Title = "Select Program Picture";
            if (op.ShowDialog() == DialogResult.OK)
            {
                pictureBoxAdd.Image = Image.FromFile(op.FileName);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtAddDesc.Text == "" || txtAddGroups.Text == "" || txtAddMuscle.Text == "" || txtAddRepatation.Text == "" ||comboBoxChooseDay.SelectedIndex <0)
            {
                MessageBox.Show("Missing Information");
            }
            else if (!Regex.IsMatch(txtAddGroups.Text, @"^(-?[1-9]+\d*([.]\d+)?)$|^(-?0[.]\d*[1-9]+)$|^0$|^0.0$") || int.Parse(txtAddGroups.Text) <= 0)
            {
                MessageBox.Show(" Enter Valid number!");
            }
            else if (!Regex.IsMatch(txtAddRepatation.Text, @"^(-?[1-9]+\d*([.]\d+)?)$|^(-?0[.]\d*[1-9]+)$|^0$|^0.0$") || int.Parse(txtAddRepatation.Text) <= 0)
            {
                MessageBox.Show(" Enter a valid number !");
            }
            
            else
            {
                MemoryStream ms = new MemoryStream();
                pictureBoxAdd.Image.Save(ms, pictureBoxAdd.Image.RawFormat);
                byte[] imageArr = ms.ToArray();
                var y = context.TrainingDays.Add(new TrainingDay()
                {
                    LevelID = (int)comboBoxChooseLevel.SelectedValue,
                    DayName = comboBoxChooseDay.Text,
                    TargetMuscle = txtAddMuscle.Text,
                    Groups = int.Parse(txtAddGroups.Text),
                    Repetations = int.Parse(txtAddRepatation.Text),
                    TrainingDesc = txtAddDesc.Text,
                    Image = imageArr
                });
                try

                {
                context.SaveChanges();
                lblAddSuccess.Visible = true;
                FillDataGridView();
                dataGridViewShowTraining.Update();
                dataGridViewShowTraining.Refresh();
                }
                catch (DbUpdateException de)
                {
                    MessageBox.Show("You Dublicate The data insert new data");
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAddDesc.Text = "";
            txtAddGroups.Text = "";
            txtAddMuscle.Text = "";
            txtAddRepatation.Text = "";
            comboBoxChooseDay.Text = "";
            pictureBoxAdd.Image = null;
            lblAddSuccess.Visible = false;
            UnEnableData();
        }


        private void btnAddProgram_Click(object sender, EventArgs e)
        {
            panelAddNewProgram.Visible = !panelAddNewProgram.Visible;

        }

        private void btnSearchProgram_Click(object sender, EventArgs e)
        {

            panelSearchTraining.Show();
            panelAddNewProgram.Hide();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }

        private void panelAddNewProgram_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridViewShowTraining_SelectionChanged_1(object sender, EventArgs e)
        {
            try
            {

                if (dataGridViewShowTraining.CurrentRow != null)
                {
                    try
                    {

                        comboBoxEditDay.Text = dataGridViewShowTraining.CurrentRow.Cells[0].Value.ToString();
                        txtEditMuscle.Text = dataGridViewShowTraining.CurrentRow.Cells[1].Value.ToString();
                        txtGroups.Text = dataGridViewShowTraining.CurrentRow.Cells[2].Value.ToString();
                        txtEditRepataion.Text = dataGridViewShowTraining.CurrentRow.Cells[3].Value.ToString();
                        txtDesc.Text = dataGridViewShowTraining.CurrentRow.Cells[4].Value.ToString();
                    }
                    catch (Exception d)
                    {
                    }
                }
            }
            catch(Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
    }
}
