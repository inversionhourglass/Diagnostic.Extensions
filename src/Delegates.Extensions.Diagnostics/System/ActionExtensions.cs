using Delegates.Extensions.Diagnostics.Contexts;
using System.Collections.Generic;

using static Delegates.Extensions.Diagnostics.Diagnostician;

namespace System
{
    /// <summary>
    /// Action&lt;&gt; extensions
    /// </summary>
    public static class ActionExtensions
    {
    
        /// <summary/>
        public static Action Diagnostic(this Action action, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Action wrapped = () =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    action();
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
    
        /// <summary/>
        public static Action<T> Diagnostic<T>(this Action<T> action, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Action<T> wrapped = (arg) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    action(arg);
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
    
        /// <summary/>
        public static Action<T1, T2> Diagnostic<T1, T2>(this Action<T1, T2> action, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Action<T1, T2> wrapped = (arg1, arg2) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    action(arg1, arg2);
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
    
        /// <summary/>
        public static Action<T1, T2, T3> Diagnostic<T1, T2, T3>(this Action<T1, T2, T3> action, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Action<T1, T2, T3> wrapped = (arg1, arg2, arg3) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    action(arg1, arg2, arg3);
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
    
        /// <summary/>
        public static Action<T1, T2, T3, T4> Diagnostic<T1, T2, T3, T4>(this Action<T1, T2, T3, T4> action, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Action<T1, T2, T3, T4> wrapped = (arg1, arg2, arg3, arg4) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    action(arg1, arg2, arg3, arg4);
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
    
        /// <summary/>
        public static Action<T1, T2, T3, T4, T5> Diagnostic<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> action, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Action<T1, T2, T3, T4, T5> wrapped = (arg1, arg2, arg3, arg4, arg5) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    action(arg1, arg2, arg3, arg4, arg5);
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
    
        /// <summary/>
        public static Action<T1, T2, T3, T4, T5, T6> Diagnostic<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Action<T1, T2, T3, T4, T5, T6> wrapped = (arg1, arg2, arg3, arg4, arg5, arg6) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    action(arg1, arg2, arg3, arg4, arg5, arg6);
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
    
        /// <summary/>
        public static Action<T1, T2, T3, T4, T5, T6, T7> Diagnostic<T1, T2, T3, T4, T5, T6, T7>(this Action<T1, T2, T3, T4, T5, T6, T7> action, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Action<T1, T2, T3, T4, T5, T6, T7> wrapped = (arg1, arg2, arg3, arg4, arg5, arg6, arg7) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    action(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
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
    
        /// <summary/>
        public static Action<T1, T2, T3, T4, T5, T6, T7, T8> Diagnostic<T1, T2, T3, T4, T5, T6, T7, T8>(this Action<T1, T2, T3, T4, T5, T6, T7, T8> action, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Action<T1, T2, T3, T4, T5, T6, T7, T8> wrapped = (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
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
    
        /// <summary/>
        public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> Diagnostic<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> wrapped = (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
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
    
        /// <summary/>
        public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Diagnostic<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> wrapped = (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
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
    
        /// <summary/>
        public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Diagnostic<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> wrapped = (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
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
    
        /// <summary/>
        public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Diagnostic<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> wrapped = (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
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
    
        /// <summary/>
        public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Diagnostic<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> wrapped = (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
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
    
        /// <summary/>
        public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Diagnostic<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> wrapped = (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
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
    
        /// <summary/>
        public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Diagnostic<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> wrapped = (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
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
    
        /// <summary/>
        public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Diagnostic<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, string? category = null, object? data = null)
        {
            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> wrapped = (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
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