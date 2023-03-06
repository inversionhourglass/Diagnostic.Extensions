using System.ComponentModel;
using System.Threading.Tasks;

namespace System
{
    
    /// <summary>
    /// Func diagnostic message
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("Infact we don't need DiagnosticGenericTaskFunc, DiagnosticFunc is enough")]
    public struct DiagnosticGenericTaskFunc<TResult>
    {
        private readonly Func<Task<TResult>> _func;

        /// <summary/>
        public DiagnosticGenericTaskFunc(Func<Task<TResult>> func) : this(null, null, func) { }

        /// <summary/>
        public DiagnosticGenericTaskFunc(string? category, Func<Task<TResult>> func) : this(category, null, func) { }

        /// <summary/>
        public DiagnosticGenericTaskFunc(string? category, object? data, Func<Task<TResult>> func)
        {
            _func = func.Diagnostic(category, data);
        }

        /// <summary/>
        public Task<TResult> Invoke() => _func();

        /// <summary>
        /// Implicit convert DiagnosticGenericTaskFunc to Func
        /// </summary>
        public static implicit operator Func<Task<TResult>>(DiagnosticGenericTaskFunc<TResult> func)
        {
            return func._func;
        }
    }
    
    /// <summary>
    /// Func diagnostic message
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("Infact we don't need DiagnosticGenericTaskFunc, DiagnosticFunc is enough")]
    public struct DiagnosticGenericTaskFunc<T, TResult>
    {
        private readonly Func<T, Task<TResult>> _func;

        /// <summary/>
        public DiagnosticGenericTaskFunc(Func<T, Task<TResult>> func) : this(null, null, func) { }

        /// <summary/>
        public DiagnosticGenericTaskFunc(string? category, Func<T, Task<TResult>> func) : this(category, null, func) { }

        /// <summary/>
        public DiagnosticGenericTaskFunc(string? category, object? data, Func<T, Task<TResult>> func)
        {
            _func = func.Diagnostic(category, data);
        }

        /// <summary/>
        public Task<TResult> Invoke(T arg) => _func(arg);

        /// <summary>
        /// Implicit convert DiagnosticGenericTaskFunc to Func
        /// </summary>
        public static implicit operator Func<T, Task<TResult>>(DiagnosticGenericTaskFunc<T, TResult> func)
        {
            return func._func;
        }
    }
    
    /// <summary>
    /// Func diagnostic message
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("Infact we don't need DiagnosticGenericTaskFunc, DiagnosticFunc is enough")]
    public struct DiagnosticGenericTaskFunc<T1, T2, TResult>
    {
        private readonly Func<T1, T2, Task<TResult>> _func;

        /// <summary/>
        public DiagnosticGenericTaskFunc(Func<T1, T2, Task<TResult>> func) : this(null, null, func) { }

        /// <summary/>
        public DiagnosticGenericTaskFunc(string? category, Func<T1, T2, Task<TResult>> func) : this(category, null, func) { }

        /// <summary/>
        public DiagnosticGenericTaskFunc(string? category, object? data, Func<T1, T2, Task<TResult>> func)
        {
            _func = func.Diagnostic(category, data);
        }

        /// <summary/>
        public Task<TResult> Invoke(T1 arg1, T2 arg2) => _func(arg1, arg2);

        /// <summary>
        /// Implicit convert DiagnosticGenericTaskFunc to Func
        /// </summary>
        public static implicit operator Func<T1, T2, Task<TResult>>(DiagnosticGenericTaskFunc<T1, T2, TResult> func)
        {
            return func._func;
        }
    }
    
    /// <summary>
    /// Func diagnostic message
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("Infact we don't need DiagnosticGenericTaskFunc, DiagnosticFunc is enough")]
    public struct DiagnosticGenericTaskFunc<T1, T2, T3, TResult>
    {
        private readonly Func<T1, T2, T3, Task<TResult>> _func;

        /// <summary/>
        public DiagnosticGenericTaskFunc(Func<T1, T2, T3, Task<TResult>> func) : this(null, null, func) { }

        /// <summary/>
        public DiagnosticGenericTaskFunc(string? category, Func<T1, T2, T3, Task<TResult>> func) : this(category, null, func) { }

        /// <summary/>
        public DiagnosticGenericTaskFunc(string? category, object? data, Func<T1, T2, T3, Task<TResult>> func)
        {
            _func = func.Diagnostic(category, data);
        }

        /// <summary/>
        public Task<TResult> Invoke(T1 arg1, T2 arg2, T3 arg3) => _func(arg1, arg2, arg3);

        /// <summary>
        /// Implicit convert DiagnosticGenericTaskFunc to Func
        /// </summary>
        public static implicit operator Func<T1, T2, T3, Task<TResult>>(DiagnosticGenericTaskFunc<T1, T2, T3, TResult> func)
        {
            return func._func;
        }
    }
    
    /// <summary>
    /// Func diagnostic message
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("Infact we don't need DiagnosticGenericTaskFunc, DiagnosticFunc is enough")]
    public struct DiagnosticGenericTaskFunc<T1, T2, T3, T4, TResult>
    {
        private readonly Func<T1, T2, T3, T4, Task<TResult>> _func;

        /// <summary/>
        public DiagnosticGenericTaskFunc(Func<T1, T2, T3, T4, Task<TResult>> func) : this(null, null, func) { }

        /// <summary/>
        public DiagnosticGenericTaskFunc(string? category, Func<T1, T2, T3, T4, Task<TResult>> func) : this(category, null, func) { }

        /// <summary/>
        public DiagnosticGenericTaskFunc(string? category, object? data, Func<T1, T2, T3, T4, Task<TResult>> func)
        {
            _func = func.Diagnostic(category, data);
        }

        /// <summary/>
        public Task<TResult> Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4) => _func(arg1, arg2, arg3, arg4);

        /// <summary>
        /// Implicit convert DiagnosticGenericTaskFunc to Func
        /// </summary>
        public static implicit operator Func<T1, T2, T3, T4, Task<TResult>>(DiagnosticGenericTaskFunc<T1, T2, T3, T4, TResult> func)
        {
            return func._func;
        }
    }
    
    /// <summary>
    /// Func diagnostic message
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("Infact we don't need DiagnosticGenericTaskFunc, DiagnosticFunc is enough")]
    public struct DiagnosticGenericTaskFunc<T1, T2, T3, T4, T5, TResult>
    {
        private readonly Func<T1, T2, T3, T4, T5, Task<TResult>> _func;

        /// <summary/>
        public DiagnosticGenericTaskFunc(Func<T1, T2, T3, T4, T5, Task<TResult>> func) : this(null, null, func) { }

        /// <summary/>
        public DiagnosticGenericTaskFunc(string? category, Func<T1, T2, T3, T4, T5, Task<TResult>> func) : this(category, null, func) { }

        /// <summary/>
        public DiagnosticGenericTaskFunc(string? category, object? data, Func<T1, T2, T3, T4, T5, Task<TResult>> func)
        {
            _func = func.Diagnostic(category, data);
        }

        /// <summary/>
        public Task<TResult> Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) => _func(arg1, arg2, arg3, arg4, arg5);

        /// <summary>
        /// Implicit convert DiagnosticGenericTaskFunc to Func
        /// </summary>
        public static implicit operator Func<T1, T2, T3, T4, T5, Task<TResult>>(DiagnosticGenericTaskFunc<T1, T2, T3, T4, T5, TResult> func)
        {
            return func._func;
        }
    }
    
    /// <summary>
    /// Func diagnostic message
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("Infact we don't need DiagnosticGenericTaskFunc, DiagnosticFunc is enough")]
    public struct DiagnosticGenericTaskFunc<T1, T2, T3, T4, T5, T6, TResult>
    {
        private readonly Func<T1, T2, T3, T4, T5, T6, Task<TResult>> _func;

        /// <summary/>
        public DiagnosticGenericTaskFunc(Func<T1, T2, T3, T4, T5, T6, Task<TResult>> func) : this(null, null, func) { }

        /// <summary/>
        public DiagnosticGenericTaskFunc(string? category, Func<T1, T2, T3, T4, T5, T6, Task<TResult>> func) : this(category, null, func) { }

        /// <summary/>
        public DiagnosticGenericTaskFunc(string? category, object? data, Func<T1, T2, T3, T4, T5, T6, Task<TResult>> func)
        {
            _func = func.Diagnostic(category, data);
        }

        /// <summary/>
        public Task<TResult> Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) => _func(arg1, arg2, arg3, arg4, arg5, arg6);

        /// <summary>
        /// Implicit convert DiagnosticGenericTaskFunc to Func
        /// </summary>
        public static implicit operator Func<T1, T2, T3, T4, T5, T6, Task<TResult>>(DiagnosticGenericTaskFunc<T1, T2, T3, T4, T5, T6, TResult> func)
        {
            return func._func;
        }
    }
    
    /// <summary>
    /// Func diagnostic message
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("Infact we don't need DiagnosticGenericTaskFunc, DiagnosticFunc is enough")]
    public struct DiagnosticGenericTaskFunc<T1, T2, T3, T4, T5, T6, T7, TResult>
    {
        private readonly Func<T1, T2, T3, T4, T5, T6, T7, Task<TResult>> _func;

        /// <summary/>
        public DiagnosticGenericTaskFunc(Func<T1, T2, T3, T4, T5, T6, T7, Task<TResult>> func) : this(null, null, func) { }

        /// <summary/>
        public DiagnosticGenericTaskFunc(string? category, Func<T1, T2, T3, T4, T5, T6, T7, Task<TResult>> func) : this(category, null, func) { }

        /// <summary/>
        public DiagnosticGenericTaskFunc(string? category, object? data, Func<T1, T2, T3, T4, T5, T6, T7, Task<TResult>> func)
        {
            _func = func.Diagnostic(category, data);
        }

        /// <summary/>
        public Task<TResult> Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) => _func(arg1, arg2, arg3, arg4, arg5, arg6, arg7);

        /// <summary>
        /// Implicit convert DiagnosticGenericTaskFunc to Func
        /// </summary>
        public static implicit operator Func<T1, T2, T3, T4, T5, T6, T7, Task<TResult>>(DiagnosticGenericTaskFunc<T1, T2, T3, T4, T5, T6, T7, TResult> func)
        {
            return func._func;
        }
    }
    
    /// <summary>
    /// Func diagnostic message
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("Infact we don't need DiagnosticGenericTaskFunc, DiagnosticFunc is enough")]
    public struct DiagnosticGenericTaskFunc<T1, T2, T3, T4, T5, T6, T7, T8, TResult>
    {
        private readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, Task<TResult>> _func;

        /// <summary/>
        public DiagnosticGenericTaskFunc(Func<T1, T2, T3, T4, T5, T6, T7, T8, Task<TResult>> func) : this(null, null, func) { }

        /// <summary/>
        public DiagnosticGenericTaskFunc(string? category, Func<T1, T2, T3, T4, T5, T6, T7, T8, Task<TResult>> func) : this(category, null, func) { }

        /// <summary/>
        public DiagnosticGenericTaskFunc(string? category, object? data, Func<T1, T2, T3, T4, T5, T6, T7, T8, Task<TResult>> func)
        {
            _func = func.Diagnostic(category, data);
        }

        /// <summary/>
        public Task<TResult> Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) => _func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);

        /// <summary>
        /// Implicit convert DiagnosticGenericTaskFunc to Func
        /// </summary>
        public static implicit operator Func<T1, T2, T3, T4, T5, T6, T7, T8, Task<TResult>>(DiagnosticGenericTaskFunc<T1, T2, T3, T4, T5, T6, T7, T8, TResult> func)
        {
            return func._func;
        }
    }
    
    /// <summary>
    /// Func diagnostic message
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("Infact we don't need DiagnosticGenericTaskFunc, DiagnosticFunc is enough")]
    public struct DiagnosticGenericTaskFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>
    {
        private readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task<TResult>> _func;

        /// <summary/>
        public DiagnosticGenericTaskFunc(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task<TResult>> func) : this(null, null, func) { }

        /// <summary/>
        public DiagnosticGenericTaskFunc(string? category, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task<TResult>> func) : this(category, null, func) { }

        /// <summary/>
        public DiagnosticGenericTaskFunc(string? category, object? data, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task<TResult>> func)
        {
            _func = func.Diagnostic(category, data);
        }

        /// <summary/>
        public Task<TResult> Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) => _func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);

        /// <summary>
        /// Implicit convert DiagnosticGenericTaskFunc to Func
        /// </summary>
        public static implicit operator Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task<TResult>>(DiagnosticGenericTaskFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> func)
        {
            return func._func;
        }
    }
    
    /// <summary>
    /// Func diagnostic message
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("Infact we don't need DiagnosticGenericTaskFunc, DiagnosticFunc is enough")]
    public struct DiagnosticGenericTaskFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>
    {
        private readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task<TResult>> _func;

        /// <summary/>
        public DiagnosticGenericTaskFunc(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task<TResult>> func) : this(null, null, func) { }

        /// <summary/>
        public DiagnosticGenericTaskFunc(string? category, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task<TResult>> func) : this(category, null, func) { }

        /// <summary/>
        public DiagnosticGenericTaskFunc(string? category, object? data, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task<TResult>> func)
        {
            _func = func.Diagnostic(category, data);
        }

        /// <summary/>
        public Task<TResult> Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) => _func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);

        /// <summary>
        /// Implicit convert DiagnosticGenericTaskFunc to Func
        /// </summary>
        public static implicit operator Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task<TResult>>(DiagnosticGenericTaskFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> func)
        {
            return func._func;
        }
    }
    
    /// <summary>
    /// Func diagnostic message
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("Infact we don't need DiagnosticGenericTaskFunc, DiagnosticFunc is enough")]
    public struct DiagnosticGenericTaskFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>
    {
        private readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task<TResult>> _func;

        /// <summary/>
        public DiagnosticGenericTaskFunc(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task<TResult>> func) : this(null, null, func) { }

        /// <summary/>
        public DiagnosticGenericTaskFunc(string? category, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task<TResult>> func) : this(category, null, func) { }

        /// <summary/>
        public DiagnosticGenericTaskFunc(string? category, object? data, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task<TResult>> func)
        {
            _func = func.Diagnostic(category, data);
        }

        /// <summary/>
        public Task<TResult> Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) => _func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);

        /// <summary>
        /// Implicit convert DiagnosticGenericTaskFunc to Func
        /// </summary>
        public static implicit operator Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task<TResult>>(DiagnosticGenericTaskFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> func)
        {
            return func._func;
        }
    }
    
    /// <summary>
    /// Func diagnostic message
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("Infact we don't need DiagnosticGenericTaskFunc, DiagnosticFunc is enough")]
    public struct DiagnosticGenericTaskFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>
    {
        private readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task<TResult>> _func;

        /// <summary/>
        public DiagnosticGenericTaskFunc(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task<TResult>> func) : this(null, null, func) { }

        /// <summary/>
        public DiagnosticGenericTaskFunc(string? category, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task<TResult>> func) : this(category, null, func) { }

        /// <summary/>
        public DiagnosticGenericTaskFunc(string? category, object? data, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task<TResult>> func)
        {
            _func = func.Diagnostic(category, data);
        }

        /// <summary/>
        public Task<TResult> Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) => _func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);

        /// <summary>
        /// Implicit convert DiagnosticGenericTaskFunc to Func
        /// </summary>
        public static implicit operator Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task<TResult>>(DiagnosticGenericTaskFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> func)
        {
            return func._func;
        }
    }
    
    /// <summary>
    /// Func diagnostic message
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("Infact we don't need DiagnosticGenericTaskFunc, DiagnosticFunc is enough")]
    public struct DiagnosticGenericTaskFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>
    {
        private readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task<TResult>> _func;

        /// <summary/>
        public DiagnosticGenericTaskFunc(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task<TResult>> func) : this(null, null, func) { }

        /// <summary/>
        public DiagnosticGenericTaskFunc(string? category, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task<TResult>> func) : this(category, null, func) { }

        /// <summary/>
        public DiagnosticGenericTaskFunc(string? category, object? data, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task<TResult>> func)
        {
            _func = func.Diagnostic(category, data);
        }

        /// <summary/>
        public Task<TResult> Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13) => _func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);

        /// <summary>
        /// Implicit convert DiagnosticGenericTaskFunc to Func
        /// </summary>
        public static implicit operator Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task<TResult>>(DiagnosticGenericTaskFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> func)
        {
            return func._func;
        }
    }
    
    /// <summary>
    /// Func diagnostic message
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("Infact we don't need DiagnosticGenericTaskFunc, DiagnosticFunc is enough")]
    public struct DiagnosticGenericTaskFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>
    {
        private readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task<TResult>> _func;

        /// <summary/>
        public DiagnosticGenericTaskFunc(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task<TResult>> func) : this(null, null, func) { }

        /// <summary/>
        public DiagnosticGenericTaskFunc(string? category, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task<TResult>> func) : this(category, null, func) { }

        /// <summary/>
        public DiagnosticGenericTaskFunc(string? category, object? data, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task<TResult>> func)
        {
            _func = func.Diagnostic(category, data);
        }

        /// <summary/>
        public Task<TResult> Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14) => _func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);

        /// <summary>
        /// Implicit convert DiagnosticGenericTaskFunc to Func
        /// </summary>
        public static implicit operator Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task<TResult>>(DiagnosticGenericTaskFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> func)
        {
            return func._func;
        }
    }
    
    /// <summary>
    /// Func diagnostic message
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("Infact we don't need DiagnosticGenericTaskFunc, DiagnosticFunc is enough")]
    public struct DiagnosticGenericTaskFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>
    {
        private readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task<TResult>> _func;

        /// <summary/>
        public DiagnosticGenericTaskFunc(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task<TResult>> func) : this(null, null, func) { }

        /// <summary/>
        public DiagnosticGenericTaskFunc(string? category, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task<TResult>> func) : this(category, null, func) { }

        /// <summary/>
        public DiagnosticGenericTaskFunc(string? category, object? data, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task<TResult>> func)
        {
            _func = func.Diagnostic(category, data);
        }

        /// <summary/>
        public Task<TResult> Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15) => _func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);

        /// <summary>
        /// Implicit convert DiagnosticGenericTaskFunc to Func
        /// </summary>
        public static implicit operator Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task<TResult>>(DiagnosticGenericTaskFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> func)
        {
            return func._func;
        }
    }
    
    /// <summary>
    /// Func diagnostic message
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("Infact we don't need DiagnosticGenericTaskFunc, DiagnosticFunc is enough")]
    public struct DiagnosticGenericTaskFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>
    {
        private readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task<TResult>> _func;

        /// <summary/>
        public DiagnosticGenericTaskFunc(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task<TResult>> func) : this(null, null, func) { }

        /// <summary/>
        public DiagnosticGenericTaskFunc(string? category, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task<TResult>> func) : this(category, null, func) { }

        /// <summary/>
        public DiagnosticGenericTaskFunc(string? category, object? data, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task<TResult>> func)
        {
            _func = func.Diagnostic(category, data);
        }

        /// <summary/>
        public Task<TResult> Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16) => _func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);

        /// <summary>
        /// Implicit convert DiagnosticGenericTaskFunc to Func
        /// </summary>
        public static implicit operator Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task<TResult>>(DiagnosticGenericTaskFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> func)
        {
            return func._func;
        }
    }
    
}