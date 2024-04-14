namespace LOE_Overhaul
{
    partial class mainForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            mainList = new Panel();
            modOrder0 = new Label();
            readFAQ = new Label();
            joinLink = new Label();
            btnDown = new Button();
            btnUp = new Button();
            panel1 = new Panel();
            placeholder = new Label();
            modInfo = new ToolTip(components);
            mainList.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // mainList
            // 
            mainList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            mainList.AutoScroll = true;
            mainList.Controls.Add(modOrder0);
            mainList.Font = new Font("Bahnschrift Light", 12F);
            mainList.Location = new Point(0, 0);
            mainList.Margin = new Padding(4, 3, 4, 3);
            mainList.Name = "mainList";
            mainList.Size = new Size(575, 450);
            mainList.TabIndex = 1;
            mainList.DragDrop += mainList_DragDrop;
            // 
            // modOrder0
            // 
            modOrder0.AutoEllipsis = true;
            modOrder0.Cursor = Cursors.Hand;
            modOrder0.Font = new Font("Bahnschrift SemiBold", 12F);
            modOrder0.Location = new Point(1, 1);
            modOrder0.Name = "modOrder0";
            modOrder0.Padding = new Padding(10, 0, 0, 0);
            modOrder0.Size = new Size(573, 30);
            modOrder0.TabIndex = 0;
            modOrder0.Text = "placeholderItem";
            modOrder0.TextAlign = ContentAlignment.MiddleLeft;
            modOrder0.Visible = false;
            // 
            // readFAQ
            // 
            readFAQ.Cursor = Cursors.Hand;
            readFAQ.Font = new Font("Bahnschrift", 11F, FontStyle.Bold);
            readFAQ.ForeColor = Color.DimGray;
            readFAQ.Location = new Point(9, 9);
            readFAQ.Margin = new Padding(0);
            readFAQ.Name = "readFAQ";
            readFAQ.Padding = new Padding(5, 5, 0, 0);
            readFAQ.Size = new Size(182, 25);
            readFAQ.TabIndex = 10;
            readFAQ.Text = "Read the FAQ";
            readFAQ.Click += readFAQ_Click;
            readFAQ.MouseEnter += readFAQ_MouseEnter;
            readFAQ.MouseLeave += readFAQ_MouseLeave;
            // 
            // joinLink
            // 
            joinLink.Cursor = Cursors.Hand;
            joinLink.Font = new Font("Bahnschrift", 11F, FontStyle.Bold);
            joinLink.ForeColor = Color.DimGray;
            joinLink.Location = new Point(9, 34);
            joinLink.Margin = new Padding(0);
            joinLink.Name = "joinLink";
            joinLink.Padding = new Padding(5, 5, 0, 0);
            joinLink.Size = new Size(182, 25);
            joinLink.TabIndex = 9;
            joinLink.Text = "Join the SPT-AKI Discord";
            joinLink.Click += joinLink_Click;
            joinLink.MouseEnter += joinLink_MouseEnter;
            joinLink.MouseLeave += joinLink_MouseLeave;
            // 
            // btnDown
            // 
            btnDown.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDown.BackColor = Color.FromArgb(34, 36, 38);
            btnDown.FlatAppearance.BorderColor = SystemColors.WindowFrame;
            btnDown.FlatStyle = FlatStyle.Flat;
            btnDown.Font = new Font("Bahnschrift Light", 20F);
            btnDown.Location = new Point(493, 12);
            btnDown.Name = "btnDown";
            btnDown.Padding = new Padding(3, 0, 0, 6);
            btnDown.Size = new Size(70, 45);
            btnDown.TabIndex = 8;
            btnDown.Text = "⬇️";
            btnDown.UseVisualStyleBackColor = false;
            btnDown.Click += btnDown_Click;
            // 
            // btnUp
            // 
            btnUp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUp.BackColor = Color.FromArgb(34, 36, 38);
            btnUp.FlatAppearance.BorderColor = SystemColors.WindowFrame;
            btnUp.FlatStyle = FlatStyle.Flat;
            btnUp.Font = new Font("Bahnschrift Light", 20F);
            btnUp.Location = new Point(402, 12);
            btnUp.Name = "btnUp";
            btnUp.Padding = new Padding(3, 0, 0, 6);
            btnUp.Size = new Size(70, 45);
            btnUp.TabIndex = 7;
            btnUp.Text = "⬆️";
            btnUp.UseVisualStyleBackColor = false;
            btnUp.Click += btnUp_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(30, 32, 34);
            panel1.Controls.Add(readFAQ);
            panel1.Controls.Add(joinLink);
            panel1.Controls.Add(placeholder);
            panel1.Controls.Add(btnDown);
            panel1.Controls.Add(btnUp);
            panel1.Location = new Point(0, 450);
            panel1.Name = "panel1";
            panel1.Size = new Size(575, 69);
            panel1.TabIndex = 12;
            // 
            // placeholder
            // 
            placeholder.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            placeholder.AutoSize = true;
            placeholder.Font = new Font("Bender", 8F);
            placeholder.ForeColor = Color.DimGray;
            placeholder.Location = new Point(3, 48);
            placeholder.Name = "placeholder";
            placeholder.Size = new Size(62, 12);
            placeholder.TabIndex = 11;
            placeholder.Text = "placeholder";
            placeholder.Visible = false;
            // 
            // modInfo
            // 
            modInfo.AutoPopDelay = 60000;
            modInfo.InitialDelay = 500;
            modInfo.ReshowDelay = 100;
            modInfo.ShowAlways = true;
            modInfo.ToolTipTitle = "Mod information";
            // 
            // mainForm
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 26, 28);
            ClientSize = new Size(575, 519);
            Controls.Add(panel1);
            Controls.Add(mainList);
            Font = new Font("Bender", 12F);
            ForeColor = Color.LightGray;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "mainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Load Order Editor - Revamped";
            Load += mainForm_Load;
            KeyDown += mainForm_KeyDown;
            mainList.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel mainList;
        private Label modOrder0;
        private Button btnUp;
        private Button btnDown;
        private Label joinLink;
        private Label readFAQ;
        private Panel panel1;
        private Label placeholder;
        private ToolTip modInfo;
    }
}
