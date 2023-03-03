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

        /// <summary>
        /// Implicit convert DiagnosticFunc to Func
        /// </summary>
        public static implicit operator Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(DiagnosticFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> func)
        {
            return func._func;
        }
    }
    
}