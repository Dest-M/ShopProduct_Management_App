namespace WinFormsApp4
{
    partial class DeleteShop
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
            SuspendLayout();
            // 
            // DeleteProductCancelBtn
            // 
            DeleteProductCancelBtn.BackColor = Color.Firebrick;
            DeleteProductCancelBtn.ForeColor = Color.LightSalmon;
            DeleteProductCancelBtn.Location = new Point(83, 106);
            DeleteProductCancelBtn.Name = "DeleteProductCancelBtn";
            DeleteProductCancelBtn.Size = new Size(190, 34);
            DeleteProductCancelBtn.TabIndex = 25;
            DeleteProductCancelBtn.Text = "Cancel";
            DeleteProductCancelBtn.UseVisualStyleBackColor = false;
            DeleteProductCancelBtn.Click += DeleteProductCancelBtn_Click;
            // 
            // DeleteProductConfirmBtn
            // 
            DeleteProductConfirmBtn.BackColor = Color.DarkOliveGreen;
            DeleteProductConfirmBtn.ForeColor = Color.LightGreen;
            DeleteProductConfirmBtn.Location = new Point(83, 66);
            DeleteProductConfirmBtn.Name = "DeleteProductConfirmBtn";
            DeleteProductConfirmBtn.Size = new Size(190, 34);
            DeleteProductConfirmBtn.TabIndex = 24;
            DeleteProductConfirmBtn.Text = "Confirm";
            DeleteProductConfirmBtn.UseVisualStyleBackColor = false;
            DeleteProductConfirmBtn.Click += DeleteProductConfirmBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 30);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 23;
            label1.Text = "Shop Name:";
            // 
            // ShopComboBox
            // 
            ShopComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ShopComboBox.FormattingEnabled = true;
            ShopComboBox.Location = new Point(113, 27);
            ShopComboBox.Name = "ShopComboBox";
            ShopComboBox.Size = new Size(235, 23);
            ShopComboBox.TabIndex = 22;
            ShopComboBox.SelectedIndexChanged += ShopComboBox_SelectedIndexChanged;
            // 
            // DeleteShop
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(376, 156);
            Controls.Add(DeleteProductCancelBtn);
            Controls.Add(DeleteProductConfirmBtn);
            Controls.Add(label1);
            Controls.Add(ShopComboBox);
            Name = "DeleteShop";
            Text = "Delete Shop";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button DeleteProductCancelBtn;
        private Button DeleteProductConfirmBtn;
        private Label label1;
        private ComboBox ShopComboBox;
    }
}