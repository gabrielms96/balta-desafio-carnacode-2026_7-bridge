using DesignPatternBridge.ConcreteImplementation;
using DesignPatternBridge.RefinedAbstraction;

namespace DesignPatternBridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Bridge Pattern - Notificações Multi-Plataforma ===\n");

            // Texto para Web
            var textWeb = new TextNotification(new WebNotification(), "Novo Pedido", "Você tem um novo pedido");
            textWeb.Send();
            Console.WriteLine();

            // Texto para Mobile
            var textMobile = new TextNotification(new MobileNotification(), "Novo Pedido", "Você tem um novo pedido");
            textMobile.Send();
            Console.WriteLine();

            // Imagem para Web
            var imageWeb = new ImageNotification(
                new WebNotification(),
                "Promoção",
                "50% de desconto!",
                "promo.jpg"
            );
            imageWeb.Send();
            Console.WriteLine();

            // Vídeo para Mobile
            var videoMobile = new VideoNotification(
                new MobileNotification(),
                "Tutorial",
                "Aprenda a usar o app",
                "tutorial.mp4"
            );
            videoMobile.Send();
            Console.WriteLine();
        }
    }
}