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
    public partial class LoginForm : Form
    {
        GYMEntities2 context = new GYMEntities2();
        public LoginForm()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(125, Color.Black);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

       
       
        private void lblClose_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var user = context.Users.Find(1);
            string username = user.UserName;
            string password = user.Passowrd;
            if(txtUsername.Text == username && txtPassword.Text == password)
            {
                Form1 f = new Form1();
                Hide();
                f.ShowDialog();
            }
            else
            {
                label1.Visible = true;
            }
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        private void linkLabelPass_Click(object sender, EventArgs e)
        {
        
            
        }
    }
}
