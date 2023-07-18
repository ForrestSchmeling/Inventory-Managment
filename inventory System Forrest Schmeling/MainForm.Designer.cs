namespace inventory_System_Forrest_Schmeling
{
    partial class MainForm
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
            this.SearchButtonPart = new System.Windows.Forms.Button();
            this.partTable = new System.Windows.Forms.DataGridView();
            this.SearchButtonProduct = new System.Windows.Forms.Button();
            this.productTable = new System.Windows.Forms.DataGridView();
            this.AddPart = new System.Windows.Forms.Button();
            this.AddProduct = new System.Windows.Forms.Button();
            this.ModifyPart = new System.Windows.Forms.Button();
            this.ModifyProduct = new System.Windows.Forms.Button();
            this.DeletePart = new System.Windows.Forms.Button();
            this.DeleteProduct = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.PartLabel = new System.Windows.Forms.Label();
            this.ProductLabel = new System.Windows.Forms.Label();
            this.TextBoxPart = new System.Windows.Forms.TextBox();
            this.TextBoxProduct = new System.Windows.Forms.TextBox();
            this.LabelTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.partTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTable)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchButtonPart
            // 
            this.SearchButtonPart.Location = new System.Drawing.Point(256, 46);
            this.SearchButtonPart.Margin = new System.Windows.Forms.Padding(2);
            this.SearchButtonPart.Name = "SearchButtonPart";
            this.SearchButtonPart.Size = new System.Drawing.Size(57, 25);
            this.SearchButtonPart.TabIndex = 0;
            this.SearchButtonPart.Text = "Search";
            this.SearchButtonPart.UseVisualStyleBackColor = true;
            this.SearchButtonPart.Click += new System.EventHandler(this.SearchButtonPart_Click);
            // 
            // partTable
            // 
            this.partTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partTable.Location = new System.Drawing.Point(16, 75);
            this.partTable.Margin = new System.Windows.Forms.Padding(2);
            this.partTable.Name = "partTable";
            this.partTable.RowHeadersWidth = 82;
            this.partTable.RowTemplate.Height = 33;
            this.partTable.Size = new System.Drawing.Size(456, 236);
            this.partTable.TabIndex = 1;
            // 
            // SearchButtonProduct
            // 
            this.SearchButtonProduct.Location = new System.Drawing.Point(750, 46);
            this.SearchButtonProduct.Margin = new System.Windows.Forms.Padding(2);
            this.SearchButtonProduct.Name = "SearchButtonProduct";
            this.SearchButtonProduct.Size = new System.Drawing.Size(60, 25);
            this.SearchButtonProduct.TabIndex = 3;
            this.SearchButtonProduct.Text = "Search";
            this.SearchButtonProduct.UseVisualStyleBackColor = true;
            this.SearchButtonProduct.Click += new System.EventHandler(this.SearchButtonProduct_Click);
            // 
            // productTable
            // 
            this.productTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productTable.Location = new System.Drawing.Point(507, 75);
            this.productTable.Margin = new System.Windows.Forms.Padding(2);
            this.productTable.Name = "productTable";
            this.productTable.RowHeadersWidth = 82;
            this.productTable.RowTemplate.Height = 33;
            this.productTable.Size = new System.Drawing.Size(463, 236);
            this.productTable.TabIndex = 4;
            // 
            // AddPart
            // 
            this.AddPart.Location = new System.Drawing.Point(294, 326);
            this.AddPart.Margin = new System.Windows.Forms.Padding(2);
            this.AddPart.Name = "AddPart";
            this.AddPart.Size = new System.Drawing.Size(37, 25);
            this.AddPart.TabIndex = 5;
            this.AddPart.Text = "AddPart";
            this.AddPart.UseVisualStyleBackColor = true;
            this.AddPart.Click += new System.EventHandler(this.AddPart_Click);
            // 
            // AddProduct
            // 
            this.AddProduct.Location = new System.Drawing.Point(785, 326);
            this.AddProduct.Margin = new System.Windows.Forms.Padding(2);
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.Size = new System.Drawing.Size(40, 25);
            this.AddProduct.TabIndex = 6;
            this.AddProduct.Text = "AddProduct";
            this.AddProduct.UseVisualStyleBackColor = true;
            this.AddProduct.Click += new System.EventHandler(this.AddProduct_Click);
            // 
            // ModifyPart
            // 
            this.ModifyPart.Location = new System.Drawing.Point(356, 326);
            this.ModifyPart.Margin = new System.Windows.Forms.Padding(2);
            this.ModifyPart.Name = "ModifyPart";
            this.ModifyPart.Size = new System.Drawing.Size(49, 25);
            this.ModifyPart.TabIndex = 7;
            this.ModifyPart.Text = "ModifyPart";
            this.ModifyPart.UseVisualStyleBackColor = true;
            this.ModifyPart.Click += new System.EventHandler(this.ModifyPart_Click);
            // 
            // ModifyProduct
            // 
            this.ModifyProduct.Location = new System.Drawing.Point(854, 326);
            this.ModifyProduct.Margin = new System.Windows.Forms.Padding(2);
            this.ModifyProduct.Name = "ModifyProduct";
            this.ModifyProduct.Size = new System.Drawing.Size(52, 25);
            this.ModifyProduct.TabIndex = 8;
            this.ModifyProduct.Text = "ModifyProduct";
            this.ModifyProduct.UseVisualStyleBackColor = true;
            this.ModifyProduct.Click += new System.EventHandler(this.ModifyProduct_Click);
            // 
            // DeletePart
            // 
            this.DeletePart.Location = new System.Drawing.Point(421, 326);
            this.DeletePart.Margin = new System.Windows.Forms.Padding(2);
            this.DeletePart.Name = "DeletePart";
            this.DeletePart.Size = new System.Drawing.Size(52, 25);
            this.DeletePart.TabIndex = 9;
            this.DeletePart.Text = "DeletePart";
            this.DeletePart.UseVisualStyleBackColor = true;
            this.DeletePart.Click += new System.EventHandler(this.DeletePart_Click);
            // 
            // DeleteProduct
            // 
            this.DeleteProduct.Location = new System.Drawing.Point(922, 326);
            this.DeleteProduct.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteProduct.Name = "DeleteProduct";
            this.DeleteProduct.Size = new System.Drawing.Size(50, 25);
            this.DeleteProduct.TabIndex = 10;
            this.DeleteProduct.Text = "DeleteProduct";
            this.DeleteProduct.UseVisualStyleBackColor = true;
            this.DeleteProduct.Click += new System.EventHandler(this.DeleteProduct_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(934, 405);
            this.Exit.Margin = new System.Windows.Forms.Padding(2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(56, 25);
            this.Exit.TabIndex = 11;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // PartLabel
            // 
            this.PartLabel.AutoSize = true;
            this.PartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartLabel.Location = new System.Drawing.Point(23, 51);
            this.PartLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PartLabel.Name = "PartLabel";
            this.PartLabel.Size = new System.Drawing.Size(51, 24);
            this.PartLabel.TabIndex = 12;
            this.PartLabel.Text = "Parts";
            // 
            // ProductLabel
            // 
            this.ProductLabel.AutoSize = true;
            this.ProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductLabel.Location = new System.Drawing.Point(509, 51);
            this.ProductLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductLabel.Name = "ProductLabel";
            this.ProductLabel.Size = new System.Drawing.Size(84, 24);
            this.ProductLabel.TabIndex = 13;
            this.ProductLabel.Text = "Products";
            // 
            // TextBoxPart
            // 
            this.TextBoxPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPart.Location = new System.Drawing.Point(326, 46);
            this.TextBoxPart.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxPart.Name = "TextBoxPart";
            this.TextBoxPart.Size = new System.Drawing.Size(147, 26);
            this.TextBoxPart.TabIndex = 14;
            // 
            // TextBoxProduct
            // 
            this.TextBoxProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxProduct.Location = new System.Drawing.Point(825, 46);
            this.TextBoxProduct.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxProduct.Name = "TextBoxProduct";
            this.TextBoxProduct.Size = new System.Drawing.Size(147, 26);
            this.TextBoxProduct.TabIndex = 15;
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.Location = new System.Drawing.Point(13, 13);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(220, 20);
            this.LabelTitle.TabIndex = 16;
            this.LabelTitle.Text = "Inventory Managment System";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 437);
            this.Controls.Add(this.LabelTitle);
            this.Controls.Add(this.TextBoxProduct);
            this.Controls.Add(this.TextBoxPart);
            this.Controls.Add(this.ProductLabel);
            this.Controls.Add(this.PartLabel);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.DeleteProduct);
            this.Controls.Add(this.DeletePart);
            this.Controls.Add(this.ModifyProduct);
            this.Controls.Add(this.ModifyPart);
            this.Controls.Add(this.AddProduct);
            this.Controls.Add(this.AddPart);
            this.Controls.Add(this.productTable);
            this.Controls.Add(this.SearchButtonProduct);
            this.Controls.Add(this.partTable);
            this.Controls.Add(this.SearchButtonPart);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Screen";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.partTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchButtonPart;
        private System.Windows.Forms.Button SearchButtonProduct;
        private System.Windows.Forms.Button AddPart;
        private System.Windows.Forms.Button AddProduct;
        private System.Windows.Forms.Button ModifyPart;
        private System.Windows.Forms.Button ModifyProduct;
        private System.Windows.Forms.Button DeletePart;
        private System.Windows.Forms.Button DeleteProduct;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label PartLabel;
        private System.Windows.Forms.Label ProductLabel;
        private System.Windows.Forms.TextBox TextBoxPart;
        private System.Windows.Forms.TextBox TextBoxProduct;
        private System.Windows.Forms.Label LabelTitle;
        public System.Windows.Forms.DataGridView partTable;
        public System.Windows.Forms.DataGridView productTable;
    }
}

