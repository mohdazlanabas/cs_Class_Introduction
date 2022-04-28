// Struct

namespace Acme.Collections
{
    public struct Point2
    {
        public double X2 { get; }
        public double Y2 { get; }

        public Point2(double x2, double y2) => (X2, Y2) = (x2, y2);
    }
}
