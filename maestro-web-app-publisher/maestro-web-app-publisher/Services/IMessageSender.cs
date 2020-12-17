using maestro_web_app_publisher.Models;

namespace maestro_web_app_publisher.Services
{
    public interface IMessageSender
    {
        void SendMessage(Message message);
    }
}
