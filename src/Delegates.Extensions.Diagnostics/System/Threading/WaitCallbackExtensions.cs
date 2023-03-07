using Delegates.Extensions.Diagnostics.Contexts;
using System.Collections.Generic;

using static Delegates.Extensions.Diagnostics.Diagnostician;

namespace System.Threading
{
    /// <summary>
    /// <see cref="ThreadStart"/> extensions
    /// </summary>
    public static class WaitCallbackExtensions
    {
        /// <summary/>
        public static WaitCallback Diagnostic(this WaitCallback waitCallback, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            WaitCallback wrapped = state =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    waitCallback(state);
                    var succeedContext = new SucceedContext(data, cabinet);
                    Write(category, Ids.SUCCEED, succeedContext);
                }
                catch (Exception ex)
                {
                    var exceptionalContext = new ExceptionalContext(ex, data, cabinet);
                    Write(category, Ids.EXCEPTIONAL, exceptionalContext);
                    throw;
                }
                finally
                {
                    var finishedContext = new FinishedContext(data, cabinet);
                    Write(category, Ids.FINISHED, finishedContext);
                }
            };
            var preparedContext = new PreparedContext(data, cabinet);
            Write(category, Ids.PREPARED, preparedContext);

            return wrapped;
        }
    }
}
