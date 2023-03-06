namespace System
{
    
    /// <summary>
    /// Func diagnostic message
    /// </summary>
    public struct DiagnosticFunc<TResult>
    {
        private readonly Func<TResult> _func;

        /// <summary/>
        public DiagnosticFunc(Func<TResult> func) : this(null, null, func) { }

        /// <summary/>
        public DiagnosticFunc(string? category, Func<TResult> func) : this(category, null, func) { }

        /// <summary/>
        public DiagnosticFunc(string? category, object? data, Func<TResult> func)
        {
            _func = func.Diagnostic(category, data);
        }

        /// <summary/>
        public TResult Invoke() => _func();

        /// <summary>
        /// Implicit convert DiagnosticFunc to Func
        /// </summary>
        public static implicit operator Func<TResult>(DiagnosticFunc<TResult> func)
        {
            return func._func;
        }
    }
    
    /// <summary>
    /// Func diagnostic message
    /// </summary>
    public struct DiagnosticFunc<T, TResult>
    {
        private readonly Func<T, TResult> _func;

        /// <summary/>
        public DiagnosticFunc(Func<T, TResult> func) : this(null, null, func) { }

        /// <summary/>
        public DiagnosticFunc(string? category, Func<T, TResult> func) : this(category, null, func) { }

        /// <summary/>
        public DiagnosticFunc(string? category, object? data, Func<T, TResult> func)
        {
            _func = func.Diagnostic(category, data);
        }

        /// <summary/>
        public TResult Invoke(T arg) => _func(arg);

        /// <summary>
        /// Implicit convert DiagnosticFunc to Func
        /// </summary>
        public static implicit operator Func<T, TResult>(DiagnosticFunc<T, TResult> func)
        {
            return func._func;
        }
    }
    
    /// <summary>
    /// Func diagnostic message
    /// </summary>
    public struct DiagnosticFunc<T1, T2, TResult>
    {
        private readonly Func<T1, T2, TResult> _func;

        /// <summary/>
        public DiagnosticFunc(Func<T1, T2, TResult> func) : this(null, null, func) { }

        /// <summary/>
        public DiagnosticFunc(string? category, Func<T1, T2, TResult> func) : this(category, null, func) { }

        /// <summary/>
        public DiagnosticFunc(string? category, object? data, Func<T1, T2, TResult> func)
        {
            _func = func.Diagnostic(category, data);
        }

        /// <summary/>
        public TResult Invoke(T1 arg1, T2 arg2) => _func(arg1, arg2);

        /// <summary>
        /// Implicit convert DiagnosticFunc to Func
        /// </summary>
        public static implicit operator Func<T1, T2, TResult>(DiagnosticFunc<T1, T2, TResult> func)
        {
            return func._func;
        }
    }
    
    /// <summary>
    /// Func diagnostic message
    /// </summary>
    public struct DiagnosticFunc<T1, T2, T3, TResult>
    {
        private readonly Func<T1, T2, T3, TResult> _func;

        /// <summary/>
        public DiagnosticFunc(Func<T1, T2, T3, TResult> func) : this(null, null, func) { }

        /// <summary/>
        public DiagnosticFunc(string? category, Func<T1, T2, T3, TResult> func) : this(category, null, func) { }

        /// <summary/>
        public DiagnosticFunc(string? category, object? data, Func<T1, T2, T3, TResult> func)
        {
            _func = func.Diagnostic(category, data);
        }

        /// <summary/>
        public TResult Invoke(T1 arg1, T2 arg2, T3 arg3) => _func(arg1, arg2, arg3);

        /// <summary>
        /// Implicit convert DiagnosticFunc to Func
        /// </summary>
        public static implicit operator Func<T1, T2, T3, TResult>(DiagnosticFunc<T1, T2, T3, TResult> func)
        {
            return func._func;
        }
    }
    
    /// <summary>
    /// Func diagnostic message
    /// </summary>
    public struct DiagnosticFunc<T1, T2, T3, T4, TResult>
    {
        private readonly Func<T1, T2, T3, T4, TResult> _func;

        /// <summary/>
        public DiagnosticFunc(Func<T1, T2, T3, T4, TResult> func) : this(null, null, func) { }

        /// <summary/>
        public DiagnosticFunc(string? category, Func<T1, T2, T3, T4, TResult> func) : this(category, null, func) { }

        /// <summary/>
        public DiagnosticFunc(string? category, object? data, Func<T1, T2, T3, T4, TResult> func)
        {
            _func = func.Diagnostic(category, data);
        }

        /// <summary/>
        public TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4) => _func(arg1, arg2, arg3, arg4);

        /// <summary>
        /// Implicit convert DiagnosticFunc to Func
        /// </summary>
        public static implicit operator Func<T1, T2, T3, T4, TResult>(DiagnosticFunc<T1, T2, T3, T4, TResult> func)
        {
            return func._func;
        }
    }
    
    /// <summary>
    /// Func diagnostic message
    /// </summary>
    public struct DiagnosticFunc<T1, T2, T3, T4, T5, TResult>
    {
        private readonly Func<T1, T2, T3, T4, T5, TResult> _func;

        /// <summary/>
        public DiagnosticFunc(Func<T1, T2, T3, T4, T5, TResult> func) : this(null, null, func) { }

        /// <summary/>
        public DiagnosticFunc(string? category, Func<T1, T2, T3, T4, T5, TResult> func) : this(category, null, func) { }

        /// <summary/>
        public DiagnosticFunc(string? category, object? data, Func<T1, T2, T3, T4, T5, TResult> func)
        {
            _func = func.Diagnostic(category, data);
        }

        /// <summary/>
        public TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) => _func(arg1, arg2, arg3, arg4, arg5);

        /// <summary>
        /// Implicit convert DiagnosticFunc to Func
        /// </summary>
        public static implicit operator Func<T1, T2, T3, T4, T5, TResult>(DiagnosticFunc<T1, T2, T3, T4, T5, TResult> func)
        {
            return func._func;
        }
    }
    
    /// <summary>
    /// Func diagnostic message
    /// </summary>
    public struct DiagnosticFunc<T1, T2, T3, T4, T5, T6, TResult>
    {
        private readonly Func<T1, T2, T3, T4, T5, T6, TResult> _func;

        /// <summary/>
        public DiagnosticFunc(Func<T1, T2, T3, T4, T5, T6, TResult> func) : this(null, null, func) { }

        /// <summary/>
        public DiagnosticFunc(string? category, Func<T1, T2, T3, T4, T5, T6, TResult> func) : this(category, null, func) { }

        /// <summary/>
        public DiagnosticFunc(string? category, object? data, Func<T1, T2, T3, T4, T5, T6, TResult> func)
        {
            _func = func.Diagnostic(category, data);
        }

        /// <summary/>
        public TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) => _func(arg1, arg2, arg3, arg4, arg5, arg6);

        /// <summary>
        /// Implicit convert DiagnosticFunc to Func
        /// </summary>
        public static implicit operator Func<T1, T2, T3, T4, T5, T6, TResult>(DiagnosticFunc<T1, T2, T3, T4, T5, T6, TResult> func)
        {
            return func._func;
        }
    }
    
    /// <summary>
    /// Func diagnostic message
    /// </summary>
    public struct DiagnosticFunc<T1, T2, T3, T4, T5, T6, T7, TResult>
    {
        private readonly Func<T1, T2, T3, T4, T5, T6, T7, TResult> _func;

        /// <summary/>
        public DiagnosticFunc(Func<T1, T2, T3, T4, T5, T6, T7, TResult> func) : this(null, null, func) { }

        /// <summary/>
        public DiagnosticFunc(string? category, Func<T1, T2, T3, T4, T5, T6, T7, TResult> func) : this(category, null, func) { }

        /// <summary/>
        public DiagnosticFunc(string? category, object? data, Func<T1, T2, T3, T4, T5, T6, T7, TResult> func)
        {
            _func = func.Diagnostic(category, data);
        }

        /// <summary/>
        public TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) => _func(arg1, arg2, arg3, arg4, arg5, arg6, arg7);

        /// <summary>
        /// Implicit convert DiagnosticFunc to Func
        /// </summary>
        public static implicit operator Func<T1, T2, T3, T4, T5, T6, T7, TResult>(DiagnosticFunc<T1, T2, T3, T4, T5, T6, T7, TResult> func)
        {
            return func._func;
        }
    }
    
    /// <summary>
    /// Func diagnostic message
    /// </summary>
    public struct DiagnosticFunc<T1, T2, T3, T4, T5, T6, T7, T8, TResult>
    {
        private readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> _func;

        /// <summary/>
        public DiagnosticFunc(Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> func) : this(null, null, func) { }

        /// <summary/>
        public DiagnosticFunc(string? category, Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> func) : this(category, null, func) { }

        /// <summary/>
        public DiagnosticFunc(string? category, object? data, Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> func)
        {
            _func = func.Diagnostic(category, data);
        }

        /// <summary/>
        public TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) => _func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);

        /// <summary>
        /// Implicit convert DiagnosticFunc to Func
        /// </summary>
        public static implicit operator Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(DiagnosticFunc<T1, T2, T3, T4, T5, T6, T7, T8, TResult> func)
        {
            return func._func;
        }
    }
    
    /// <summary>
    /// Func diagnostic message
    /// </summary>
    public struct DiagnosticFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>
    {
        private readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> _func;

        /// <summary/>
        public DiagnosticFunc(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> func) : this(null, null, func) { }

        /// <summary/>
        public DiagnosticFunc(string? category, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> func) : this(category, null, func) { }

        /// <summary/>
        public DiagnosticFunc(string? category, object? data, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> func)
        {
            _func = func.Diagnostic(category, data);
        }

        /// <summary/>
        public TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) => _func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);

        /// <summary>
        /// Implicit convert DiagnosticFunc to Func
        /// </summary>
        public static implicit operator Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(DiagnosticFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> func)
        {
            return func._func;
        }
    }
    
    /// <summary>
    /// Func diagnostic message
    /// </summary>
    public struct DiagnosticFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>
    {
        private readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> _func;

        /// <summary/>
        public DiagnosticFunc(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> func) : this(null, null, func) { }

        /// <summary/>
        public DiagnosticFunc(string? category, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> func) : this(category, null, func) { }

        /// <summary/>
        public DiagnosticFunc(string? category, object? data, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> func)
        {
            _func = func.Diagnostic(category, data);
        }

        /// <summary/>
        public TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) => _func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);

        /// <summary>
        /// Implicit convert DiagnosticFunc to Func
        /// </summary>
        public static implicit operator Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(DiagnosticFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> func)
        {
            return func._func;
        }
    }
    
    /// <summary>
    /// Func diagnostic message
    /// </summary>
    public struct DiagnosticFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>
    {
        private readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> _func;

        /// <summary/>
        public DiagnosticFunc(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> func) : this(null, null, func) { }

        /// <summary/>
        public DiagnosticFunc(string? category, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> func) : this(category, null, func) { }

        /// <summary/>
        public DiagnosticFunc(string? category, object? data, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> func)
        {
            _func = func.Diagnostic(category, data);
        }

        /// <summary/>
        public TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) => _func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);

        /// <summary>
        /// Implicit convert DiagnosticFunc to Func
        /// </summary>
        public static implicit operator Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(DiagnosticFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> func)
        {
            return func._func;
        }
    }
    
    /// <summary>
    /// Func diagnostic message
    /// </summary>
    public struct DiagnosticFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>
    {
        private readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> _func;

        /// <summary/>
        public DiagnosticFunc(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> func) : this(null, null, func) { }

        /// <summary/>
        public DiagnosticFunc(string? category, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> func) : this(category, null, func) { }

        /// <summary/>
        public DiagnosticFunc(string? category, object? data, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> func)
        {
            _func = func.Diagnostic(category, data);
        }

        /// <summary/>
        public TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) => _func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);

        /// <summary>
        /// Implicit convert DiagnosticFunc to Func
        /// </summary>
        public static implicit operator Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(DiagnosticFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> func)
        {
            return func._func;
        }
    }
    
    /// <summary>
    /// Func diagnostic message
    /// </summary>
    public struct DiagnosticFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>
    {
        private readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> _func;

        /// <summary/>
        public DiagnosticFunc(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> func) : this(null, null, func) { }

        /// <summary/>
        public DiagnosticFunc(string? category, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> func) : this(category, null, func) { }

        /// <summary/>
        public DiagnosticFunc(string? category, object? data, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> func)
        {
            _func = func.Diagnostic(category, data);
        }

        /// <summary/>
        public TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13) => _func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);

        /// <summary>
        /// Implicit convert DiagnosticFunc to Func
        /// </summary>
        public static implicit operator Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(DiagnosticFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> func)
        {
            return func._func;
        }
    }
    
    /// <summary>
    /// Func diagnostic message
    /// </summary>
    public struct DiagnosticFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>
    {
        private readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> _func;

        /// <summary/>
        public DiagnosticFunc(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> func) : this(null, null, func) { }

        /// <summary/>
        public DiagnosticFunc(string? category, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> func) : this(category, null, func) { }

        /// <summary/>
        public DiagnosticFunc(string? category, object? data, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> func)
        {
            _func = func.Diagnostic(category, data);
        }

        /// <summary/>
        public TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14) => _func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);

        /// <summary>
        /// Implicit convert DiagnosticFunc to Func
        /// </summary>
        public static implicit operator Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(DiagnosticFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> func)
        {
            return func._func;
        }
    }
    
    /// <summary>
    /// Func diagnostic message
    /// </summary>
    public struct DiagnosticFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>
    {
        private readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> _func;

        /// <summary/>
        public DiagnosticFunc(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> func) : this(null, null, func) { }

        /// <summary/>
        public DiagnosticFunc(string? category, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> func) : this(category, null, func) { }

        /// <summary/>
        public DiagnosticFunc(string? category, object? data, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> func)
        {
            _func = func.Diagnostic(category, data);
        }

        /// <summary/>
        public TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15) => _func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);

        /// <summary>
        /// Implicit convert DiagnosticFunc to Func
        /// </summary>
        public static implicit operator Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(DiagnosticFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> func)
        {
            return func._func;
        }
    }
    
    /// <summary>
    /// Func diagnostic message
    /// </summary>
    public struct DiagnosticFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>
    {
        private readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> _func;

        /// <summary/>
        public DiagnosticFunc(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> func) : this(null, null, func) { }

        /// <summary/>
        public DiagnosticFunc(string? category, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> func) : this(category, null, func) { }

        /// <summary/>
        public DiagnosticFunc(string? category, object? data, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> func)
        {
            _func = func.Diagnostic(category, data);
        }

        /// <summary/>
        public TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16) => _func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);

        /// <summary>
        /// Implicit convert DiagnosticFunc to Func
        /// </summary>
        public static implicit operator Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(DiagnosticFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> func)
        {
            return func._func;
        }
    }
    
}