namespace excursionAppC
{
    partial class FormMain
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
            flowLayoutPanel = new FlowLayoutPanel();
            buttonAllCity = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.AutoScroll = true;
            flowLayoutPanel.BackColor = Color.Transparent;
            flowLayoutPanel.Location = new Point(12, 69);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(760, 369);
            flowLayoutPanel.TabIndex = 0;
            // 
            // buttonAllCity
            // 
            buttonAllCity.BackColor = SystemColors.ActiveCaption;
            buttonAllCity.FlatStyle = FlatStyle.Popup;
            buttonAllCity.Location = new Point(12, 12);
            buttonAllCity.Name = "buttonAllCity";
            buttonAllCity.Size = new Size(148, 32);
            buttonAllCity.TabIndex = 1;
            buttonAllCity.Text = "Список всех городов";
            buttonAllCity.UseVisualStyleBackColor = false;
            buttonAllCity.Click += button1_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(166, 12);
            button1.Name = "button1";
            button1.Size = new Size(279, 32);
            button1.TabIndex = 2;
            button1.Text = "Список всех достопримечательностей";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._1612769042_20_p_goluboi_fon_dlya_pisma_22;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(buttonAllCity);
            Controls.Add(flowLayoutPanel);
            Name = "FormMain";
            Text = "FormMain";
            Load += FormMain_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel;
        private Button buttonAllCity;
        private Button button1;
    }
}