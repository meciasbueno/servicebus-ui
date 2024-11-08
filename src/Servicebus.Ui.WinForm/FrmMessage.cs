using Servicebus.Ui.WinForm.Model;

namespace Servicebus.Ui.WinForm
{
    public partial class FrmMessage : Form
    {
        private readonly string _topicName;
        private readonly Subscription _subscription;

        public FrmMessage(string topicName, Subscription subscription)
        {
            InitializeComponent();
            _topicName = topicName;
            _subscription = subscription;
            Text = $"{Text} - {topicName}";
        }

        private async void FrmMessage_Load(object sender, EventArgs e)
        {
            await LoadMessages();
        }

        private async Task LoadMessages()
        {
            var messages = await ServiceBusMessages.ReceiveMessage(_topicName, _subscription.Name, int.Parse(txtQuantity.Text), rbDeadLetterMessages.Checked);
            gridMessages.DataSource = messages;
            new SbMessage().DefineGrid(gridMessages);
        }
    }
}
