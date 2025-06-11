namespace TheTextAdventure
{
    partial class TheTextAdventure
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
            TabPage tabPage3;
            panel1 = new Panel();
            HuntButton = new Button();
            WolfLabel = new Label();
            HuntLabel = new Label();
            statusStrip1 = new StatusStrip();
            HealthShow = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            LevelStatusShow = new ToolStripStatusLabel();
            LevelShow = new ToolStripProgressBar();
            DateandTime = new ToolStripStatusLabel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            MainPanel = new Panel();
            PlayerName = new Label();
            panel2 = new Panel();
            tabPage2 = new TabPage();
            PickPanel1 = new Panel();
            AppleLabel = new Label();
            PickPanelText = new Label();
            PickButton = new Button();
            Market = new TabPage();
            RemoveFromCartButton = new Button();
            AddToCartButton = new Button();
            BuyCartButton = new Button();
            CartListBox = new ListBox();
            MarketListBox = new ListBox();
            menuStrip1 = new MenuStrip();
            menüToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            nameToolStripMenuItem = new ToolStripMenuItem();
            PickTimer = new System.Windows.Forms.Timer(components);
            HuntAndFightTimer = new System.Windows.Forms.Timer(components);
            tabPage3 = new TabPage();
            tabPage3.SuspendLayout();
            panel1.SuspendLayout();
            statusStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            MainPanel.SuspendLayout();
            tabPage2.SuspendLayout();
            PickPanel1.SuspendLayout();
            Market.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(panel1);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(770, 364);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Hunt & Fight";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(HuntButton);
            panel1.Controls.Add(WolfLabel);
            panel1.Controls.Add(HuntLabel);
            panel1.Location = new Point(6, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 100);
            panel1.TabIndex = 0;
            // 
            // HuntButton
            // 
            HuntButton.Location = new Point(122, 74);
            HuntButton.Name = "HuntButton";
            HuntButton.Size = new Size(75, 23);
            HuntButton.TabIndex = 1;
            HuntButton.Text = "Hunt";
            HuntButton.UseVisualStyleBackColor = true;
            HuntButton.Click += HuntButton_Click;
            // 
            // WolfLabel
            // 
            WolfLabel.AutoSize = true;
            WolfLabel.Location = new Point(12, 15);
            WolfLabel.Name = "WolfLabel";
            WolfLabel.Size = new Size(35, 15);
            WolfLabel.TabIndex = 2;
            WolfLabel.Text = "Wolf:";
            // 
            // HuntLabel
            // 
            HuntLabel.AutoSize = true;
            HuntLabel.Location = new Point(3, 0);
            HuntLabel.Name = "HuntLabel";
            HuntLabel.Size = new Size(34, 15);
            HuntLabel.TabIndex = 1;
            HuntLabel.Text = "Hunt";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { HealthShow, toolStripStatusLabel2, LevelStatusShow, LevelShow, DateandTime });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // HealthShow
            // 
            HealthShow.Name = "HealthShow";
            HealthShow.Size = new Size(86, 17);
            HealthShow.Text = "Health:100/100";
            HealthShow.Click += HealthShow_Click;
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(0, 17);
            // 
            // LevelStatusShow
            // 
            LevelStatusShow.Name = "LevelStatusShow";
            LevelStatusShow.Size = new Size(49, 17);
            LevelStatusShow.Text = "Level 1 :";
            // 
            // LevelShow
            // 
            LevelShow.Name = "LevelShow";
            LevelShow.Size = new Size(100, 16);
            // 
            // DateandTime
            // 
            DateandTime.DisplayStyle = ToolStripItemDisplayStyle.Text;
            DateandTime.Margin = new Padding(475, 3, 15, 2);
            DateandTime.Name = "DateandTime";
            DateandTime.RightToLeft = RightToLeft.No;
            DateandTime.Size = new Size(91, 15);
            DateandTime.Text = "00:00 01.01.2025";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(Market);
            tabControl1.Location = new Point(10, 33);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(778, 392);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(MainPanel);
            tabPage1.Controls.Add(panel2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(770, 364);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Main Page";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // MainPanel
            // 
            MainPanel.Controls.Add(PlayerName);
            MainPanel.Location = new Point(6, 6);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(369, 167);
            MainPanel.TabIndex = 3;
            // 
            // PlayerName
            // 
            PlayerName.AutoSize = true;
            PlayerName.Location = new Point(3, 0);
            PlayerName.Name = "PlayerName";
            PlayerName.Size = new Size(42, 15);
            PlayerName.TabIndex = 4;
            PlayerName.Text = "Name:";
            // 
            // panel2
            // 
            panel2.Location = new Point(381, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(383, 167);
            panel2.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(PickPanel1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(770, 364);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Pick";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // PickPanel1
            // 
            PickPanel1.Controls.Add(AppleLabel);
            PickPanel1.Controls.Add(PickPanelText);
            PickPanel1.Controls.Add(PickButton);
            PickPanel1.Location = new Point(6, 6);
            PickPanel1.Name = "PickPanel1";
            PickPanel1.Size = new Size(200, 100);
            PickPanel1.TabIndex = 0;
            // 
            // AppleLabel
            // 
            AppleLabel.AutoSize = true;
            AppleLabel.Location = new Point(12, 15);
            AppleLabel.Name = "AppleLabel";
            AppleLabel.Size = new Size(41, 15);
            AppleLabel.TabIndex = 2;
            AppleLabel.Text = "Apple:";
            // 
            // PickPanelText
            // 
            PickPanelText.AutoSize = true;
            PickPanelText.Location = new Point(3, 0);
            PickPanelText.Name = "PickPanelText";
            PickPanelText.Size = new Size(84, 15);
            PickPanelText.TabIndex = 1;
            PickPanelText.Text = "Pick (Level 0+)";
            // 
            // PickButton
            // 
            PickButton.Location = new Point(122, 74);
            PickButton.Name = "PickButton";
            PickButton.Size = new Size(75, 23);
            PickButton.TabIndex = 0;
            PickButton.Text = "Pick";
            PickButton.UseVisualStyleBackColor = true;
            PickButton.Click += PickButton_Click;
            // 
            // Market
            // 
            Market.Controls.Add(RemoveFromCartButton);
            Market.Controls.Add(AddToCartButton);
            Market.Controls.Add(BuyCartButton);
            Market.Controls.Add(CartListBox);
            Market.Controls.Add(MarketListBox);
            Market.Location = new Point(4, 24);
            Market.Name = "Market";
            Market.Padding = new Padding(3);
            Market.Size = new Size(770, 364);
            Market.TabIndex = 3;
            Market.Text = "Market";
            Market.UseVisualStyleBackColor = true;
            // 
            // RemoveFromCartButton
            // 
            RemoveFromCartButton.Location = new Point(326, 35);
            RemoveFromCartButton.Name = "RemoveFromCartButton";
            RemoveFromCartButton.Size = new Size(120, 23);
            RemoveFromCartButton.TabIndex = 4;
            RemoveFromCartButton.Text = "Remove from Cart";
            RemoveFromCartButton.UseVisualStyleBackColor = true;
            // 
            // AddToCartButton
            // 
            AddToCartButton.Location = new Point(326, 6);
            AddToCartButton.Name = "AddToCartButton";
            AddToCartButton.Size = new Size(120, 23);
            AddToCartButton.TabIndex = 3;
            AddToCartButton.Text = "Add to Cart";
            AddToCartButton.UseVisualStyleBackColor = true;
            // 
            // BuyCartButton
            // 
            BuyCartButton.Location = new Point(526, 332);
            BuyCartButton.Name = "BuyCartButton";
            BuyCartButton.Size = new Size(238, 23);
            BuyCartButton.TabIndex = 2;
            BuyCartButton.Text = "Buy";
            BuyCartButton.UseVisualStyleBackColor = true;
            BuyCartButton.Click += BuyCartButton_Click;
            // 
            // CartListBox
            // 
            CartListBox.FormattingEnabled = true;
            CartListBox.ItemHeight = 15;
            CartListBox.Location = new Point(518, 6);
            CartListBox.Name = "CartListBox";
            CartListBox.Size = new Size(246, 319);
            CartListBox.TabIndex = 1;
            // 
            // MarketListBox
            // 
            MarketListBox.FormattingEnabled = true;
            MarketListBox.ItemHeight = 15;
            MarketListBox.Location = new Point(6, 6);
            MarketListBox.Name = "MarketListBox";
            MarketListBox.Size = new Size(246, 349);
            MarketListBox.TabIndex = 0;
            MarketListBox.SelectedIndexChanged += MarketListBox_SelectedIndexChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menüToolStripMenuItem, editToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // menüToolStripMenuItem
            // 
            menüToolStripMenuItem.Name = "menüToolStripMenuItem";
            menüToolStripMenuItem.Size = new Size(50, 20);
            menüToolStripMenuItem.Text = "Menu";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nameToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // nameToolStripMenuItem
            // 
            nameToolStripMenuItem.Name = "nameToolStripMenuItem";
            nameToolStripMenuItem.Size = new Size(106, 22);
            nameToolStripMenuItem.Text = "Name";
            nameToolStripMenuItem.Click += nameToolStripMenuItem_Click;
            // 
            // TheTextAdventure
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Controls.Add(tabControl1);
            MainMenuStrip = menuStrip1;
            Name = "TheTextAdventure";
            Text = "The Text Adventure";
            Load += TheTextAdventure_Load;
            tabPage3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            tabPage2.ResumeLayout(false);
            PickPanel1.ResumeLayout(false);
            PickPanel1.PerformLayout();
            Market.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menüToolStripMenuItem;
        private ToolStripStatusLabel HealthShow;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel LevelStatusShow;
        private ToolStripProgressBar LevelShow;
        private ToolStripStatusLabel DateandTime;
        private Panel MainPanel;
        private Label PlayerName;
        private Panel panel2;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem nameToolStripMenuItem;
        private Panel PickPanel1;
        private Button PickButton;
        private Label PickPanelText;
        private System.Windows.Forms.Timer PickTimer;
        private Label AppleLabel;
        private TabPage tabPage3;
        private Panel panel1;
        private Label HuntLabel;
        private Button HuntButton;
        private Label WolfLabel;
        private System.Windows.Forms.Timer HuntAndFightTimer;
        private TabPage Market;
        private Button AddToCartButton;
        private Button BuyCartButton;
        private ListBox CartListBox;
        private ListBox MarketListBox;
        private Button RemoveFromCartButton;
    }
}
