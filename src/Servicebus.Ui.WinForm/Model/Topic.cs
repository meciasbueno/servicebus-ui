namespace Servicebus.Ui.WinForm.Model
{
    public class Topic
    {
        public Topic()
        {
                
        }
        public Topic(string fullName)
        {
            FullName = fullName;

            if (FullName.Split("/").Length > 1)
            {
                Prefix = FullName.Split("/")[0];
                ShortName = FullName.Split("/")[1];
            }
            else
                ShortName = FullName;
        }

        public string Prefix { get; private set; }
        public string FullName { get; private set; }
        public string ShortName { get; private set; }
        public List<Subscription> Subscriptions { get; private set; } = new List<Subscription>();
        public int SubscriptionCount => Subscriptions.Count();
        public long ActiveMessageCount => Subscriptions.Sum(x=> x.ActiveMessageCount);
        public long DeadLetterMessageCount => Subscriptions.Sum(x=> x.DeadLetterMessageCount);

        public void Update(Topic topic)
        {
            FullName = topic.FullName;
            Subscriptions = topic.Subscriptions;
        }


        public void AddSubscription(string subscriptionName, long activeMessageCount, long deadLetterMessageCount)
        {
            Subscriptions.Add(new Subscription(subscriptionName, activeMessageCount, deadLetterMessageCount));
        }

        public void DefineGrid(DataGridView grid)
        {
            grid.Columns[nameof(Prefix)].Width = 105;
            grid.Columns[nameof(Prefix)].HeaderText = "Prefix";

            grid.Columns[nameof(FullName)].Visible = false;

            grid.Columns[nameof(ShortName)].Width = 300;
            grid.Columns[nameof(ShortName)].HeaderText = "Topic";

            grid.Columns[nameof(SubscriptionCount)].Width = 85;
            grid.Columns[nameof(SubscriptionCount)].HeaderText = "Subscriptions";
            grid.Columns[nameof(SubscriptionCount)].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            grid.Columns[nameof(ActiveMessageCount)].Width = 119;
            grid.Columns[nameof(ActiveMessageCount)].SortMode = DataGridViewColumnSortMode.Automatic;
            grid.Columns[nameof(ActiveMessageCount)].HeaderText = "Active Messages";
            grid.Columns[nameof(ActiveMessageCount)].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            grid.Columns[nameof(DeadLetterMessageCount)].Width = 125;
            grid.Columns[nameof(DeadLetterMessageCount)].HeaderText = "D.Letter Messages";
            grid.Columns[nameof(DeadLetterMessageCount)].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
    }
}
