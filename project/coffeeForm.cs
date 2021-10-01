using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class coffeeForm : Form
    {
        GYMEntities2 context = new GYMEntities2();
        public coffeeForm()
        {
            InitializeComponent();
        }
        Bitmap bitmap;


        private void btnTea_Click(object sender, EventArgs e)
        {
            try
            {

                var btn = sender as Button;
                var Name = btn.Text.ToLower();
                var pname = context.Coffes.Where(w => w.ProductName.ToLower() == Name).Single();
                string ppname = pname.ProductName;
                string pType = pname.ProductType.ToString();
                string pprice = pname.ProductPrice.ToString();
                dataGridView1.Rows.Add(ppname.ToString(), pType.ToString(), pprice.ToString());
                AddCost();
            }
            catch
            {

            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Cash")
            {
                Change();
            }
            else
            {
                lblChange.Text = "";
                lblCash.Text = "0";
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
          
  
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);

            
            AddCost();
            if (comboBox1.Text == "Cash")
            {
                Change();
            }
            else
            {
                lblChange.Text = "";
                lblChange.Text = "0";
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                int height = dataGridView1.Height;
                dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height * 2;
                bitmap = new Bitmap(dataGridView1.Width, dataGridView1.Height);
                dataGridView1.DrawToBitmap(bitmap, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
                printPreviewDialog1.PrintPreviewControl.Zoom = 1;
                printPreviewDialog1.ShowDialog();
                dataGridView1.Height = height;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
              //  lblbarcode.Text = "";
                lblCash.Text = "0";
                lblChange.Text = "";
                lblSub_Total.Text = "";
                lblTax.Text = "";
                lblTotal.Text = "";
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                comboBox1.Text = "";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public double Cost_of_Items()
        {
            Double Sum = 0;
            int i = 0;
            for (i = 0; i < (dataGridView1.Rows.Count); i++)
            {
                Sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value);
            }
            return Sum;
        }

        private void AddCost()
        {
            Double tax, q;
            tax = 3.9;
            if (dataGridView1.Rows.Count > 0)
            {
                lblTax.Text = string.Format("{0:C2}", (((Cost_of_Items() * tax) / 100)));
                lblSub_Total.Text = string.Format("{0:C2}", (Cost_of_Items()));
                q = ((Cost_of_Items() * tax) / 100);
                lblTotal.Text = Convert.ToString(q + Cost_of_Items());

            }
        }
        private void Change()
        {
            Double tax, q, c;
            tax = 3.9;
            if (dataGridView1.Rows.Count > 0)
            {
                q = ((Cost_of_Items() * tax) / 100) + Cost_of_Items();
                c = Convert.ToInt32(lblCash.Text);
                lblChange.Text = String.Format("{0:C2}", c - q);


            }
        }
        private void calculator(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (lblCash.Text == "0")
            {
                lblCash.Text = "";
                lblCash.Text = b.Text;
            }
            else if (b.Text == ("."))
            {
                if (!lblCash.Text.Contains("."))
                {
                    lblCash.Text += b.Text;
                }
            }
            else
                lblCash.Text += b.Text;

        }

        private void coffeeForm_Load(object sender, EventArgs e)
        {

            comboBox1.Items.Add("Cash");
            comboBox1.Items.Add("Visa Card");
            comboBox1.Items.Add("Master Card");
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panelFood.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panelDrinks.BringToFront();
        }
    }
}
