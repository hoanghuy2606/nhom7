namespace frmfind
{
    partial class Form1
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
            this.dtgv_Product = new System.Windows.Forms.DataGridView();
            this.btn_FindProduct = new System.Windows.Forms.Button();
            this.txt_Lookup = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_Product
            // 
            this.dtgv_Product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Product.Location = new System.Drawing.Point(69, 275);
            this.dtgv_Product.Margin = new System.Windows.Forms.Padding(4);
            this.dtgv_Product.Name = "dtgv_Product";
            this.dtgv_Product.RowHeadersWidth = 51;
            this.dtgv_Product.Size = new System.Drawing.Size(879, 212);
            this.dtgv_Product.TabIndex = 1;
            this.dtgv_Product.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_Product_CellContentClick);
            // 
            // btn_FindProduct
            // 
            this.btn_FindProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FindProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_FindProduct.Location = new System.Drawing.Point(619, 46);
            this.btn_FindProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btn_FindProduct.Name = "btn_FindProduct";
            this.btn_FindProduct.Size = new System.Drawing.Size(124, 42);
            this.btn_FindProduct.TabIndex = 9;
            this.btn_FindProduct.Text = "Tìm kiếm";
            this.btn_FindProduct.UseVisualStyleBackColor = true;
            this.btn_FindProduct.Click += new System.EventHandler(this.btn_FindProduct_Click);
            // 
            // txt_Lookup
            // 
            this.txt_Lookup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Lookup.Location = new System.Drawing.Point(324, 59);
            this.txt_Lookup.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Lookup.Name = "txt_Lookup";
            this.txt_Lookup.Size = new System.Drawing.Size(189, 26);
            this.txt_Lookup.TabIndex = 10;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(107, 66);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(135, 20);
            this.label15.TabIndex = 11;
            this.label15.Text = "Dữ liệu tìm kiếm:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(69, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(879, 107);
            this.dataGridView1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 538);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txt_Lookup);
            this.Controls.Add(this.btn_FindProduct);
            this.Controls.Add(this.dtgv_Product);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_Product;
        private System.Windows.Forms.Button btn_FindProduct;
        private System.Windows.Forms.TextBox txt_Lookup;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

