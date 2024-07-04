using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Invoice.UI;
using Microsoft.VisualBasic;

namespace Invoice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Add(object sender, EventArgs e)
        {
            //string Fname = Microsoft.VisualBasic.Interaction.InputBox("Enter customer firist name ", "Add Customer");
            //string Lname = Microsoft.VisualBasic.Interaction.InputBox("Enter customer Last name ", "Add Customer");
            Add A = new Add();
            A.Show();
        }

        private void Edit(object sender, EventArgs e)
        {
            Edit E = new Edit();
            E.Show();
        }

        private void Delete(object sender, EventArgs e)
        {
            Delete D = new Delete();
            D.Show();
        }     

        private void Products(object sender, EventArgs e)
        {
            Products P = new Products();
            P.Show();
        }

        private void Bill(object sender, EventArgs e)
        {
            Bill B = new Bill();
            B.Show();
        }
    }
}
