using DesignPatternBridge.Implementor;

namespace DesignPatternBridge.Abstraction
{
    public abstract class Notification
    {
        protected readonly INotification _notification;

        public Notification(INotification notification)
        {
            _notification = notification;
        }

        public abstract void Send();
    }
}
