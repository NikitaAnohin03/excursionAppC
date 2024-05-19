namespace excursionAppC
{
    partial class FormAddAttractions
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
            nameTextBox = new TextBox();
            descriptionTextBox = new TextBox();
            imageURLTextBox = new TextBox();
            addButton = new Button();
            buttonExit = new Button();
            label1 = new Label();
            cityComboBox = new ComboBox();
            locationTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // nameTextBox
            // 
            nameTextBox.BackColor = SystemColors.InactiveBorder;
            nameTextBox.Font = new Font("Segoe UI", 12F);
            nameTextBox.Location = new Point(101, 104);
            nameTextBox.Multiline = true;
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(171, 27);
            nameTextBox.TabIndex = 0;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.BackColor = SystemColors.InactiveBorder;
            descriptionTextBox.Font = new Font("Segoe UI", 12F);
            descriptionTextBox.Location = new Point(101, 150);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(171, 27);
            descriptionTextBox.TabIndex = 1;
            // 
            // imageURLTextBox
            // 
            imageURLTextBox.BackColor = SystemColors.InactiveBorder;
            imageURLTextBox.Font = new Font("Segoe UI", 12F);
            imageURLTextBox.Location = new Point(101, 198);
            imageURLTextBox.Multiline = true;
            imageURLTextBox.Name = "imageURLTextBox";
            imageURLTextBox.Size = new Size(171, 27);
            imageURLTextBox.TabIndex = 2;
            // 
            // addButton
            // 
            addButton.BackColor = SystemColors.ActiveCaption;
            addButton.FlatStyle = FlatStyle.Popup;
            addButton.Location = new Point(151, 285);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 3;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = SystemColors.ActiveCaption;
            buttonExit.FlatStyle = FlatStyle.Popup;
            buttonExit.Location = new Point(12, 305);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(75, 23);
            buttonExit.TabIndex = 4;
            buttonExit.Text = "Закрыть";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(37, 9);
            label1.Name = "label1";
            label1.Size = new Size(344, 25);
            label1.TabIndex = 5;
            label1.Text = "Добавление достопримечательности";
            // 
            // cityComboBox
            // 
            cityComboBox.FormattingEnabled = true;
            cityComboBox.Location = new Point(125, 60);
            cityComboBox.Name = "cityComboBox";
            cityComboBox.Size = new Size(121, 23);
            cityComboBox.TabIndex = 6;
            // 
            // locationTextBox
            // 
            locationTextBox.BackColor = SystemColors.InactiveBorder;
            locationTextBox.Font = new Font("Segoe UI", 12F);
            locationTextBox.Location = new Point(101, 246);
            locationTextBox.Multiline = true;
            locationTextBox.Name = "locationTextBox";
            locationTextBox.Size = new Size(171, 27);
            locationTextBox.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(125, 42);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 8;
            label2.Text = "Город";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(101, 86);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 9;
            label3.Text = "Название";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(101, 132);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 10;
            label4.Text = "Описание";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(101, 180);
            label5.Name = "label5";
            label5.Size = new Size(96, 15);
            label5.TabIndex = 11;
            label5.Text = "Ссылка на фото";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Location = new Point(101, 228);
            label6.Name = "label6";
            label6.Size = new Size(135, 15);
            label6.TabIndex = 12;
            label6.Text = "Ссылка на координаты";
            // 
            // FormAddAttractions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._1612769042_20_p_goluboi_fon_dlya_pisma_22;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(397, 340);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(locationTextBox);
            Controls.Add(cityComboBox);
            Controls.Add(label1);
            Controls.Add(buttonExit);
            Controls.Add(addButton);
            Controls.Add(imageURLTextBox);
            Controls.Add(descriptionTextBox);
            Controls.Add(nameTextBox);
            Name = "FormAddAttractions";
            Text = "FormAddAttractions";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameTextBox;
        private TextBox descriptionTextBox;
        private TextBox imageURLTextBox;
        private Button addButton;
        private Button buttonExit;
        private Label label1;
        private ComboBox cityComboBox;
        private TextBox locationTextBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}