// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// ARRAYS

int[] a = new int[10];
for (int i = 0; i < a.Length; i++)
{
    a[i] = i * i;
}
for (int i = 0; i < a.Length; i++)
{
    Console.WriteLine($"a[{i}] = {a[i]}");
}

int[] a1 = new int[10];
int[,] a2 = new int[10, 5];
int[,,] a3 = new int[10, 5, 2];

int[][] a4 = new int[3][];
a4[0] = new int[10];
a4[1] = new int[5];
a4[2] = new int[20];

int[] a5 = new int[] { 1, 2, 3 };

int[] a6 = { 1, 2, 3 };

int[] t = new int[3];
t[0] = 1;
t[1] = 2;
t[2] = 3;
int[] a7 = t;

foreach (int item in a)
{
    Console.WriteLine(item);
}
