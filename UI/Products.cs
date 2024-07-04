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
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        productsBLL p = new productsBLL();
        ProductsDAL dal = new ProductsDAL();

        private void bUpdate_Click(object sender, EventArgs e)
        {
            p.Items = Convert.ToInt32(txtItem.Text);
            p.Description= txtDesc.Text;
            p.Amount = Convert.ToInt32(txtAmount.Text);           

            bool success = dal.UpdateP(p);
            if (success == true)
            {
                MessageBox.Show("Products information Successfully updated.");
                clear();
            }
            else
            {
                MessageBox.Show("Error");
            }
            DataTable dt = dal.SelectP();
            dgvProducts.DataSource = dt;
        }

        private void Products_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.SelectP();
            dgvProducts.DataSource = dt;
        }

        private void clear()
        {
            txtItem.Text = "";
            txtDesc.Text = "";
            txtAmount.Text = "";            
        }

        private void dgvProducts_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtItem.Text = dgvProducts.Rows[rowIndex].Cells[0].Value.ToString();
            txtDesc.Text = dgvProducts.Rows[rowIndex].Cells[1].Value.ToString();
            txtAmount.Text = dgvProducts.Rows[rowIndex].Cells[2].Value.ToString();           
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            p.Items = Convert.ToInt32(txtItem.Text);

            bool success = dal.DeleteP(p);
            if (success == true)
            {
                MessageBox.Show("Products Successfully Deleted.");
                clear();
            }
            else
            {
                MessageBox.Show("Faild to delete Products");
            }
            DataTable dt = dal.SelectP();
            dgvProducts.DataSource = dt;
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
                DataTable dt = dal.SearchP(keywords);
                dgvProducts.DataSource = dt;
            }
            else
            {
                DataTable dt = dal.SelectP();
                dgvProducts.DataSource = dt;
            }
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            p.Description = txtDesc.Text;
            p.Amount = Convert.ToInt32(txtAmount.Text);           

            bool success = dal.InsertP(p);

            if (success == true)
            {
                MessageBox.Show("Products Successfully Added. ");
                clear();
            }
            else
            {
                MessageBox.Show("Faild to Add.");
            }
            DataTable dt = dal.SelectP();
            dgvProducts.DataSource = dt;
        }
    }
}
