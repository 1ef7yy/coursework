namespace coursework
{
    partial class Корзина
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
            pictureBox1 = new PictureBox();
            cartSum = new Label();
            timeSelect = new ComboBox();
            label1 = new Label();
            orderBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.trans_logo_black_resized;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(236, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // cartSum
            // 
            cartSum.AutoSize = true;
            cartSum.Location = new Point(566, 197);
            cartSum.Name = "cartSum";
            cartSum.Size = new Size(0, 32);
            cartSum.TabIndex = 2;
            // 
            // timeSelect
            // 
            timeSelect.FormattingEnabled = true;
            timeSelect.Items.AddRange(new object[] { "Через 30 минут", "Через час", "Через 3 часа", "Завтра" });
            timeSelect.Location = new Point(469, 388);
            timeSelect.Name = "timeSelect";
            timeSelect.Size = new Size(261, 40);
            timeSelect.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 388);
            label1.Name = "label1";
            label1.Size = new Size(310, 32);
            label1.TabIndex = 4;
            label1.Text = "Выберите время доставки:";
            // 
            // orderBtn
            // 
            orderBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            orderBtn.Location = new Point(469, 578);
            orderBtn.Name = "orderBtn";
            orderBtn.Size = new Size(261, 100);
            orderBtn.TabIndex = 5;
            orderBtn.Text = "Заказать";
            orderBtn.UseVisualStyleBackColor = true;
            orderBtn.Click += orderBtn_Click;
            // 
            // Корзина
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 854);
            Controls.Add(orderBtn);
            Controls.Add(label1);
            Controls.Add(timeSelect);
            Controls.Add(cartSum);
            Controls.Add(pictureBox1);
            Name = "Корзина";
            Text = "CartForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label cartSum;
        private ComboBox timeSelect;
        private Label label1;
        private Button orderBtn;
    }
}