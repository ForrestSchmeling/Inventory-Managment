namespace inventory_System_Forrest_Schmeling
{
    partial class ModifyProduct
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
            this.DataGridViewPart = new System.Windows.Forms.DataGridView();
            this.DataGridViewProduct = new System.Windows.Forms.DataGridView();
            this.Add = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.LabelPart = new System.Windows.Forms.Label();
            this.LabelProduct = new System.Windows.Forms.Label();
            this.ModifyProductLabel = new System.Windows.Forms.Label();
            this.LabelID = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelInventory = new System.Windows.Forms.Label();
            this.LabelMax = new System.Windows.Forms.Label();
            this.LabelMin = new System.Windows.Forms.Label();
            this.LabelPrice = new System.Windows.Forms.Label();
            this.TextBoxID = new System.Windows.Forms.TextBox();
            this.ModTextBoxName = new System.Windows.Forms.TextBox();
            this.TextBoxInventory = new System.Windows.Forms.TextBox();
            this.TextBoxPrice = new System.Windows.Forms.TextBox();
            this.TextBoxMax = new System.Windows.Forms.TextBox();
            this.TextBoxMin = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewPart
            // 
            this.DataGridViewPart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewPart.Location = new System.Drawing.Point(255, 45);
            this.DataGridViewPart.Margin = new System.Windows.Forms.Padding(2);
            this.DataGridViewPart.Name = "DataGridViewPart";
            this.DataGridViewPart.RowHeadersWidth = 82;
            this.DataGridViewPart.RowTemplate.Height = 33;
            this.DataGridViewPart.Size = new System.Drawing.Size(576, 170);
            this.DataGridViewPart.TabIndex = 0;
            // 
            // DataGridViewProduct
            // 
            this.DataGridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewProduct.Location = new System.Drawing.Point(255, 270);
            this.DataGridViewProduct.Margin = new System.Windows.Forms.Padding(2);
            this.DataGridViewProduct.Name = "DataGridViewProduct";
            this.DataGridViewProduct.RowHeadersWidth = 82;
            this.DataGridViewProduct.RowTemplate.Height = 33;
            this.DataGridViewProduct.Size = new System.Drawing.Size(576, 180);
            this.DataGridViewProduct.TabIndex = 1;
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(782, 219);
            this.Add.Margin = new System.Windows.Forms.Padding(2);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(45, 24);
            this.Add.TabIndex = 2;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.Location = new System.Drawing.Point(701, 503);
            this.Save.Margin = new System.Windows.Forms.Padding(2);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(61, 35);
            this.Save.TabIndex = 3;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(782, 454);
            this.Delete.Margin = new System.Windows.Forms.Padding(2);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(62, 33);
            this.Delete.TabIndex = 4;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.Location = new System.Drawing.Point(782, 503);
            this.Cancel.Margin = new System.Windows.Forms.Padding(2);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(62, 34);
            this.Cancel.TabIndex = 5;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(531, 17);
            this.Search.Margin = new System.Windows.Forms.Padding(2);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(60, 20);
            this.Search.TabIndex = 6;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxSearch.Location = new System.Drawing.Point(627, 17);
            this.TextBoxSearch.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(112, 23);
            this.TextBoxSearch.TabIndex = 7;
            // 
            // LabelPart
            // 
            this.LabelPart.AutoSize = true;
            this.LabelPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPart.Location = new System.Drawing.Point(267, 20);
            this.LabelPart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelPart.Name = "LabelPart";
            this.LabelPart.Size = new System.Drawing.Size(124, 18);
            this.LabelPart.TabIndex = 8;
            this.LabelPart.Text = "All Canidate Parts";
            // 
            // LabelProduct
            // 
            this.LabelProduct.AutoSize = true;
            this.LabelProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelProduct.Location = new System.Drawing.Point(252, 244);
            this.LabelProduct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelProduct.Name = "LabelProduct";
            this.LabelProduct.Size = new System.Drawing.Size(237, 18);
            this.LabelProduct.TabIndex = 9;
            this.LabelProduct.Text = "Parts Associated With this Product";
            // 
            // ModifyProductLabel
            // 
            this.ModifyProductLabel.AutoSize = true;
            this.ModifyProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyProductLabel.Location = new System.Drawing.Point(6, 20);
            this.ModifyProductLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ModifyProductLabel.Name = "ModifyProductLabel";
            this.ModifyProductLabel.Size = new System.Drawing.Size(114, 20);
            this.ModifyProductLabel.TabIndex = 10;
            this.ModifyProductLabel.Text = "Modify Product";
            // 
            // LabelID
            // 
            this.LabelID.AutoSize = true;
            this.LabelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelID.Location = new System.Drawing.Point(11, 60);
            this.LabelID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelID.Name = "LabelID";
            this.LabelID.Size = new System.Drawing.Size(22, 18);
            this.LabelID.TabIndex = 11;
            this.LabelID.Text = "ID";
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelName.Location = new System.Drawing.Point(7, 94);
            this.LabelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(48, 18);
            this.LabelName.TabIndex = 12;
            this.LabelName.Text = "Name";
            // 
            // LabelInventory
            // 
            this.LabelInventory.AutoSize = true;
            this.LabelInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelInventory.Location = new System.Drawing.Point(0, 143);
            this.LabelInventory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelInventory.Name = "LabelInventory";
            this.LabelInventory.Size = new System.Drawing.Size(67, 18);
            this.LabelInventory.TabIndex = 13;
            this.LabelInventory.Text = "Inventory";
            // 
            // LabelMax
            // 
            this.LabelMax.AutoSize = true;
            this.LabelMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMax.Location = new System.Drawing.Point(6, 269);
            this.LabelMax.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelMax.Name = "LabelMax";
            this.LabelMax.Size = new System.Drawing.Size(36, 18);
            this.LabelMax.TabIndex = 14;
            this.LabelMax.Text = "Max";
            // 
            // LabelMin
            // 
            this.LabelMin.AutoSize = true;
            this.LabelMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMin.Location = new System.Drawing.Point(126, 269);
            this.LabelMin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelMin.Name = "LabelMin";
            this.LabelMin.Size = new System.Drawing.Size(32, 18);
            this.LabelMin.TabIndex = 15;
            this.LabelMin.Text = "Min";
            // 
            // LabelPrice
            // 
            this.LabelPrice.AutoSize = true;
            this.LabelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPrice.Location = new System.Drawing.Point(-4, 194);
            this.LabelPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelPrice.Name = "LabelPrice";
            this.LabelPrice.Size = new System.Drawing.Size(78, 18);
            this.LabelPrice.TabIndex = 16;
            this.LabelPrice.Text = "Price/Cost";
            // 
            // TextBoxID
            // 
            this.TextBoxID.Location = new System.Drawing.Point(83, 60);
            this.TextBoxID.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxID.Name = "TextBoxID";
            this.TextBoxID.ReadOnly = true;
            this.TextBoxID.Size = new System.Drawing.Size(134, 20);
            this.TextBoxID.TabIndex = 17;
            this.TextBoxID.TextChanged += new System.EventHandler(this.TextBoxID_TextChanged);
            // 
            // ModTextBoxName
            // 
            this.ModTextBoxName.Location = new System.Drawing.Point(83, 94);
            this.ModTextBoxName.Margin = new System.Windows.Forms.Padding(2);
            this.ModTextBoxName.Name = "ModTextBoxName";
            this.ModTextBoxName.Size = new System.Drawing.Size(134, 20);
            this.ModTextBoxName.TabIndex = 18;
            // 
            // TextBoxInventory
            // 
            this.TextBoxInventory.Location = new System.Drawing.Point(83, 145);
            this.TextBoxInventory.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxInventory.Name = "TextBoxInventory";
            this.TextBoxInventory.Size = new System.Drawing.Size(134, 20);
            this.TextBoxInventory.TabIndex = 19;
            // 
            // TextBoxPrice
            // 
            this.TextBoxPrice.Location = new System.Drawing.Point(83, 195);
            this.TextBoxPrice.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxPrice.Name = "TextBoxPrice";
            this.TextBoxPrice.Size = new System.Drawing.Size(134, 20);
            this.TextBoxPrice.TabIndex = 20;
            // 
            // TextBoxMax
            // 
            this.TextBoxMax.Location = new System.Drawing.Point(49, 270);
            this.TextBoxMax.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxMax.Name = "TextBoxMax";
            this.TextBoxMax.Size = new System.Drawing.Size(54, 20);
            this.TextBoxMax.TabIndex = 21;
            // 
            // TextBoxMin
            // 
            this.TextBoxMin.Location = new System.Drawing.Point(173, 270);
            this.TextBoxMin.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxMin.Name = "TextBoxMin";
            this.TextBoxMin.Size = new System.Drawing.Size(54, 20);
            this.TextBoxMin.TabIndex = 22;
            // 
            // ModifyProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 548);
            this.Controls.Add(this.TextBoxMin);
            this.Controls.Add(this.TextBoxMax);
            this.Controls.Add(this.TextBoxPrice);
            this.Controls.Add(this.TextBoxInventory);
            this.Controls.Add(this.ModTextBoxName);
            this.Controls.Add(this.TextBoxID);
            this.Controls.Add(this.LabelPrice);
            this.Controls.Add(this.LabelMin);
            this.Controls.Add(this.LabelMax);
            this.Controls.Add(this.LabelInventory);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.LabelID);
            this.Controls.Add(this.ModifyProductLabel);
            this.Controls.Add(this.LabelProduct);
            this.Controls.Add(this.LabelPart);
            this.Controls.Add(this.TextBoxSearch);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.DataGridViewProduct);
            this.Controls.Add(this.DataGridViewPart);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ModifyProduct";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.ModifyProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewPart;
        private System.Windows.Forms.DataGridView DataGridViewProduct;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox TextBoxSearch;
        private System.Windows.Forms.Label LabelPart;
        private System.Windows.Forms.Label LabelProduct;
        private System.Windows.Forms.Label ModifyProductLabel;
        private System.Windows.Forms.Label LabelID;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelInventory;
        private System.Windows.Forms.Label LabelMax;
        private System.Windows.Forms.Label LabelMin;
        private System.Windows.Forms.Label LabelPrice;
        private System.Windows.Forms.TextBox TextBoxID;
        private System.Windows.Forms.TextBox ModTextBoxName;
        private System.Windows.Forms.TextBox TextBoxInventory;
        private System.Windows.Forms.TextBox TextBoxPrice;
        private System.Windows.Forms.TextBox TextBoxMax;
        private System.Windows.Forms.TextBox TextBoxMin;
    }
}