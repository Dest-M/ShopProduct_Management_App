namespace WinFormsApp4
{
    partial class AddShop
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
            ShopLbl = new Label();
            ShopName = new TextBox();
            AddShopConfirmBtn = new Button();
            AddShopCancelBtn = new Button();
            SuspendLayout();
            // 
            // ShopLbl
            // 
            ShopLbl.AutoSize = true;
            ShopLbl.Location = new Point(31, 31);
            ShopLbl.Name = "ShopLbl";
            ShopLbl.Size = new Size(72, 15);
            ShopLbl.TabIndex = 7;
            ShopLbl.Text = "Shop Name:";
            // 
            // ShopName
            // 
            ShopName.Location = new Point(109, 28);
            ShopName.Name = "ShopName";
            ShopName.Size = new Size(235, 23);
            ShopName.TabIndex = 8;
            // 
            // AddShopConfirmBtn
            // 
            AddShopConfirmBtn.BackColor = Color.DarkOliveGreen;
            AddShopConfirmBtn.ForeColor = Color.LightGreen;
            AddShopConfirmBtn.Location = new Point(125, 71);
            AddShopConfirmBtn.Name = "AddShopConfirmBtn";
            AddShopConfirmBtn.Size = new Size(190, 34);
            AddShopConfirmBtn.TabIndex = 9;
            AddShopConfirmBtn.Text = "Confirm";
            AddShopConfirmBtn.UseVisualStyleBackColor = false;
            AddShopConfirmBtn.Click += AddShopConfirmBtn_Click;
            // 
            // AddShopCancelBtn
            // 
            AddShopCancelBtn.BackColor = Color.Firebrick;
            AddShopCancelBtn.ForeColor = Color.LightSalmon;
            AddShopCancelBtn.Location = new Point(125, 111);
            AddShopCancelBtn.Name = "AddShopCancelBtn";
            AddShopCancelBtn.Size = new Size(190, 34);
            AddShopCancelBtn.TabIndex = 10;
            AddShopCancelBtn.Text = "Cancel";
            AddShopCancelBtn.UseVisualStyleBackColor = false;
            AddShopCancelBtn.Click += AddShopCancelBtn_Click;
            // 
            // AddShop
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 181);
            Controls.Add(AddShopCancelBtn);
            Controls.Add(AddShopConfirmBtn);
            Controls.Add(ShopName);
            Controls.Add(ShopLbl);
            Name = "AddShop";
            Text = "Add Shop";
            Load += AddShop_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ShopLbl;
        private TextBox ShopName;
        private Button AddShopConfirmBtn;
        private Button AddShopCancelBtn;
    }
}