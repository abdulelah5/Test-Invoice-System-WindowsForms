
namespace Invoice.UI
{
    partial class Edit
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.bUpdate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(154, 22);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(491, 27);
            this.txtSearch.TabIndex = 6;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Search:";
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToOrderColumns = true;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(12, 67);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersWidth = 62;
            this.dgvUsers.RowTemplate.Height = 29;
            this.dgvUsers.Size = new System.Drawing.Size(820, 371);
            this.dgvUsers.TabIndex = 8;
            this.dgvUsers.Tag = "";
            this.dgvUsers.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvUsers_RowHeaderMouseClick);
            // 
            // bUpdate
            // 
            this.bUpdate.BackColor = System.Drawing.Color.CadetBlue;
            this.bUpdate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bUpdate.Location = new System.Drawing.Point(386, 469);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(126, 40);
            this.bUpdate.TabIndex = 12;
            this.bUpdate.Text = "Update";
            this.bUpdate.UseVisualStyleBackColor = false;
            this.bUpdate.Click += new System.EventHandler(this.bUpdate_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Azure;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(787, 469);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 40);
            this.button1.TabIndex = 13;
            this.button1.Tag = "bCancel";
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(1015, 154);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(214, 27);
            this.txtFname.TabIndex = 24;
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(1015, 372);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(214, 27);
            this.txtMobile.TabIndex = 23;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(1015, 307);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(214, 27);
            this.txtAddress.TabIndex = 22;
            // 
            // txtLname
            // 
            this.txtLname.Location = new System.Drawing.Point(1015, 233);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(214, 27);
            this.txtLname.TabIndex = 21;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(1015, 84);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(214, 27);
            this.txtID.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(852, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 24);
            this.label6.TabIndex = 17;
            this.label6.Text = "Mobile:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(852, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 24);
            this.label5.TabIndex = 19;
            this.label5.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(852, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(853, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Last Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(852, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "First Name:";
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.Firebrick;
            this.Delete.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(587, 469);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(126, 40);
            this.Delete.TabIndex = 26;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 544);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bUpdate);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Name = "Edit";
            this.Text = "Edit";
            this.Load += new System.EventHandler(this.Edit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Button bUpdate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Delete;
    }
}