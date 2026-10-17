using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_uygulamalar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter the values of X and Y to calculate the expressions 3x+4y.");   
            
            Console.Write("Enter the value of variable X: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the value of veriable Y: ");
            double y=Convert.ToDouble(Console.ReadLine());

            double sonuc = 3 * x + 4 * y;
            Console.WriteLine($"The result of the equation 3x+4y: {result}");
            Console.ReadKey();
        }
    }
} 
