// Class Struct Interace Delegate

namespace Acme.Collections;

class Program
{
    public static void Main()
    {
        // classes & objects
        var s = new Stack<int>();
        s.Push(1); // stack contains 1
        s.Push(10); // stack contains 1, 10
        s.Push(100); // stack contains 1, 10, 100
        Console.WriteLine(s.Pop()); // stack contains 1, 10
        Console.WriteLine(s.Pop()); // stack contains 1
        Console.WriteLine(s.Pop()); // stack is empty

        var p1 = new Point(0, 0);
        var p2 = new Point(10, 20);

        // Type Parameter
        var pair = new Pair<int, string>(1, "two");
        int i = pair.First;     //TFirst int
        string t = pair.Second; //TSecond string

        // Base classes
        Point a = new(10, 20);
        Point b = new Point3D(10, 20, 30);

        // interfaces
        EditBox editBox = new();
        IControl control = editBox;
        IDataBound dataBound = editBox;

        // enums
        var turnip = SomeRootVegetable.Turnip;
        var spring = Seasons.Spring;
        var startingOnEquinox = Seasons.Spring | Seasons.Autumn;
        var theYear = Seasons.All;
        Console.WriteLine(turnip);
        Console.WriteLine(spring);
        Console.WriteLine(startingOnEquinox);
        Console.WriteLine(theYear);

        // nullable
        int? optionalInt = default;
        optionalInt = 5;
        string? optionalText = default;
        optionalText = "Hello World.";
        Console.WriteLine(optionalInt + optionalText);

        // Tuples
        (double Sum, int Count) t2 = (4.5, 3);
        Console.WriteLine($"Sum of {t2.Count} elements is {t2.Sum}.");

        Entity.SetNextSerialNo(1000);
        Entity e1 = new();
        Entity e2 = new();
        Console.WriteLine(e1.GetSerialNo());          // Outputs "1000"
        Console.WriteLine(e2.GetSerialNo());          // Outputs "1001"
        Console.WriteLine(Entity.GetNextSerialNo());  // Outputs "1002"

        // CONATRUCTORS
        MyList<string> list1 = new();
        MyList<string> list2 = new(10);

        // PROPERTY
        MyList<string> names = new();
        names.Capacity = 100;   // Invokes set accessor
        int i2 = names.Count;    // Invokes get accessor
        int j2 = names.Capacity; // Invokes get accessor

        // INDEXERS
        MyList<string> names2 = new();
        names.Add("Liz");
        names.Add("Martha");
        names.Add("Beth");
        for (int i3 = 0; i < names.Count; i3++)
        {
            string s2 = names[i3];
            names[i3] = s2.ToUpper();
        }


        // ARRAYS

        int[] a4 = new int[10];
        for (int i4 = 0; i4 < a4.Length; i4++)
        {
            a4[i4] = i * i;
        }
        for (int i4 = 0; i4 < a4.Length; i4++)
        {
            Console.WriteLine($"a4[{i4}] = {a4[i4]}");
        }

    }

}