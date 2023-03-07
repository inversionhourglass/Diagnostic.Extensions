using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace Delegates.Samples.Basic
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            DiagnosticListener.AllListeners.Subscribe(new DelegatesListener());

            var t = new DiagnosticFunc<Task>(async () => await Log(3000)).Invoke();

            AsyncLocal();

            await new DiagnosticFunc<Task>(async () => await Log(500));

            TaskEnqueueTiming();

            t.Wait();
        }

        static void TaskEnqueueTiming()
        {
            ThreadPool.GetMinThreads(out var worker, out var completion);
            ThreadPool.SetMinThreads(2, 2);

            var tasks = new List<Task>();

            for (int i = 0; i < 15; i++)
            {
                tasks.Add(Task.Run(new DiagnosticAction("Timing", Delay)));
            }

            Task.WaitAll(tasks.ToArray());

            ThreadPool.SetMinThreads(worker, completion);

            void Delay()
            {
                Thread.Sleep(10000);
            }
        }

        static void AsyncLocal()
        {
            DetailListener.Data.Value = 1;

            Task.Run(Print);

            Task.Run(new DiagnosticAction("PreventAsyncLocal", Print));

            Task.Run(Print);

            void Print()
            {
                Console.WriteLine($"async local value: {DetailListener.Data.Value}");
            }
        }

        static async Task Log(int delay)
        {
            Console.WriteLine($"{nameof(Log)} - {delay} - 1");
            await Task.Delay(delay);
            Console.WriteLine($"{nameof(Log)} - {delay} - 2");
        }
    }
}
