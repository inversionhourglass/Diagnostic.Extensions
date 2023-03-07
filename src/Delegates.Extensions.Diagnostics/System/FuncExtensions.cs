using Delegates.Extensions.Diagnostics.Contexts;
using System.Collections.Generic;

using static Delegates.Extensions.Diagnostics.Diagnostician;

namespace System
{
    /// <summary>
    /// Func&lt;, TResult&gt; extensions
    /// </summary>
    public static partial class FuncExtensions
    {
    
        /// <summary/>
        public static Func<TResult> Diagnostic<TResult>(this Func<TResult> func, string? category = null, object? data = null)
        {
            var taskFunc = TryTaskDiagnostic(func, category, data);
            if (taskFunc != null) return taskFunc;

            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Func<TResult> wrapped = () =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    var result = func();
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
        public static Func<T, TResult> Diagnostic<T, TResult>(this Func<T, TResult> func, string? category = null, object? data = null)
        {
            var taskFunc = TryTaskDiagnostic(func, category, data);
            if (taskFunc != null) return taskFunc;

            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Func<T, TResult> wrapped = (arg) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    var result = func(arg);
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
        public static Func<T1, T2, TResult> Diagnostic<T1, T2, TResult>(this Func<T1, T2, TResult> func, string? category = null, object? data = null)
        {
            var taskFunc = TryTaskDiagnostic(func, category, data);
            if (taskFunc != null) return taskFunc;

            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Func<T1, T2, TResult> wrapped = (arg1, arg2) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    var result = func(arg1, arg2);
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
        public static Func<T1, T2, T3, TResult> Diagnostic<T1, T2, T3, TResult>(this Func<T1, T2, T3, TResult> func, string? category = null, object? data = null)
        {
            var taskFunc = TryTaskDiagnostic(func, category, data);
            if (taskFunc != null) return taskFunc;

            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Func<T1, T2, T3, TResult> wrapped = (arg1, arg2, arg3) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    var result = func(arg1, arg2, arg3);
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
        public static Func<T1, T2, T3, T4, TResult> Diagnostic<T1, T2, T3, T4, TResult>(this Func<T1, T2, T3, T4, TResult> func, string? category = null, object? data = null)
        {
            var taskFunc = TryTaskDiagnostic(func, category, data);
            if (taskFunc != null) return taskFunc;

            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Func<T1, T2, T3, T4, TResult> wrapped = (arg1, arg2, arg3, arg4) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    var result = func(arg1, arg2, arg3, arg4);
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
        public static Func<T1, T2, T3, T4, T5, TResult> Diagnostic<T1, T2, T3, T4, T5, TResult>(this Func<T1, T2, T3, T4, T5, TResult> func, string? category = null, object? data = null)
        {
            var taskFunc = TryTaskDiagnostic(func, category, data);
            if (taskFunc != null) return taskFunc;

            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Func<T1, T2, T3, T4, T5, TResult> wrapped = (arg1, arg2, arg3, arg4, arg5) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    var result = func(arg1, arg2, arg3, arg4, arg5);
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
        public static Func<T1, T2, T3, T4, T5, T6, TResult> Diagnostic<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, string? category = null, object? data = null)
        {
            var taskFunc = TryTaskDiagnostic(func, category, data);
            if (taskFunc != null) return taskFunc;

            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Func<T1, T2, T3, T4, T5, T6, TResult> wrapped = (arg1, arg2, arg3, arg4, arg5, arg6) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    var result = func(arg1, arg2, arg3, arg4, arg5, arg6);
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
        public static Func<T1, T2, T3, T4, T5, T6, T7, TResult> Diagnostic<T1, T2, T3, T4, T5, T6, T7, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, TResult> func, string? category = null, object? data = null)
        {
            var taskFunc = TryTaskDiagnostic(func, category, data);
            if (taskFunc != null) return taskFunc;

            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Func<T1, T2, T3, T4, T5, T6, T7, TResult> wrapped = (arg1, arg2, arg3, arg4, arg5, arg6, arg7) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    var result = func(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
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
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> Diagnostic<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> func, string? category = null, object? data = null)
        {
            var taskFunc = TryTaskDiagnostic(func, category, data);
            if (taskFunc != null) return taskFunc;

            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> wrapped = (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    var result = func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
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
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> Diagnostic<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> func, string? category = null, object? data = null)
        {
            var taskFunc = TryTaskDiagnostic(func, category, data);
            if (taskFunc != null) return taskFunc;

            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> wrapped = (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    var result = func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
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
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> Diagnostic<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> func, string? category = null, object? data = null)
        {
            var taskFunc = TryTaskDiagnostic(func, category, data);
            if (taskFunc != null) return taskFunc;

            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> wrapped = (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    var result = func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
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
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> Diagnostic<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> func, string? category = null, object? data = null)
        {
            var taskFunc = TryTaskDiagnostic(func, category, data);
            if (taskFunc != null) return taskFunc;

            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> wrapped = (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    var result = func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
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
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> Diagnostic<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> func, string? category = null, object? data = null)
        {
            var taskFunc = TryTaskDiagnostic(func, category, data);
            if (taskFunc != null) return taskFunc;

            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> wrapped = (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    var result = func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
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
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> Diagnostic<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> func, string? category = null, object? data = null)
        {
            var taskFunc = TryTaskDiagnostic(func, category, data);
            if (taskFunc != null) return taskFunc;

            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> wrapped = (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    var result = func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
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
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> Diagnostic<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> func, string? category = null, object? data = null)
        {
            var taskFunc = TryTaskDiagnostic(func, category, data);
            if (taskFunc != null) return taskFunc;

            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> wrapped = (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    var result = func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
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
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> Diagnostic<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> func, string? category = null, object? data = null)
        {
            var taskFunc = TryTaskDiagnostic(func, category, data);
            if (taskFunc != null) return taskFunc;

            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> wrapped = (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    var result = func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
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
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Diagnostic<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> func, string? category = null, object? data = null)
        {
            var taskFunc = TryTaskDiagnostic(func, category, data);
            if (taskFunc != null) return taskFunc;

            var cabinet = new Dictionary<string, object>();

            var preparingContext = new PreparingContext(data, cabinet);
            Write(category, Ids.PREPARING, preparingContext);
            Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> wrapped = (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16) =>
            {
                var executingContext = new ExecutingContext(data, cabinet);
                Write(category, Ids.EXECUTING, executingContext);
                try
                {
                    var result = func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
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