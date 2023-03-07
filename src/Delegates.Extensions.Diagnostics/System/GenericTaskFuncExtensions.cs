using Delegates.Extensions.Diagnostics.Contexts;
using System.Collections.Generic;
using System.Threading.Tasks;

using static Delegates.Extensions.Diagnostics.Diagnostician;

namespace System
{
    /// <summary>
    /// Func&lt;, Task&lt;TResult&gt;&gt; extensions
    /// </summary>
    public static class GenericTaskFuncExtensions
    {
    
        /// <summary/>
        public static Func<Task<TResult>> Diagnostic<TResult>(this Func<Task<TResult>> func, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Func<Task<TResult>> wrapped = async () =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    var result = await func();
                    var succeedContext = new SucceedContext(data, cabinet);
                    Write(category, Ids.SUCCEED, succeedContext);
                    return result;
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
    
        /// <summary/>
        public static Func<ValueTask<TResult>> Diagnostic<TResult>(this Func<ValueTask<TResult>> func, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Func<ValueTask<TResult>> wrapped = async () =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    var result = await func();
                    var succeedContext = new SucceedContext(data, cabinet);
                    Write(category, Ids.SUCCEED, succeedContext);
                    return result;
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
    
        /// <summary/>
        public static Func<T, Task<TResult>> Diagnostic<T, TResult>(this Func<T, Task<TResult>> func, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Func<T, Task<TResult>> wrapped = async (arg) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    var result = await func(arg);
                    var succeedContext = new SucceedContext(data, cabinet);
                    Write(category, Ids.SUCCEED, succeedContext);
                    return result;
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
    
        /// <summary/>
        public static Func<T, ValueTask<TResult>> Diagnostic<T, TResult>(this Func<T, ValueTask<TResult>> func, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Func<T, ValueTask<TResult>> wrapped = async (arg) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    var result = await func(arg);
                    var succeedContext = new SucceedContext(data, cabinet);
                    Write(category, Ids.SUCCEED, succeedContext);
                    return result;
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
    
        /// <summary/>
        public static Func<T1, T2, Task<TResult>> Diagnostic<T1, T2, TResult>(this Func<T1, T2, Task<TResult>> func, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Func<T1, T2, Task<TResult>> wrapped = async (arg1, arg2) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    var result = await func(arg1, arg2);
                    var succeedContext = new SucceedContext(data, cabinet);
                    Write(category, Ids.SUCCEED, succeedContext);
                    return result;
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
    
        /// <summary/>
        public static Func<T1, T2, ValueTask<TResult>> Diagnostic<T1, T2, TResult>(this Func<T1, T2, ValueTask<TResult>> func, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Func<T1, T2, ValueTask<TResult>> wrapped = async (arg1, arg2) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    var result = await func(arg1, arg2);
                    var succeedContext = new SucceedContext(data, cabinet);
                    Write(category, Ids.SUCCEED, succeedContext);
                    return result;
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
    
        /// <summary/>
        public static Func<T1, T2, T3, Task<TResult>> Diagnostic<T1, T2, T3, TResult>(this Func<T1, T2, T3, Task<TResult>> func, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Func<T1, T2, T3, Task<TResult>> wrapped = async (arg1, arg2, arg3) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    var result = await func(arg1, arg2, arg3);
                    var succeedContext = new SucceedContext(data, cabinet);
                    Write(category, Ids.SUCCEED, succeedContext);
                    return result;
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
    
        /// <summary/>
        public static Func<T1, T2, T3, ValueTask<TResult>> Diagnostic<T1, T2, T3, TResult>(this Func<T1, T2, T3, ValueTask<TResult>> func, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Func<T1, T2, T3, ValueTask<TResult>> wrapped = async (arg1, arg2, arg3) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    var result = await func(arg1, arg2, arg3);
                    var succeedContext = new SucceedContext(data, cabinet);
                    Write(category, Ids.SUCCEED, succeedContext);
                    return result;
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
    
        /// <summary/>
        public static Func<T1, T2, T3, T4, Task<TResult>> Diagnostic<T1, T2, T3, T4, TResult>(this Func<T1, T2, T3, T4, Task<TResult>> func, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Func<T1, T2, T3, T4, Task<TResult>> wrapped = async (arg1, arg2, arg3, arg4) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    var result = await func(arg1, arg2, arg3, arg4);
                    var succeedContext = new SucceedContext(data, cabinet);
                    Write(category, Ids.SUCCEED, succeedContext);
                    return result;
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
    
        /// <summary/>
        public static Func<T1, T2, T3, T4, ValueTask<TResult>> Diagnostic<T1, T2, T3, T4, TResult>(this Func<T1, T2, T3, T4, ValueTask<TResult>> func, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Func<T1, T2, T3, T4, ValueTask<TResult>> wrapped = async (arg1, arg2, arg3, arg4) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    var result = await func(arg1, arg2, arg3, arg4);
                    var succeedContext = new SucceedContext(data, cabinet);
                    Write(category, Ids.SUCCEED, succeedContext);
                    return result;
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
    
        /// <summary/>
        public static Func<T1, T2, T3, T4, T5, Task<TResult>> Diagnostic<T1, T2, T3, T4, T5, TResult>(this Func<T1, T2, T3, T4, T5, Task<TResult>> func, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Func<T1, T2, T3, T4, T5, Task<TResult>> wrapped = async (arg1, arg2, arg3, arg4, arg5) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    var result = await func(arg1, arg2, arg3, arg4, arg5);
                    var succeedContext = new SucceedContext(data, cabinet);
                    Write(category, Ids.SUCCEED, succeedContext);
                    return result;
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
    
        /// <summary/>
        public static Func<T1, T2, T3, T4, T5, ValueTask<TResult>> Diagnostic<T1, T2, T3, T4, T5, TResult>(this Func<T1, T2, T3, T4, T5, ValueTask<TResult>> func, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Func<T1, T2, T3, T4, T5, ValueTask<TResult>> wrapped = async (arg1, arg2, arg3, arg4, arg5) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    var result = await func(arg1, arg2, arg3, arg4, arg5);
                    var succeedContext = new SucceedContext(data, cabinet);
                    Write(category, Ids.SUCCEED, succeedContext);
                    return result;
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
    
        /// <summary/>
        public static Func<T1, T2, T3, T4, T5, T6, Task<TResult>> Diagnostic<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, Task<TResult>> func, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Func<T1, T2, T3, T4, T5, T6, Task<TResult>> wrapped = async (arg1, arg2, arg3, arg4, arg5, arg6) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    var result = await func(arg1, arg2, arg3, arg4, arg5, arg6);
                    var succeedContext = new SucceedContext(data, cabinet);
                    Write(category, Ids.SUCCEED, succeedContext);
                    return result;
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
    
        /// <summary/>
        public static Func<T1, T2, T3, T4, T5, T6, ValueTask<TResult>> Diagnostic<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, ValueTask<TResult>> func, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Func<T1, T2, T3, T4, T5, T6, ValueTask<TResult>> wrapped = async (arg1, arg2, arg3, arg4, arg5, arg6) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    var result = await func(arg1, arg2, arg3, arg4, arg5, arg6);
                    var succeedContext = new SucceedContext(data, cabinet);
                    Write(category, Ids.SUCCEED, succeedContext);
                    return result;
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
    
        /// <summary/>
        public static Func<T1, T2, T3, T4, T5, T6, T7, Task<TResult>> Diagnostic<T1, T2, T3, T4, T5, T6, T7, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, Task<TResult>> func, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Func<T1, T2, T3, T4, T5, T6, T7, Task<TResult>> wrapped = async (arg1, arg2, arg3, arg4, arg5, arg6, arg7) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    var result = await func(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
                    var succeedContext = new SucceedContext(data, cabinet);
                    Write(category, Ids.SUCCEED, succeedContext);
                    return result;
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
    
        /// <summary/>
        public static Func<T1, T2, T3, T4, T5, T6, T7, ValueTask<TResult>> Diagnostic<T1, T2, T3, T4, T5, T6, T7, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, ValueTask<TResult>> func, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Func<T1, T2, T3, T4, T5, T6, T7, ValueTask<TResult>> wrapped = async (arg1, arg2, arg3, arg4, arg5, arg6, arg7) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    var result = await func(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
                    var succeedContext = new SucceedContext(data, cabinet);
                    Write(category, Ids.SUCCEED, succeedContext);
                    return result;
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
    
        /// <summary/>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, Task<TResult>> Diagnostic<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, Task<TResult>> func, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Func<T1, T2, T3, T4, T5, T6, T7, T8, Task<TResult>> wrapped = async (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    var result = await func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
                    var succeedContext = new SucceedContext(data, cabinet);
                    Write(category, Ids.SUCCEED, succeedContext);
                    return result;
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
    
        /// <summary/>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, ValueTask<TResult>> Diagnostic<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, ValueTask<TResult>> func, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Func<T1, T2, T3, T4, T5, T6, T7, T8, ValueTask<TResult>> wrapped = async (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    var result = await func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
                    var succeedContext = new SucceedContext(data, cabinet);
                    Write(category, Ids.SUCCEED, succeedContext);
                    return result;
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
    
        /// <summary/>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task<TResult>> Diagnostic<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task<TResult>> func, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task<TResult>> wrapped = async (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    var result = await func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
                    var succeedContext = new SucceedContext(data, cabinet);
                    Write(category, Ids.SUCCEED, succeedContext);
                    return result;
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
    
        /// <summary/>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, ValueTask<TResult>> Diagnostic<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, ValueTask<TResult>> func, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, ValueTask<TResult>> wrapped = async (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    var result = await func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
                    var succeedContext = new SucceedContext(data, cabinet);
                    Write(category, Ids.SUCCEED, succeedContext);
                    return result;
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
    
        /// <summary/>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task<TResult>> Diagnostic<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task<TResult>> func, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task<TResult>> wrapped = async (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    var result = await func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
                    var succeedContext = new SucceedContext(data, cabinet);
                    Write(category, Ids.SUCCEED, succeedContext);
                    return result;
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
    
        /// <summary/>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, ValueTask<TResult>> Diagnostic<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, ValueTask<TResult>> func, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, ValueTask<TResult>> wrapped = async (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    var result = await func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
                    var succeedContext = new SucceedContext(data, cabinet);
                    Write(category, Ids.SUCCEED, succeedContext);
                    return result;
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
    
        /// <summary/>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task<TResult>> Diagnostic<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task<TResult>> func, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task<TResult>> wrapped = async (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    var result = await func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
                    var succeedContext = new SucceedContext(data, cabinet);
                    Write(category, Ids.SUCCEED, succeedContext);
                    return result;
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
    
        /// <summary/>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, ValueTask<TResult>> Diagnostic<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, ValueTask<TResult>> func, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, ValueTask<TResult>> wrapped = async (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    var result = await func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
                    var succeedContext = new SucceedContext(data, cabinet);
                    Write(category, Ids.SUCCEED, succeedContext);
                    return result;
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
    
        /// <summary/>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task<TResult>> Diagnostic<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task<TResult>> func, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task<TResult>> wrapped = async (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    var result = await func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
                    var succeedContext = new SucceedContext(data, cabinet);
                    Write(category, Ids.SUCCEED, succeedContext);
                    return result;
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
    
        /// <summary/>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, ValueTask<TResult>> Diagnostic<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, ValueTask<TResult>> func, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, ValueTask<TResult>> wrapped = async (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    var result = await func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
                    var succeedContext = new SucceedContext(data, cabinet);
                    Write(category, Ids.SUCCEED, succeedContext);
                    return result;
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
    
        /// <summary/>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task<TResult>> Diagnostic<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task<TResult>> func, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task<TResult>> wrapped = async (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    var result = await func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
                    var succeedContext = new SucceedContext(data, cabinet);
                    Write(category, Ids.SUCCEED, succeedContext);
                    return result;
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
    
        /// <summary/>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, ValueTask<TResult>> Diagnostic<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, ValueTask<TResult>> func, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, ValueTask<TResult>> wrapped = async (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    var result = await func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
                    var succeedContext = new SucceedContext(data, cabinet);
                    Write(category, Ids.SUCCEED, succeedContext);
                    return result;
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
    
        /// <summary/>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task<TResult>> Diagnostic<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task<TResult>> func, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task<TResult>> wrapped = async (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    var result = await func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
                    var succeedContext = new SucceedContext(data, cabinet);
                    Write(category, Ids.SUCCEED, succeedContext);
                    return result;
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
    
        /// <summary/>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, ValueTask<TResult>> Diagnostic<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, ValueTask<TResult>> func, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, ValueTask<TResult>> wrapped = async (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    var result = await func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
                    var succeedContext = new SucceedContext(data, cabinet);
                    Write(category, Ids.SUCCEED, succeedContext);
                    return result;
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
    
        /// <summary/>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task<TResult>> Diagnostic<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task<TResult>> func, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task<TResult>> wrapped = async (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    var result = await func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
                    var succeedContext = new SucceedContext(data, cabinet);
                    Write(category, Ids.SUCCEED, succeedContext);
                    return result;
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
    
        /// <summary/>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, ValueTask<TResult>> Diagnostic<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, ValueTask<TResult>> func, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, ValueTask<TResult>> wrapped = async (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    var result = await func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
                    var succeedContext = new SucceedContext(data, cabinet);
                    Write(category, Ids.SUCCEED, succeedContext);
                    return result;
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
    
        /// <summary/>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task<TResult>> Diagnostic<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task<TResult>> func, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task<TResult>> wrapped = async (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    var result = await func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
                    var succeedContext = new SucceedContext(data, cabinet);
                    Write(category, Ids.SUCCEED, succeedContext);
                    return result;
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
    
        /// <summary/>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, ValueTask<TResult>> Diagnostic<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, ValueTask<TResult>> func, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, ValueTask<TResult>> wrapped = async (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    var result = await func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
                    var succeedContext = new SucceedContext(data, cabinet);
                    Write(category, Ids.SUCCEED, succeedContext);
                    return result;
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