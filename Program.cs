
using DesignPatternChallenge.Bridges;
using DesignPatternChallenge.Notification;

var plataforma = new WebPlatform();
var notificacao = new ImageNotification(plataforma, "aula01.mp4");

notificacao.Send("Nova Aula", "Assista agora ao conteúdo de Design Patterns.");
