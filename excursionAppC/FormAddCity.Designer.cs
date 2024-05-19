namespace excursionAppC
{
    partial class FormAddCity
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
            buttonAddCity = new Button();
            label1 = new Label();
            nameTextBox = new TextBox();
            descriptionTextBox = new TextBox();
            imageURLTextBox = new TextBox();
            buttonClose = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // buttonAddCity
            // 
            buttonAddCity.BackColor = SystemColors.ActiveCaption;
            buttonAddCity.FlatStyle = FlatStyle.Popup;
            buttonAddCity.Location = new Point(146, 232);
            buttonAddCity.Name = "buttonAddCity";
            buttonAddCity.Size = new Size(75, 23);
            buttonAddCity.TabIndex = 0;
            buttonAddCity.Text = "Добавить";
            buttonAddCity.UseVisualStyleBackColor = false;
            buttonAddCity.Click += buttonAddCity_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(82, 9);
            label1.Name = "label1";
            label1.Size = new Size(203, 30);
            label1.TabIndex = 1;
            label1.Text = "Добавление города";
            // 
            // nameTextBox
            // 
            nameTextBox.BackColor = SystemColors.InactiveBorder;
            nameTextBox.Location = new Point(96, 83);
            nameTextBox.Multiline = true;
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(179, 29);
            nameTextBox.TabIndex = 2;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.BackColor = SystemColors.InactiveBorder;
            descriptionTextBox.Location = new Point(96, 130);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(179, 29);
            descriptionTextBox.TabIndex = 3;
            // 
            // imageURLTextBox
            // 
            imageURLTextBox.BackColor = SystemColors.InactiveBorder;
            imageURLTextBox.Location = new Point(96, 177);
            imageURLTextBox.Multiline = true;
            imageURLTextBox.Name = "imageURLTextBox";
            imageURLTextBox.Size = new Size(179, 29);
            imageURLTextBox.TabIndex = 4;
            // 
            // buttonClose
            // 
            buttonClose.BackColor = SystemColors.ActiveCaption;
            buttonClose.FlatStyle = FlatStyle.Popup;
            buttonClose.Location = new Point(12, 254);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(75, 23);
            buttonClose.TabIndex = 5;
            buttonClose.Text = "Закрыть";
            buttonClose.UseVisualStyleBackColor = false;
            buttonClose.Click += buttonClose_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(96, 65);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 6;
            label2.Text = "Название";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(96, 112);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 7;
            label3.Text = "Описание";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(96, 162);
            label4.Name = "label4";
            label4.Size = new Size(96, 15);
            label4.TabIndex = 8;
            label4.Text = "Ссылка на фото";
            // 
            // FormAddCity
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._1612769042_20_p_goluboi_fon_dlya_pisma_22;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(390, 289);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(buttonClose);
            Controls.Add(imageURLTextBox);
            Controls.Add(descriptionTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(label1);
            Controls.Add(buttonAddCity);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormAddCity";
            Text = "FormAddCity";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAddCity;
        private Label label1;
        private TextBox nameTextBox;
        private TextBox descriptionTextBox;
        private TextBox imageURLTextBox;
        private Button buttonClose;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}