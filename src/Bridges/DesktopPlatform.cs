using DesignPatternChallenge.Contracts;

namespace DesignPatternChallenge.Bridges;

public class DesktopPlatform : INotificationPlatform
{
    public void Render(string title, string content, string anexo)
    {
        Console.WriteLine($"[Desktop - Toast] Windows Notification: {anexo}");
        Console.WriteLine($"╔══════════════════════════╗");
        Console.WriteLine($"║ {title.PadRight(24)}     ║");
        Console.WriteLine($"║ {content.PadRight(24)}   ║");
        Console.WriteLine($"╚══════════════════════════╝");
    }
}