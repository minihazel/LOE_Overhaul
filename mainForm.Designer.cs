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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            mainList = new Panel();
            modOrder0 = new Label();
            panelSidebar = new Panel();
            grLinks = new GroupBox();
            readFAQ = new Label();
            joinLink = new Label();
            btnDown = new Button();
            btnUp = new Button();
            pnlModAkiVersion = new Panel();
            titleModAkiVersion = new Label();
            textModAkiVersion = new TextBox();
            pnlModHasConfig = new Panel();
            titleModHasConfig = new Label();
            textModHasConfig = new TextBox();
            pnlModAuthor = new Panel();
            titleModAuthor = new Label();
            textModAuthor = new TextBox();
            pnlModVersion = new Panel();
            titleModVersion = new Label();
            textModVersion = new TextBox();
            pnlModName = new Panel();
            titleModName = new Label();
            textModName = new TextBox();
            mainList.SuspendLayout();
            panelSidebar.SuspendLayout();
            grLinks.SuspendLayout();
            pnlModAkiVersion.SuspendLayout();
            pnlModHasConfig.SuspendLayout();
            pnlModAuthor.SuspendLayout();
            pnlModVersion.SuspendLayout();
            pnlModName.SuspendLayout();
            SuspendLayout();
            // 
            // mainList
            // 
            mainList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            mainList.AutoScroll = true;
            mainList.Controls.Add(modOrder0);
            mainList.Font = new Font("Bahnschrift Light", 12F);
            mainList.Location = new Point(265, 0);
            mainList.Margin = new Padding(4, 3, 4, 3);
            mainList.Name = "mainList";
            mainList.Size = new Size(310, 664);
            mainList.TabIndex = 1;
            mainList.DragDrop += mainList_DragDrop;
            // 
            // modOrder0
            // 
            modOrder0.AutoEllipsis = true;
            modOrder0.Cursor = Cursors.Hand;
            modOrder0.Location = new Point(1, 1);
            modOrder0.Name = "modOrder0";
            modOrder0.Padding = new Padding(10, 0, 0, 0);
            modOrder0.Size = new Size(306, 33);
            modOrder0.TabIndex = 0;
            modOrder0.Text = "placeholderItem";
            modOrder0.TextAlign = ContentAlignment.MiddleLeft;
            modOrder0.Visible = false;
            // 
            // panelSidebar
            // 
            panelSidebar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelSidebar.BackColor = Color.FromArgb(28, 30, 32);
            panelSidebar.Controls.Add(grLinks);
            panelSidebar.Controls.Add(btnDown);
            panelSidebar.Controls.Add(btnUp);
            panelSidebar.Controls.Add(pnlModAkiVersion);
            panelSidebar.Controls.Add(pnlModHasConfig);
            panelSidebar.Controls.Add(pnlModAuthor);
            panelSidebar.Controls.Add(pnlModVersion);
            panelSidebar.Controls.Add(pnlModName);
            panelSidebar.Font = new Font("Bahnschrift Light", 12F);
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(266, 664);
            panelSidebar.TabIndex = 2;
            // 
            // grLinks
            // 
            grLinks.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            grLinks.Controls.Add(readFAQ);
            grLinks.Controls.Add(joinLink);
            grLinks.Font = new Font("Bahnschrift Light", 11F);
            grLinks.ForeColor = Color.LightGray;
            grLinks.Location = new Point(6, 556);
            grLinks.Name = "grLinks";
            grLinks.Size = new Size(251, 96);
            grLinks.TabIndex = 11;
            grLinks.TabStop = false;
            grLinks.Text = "Links";
            // 
            // readFAQ
            // 
            readFAQ.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            readFAQ.Cursor = Cursors.Hand;
            readFAQ.Font = new Font("Bahnschrift", 11F, FontStyle.Bold);
            readFAQ.ForeColor = Color.DimGray;
            readFAQ.Location = new Point(3, 22);
            readFAQ.Margin = new Padding(0);
            readFAQ.Name = "readFAQ";
            readFAQ.Padding = new Padding(5, 5, 0, 0);
            readFAQ.Size = new Size(245, 25);
            readFAQ.TabIndex = 10;
            readFAQ.Text = "Read the FAQ";
            readFAQ.TextAlign = ContentAlignment.TopCenter;
            readFAQ.Click += readFAQ_Click;
            readFAQ.MouseEnter += readFAQ_MouseEnter;
            readFAQ.MouseLeave += readFAQ_MouseLeave;
            // 
            // joinLink
            // 
            joinLink.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            joinLink.Cursor = Cursors.Hand;
            joinLink.Font = new Font("Bahnschrift", 11F, FontStyle.Bold);
            joinLink.ForeColor = Color.DimGray;
            joinLink.Location = new Point(3, 56);
            joinLink.Margin = new Padding(0);
            joinLink.Name = "joinLink";
            joinLink.Padding = new Padding(5, 5, 0, 0);
            joinLink.Size = new Size(245, 25);
            joinLink.TabIndex = 9;
            joinLink.Text = "Join the SPT-AKI Discord";
            joinLink.TextAlign = ContentAlignment.TopCenter;
            joinLink.Click += joinLink_Click;
            joinLink.MouseEnter += joinLink_MouseEnter;
            joinLink.MouseLeave += joinLink_MouseLeave;
            // 
            // btnDown
            // 
            btnDown.BackColor = Color.FromArgb(34, 36, 38);
            btnDown.FlatAppearance.BorderColor = SystemColors.WindowFrame;
            btnDown.FlatStyle = FlatStyle.Flat;
            btnDown.Font = new Font("Bahnschrift Light", 30F);
            btnDown.Location = new Point(6, 469);
            btnDown.Name = "btnDown";
            btnDown.Size = new Size(251, 65);
            btnDown.TabIndex = 8;
            btnDown.Text = "⬇️";
            btnDown.UseVisualStyleBackColor = false;
            btnDown.Click += btnDown_Click;
            // 
            // btnUp
            // 
            btnUp.BackColor = Color.FromArgb(34, 36, 38);
            btnUp.FlatAppearance.BorderColor = SystemColors.WindowFrame;
            btnUp.FlatStyle = FlatStyle.Flat;
            btnUp.Font = new Font("Bahnschrift Light", 30F);
            btnUp.Location = new Point(6, 389);
            btnUp.Name = "btnUp";
            btnUp.Size = new Size(251, 65);
            btnUp.TabIndex = 7;
            btnUp.Text = "⬆️";
            btnUp.UseVisualStyleBackColor = false;
            btnUp.Click += btnUp_Click;
            // 
            // pnlModAkiVersion
            // 
            pnlModAkiVersion.Controls.Add(titleModAkiVersion);
            pnlModAkiVersion.Controls.Add(textModAkiVersion);
            pnlModAkiVersion.Location = new Point(3, 296);
            pnlModAkiVersion.Name = "pnlModAkiVersion";
            pnlModAkiVersion.Size = new Size(257, 65);
            pnlModAkiVersion.TabIndex = 6;
            // 
            // titleModAkiVersion
            // 
            titleModAkiVersion.Font = new Font("Bahnschrift Light", 9F);
            titleModAkiVersion.Location = new Point(3, 3);
            titleModAkiVersion.Name = "titleModAkiVersion";
            titleModAkiVersion.Size = new Size(251, 20);
            titleModAkiVersion.TabIndex = 0;
            titleModAkiVersion.Text = "Aki version";
            titleModAkiVersion.TextAlign = ContentAlignment.BottomLeft;
            // 
            // textModAkiVersion
            // 
            textModAkiVersion.BackColor = Color.FromArgb(28, 30, 32);
            textModAkiVersion.BorderStyle = BorderStyle.FixedSingle;
            textModAkiVersion.Enabled = false;
            textModAkiVersion.Font = new Font("Bahnschrift Light", 13F);
            textModAkiVersion.ForeColor = Color.LightGray;
            textModAkiVersion.Location = new Point(3, 35);
            textModAkiVersion.Name = "textModAkiVersion";
            textModAkiVersion.ReadOnly = true;
            textModAkiVersion.Size = new Size(251, 28);
            textModAkiVersion.TabIndex = 1;
            textModAkiVersion.Text = "Placeholder";
            // 
            // pnlModHasConfig
            // 
            pnlModHasConfig.Controls.Add(titleModHasConfig);
            pnlModHasConfig.Controls.Add(textModHasConfig);
            pnlModHasConfig.Location = new Point(3, 225);
            pnlModHasConfig.Name = "pnlModHasConfig";
            pnlModHasConfig.Size = new Size(257, 65);
            pnlModHasConfig.TabIndex = 5;
            // 
            // titleModHasConfig
            // 
            titleModHasConfig.Font = new Font("Bahnschrift Light", 9F);
            titleModHasConfig.Location = new Point(3, 3);
            titleModHasConfig.Name = "titleModHasConfig";
            titleModHasConfig.Size = new Size(251, 20);
            titleModHasConfig.TabIndex = 0;
            titleModHasConfig.Text = "Config path";
            titleModHasConfig.TextAlign = ContentAlignment.BottomLeft;
            // 
            // textModHasConfig
            // 
            textModHasConfig.BackColor = Color.FromArgb(28, 30, 32);
            textModHasConfig.BorderStyle = BorderStyle.FixedSingle;
            textModHasConfig.Enabled = false;
            textModHasConfig.Font = new Font("Bahnschrift Light", 13F);
            textModHasConfig.ForeColor = Color.LightGray;
            textModHasConfig.Location = new Point(3, 35);
            textModHasConfig.Name = "textModHasConfig";
            textModHasConfig.ReadOnly = true;
            textModHasConfig.Size = new Size(251, 28);
            textModHasConfig.TabIndex = 1;
            textModHasConfig.Text = "Placeholder";
            // 
            // pnlModAuthor
            // 
            pnlModAuthor.Controls.Add(titleModAuthor);
            pnlModAuthor.Controls.Add(textModAuthor);
            pnlModAuthor.Location = new Point(3, 154);
            pnlModAuthor.Name = "pnlModAuthor";
            pnlModAuthor.Size = new Size(257, 65);
            pnlModAuthor.TabIndex = 4;
            // 
            // titleModAuthor
            // 
            titleModAuthor.Font = new Font("Bahnschrift Light", 9F);
            titleModAuthor.Location = new Point(3, 3);
            titleModAuthor.Name = "titleModAuthor";
            titleModAuthor.Size = new Size(251, 20);
            titleModAuthor.TabIndex = 0;
            titleModAuthor.Text = "Author";
            titleModAuthor.TextAlign = ContentAlignment.BottomLeft;
            // 
            // textModAuthor
            // 
            textModAuthor.BackColor = Color.FromArgb(28, 30, 32);
            textModAuthor.BorderStyle = BorderStyle.FixedSingle;
            textModAuthor.Enabled = false;
            textModAuthor.Font = new Font("Bahnschrift Light", 13F);
            textModAuthor.ForeColor = Color.LightGray;
            textModAuthor.Location = new Point(3, 35);
            textModAuthor.Name = "textModAuthor";
            textModAuthor.ReadOnly = true;
            textModAuthor.Size = new Size(251, 28);
            textModAuthor.TabIndex = 1;
            textModAuthor.Text = "Placeholder";
            // 
            // pnlModVersion
            // 
            pnlModVersion.Controls.Add(titleModVersion);
            pnlModVersion.Controls.Add(textModVersion);
            pnlModVersion.Location = new Point(3, 83);
            pnlModVersion.Name = "pnlModVersion";
            pnlModVersion.Size = new Size(257, 65);
            pnlModVersion.TabIndex = 3;
            // 
            // titleModVersion
            // 
            titleModVersion.Font = new Font("Bahnschrift Light", 9F);
            titleModVersion.Location = new Point(3, 3);
            titleModVersion.Name = "titleModVersion";
            titleModVersion.Size = new Size(251, 20);
            titleModVersion.TabIndex = 0;
            titleModVersion.Text = "Version";
            titleModVersion.TextAlign = ContentAlignment.BottomLeft;
            // 
            // textModVersion
            // 
            textModVersion.BackColor = Color.FromArgb(28, 30, 32);
            textModVersion.BorderStyle = BorderStyle.FixedSingle;
            textModVersion.Enabled = false;
            textModVersion.Font = new Font("Bahnschrift Light", 13F);
            textModVersion.ForeColor = Color.LightGray;
            textModVersion.Location = new Point(3, 35);
            textModVersion.Name = "textModVersion";
            textModVersion.ReadOnly = true;
            textModVersion.Size = new Size(251, 28);
            textModVersion.TabIndex = 1;
            textModVersion.Text = "Placeholder";
            // 
            // pnlModName
            // 
            pnlModName.Controls.Add(titleModName);
            pnlModName.Controls.Add(textModName);
            pnlModName.Location = new Point(3, 12);
            pnlModName.Name = "pnlModName";
            pnlModName.Size = new Size(257, 65);
            pnlModName.TabIndex = 2;
            // 
            // titleModName
            // 
            titleModName.Font = new Font("Bahnschrift Light", 9F);
            titleModName.Location = new Point(3, 3);
            titleModName.Name = "titleModName";
            titleModName.Size = new Size(251, 20);
            titleModName.TabIndex = 0;
            titleModName.Text = "Name";
            titleModName.TextAlign = ContentAlignment.BottomLeft;
            // 
            // textModName
            // 
            textModName.BackColor = Color.FromArgb(28, 30, 32);
            textModName.BorderStyle = BorderStyle.FixedSingle;
            textModName.Enabled = false;
            textModName.Font = new Font("Bahnschrift Light", 13F);
            textModName.ForeColor = Color.LightGray;
            textModName.Location = new Point(3, 35);
            textModName.Name = "textModName";
            textModName.ReadOnly = true;
            textModName.Size = new Size(251, 28);
            textModName.TabIndex = 1;
            textModName.Text = "Placeholder";
            // 
            // mainForm
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 26, 28);
            ClientSize = new Size(575, 664);
            Controls.Add(panelSidebar);
            Controls.Add(mainList);
            Font = new Font("Bender", 12F);
            ForeColor = Color.LightGray;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "mainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Load Order Editor - Revamped";
            Load += mainForm_Load;
            KeyDown += mainForm_KeyDown;
            mainList.ResumeLayout(false);
            panelSidebar.ResumeLayout(false);
            grLinks.ResumeLayout(false);
            pnlModAkiVersion.ResumeLayout(false);
            pnlModAkiVersion.PerformLayout();
            pnlModHasConfig.ResumeLayout(false);
            pnlModHasConfig.PerformLayout();
            pnlModAuthor.ResumeLayout(false);
            pnlModAuthor.PerformLayout();
            pnlModVersion.ResumeLayout(false);
            pnlModVersion.PerformLayout();
            pnlModName.ResumeLayout(false);
            pnlModName.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel mainList;
        private Label modOrder0;
        private Panel panelSidebar;
        private Label titleModName;
        private TextBox textModName;
        private Panel pnlModVersion;
        private Label titleModVersion;
        private TextBox textModVersion;
        private Panel pnlModName;
        private Panel pnlModAuthor;
        private Label titleModAuthor;
        private TextBox textModAuthor;
        private Panel pnlModHasConfig;
        private Label titleModHasConfig;
        private TextBox textModHasConfig;
        private Panel pnlModAkiVersion;
        private Label titleModAkiVersion;
        private TextBox textModAkiVersion;
        private Button btnUp;
        private Button btnDown;
        private Label joinLink;
        private Label readFAQ;
        private GroupBox grLinks;
    }
}
