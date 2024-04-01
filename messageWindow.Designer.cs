namespace LOE_Overhaul
{
    partial class messageWindow
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
            mainPanel = new Panel();
            titleContent = new Label();
            titlePanel = new Panel();
            titleText = new Label();
            btnPanel = new Panel();
            btnOK = new Button();
            btnCancel = new Button();
            panel1 = new Panel();
            mainPanel.SuspendLayout();
            titlePanel.SuspendLayout();
            btnPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainPanel.Controls.Add(titleContent);
            mainPanel.Font = new Font("Bender", 14F, FontStyle.Bold);
            mainPanel.Location = new Point(12, 66);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(576, 199);
            mainPanel.TabIndex = 0;
            // 
            // titleContent
            // 
            titleContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            titleContent.Font = new Font("Bender", 16F);
            titleContent.Location = new Point(3, 3);
            titleContent.Name = "titleContent";
            titleContent.Size = new Size(570, 187);
            titleContent.TabIndex = 1;
            titleContent.Text = "Placeholder content";
            titleContent.MouseDown += titleContent_MouseDown;
            // 
            // titlePanel
            // 
            titlePanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            titlePanel.Controls.Add(titleText);
            titlePanel.Font = new Font("Bender", 14F);
            titlePanel.Location = new Point(12, 12);
            titlePanel.Margin = new Padding(5);
            titlePanel.Name = "titlePanel";
            titlePanel.Size = new Size(574, 48);
            titlePanel.TabIndex = 1;
            titlePanel.MouseDown += titlePanel_MouseDown;
            // 
            // titleText
            // 
            titleText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            titleText.Font = new Font("Bender", 11F);
            titleText.Location = new Point(3, 25);
            titleText.Name = "titleText";
            titleText.Size = new Size(568, 20);
            titleText.TabIndex = 0;
            titleText.Text = "Placeholder content";
            // 
            // btnPanel
            // 
            btnPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnPanel.Controls.Add(btnOK);
            btnPanel.Controls.Add(btnCancel);
            btnPanel.Font = new Font("Bender", 14F);
            btnPanel.Location = new Point(12, 275);
            btnPanel.Name = "btnPanel";
            btnPanel.Size = new Size(576, 66);
            btnPanel.TabIndex = 2;
            btnPanel.MouseDown += btnPanel_MouseDown;
            // 
            // btnOK
            // 
            btnOK.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnOK.Cursor = Cursors.Hand;
            btnOK.FlatAppearance.BorderColor = SystemColors.WindowFrame;
            btnOK.FlatAppearance.BorderSize = 2;
            btnOK.FlatStyle = FlatStyle.Flat;
            btnOK.Location = new Point(258, 11);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(150, 45);
            btnOK.TabIndex = 1;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderColor = SystemColors.WindowFrame;
            btnCancel.FlatAppearance.BorderSize = 2;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Location = new Point(423, 11);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(150, 45);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(0, 268);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 1);
            panel1.TabIndex = 3;
            // 
            // messageWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 26, 28);
            ClientSize = new Size(600, 353);
            Controls.Add(panel1);
            Controls.Add(btnPanel);
            Controls.Add(titlePanel);
            Controls.Add(mainPanel);
            Font = new Font("Bender", 11F, FontStyle.Bold);
            ForeColor = Color.LightGray;
            FormBorderStyle = FormBorderStyle.None;
            Name = "messageWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Load += messageWindow_Load;
            Paint += messageWindow_Paint;
            mainPanel.ResumeLayout(false);
            titlePanel.ResumeLayout(false);
            btnPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        public Panel mainPanel;
        public Panel titlePanel;
        public Panel btnPanel;
        public Label titleText;
        public Label titleContent;
        public Button btnCancel;
        public Button btnOK;
        private Panel panel1;
    }
}