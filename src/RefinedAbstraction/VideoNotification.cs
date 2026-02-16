using DesignPatternBridge.Abstraction;
using DesignPatternBridge.Implementor;

namespace DesignPatternBridge.RefinedAbstraction
{
    public class VideoNotification : Notification
    {
        private readonly string _title;
        private readonly string _content;
        private readonly string _videoUrl;

        public VideoNotification(INotification notification, string title, string content, string videoUrl)
            : base(notification)
        {
            _title = title;
            _content = content;
            _videoUrl = videoUrl;
        }

        public override void Send()
        {
            Console.WriteLine($"[Video Notification]");
            Console.WriteLine($"Video: {_videoUrl}");
            _notification.Render(_title, _content);
        }
    }
}