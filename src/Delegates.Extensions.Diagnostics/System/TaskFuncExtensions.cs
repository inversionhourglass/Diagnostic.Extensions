using Delegates.Extensions.Diagnostics.Contexts;
using System.Collections.Generic;
using System.Threading.Tasks;

using static Delegates.Extensions.Diagnostics.Diagnostician;

namespace System
{
    /// <summary>
    /// Func&lt;, Task&gt; extensions
    /// </summary>
    public static class TaskFuncExtensions
    {
    
        /// <summary/>
        public static Func<Task> Diagnostic(this Func<Task> func, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Func<Task> wrapped = async () =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    await func();
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
    
        /// <summary/>
        public static Func<ValueTask> Diagnostic(this Func<ValueTask> func, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Func<ValueTask> wrapped = async () =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    await func();
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
    
        /// <summary/>
        public static Func<T, Task> Diagnostic<T>(this Func<T, Task> func, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Func<T, Task> wrapped = async (arg) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    await func(arg);
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
    
        /// <summary/>
        public static Func<T, ValueTask> Diagnostic<T>(this Func<T, ValueTask> func, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Func<T, ValueTask> wrapped = async (arg) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    await func(arg);
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
    
        /// <summary/>
        public static Func<T1, T2, Task> Diagnostic<T1, T2>(this Func<T1, T2, Task> func, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Func<T1, T2, Task> wrapped = async (arg1, arg2) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    await func(arg1, arg2);
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
    
        /// <summary/>
        public static Func<T1, T2, ValueTask> Diagnostic<T1, T2>(this Func<T1, T2, ValueTask> func, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Func<T1, T2, ValueTask> wrapped = async (arg1, arg2) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    await func(arg1, arg2);
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
    
        /// <summary/>
        public static Func<T1, T2, T3, Task> Diagnostic<T1, T2, T3>(this Func<T1, T2, T3, Task> func, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Func<T1, T2, T3, Task> wrapped = async (arg1, arg2, arg3) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    await func(arg1, arg2, arg3);
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
    
        /// <summary/>
        public static Func<T1, T2, T3, ValueTask> Diagnostic<T1, T2, T3>(this Func<T1, T2, T3, ValueTask> func, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Func<T1, T2, T3, ValueTask> wrapped = async (arg1, arg2, arg3) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    await func(arg1, arg2, arg3);
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
    
        /// <summary/>
        public static Func<T1, T2, T3, T4, Task> Diagnostic<T1, T2, T3, T4>(this Func<T1, T2, T3, T4, Task> func, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Func<T1, T2, T3, T4, Task> wrapped = async (arg1, arg2, arg3, arg4) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    await func(arg1, arg2, arg3, arg4);
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
    
        /// <summary/>
        public static Func<T1, T2, T3, T4, ValueTask> Diagnostic<T1, T2, T3, T4>(this Func<T1, T2, T3, T4, ValueTask> func, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Func<T1, T2, T3, T4, ValueTask> wrapped = async (arg1, arg2, arg3, arg4) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    await func(arg1, arg2, arg3, arg4);
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
    
        /// <summary/>
        public static Func<T1, T2, T3, T4, T5, Task> Diagnostic<T1, T2, T3, T4, T5>(this Func<T1, T2, T3, T4, T5, Task> func, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Func<T1, T2, T3, T4, T5, Task> wrapped = async (arg1, arg2, arg3, arg4, arg5) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    await func(arg1, arg2, arg3, arg4, arg5);
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
    
        /// <summary/>
        public static Func<T1, T2, T3, T4, T5, ValueTask> Diagnostic<T1, T2, T3, T4, T5>(this Func<T1, T2, T3, T4, T5, ValueTask> func, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Func<T1, T2, T3, T4, T5, ValueTask> wrapped = async (arg1, arg2, arg3, arg4, arg5) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    await func(arg1, arg2, arg3, arg4, arg5);
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
    
        /// <summary/>
        public static Func<T1, T2, T3, T4, T5, T6, Task> Diagnostic<T1, T2, T3, T4, T5, T6>(this Func<T1, T2, T3, T4, T5, T6, Task> func, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Func<T1, T2, T3, T4, T5, T6, Task> wrapped = async (arg1, arg2, arg3, arg4, arg5, arg6) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    await func(arg1, arg2, arg3, arg4, arg5, arg6);
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
    
        /// <summary/>
        public static Func<T1, T2, T3, T4, T5, T6, ValueTask> Diagnostic<T1, T2, T3, T4, T5, T6>(this Func<T1, T2, T3, T4, T5, T6, ValueTask> func, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Func<T1, T2, T3, T4, T5, T6, ValueTask> wrapped = async (arg1, arg2, arg3, arg4, arg5, arg6) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    await func(arg1, arg2, arg3, arg4, arg5, arg6);
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
    
        /// <summary/>
        public static Func<T1, T2, T3, T4, T5, T6, T7, Task> Diagnostic<T1, T2, T3, T4, T5, T6, T7>(this Func<T1, T2, T3, T4, T5, T6, T7, Task> func, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Func<T1, T2, T3, T4, T5, T6, T7, Task> wrapped = async (arg1, arg2, arg3, arg4, arg5, arg6, arg7) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    await func(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
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
    
        /// <summary/>
        public static Func<T1, T2, T3, T4, T5, T6, T7, ValueTask> Diagnostic<T1, T2, T3, T4, T5, T6, T7>(this Func<T1, T2, T3, T4, T5, T6, T7, ValueTask> func, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Func<T1, T2, T3, T4, T5, T6, T7, ValueTask> wrapped = async (arg1, arg2, arg3, arg4, arg5, arg6, arg7) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    await func(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
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
    
        /// <summary/>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, Task> Diagnostic<T1, T2, T3, T4, T5, T6, T7, T8>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, Task> func, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Func<T1, T2, T3, T4, T5, T6, T7, T8, Task> wrapped = async (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    await func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
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
    
        /// <summary/>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, ValueTask> Diagnostic<T1, T2, T3, T4, T5, T6, T7, T8>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, ValueTask> func, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Func<T1, T2, T3, T4, T5, T6, T7, T8, ValueTask> wrapped = async (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    await func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
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
    
        /// <summary/>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task> Diagnostic<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task> func, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task> wrapped = async (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    await func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
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
    
        /// <summary/>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, ValueTask> Diagnostic<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, ValueTask> func, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, ValueTask> wrapped = async (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    await func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
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
    
        /// <summary/>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task> Diagnostic<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task> func, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task> wrapped = async (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    await func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
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
    
        /// <summary/>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, ValueTask> Diagnostic<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, ValueTask> func, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, ValueTask> wrapped = async (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    await func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
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
    
        /// <summary/>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task> Diagnostic<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task> func, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task> wrapped = async (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    await func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
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
    
        /// <summary/>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, ValueTask> Diagnostic<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, ValueTask> func, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, ValueTask> wrapped = async (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    await func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
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
    
        /// <summary/>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task> Diagnostic<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task> func, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task> wrapped = async (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    await func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
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
    
        /// <summary/>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, ValueTask> Diagnostic<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, ValueTask> func, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, ValueTask> wrapped = async (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    await func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
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
    
        /// <summary/>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task> Diagnostic<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task> func, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task> wrapped = async (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    await func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
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
    
        /// <summary/>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, ValueTask> Diagnostic<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, ValueTask> func, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, ValueTask> wrapped = async (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    await func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
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
    
        /// <summary/>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task> Diagnostic<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task> func, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task> wrapped = async (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    await func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
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
    
        /// <summary/>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, ValueTask> Diagnostic<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, ValueTask> func, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, ValueTask> wrapped = async (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    await func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
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
    
        /// <summary/>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task> Diagnostic<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task> func, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task> wrapped = async (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    await func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
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
    
        /// <summary/>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, ValueTask> Diagnostic<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, ValueTask> func, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, ValueTask> wrapped = async (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    await func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
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
    
        /// <summary/>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task> Diagnostic<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task> func, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task> wrapped = async (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    await func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
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
    
        /// <summary/>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, ValueTask> Diagnostic<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, ValueTask> func, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, ValueTask> wrapped = async (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    await func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
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