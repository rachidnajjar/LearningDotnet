using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace TaskHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowThreadInfo("Application");

            var t = Task.Run(() => ShowThreadInfo("Task"));
            t.Wait();


            var list = new ConcurrentBag<string>();
            string[] dirNames = { ".", ".." };
            List<Task> taches = new List<Task>();
            foreach (var dirName in dirNames) 
            {
                Task tache = Task.Run( () => 
                { 
                    foreach(var path in Directory.GetFiles(dirName)) 
                        list.Add(path); 
                });
                taches.Add(tache);
            }
            Task.WaitAll(taches.ToArray());
            foreach (Task tache in taches)
                Console.WriteLine("Task {0} Status: {1}", tache.Id, tache.Status);
                
            Console.WriteLine("Number of files read: {0}", list.Count);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        static void ShowThreadInfo(String s)
        {
            Console.WriteLine("{0} Thread ID: {1}", s, Thread.CurrentThread.ManagedThreadId);
        }
    }
}
