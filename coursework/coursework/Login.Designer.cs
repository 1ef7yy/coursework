namespace coursework
{
    partial class Login
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
            submitButton = new Button();
            phoneInput = new TextBox();
            addressInput = new TextBox();
            consentBox = new CheckBox();
            usernameInput = new TextBox();
            loginLabel = new Label();
            SuspendLayout();
            // 
            // submitButton
            // 
            submitButton.Location = new Point(818, 691);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(283, 66);
            submitButton.TabIndex = 0;
            submitButton.Text = "Войти";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // phoneInput
            // 
            phoneInput.Location = new Point(818, 392);
            phoneInput.Name = "phoneInput";
            phoneInput.PlaceholderText = " Номер телефона";
            phoneInput.Size = new Size(322, 39);
            phoneInput.TabIndex = 1;
            // 
            // addressInput
            // 
            addressInput.Location = new Point(672, 468);
            addressInput.Name = "addressInput";
            addressInput.PlaceholderText = " Адрес";
            addressInput.Size = new Size(579, 39);
            addressInput.TabIndex = 2;
            // 
            // consentBox
            // 
            consentBox.AutoSize = true;
            consentBox.Location = new Point(672, 556);
            consentBox.Name = "consentBox";
            consentBox.Size = new Size(574, 36);
            consentBox.TabIndex = 3;
            consentBox.Text = "Я согласен на обработку персональных данных";
            consentBox.UseVisualStyleBackColor = true;
            // 
            // usernameInput
            // 
            usernameInput.Location = new Point(818, 313);
            usernameInput.Name = "usernameInput";
            usernameInput.PlaceholderText = " Имя";
            usernameInput.Size = new Size(322, 39);
            usernameInput.TabIndex = 4;
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            loginLabel.ForeColor = SystemColors.ControlText;
            loginLabel.Location = new Point(870, 70);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(191, 86);
            loginLabel.TabIndex = 5;
            loginLabel.Text = "Вход";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1894, 1009);
            Controls.Add(loginLabel);
            Controls.Add(usernameInput);
            Controls.Add(consentBox);
            Controls.Add(addressInput);
            Controls.Add(phoneInput);
            Controls.Add(submitButton);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button submitButton;
        private TextBox phoneInput;
        private TextBox addressInput;
        private CheckBox consentBox;
        private TextBox usernameInput;
        private Label loginLabel;
    }
}