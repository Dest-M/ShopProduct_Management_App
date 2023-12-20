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
            DeleteShopBtn = new Button();
            DeleteProductBtn = new Button();
            button1 = new Button();
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
            // DeleteShopBtn
            // 
            DeleteShopBtn.BackColor = Color.Firebrick;
            DeleteShopBtn.ForeColor = Color.LightSalmon;
            DeleteShopBtn.Location = new Point(26, 425);
            DeleteShopBtn.Name = "DeleteShopBtn";
            DeleteShopBtn.Size = new Size(166, 37);
            DeleteShopBtn.TabIndex = 26;
            DeleteShopBtn.Text = "Delete Shop";
            DeleteShopBtn.UseVisualStyleBackColor = false;
            DeleteShopBtn.Click += DeleteShopBtn_Click;
            // 
            // DeleteProductBtn
            // 
            DeleteProductBtn.BackColor = Color.Firebrick;
            DeleteProductBtn.ForeColor = Color.LightSalmon;
            DeleteProductBtn.Location = new Point(292, 425);
            DeleteProductBtn.Name = "DeleteProductBtn";
            DeleteProductBtn.Size = new Size(166, 37);
            DeleteProductBtn.TabIndex = 27;
            DeleteProductBtn.Text = "Delete Product";
            DeleteProductBtn.UseVisualStyleBackColor = false;
            DeleteProductBtn.Click += DeleteProductBtn_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ImageAlign = ContentAlignment.TopLeft;
            button1.Location = new Point(575, 12);
            button1.Name = "button1";
            button1.Size = new Size(54, 52);
            button1.TabIndex = 28;
            button1.Text = "Sign Out";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(641, 474);
            Controls.Add(button1);
            Controls.Add(DeleteProductBtn);
            Controls.Add(DeleteShopBtn);
            Controls.Add(AddShopBtn);
            Controls.Add(AddProductBtn);
            Controls.Add(ProductsListBox);
            Controls.Add(ShopsListBox);
            Name = "MainWindow";
            Text = "MainWindow";
            Load += MainWindow_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox ShopsListBox;
        private ListBox ProductsListBox;
        private Button AddProductBtn;
        private Button AddShopBtn;
        private Button DeleteShopBtn;
        private Button DeleteProductBtn;
        private Button button1;
    }
}