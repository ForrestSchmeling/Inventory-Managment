namespace inventory_System_Forrest_Schmeling
{
    partial class AddPart
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
            this.AddPartLabel = new System.Windows.Forms.Label();
            this.RadioInhouse = new System.Windows.Forms.RadioButton();
            this.RadioOutsourced = new System.Windows.Forms.RadioButton();
            this.Save = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.LabelID = new System.Windows.Forms.Label();
            this.LabelMin = new System.Windows.Forms.Label();
            this.LabelMax = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelInventory = new System.Windows.Forms.Label();
            this.LabelPrice = new System.Windows.Forms.Label();
            this.LabelCompanyID = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.TextBoxInventory = new System.Windows.Forms.TextBox();
            this.TextBoxPrice = new System.Windows.Forms.TextBox();
            this.TextBoxMin = new System.Windows.Forms.TextBox();
            this.TextBoxCompanyID = new System.Windows.Forms.TextBox();
            this.TextBoxMax = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddPartLabel
            // 
            this.AddPartLabel.AutoSize = true;
            this.AddPartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPartLabel.Location = new System.Drawing.Point(50, 7);
            this.AddPartLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AddPartLabel.Name = "AddPartLabel";
            this.AddPartLabel.Size = new System.Drawing.Size(64, 18);
            this.AddPartLabel.TabIndex = 0;
            this.AddPartLabel.Text = "Add Part";
            // 
            // RadioInhouse
            // 
            this.RadioInhouse.AutoSize = true;
            this.RadioInhouse.Location = new System.Drawing.Point(128, 7);
            this.RadioInhouse.Margin = new System.Windows.Forms.Padding(2);
            this.RadioInhouse.Name = "RadioInhouse";
            this.RadioInhouse.Size = new System.Drawing.Size(68, 17);
            this.RadioInhouse.TabIndex = 1;
            this.RadioInhouse.TabStop = true;
            this.RadioInhouse.Text = "In-House";
            this.RadioInhouse.UseVisualStyleBackColor = true;
            this.RadioInhouse.CheckedChanged += new System.EventHandler(this.RadioInhouse_CheckedChanged);
            // 
            // RadioOutsourced
            // 
            this.RadioOutsourced.AutoSize = true;
            this.RadioOutsourced.Location = new System.Drawing.Point(256, 6);
            this.RadioOutsourced.Margin = new System.Windows.Forms.Padding(2);
            this.RadioOutsourced.Name = "RadioOutsourced";
            this.RadioOutsourced.Size = new System.Drawing.Size(80, 17);
            this.RadioOutsourced.TabIndex = 2;
            this.RadioOutsourced.TabStop = true;
            this.RadioOutsourced.Text = "Outsourced";
            this.RadioOutsourced.UseVisualStyleBackColor = true;
            this.RadioOutsourced.CheckedChanged += new System.EventHandler(this.RadioOutsourced_CheckedChanged);
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.Location = new System.Drawing.Point(244, 324);
            this.Save.Margin = new System.Windows.Forms.Padding(2);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(53, 26);
            this.Save.TabIndex = 3;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.Location = new System.Drawing.Point(312, 324);
            this.Cancel.Margin = new System.Windows.Forms.Padding(2);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(56, 26);
            this.Cancel.TabIndex = 4;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // LabelID
            // 
            this.LabelID.AutoSize = true;
            this.LabelID.Location = new System.Drawing.Point(92, 62);
            this.LabelID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelID.Name = "LabelID";
            this.LabelID.Size = new System.Drawing.Size(18, 13);
            this.LabelID.TabIndex = 5;
            this.LabelID.Text = "ID";
            // 
            // LabelMin
            // 
            this.LabelMin.AutoSize = true;
            this.LabelMin.Location = new System.Drawing.Point(218, 230);
            this.LabelMin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelMin.Name = "LabelMin";
            this.LabelMin.Size = new System.Drawing.Size(24, 13);
            this.LabelMin.TabIndex = 6;
            this.LabelMin.Text = "Min";
            // 
            // LabelMax
            // 
            this.LabelMax.AutoSize = true;
            this.LabelMax.Location = new System.Drawing.Point(80, 230);
            this.LabelMax.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelMax.Name = "LabelMax";
            this.LabelMax.Size = new System.Drawing.Size(27, 13);
            this.LabelMax.TabIndex = 7;
            this.LabelMax.Text = "Max";
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(80, 99);
            this.LabelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(35, 13);
            this.LabelName.TabIndex = 8;
            this.LabelName.Text = "Name";
            // 
            // LabelInventory
            // 
            this.LabelInventory.AutoSize = true;
            this.LabelInventory.Location = new System.Drawing.Point(64, 135);
            this.LabelInventory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelInventory.Name = "LabelInventory";
            this.LabelInventory.Size = new System.Drawing.Size(51, 13);
            this.LabelInventory.TabIndex = 9;
            this.LabelInventory.Text = "Inventory";
            // 
            // LabelPrice
            // 
            this.LabelPrice.AutoSize = true;
            this.LabelPrice.Location = new System.Drawing.Point(59, 174);
            this.LabelPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelPrice.Name = "LabelPrice";
            this.LabelPrice.Size = new System.Drawing.Size(57, 13);
            this.LabelPrice.TabIndex = 10;
            this.LabelPrice.Text = "Price/Cost";
            // 
            // LabelCompanyID
            // 
            this.LabelCompanyID.AutoSize = true;
            this.LabelCompanyID.Location = new System.Drawing.Point(59, 281);
            this.LabelCompanyID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelCompanyID.Name = "LabelCompanyID";
            this.LabelCompanyID.Size = new System.Drawing.Size(62, 13);
            this.LabelCompanyID.TabIndex = 11;
            this.LabelCompanyID.Text = "Machine ID";
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.Location = new System.Drawing.Point(128, 62);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(131, 23);
            this.textBoxID.TabIndex = 12;
            // 
            // TextBoxName
            // 
            this.TextBoxName.BackColor = System.Drawing.Color.White;
            this.TextBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxName.Location = new System.Drawing.Point(128, 99);
            this.TextBoxName.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(131, 23);
            this.TextBoxName.TabIndex = 13;
            // 
            // TextBoxInventory
            // 
            this.TextBoxInventory.BackColor = System.Drawing.Color.White;
            this.TextBoxInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxInventory.Location = new System.Drawing.Point(128, 131);
            this.TextBoxInventory.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxInventory.Name = "TextBoxInventory";
            this.TextBoxInventory.Size = new System.Drawing.Size(131, 23);
            this.TextBoxInventory.TabIndex = 14;
            // 
            // TextBoxPrice
            // 
            this.TextBoxPrice.BackColor = System.Drawing.Color.White;
            this.TextBoxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPrice.Location = new System.Drawing.Point(128, 174);
            this.TextBoxPrice.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxPrice.Name = "TextBoxPrice";
            this.TextBoxPrice.Size = new System.Drawing.Size(131, 23);
            this.TextBoxPrice.TabIndex = 15;
            // 
            // TextBoxMin
            // 
            this.TextBoxMin.BackColor = System.Drawing.Color.White;
            this.TextBoxMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxMin.Location = new System.Drawing.Point(244, 225);
            this.TextBoxMin.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxMin.Name = "TextBoxMin";
            this.TextBoxMin.Size = new System.Drawing.Size(46, 23);
            this.TextBoxMin.TabIndex = 17;
            // 
            // TextBoxCompanyID
            // 
            this.TextBoxCompanyID.BackColor = System.Drawing.Color.White;
            this.TextBoxCompanyID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxCompanyID.Location = new System.Drawing.Point(138, 276);
            this.TextBoxCompanyID.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxCompanyID.Name = "TextBoxCompanyID";
            this.TextBoxCompanyID.Size = new System.Drawing.Size(131, 23);
            this.TextBoxCompanyID.TabIndex = 18;
            // 
            // TextBoxMax
            // 
            this.TextBoxMax.BackColor = System.Drawing.Color.White;
            this.TextBoxMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxMax.Location = new System.Drawing.Point(121, 225);
            this.TextBoxMax.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxMax.Name = "TextBoxMax";
            this.TextBoxMax.Size = new System.Drawing.Size(46, 23);
            this.TextBoxMax.TabIndex = 19;
            // 
            // AddPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 375);
            this.Controls.Add(this.TextBoxMax);
            this.Controls.Add(this.TextBoxCompanyID);
            this.Controls.Add(this.TextBoxMin);
            this.Controls.Add(this.TextBoxPrice);
            this.Controls.Add(this.TextBoxInventory);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.LabelCompanyID);
            this.Controls.Add(this.LabelPrice);
            this.Controls.Add(this.LabelInventory);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.LabelMax);
            this.Controls.Add(this.LabelMin);
            this.Controls.Add(this.LabelID);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.RadioOutsourced);
            this.Controls.Add(this.RadioInhouse);
            this.Controls.Add(this.AddPartLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddPart";
            this.Text = "Part";
            this.Load += new System.EventHandler(this.AddPart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddPartLabel;
        private System.Windows.Forms.RadioButton RadioInhouse;
        private System.Windows.Forms.RadioButton RadioOutsourced;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label LabelID;
        private System.Windows.Forms.Label LabelMin;
        private System.Windows.Forms.Label LabelMax;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelInventory;
        private System.Windows.Forms.Label LabelPrice;
        private System.Windows.Forms.Label LabelCompanyID;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.TextBox TextBoxInventory;
        private System.Windows.Forms.TextBox TextBoxPrice;
        private System.Windows.Forms.TextBox TextBoxMin;
        private System.Windows.Forms.TextBox TextBoxCompanyID;
        private System.Windows.Forms.TextBox TextBoxMax;
    }
}