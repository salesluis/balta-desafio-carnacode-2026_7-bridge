using DesignPatternChallenge.Contracts;

namespace DesignPatternChallenge.Bridges;

public class ModilePlatform : INotificationPlatform
{
    public void Render(string title, string content, string anexo)
    {
        Console.WriteLine($"[Mobile - Native] Push Notification: {anexo}");
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Body: {content}");
        Console.WriteLine($"Icon: notification_icon.png");
    }
}