namespace PenaticCore.Infrastructure.Utils
{
    public class IdGenerator
    {
        private static long _lastId = DateTime.UtcNow.Ticks;
        public static long GetNextId() => Interlocked.Increment(ref _lastId);
    }
}
