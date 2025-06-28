using ServiceLifetime.Interfaces;

namespace ServiceLifetime.Services
{
    public class SingletonService : ISingletonService
    {
        private Guid _guid { get; } =  Guid.NewGuid();
        public Guid GetGuid()
        {
            return _guid;
        }
    }
}
