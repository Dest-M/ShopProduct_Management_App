namespace WinFormsApp4
{
    partial class DeleteProduct
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
            DeleteProductCancelBtn = new Button();
            DeleteProductConfirmBtn = new Button();
            label1 = new Label();
            ShopComboBox = new ComboBox();
            ProductLbl = new Label();
            ProductComboBox = new ComboBox();
            SuspendLayout();
            // 
            // DeleteProductCancelBtn
            // 
            DeleteProductCancelBtn.BackColor = Color.Firebrick;
            DeleteProductCancelBtn.ForeColor = Color.LightSalmon;
            DeleteProductCancelBtn.Location = new Point(87, 152);
            DeleteProductCancelBtn.Name = "DeleteProductCancelBtn";
            DeleteProductCancelBtn.Size = new Size(190, 34);
            DeleteProductCancelBtn.TabIndex = 19;
            DeleteProductCancelBtn.Text = "Cancel";
            DeleteProductCancelBtn.UseVisualStyleBackColor = false;
            DeleteProductCancelBtn.Click += DeleteProductCancelBtn_Click_1;
            // 
            // DeleteProductConfirmBtn
            // 
            DeleteProductConfirmBtn.BackColor = Color.DarkOliveGreen;
            DeleteProductConfirmBtn.ForeColor = Color.LightGreen;
            DeleteProductConfirmBtn.Location = new Point(87, 112);
            DeleteProductConfirmBtn.Name = "DeleteProductConfirmBtn";
            DeleteProductConfirmBtn.Size = new Size(190, 34);
            DeleteProductConfirmBtn.TabIndex = 18;
            DeleteProductConfirmBtn.Text = "Confirm";
            DeleteProductConfirmBtn.UseVisualStyleBackColor = false;
            DeleteProductConfirmBtn.Click += DeleteProductConfirmBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 34);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 17;
            label1.Text = "Shop Name:";
            // 
            // ShopComboBox
            // 
            ShopComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ShopComboBox.FormattingEnabled = true;
            ShopComboBox.Location = new Point(114, 31);
            ShopComboBox.Name = "ShopComboBox";
            ShopComboBox.Size = new Size(235, 23);
            ShopComboBox.TabIndex = 16;
            ShopComboBox.SelectedIndexChanged += ShopComboBox_SelectedIndexChanged;
            // 
            // ProductLbl
            // 
            ProductLbl.AutoSize = true;
            ProductLbl.Location = new Point(21, 73);
            ProductLbl.Name = "ProductLbl";
            ProductLbl.Size = new Size(87, 15);
            ProductLbl.TabIndex = 15;
            ProductLbl.Text = "Product Name:";
            // 
            // ProductComboBox
            // 
            ProductComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ProductComboBox.FormattingEnabled = true;
            ProductComboBox.Location = new Point(114, 70);
            ProductComboBox.Name = "ProductComboBox";
            ProductComboBox.Size = new Size(235, 23);
            ProductComboBox.TabIndex = 20;
            // 
            // DeleteProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(370, 221);
            Controls.Add(ProductComboBox);
            Controls.Add(DeleteProductCancelBtn);
            Controls.Add(DeleteProductConfirmBtn);
            Controls.Add(label1);
            Controls.Add(ShopComboBox);
            Controls.Add(ProductLbl);
            Name = "DeleteProduct";
            Text = "Delete Product";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button DeleteProductCancelBtn;
        private Button DeleteProductConfirmBtn;
        private Label label1;
        private ComboBox ShopComboBox;
        private Label ProductLbl;
        private ComboBox ProductComboBox;
    }
}