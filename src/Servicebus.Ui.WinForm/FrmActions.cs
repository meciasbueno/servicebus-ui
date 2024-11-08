using Servicebus.Ui.WinForm.Model;
using System.Data;

namespace Servicebus.Ui.WinForm
{
    public partial class FrmActions : Form
    {
        private readonly List<Topic> _topics;

        public FrmActions(List<Topic> topics)
        {
            InitializeComponent();
            _topics = topics;
            if (topics != null)
                Text = $"Actions - {topics.Count} topics";
            else
                Text = $"Actions - 0 topics";
        }

        private async void btRemoveSubsWithActiveMsg_Click(object sender, EventArgs e)
        {
            ButtonEnableControl(sender, false);
            try
            {
                var minimumMessageCountToRemove = 2;
                foreach (var topic in _topics.Where(x => x.ActiveMessageCount >= minimumMessageCountToRemove))
                {
                    foreach (var sub in topic.Subscriptions.Where(x => x.ActiveMessageCount >= minimumMessageCountToRemove))
                    {
                        await ServiceBusClients.Admin.DeleteSubscriptionAsync(topic.FullName, sub.Name);
                    }
                }
                MessageBox.Show("Done");
            }
            finally
            {
                ButtonEnableControl(sender, true);
            }
        }

        private async void btPurgeDeadLetterAllTopics_Click(object sender, EventArgs e)
        {
            ButtonEnableControl(sender, false);
            try
            {
                foreach (var topic in _topics.Where(x => x.DeadLetterMessageCount > 0))
                {
                    await ServiceBusManagement.PurgeMessagesFromTopic(topic, true);
                }
                MessageBox.Show("Done");
            }
            finally
            {
                ButtonEnableControl(sender, true);
            }
        }

        private void ButtonEnableControl(object sender, bool enabled)
        {
            (sender as Button).Enabled = enabled;
        }
    }
}
