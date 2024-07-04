
namespace Invoice.UI
{
    partial class Bill
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCname = new System.Windows.Forms.TextBox();
            this.txtCmobile = new System.Windows.Forms.TextBox();
            this.txtCaddress = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtAmount4 = new System.Windows.Forms.TextBox();
            this.txtDesc4 = new System.Windows.Forms.TextBox();
            this.txtItem4 = new System.Windows.Forms.TextBox();
            this.txtAmount3 = new System.Windows.Forms.TextBox();
            this.txtDesc3 = new System.Windows.Forms.TextBox();
            this.txtItem3 = new System.Windows.Forms.TextBox();
            this.txtAmount2 = new System.Windows.Forms.TextBox();
            this.txtDesc2 = new System.Windows.Forms.TextBox();
            this.txtItem2 = new System.Windows.Forms.TextBox();
            this.txtAmount1 = new System.Windows.Forms.TextBox();
            this.txtDesc1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtItem1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PrintBt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Invoice # Bill To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(860, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Customer Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mobile #";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtCname
            // 
            this.txtCname.Location = new System.Drawing.Point(198, 57);
            this.txtCname.Name = "txtCname";
            this.txtCname.Size = new System.Drawing.Size(514, 27);
            this.txtCname.TabIndex = 5;
            // 
            // txtCmobile
            // 
            this.txtCmobile.Location = new System.Drawing.Point(198, 145);
            this.txtCmobile.Name = "txtCmobile";
            this.txtCmobile.Size = new System.Drawing.Size(514, 27);
            this.txtCmobile.TabIndex = 6;
            // 
            // txtCaddress
            // 
            this.txtCaddress.Location = new System.Drawing.Point(198, 102);
            this.txtCaddress.Name = "txtCaddress";
            this.txtCaddress.Size = new System.Drawing.Size(514, 27);
            this.txtCaddress.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(935, 7);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 27);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToOrderColumns = true;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(734, 40);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersWidth = 62;
            this.dgvProducts.RowTemplate.Height = 29;
            this.dgvProducts.Size = new System.Drawing.Size(554, 224);
            this.dgvProducts.TabIndex = 30;
            this.dgvProducts.Tag = "";
            this.dgvProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellContentClick);
            this.dgvProducts.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProducts_RowHeaderMouseClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.28394F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.71606F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 232F));
            this.tableLayoutPanel1.Controls.Add(this.txtAmount4, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtDesc4, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtItem4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtAmount3, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtDesc3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtItem3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtAmount2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtDesc2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtItem2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtAmount1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtDesc1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label8, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label9, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtTotal, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtItem1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.PrintBt, 0, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 270);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1142, 414);
            this.tableLayoutPanel1.TabIndex = 31;
            // 
            // txtAmount4
            // 
            this.txtAmount4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAmount4.Location = new System.Drawing.Point(918, 294);
            this.txtAmount4.Name = "txtAmount4";
            this.txtAmount4.ReadOnly = true;
            this.txtAmount4.Size = new System.Drawing.Size(215, 27);
            this.txtAmount4.TabIndex = 49;
            // 
            // txtDesc4
            // 
            this.txtDesc4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDesc4.Location = new System.Drawing.Point(457, 294);
            this.txtDesc4.Name = "txtDesc4";
            this.txtDesc4.ReadOnly = true;
            this.txtDesc4.Size = new System.Drawing.Size(215, 27);
            this.txtDesc4.TabIndex = 48;
            // 
            // txtItem4
            // 
            this.txtItem4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtItem4.Location = new System.Drawing.Point(3, 294);
            this.txtItem4.Name = "txtItem4";
            this.txtItem4.ReadOnly = true;
            this.txtItem4.Size = new System.Drawing.Size(214, 27);
            this.txtItem4.TabIndex = 47;
            // 
            // txtAmount3
            // 
            this.txtAmount3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAmount3.Location = new System.Drawing.Point(918, 221);
            this.txtAmount3.Name = "txtAmount3";
            this.txtAmount3.ReadOnly = true;
            this.txtAmount3.Size = new System.Drawing.Size(215, 27);
            this.txtAmount3.TabIndex = 46;
            // 
            // txtDesc3
            // 
            this.txtDesc3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDesc3.Location = new System.Drawing.Point(457, 221);
            this.txtDesc3.Name = "txtDesc3";
            this.txtDesc3.ReadOnly = true;
            this.txtDesc3.Size = new System.Drawing.Size(215, 27);
            this.txtDesc3.TabIndex = 45;
            // 
            // txtItem3
            // 
            this.txtItem3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtItem3.Location = new System.Drawing.Point(3, 221);
            this.txtItem3.Name = "txtItem3";
            this.txtItem3.ReadOnly = true;
            this.txtItem3.Size = new System.Drawing.Size(214, 27);
            this.txtItem3.TabIndex = 44;
            // 
            // txtAmount2
            // 
            this.txtAmount2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAmount2.Location = new System.Drawing.Point(918, 151);
            this.txtAmount2.Name = "txtAmount2";
            this.txtAmount2.ReadOnly = true;
            this.txtAmount2.Size = new System.Drawing.Size(215, 27);
            this.txtAmount2.TabIndex = 43;
            // 
            // txtDesc2
            // 
            this.txtDesc2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDesc2.Location = new System.Drawing.Point(457, 151);
            this.txtDesc2.Name = "txtDesc2";
            this.txtDesc2.ReadOnly = true;
            this.txtDesc2.Size = new System.Drawing.Size(215, 27);
            this.txtDesc2.TabIndex = 42;
            // 
            // txtItem2
            // 
            this.txtItem2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtItem2.Location = new System.Drawing.Point(3, 151);
            this.txtItem2.Name = "txtItem2";
            this.txtItem2.ReadOnly = true;
            this.txtItem2.Size = new System.Drawing.Size(214, 27);
            this.txtItem2.TabIndex = 41;
            // 
            // txtAmount1
            // 
            this.txtAmount1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAmount1.Location = new System.Drawing.Point(918, 84);
            this.txtAmount1.Name = "txtAmount1";
            this.txtAmount1.ReadOnly = true;
            this.txtAmount1.Size = new System.Drawing.Size(215, 27);
            this.txtAmount1.TabIndex = 40;
            // 
            // txtDesc1
            // 
            this.txtDesc1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDesc1.Location = new System.Drawing.Point(457, 84);
            this.txtDesc1.Name = "txtDesc1";
            this.txtDesc1.ReadOnly = true;
            this.txtDesc1.Size = new System.Drawing.Size(215, 27);
            this.txtDesc1.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(986, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 24);
            this.label8.TabIndex = 34;
            this.label8.Text = "Amount";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(509, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 24);
            this.label7.TabIndex = 33;
            this.label7.Text = "Description";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label9.Location = new System.Drawing.Point(850, 368);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 24);
            this.label9.TabIndex = 35;
            this.label9.Text = "Total";
            this.label9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTotal.Location = new System.Drawing.Point(918, 367);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(215, 27);
            this.txtTotal.TabIndex = 50;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // txtItem1
            // 
            this.txtItem1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtItem1.Location = new System.Drawing.Point(3, 84);
            this.txtItem1.Name = "txtItem1";
            this.txtItem1.ReadOnly = true;
            this.txtItem1.Size = new System.Drawing.Size(214, 27);
            this.txtItem1.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(73, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 24);
            this.label6.TabIndex = 32;
            this.label6.Text = "Item #";
            // 
            // PrintBt
            // 
            this.PrintBt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PrintBt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PrintBt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintBt.Location = new System.Drawing.Point(57, 364);
            this.PrintBt.Name = "PrintBt";
            this.PrintBt.Size = new System.Drawing.Size(106, 33);
            this.PrintBt.TabIndex = 32;
            this.PrintBt.Text = "Print";
            this.PrintBt.UseVisualStyleBackColor = false;
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1780, 968);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtCaddress);
            this.Controls.Add(this.txtCmobile);
            this.Controls.Add(this.txtCname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Bill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice";
            this.Load += new System.EventHandler(this.Bill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCname;
        private System.Windows.Forms.TextBox txtCmobile;
        private System.Windows.Forms.TextBox txtCaddress;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAmount4;
        private System.Windows.Forms.TextBox txtDesc4;
        private System.Windows.Forms.TextBox txtItem4;
        private System.Windows.Forms.TextBox txtAmount3;
        private System.Windows.Forms.TextBox txtDesc3;
        private System.Windows.Forms.TextBox txtItem3;
        private System.Windows.Forms.TextBox txtAmount2;
        private System.Windows.Forms.TextBox txtDesc2;
        private System.Windows.Forms.TextBox txtItem2;
        private System.Windows.Forms.TextBox txtAmount1;
        private System.Windows.Forms.TextBox txtDesc1;
        private System.Windows.Forms.TextBox txtItem1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button PrintBt;
    }
}