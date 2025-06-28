using DependencyInjection.Interfaces;

namespace DependencyInjection.Services
{
    public class MessageService : IMessageService
    {
        public string PrintMessage()
        {
            return "Hello world";
        }
    }
}
