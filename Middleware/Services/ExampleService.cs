using Middleware.Interfaces;

namespace Middleware.Services
{
    public class ExampleService : IExampleService
    {
        private Guid _guid { get; } = Guid.NewGuid();
        public string GetGuid()
        {
            return _guid.ToString();
        }
    }
}
