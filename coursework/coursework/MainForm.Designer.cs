namespace coursework
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            pictureBox1 = new PictureBox();
            cartButton = new Button();
            picturePears = new PictureBox();
            pictureOreshki = new PictureBox();
            pictureEggs = new PictureBox();
            pictureWater = new PictureBox();
            pictureBeef = new PictureBox();
            beefSelect = new NumericUpDown();
            eggsSelect = new NumericUpDown();
            oreshkiSelect = new NumericUpDown();
            pearSelect = new NumericUpDown();
            waterSelect = new NumericUpDown();
            beefPrice = new Label();
            eggsPrice = new Label();
            oreshkiPrice = new Label();
            pearPrice = new Label();
            waterPrice = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picturePears).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureOreshki).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureEggs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureWater).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBeef).BeginInit();
            ((System.ComponentModel.ISupportInitialize)beefSelect).BeginInit();
            ((System.ComponentModel.ISupportInitialize)eggsSelect).BeginInit();
            ((System.ComponentModel.ISupportInitialize)oreshkiSelect).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pearSelect).BeginInit();
            ((System.ComponentModel.ISupportInitialize)waterSelect).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.trans_logo_black_resized;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(236, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // cartButton
            // 
            cartButton.BackgroundImage = Properties.Resources.shopping_cart_1_;
            cartButton.FlatAppearance.BorderSize = 0;
            cartButton.FlatStyle = FlatStyle.Flat;
            cartButton.Location = new Point(1931, 22);
            cartButton.Name = "cartButton";
            cartButton.Size = new Size(50, 50);
            cartButton.TabIndex = 1;
            cartButton.Text = "cartButton";
            cartButton.TextImageRelation = TextImageRelation.ImageAboveText;
            cartButton.UseVisualStyleBackColor = true;
            cartButton.Click += cartButton_Click;
            // 
            // picturePears
            // 
            picturePears.Image = Properties.Resources.pears;
            picturePears.Location = new Point(1182, 379);
            picturePears.Name = "picturePears";
            picturePears.Size = new Size(305, 199);
            picturePears.SizeMode = PictureBoxSizeMode.StretchImage;
            picturePears.TabIndex = 2;
            picturePears.TabStop = false;
            // 
            // pictureOreshki
            // 
            pictureOreshki.Image = Properties.Resources.oreshki;
            pictureOreshki.Location = new Point(871, 180);
            pictureOreshki.Name = "pictureOreshki";
            pictureOreshki.Size = new Size(305, 199);
            pictureOreshki.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureOreshki.TabIndex = 3;
            pictureOreshki.TabStop = false;
            // 
            // pictureEggs
            // 
            pictureEggs.Image = Properties.Resources.eggs;
            pictureEggs.InitialImage = Properties.Resources.eggs;
            pictureEggs.Location = new Point(560, 379);
            pictureEggs.Name = "pictureEggs";
            pictureEggs.Size = new Size(305, 199);
            pictureEggs.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureEggs.TabIndex = 4;
            pictureEggs.TabStop = false;
            // 
            // pictureWater
            // 
            pictureWater.Image = Properties.Resources.water;
            pictureWater.Location = new Point(1493, 180);
            pictureWater.Name = "pictureWater";
            pictureWater.Size = new Size(305, 199);
            pictureWater.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureWater.TabIndex = 5;
            pictureWater.TabStop = false;
            // 
            // pictureBeef
            // 
            pictureBeef.ErrorImage = Properties.Resources.beef;
            pictureBeef.Image = Properties.Resources.beef;
            pictureBeef.InitialImage = (Image)resources.GetObject("pictureBeef.InitialImage");
            pictureBeef.Location = new Point(249, 180);
            pictureBeef.Name = "pictureBeef";
            pictureBeef.Size = new Size(305, 199);
            pictureBeef.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBeef.TabIndex = 6;
            pictureBeef.TabStop = false;
            // 
            // beefSelect
            // 
            beefSelect.Location = new Point(345, 385);
            beefSelect.Name = "beefSelect";
            beefSelect.Size = new Size(83, 39);
            beefSelect.TabIndex = 7;
            // 
            // eggsSelect
            // 
            eggsSelect.Location = new Point(692, 584);
            eggsSelect.Name = "eggsSelect";
            eggsSelect.Size = new Size(83, 39);
            eggsSelect.TabIndex = 8;
            // 
            // oreshkiSelect
            // 
            oreshkiSelect.Location = new Point(997, 385);
            oreshkiSelect.Name = "oreshkiSelect";
            oreshkiSelect.Size = new Size(83, 39);
            oreshkiSelect.TabIndex = 9;
            // 
            // pearSelect
            // 
            pearSelect.Location = new Point(1310, 584);
            pearSelect.Name = "pearSelect";
            pearSelect.Size = new Size(83, 39);
            pearSelect.TabIndex = 10;
            // 
            // waterSelect
            // 
            waterSelect.Location = new Point(1617, 385);
            waterSelect.Name = "waterSelect";
            waterSelect.Size = new Size(83, 39);
            waterSelect.TabIndex = 11;
            // 
            // beefPrice
            // 
            beefPrice.AutoSize = true;
            beefPrice.Location = new Point(345, 445);
            beefPrice.Name = "beefPrice";
            beefPrice.Size = new Size(0, 32);
            beefPrice.TabIndex = 12;
            // 
            // eggsPrice
            // 
            eggsPrice.AutoSize = true;
            eggsPrice.Location = new Point(692, 653);
            eggsPrice.Name = "eggsPrice";
            eggsPrice.Size = new Size(0, 32);
            eggsPrice.TabIndex = 13;
            // 
            // oreshkiPrice
            // 
            oreshkiPrice.AutoSize = true;
            oreshkiPrice.Location = new Point(997, 445);
            oreshkiPrice.Name = "oreshkiPrice";
            oreshkiPrice.Size = new Size(0, 32);
            oreshkiPrice.TabIndex = 14;
            // 
            // pearPrice
            // 
            pearPrice.AutoSize = true;
            pearPrice.Location = new Point(1310, 653);
            pearPrice.Name = "pearPrice";
            pearPrice.Size = new Size(0, 32);
            pearPrice.TabIndex = 15;
            // 
            // waterPrice
            // 
            waterPrice.AutoSize = true;
            waterPrice.Location = new Point(1617, 445);
            waterPrice.Name = "waterPrice";
            waterPrice.Size = new Size(0, 32);
            waterPrice.TabIndex = 16;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(2018, 1170);
            Controls.Add(waterPrice);
            Controls.Add(pearPrice);
            Controls.Add(oreshkiPrice);
            Controls.Add(eggsPrice);
            Controls.Add(beefPrice);
            Controls.Add(waterSelect);
            Controls.Add(pearSelect);
            Controls.Add(oreshkiSelect);
            Controls.Add(eggsSelect);
            Controls.Add(beefSelect);
            Controls.Add(pictureBeef);
            Controls.Add(pictureWater);
            Controls.Add(pictureEggs);
            Controls.Add(pictureOreshki);
            Controls.Add(picturePears);
            Controls.Add(cartButton);
            Controls.Add(pictureBox1);
            Name = "MainForm";
            Text = "Каталог";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picturePears).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureOreshki).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureEggs).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureWater).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBeef).EndInit();
            ((System.ComponentModel.ISupportInitialize)beefSelect).EndInit();
            ((System.ComponentModel.ISupportInitialize)eggsSelect).EndInit();
            ((System.ComponentModel.ISupportInitialize)oreshkiSelect).EndInit();
            ((System.ComponentModel.ISupportInitialize)pearSelect).EndInit();
            ((System.ComponentModel.ISupportInitialize)waterSelect).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button cartButton;
        private PictureBox picturePears;
        private PictureBox pictureOreshki;
        private PictureBox pictureEggs;
        private PictureBox pictureWater;
        private PictureBox pictureBeef;
        private NumericUpDown beefSelect;
        private NumericUpDown eggsSelect;
        private NumericUpDown oreshkiSelect;
        private NumericUpDown pearSelect;
        private NumericUpDown waterSelect;
        private Label beefPrice;
        private Label eggsPrice;
        private Label oreshkiPrice;
        private Label pearPrice;
        private Label waterPrice;
    }
}