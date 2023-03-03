using Delegates.Extensions.Diagnostics.Contexts;
using System.Collections.Generic;

using static Delegates.Extensions.Diagnostics.Diagnostician;

namespace System.Threading
{
    /// <summary>
    /// <see cref="ThreadStart"/> extensions
    /// </summary>
    public static class ThreadStartExtensions
    {
        /// <summary/>
        public static ThreadStart Diagnostic(this ThreadStart threadStart, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            ThreadStart wrapped = () =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    threadStart();
                    var succeedContext = new SucceedContext(data, cabinet);
                    Write(category, Ids.SUCCEED, data);
                }
                catch (Exception ex)
                {
                    var exceptionalContext = new ExceptionalContext(ex, data, cabinet);
                    Write(category, Ids.EXCEPTIONAL, data);
                    throw;
                }
                finally
                {
                    var finishedContext = new FinishedContext(data, cabinet);
                    Write(category, Ids.FINISHED, data);
                }
            };
            var preparedContext = new PreparedContext(data, cabinet);
            Write(category, Ids.PREPARED, data);

            return wrapped;
        }
    }
}
