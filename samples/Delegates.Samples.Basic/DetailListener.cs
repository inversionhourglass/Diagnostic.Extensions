using Delegates.Extensions.Diagnostics.Contexts;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace Delegates.Samples.Basic
{
    internal class DetailListener : IObserver<KeyValuePair<string, object>>
    {
        public static AsyncLocal<int?> Data = new AsyncLocal<int?>();

        public void OnCompleted()
        {
        }

        public void OnError(Exception error)
        {
        }

        public void OnNext(KeyValuePair<string, object> value)
        {
            switch (value.Key)
            {
                case "Delegates.Extensions.Timing.Preparing":
                    OnTimingPreparing((PreparingContext)value.Value);
                    break;
                case "Delegates.Extensions.Timing.Executing":
                    OnTimingExecuting((ExecutingContext)value.Value);
                    break;
                case "Delegates.Extensions.PreventAsyncLocal.Executing":
                    OnPreventAsyncLocalExecuting((ExecutingContext)value.Value);
                    break;
            }
        }

        private void OnTimingPreparing(PreparingContext context)
        {
            context.Cabinet["prepare"] = Stopwatch.StartNew();
        }

        private void OnTimingExecuting(ExecutingContext context)
        {
            var prepare = (Stopwatch)context.Cabinet["prepare"];
            prepare.Stop();
            Console.WriteLine($"enqueue task costs {prepare.ElapsedMilliseconds}ms");
        }

        private void OnPreventAsyncLocalExecuting(ExecutingContext context)
        {
            Data.Value = null;
        }
    }
}
