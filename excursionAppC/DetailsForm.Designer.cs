namespace excursionAppC
{
    partial class DetailsForm
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
            nameLabel = new Label();
            descriptionLabel = new Label();
            cityPictureBox = new PictureBox();
            AttractionButton = new Button();
            buttonHide = new Button();
            ((System.ComponentModel.ISupportInitialize)cityPictureBox).BeginInit();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.BackColor = Color.Transparent;
            nameLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            nameLabel.Location = new Point(345, 56);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(48, 20);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "label1";
            // 
            // descriptionLabel
            // 
            descriptionLabel.BackColor = Color.Transparent;
            descriptionLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            descriptionLabel.Location = new Point(345, 93);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(261, 112);
            descriptionLabel.TabIndex = 1;
            descriptionLabel.Text = "label1";
            // 
            // cityPictureBox
            // 
            cityPictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            cityPictureBox.Location = new Point(61, 56);
            cityPictureBox.Name = "cityPictureBox";
            cityPictureBox.Size = new Size(209, 175);
            cityPictureBox.TabIndex = 2;
            cityPictureBox.TabStop = false;
            // 
            // AttractionButton
            // 
            AttractionButton.BackColor = SystemColors.ActiveCaption;
            AttractionButton.FlatStyle = FlatStyle.Popup;
            AttractionButton.Location = new Point(533, 341);
            AttractionButton.Name = "AttractionButton";
            AttractionButton.Size = new Size(159, 23);
            AttractionButton.TabIndex = 3;
            AttractionButton.Text = "Достопримечательности";
            AttractionButton.UseVisualStyleBackColor = false;
            AttractionButton.Click += AttractionButton_Click;
            // 
            // buttonHide
            // 
            buttonHide.BackColor = SystemColors.ActiveCaption;
            buttonHide.FlatStyle = FlatStyle.Popup;
            buttonHide.Location = new Point(12, 341);
            buttonHide.Name = "buttonHide";
            buttonHide.Size = new Size(75, 23);
            buttonHide.TabIndex = 4;
            buttonHide.Text = "Назад";
            buttonHide.UseVisualStyleBackColor = false;
            buttonHide.Click += buttonHide_Click;
            // 
            // DetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._1612769042_20_p_goluboi_fon_dlya_pisma_22;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(721, 387);
            Controls.Add(buttonHide);
            Controls.Add(AttractionButton);
            Controls.Add(cityPictureBox);
            Controls.Add(descriptionLabel);
            Controls.Add(nameLabel);
            Name = "DetailsForm";
            Text = "DetailsForm";
            Load += DetailsForm_Load;
            ((System.ComponentModel.ISupportInitialize)cityPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private Label descriptionLabel;
        private PictureBox cityPictureBox;
        private Button AttractionButton;
        private Button buttonHide;
    }
}