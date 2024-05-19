namespace excursionAppC
{
    partial class FormDeleteCity
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
            buttonDelete = new Button();
            cityListBox = new ListBox();
            buttonExit = new Button();
            SuspendLayout();
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = SystemColors.ActiveCaption;
            buttonDelete.FlatStyle = FlatStyle.Popup;
            buttonDelete.Location = new Point(124, 156);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 23);
            buttonDelete.TabIndex = 0;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // cityListBox
            // 
            cityListBox.BackColor = SystemColors.InactiveBorder;
            cityListBox.FormattingEnabled = true;
            cityListBox.ItemHeight = 15;
            cityListBox.Location = new Point(67, 26);
            cityListBox.Name = "cityListBox";
            cityListBox.Size = new Size(206, 124);
            cityListBox.TabIndex = 1;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = SystemColors.ActiveCaption;
            buttonExit.FlatStyle = FlatStyle.Popup;
            buttonExit.Location = new Point(12, 173);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(75, 23);
            buttonExit.TabIndex = 2;
            buttonExit.Text = "Закрыть";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // FormDeleteCity
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._1612769042_20_p_goluboi_fon_dlya_pisma_22;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(365, 208);
            Controls.Add(buttonExit);
            Controls.Add(cityListBox);
            Controls.Add(buttonDelete);
            Name = "FormDeleteCity";
            Text = "FormDeleteCity";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonDelete;
        private ListBox cityListBox;
        private Button buttonExit;
    }
}