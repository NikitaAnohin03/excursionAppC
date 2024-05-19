namespace excursionAppC
{
    partial class Form1
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
            button1 = new Button();
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            buttonReg = new Button();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(160, 480);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 0;
            button1.Text = "Войти";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // usernameTextBox
            // 
            usernameTextBox.BackColor = SystemColors.InactiveBorder;
            usernameTextBox.Font = new Font("Segoe UI", 12F);
            usernameTextBox.Location = new Point(111, 184);
            usernameTextBox.Margin = new Padding(3, 4, 3, 4);
            usernameTextBox.Multiline = true;
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(181, 40);
            usernameTextBox.TabIndex = 1;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BackColor = SystemColors.InactiveBorder;
            passwordTextBox.Font = new Font("Segoe UI", 12F);
            passwordTextBox.Location = new Point(111, 276);
            passwordTextBox.Margin = new Padding(3, 4, 3, 4);
            passwordTextBox.Multiline = true;
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(181, 40);
            passwordTextBox.TabIndex = 2;
            // 
            // buttonReg
            // 
            buttonReg.BackColor = SystemColors.ActiveCaption;
            buttonReg.FlatAppearance.BorderSize = 0;
            buttonReg.FlatStyle = FlatStyle.Popup;
            buttonReg.ForeColor = SystemColors.ControlText;
            buttonReg.Location = new Point(286, 16);
            buttonReg.Margin = new Padding(3, 4, 3, 4);
            buttonReg.Name = "buttonReg";
            buttonReg.Size = new Size(126, 31);
            buttonReg.TabIndex = 3;
            buttonReg.Text = "Регистрация";
            buttonReg.UseVisualStyleBackColor = false;
            buttonReg.Click += buttonReg_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(111, 160);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 4;
            label1.Text = "Логин";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(111, 252);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 5;
            label2.Text = "Пароль";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.solo_traveller_trave;
            pictureBox1.Location = new Point(56, 213);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(371, 360);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources._1612769042_20_p_goluboi_fon_dlya_pisma_22;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(425, 568);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonReg);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Button buttonReg;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
    }
}
