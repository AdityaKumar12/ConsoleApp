using ServiceLifetime.Interfaces;

namespace ServiceLifetime.Services
{
    public class ScopedService : IScopedService
    {
        private Guid _guid { get; } = Guid.NewGuid();
        public Guid GetGuid()
        {
            return _guid;
        }
    }
}
