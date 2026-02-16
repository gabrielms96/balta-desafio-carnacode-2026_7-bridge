using DesignPatternBridge.Implementor;

namespace DesignPatternBridge.ConcreteImplementation
{
    public class WebNotification : INotification
    {
        public void Render(string title, string content)
        {
            Console.WriteLine($"[Web - HTML] <div class='notification'>");
            Console.WriteLine($"  <h3>{title}</h3>");
            Console.WriteLine($"  <p>{content}</p>");
            Console.WriteLine("</div>");
        }
    }
}