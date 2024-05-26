using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geolocate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "calculine";
            Console.Write("put a number in the range of 0-2,147,483,647:");
            Int32 A = Convert.ToInt32(Console.ReadLine());
            Console.Write("put Another number in the range of 0-2,147,483,647:");
            Int32 B = Convert.ToInt32(Console.ReadLine());
            Console.Write("A + B = "); Console.WriteLine(A + B);
            Console.Write("A - B = "); Console.WriteLine(A - B);
            Console.Write("A × B = "); Console.WriteLine(A * B);
            Console.Write("A ÷ B = "); Console.WriteLine(A / B);
            Console.Write("A ^ B = "); Console.WriteLine(Math.Pow(A, B));
            Console.Write("√A = "); Console.WriteLine(Math.Sqrt(A));
            Console.Write("√B = "); Console.WriteLine(Math.Sqrt(B));
            Console.Write("A % B = "); Console.WriteLine(A % B);
            Console.Write("press any key to exit");
            Console.ReadKey();

        }
    }
}
