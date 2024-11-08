using Azure.Messaging.ServiceBus;
using Servicebus.Ui.WinForm.Model;

namespace Servicebus.Ui.WinForm
{
    public static class ServiceBusMessages
    {
        public static async Task<List<SbMessage>> ReceiveMessage(string topicName, string subscriptionName, long messageCountToReceive, bool onlyDeadLetterMessages)
        {
            var option = new ServiceBusReceiverOptions
            {
                ReceiveMode = ServiceBusReceiveMode.PeekLock,
                SubQueue = onlyDeadLetterMessages ? SubQueue.DeadLetter : SubQueue.None,
            };
                
            var receiver = ServiceBusClients.Client.CreateReceiver(topicName, subscriptionName, option);
            var sbts = await ServiceBusClients.Admin.GetSubscriptionRuntimePropertiesAsync(topicName, subscriptionName);

            var messagesExists = onlyDeadLetterMessages ? sbts.Value.DeadLetterMessageCount : sbts.Value.ActiveMessageCount;
            messageCountToReceive = messageCountToReceive > messagesExists ? messagesExists : messageCountToReceive;

            var messages = new List<SbMessage>();

            for (int i = 1; i <= messageCountToReceive; i++)
            {
                var receivedMessage = await receiver.ReceiveMessageAsync();
                try
                {
                    var properties = new List<Property>();
                    receivedMessage.ApplicationProperties.ToList().ForEach(p =>
                    {
                        properties.Add(new Property { Key = p.Key, Value = p.Value.ToString() });
                    });

                    messages.Add(new SbMessage
                    {
                        Body = receivedMessage.Body.ToString(),
                        Label = receivedMessage.Subject,
                        Sequence = receivedMessage.SequenceNumber,
                        EnqueuedTime = receivedMessage.EnqueuedTime,
                        ExpiresAt = receivedMessage.ExpiresAt,
                        Properties = properties
                    });
                }
                finally
                {
                    await receiver.AbandonMessageAsync(receivedMessage);
                }
            }
            return messages;
        }
    }
}