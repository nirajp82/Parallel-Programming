using System;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelProgramming
{
    public class LocalDataStoreSlotDemo
    {
        public static void Start()
        {
            Task task1 = Task.Factory.StartNew(() =>
            {
                LocalDataStore.UseRoles = "Admin";
                Console.WriteLine("ThreadId: " + Thread.CurrentThread.ManagedThreadId + LocalDataStore.UseRoles);
                Thread.Sleep(25);
                LocalDataStore.UseRoles = "Manager";
                Console.WriteLine("ThreadId: " + Thread.CurrentThread.ManagedThreadId + LocalDataStore.UseRoles);
            });

            Task task2 = Task.Factory.StartNew(() =>
            {
                LocalDataStore.UseRoles = "Developer";
                Console.WriteLine("ThreadId: " + Thread.CurrentThread.ManagedThreadId + LocalDataStore.UseRoles);
                Thread.Sleep(20);
                LocalDataStore.UseRoles = "Contractor";
                Console.WriteLine("ThreadId: " + Thread.CurrentThread.ManagedThreadId + LocalDataStore.UseRoles);
            });

            Task.WaitAll(task1, task2);
        }
    }
}