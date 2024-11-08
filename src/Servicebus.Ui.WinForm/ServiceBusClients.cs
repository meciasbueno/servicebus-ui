using Azure.Messaging.ServiceBus.Administration;

namespace Servicebus.Ui.WinForm
{
    public static class ServiceBusClients
    {
        public static void SetConnection(string connectionString)
        {
            var hasText = !string.IsNullOrEmpty(connectionString);
            Client = hasText ? new Azure.Messaging.ServiceBus.ServiceBusClient(connectionString) : null;
            Admin = hasText ? new ServiceBusAdministrationClient(connectionString) : null;
        }

        public static Azure.Messaging.ServiceBus.ServiceBusClient Client { get; private set; } = null;
        public static ServiceBusAdministrationClient Admin { get; private set; } = null;
    }
}
