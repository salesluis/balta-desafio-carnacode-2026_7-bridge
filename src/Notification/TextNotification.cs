using DesignPatternChallenge.Contracts;

namespace DesignPatternChallenge.Notification;

public class TextNotification(INotificationPlatform platform) : Bridges.Notification(platform)
{
    public override void Send(string titulo, string mensagem)
    {
        _platform.Render(titulo, mensagem);
    }
}