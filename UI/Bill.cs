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
    public partial class Bill : Form
    {
        public Bill()
        {
            InitializeComponent();
        }

        productsBLL p = new productsBLL();
        ProductsDAL dal = new ProductsDAL();

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Bill_Load(object sender, EventArgs e)
        {            
            DataTable dt = dal.SelectP();
            dgvProducts.DataSource = dt;

        }

        private void dgvProducts_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;

            if (txtItem1.Text == "")
            {
                txtItem1.Text = dgvProducts.Rows[rowIndex].Cells[0].Value.ToString();
                txtDesc1.Text = dgvProducts.Rows[rowIndex].Cells[1].Value.ToString();
                txtAmount1.Text = dgvProducts.Rows[rowIndex].Cells[2].Value.ToString();                

                txtTotal.Text = (float.Parse(txtAmount1.Text)).ToString();
            }
            else if (txtItem1.Text != "" && txtItem2.Text == "")
            {
                txtItem2.Text = dgvProducts.Rows[rowIndex].Cells[0].Value.ToString();
                txtDesc2.Text = dgvProducts.Rows[rowIndex].Cells[1].Value.ToString();
                txtAmount2.Text = dgvProducts.Rows[rowIndex].Cells[2].Value.ToString();                
                
                txtTotal.Text = (float.Parse(txtAmount1.Text) + float.Parse(txtAmount2.Text)).ToString();

            }
            else if (txtItem2.Text != "" && txtItem3.Text == "")
            {
                txtItem3.Text = dgvProducts.Rows[rowIndex].Cells[0].Value.ToString();
                txtDesc3.Text = dgvProducts.Rows[rowIndex].Cells[1].Value.ToString();
                txtAmount3.Text = dgvProducts.Rows[rowIndex].Cells[2].Value.ToString();
                txtTotal.Text = (float.Parse(txtAmount1.Text) + float.Parse(txtAmount2.Text) + float.Parse(txtAmount3.Text)).ToString();
            }
            else if (txtItem3.Text != "" && txtItem4.Text == "")
            {
                txtItem4.Text = dgvProducts.Rows[rowIndex].Cells[0].Value.ToString();
                txtDesc4.Text = dgvProducts.Rows[rowIndex].Cells[1].Value.ToString();
                txtAmount4.Text = dgvProducts.Rows[rowIndex].Cells[2].Value.ToString();
                txtTotal.Text = (float.Parse(txtAmount1.Text) + float.Parse(txtAmount2.Text) + float.Parse(txtAmount3.Text) + float.Parse(txtAmount4.Text)).ToString();
            }                            

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
