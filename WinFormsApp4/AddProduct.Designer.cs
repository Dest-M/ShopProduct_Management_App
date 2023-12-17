namespace WinFormsApp4
{
    partial class AddProduct
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
            ProductName = new TextBox();
            ProductLbl = new Label();
            ShopComboBox = new ComboBox();
            label1 = new Label();
            AddProductConfirmBtn = new Button();
            AddProductCancelBtn = new Button();
            SuspendLayout();
            // 
            // ProductName
            // 
            ProductName.Location = new Point(123, 86);
            ProductName.Name = "ProductName";
            ProductName.Size = new Size(235, 23);
            ProductName.TabIndex = 9;
            // 
            // ProductLbl
            // 
            ProductLbl.AutoSize = true;
            ProductLbl.Location = new Point(30, 89);
            ProductLbl.Name = "ProductLbl";
            ProductLbl.Size = new Size(87, 15);
            ProductLbl.TabIndex = 10;
            ProductLbl.Text = "Product Name:";
            // 
            // ShopComboBox
            // 
            ShopComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ShopComboBox.FormattingEnabled = true;
            ShopComboBox.Location = new Point(123, 47);
            ShopComboBox.Name = "ShopComboBox";
            ShopComboBox.Size = new Size(235, 23);
            ShopComboBox.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 50);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 12;
            label1.Text = "Shop Name:";
            // 
            // AddProductConfirmBtn
            // 
            AddProductConfirmBtn.BackColor = Color.DarkOliveGreen;
            AddProductConfirmBtn.ForeColor = Color.LightGreen;
            AddProductConfirmBtn.Location = new Point(96, 128);
            AddProductConfirmBtn.Name = "AddProductConfirmBtn";
            AddProductConfirmBtn.Size = new Size(190, 34);
            AddProductConfirmBtn.TabIndex = 13;
            AddProductConfirmBtn.Text = "Confirm";
            AddProductConfirmBtn.UseVisualStyleBackColor = false;
            AddProductConfirmBtn.Click += AddProductConfirmBtn_Click;
            // 
            // AddProductCancelBtn
            // 
            AddProductCancelBtn.BackColor = Color.Firebrick;
            AddProductCancelBtn.ForeColor = Color.LightSalmon;
            AddProductCancelBtn.Location = new Point(96, 168);
            AddProductCancelBtn.Name = "AddProductCancelBtn";
            AddProductCancelBtn.Size = new Size(190, 34);
            AddProductCancelBtn.TabIndex = 14;
            AddProductCancelBtn.Text = "Cancel";
            AddProductCancelBtn.UseVisualStyleBackColor = false;
            AddProductCancelBtn.Click += AddProductCancelBtn_Click;
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 266);
            Controls.Add(AddProductCancelBtn);
            Controls.Add(AddProductConfirmBtn);
            Controls.Add(label1);
            Controls.Add(ShopComboBox);
            Controls.Add(ProductLbl);
            Controls.Add(ProductName);
            Name = "AddProduct";
            Text = "Add Product";
            Load += AddProduct_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ProductName;
        private Label ProductLbl;
        private ComboBox ShopComboBox;
        private Label label1;
        private Button AddProductConfirmBtn;
        private Button AddProductCancelBtn;
    }
}