using Servicebus.Ui.WinForm.Enums;

namespace Servicebus.Ui.WinForm.Model
{
    public class Filter
    {
        private string _lastStringFilter = string.Empty;

        public string TopicPrefix { get; set; }
        public string TopicName { get; set; }
        public string SubscriptionName { get; set; }
        public TopicOrder TopicOrder { get; set; }

        public List<Topic> GetFilteredTopics(List<Topic> allTopics)
        {
            IEnumerable<Topic> filteredTopics = allTopics;
            
            if (!string.IsNullOrEmpty(TopicPrefix))
                filteredTopics = filteredTopics.Where(x => x.Prefix == TopicPrefix);
            if (!string.IsNullOrEmpty(TopicName))
                filteredTopics = filteredTopics.Where(t=> t.ShortName.Contains(TopicName, StringComparison.OrdinalIgnoreCase));
            if (!string.IsNullOrEmpty(SubscriptionName))
            {
                filteredTopics = filteredTopics.Where(t => t.Subscriptions.Any(s => s.Name.Contains(SubscriptionName, StringComparison.OrdinalIgnoreCase)));
                filteredTopics.ToList().ForEach(sbt =>
                {
                    sbt.Subscriptions.Where(s => !s.Name.Contains(SubscriptionName, StringComparison.OrdinalIgnoreCase)).ToList().ForEach(sbts =>
                    {
                        sbt.Subscriptions.Remove(sbts);
                    });
                });
            }
            _lastStringFilter = FilterToString();

            return filteredTopics.ToList();
        }

        private string FilterToString() =>
            $"{TopicPrefix}|{TopicName}|{SubscriptionName}|{TopicOrder}";

        public bool FilterIsModified => _lastStringFilter != FilterToString();

    }
}
