using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Data;
using System.Windows.Forms;
using Button = System.Windows.Forms.Button;

namespace project
{
    public partial class SubscribtionForm : Form
    {
        GYMEntities2 context = new GYMEntities2();
        public SubscribtionForm()
        {
            InitializeComponent();
            AddDatatoComboBox();
            FillDataGrid();
      
        }
        private void AddDatatoComboBox()
        {
            //    comboBoxSubscribtion.DataSource = context.Subscribtions.Select(d => d).ToList();
            comboBoxSearchSubscripers.DataSource = context.Subscribtions.Select(d => d).ToList();
            comboBoxSearchSubscripers.DisplayMember = "Type";
            comboBoxSearchSubscripers.ValueMember = "SubscribtionID";
            comboBoxSearchType.DataSource = context.Subscribtions.Select(d => d).ToList();
            comboBoxSearchType.DisplayMember = "Type";
            comboBoxSearchType.ValueMember = "SubscribtionID";
        }
        private void FillDataGrid()
        {
            BindingSource _source = new BindingSource();
            _source.DataSource = context.Subscribtions.Select(m => m).ToList();
            dataGridViewSub.DataSource = _source;
         
        }

   

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBoxSearchSubscripers_SelectedIndexChanged(object sender, EventArgs e)
        { 
          

        }

        private void btnSelectSubsripers_Click(object sender, EventArgs e)
        {
       
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
           
            DialogResult sure = MessageBox.Show("Are you sure You Want To change Data? ", "Confirm", MessageBoxButtons.YesNo);
            if (sure == DialogResult.Yes)
            {
                try
                {
                    if (dataGridViewSub.CurrentRow != null)
                    {
                        dataGridViewSub.CurrentRow.Cells[0].Value = comboBoxSearchType.Text ;
                         dataGridViewSub.CurrentRow.Cells[1].Value = txtEditPrice.Text ;
                        context.SaveChanges();
                    }
                }
                catch
                {
                    MessageBox.Show("Not Valid!");

                }

            }
        }

        private void panelshowmembersuscription_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {
            DialogResult sure = MessageBox.Show("Are you sure ? ", "Confirm", MessageBoxButtons.YesNo);
                if (sure == DialogResult.Yes)
                {
                    if (dataGridViewSub.CurrentRow != null)
                    {
                        dataGridViewSub.Rows.RemoveAt(dataGridViewSub.CurrentCell.RowIndex);
                        context.SaveChanges();

                    }
                }
            }
            catch (Exception r)
            {
                MessageBox.Show(r.Message);
            }
        }

   

        private void lblClose_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Close();
            f.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            if (comboBoxSearchSubscripers.SelectedValue != null)
            {
                var x = comboBoxSearchSubscripers.SelectedValue;
                dataGridViewSubscriptions.DataSource = context.Members.Where(m => m.Subscribtion.SubscribtionID == (int)x).Select(m =>m).ToList();

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtType.Text == "" || txtPrice.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else if (!Regex.IsMatch(txtPrice.Text, @"^(-?[1-9]+\d*([.]\d+)?)$|^(-?0[.]\d*[1-9]+)$|^0$|^0.0$") || int.Parse(txtPrice.Text) <= 0)
            {
                MessageBox.Show(" Price Should be a valid number!");
            }
            else
            {
                Subscribtion sub1 = new Subscribtion() { Price = int.Parse(txtPrice.Text), Type = txtType.Text };
                context.Subscribtions.Add(sub1);
                context.SaveChanges();
                lblAddSubscriptionSystemSuccess.Visible = true;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblAddSubscriptionSystemSuccess.Visible = false;
            txtType.Text = "";
            txtPrice.Text = "";
        }

        private void btnsubscribtionmembers_Click(object sender, EventArgs e)
        {

            panelshowmembersuscription.Show();
            panelAddSub.Hide();
        }

        private void btnAddNewSubscription_Click(object sender, EventArgs e)
        {
            panelAddSub.Visible = !panelAddSub.Visible;
        }

        private void dataGridViewSub_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridViewSub.CurrentRow !=null)
            {
                comboBoxSearchType.Text = dataGridViewSub.CurrentRow.Cells[0].Value.ToString();
                txtEditPrice.Text = dataGridViewSub.CurrentRow.Cells[1].Value.ToString();
            }
        }
    }
}
