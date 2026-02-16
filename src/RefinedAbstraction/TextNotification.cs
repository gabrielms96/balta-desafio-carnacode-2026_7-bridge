using DesignPatternBridge.Abstraction;
using DesignPatternBridge.Implementor;

namespace DesignPatternBridge.RefinedAbstraction
{
    public class TextNotification : Notification
    {
        private readonly string _title;
        private readonly string _content;

        public TextNotification(INotification notification, string title, string content)
            : base(notification)
        {
            _title = title;
            _content = content;
        }

        public override void Send()
        {
            _notification.Render(_title, _content);
        }
    }
}