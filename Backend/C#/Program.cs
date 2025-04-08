using System;
using System.Runtime.InteropServices;

class Program
{
    [DllImport("CppLibrary.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern int add(int a, int b);

    static void Main()
    {
        int tulos = add(3, 4);
        Console.WriteLine($"3 + 4 = {tulos}");
    }
}
