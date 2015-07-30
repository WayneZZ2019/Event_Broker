using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyEventBroker
{
    public abstract class EventAttributes : Attribute
    {
        private string topic;

        protected EventAttributes(string topic)
        {
            this.topic = topic;
        }

        /// <summary>
        /// 事件主题标识
        /// </summary>
        public string Topic
        {
            get { return topic; }
        }

        /// <summary>
        /// 事件场景
        /// </summary>
        public EventScope EventScope { get; set; }
    }

    [AttributeUsage(AttributeTargets.Event, AllowMultiple = true)]
    public class EventPublicationAttribute : EventAttributes
    {
        public EventPublicationAttribute(string topic)
            : base(topic)
        {
        }
    }

    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public class EventSubscriptionAttribute : EventAttributes
    {
        public EventSubscriptionAttribute(string topic)
            : base(topic)
        {
        }
    }
}
