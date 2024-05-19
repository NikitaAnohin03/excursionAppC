namespace excursionAppC
{
    partial class FormAdmin
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
            buttonAddAttractions = new Button();
            pictureBox1 = new PictureBox();
            labelCountUsers = new Label();
            buttonDeleteCity = new Button();
            buttonDeleteAAttractions = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonAddCity
            // 
            buttonAddCity.BackColor = SystemColors.ActiveCaption;
            buttonAddCity.FlatStyle = FlatStyle.Popup;
            buttonAddCity.Location = new Point(216, 323);
            buttonAddCity.Margin = new Padding(3, 4, 3, 4);
            buttonAddCity.Name = "buttonAddCity";
            buttonAddCity.Size = new Size(257, 31);
            buttonAddCity.TabIndex = 0;
            buttonAddCity.Text = "Добавить город";
            buttonAddCity.UseVisualStyleBackColor = false;
            buttonAddCity.Click += buttonAddCity_Click;
            // 
            // buttonAddAttractions
            // 
            buttonAddAttractions.BackColor = SystemColors.ActiveCaption;
            buttonAddAttractions.FlatStyle = FlatStyle.Popup;
            buttonAddAttractions.Location = new Point(216, 361);
            buttonAddAttractions.Margin = new Padding(3, 4, 3, 4);
            buttonAddAttractions.Name = "buttonAddAttractions";
            buttonAddAttractions.Size = new Size(258, 31);
            buttonAddAttractions.TabIndex = 1;
            buttonAddAttractions.Text = "Добавить достопримечательность";
            buttonAddAttractions.UseVisualStyleBackColor = false;
            buttonAddAttractions.Click += buttonAddAttractions_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.gas_kvas_com_p_znachok_puteshestviya_na_prozrachnom_fone_2__1_;
            pictureBox1.Location = new Point(195, -4);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(299, 287);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // labelCountUsers
            // 
            labelCountUsers.AutoSize = true;
            labelCountUsers.BackColor = Color.Transparent;
            labelCountUsers.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelCountUsers.Location = new Point(183, 287);
            labelCountUsers.Name = "labelCountUsers";
            labelCountUsers.Size = new Size(365, 28);
            labelCountUsers.TabIndex = 3;
            labelCountUsers.Text = "Пользователей зарегестрировано: 15";
            // 
            // buttonDeleteCity
            // 
            buttonDeleteCity.BackColor = SystemColors.ActiveCaption;
            buttonDeleteCity.FlatStyle = FlatStyle.Popup;
            buttonDeleteCity.Location = new Point(216, 400);
            buttonDeleteCity.Margin = new Padding(3, 4, 3, 4);
            buttonDeleteCity.Name = "buttonDeleteCity";
            buttonDeleteCity.Size = new Size(257, 31);
            buttonDeleteCity.TabIndex = 4;
            buttonDeleteCity.Text = "Удалить город";
            buttonDeleteCity.UseVisualStyleBackColor = false;
            buttonDeleteCity.Click += buttonDeleteCity_Click;
            // 
            // buttonDeleteAAttractions
            // 
            buttonDeleteAAttractions.BackColor = SystemColors.ActiveCaption;
            buttonDeleteAAttractions.FlatStyle = FlatStyle.Popup;
            buttonDeleteAAttractions.Location = new Point(216, 439);
            buttonDeleteAAttractions.Margin = new Padding(3, 4, 3, 4);
            buttonDeleteAAttractions.Name = "buttonDeleteAAttractions";
            buttonDeleteAAttractions.Size = new Size(257, 31);
            buttonDeleteAAttractions.TabIndex = 5;
            buttonDeleteAAttractions.Text = "Удалить достопримечательности";
            buttonDeleteAAttractions.UseVisualStyleBackColor = false;
            buttonDeleteAAttractions.Click += buttonDeleteAAttractions_Click;
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._1612769042_20_p_goluboi_fon_dlya_pisma_22;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(736, 573);
            Controls.Add(buttonDeleteAAttractions);
            Controls.Add(buttonDeleteCity);
            Controls.Add(labelCountUsers);
            Controls.Add(pictureBox1);
            Controls.Add(buttonAddAttractions);
            Controls.Add(buttonAddCity);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormAdmin";
            Text = "FormAdmin";
            Load += FormAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAddCity;
        private Button buttonAddAttractions;
        private PictureBox pictureBox1;
        private Label labelCountUsers;
        private Button buttonDeleteCity;
        private Button buttonDeleteAAttractions;
    }
}