using Azure.Messaging.ServiceBus;
using Servicebus.Ui.WinForm.Model;

namespace Servicebus.Ui.WinForm
{
    public partial class FrmPublishMessage : Form
    {
        private readonly Data _data;
        private readonly Topic _topic;

        public FrmPublishMessage(Data data, Topic topic)
        {
            InitializeComponent();
            Text = $"{Text} {topic.FullName}";
            _data = data;
            _topic = topic;
        }

        private void frmPublishMessage_Load(object sender, EventArgs e)
        {
            LoadProperties();
        }

        private List<Property> GridProperties()
        {
            var list = new List<Property>();

            for (int i = 0; i < gridProperties.RowCount - 1; i++)
            {
                list.Add(new Property
                {
                    Key = gridProperties.Rows[i].Cells[0].Value.ToString(),
                    Value = gridProperties.Rows[i].Cells[1].Value.ToString(),
                });
            }
            return list;
        }

        private void SetMessageProperties(ServiceBusMessage serviceBusMessage)
        {
            serviceBusMessage.Subject = "From Servicebus C#";
            GridProperties().ForEach(p =>
            {
                serviceBusMessage.ApplicationProperties.Add(p.Key, p.Value);
            });
        }

        private void LoadProperties()
        {
            //var cbTypes = new DataGridViewComboBoxColumn();
            //cbTypes.HeaderText = "Type";
            //cbTypes.DataPropertyName = "Type";
            //cbTypes.Items.Add("String");
            //cbTypes.Items.Add("Boolean");
            //gridProperties.Columns.Add(cbTypes);

            gridProperties.Rows.Clear();
            _data.Properties.ForEach(p =>
            {
                gridProperties.Rows.Add(p.Key, p.Value);
            });
        }

        private async void btPublish_Click(object sender, EventArgs e)
        {
            try
            {
                btPublish.Enabled = false;
                await Publisher();
                MessageBox.Show($"Published ({txtQuantity.Text}x)");
            }
            finally
            {
                btPublish.Enabled = true;
            }
        }

        private async Task Publisher()
        {
            var payload = new ServiceBusMessage(txtPayload.Text);
            payload.ContentType = GetMessageFormat();

            SetMessageProperties(payload);
            var sbSender = ServiceBusClients.Client.CreateSender(_topic.FullName);

            var quantity = int.Parse(txtQuantity.Text);
            for (int i = 1; i <= quantity; i++)
            {
                await sbSender.SendMessageAsync(payload);
            }

            _data.Properties = GridProperties();
            _data.Save();
        }

        private string GetMessageFormat()
        {
            if (rbJson.Checked)
                return "application/json";
            if (rbXml.Checked)
                return "text/xml";
            if (rbText.Checked)
                return "text/plain";
            return null;
        }
    }
}
