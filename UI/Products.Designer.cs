
namespace Invoice.UI
{
    partial class Products
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
            this.Delete = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bUpdate = new System.Windows.Forms.Button();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.bAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.Firebrick;
            this.Delete.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(596, 508);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(126, 40);
            this.Delete.TabIndex = 42;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(961, 344);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(307, 27);
            this.txtAmount.TabIndex = 40;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(961, 275);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(307, 27);
            this.txtDesc.TabIndex = 39;
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(961, 197);
            this.txtItem.Name = "txtItem";
            this.txtItem.ReadOnly = true;
            this.txtItem.Size = new System.Drawing.Size(307, 27);
            this.txtItem.TabIndex = 37;
            // 
            // txtA
            // 
            this.txtA.AutoSize = true;
            this.txtA.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA.Location = new System.Drawing.Point(836, 343);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(79, 24);
            this.txtA.TabIndex = 35;
            this.txtA.Text = "Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(836, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 24);
            this.label5.TabIndex = 36;
            this.label5.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(836, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 24);
            this.label3.TabIndex = 34;
            this.label3.Text = "Item #";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Azure;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(796, 508);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 40);
            this.button1.TabIndex = 31;
            this.button1.Tag = "bCancel";
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bUpdate
            // 
            this.bUpdate.BackColor = System.Drawing.Color.CadetBlue;
            this.bUpdate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bUpdate.Location = new System.Drawing.Point(395, 508);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(126, 40);
            this.bUpdate.TabIndex = 30;
            this.bUpdate.Text = "Update";
            this.bUpdate.UseVisualStyleBackColor = false;
            this.bUpdate.Click += new System.EventHandler(this.bUpdate_Click);
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToOrderColumns = true;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(21, 106);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersWidth = 62;
            this.dgvProducts.RowTemplate.Height = 29;
            this.dgvProducts.Size = new System.Drawing.Size(799, 371);
            this.dgvProducts.TabIndex = 29;
            this.dgvProducts.Tag = "";
            this.dgvProducts.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProducts_RowHeaderMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 19);
            this.label1.TabIndex = 28;
            this.label1.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(163, 61);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(491, 27);
            this.txtSearch.TabIndex = 27;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // bAdd
            // 
            this.bAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bAdd.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAdd.Location = new System.Drawing.Point(201, 508);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(131, 40);
            this.bAdd.TabIndex = 43;
            this.bAdd.Text = "Add";
            this.bAdd.UseVisualStyleBackColor = false;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 674);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bUpdate);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Name = "Products";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Label txtA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bUpdate;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button bAdd;
    }
}