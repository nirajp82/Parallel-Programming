using System;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelProgramming
{
    public class Program
    {
        static void Main(string[] args)
        {
            LocalDataStoreSlotDemo.Start();
            Console.Read();
        }
    }
}