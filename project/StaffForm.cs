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
    public partial class StaffForm : Form
    {
        GYMEntities2 context = new GYMEntities2();
        public StaffForm()
        {
            InitializeComponent();
            FillDataGridView();
        }
       private void FillDataGridView()
        {
            BindingSource _source = new BindingSource();
            _source.DataSource = context.Workers.Select(m => m).ToList();
            dataGridViewShowStaff.DataSource = _source;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtSalary.Text == "" || txtPhone.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else if (!Regex.IsMatch(txtPhone.Text, @"^(-?[1-9]+\d*([.]\d+)?)$|^(-?0[.]\d*[1-9]+)$|^0$|^0.0$"))
            {
                MessageBox.Show(" Phone Should be a number!");
            }
            else if (!Regex.IsMatch(txtSalary.Text, @"^(-?[1-9]+\d*([.]\d+)?)$|^(-?0[.]\d*[1-9]+)$|^0$|^0.0$") || int.Parse(txtSalary.Text) < 1000 )
            {
                MessageBox.Show(" Enter a valid salary !");
            }
            else if (DateTime.Now.Year - dateTimePickerBirthdate.Value.Year <= 18 || DateTime.Now.Year - dateTimePickerBirthdate.Value.Year > 40)
            {
                MessageBox.Show("Date of Birth not valid");
            }
            else
            {
                var y = context.Workers.Add(new Worker()
                {
                    WorkerName = txtName.Text,
                    Salary = int.Parse(txtSalary.Text),
                    Birhtdate = dateTimePickerBirthdate.Value,
                    HireDate = DateTime.Today,
                    Position = comboBoxPosition.Text,
                    Shift = comboBoxShift.Text,
                    Phone = int.Parse(txtPhone.Text)
                }) ;
                context.SaveChanges();
                lblAddWorkerSuccess.Text = txtName.Text + " has been added Successfully ";
                lblAddWorkerSuccess.Visible = true;
                FillDataGridView();
                dataGridViewShowStaff.Update();
                dataGridViewShowStaff.Refresh();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblAddWorkerSuccess.Visible = false;

            txtName.Text = " ";
            txtSalary.Text = " ";
            txtPhone.Text = " ";
            dateTimePickerBirthdate.Value = DateTime.Today;
            comboBoxShift.Text = "";
            comboBoxPosition.Text = "";

        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Close();
            f.Show();
        }

         // to make a right click menu
        private void comboBoxPosition_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                ContextMenu cm = new ContextMenu();


            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // BindingSource _source = new BindingSource();
            dataGridViewShowStaff.DataSource = context.Workers.Where(d => d.Position == comboBoxSearchBuPosition.Text).Select(m => m).ToList();
         //   dataGridViewShowStaff.DataSource = _source;
         if(comboBoxSearchBuPosition.Text == "All")
            {
                dataGridViewShowStaff.DataSource = context.Workers.Select(m =>  m).ToList();

            }
        }

        private void btnAddNewWorker_Click(object sender, EventArgs e)
        {
            panelAddWorker.Show();
            panelFindWorker.Hide();
        }

        private void btnFindMember_Click(object sender, EventArgs e)
        {
            panelFindWorker.Visible = !panelFindWorker.Visible;
        }

        private void Search_Click(object sender, EventArgs e)
        {
            BindingSource _source = new BindingSource();
            _source.DataSource = context.Workers.Where(d => d.WorkerName == txtSearchName.Text).Select(m => m ).ToList();
            dataGridViewShowStaff.DataSource = _source;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DialogResult sure = MessageBox.Show("Are you sure You Want To change Data? ", "Confirm", MessageBoxButtons.YesNo);
            if (sure == DialogResult.Yes)
            {
                try
                {
                    if (dataGridViewShowStaff.CurrentRow != null)
                    {
                        dataGridViewShowStaff.CurrentRow.Cells[0].Value = txtEditName.Text;
                        dataGridViewShowStaff.CurrentRow.Cells[1].Value = txtEditSalary.Text;
                        dataGridViewShowStaff.CurrentRow.Cells[2].Value = comboBoxEditPosition.Text;
                        dataGridViewShowStaff.CurrentRow.Cells[3].Value = comboBoxEditShift.Text;
                        dataGridViewShowStaff.CurrentRow.Cells[4].Value = txtEditPhone.Text;
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
                    if (dataGridViewShowStaff.CurrentRow != null)
                    {
                        dataGridViewShowStaff.Rows.RemoveAt(dataGridViewShowStaff.CurrentCell.RowIndex);
                        context.SaveChanges();

                    }
                }
            }
            catch
            {
                MessageBox.Show("Not Valid!");
            }

        }

       
        private void dataGridViewShowStaff_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewShowStaff.CurrentRow != null)
                {

                    txtEditName.Text = dataGridViewShowStaff.CurrentRow.Cells[0].Value.ToString();
                    txtEditSalary.Text = dataGridViewShowStaff.CurrentRow.Cells[1].Value.ToString();
                    comboBoxEditPosition.Text = dataGridViewShowStaff.CurrentRow.Cells[2].Value.ToString();
                    comboBoxEditShift.Text = dataGridViewShowStaff.CurrentRow.Cells[3].Value.ToString();
                    txtEditPhone.Text = dataGridViewShowStaff.CurrentRow.Cells[4].Value.ToString();
                }
                else
                {
                    txtEditName.Text = " ";
                    txtEditSalary.Text = " ";
                    txtEditPhone.Text = " ";
                    comboBoxEditPosition.Text = "";
                    comboBoxEditShift.Text = "";
                }
            }
            catch 
            {
                MessageBox.Show("Not Valid!");
            }
           
        }
    }
}
