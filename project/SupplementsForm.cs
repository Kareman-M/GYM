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
    public partial class SupplementsForm : Form
    {
        GYMEntities2 context = new GYMEntities2();
        public SupplementsForm()
        {
            InitializeComponent();
            AddDataTodatagridview();
            AddDataToComboBox();
        }
        private void AddDataToComboBox()
        {
            comboBoxSearch.DataSource = context.Supplements.Select(d => d).ToList();
            comboBoxSearch.DisplayMember = "SupplementName";
            comboBoxSearch.ValueMember = "SupplementID";
        }
        private void AddDataTodatagridview()
        {
            BindingSource _source = new BindingSource();
            _source.DataSource = context.Supplements.Select(m => m ).ToList();
            dataGridViewShowSupp.DataSource = _source;
        }
        private void lblClose_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Close();
            f.Show();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridViewShowSupp.DataSource = context.Supplements.Where(d => d.SupplementID == (int)comboBoxSearch.SelectedValue)
            .Select(d => new
            {
                d.SupplementName,
                d.Type,
                d.Price,
                d.Timing,
            }).ToList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult sure = MessageBox.Show("Are you sure ? ", "Confirm", MessageBoxButtons.YesNo);
                if (sure == DialogResult.Yes)
                {
                    if (dataGridViewShowSupp.CurrentRow != null)
                    {
                        dataGridViewShowSupp.Rows.RemoveAt(dataGridViewShowSupp.CurrentCell.RowIndex);
                        context.SaveChanges();

                    }
                }
            }
            catch (Exception r)
            {
                MessageBox.Show(r.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DialogResult sure = MessageBox.Show("Are you sure You Want To change Data? ", "Confirm", MessageBoxButtons.YesNo);
            if (sure == DialogResult.Yes)
            {
                try
                {
                    if (dataGridViewShowSupp.CurrentRow != null)
                    {
                        dataGridViewShowSupp.CurrentRow.Cells[0].Value = txtEditName.Text;
                        dataGridViewShowSupp.CurrentRow.Cells[1].Value = txtEditPrice.Text;
                        dataGridViewShowSupp.CurrentRow.Cells[2].Value = comboBoxEditType.Text;
                        dataGridViewShowSupp.CurrentRow.Cells[3].Value = comboBoxEditTime.Text;
                        context.SaveChanges();
                        dataGridViewShowSupp.Update();
                        dataGridViewShowSupp.Refresh();
                    }
                }
                catch
                {
                    MessageBox.Show("Not Valid!");

                }

            }

        }

        private void btnFindSupp_Click(object sender, EventArgs e)
        {
           panelSearchSupp.Show();
            panelAddSupp.Hide();
        }

        private void btnAddSupp_Click(object sender, EventArgs e)
        {
            panelAddSupp.Visible = !panelAddSupp.Visible;
        
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (txtName.Text == "" || txtPrice.Text == "" || comboBoxTime.Text == "" || comboBoxType.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else if (!Regex.IsMatch(txtPrice.Text, @"^(-?[1-9]+\d*([.]\d+)?)$|^(-?0[.]\d*[1-9]+)$|^0$|^0.0$") || int.Parse(txtPrice.Text) <= 0)
            {
                MessageBox.Show(" Price Should be a valid number!");
            }
            else
            {
                var y = context.Supplements.Add(new Supplement()
                {
                    SupplementName = txtName.Text,
                    Price = int.Parse(txtPrice.Text),
                    Type = comboBoxType.Text,
                    Timing = comboBoxTime.Text,
                });
                context.SaveChanges();
                lblAddSuccess.Visible = true;
                AddDataTodatagridview();
                dataGridViewShowSupp.Update();
                dataGridViewShowSupp.Refresh();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblAddSuccess.Visible = false;
            txtName.Text = "";
            txtPrice.Text = "";
            comboBoxType.Text = null;
            comboBoxTime.Text = null;
        }

      
      

  


        private void dataGridViewShowSupp_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dataGridViewShowSupp.CurrentRow != null)
            {
                txtEditName.Text = dataGridViewShowSupp.CurrentRow.Cells[0].Value.ToString();
                txtEditPrice.Text = dataGridViewShowSupp.CurrentRow.Cells[1].Value.ToString();
                comboBoxEditType.Text = dataGridViewShowSupp.CurrentRow.Cells[2].Value.ToString();
                comboBoxEditTime.Text = dataGridViewShowSupp.CurrentRow.Cells[3].Value.ToString();

            }
        }
    }
}
