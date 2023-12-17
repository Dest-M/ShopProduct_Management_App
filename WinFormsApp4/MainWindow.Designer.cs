namespace WinFormsApp4
{
    partial class MainWindow
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
            ShopsListBox = new ListBox();
            ProductsListBox = new ListBox();
            AddProductBtn = new Button();
            AddShopBtn = new Button();
            SuspendLayout();
            // 
            // ShopsListBox
            // 
            ShopsListBox.FormattingEnabled = true;
            ShopsListBox.ItemHeight = 15;
            ShopsListBox.Location = new Point(26, 12);
            ShopsListBox.Name = "ShopsListBox";
            ShopsListBox.Size = new Size(166, 364);
            ShopsListBox.TabIndex = 0;
            ShopsListBox.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // ProductsListBox
            // 
            ProductsListBox.FormattingEnabled = true;
            ProductsListBox.ItemHeight = 15;
            ProductsListBox.Location = new Point(292, 12);
            ProductsListBox.Name = "ProductsListBox";
            ProductsListBox.Size = new Size(166, 364);
            ProductsListBox.TabIndex = 1;
            ProductsListBox.SelectedIndexChanged += Products_SelectedIndexChanged;
            // 
            // AddProductBtn
            // 
            AddProductBtn.BackColor = Color.DarkOliveGreen;
            AddProductBtn.ForeColor = Color.LightGreen;
            AddProductBtn.Location = new Point(292, 382);
            AddProductBtn.Name = "AddProductBtn";
            AddProductBtn.Size = new Size(166, 40);
            AddProductBtn.TabIndex = 2;
            AddProductBtn.Text = "Add Product";
            AddProductBtn.UseVisualStyleBackColor = false;
            AddProductBtn.Click += AddProductBtn_Click;
            // 
            // AddShopBtn
            // 
            AddShopBtn.BackColor = Color.DarkOliveGreen;
            AddShopBtn.ForeColor = Color.LightGreen;
            AddShopBtn.Location = new Point(26, 382);
            AddShopBtn.Name = "AddShopBtn";
            AddShopBtn.Size = new Size(166, 40);
            AddShopBtn.TabIndex = 3;
            AddShopBtn.Text = "Add Shop";
            AddShopBtn.UseVisualStyleBackColor = false;
            AddShopBtn.Click += AddShopBtn_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(493, 474);
            Controls.Add(AddShopBtn);
            Controls.Add(AddProductBtn);
            Controls.Add(ProductsListBox);
            Controls.Add(ShopsListBox);
            Name = "MainWindow";
            Text = "MainWindow";
            ResumeLayout(false);
        }

        #endregion

        private ListBox ShopsListBox;
        private ListBox ProductsListBox;
        private Button AddProductBtn;
        private Button AddShopBtn;
    }
}