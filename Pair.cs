// Type Parameters
// TFirst and TSecond is Pair

namespace Acme.Collections
{
    public class Pair<TFirst, TSecond>
    {
        public TFirst First { get; }
        public TSecond Second { get; }
        public Pair(TFirst first, TSecond second) =>
            (First, Second) = (first, second);
    }
}
