using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double k= Convert.ToDouble(Console.ReadLine()); 
            double b= Convert.ToDouble(Console.ReadLine()); 
           
            Linear linear = new Linear (k, b);
            Console.WriteLine(linear.Root());
            Console.ReadKey();
        }
        
    }
}
