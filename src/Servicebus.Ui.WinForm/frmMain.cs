using Servicebus.Ui.WinForm.Model;
using Azure.Messaging.ServiceBus.Administration;
using Servicebus.Ui.WinForm.Enums;

namespace Servicebus.Ui.WinForm
{
    public partial class FrmMain : Form
    {
        private List<Topic> Topics => GridTopics.DataSource as List<Topic>;
        private List<Subscription> Subscriptions => GridSubscriptions.DataSource as List<Subscription>;

        private Topic _selectedTopic = null;
        private Subscription _selectedSubscription = null;
        private Data _data = new();
        
        private readonly Filter _filter = new();

        public FrmMain()
        {
            InitializeComponent();
        }

        private async void FrmMain_Load(object sender, EventArgs e)
        {
            _data = _data.Get();
            UpdateTitleStatus("");
            LoadOrderByCombo();
            await LoadData();
        }

        private void LoadOrderByCombo()
        {
            CbOrderBy.Items.Clear();
            foreach (TopicOrder topicOrder in Enum.GetValues(typeof(TopicOrder)))
            {
                CbOrderBy.Items.Add(topicOrder.ToString());
            }
            CbOrderBy.SelectedIndex = (int)TopicOrder.NameAsc;
        }

        private void UpdateTitleStatus(string text)
        {
            Text = "ServiceBus";
            if (!string.IsNullOrEmpty(text))
                Text = $"{text}...";
        }


        private async Task LoadData()
        {
            if (ServiceBusClients.Client is null) return;

            BtSearch.Enabled = false;
            try
            {
                await LoadTopics();
            }
            finally
            {
                BtSearch.Enabled = true;
            }
        }

        private async Task LoadTopics()
        {
            UpdateTitleStatus("Loading all topics");
            try
            {
                CbPrefix.Items.Clear();
                await ServiceBusManagement.LoadTopicsFromAzure();
                LoadGridTopics();
                LoadPrefixCombo();
                new Topic().DefineGrid(GridTopics);
            }
            finally
            {
                UpdateTitleStatus("");
            }
        }

        private void LoadGridTopics()
        {
            if (GridTopics.DataSource is not null && !_filter.FilterIsModified) return;
            GridTopics.DataSource = ServiceBusManagement.GetTopics(_filter);
            UpdateTopicsCount();
        }

        private void CbPrefix_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Topics is null) return;

            _filter.TopicPrefix = CbPrefix.Text;
            _filter.TopicName = TxtTopic.Text;
            _filter.SubscriptionName = TxtSubscription.Text;
            _filter.TopicOrder = (TopicOrder)CbOrderBy.SelectedIndex;
            LoadGridTopics();
        }

        private void CbOrderBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Topics is null) return;
            LoadGridTopics();
        }

        private void UpdateTopicsCount()
        {
            TabTopics.Text = $"Topics ({Topics.Count()})";
        }

        private void LoadPrefixCombo()
        {
            CbPrefix.Items.Clear();
            CbPrefix.Items.Add("");

            ServiceBusManagement.GetPrefixList().ForEach(x =>
            {
                CbPrefix.Items.Add(x);
            });
            CbPrefix.SelectedIndex = 0;
        }

        private async Task LoadTopic(string name)
        {
            UpdateTitleStatus($"Loading [{name}]");
            try
            {
                var topics = Topics;
                var topic = topics.FirstOrDefault(x => x.FullName == name);

                var updatedTopic = await ServiceBusManagement.LoadTopicFromAzure(name, _filter);

                topic.Update(updatedTopic);

                GridTopics.DataSource = topics;

                new Topic().DefineGrid(GridTopics);
                GridTopics.Refresh();
            }
            finally
            {
                UpdateTitleStatus("");
            }
        }

        private async Task LoadSubscription(string topicName, string subscriptionName)
        {
            UpdateTitleStatus($"Loading [{subscriptionName}]");
            try
            {
                var subscriptions = Subscriptions;
                var subscription = subscriptions.FirstOrDefault(x => x.Name == subscriptionName);

                var updatedSubscription = await ServiceBusManagement.LoadSubscription(topicName, subscriptionName);

                subscription.Update(updatedSubscription);

                GridSubscriptions.DataSource = subscriptions;

                new Subscription().DefineGrid(GridSubscriptions);
                GridSubscriptions.Refresh();
            }
            finally
            {
                UpdateTitleStatus("");
            }
        }

        private void LoadSubscriptionsFromTopic(Topic topic)
        {
            if (topic == null) return;
            GridSubscriptions.DataSource = topic.Subscriptions;
            new Subscription().DefineGrid(GridSubscriptions);
            UpdateSubscriptionTabTitle(topic.Subscriptions.Count());
        }

        private void UpdateSubscriptionTabTitle(int sbtsCount)
        {
            if (_selectedTopic is null) return;
            lblSubscriptionTopicName.Text = $"Topic: {_selectedTopic.FullName}";
            TabSubscriptions.Text = "Subscriptions";
            if (sbtsCount > 0)
                TabSubscriptions.Text += $" ({sbtsCount})";
        }

        private void TabControl_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage == TabSubscriptions)
                LoadSubscriptionsFromTopic(_selectedTopic);
            else
                UpdateSubscriptionTabTitle(0);
        }

        private void GridTopics_SelectionChanged(object sender, EventArgs e)
        {
            var rowIndex = GridTopics.CurrentCell.RowIndex;
            var topicName = GridTopics.Rows[rowIndex].Cells["FullName"].Value.ToString();
            _selectedTopic = Topics.FirstOrDefault(x => x.FullName == topicName);
        }

        private void GridSubscriptions_SelectionChanged(object sender, EventArgs e)
        {
            var rowIndex = GridSubscriptions.CurrentCell.RowIndex;
            var sbtsName = GridSubscriptions.Rows[rowIndex].Cells["Name"].Value.ToString();
            _selectedSubscription = Subscriptions.FirstOrDefault(x => x.Name == sbtsName);
        }

        private void GridTopics_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TabControl.SelectedTab = TabSubscriptions;
        }

        private void PopupTopicsPublishMessage_Click(object sender, EventArgs e)
        {
            var form = new FrmPublishMessage(_data, _selectedTopic);
            form.Show();
        }

        private async void PopUpTopicsPurgeActiveMessages_Click(object sender, EventArgs e)
        {
            try
            {
                var topicName = _selectedTopic.FullName;
                UpdateTitleStatus($"Purging Active Messages from [{topicName}]");
                await ServiceBusManagement.PurgeMessagesFromTopic(_selectedTopic, false);
                await LoadTopic(topicName);
            }
            finally
            {
                UpdateTitleStatus("");
            }
        }

        private async void PopUpTopicsPurgeDeadLetterMessages_Click(object sender, EventArgs e)
        {
            try
            {
                var topicName = _selectedTopic.FullName;
                UpdateTitleStatus($"Purging Dead Letter messages from [{topicName}]");
                await ServiceBusManagement.PurgeMessagesFromTopic(_selectedTopic, true);
                await LoadTopic(topicName);
            }
            finally
            {
                UpdateTitleStatus("");
            }
        }

        private async void PopUpTopicsDisableTopic_Click(object sender, EventArgs e)
        {
            try
            {
                var topicName = _selectedTopic.FullName;
                UpdateTitleStatus($"Changing topic status [{topicName}]");
                var topic = await ServiceBusClients.Admin.GetTopicAsync(topicName);
                topic.Value.Status = topic.Value.Status == EntityStatus.Disabled ? EntityStatus.Active : EntityStatus.Disabled;
                await ServiceBusClients.Admin.UpdateTopicAsync(topic.Value);
                await LoadTopic(topicName);
            }
            finally
            {
                UpdateTitleStatus("");
            }
        }

        private async void PopUpTopicsDeleteTopic_ClickAsync(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            try
            {
                var topicName = _selectedTopic.FullName;
                UpdateTitleStatus($"Deleting topic [{topicName}]");
                await ServiceBusClients.Admin.DeleteTopicAsync(topicName);
                await LoadTopics();
            }
            finally
            {
                UpdateTitleStatus("");
            }
        }

        private async void PopUpSubscriptionPurgeActiveMessages_Click(object sender, EventArgs e)
        {
            try
            {
                var sbtsName = _selectedSubscription.Name;
                UpdateTitleStatus($"Purging Active Messages from [{sbtsName}]");
                await ServiceBusManagement.PurgeMessagesFromSubscription(_selectedTopic.FullName, sbtsName, false);
                await LoadTopic(_selectedTopic.FullName);
                LoadSubscriptionsFromTopic(_selectedTopic);
            }
            finally
            {
                UpdateTitleStatus("");
            }
        }

        private async void PopUpSubscriptionPurgeDeadLetterMessages_Click(object sender, EventArgs e)
        {
            try
            {
                var sbtsName = _selectedSubscription.Name;
                UpdateTitleStatus($"Purging Dead Letter Messages from [{sbtsName}]");
                await ServiceBusManagement.PurgeMessagesFromSubscription(_selectedTopic.FullName, sbtsName, true);
                await LoadTopic(_selectedTopic.FullName);
                LoadSubscriptionsFromTopic(_selectedTopic);
            }
            finally
            {
                UpdateTitleStatus("");
            }
        }

        private async void PopUpSubscriptionDeleteSubscription_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            try
            {
                var sbtsName = _selectedSubscription.Name;
                UpdateTitleStatus($"Deleting subscription [{sbtsName}]");
                await ServiceBusClients.Admin.DeleteSubscriptionAsync(_selectedTopic.FullName, sbtsName);
                await LoadTopic(_selectedTopic.FullName);
                LoadSubscriptionsFromTopic(_selectedTopic);
            }
            finally
            {
                UpdateTitleStatus("");
            }
        }

        private async void PopUpSubscriptionDisableSubscription_Click(object sender, EventArgs e)
        {
            try
            {
                var sbts = _selectedSubscription.Name;
                UpdateTitleStatus($"Changing subscription status [{sbts}]");
                var sub = await ServiceBusClients.Admin.GetSubscriptionAsync(_selectedTopic.FullName, sbts);
                sub.Value.Status = sub.Value.Status == EntityStatus.Disabled ? EntityStatus.Active : EntityStatus.Disabled;
                await ServiceBusClients.Admin.UpdateSubscriptionAsync(sub.Value);
                await LoadTopic(_selectedTopic.FullName);
                LoadSubscriptionsFromTopic(_selectedTopic);
            }
            finally
            {
                UpdateTitleStatus("");
            }
        }

        private async void GridTopics_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                if (_selectedTopic == null) return;
                await LoadTopic(_selectedTopic.FullName);
            }
        }

        private async void GridSubscriptions_KeyDownAsync(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                if (_selectedTopic == null) return;
                await LoadSubscription(_selectedTopic.FullName, _selectedSubscription.Name);
            }
        }

        private void PopUpSubscriptionReceiveMessages_Click(object sender, EventArgs e)
        {
            ReceiveMessages();
        }
        private void GridSubscriptions_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ReceiveMessages();
        }

        private void ReceiveMessages()
        {
            var form = new FrmMessage(_selectedTopic.FullName, _selectedSubscription);
            form.Show();
        }

        private void TxtConnectionString_Leave(object sender, EventArgs e)
        {
            ServiceBusClients.SetConnection(TxtConnectionString.Text);
        }

        private void MenuActions_Click(object sender, EventArgs e)
        {
            var form = new FrmActions(Topics);
            form.Show();
        }

        private async void BtSearch_Click(object sender, EventArgs e)
        {
            await LoadData();
        }
    }
}