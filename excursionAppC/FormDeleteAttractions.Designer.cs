namespace excursionAppC
{
    partial class FormDeleteAttractions
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
            attractionListBox = new ListBox();
            deleteButton = new Button();
            buttonExit = new Button();
            SuspendLayout();
            // 
            // attractionListBox
            // 
            attractionListBox.BackColor = SystemColors.InactiveBorder;
            attractionListBox.FormattingEnabled = true;
            attractionListBox.ItemHeight = 15;
            attractionListBox.Location = new Point(69, 35);
            attractionListBox.Name = "attractionListBox";
            attractionListBox.Size = new Size(326, 139);
            attractionListBox.TabIndex = 0;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = SystemColors.ActiveCaption;
            deleteButton.FlatStyle = FlatStyle.Popup;
            deleteButton.Location = new Point(183, 192);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(75, 23);
            deleteButton.TabIndex = 1;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = SystemColors.ActiveCaption;
            buttonExit.FlatStyle = FlatStyle.Popup;
            buttonExit.Location = new Point(12, 227);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(75, 23);
            buttonExit.TabIndex = 2;
            buttonExit.Text = "Закрыть";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // FormDeleteAttractions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._1612769042_20_p_goluboi_fon_dlya_pisma_22;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(469, 261);
            Controls.Add(buttonExit);
            Controls.Add(deleteButton);
            Controls.Add(attractionListBox);
            Name = "FormDeleteAttractions";
            Text = "FormDeleteAttractions";
            ResumeLayout(false);
        }

        #endregion

        private ListBox attractionListBox;
        private Button deleteButton;
        private Button buttonExit;
    }
}