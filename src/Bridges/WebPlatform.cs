using DesignPatternChallenge.Contracts;

namespace DesignPatternChallenge.Bridges;

public class WebPlatform :  INotificationPlatform
{
    public void Render(string title, string content, string anexo)
    { 
        Console.WriteLine($"[Web - HTML] <div class='notification'>");
        Console.WriteLine($"  <h3>{title}</h3>");
        Console.WriteLine($"  <p>{content}</p>");
        Console.WriteLine("</div>");
    }
}