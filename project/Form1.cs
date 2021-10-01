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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(g.Meals.Find(1).Breakfast);
            timer.Start();

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:MM");
            lblSeconds.Text = DateTime.Now.ToString("ss");
            lblDate.Text = DateTime.Now.ToString("MMMM dd yyyy");
            lblDay.Text = DateTime.Now.ToString("dddd");
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            Members m = new Members();
            m.Show();
            Hide();
        }

        private void btnSubscribtions_Click(object sender, EventArgs e)
        {
            SubscribtionForm s = new SubscribtionForm();
            s.Show();
            Hide();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            StaffForm s = new StaffForm();
            s.Show();
            Hide();
        }

        private void btnTrainingPrograms_Click(object sender, EventArgs e)
        {
            TrainingForm s = new TrainingForm();
            s.Show();
            Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSupplements_Click(object sender, EventArgs e)
        {
            SupplementsForm s = new SupplementsForm();
            s.Show();
            Hide();
        }

        private void btnDiet_Click(object sender, EventArgs e)
        {
            DietForm s = new DietForm();
            s.Show();
            Hide();
        }

        private void btnIncom_Click(object sender, EventArgs e)
        {

            income s = new income();
            s.Show();
            Hide();
        }

        private void btnCoffe_Click(object sender, EventArgs e)
        {
            coffeeForm s = new coffeeForm();
            s.Show();
            Hide();
        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
