using Delegates.Extensions.Diagnostics.Contexts;
using System.Collections.Generic;

using static Delegates.Extensions.Diagnostics.Diagnostician;

namespace System.Threading
{
    /// <summary>
    /// <see cref="ThreadStart"/> extensions
    /// </summary>
    public static class TimerCallbackExtensions
    {
        /// <summary/>
        public static TimerCallback Diagnostic(this TimerCallback timerCallback, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            TimerCallback wrapped = state =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    timerCallback(state);
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
