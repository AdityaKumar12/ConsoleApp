using ServiceLifetime.Interfaces;

namespace ServiceLifetime.Services
{
    public class TrasientService : ITrasientService
    {
        private Guid _guid { get; } = Guid.NewGuid();
        public Guid GetGuid()
        {
            return _guid;
        }
    }
}
