using DesignPatternChallenge.Contracts;

namespace DesignPatternChallenge.Bridges;

public abstract class Notification
{
    protected INotificationPlatform _platform;
    
    protected  Notification(INotificationPlatform platform)
    {
        _platform = platform;
    }
    
    public abstract void Send(string titulo, string mensagem);
}