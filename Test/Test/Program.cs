using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 c1 = new Class1();
            Class2 c2 = new Class2();
            while (true) {
                Console.WriteLine("1-Create object,2-Method1,3-Method2,4-Create polymorph,5-Create Class2");
                int foulder= Int32.Parse(Console.ReadLine());
                if (foulder == 1)
                {
                    Console.WriteLine($"Enter size of array");
                    int foulder1 = Int32.Parse(Console.ReadLine());
                    c1.SetSize(foulder1);
                    Console.WriteLine($"Ready, array with size {c1.GetSize()} is created");
                }
                else if (foulder == 2)
                {
                    Console.WriteLine(c1.Method1());
                }
                else if (foulder == 3)
                {
                    Console.WriteLine(c1.Method2());
                }
                else if (foulder == 4)
                {
                    Console.WriteLine($"Enter size of array");
                    int foulder1 = Int32.Parse(Console.ReadLine());
                    c1 = new Class1(foulder1);
                    Console.WriteLine($"Ready, object with inner array with size {c1.GetSize()} is created");
                }
                else if (foulder == 5) {
                    Console.WriteLine($"Enter size of list");
                    int foulder1 = Int32.Parse(Console.ReadLine());
                    c2 = new Class2(foulder1);
                    Console.WriteLine($"Ready, object with inner list with size {c2.GetSize()} is created");
                    Console.WriteLine($"{c2[2]}");
                    c2[2] = 10;
                    Console.WriteLine($"{c2[2]}");
                }
            }
        }
    }
}
