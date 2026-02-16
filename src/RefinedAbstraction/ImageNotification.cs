using DesignPatternBridge.Abstraction;
using DesignPatternBridge.Implementor;

namespace DesignPatternBridge.RefinedAbstraction
{
    public class ImageNotification : Notification
    {
        private readonly string _title;
        private readonly string _content;
        private readonly string _imageUrl;

        public ImageNotification(INotification notification, string title, string content, string imageUrl)
            : base(notification)
        {
            _title = title;
            _content = content;
            _imageUrl = imageUrl;
        }

        public override void Send()
        {
            Console.WriteLine($"[Image Notification]");
            Console.WriteLine($"Image: {_imageUrl}");
            _notification.Render(_title, _content);
        }
    }
}