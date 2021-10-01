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
    public partial class Members : Form
    {

        public int getMemberID;
       GYMEntities2 context = new GYMEntities2();
        public Members()
        {
            InitializeComponent();
            AddDataToComboBox();
            FillDataGridView();
        }
        private void FillDataGridView()
        {
            BindingSource _source = new BindingSource();
            var data = context.Members;
            _source.DataSource = data.Select(m => m).ToList();
            dataGridViewShowMembers.DataSource = _source;

        }
        private void AddDataToComboBox()
        {
            comboBoxSubscribtion.DataSource = context.Subscribtions.Select(d => d).ToList();
            comboBoxSubscribtion.DisplayMember = "Type";
            comboBoxSubscribtion.ValueMember = "SubscribtionID";
           
        }

       
        private void lblClose_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }

        private void btnAddNewMember_Click(object sender, EventArgs e)
        {
            panelAddMemeber.Show();
            panelFindMember.Hide();
        }

        private void btnFindMember_Click(object sender, EventArgs e)
        {

            panelFindMember.Visible = !panelFindMember.Visible;
    
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtAge.Text == "" || txtPaid.Text == "" || txtPhone.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else if (!Regex.IsMatch(txtPhone.Text, @"^(-?[1-9]+\d*([.]\d+)?)$|^(-?0[.]\d*[1-9]+)$|^0$|^0.0$"))
            {
                MessageBox.Show(" Phone Should be a number!");
            }
            else if(!Regex.IsMatch(txtAge.Text, @"^(-?[1-9]+\d*([.]\d+)?)$|^(-?0[.]\d*[1-9]+)$|^0$|^0.0$") || int.Parse(txtAge.Text) < 10 || int.Parse(txtAge.Text) > 60)
            {
                MessageBox.Show(" Enter a valid age !"); 
            }
            else if (int.Parse(txtPaid.Text) < 0 )
            {
                MessageBox.Show("Really!! Enter a valid number for paid");
            }
            else 
            {
                int x = int.Parse(comboBoxSubscribtion.SelectedValue.ToString());
                var y = context.Members.Add(new Member()
                {
                    MemberName = txtName.Text,
                    MemberAge = int.Parse(txtAge.Text),
                    SubscribtionID = x,
                    MemberGender = comboBoxGender.SelectedText,
                    Phone = txtPhone.Text,
                    Paid = int.Parse(txtPaid.Text),
                    EnrollmentDate = DateTime.Today,
                    RemainingAmount = (context.Subscribtions.Find(x).Price) - int.Parse(txtPaid.Text) 
                });
                context.SaveChanges();
                lblAddmemberSuccess.Text = txtName.Text + " has been added Successfully ";
                lblAddmemberSuccess.Visible = true;
                btnGetBarcode.Visible = true;
                getMemberID = y.MemberID;    
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblAddmemberSuccess.Visible = false;
            btnGetBarcode.Visible = false;

            txtName.Text = " ";
            txtAge.Text = " ";
            txtPaid.Text = " ";
            txtPhone.Text = " ";
        } 

        private void panelFindMember_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGetBarcode_Click(object sender, EventArgs e)
        {
            Zen.Barcode.Code128BarcodeDraw brcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
           
            var picture = new PictureBox
            {
                Name = "pictureBox",
                Size = new Size(200, 200),
                Location = new Point(100, 100),
                Image = brcode.Draw(getMemberID.ToString(), 60),

            };
            var formPopup = new Form();
            formPopup.Controls.Add(picture);
            formPopup.Show();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            BindingSource _source = new BindingSource();
             _source.DataSource = context.Members.Where(d => d.MemberName == txtSearchName.Text).Select(m => m).ToList();
            dataGridViewShowMembers.DataSource = _source;
        }

        private void txtSearchName_Click(object sender, EventArgs e)
        {
            this.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult sure =MessageBox.Show("Are you sure ? ", "Confirm", MessageBoxButtons.YesNo);
            if (sure== DialogResult.Yes)
            {
            dataGridViewShowMembers.Rows.RemoveAt(dataGridViewShowMembers.CurrentCell.RowIndex);
                context.SaveChanges();
            }
        }

        private void dataGridViewShowMembers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            DialogResult sure = MessageBox.Show("Are you sure You Want To change Data? ", "Confirm", MessageBoxButtons.YesNo);
            if (sure == DialogResult.Yes)
            {
            int y = (int) dataGridViewShowMembers.CurrentRow.Cells[6].Value;
            int id = (int) dataGridViewShowMembers.CurrentRow.Cells[7].Value;
                var x = context.Members.Where(m => m.Subscribtion.SubscribtionID == y && m.MemberID == id).Select(m => m.Subscribtion.Price).SingleOrDefault();
                dataGridViewShowMembers.CurrentRow.Cells[0].Value = txtEditName.Text;
                dataGridViewShowMembers.CurrentRow.Cells[1].Value = txtEditAge.Text;
                dataGridViewShowMembers.CurrentRow.Cells[2].Value = comboBoxEditGender.Text;
                dataGridViewShowMembers.CurrentRow.Cells[3].Value = txtEditPaid.Text;
                dataGridViewShowMembers.CurrentRow.Cells[4].Value = x - int.Parse(txtEditPaid.Text);
                dataGridViewShowMembers.CurrentRow.Cells[5].Value = txtEditPhone.Text;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {

     
        }

     

        private void dataGridViewShowMembers_SelectionChanged_1(object sender, EventArgs e)
        {

            txtEditName.Text= dataGridViewShowMembers.CurrentRow.Cells[0].Value.ToString() ;
            txtEditAge.Text= dataGridViewShowMembers.CurrentRow.Cells[1].Value.ToString() ;
            txtEditPhone.Text=dataGridViewShowMembers.CurrentRow.Cells[5].Value.ToString() ;
            txtEditPaid.Text= dataGridViewShowMembers.CurrentRow.Cells[3].Value.ToString() ;
        }
    }
}
