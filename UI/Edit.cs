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
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
        }

        userBLL b = new userBLL();
        userDAL dal = new userDAL();

        private void Edit_Load(object sender, EventArgs e)
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
            txtID.Text = dgvUsers.Rows[rowIndex].Cells[0].Value.ToString();
            txtFname.Text = dgvUsers.Rows[rowIndex].Cells[1].Value.ToString();
            txtLname.Text = dgvUsers.Rows[rowIndex].Cells[2].Value.ToString();
            txtAddress.Text = dgvUsers.Rows[rowIndex].Cells[3].Value.ToString();
            txtMobile.Text = dgvUsers.Rows[rowIndex].Cells[4].Value.ToString();            
        }

        private void bUpdate_Click(object sender, EventArgs e)
        {
            b.id = Convert.ToInt32(txtID.Text);
            b.First_Name = txtFname.Text;
            b.Last_Name = txtLname.Text;
            b.Address = txtAddress.Text;
            b.Mobile = Convert.ToInt32(txtMobile.Text);

            bool success = dal.Update(b);
            if (success == true)
            {
                MessageBox.Show("Customer information Successfully updated.");
                clear();
            }
            else
            {
                MessageBox.Show("Error");
            }
            DataTable dt = dal.Select();
            dgvUsers.DataSource = dt;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            b.id = Convert.ToInt32(txtID.Text);

            bool success = dal.Delete(b);
            if (success == true)
            {
                MessageBox.Show("Customer Successfully Deleted.");
                clear();
            }
            else
            {
                MessageBox.Show("Faild to delete customer");
            }
            DataTable dt = dal.Select();
            dgvUsers.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtSearch.Text;

            if (keywords != null)
            {
                DataTable dt = dal.Search(keywords);
                dgvUsers.DataSource = dt;
            }
            else
            {
                DataTable dt = dal.Select();
                dgvUsers.DataSource = dt;
            }
        }
    }
}
