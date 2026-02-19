using DesignPatternChallenge.Contracts;

namespace DesignPatternChallenge.Notification;

public class ImageNotification(INotificationPlatform platform, string imageUrl) : Bridges.Notification(platform)
{
    public override void Send(string titulo, string mensagem)
    {
        _platform.Render(titulo, mensagem, imageUrl);
    }
}