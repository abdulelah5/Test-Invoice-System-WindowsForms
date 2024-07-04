
namespace Invoice.UI
{
    partial class Add
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.bAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Address:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(186, 81);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(214, 27);
            this.txtID.TabIndex = 5;
            // 
            // txtLname
            // 
            this.txtLname.Location = new System.Drawing.Point(186, 230);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(214, 27);
            this.txtLname.TabIndex = 6;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(186, 304);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(214, 27);
            this.txtAddress.TabIndex = 7;
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(186, 151);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(214, 27);
            this.txtFname.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 372);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 24);
            this.label6.TabIndex = 3;
            this.label6.Text = "Mobile:";
            this.label6.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(186, 369);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(214, 27);
            this.txtMobile.TabIndex = 8;
            this.txtMobile.TextChanged += new System.EventHandler(this.txtMobile_TextChanged);
            // 
            // bAdd
            // 
            this.bAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bAdd.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAdd.Location = new System.Drawing.Point(150, 489);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(131, 40);
            this.bAdd.TabIndex = 11;
            this.bAdd.Text = "Add";
            this.bAdd.UseVisualStyleBackColor = false;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Azure;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(352, 489);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 40);
            this.button1.TabIndex = 14;
            this.button1.Tag = "bCancel";
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvUsers
            // 
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(426, 50);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersWidth = 62;
            this.dgvUsers.RowTemplate.Height = 29;
            this.dgvUsers.Size = new System.Drawing.Size(868, 383);
            this.dgvUsers.TabIndex = 15;
            this.dgvUsers.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvUsers_RowHeaderMouseClick);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1306, 564);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Add";
            this.Text = "Add";
            this.Load += new System.EventHandler(this.Add_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvUsers;
    }
}