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
    public partial class income : Form
    {
        GYMEntities2 context =new  GYMEntities2();
        public income()
        {
            InitializeComponent();
        }

        private void panelAddSupp_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Close();
            f.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
            //var i = context.
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (txtWBill.Text == "")
            {
                txtWBill.Text = "0";
            }
            else if (txtOther.Text == "")
            {
                txtOther.Text = "0";
            }
           else if (txtSub.Text == "")
            {
                txtSub.Text = "0";
            }
           else if (txtRepairs.Text == "")
            {
                txtRepairs.Text = "0";
            }
            else if(txtCoffee.Text == "")
            {
                txtCoffee.Text = "0";
            }
            else if(txtGBill.Text == "")
            {
                txtGBill.Text = "0";
            }
            else if(txtEBill.Text == "")
            {
                txtEBill.Text = "0";
            }
            else if (comboBoxEditShift.Text == "")
            {
                MessageBox.Show("You have to Select The Shift");
            }
            else
            {
                int revenue = int.Parse(txtCoffee.Text) + int.Parse(txtOther.Text) + int.Parse(txtSub.Text);
                int expenses = int.Parse(txtWBill.Text) + int.Parse(txtEBill.Text) + int.Parse(txtGBill.Text) + int.Parse(txtRepairs.Text);
                int total = revenue - expenses;

                lblTotalRevenue.Text = revenue.ToString();
                lblTotalExpenses.Text = expenses.ToString();
                lbltNetProfit.Text = total.ToString();

                lblRevenue.Visible = true;
                lblExpenses.Visible = true;
                lblNet.Visible = true;
                lblTotalRevenue.Visible = true;
                lbltNetProfit.Visible = true;
                lblTotalExpenses.Visible = true;
                panelAdd.Visible = true;

                var s = context.ShiftIncomes.Add(new ShiftIncome()
                {
                    Date = DateTime.Now,
                    CoffeIncome = int.Parse(txtCoffee.Text),
                    SubscribesIncome = int.Parse(txtSub.Text),
                    ElectricityBills = int.Parse(txtEBill.Text),
                    WaterBills = int.Parse(txtWBill.Text),
                    GasBills = int.Parse(txtGBill.Text),
                    OtherIncome = int.Parse(txtOther.Text),
                    Repairs = int.Parse(txtRepairs.Text),
                    Shift = comboBoxEditShift.Text,
                    NetProfit = total
                });
                context.SaveChanges();
         
            }
           
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(comboBoxSearchShift.Text == "" )
            {
                MessageBox.Show("Select The Shift");
            }
            else if (dateTimePickerFind.Value.Date > DateTime.Now)
            {
                MessageBox.Show("mmmm You Selecte Date in the future ");
            }
            else
            {
                var s = context.ShiftIncomes.Where(m => comboBoxEditShift.Text == m.Shift && dateTimePickerFind.Value.Date == m.Date).Select(m => m ).ToList();
        
                if (s.Any())
                {
                    foreach (var item in s)
                    {
                    txtFindCofe.Text = item.CoffeIncome.ToString();
                    txtFindEB.Text = item.ElectricityBills.ToString();
                    txtFindGB.Text = item.GasBills.ToString();
                    txtFindOther.Text = item.OtherIncome.ToString();
                    txtFindRepairs.Text = item.Repairs.ToString();
                    txtFindWB.Text = item.WaterBills.ToString();
                    txtFindSub.Text = item.SubscribesIncome.ToString();
                    lblFingNet.Text = item.NetProfit.ToString();
                    }
                    label11.Visible = false;
                    pictureBox2.Visible = false;
                }
                else
                {
                    label11.Visible = true;
                    pictureBox2.Visible = true;
                    txtFindCofe.Text = "0";
                    txtFindEB.Text = "0";
                    txtFindGB.Text = "0";
                    txtFindOther.Text = "0";
                    txtFindRepairs.Text = "0";
                    txtFindWB.Text = "0";
                    txtFindSub.Text = "0";
                    lblFingNet.Text = "0";
                }

            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            panelFind.Visible = !panelFind.Visible;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            panelAdd.Show();
            panelFind.Hide();
        }

        private void comboBoxSearchShift_SelectedIndexChanged(object sender, EventArgs e)
        {
            label11.Visible = false;
            pictureBox2.Visible = false;
            txtFindCofe.Text = "0";
            txtFindEB.Text = "0";
            txtFindGB.Text = "0";
            txtFindOther.Text = "0";
            txtFindRepairs.Text = "0";
            txtFindWB.Text = "0";
            txtFindSub.Text = "0";
            lblFingNet.Text = "0";
        }
    }
}
