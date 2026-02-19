using DesignPatternChallenge.Contracts;

namespace DesignPatternChallenge.Notification;

public class VideoNotification(INotificationPlatform platform, string videoUrl) : Bridges.Notification(platform)
{
    public override void Send(string titulo, string mensagem)
    {
        _platform.Render(titulo, mensagem, videoUrl);        
    }
}