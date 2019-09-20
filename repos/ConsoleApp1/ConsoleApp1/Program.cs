using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            int positiveCounter = 0;
            int negativeCounter = 0;
            int sum = 0;


            while (true)
            {
                Console.Write("Please enter Zero:");
                int digit = Convert.ToInt32(Console.ReadLine());

                if (digit > 0)
                {
                    positiveCounter++;
                    continue;
                }

                if (digit < 0)
                {
                    negativeCounter++;
                    continue;
                }

                else
                {
                    sum = positiveCounter + negativeCounter;
                    Console.WriteLine($"positiveCounter is {positiveCounter}");
                    Console.WriteLine($"negativeCounter is {negativeCounter}");
                    Console.WriteLine(sum);

                    break;
                }
            }

            Console.ReadKey();
        }
    }
}
