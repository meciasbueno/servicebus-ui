namespace Servicebus.Ui.WinForm
{
    partial class FrmMain
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
            components = new System.ComponentModel.Container();
            TabControl = new TabControl();
            TabTopics = new TabPage();
            GridTopics = new DataGridView();
            PopupTopics = new ContextMenuStrip(components);
            PopupTopicsPublishMessage = new ToolStripMenuItem();
            popupTopicsPurgeMessages = new ToolStripSeparator();
            PopUpTopicsPurgeActiveMessages = new ToolStripMenuItem();
            PopUpTopicsPurgeDeadLetterMessages = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            PopUpTopicsDisableTopic = new ToolStripMenuItem();
            PopUpTopicsDeleteTopic = new ToolStripMenuItem();
            TabSubscriptions = new TabPage();
            lblSubscriptionTopicName = new Label();
            GridSubscriptions = new DataGridView();
            PopupSubscriptions = new ContextMenuStrip(components);
            PopUpSubscriptionPurgeActiveMessages = new ToolStripMenuItem();
            PopUpSubscriptionPurgeDeadLetterMessages = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            PopUpSubscriptionDisableSubscription = new ToolStripMenuItem();
            PopUpSubscriptionDeleteSubscription = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            PopUpSubscriptionReceiveMessages = new ToolStripMenuItem();
            TxtConnectionString = new TextBox();
            MenuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            menuActions = new ToolStripMenuItem();
            CbOrderBy = new ComboBox();
            label1 = new Label();
            BtSearch = new Button();
            label2 = new Label();
            label4 = new Label();
            TxtSubscription = new TextBox();
            label5 = new Label();
            TxtTopic = new TextBox();
            label3 = new Label();
            CbPrefix = new ComboBox();
            TabControl.SuspendLayout();
            TabTopics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridTopics).BeginInit();
            PopupTopics.SuspendLayout();
            TabSubscriptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridSubscriptions).BeginInit();
            PopupSubscriptions.SuspendLayout();
            MenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // TabControl
            // 
            TabControl.Appearance = TabAppearance.FlatButtons;
            TabControl.Controls.Add(TabTopics);
            TabControl.Controls.Add(TabSubscriptions);
            TabControl.Dock = DockStyle.Bottom;
            TabControl.Location = new Point(0, 132);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(775, 433);
            TabControl.TabIndex = 3;
            TabControl.Selected += TabControl_Selected;
            // 
            // TabTopics
            // 
            TabTopics.Controls.Add(GridTopics);
            TabTopics.Location = new Point(4, 27);
            TabTopics.Name = "TabTopics";
            TabTopics.Padding = new Padding(3);
            TabTopics.Size = new Size(767, 402);
            TabTopics.TabIndex = 0;
            TabTopics.Text = "Topics";
            TabTopics.UseVisualStyleBackColor = true;
            // 
            // GridTopics
            // 
            GridTopics.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridTopics.ContextMenuStrip = PopupTopics;
            GridTopics.Dock = DockStyle.Fill;
            GridTopics.Location = new Point(3, 3);
            GridTopics.Name = "GridTopics";
            GridTopics.RowHeadersVisible = false;
            GridTopics.RowTemplate.Height = 25;
            GridTopics.Size = new Size(761, 396);
            GridTopics.TabIndex = 1;
            GridTopics.CellDoubleClick += GridTopics_CellDoubleClick;
            GridTopics.SelectionChanged += GridTopics_SelectionChanged;
            GridTopics.KeyDown += GridTopics_KeyDown;
            // 
            // PopupTopics
            // 
            PopupTopics.Items.AddRange(new ToolStripItem[] { PopupTopicsPublishMessage, popupTopicsPurgeMessages, PopUpTopicsPurgeActiveMessages, PopUpTopicsPurgeDeadLetterMessages, toolStripSeparator1, PopUpTopicsDisableTopic, PopUpTopicsDeleteTopic });
            PopupTopics.Name = "contextMenuStrip1";
            PopupTopics.Size = new Size(223, 126);
            // 
            // PopupTopicsPublishMessage
            // 
            PopupTopicsPublishMessage.Name = "PopupTopicsPublishMessage";
            PopupTopicsPublishMessage.Size = new Size(222, 22);
            PopupTopicsPublishMessage.Text = "Publish Message";
            PopupTopicsPublishMessage.Click += PopupTopicsPublishMessage_Click;
            // 
            // popupTopicsPurgeMessages
            // 
            popupTopicsPurgeMessages.Name = "popupTopicsPurgeMessages";
            popupTopicsPurgeMessages.Size = new Size(219, 6);
            // 
            // PopUpTopicsPurgeActiveMessages
            // 
            PopUpTopicsPurgeActiveMessages.Name = "PopUpTopicsPurgeActiveMessages";
            PopUpTopicsPurgeActiveMessages.Size = new Size(222, 22);
            PopUpTopicsPurgeActiveMessages.Text = "Purge Active Messages";
            PopUpTopicsPurgeActiveMessages.Click += PopUpTopicsPurgeActiveMessages_Click;
            // 
            // PopUpTopicsPurgeDeadLetterMessages
            // 
            PopUpTopicsPurgeDeadLetterMessages.Name = "PopUpTopicsPurgeDeadLetterMessages";
            PopUpTopicsPurgeDeadLetterMessages.Size = new Size(222, 22);
            PopUpTopicsPurgeDeadLetterMessages.Text = "Purge Dead Letter Messages";
            PopUpTopicsPurgeDeadLetterMessages.Click += PopUpTopicsPurgeDeadLetterMessages_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(219, 6);
            // 
            // PopUpTopicsDisableTopic
            // 
            PopUpTopicsDisableTopic.Name = "PopUpTopicsDisableTopic";
            PopUpTopicsDisableTopic.Size = new Size(222, 22);
            PopUpTopicsDisableTopic.Text = "Enabled / Disable Topic";
            PopUpTopicsDisableTopic.Click += PopUpTopicsDisableTopic_Click;
            // 
            // PopUpTopicsDeleteTopic
            // 
            PopUpTopicsDeleteTopic.Name = "PopUpTopicsDeleteTopic";
            PopUpTopicsDeleteTopic.Size = new Size(222, 22);
            PopUpTopicsDeleteTopic.Text = "Delete Topic";
            PopUpTopicsDeleteTopic.Click += PopUpTopicsDeleteTopic_ClickAsync;
            // 
            // TabSubscriptions
            // 
            TabSubscriptions.Controls.Add(lblSubscriptionTopicName);
            TabSubscriptions.Controls.Add(GridSubscriptions);
            TabSubscriptions.Location = new Point(4, 27);
            TabSubscriptions.Name = "TabSubscriptions";
            TabSubscriptions.Padding = new Padding(3);
            TabSubscriptions.Size = new Size(767, 402);
            TabSubscriptions.TabIndex = 1;
            TabSubscriptions.Text = "Subscriptions";
            TabSubscriptions.UseVisualStyleBackColor = true;
            // 
            // lblSubscriptionTopicName
            // 
            lblSubscriptionTopicName.AutoSize = true;
            lblSubscriptionTopicName.Location = new Point(3, 3);
            lblSubscriptionTopicName.Name = "lblSubscriptionTopicName";
            lblSubscriptionTopicName.Size = new Size(38, 15);
            lblSubscriptionTopicName.TabIndex = 3;
            lblSubscriptionTopicName.Text = "Topic:";
            // 
            // GridSubscriptions
            // 
            GridSubscriptions.Anchor = AnchorStyles.Left;
            GridSubscriptions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridSubscriptions.ContextMenuStrip = PopupSubscriptions;
            GridSubscriptions.Location = new Point(0, 21);
            GridSubscriptions.Name = "GridSubscriptions";
            GridSubscriptions.RowHeadersVisible = false;
            GridSubscriptions.RowTemplate.Height = 25;
            GridSubscriptions.Size = new Size(764, 389);
            GridSubscriptions.TabIndex = 2;
            GridSubscriptions.CellDoubleClick += GridSubscriptions_CellDoubleClick;
            GridSubscriptions.SelectionChanged += GridSubscriptions_SelectionChanged;
            GridSubscriptions.KeyDown += GridSubscriptions_KeyDownAsync;
            // 
            // PopupSubscriptions
            // 
            PopupSubscriptions.Items.AddRange(new ToolStripItem[] { PopUpSubscriptionPurgeActiveMessages, PopUpSubscriptionPurgeDeadLetterMessages, toolStripSeparator2, PopUpSubscriptionDisableSubscription, PopUpSubscriptionDeleteSubscription, toolStripSeparator3, PopUpSubscriptionReceiveMessages });
            PopupSubscriptions.Name = "popupSubscriptions";
            PopupSubscriptions.Size = new Size(235, 126);
            // 
            // PopUpSubscriptionPurgeActiveMessages
            // 
            PopUpSubscriptionPurgeActiveMessages.Name = "PopUpSubscriptionPurgeActiveMessages";
            PopUpSubscriptionPurgeActiveMessages.Size = new Size(234, 22);
            PopUpSubscriptionPurgeActiveMessages.Text = "Purge Active Messages";
            PopUpSubscriptionPurgeActiveMessages.Click += PopUpSubscriptionPurgeActiveMessages_Click;
            // 
            // PopUpSubscriptionPurgeDeadLetterMessages
            // 
            PopUpSubscriptionPurgeDeadLetterMessages.Name = "PopUpSubscriptionPurgeDeadLetterMessages";
            PopUpSubscriptionPurgeDeadLetterMessages.Size = new Size(234, 22);
            PopUpSubscriptionPurgeDeadLetterMessages.Text = "Purge Dead Letter Messages";
            PopUpSubscriptionPurgeDeadLetterMessages.Click += PopUpSubscriptionPurgeDeadLetterMessages_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(231, 6);
            // 
            // PopUpSubscriptionDisableSubscription
            // 
            PopUpSubscriptionDisableSubscription.Name = "PopUpSubscriptionDisableSubscription";
            PopUpSubscriptionDisableSubscription.Size = new Size(234, 22);
            PopUpSubscriptionDisableSubscription.Text = "Enabled / Disable Subscription";
            PopUpSubscriptionDisableSubscription.Click += PopUpSubscriptionDisableSubscription_Click;
            // 
            // PopUpSubscriptionDeleteSubscription
            // 
            PopUpSubscriptionDeleteSubscription.Name = "PopUpSubscriptionDeleteSubscription";
            PopUpSubscriptionDeleteSubscription.Size = new Size(234, 22);
            PopUpSubscriptionDeleteSubscription.Text = "Delete Subscription";
            PopUpSubscriptionDeleteSubscription.Click += PopUpSubscriptionDeleteSubscription_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(231, 6);
            // 
            // PopUpSubscriptionReceiveMessages
            // 
            PopUpSubscriptionReceiveMessages.Name = "PopUpSubscriptionReceiveMessages";
            PopUpSubscriptionReceiveMessages.Size = new Size(234, 22);
            PopUpSubscriptionReceiveMessages.Text = "Receive Messages";
            PopUpSubscriptionReceiveMessages.Click += PopUpSubscriptionReceiveMessages_Click;
            // 
            // TxtConnectionString
            // 
            TxtConnectionString.Location = new Point(12, 40);
            TxtConnectionString.Name = "TxtConnectionString";
            TxtConnectionString.Size = new Size(333, 23);
            TxtConnectionString.TabIndex = 0;
            TxtConnectionString.Leave += TxtConnectionString_Leave;
            // 
            // MenuStrip1
            // 
            MenuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            MenuStrip1.Location = new Point(0, 0);
            MenuStrip1.Name = "MenuStrip1";
            MenuStrip1.Size = new Size(775, 24);
            MenuStrip1.TabIndex = 9;
            MenuStrip1.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuActions });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // menuActions
            // 
            menuActions.Name = "menuActions";
            menuActions.Size = new Size(114, 22);
            menuActions.Text = "Actions";
            menuActions.Click += MenuActions_Click;
            // 
            // CbOrderBy
            // 
            CbOrderBy.DropDownStyle = ComboBoxStyle.DropDownList;
            CbOrderBy.FlatStyle = FlatStyle.Popup;
            CbOrderBy.FormattingEnabled = true;
            CbOrderBy.Location = new Point(487, 40);
            CbOrderBy.Name = "CbOrderBy";
            CbOrderBy.Size = new Size(177, 23);
            CbOrderBy.TabIndex = 2;
            CbOrderBy.SelectedIndexChanged += CbPrefix_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(487, 23);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 11;
            label1.Text = "Order by";
            // 
            // BtSearch
            // 
            BtSearch.FlatStyle = FlatStyle.Flat;
            BtSearch.Location = new Point(675, 40);
            BtSearch.Name = "BtSearch";
            BtSearch.Size = new Size(95, 23);
            BtSearch.TabIndex = 5;
            BtSearch.Text = "Search";
            BtSearch.UseVisualStyleBackColor = true;
            BtSearch.Click += BtSearch_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 24);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 13;
            label2.Text = "Connection String";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(351, 73);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 17;
            label4.Text = "Subscription";
            // 
            // TxtSubscription
            // 
            TxtSubscription.Location = new Point(351, 89);
            TxtSubscription.Name = "TxtSubscription";
            TxtSubscription.Size = new Size(333, 23);
            TxtSubscription.TabIndex = 4;
            TxtSubscription.Leave += CbPrefix_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 73);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 19;
            label5.Text = "Topic";
            // 
            // TxtTopic
            // 
            TxtTopic.Location = new Point(12, 89);
            TxtTopic.Name = "TxtTopic";
            TxtTopic.Size = new Size(333, 23);
            TxtTopic.TabIndex = 3;
            TxtTopic.Leave += CbPrefix_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(351, 22);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 21;
            label3.Text = "Prefix";
            // 
            // CbPrefix
            // 
            CbPrefix.DropDownStyle = ComboBoxStyle.DropDownList;
            CbPrefix.FlatStyle = FlatStyle.Popup;
            CbPrefix.FormattingEnabled = true;
            CbPrefix.Location = new Point(351, 40);
            CbPrefix.Name = "CbPrefix";
            CbPrefix.Size = new Size(130, 23);
            CbPrefix.TabIndex = 1;
            CbPrefix.SelectedIndexChanged += CbPrefix_SelectedIndexChanged;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(775, 565);
            Controls.Add(label3);
            Controls.Add(CbPrefix);
            Controls.Add(label5);
            Controls.Add(TxtTopic);
            Controls.Add(label4);
            Controls.Add(TxtSubscription);
            Controls.Add(label2);
            Controls.Add(BtSearch);
            Controls.Add(label1);
            Controls.Add(CbOrderBy);
            Controls.Add(MenuStrip1);
            Controls.Add(TxtConnectionString);
            Controls.Add(TabControl);
            KeyPreview = true;
            MainMenuStrip = MenuStrip1;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Servicebus";
            Load += FrmMain_Load;
            TabControl.ResumeLayout(false);
            TabTopics.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GridTopics).EndInit();
            PopupTopics.ResumeLayout(false);
            TabSubscriptions.ResumeLayout(false);
            TabSubscriptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GridSubscriptions).EndInit();
            PopupSubscriptions.ResumeLayout(false);
            MenuStrip1.ResumeLayout(false);
            MenuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TabControl TabControl;
        private TabPage TabTopics;
        private TabPage TabSubscriptions;
        private DataGridView GridTopics;
        private Panel panel1;
        private Button BtSearch;
        private DataGridView GridSubscriptions;
        private ContextMenuStrip PopupTopics;
        private ToolStripMenuItem PopupTopicsPublishMessage;
        private ToolStripSeparator popupTopicsPurgeMessages;
        private ToolStripMenuItem PopUpTopicsPurgeActiveMessages;
        private ToolStripMenuItem PopUpTopicsPurgeDeadLetterMessages;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem PopUpTopicsDisableTopic;
        private ToolStripMenuItem PopUpTopicsDeleteTopic;
        private ContextMenuStrip PopupSubscriptions;
        private ToolStripMenuItem PopUpSubscriptionPurgeActiveMessages;
        private ToolStripMenuItem PopUpSubscriptionPurgeDeadLetterMessages;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem PopUpSubscriptionDisableSubscription;
        private ToolStripMenuItem PopUpSubscriptionDeleteSubscription;
        private Label lblSubscriptionTopicName;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem PopUpSubscriptionReceiveMessages;
        private TextBox TxtConnectionString;
        private MenuStrip MenuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem menuActions;
        private ComboBox CbOrderBy;
        private Label label1;
        private Button button1;
        private Label label2;
        private Label label4;
        private TextBox TxtSubscription;
        private Label label5;
        private TextBox TxtTopic;
        private Label label3;
        private ComboBox CbPrefix;
    }
}