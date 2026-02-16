using DesignPatternBridge.Implementor;

namespace DesignPatternBridge.ConcreteImplementation
{
    public class MobileNotification : INotification
    {
        public void Render(string title, string content)
        {
            Console.WriteLine($"[Mobile - Native] Push Notification:");
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Body: {content}");
            Console.WriteLine($"Icon: notification_icon.png");
        }
    }
}