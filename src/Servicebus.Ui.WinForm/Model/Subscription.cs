namespace Servicebus.Ui.WinForm.Model
{
    public class Subscription
    {
        public Subscription()
        {
                
        }

        public Subscription(string name, long activeMessageCount, long deadLetterMessageCount)
        {
            Name = name;
            ActiveMessageCount = activeMessageCount;
            DeadLetterMessageCount = deadLetterMessageCount;
        }

        public string Name { get; private set; }
        public long ActiveMessageCount { get; private set; }
        public long DeadLetterMessageCount { get; private set; }

        public void Update(Subscription subscription)
        {
            Name = subscription.Name;
            ActiveMessageCount = subscription.ActiveMessageCount;
            DeadLetterMessageCount = subscription.DeadLetterMessageCount;
        }

        public void DefineGrid(DataGridView grid)
        {
            grid.Columns[nameof(Name)].Width = 350;
            grid.Columns[nameof(Name)].HeaderText = "Subscription";

            grid.Columns[nameof(ActiveMessageCount)].Width = 120;
            grid.Columns[nameof(ActiveMessageCount)].HeaderText = "Active Messages";
            grid.Columns[nameof(ActiveMessageCount)].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            grid.Columns[nameof(DeadLetterMessageCount)].Width = 125;
            grid.Columns[nameof(DeadLetterMessageCount)].HeaderText = "D.Letter Messages";
            grid.Columns[nameof(DeadLetterMessageCount)].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
    }
}
