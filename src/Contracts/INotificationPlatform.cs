namespace DesignPatternChallenge.Contracts;

public interface INotificationPlatform
{
    void Render(string title, string content, string anexo = "");
}