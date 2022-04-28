namespace Acme.Collections
{
    public class Color
    // FIelds
    {
        public static readonly Color Black = new(0, 0, 0); // OBJECT
        public static readonly Color White = new(255, 255, 255);
        public static readonly Color Red = new(255, 0, 0);
        public static readonly Color Green = new(0, 255, 0);
        public static readonly Color Blue = new(0, 0, 255);

        public byte R;
        public byte G;
        public byte B;

        public Color(byte r, byte g, byte b)
        {
            R = r;
            G = g;
            B = b;
        }

        // PARAMETERS
        static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        public static void SwapExample()
        {
            int i = 1, j = 2;
            Swap(ref i, ref j);
            Console.WriteLine($"{i} {j}");    // "2 1"
        }

        static void Divide(int x, int y, out int result, out int remainder)
        {
            result = x / y;
            remainder = x % y;
        }

        public static void OutUsage()
        {
            Divide(10, 3, out int res, out int rem);
            Console.WriteLine($"{res} {rem}");  // "3 1"
        }

        public class Console
        {
            public static void Write(string fmt, params object[] args) { }
            public static void WriteLine(string fmt, params object[] args) { }
            // ...
        }

        static void Placeholder()
        {
            int x = 3, y = 4, z = 5;

            string s = "x={0} y={1} z={2}";
            object[] args = new object[3];
            args[0] = x;
            args[1] = y;
            args[2] = z;
            Console.WriteLine(s, args);
        }

        public static void WriteSquares()
        // Method Bpdy Local Variable
        {
            int i = 0;
            int j;
            while (i < 10)
            {
                j = i * i;
                Console.WriteLine($"{i} x {i} = {j}");
                i++;
            }
        }

    }
}
