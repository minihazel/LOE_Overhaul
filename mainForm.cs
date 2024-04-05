using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace LOE_Overhaul
{
    public partial class mainForm : Form
    {
        public string? currentEnv = Path.GetDirectoryName(Application.ExecutablePath);
        public string? cacheFolder;
        public string? serverFolder;
        public string? orderFile;
        public string[] mainOrder = { };

        public bool isSidebarOpen = false;

        public int sizeWidth = 0;
        public int sizeHeight = 0;

        public Color idleColor = Color.FromArgb(255, 24, 26, 28);
        public Color hoverColor = Color.FromArgb(255, 28, 30, 32);
        public Color selectColor = Color.FromArgb(255, 30, 32, 36);

        System.Windows.Forms.Timer tmr = null;
        int interval = 300;

        private messageWindow msgWindow;
        private Label draggedLabel = null;

        public mainForm()
        {
            InitializeComponent();
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            switch (m.Msg)
            {
                case 0x84: //WM_NCHITTEST
                    var result = (HitTest)m.Result.ToInt32();
                    if (result == HitTest.Left || result == HitTest.Right)
                        m.Result = new IntPtr((int)HitTest.Caption);
                    if (result == HitTest.TopLeft || result == HitTest.TopRight)
                        m.Result = new IntPtr((int)HitTest.Top);
                    if (result == HitTest.BottomLeft || result == HitTest.BottomRight)
                        m.Result = new IntPtr((int)HitTest.Bottom);

                    break;
            }
        }
        enum HitTest
        {
            Caption = 2,
            Transparent = -1,
            Nowhere = 0,
            Client = 1,
            Left = 10,
            Right = 11,
            Top = 12,
            TopLeft = 13,
            TopRight = 14,
            Bottom = 15,
            BottomLeft = 16,
            BottomRight = 17,
            Border = 18
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            serverFolder = Directory.GetParent(Directory.GetParent(currentEnv).FullName).FullName;

            orderFile = Path.Combine(currentEnv, "order.json");
            cacheFolder = Path.Combine(serverFolder, "user", "cache");

            initializeApp();
        }

        private void initializeApp()
        {
            sizeWidth = mainList.Size.Width;
            sizeHeight = mainList.Size.Height;

            bool serverFolderExists = Directory.Exists(serverFolder);
            if (serverFolderExists)
            {
                panelSidebar.Location = new Point(-266, 0);
                mainList.Location = new Point(0, 0);
                mainList.Size = new Size(mainList.Size.Width + 310, mainList.Size.Height);

                refreshUI();
                uselessFunction();

                Label firstMod = mainList.Controls.Find("modOrder0", false).FirstOrDefault() as Label;
                if (firstMod != null)
                {
                    selectItem(mainOrder[0]);
                }
            }
            else
            {
                if (MessageBox.Show($"We could not detect the Server folder (where Aki.Server.exe is).\n\nPlease put 'Load Order Editor.exe' into your user\\mods folder and try again!",
                    this.Text, MessageBoxButtons.OK) == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
        }

        private void displayMessage(string error, bool isError)
        {
            if (msgWindow != null)
                msgWindow.Close();

            string title = $"Message";
            string content = null;

            if (isError)
                content = $"An error occurred:" + Environment.NewLine +
                    Environment.NewLine +
                    error;
            else
                content = error;

            msgWindow = new messageWindow();
            msgWindow.titleText.Text = title;
            msgWindow.titleContent.Text = content;

            msgWindow.ShowDialog();
        }

        private void listMods()
        {
            Label sidebarLbl = new Label();

            sidebarLbl.Name = $"open_sidebar";
            if (!isSidebarOpen)
                sidebarLbl.Text = $"📂 Open sidebar";
            else
                sidebarLbl.Text = $"🗂 Close sidebar";

            sidebarLbl.AutoSize = false;
            sidebarLbl.AutoEllipsis = true;
            sidebarLbl.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right);
            sidebarLbl.TextAlign = modOrder0.TextAlign;
            sidebarLbl.Size = new Size(mainList.Size.Width, modOrder0.Size.Height);
            sidebarLbl.Location = new Point(1, 1);
            sidebarLbl.Font = new Font("Bahnschrift Light", 10, FontStyle.Bold);
            sidebarLbl.BackColor = idleColor;
            sidebarLbl.ForeColor = Color.LightGray;
            sidebarLbl.Padding = new Padding(10, 0, 0, 0);
            sidebarLbl.Cursor = Cursors.Hand;
            sidebarLbl.AutoEllipsis = true;
            sidebarLbl.MouseEnter += new EventHandler(lbl_MouseEnter);
            sidebarLbl.MouseLeave += new EventHandler(lbl_MouseLeave);
            sidebarLbl.MouseDown += new MouseEventHandler(lbl_MouseDown);
            sidebarLbl.MouseUp += new MouseEventHandler(lbl_MouseUp);
            sidebarLbl.MouseDoubleClick += new MouseEventHandler(lbl_MouseDoubleClick);
            mainList.Controls.Add(sidebarLbl);

            try
            {
                for (int i = 0; i < mainOrder.Length; i++)
                {
                    Label lbl = new Label();
                    lbl.Name = $"modOrder{i}";
                    lbl.Text = $"{i + 1}   {mainOrder[i]}";
                    lbl.AutoSize = false;
                    lbl.AutoEllipsis = true;
                    lbl.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right);
                    lbl.TextAlign = modOrder0.TextAlign;
                    lbl.Size = new Size(mainList.Size.Width, modOrder0.Size.Height);
                    lbl.Location = new Point(1, sidebarLbl.Location.Y + modOrder0.Size.Height + (i * modOrder0.Size.Height));
                    lbl.Font = new Font("Bahnschrift Light", 13, FontStyle.Bold);
                    lbl.BackColor = idleColor;
                    lbl.ForeColor = Color.LightGray;
                    lbl.Padding = new Padding(10, 0, 0, 0);
                    lbl.Cursor = Cursors.Hand;
                    lbl.AutoEllipsis = true;
                    lbl.MouseEnter += new EventHandler(lbl_MouseEnter);
                    lbl.MouseLeave += new EventHandler(lbl_MouseLeave);
                    lbl.MouseDown += new MouseEventHandler(lbl_MouseDown);
                    lbl.MouseUp += new MouseEventHandler(lbl_MouseUp);
                    lbl.MouseDoubleClick += new MouseEventHandler(lbl_MouseDoubleClick);
                    mainList.Controls.Add(lbl);
                }

                this.Text = $"{Path.GetFileName(serverFolder)} - {mainList.Controls.Count} active server mods";
            }
            catch (Exception err)
            {
                displayMessage(err.Message.ToString(), true);
            }
        }

        private void lbl_MouseEnter(object sender, EventArgs e)
        {
            System.Windows.Forms.Label label = (System.Windows.Forms.Label)sender;
            if (label.Text != "")
            {
                if (label.BackColor == idleColor)
                    label.BackColor = hoverColor;
                else if (label.BackColor == selectColor)
                    label.BackColor = selectColor;
            }
        }

        private void lbl_MouseLeave(object sender, EventArgs e)
        {
            System.Windows.Forms.Label label = (System.Windows.Forms.Label)sender;
            if (label.Text != "")
            {
                if (label.BackColor == hoverColor)
                    label.BackColor = idleColor;
                else if (label.BackColor == selectColor)
                    label.BackColor = selectColor;
            }
        }

        private void lbl_MouseDown(object sender, EventArgs e)
        {
            System.Windows.Forms.Label lbl = (System.Windows.Forms.Label)sender;

            if (lbl.Text != "")
            {
                foreach (Control component in mainList.Controls)
                {
                    if (component is Label)
                    {
                        if (component.Text != lbl.Text && lbl.Name.ToLower() != "open_sidebar")
                        {
                            component.BackColor = idleColor;
                            component.ForeColor = Color.LightGray;
                            component.Padding = new Padding(10, 0, 0, 0);
                        }
                    }
                }

                if (lbl.Name.ToLower() != "open_sidebar")
                {
                    lbl.ForeColor = Color.DodgerBlue;
                    lbl.Padding = new Padding(15, 0, 0, 0);

                    tmr = new System.Windows.Forms.Timer();
                    tmr.Interval = interval;
                    tmr.Tick += (sender, e) =>
                    {
                        startMoving();
                        tmr.Stop();
                        tmr.Dispose();
                    };
                    tmr.Start();
                }
                else
                {
                    if (lbl.Text.ToLower() == "🗂 close sidebar")
                    {
                        // closing sidebar
                        panelSidebar.Location = new Point(-266, 0);
                        mainList.Location = new Point(0, 0);
                        mainList.Size = new Size(this.Size.Width, mainList.Size.Height);

                        lbl.Text = "📂 Open sidebar";
                        isSidebarOpen = false;

                        foreach (Control component in mainList.Controls)
                        {
                            if (component is Label)
                                component.Size = new Size(mainList.Size.Width, component.Size.Height);
                        }
                    }
                    else if (lbl.Text.ToLower() == "📂 open sidebar")
                    {
                        // opening sidebar
                        panelSidebar.Location = new Point(0, 0);
                        mainList.Location = new Point(266, 0);
                        mainList.Size = new Size(310, mainList.Size.Height);

                        lbl.Text = "🗂 Close sidebar";
                        isSidebarOpen = true;

                        foreach (Control component in mainList.Controls)
                        {
                            if (component is Label)
                                component.Size = new Size(mainList.Size.Width, component.Size.Height);
                        }
                    }
                }
            }
        }

        private void lbl_MouseUp(object sender, EventArgs e)
        {
            System.Windows.Forms.Label label = (System.Windows.Forms.Label)sender;
            if (label.Text != "")
            {
                if (tmr != null && tmr.Enabled)
                {
                    tmr.Stop();
                    tmr = null;

                    displayModInfo(label.Text, false);
                }
            }
        }

        private void lbl_MouseDoubleClick(object sender, EventArgs e)
        {
            System.Windows.Forms.Label lbl = (System.Windows.Forms.Label)sender;
            if (lbl.Text != "")
            {
                if (lbl.Name.ToLower() != "open_sidebar")
                {
                    string result = lbl.Text.Remove(0, 2);
                    result = Regex.Replace(result, @"^\d+", "").Trim();
                    string modFolder = Path.Combine(currentEnv, result);

                    bool modFolderExists = Directory.Exists(modFolder);
                    if (modFolderExists)
                    {
                        try
                        {
                            Process.Start("explorer.exe", modFolder);
                        }
                        catch (Exception err)
                        {
                            displayMessage(err.Message.ToString(), true);
                        }
                    }
                    else
                    {
                        displayMessage("It seems that the path is invalid or this mod doesn't exist anymore. Restarting to refresh.", true);
                        Application.Restart();
                    }
                }
            }
        }

        private void startMoving()
        {
            // to be continued
        }

        private void displayModInfo(string modText, bool manual)
        {
            if (!manual)
            {
                Match matchedNumber = Regex.Match(modText, @"^\d+");
                if (matchedNumber.Success)
                {
                    string result = Regex.Replace(modText, @"^\d+", "").Trim();
                    string modFolder = Path.Combine(currentEnv, result);
                    string modFolderName = Path.GetFileName(modFolder);
                    string packageJsonFile = Path.Combine(modFolder, "package.json");

                    bool packageJsonFileExists = File.Exists(packageJsonFile);
                    if (packageJsonFileExists)
                    {
                        try
                        {
                            int iterated = 0;
                            string packageContent = File.ReadAllText(packageJsonFile);
                            JObject pkgObject = JObject.Parse(packageContent);

                            string pkgModName = pkgObject.Value<string>("name");
                            string pkgModVersion = pkgObject.Value<string>("version");
                            string pkgModAuthor = pkgObject.Value<string>("author");
                            string pkgModAkiVersion = pkgObject.Value<string>("akiVersion").ToUpper();
                            string? pkgModConfig = null;

                            string? modConfigFolder = Path.Combine(modFolder, "config");
                            string? modConfigFile1 = Path.Combine(modFolder, "config.json");
                            string? modConfigFile2 = Path.Combine(modConfigFolder, "config.json");

                            bool configExists = Directory.Exists(modConfigFolder);
                            if (configExists)
                            {
                                iterated++;
                                iterated++;

                                bool modConfig2Exists = File.Exists(modConfigFile2);

                                if (modConfig2Exists)
                                {
                                    iterated++;
                                    iterated++;
                                }
                            }
                            else
                            {
                                bool modConfigExists = File.Exists(modConfigFile1);
                                if (modConfigExists)
                                {
                                    iterated++;
                                }
                            }

                            switch (iterated)
                            {
                                case 0:
                                    pkgModConfig = $"None available";
                                    break;
                                case 1:
                                    pkgModConfig = $"{modFolderName}/config.json";
                                    break;
                                case 2:
                                    pkgModConfig = $"Nested";
                                    break;
                                case 4:
                                    pkgModConfig = $"config/config.json";
                                    break;
                            }

                            textModName.Text = pkgModName;
                            textModVersion.Text = pkgModVersion;
                            textModAuthor.Text = pkgModAuthor;
                            textModAkiVersion.Text = pkgModAkiVersion;
                            textModHasConfig.Text = pkgModConfig;
                        }
                        catch (Exception err)
                        {
                            displayMessage(err.Message.ToString(), true);
                        }
                    }
                }
            }
            else
            {
                string modFolder = Path.Combine(currentEnv, modText);
                string packageJsonFile = Path.Combine(modFolder, "package.json");

                bool packageJsonFileExists = File.Exists(packageJsonFile);
                if (packageJsonFileExists)
                {
                    try
                    {
                        int iterated = 0;
                        string packageContent = File.ReadAllText(packageJsonFile);
                        JObject pkgObject = JObject.Parse(packageContent);

                        string pkgModName = pkgObject.Value<string>("name");
                        string pkgModVersion = pkgObject.Value<string>("version");
                        string pkgModAuthor = pkgObject.Value<string>("author");
                        string pkgModAkiVersion = pkgObject.Value<string>("akiVersion").ToUpper();
                        string? pkgModConfig = null;

                        string? modConfigFolder = Path.Combine(modFolder, "config");
                        string? modConfigFile1 = Path.Combine(modFolder, "config.json");
                        string? modConfigFile2 = Path.Combine(modConfigFolder, "config.json");

                        bool configExists = Directory.Exists(modConfigFolder);
                        if (configExists)
                        {
                            iterated++;
                            iterated++;

                            bool modConfig2Exists = File.Exists(modConfigFile2);

                            if (modConfig2Exists)
                            {
                                iterated++;
                                iterated++;
                            }
                        }
                        else
                        {
                            bool modConfigExists = File.Exists(modConfigFile1);
                            if (modConfigExists)
                            {
                                iterated++;
                            }
                        }

                        switch (iterated)
                        {
                            case 0:
                                pkgModConfig = $"None available";
                                break;
                            case 1:
                                pkgModConfig = $"{modText}/config.json";
                                break;
                            case 2:
                                pkgModConfig = $"Nested";
                                break;
                            case 4:
                                pkgModConfig = $"config/config.json";
                                break;
                        }

                        textModName.Text = pkgModName;
                        textModVersion.Text = pkgModVersion;
                        textModAuthor.Text = pkgModAuthor;
                        textModAkiVersion.Text = pkgModAkiVersion;
                        textModHasConfig.Text = pkgModConfig;
                    }
                    catch (Exception err)
                    {
                        displayMessage(err.Message.ToString(), true);
                    }
                }
            }
        }

        private void checkForRedundantMods()
        {
            bool orderFileExists = File.Exists(orderFile);
            if (orderFileExists)
            {
                string orderJson = File.ReadAllText(orderFile);
                JObject orderObject = JObject.Parse(orderJson);
                JArray loadOrder = orderObject.Value<JArray>("order");

                if (loadOrder != null)
                {
                    int redundantMods = 0;

                    List<string> redundantItems = new List<string>();
                    foreach (string item in loadOrder)
                    {
                        string fullItem = Path.Combine(currentEnv, item);
                        bool folderExists = Directory.Exists(fullItem);
                        if (!folderExists)
                        {
                            redundantMods++;
                            redundantItems.Add(item);
                        }
                    }


                    if (redundantMods > 0)
                    {
                        foreach (string item in redundantItems)
                        {
                            JToken tokenToRemove = loadOrder.FirstOrDefault(t => t.ToString() == item);
                            if (tokenToRemove != null)
                            {
                                loadOrder.Remove(tokenToRemove);
                            }
                        }

                        string updatedJson = orderObject.ToString();
                        File.WriteAllText(orderFile, updatedJson);
                    }
                }
            }
            else
                generateOrderFile();
        }

        private void checkForNewMods()
        {
            try
            {
                string orderJson = File.ReadAllText(orderFile);
                JObject orderObject = JObject.Parse(orderJson);
                JArray loadOrder = orderObject.Value<JArray>("order");

                if (loadOrder != null)
                {
                    string[] modsFolders = Directory.GetDirectories(currentEnv);
                    foreach (string modFolder in modsFolders)
                    {
                        string modName = Path.GetFileName(modFolder);
                        JToken tokenToRemove = loadOrder.FirstOrDefault(t => t.ToString() == modName);
                        if (tokenToRemove == null)
                        {
                            loadOrder.Add(modName);
                        }
                    }
                }

                string updatedJSON = orderObject.ToString();
                File.WriteAllText(orderFile, updatedJSON);
            }
            catch (Exception err)
            {
                displayMessage(err.Message.ToString(), true);
            }
        }

        private void generateOrderFile()
        {
            string[] orderArray = Directory.GetDirectories(currentEnv).ToArray();
            JArray loadOrder = JArray.FromObject(orderArray);

            JObject fullObject = new JObject
            {
                { "order", loadOrder }
            };

            string newJSON = fullObject.ToString();

            File.WriteAllText(orderFile, newJSON);
            refreshUI();
        }

        private void clearInfoPages()
        {
            textModName.Clear();
            textModVersion.Clear();
            textModAuthor.Clear();
            textModHasConfig.Clear();
            textModAkiVersion.Clear();
        }

        private void clearUI()
        {
            for (int i = mainList.Controls.Count - 1; i >= 0; i--)
            {
                Label selected = mainList.Controls[i] as Label;
                if (selected != null)
                {
                    try
                    {
                        mainList.Controls.RemoveAt(i);
                        selected.Dispose();
                    }
                    catch (Exception err)
                    {
                        displayMessage(err.Message.ToString(), true);
                    }
                }
            }
        }

        private void refreshUI()
        {
            clearUI();

            bool orderFileExists = File.Exists(orderFile);
            if (orderFileExists)
            {
                checkForRedundantMods();
                checkForNewMods();
                clearInfoPages();

                try
                {
                    string orderContent = File.ReadAllText(orderFile);
                    List<string> modList = new List<string>();

                    JObject orderObject = JObject.Parse(orderContent);
                    JArray loadOrder = orderObject.Value<JArray>("order");

                    foreach (string item in loadOrder)
                    {
                        modList.Add(item);
                    }

                    mainOrder = modList.ToArray();
                    listMods();
                }
                catch (Exception err)
                {
                    displayMessage(err.Message.ToString(), true);
                }
            }
            else
            {
                string userModsParent = Path.GetFileName(currentEnv);
                if (userModsParent == "mods")
                    generateOrderFile();
            }
        }

        public void selectItem(string itemName)
        {
            foreach (Control component in mainList.Controls)
            {
                if (component is Label)
                {
                    string modText = component.Text;

                    Match matchedNumber = Regex.Match(modText, @"^\d+");
                    if (matchedNumber.Success)
                    {
                        string result = Regex.Replace(modText, @"^\d+", "").Trim();

                        if (result.ToLower() == itemName.ToLower())
                        {
                            string activeItem = component.Text;
                            component.Text = activeItem;
                            component.ForeColor = Color.DodgerBlue;
                            component.Padding = new Padding(15, 0, 0, 0);

                            clearInfoPages();
                            displayModInfo(itemName, true);
                        }
                    }
                }
            }
        }

        private void moveItemUp(string component)
        {
            string _name = component;

            orderFile = Path.Combine(currentEnv, "order.json");
            bool orderFileExists = File.Exists(orderFile);
            if (orderFileExists)
            {
                try
                {
                    string orderContent = File.ReadAllText(orderFile);
                    JObject orderObject = JObject.Parse(orderContent);
                    JArray orderArray = orderObject.Value<JArray>("order");

                    int itemIndex = Array.IndexOf(orderArray.ToObject<string[]>(), _name);
                    int lastIndex = orderArray.Count - 1;
                    if (itemIndex == 0)
                        return;
                    else if (itemIndex > 0)
                    {
                        string temp = orderArray.Value<string>(itemIndex - 1);
                        orderArray[itemIndex - 1] = orderArray[itemIndex];
                        orderArray[itemIndex] = temp;
                    }

                    string updatedJSON = orderObject.ToString();

                    File.WriteAllText(orderFile, updatedJSON);
                    refreshUI();
                }
                catch (Exception err)
                {
                    displayMessage(err.Message.ToString(), true);
                }
            }

            selectItem(_name);
        }

        private void moveItemDown(string component)
        {
            string _name = component;

            orderFile = Path.Combine(currentEnv, "order.json");
            bool orderFileExists = File.Exists(orderFile);
            if (orderFileExists)
            {
                try
                {
                    string orderContent = File.ReadAllText(orderFile);
                    JObject orderObject = JObject.Parse(orderContent);
                    JArray orderArray = orderObject.Value<JArray>("order");

                    int itemIndex = Array.IndexOf(orderArray.ToObject<string[]>(), _name);
                    int lastIndex = orderArray.Count - 1;
                    if (itemIndex < lastIndex)
                    {
                        string temp = orderArray.Value<string>(itemIndex + 1);
                        orderArray[itemIndex + 1] = orderArray[itemIndex];
                        orderArray[itemIndex] = temp;
                    }
                    else
                        return;

                    string updatedJSON = orderObject.ToString();

                    File.WriteAllText(orderFile, updatedJSON);
                    refreshUI();
                }
                catch (Exception err)
                {
                    displayMessage(err.Message.ToString(), true);
                }
            }

            selectItem(_name);
        }

        private void OpenURL(string url)
        {
            try
            {
                Process.Start(url);
            }
            catch
            {
                // hack because of this: https://github.com/dotnet/corefx/issues/10361
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    url = url.Replace("&", "^&");
                    Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                    Process.Start("xdg-open", url);
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                    Process.Start("open", url);
                else
                    throw;
            }
        }

        private void joinLink_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Would you like to join the SPT-AKI Discord server?" + Environment.NewLine + Environment.NewLine +
                                "This will open a new window", this.Text, MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    OpenURL("https://discord.com/invite/Xn9msqQZan");
                }
                catch (Exception err)
                {
                    displayMessage(err.Message.ToString(), true);
                }
            }
        }

        private void readFAQ_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Would you like to read the F.A.Q?" + Environment.NewLine + Environment.NewLine +
                                "This will open a new window", this.Text, MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    OpenURL("https://github.com/minihazel/LoadOrderEditor#features");
                }
                catch (Exception err)
                {
                    displayMessage(err.Message.ToString(), true);
                }
            }
        }

        private void joinLink_MouseEnter(object sender, EventArgs e)
        {
            joinLink.ForeColor = Color.DodgerBlue;
        }

        private void joinLink_MouseLeave(object sender, EventArgs e)
        {
            joinLink.ForeColor = Color.DimGray;
        }

        private void readFAQ_MouseEnter(object sender, EventArgs e)
        {
            readFAQ.ForeColor = Color.DodgerBlue;
        }

        private void readFAQ_MouseLeave(object sender, EventArgs e)
        {
            readFAQ.ForeColor = Color.DimGray;
        }

        private void mainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift && e.KeyCode == Keys.R)
            {
                refreshUI();
                if (mainList.Controls.ContainsKey("modOrder0"))
                {
                    Label modOrder0 = mainList.Controls["modOrder0"] as Label;

                    string activeItem = modOrder0.Text;
                    modOrder0.Text = activeItem;
                    modOrder0.ForeColor = Color.DodgerBlue;
                    modOrder0.Padding = new Padding(15, 0, 0, 0);
                }
            }
            else if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                foreach (Control component in mainList.Controls)
                {
                    if (component is Label label && component.ForeColor == Color.DodgerBlue)
                    {
                        Match matchedNumber = Regex.Match(label.Text, @"^\d+");

                        if (matchedNumber.Success)
                        {
                            string result = Regex.Replace(label.Text, @"^\d+", "").Trim();
                            moveItemUp(result);
                        }
                        break;
                    }
                }
            }
            else if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                foreach (Control component in mainList.Controls)
                {
                    if (component is Label label && component.ForeColor == Color.DodgerBlue)
                    {
                        Match matchedNumber = Regex.Match(label.Text, @"^\d+");

                        if (matchedNumber.Success)
                        {
                            string result = Regex.Replace(label.Text, @"^\d+", "").Trim();
                            moveItemDown(result);
                        }
                        break;
                    }
                }
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            foreach (Control component in mainList.Controls)
            {
                if (component is Label label && component.ForeColor == Color.DodgerBlue)
                {
                    Match matchedNumber = Regex.Match(label.Text, @"^\d+");

                    if (matchedNumber.Success)
                    {
                        string result = Regex.Replace(label.Text, @"^\d+", "").Trim();
                        moveItemUp(result);
                    }

                    break;
                }
            }

            uselessFunction();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            foreach (Control component in mainList.Controls)
            {
                if (component is Label label && component.ForeColor == Color.DodgerBlue)
                {
                    Match matchedNumber = Regex.Match(label.Text, @"^\d+");

                    if (matchedNumber.Success)
                    {
                        string result = Regex.Replace(label.Text, @"^\d+", "").Trim();
                        moveItemDown(result);
                    }

                    break;
                }
            }

            uselessFunction();
        }

        private void mainList_DragDrop(object sender, DragEventArgs e)
        {
            if (draggedLabel != null)
            {
                Point newLoc = mainList.PointToClient(new Point(e.X, e.Y));
                int index = GetInsertionIndex(newLoc);

            }
        }

        private int GetInsertionIndex(Point loc)
        {

            return 0;
        }

        private void moveItemToIndex(Label label, int index)
        {
            mainList.Controls.SetChildIndex(label, index);
        }

        private void uselessFunction()
        {
            titleModName.Select();
        }
    }
}
