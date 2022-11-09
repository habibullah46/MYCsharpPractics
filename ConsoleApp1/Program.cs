using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valueone ;
            valueone =Convert.ToInt32( Console.ReadLine());
            int valuetwo = 9;
            int answer = valueone+ valuetwo;
            Console.WriteLine("answer"+answer);
            Console.Read();
        }
    }
}
