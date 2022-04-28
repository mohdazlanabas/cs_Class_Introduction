// Point is the Base Class of Point3D

namespace Acme.Collections
{
    public class Point3D : Point
    {
        public int Z { get; set; }

        public Point3D(int x, int y, int z) : base(x, y)
        {
            Z = z;
        }
    }
}
