using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class DietForm : Form
    {
        GYMEntities2 context = new GYMEntities2();
        public DietForm()
        {
            InitializeComponent();
            FillDataGridView();
            AddDatatoComboBox();
        }
        private void FillDataGridView()
        {
            BindingSource _source = new BindingSource();
            _source.DataSource = context.Meals.Select(m => m).ToList();
            dataGridViewShowDiet.DataSource = _source;
        }
        private void AddDatatoComboBox()
        {
            comboBoxSearchDiet.DataSource = context.Diets.Select(d => d).ToList();
            comboBoxSearchDiet.DisplayMember = "Calories";
            comboBoxSearchDiet.ValueMember = "DietID";
        }

        private void panelAddNewProgram_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBoxChooseDay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtBreakfast.Text == "" || txtDietName.Text == "" || txtDinner.Text == "" || txtFirstSnack.Text == "" || txtLunch.Text ==""|| txtSecondSnack.Text == "" || comboBoxChooseDay.Text=="")
            {
                MessageBox.Show("Missing Information");
            }
            
            else
            {
                var y = context.Meals.Add(new Meal()
                {
                    Breakfast = txtBreakfast.Text,
                    Snack1 = txtFirstSnack.Text,
                    Snack2 = txtSecondSnack.Text,
                    Dinner = txtDinner.Text,
                    Lunch = txtLunch.Text,
                    Day = comboBoxChooseDay.Text,
       
                });
                var s = context.Diets.Add(new Diet(){
                    Calories= txtDietName.Text,
                });
                context.SaveChanges();
                lblAddSuccess.Visible = true;
                FillDataGridView();
                dataGridViewShowDiet.Update();
                dataGridViewShowDiet.Refresh();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblAddSuccess.Visible = false;
            txtBreakfast.Text = "";
           txtFirstSnack.Text = "";
            txtSecondSnack.Text = "";
            txtDinner.Text = "";
            txtLunch.Text = "";
            comboBoxChooseDay.Text = "";
            txtDietName.Text = "";
        }

        private void dataGridViewShowDiet_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewShowDiet.CurrentRow != null)
                {
                    try
                    {

                    txtEditBreakfast.Text = dataGridViewShowDiet.CurrentRow.Cells[1].Value.ToString();
                    txtSnack1.Text = dataGridViewShowDiet.CurrentRow.Cells[2].Value.ToString();
                    txtEditLunch.Text = dataGridViewShowDiet.CurrentRow.Cells[3].Value.ToString();
                    txtSnack2.Text = dataGridViewShowDiet.CurrentRow.Cells[4].Value.ToString();
                    txtEditDinner.Text = dataGridViewShowDiet.CurrentRow.Cells[5].Value.ToString();
                    }
                    catch(Exception x)
                    {

                    }

                }
                else
                {
                    txtEditBreakfast.Text = " ";
                    txtSnack1.Text = " ";
                    txtEditLunch.Text = " ";
                    txtSnack2.Text = "";
                    txtEditDinner.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Not Valid!");
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DialogResult sure = MessageBox.Show("Are you sure You Want To change Data? ", "Confirm", MessageBoxButtons.YesNo);
            if (sure == DialogResult.Yes)
            {
                try
                {
                    if (dataGridViewShowDiet.CurrentRow != null)
                    {
                        dataGridViewShowDiet.CurrentRow.Cells[1].Value = txtEditBreakfast.Text;
                        dataGridViewShowDiet.CurrentRow.Cells[2].Value = txtSnack1.Text;
                        dataGridViewShowDiet.CurrentRow.Cells[3].Value = txtEditLunch.Text;
                        dataGridViewShowDiet.CurrentRow.Cells[4].Value = txtSnack2.Text;
                        dataGridViewShowDiet.CurrentRow.Cells[5].Value = txtEditDinner.Text;
                        context.SaveChanges();
                    }
                }
                catch
                {
                    MessageBox.Show("Not Valid!");

                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                DialogResult sure = MessageBox.Show("Are you sure ? ", "Confirm", MessageBoxButtons.YesNo);
                if (sure == DialogResult.Yes)
                {
                    if (dataGridViewShowDiet.CurrentRow != null)
                    {
                        dataGridViewShowDiet.Rows.RemoveAt(dataGridViewShowDiet.CurrentCell.RowIndex);
                        context.SaveChanges();

                    }
                }
            }
            catch
            {
                MessageBox.Show("Not Valid!");
            }
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Close();
            f.Show();
        }

        private void btnSearchDiet_Click(object sender, EventArgs e)
        {
            panelSearchDiet.Visible = !panelSearchDiet.Visible;

        }

        private void btnAddDiet_Click(object sender, EventArgs e)
        {
            panelAddNewDiet.Show();
            panelSearchDiet.Hide();
        }

        private void Search_Click(object sender, EventArgs e)
        {

            BindingSource _source = new BindingSource();
            _source.DataSource = context.Meals.Where(d => d.DietID == (int)comboBoxSearchDiet.SelectedValue).Select(m => m).ToList();
            dataGridViewShowDiet.DataSource = _source;
        }
    }
}
