using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MultiThreading_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 5; i++)
            {
                Thread t = new Thread(WriteX);
                t.Start();

                Console.WriteLine("O");

            }
        }
        static void WriteX()
        {

            for(int i =0; i < 10; i++)
            {
                Console.WriteLine(".");
            }
        }
    }
}
