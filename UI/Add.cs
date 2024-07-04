using Invoice.BLL;
using Invoice.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoice.UI
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        userBLL b = new userBLL();
        userDAL dal = new userDAL();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtMobile_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            
            b.First_Name = txtFname.Text;
            b.Last_Name = txtLname.Text;
            b.Address = txtAddress.Text;            
            b.Mobile = Convert.ToInt32(txtMobile.Text);

            bool success = dal.Insert(b);

            if (success == true)
            {
                MessageBox.Show("Customer Successfully Added. ");                
                clear();
            }
            else
            {
                MessageBox.Show("Faild to Add.");
            }
            DataTable dt = dal.Select();
            dgvUsers.DataSource = dt;
        }

        private void Add_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dgvUsers.DataSource = dt;
        }

        private void clear()
        {
            txtID.Text = "";
            txtFname.Text = "";
            txtLname.Text = "";
            txtMobile.Text = "";
            txtAddress.Text = "";            
        }

        private void dgvUsers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;            
            txtFname.Text = dgvUsers.Rows[rowIndex].Cells[1].Value.ToString();
            txtLname.Text = dgvUsers.Rows[rowIndex].Cells[2].Value.ToString();
            txtAddress.Text = dgvUsers.Rows[rowIndex].Cells[3].Value.ToString();
            txtMobile.Text = dgvUsers.Rows[rowIndex].Cells[4].Value.ToString();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
