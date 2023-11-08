using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num;
            Console.WriteLine("enter  value");
            num = int.Parse(Console.ReadLine());


            if(num>0)
            {
                Console.WriteLine("Number is positive");
            }
            else if(num < 0) {

                Console.WriteLine("Number is negative");
            }
            else
            {
                Console.WriteLine("Number is zero");
            }


            if(num%2==0)
            {
                Console.WriteLine("The number is even");
            }
            else
            {
                Console.WriteLine("The number is odd");
            }
        }
    }
}
