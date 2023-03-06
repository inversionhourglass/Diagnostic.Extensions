using System.Threading.Tasks;

namespace System
{
    
    /// <summary>
    /// Func diagnostic message
    /// </summary>
    public struct DiagnosticTaskFunc
    {
        private readonly Func<Task> _func;

        /// <summary/>
        public DiagnosticTaskFunc(Func<Task> func) : this(null, null, func) { }

        /// <summary/>
        public DiagnosticTaskFunc(string? category, Func<Task> func) : this(category, null, func) { }

        /// <summary/>
        public DiagnosticTaskFunc(string? category, object? data, Func<Task> func)
        {
            _func = func.Diagnostic(category, data);
        }

        /// <summary/>
        public Task Invoke() => _func();

        /// <summary>
        /// Implicit convert DiagnosticTaskFunc to Func
        /// </summary>
        public static implicit operator Func<Task>(DiagnosticTaskFunc func)
        {
            return func._func;
        }
    }
    
    /// <summary>
    /// Func diagnostic message
    /// </summary>
    public struct DiagnosticTaskFunc<T>
    {
        private readonly Func<T, Task> _func;

        /// <summary/>
        public DiagnosticTaskFunc(Func<T, Task> func) : this(null, null, func) { }

        /// <summary/>
        public DiagnosticTaskFunc(string? category, Func<T, Task> func) : this(category, null, func) { }

        /// <summary/>
        public DiagnosticTaskFunc(string? category, object? data, Func<T, Task> func)
        {
            _func = func.Diagnostic(category, data);
        }

        /// <summary/>
        public Task Invoke(T arg) => _func(arg);

        /// <summary>
        /// Implicit convert DiagnosticTaskFunc to Func
        /// </summary>
        public static implicit operator Func<T, Task>(DiagnosticTaskFunc<T> func)
        {
            return func._func;
        }
    }
    
    /// <summary>
    /// Func diagnostic message
    /// </summary>
    public struct DiagnosticTaskFunc<T1, T2>
    {
        private readonly Func<T1, T2, Task> _func;

        /// <summary/>
        public DiagnosticTaskFunc(Func<T1, T2, Task> func) : this(null, null, func) { }

        /// <summary/>
        public DiagnosticTaskFunc(string? category, Func<T1, T2, Task> func) : this(category, null, func) { }

        /// <summary/>
        public DiagnosticTaskFunc(string? category, object? data, Func<T1, T2, Task> func)
        {
            _func = func.Diagnostic(category, data);
        }

        /// <summary/>
        public Task Invoke(T1 arg1, T2 arg2) => _func(arg1, arg2);

        /// <summary>
        /// Implicit convert DiagnosticTaskFunc to Func
        /// </summary>
        public static implicit operator Func<T1, T2, Task>(DiagnosticTaskFunc<T1, T2> func)
        {
            return func._func;
        }
    }
    
    /// <summary>
    /// Func diagnostic message
    /// </summary>
    public struct DiagnosticTaskFunc<T1, T2, T3>
    {
        private readonly Func<T1, T2, T3, Task> _func;

        /// <summary/>
        public DiagnosticTaskFunc(Func<T1, T2, T3, Task> func) : this(null, null, func) { }

        /// <summary/>
        public DiagnosticTaskFunc(string? category, Func<T1, T2, T3, Task> func) : this(category, null, func) { }

        /// <summary/>
        public DiagnosticTaskFunc(string? category, object? data, Func<T1, T2, T3, Task> func)
        {
            _func = func.Diagnostic(category, data);
        }

        /// <summary/>
        public Task Invoke(T1 arg1, T2 arg2, T3 arg3) => _func(arg1, arg2, arg3);

        /// <summary>
        /// Implicit convert DiagnosticTaskFunc to Func
        /// </summary>
        public static implicit operator Func<T1, T2, T3, Task>(DiagnosticTaskFunc<T1, T2, T3> func)
        {
            return func._func;
        }
    }
    
    /// <summary>
    /// Func diagnostic message
    /// </summary>
    public struct DiagnosticTaskFunc<T1, T2, T3, T4>
    {
        private readonly Func<T1, T2, T3, T4, Task> _func;

        /// <summary/>
        public DiagnosticTaskFunc(Func<T1, T2, T3, T4, Task> func) : this(null, null, func) { }

        /// <summary/>
        public DiagnosticTaskFunc(string? category, Func<T1, T2, T3, T4, Task> func) : this(category, null, func) { }

        /// <summary/>
        public DiagnosticTaskFunc(string? category, object? data, Func<T1, T2, T3, T4, Task> func)
        {
            _func = func.Diagnostic(category, data);
        }

        /// <summary/>
        public Task Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4) => _func(arg1, arg2, arg3, arg4);

        /// <summary>
        /// Implicit convert DiagnosticTaskFunc to Func
        /// </summary>
        public static implicit operator Func<T1, T2, T3, T4, Task>(DiagnosticTaskFunc<T1, T2, T3, T4> func)
        {
            return func._func;
        }
    }
    
    /// <summary>
    /// Func diagnostic message
    /// </summary>
    public struct DiagnosticTaskFunc<T1, T2, T3, T4, T5>
    {
        private readonly Func<T1, T2, T3, T4, T5, Task> _func;

        /// <summary/>
        public DiagnosticTaskFunc(Func<T1, T2, T3, T4, T5, Task> func) : this(null, null, func) { }

        /// <summary/>
        public DiagnosticTaskFunc(string? category, Func<T1, T2, T3, T4, T5, Task> func) : this(category, null, func) { }

        /// <summary/>
        public DiagnosticTaskFunc(string? category, object? data, Func<T1, T2, T3, T4, T5, Task> func)
        {
            _func = func.Diagnostic(category, data);
        }

        /// <summary/>
        public Task Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) => _func(arg1, arg2, arg3, arg4, arg5);

        /// <summary>
        /// Implicit convert DiagnosticTaskFunc to Func
        /// </summary>
        public static implicit operator Func<T1, T2, T3, T4, T5, Task>(DiagnosticTaskFunc<T1, T2, T3, T4, T5> func)
        {
            return func._func;
        }
    }
    
    /// <summary>
    /// Func diagnostic message
    /// </summary>
    public struct DiagnosticTaskFunc<T1, T2, T3, T4, T5, T6>
    {
        private readonly Func<T1, T2, T3, T4, T5, T6, Task> _func;

        /// <summary/>
        public DiagnosticTaskFunc(Func<T1, T2, T3, T4, T5, T6, Task> func) : this(null, null, func) { }

        /// <summary/>
        public DiagnosticTaskFunc(string? category, Func<T1, T2, T3, T4, T5, T6, Task> func) : this(category, null, func) { }

        /// <summary/>
        public DiagnosticTaskFunc(string? category, object? data, Func<T1, T2, T3, T4, T5, T6, Task> func)
        {
            _func = func.Diagnostic(category, data);
        }

        /// <summary/>
        public Task Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) => _func(arg1, arg2, arg3, arg4, arg5, arg6);

        /// <summary>
        /// Implicit convert DiagnosticTaskFunc to Func
        /// </summary>
        public static implicit operator Func<T1, T2, T3, T4, T5, T6, Task>(DiagnosticTaskFunc<T1, T2, T3, T4, T5, T6> func)
        {
            return func._func;
        }
    }
    
    /// <summary>
    /// Func diagnostic message
    /// </summary>
    public struct DiagnosticTaskFunc<T1, T2, T3, T4, T5, T6, T7>
    {
        private readonly Func<T1, T2, T3, T4, T5, T6, T7, Task> _func;

        /// <summary/>
        public DiagnosticTaskFunc(Func<T1, T2, T3, T4, T5, T6, T7, Task> func) : this(null, null, func) { }

        /// <summary/>
        public DiagnosticTaskFunc(string? category, Func<T1, T2, T3, T4, T5, T6, T7, Task> func) : this(category, null, func) { }

        /// <summary/>
        public DiagnosticTaskFunc(string? category, object? data, Func<T1, T2, T3, T4, T5, T6, T7, Task> func)
        {
            _func = func.Diagnostic(category, data);
        }

        /// <summary/>
        public Task Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) => _func(arg1, arg2, arg3, arg4, arg5, arg6, arg7);

        /// <summary>
        /// Implicit convert DiagnosticTaskFunc to Func
        /// </summary>
        public static implicit operator Func<T1, T2, T3, T4, T5, T6, T7, Task>(DiagnosticTaskFunc<T1, T2, T3, T4, T5, T6, T7> func)
        {
            return func._func;
        }
    }
    
    /// <summary>
    /// Func diagnostic message
    /// </summary>
    public struct DiagnosticTaskFunc<T1, T2, T3, T4, T5, T6, T7, T8>
    {
        private readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, Task> _func;

        /// <summary/>
        public DiagnosticTaskFunc(Func<T1, T2, T3, T4, T5, T6, T7, T8, Task> func) : this(null, null, func) { }

        /// <summary/>
        public DiagnosticTaskFunc(string? category, Func<T1, T2, T3, T4, T5, T6, T7, T8, Task> func) : this(category, null, func) { }

        /// <summary/>
        public DiagnosticTaskFunc(string? category, object? data, Func<T1, T2, T3, T4, T5, T6, T7, T8, Task> func)
        {
            _func = func.Diagnostic(category, data);
        }

        /// <summary/>
        public Task Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) => _func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);

        /// <summary>
        /// Implicit convert DiagnosticTaskFunc to Func
        /// </summary>
        public static implicit operator Func<T1, T2, T3, T4, T5, T6, T7, T8, Task>(DiagnosticTaskFunc<T1, T2, T3, T4, T5, T6, T7, T8> func)
        {
            return func._func;
        }
    }
    
    /// <summary>
    /// Func diagnostic message
    /// </summary>
    public struct DiagnosticTaskFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9>
    {
        private readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task> _func;

        /// <summary/>
        public DiagnosticTaskFunc(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task> func) : this(null, null, func) { }

        /// <summary/>
        public DiagnosticTaskFunc(string? category, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task> func) : this(category, null, func) { }

        /// <summary/>
        public DiagnosticTaskFunc(string? category, object? data, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task> func)
        {
            _func = func.Diagnostic(category, data);
        }

        /// <summary/>
        public Task Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) => _func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);

        /// <summary>
        /// Implicit convert DiagnosticTaskFunc to Func
        /// </summary>
        public static implicit operator Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task>(DiagnosticTaskFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9> func)
        {
            return func._func;
        }
    }
    
    /// <summary>
    /// Func diagnostic message
    /// </summary>
    public struct DiagnosticTaskFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
    {
        private readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task> _func;

        /// <summary/>
        public DiagnosticTaskFunc(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task> func) : this(null, null, func) { }

        /// <summary/>
        public DiagnosticTaskFunc(string? category, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task> func) : this(category, null, func) { }

        /// <summary/>
        public DiagnosticTaskFunc(string? category, object? data, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task> func)
        {
            _func = func.Diagnostic(category, data);
        }

        /// <summary/>
        public Task Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) => _func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);

        /// <summary>
        /// Implicit convert DiagnosticTaskFunc to Func
        /// </summary>
        public static implicit operator Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task>(DiagnosticTaskFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> func)
        {
            return func._func;
        }
    }
    
    /// <summary>
    /// Func diagnostic message
    /// </summary>
    public struct DiagnosticTaskFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
    {
        private readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task> _func;

        /// <summary/>
        public DiagnosticTaskFunc(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task> func) : this(null, null, func) { }

        /// <summary/>
        public DiagnosticTaskFunc(string? category, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task> func) : this(category, null, func) { }

        /// <summary/>
        public DiagnosticTaskFunc(string? category, object? data, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task> func)
        {
            _func = func.Diagnostic(category, data);
        }

        /// <summary/>
        public Task Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) => _func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);

        /// <summary>
        /// Implicit convert DiagnosticTaskFunc to Func
        /// </summary>
        public static implicit operator Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task>(DiagnosticTaskFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> func)
        {
            return func._func;
        }
    }
    
    /// <summary>
    /// Func diagnostic message
    /// </summary>
    public struct DiagnosticTaskFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
    {
        private readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task> _func;

        /// <summary/>
        public DiagnosticTaskFunc(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task> func) : this(null, null, func) { }

        /// <summary/>
        public DiagnosticTaskFunc(string? category, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task> func) : this(category, null, func) { }

        /// <summary/>
        public DiagnosticTaskFunc(string? category, object? data, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task> func)
        {
            _func = func.Diagnostic(category, data);
        }

        /// <summary/>
        public Task Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) => _func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);

        /// <summary>
        /// Implicit convert DiagnosticTaskFunc to Func
        /// </summary>
        public static implicit operator Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task>(DiagnosticTaskFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> func)
        {
            return func._func;
        }
    }
    
    /// <summary>
    /// Func diagnostic message
    /// </summary>
    public struct DiagnosticTaskFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
    {
        private readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task> _func;

        /// <summary/>
        public DiagnosticTaskFunc(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task> func) : this(null, null, func) { }

        /// <summary/>
        public DiagnosticTaskFunc(string? category, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task> func) : this(category, null, func) { }

        /// <summary/>
        public DiagnosticTaskFunc(string? category, object? data, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task> func)
        {
            _func = func.Diagnostic(category, data);
        }

        /// <summary/>
        public Task Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13) => _func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);

        /// <summary>
        /// Implicit convert DiagnosticTaskFunc to Func
        /// </summary>
        public static implicit operator Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task>(DiagnosticTaskFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> func)
        {
            return func._func;
        }
    }
    
    /// <summary>
    /// Func diagnostic message
    /// </summary>
    public struct DiagnosticTaskFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
    {
        private readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task> _func;

        /// <summary/>
        public DiagnosticTaskFunc(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task> func) : this(null, null, func) { }

        /// <summary/>
        public DiagnosticTaskFunc(string? category, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task> func) : this(category, null, func) { }

        /// <summary/>
        public DiagnosticTaskFunc(string? category, object? data, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task> func)
        {
            _func = func.Diagnostic(category, data);
        }

        /// <summary/>
        public Task Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14) => _func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);

        /// <summary>
        /// Implicit convert DiagnosticTaskFunc to Func
        /// </summary>
        public static implicit operator Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task>(DiagnosticTaskFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> func)
        {
            return func._func;
        }
    }
    
    /// <summary>
    /// Func diagnostic message
    /// </summary>
    public struct DiagnosticTaskFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
    {
        private readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task> _func;

        /// <summary/>
        public DiagnosticTaskFunc(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task> func) : this(null, null, func) { }

        /// <summary/>
        public DiagnosticTaskFunc(string? category, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task> func) : this(category, null, func) { }

        /// <summary/>
        public DiagnosticTaskFunc(string? category, object? data, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task> func)
        {
            _func = func.Diagnostic(category, data);
        }

        /// <summary/>
        public Task Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15) => _func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);

        /// <summary>
        /// Implicit convert DiagnosticTaskFunc to Func
        /// </summary>
        public static implicit operator Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task>(DiagnosticTaskFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> func)
        {
            return func._func;
        }
    }
    
    /// <summary>
    /// Func diagnostic message
    /// </summary>
    public struct DiagnosticTaskFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>
    {
        private readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task> _func;

        /// <summary/>
        public DiagnosticTaskFunc(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task> func) : this(null, null, func) { }

        /// <summary/>
        public DiagnosticTaskFunc(string? category, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task> func) : this(category, null, func) { }

        /// <summary/>
        public DiagnosticTaskFunc(string? category, object? data, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task> func)
        {
            _func = func.Diagnostic(category, data);
        }

        /// <summary/>
        public Task Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16) => _func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);

        /// <summary>
        /// Implicit convert DiagnosticTaskFunc to Func
        /// </summary>
        public static implicit operator Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task>(DiagnosticTaskFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> func)
        {
            return func._func;
        }
    }
    
}