using Azure.Messaging.ServiceBus;
using Servicebus.Ui.WinForm.Enums;
using Servicebus.Ui.WinForm.Model;

namespace Servicebus.Ui.WinForm
{
    public static class ServiceBusManagement
    {
        private static readonly List<Topic> _allTopics = new();
        
        public static async Task LoadTopicsFromAzure()
        {
            var azureTopics = ServiceBusClients.Admin.GetTopicsAsync();
            await foreach (var sbt in azureTopics)
            {
                var topic = new Topic(sbt.Name);
                await LoadSubscriptionsFromAzure(topic, new Filter());
                _allTopics.Add(topic);
            }
        }

        public static List<Topic> GetTopics(Filter filter)
        {
            var filteredTopics = filter.GetFilteredTopics(_allTopics);

            return filter.TopicOrder switch
            {
                TopicOrder.NameAsc => filteredTopics.OrderBy(x => x.FullName).ToList(),
                TopicOrder.ActiveMessageCountDesc => filteredTopics.OrderByDescending(x => x.ActiveMessageCount).ToList(),
                TopicOrder.DeadLetterMessageCountDesc => filteredTopics.OrderByDescending(x => x.DeadLetterMessageCount).ToList(),
                TopicOrder.SubscriptionCountDesc => filteredTopics.OrderByDescending(x => x.SubscriptionCount).ToList(),
                _ => filteredTopics.ToList(),
            };
        }

        public static List<string> GetPrefixList() =>
            _allTopics.DistinctBy(x => x.Prefix).Select(x=> x.Prefix).ToList();

        public static async Task<Topic> LoadTopicFromAzure(string name, Filter filter)
        {
            var topic = new Topic(name);
            await LoadSubscriptionsFromAzure(topic, filter);
            return topic;
        }

        public static async Task LoadSubscriptionsFromAzure(Topic topic, Filter filter)
        {
            var subscriptions = ServiceBusClients.Admin.GetSubscriptionsRuntimePropertiesAsync(topic.FullName);
            await foreach (var sbts in subscriptions)
            {
                if (!string.IsNullOrEmpty(filter.SubscriptionName))
                {
                    if (sbts.SubscriptionName.Contains(filter.SubscriptionName, StringComparison.OrdinalIgnoreCase))
                        topic.AddSubscription(sbts.SubscriptionName, sbts.ActiveMessageCount, sbts.DeadLetterMessageCount);
                }
                else
                    topic.AddSubscription(sbts.SubscriptionName, sbts.ActiveMessageCount, sbts.DeadLetterMessageCount);
            }
        }

        public static async Task<Subscription> LoadSubscription(string topicName, string subscriptionName)
        {
            var sbts = await ServiceBusClients.Admin.GetSubscriptionRuntimePropertiesAsync(topicName, subscriptionName);
            return new Subscription(subscriptionName, sbts.Value.ActiveMessageCount, sbts.Value.DeadLetterMessageCount);
        }

        public static async Task PurgeMessagesFromTopic(Topic topic, bool onlyDeadLetterMessages)
        {
            foreach (var sbts in topic.Subscriptions)
            {
                await PurgeMessagesFromSubscription(topic.FullName, sbts.Name, onlyDeadLetterMessages);
            }
        }

        public static async Task PurgeMessagesFromSubscription(string topicName, string subscriptionName, bool onlyDeadLetterMessages)
        {
            var option = new ServiceBusReceiverOptions
            {
                ReceiveMode = ServiceBusReceiveMode.ReceiveAndDelete,
                SubQueue = onlyDeadLetterMessages ? SubQueue.DeadLetter : SubQueue.None,
            };

            var receiver = ServiceBusClients.Client.CreateReceiver(topicName, subscriptionName, option);
            var sbts = await ServiceBusClients.Admin.GetSubscriptionRuntimePropertiesAsync(topicName, subscriptionName);

            var messagesCount = onlyDeadLetterMessages ? sbts.Value.DeadLetterMessageCount : sbts.Value.ActiveMessageCount;

            for (int i = 1; i <= messagesCount; i++)
            {
                await receiver.ReceiveMessageAsync();
            }
        }
    }
}
