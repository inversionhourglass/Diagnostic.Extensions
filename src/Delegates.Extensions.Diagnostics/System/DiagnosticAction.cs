namespace System
{
    
    /// <summary>
    /// Action diagnostic message
    /// </summary>
    public struct DiagnosticAction
    {
        private readonly Action _action;

        /// <summary/>
        public DiagnosticAction(Action action) : this(null, null, action) { }

        /// <summary/>
        public DiagnosticAction(string? category, Action action) : this(category, null, action) { }

        /// <summary/>
        public DiagnosticAction(string? category, object? data, Action action)
        {
            _action = action.Diagnostic(category, data);
        }

        /// <summary/>
        public void Invoke() => _action();

        /// <summary>
        /// Implicit convert DiagnosticAction to Action
        /// </summary>
        public static implicit operator Action(DiagnosticAction action)
        {
            return action._action;
        }
    }
    
    /// <summary>
    /// Action diagnostic message
    /// </summary>
    public struct DiagnosticAction<T>
    {
        private readonly Action<T> _action;

        /// <summary/>
        public DiagnosticAction(Action<T> action) : this(null, null, action) { }

        /// <summary/>
        public DiagnosticAction(string? category, Action<T> action) : this(category, null, action) { }

        /// <summary/>
        public DiagnosticAction(string? category, object? data, Action<T> action)
        {
            _action = action.Diagnostic(category, data);
        }

        /// <summary/>
        public void Invoke(T arg) => _action(arg);

        /// <summary>
        /// Implicit convert DiagnosticAction to Action
        /// </summary>
        public static implicit operator Action<T>(DiagnosticAction<T> action)
        {
            return action._action;
        }
    }
    
    /// <summary>
    /// Action diagnostic message
    /// </summary>
    public struct DiagnosticAction<T1, T2>
    {
        private readonly Action<T1, T2> _action;

        /// <summary/>
        public DiagnosticAction(Action<T1, T2> action) : this(null, null, action) { }

        /// <summary/>
        public DiagnosticAction(string? category, Action<T1, T2> action) : this(category, null, action) { }

        /// <summary/>
        public DiagnosticAction(string? category, object? data, Action<T1, T2> action)
        {
            _action = action.Diagnostic(category, data);
        }

        /// <summary/>
        public void Invoke(T1 arg1, T2 arg2) => _action(arg1, arg2);

        /// <summary>
        /// Implicit convert DiagnosticAction to Action
        /// </summary>
        public static implicit operator Action<T1, T2>(DiagnosticAction<T1, T2> action)
        {
            return action._action;
        }
    }
    
    /// <summary>
    /// Action diagnostic message
    /// </summary>
    public struct DiagnosticAction<T1, T2, T3>
    {
        private readonly Action<T1, T2, T3> _action;

        /// <summary/>
        public DiagnosticAction(Action<T1, T2, T3> action) : this(null, null, action) { }

        /// <summary/>
        public DiagnosticAction(string? category, Action<T1, T2, T3> action) : this(category, null, action) { }

        /// <summary/>
        public DiagnosticAction(string? category, object? data, Action<T1, T2, T3> action)
        {
            _action = action.Diagnostic(category, data);
        }

        /// <summary/>
        public void Invoke(T1 arg1, T2 arg2, T3 arg3) => _action(arg1, arg2, arg3);

        /// <summary>
        /// Implicit convert DiagnosticAction to Action
        /// </summary>
        public static implicit operator Action<T1, T2, T3>(DiagnosticAction<T1, T2, T3> action)
        {
            return action._action;
        }
    }
    
    /// <summary>
    /// Action diagnostic message
    /// </summary>
    public struct DiagnosticAction<T1, T2, T3, T4>
    {
        private readonly Action<T1, T2, T3, T4> _action;

        /// <summary/>
        public DiagnosticAction(Action<T1, T2, T3, T4> action) : this(null, null, action) { }

        /// <summary/>
        public DiagnosticAction(string? category, Action<T1, T2, T3, T4> action) : this(category, null, action) { }

        /// <summary/>
        public DiagnosticAction(string? category, object? data, Action<T1, T2, T3, T4> action)
        {
            _action = action.Diagnostic(category, data);
        }

        /// <summary/>
        public void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4) => _action(arg1, arg2, arg3, arg4);

        /// <summary>
        /// Implicit convert DiagnosticAction to Action
        /// </summary>
        public static implicit operator Action<T1, T2, T3, T4>(DiagnosticAction<T1, T2, T3, T4> action)
        {
            return action._action;
        }
    }
    
    /// <summary>
    /// Action diagnostic message
    /// </summary>
    public struct DiagnosticAction<T1, T2, T3, T4, T5>
    {
        private readonly Action<T1, T2, T3, T4, T5> _action;

        /// <summary/>
        public DiagnosticAction(Action<T1, T2, T3, T4, T5> action) : this(null, null, action) { }

        /// <summary/>
        public DiagnosticAction(string? category, Action<T1, T2, T3, T4, T5> action) : this(category, null, action) { }

        /// <summary/>
        public DiagnosticAction(string? category, object? data, Action<T1, T2, T3, T4, T5> action)
        {
            _action = action.Diagnostic(category, data);
        }

        /// <summary/>
        public void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) => _action(arg1, arg2, arg3, arg4, arg5);

        /// <summary>
        /// Implicit convert DiagnosticAction to Action
        /// </summary>
        public static implicit operator Action<T1, T2, T3, T4, T5>(DiagnosticAction<T1, T2, T3, T4, T5> action)
        {
            return action._action;
        }
    }
    
    /// <summary>
    /// Action diagnostic message
    /// </summary>
    public struct DiagnosticAction<T1, T2, T3, T4, T5, T6>
    {
        private readonly Action<T1, T2, T3, T4, T5, T6> _action;

        /// <summary/>
        public DiagnosticAction(Action<T1, T2, T3, T4, T5, T6> action) : this(null, null, action) { }

        /// <summary/>
        public DiagnosticAction(string? category, Action<T1, T2, T3, T4, T5, T6> action) : this(category, null, action) { }

        /// <summary/>
        public DiagnosticAction(string? category, object? data, Action<T1, T2, T3, T4, T5, T6> action)
        {
            _action = action.Diagnostic(category, data);
        }

        /// <summary/>
        public void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) => _action(arg1, arg2, arg3, arg4, arg5, arg6);

        /// <summary>
        /// Implicit convert DiagnosticAction to Action
        /// </summary>
        public static implicit operator Action<T1, T2, T3, T4, T5, T6>(DiagnosticAction<T1, T2, T3, T4, T5, T6> action)
        {
            return action._action;
        }
    }
    
    /// <summary>
    /// Action diagnostic message
    /// </summary>
    public struct DiagnosticAction<T1, T2, T3, T4, T5, T6, T7>
    {
        private readonly Action<T1, T2, T3, T4, T5, T6, T7> _action;

        /// <summary/>
        public DiagnosticAction(Action<T1, T2, T3, T4, T5, T6, T7> action) : this(null, null, action) { }

        /// <summary/>
        public DiagnosticAction(string? category, Action<T1, T2, T3, T4, T5, T6, T7> action) : this(category, null, action) { }

        /// <summary/>
        public DiagnosticAction(string? category, object? data, Action<T1, T2, T3, T4, T5, T6, T7> action)
        {
            _action = action.Diagnostic(category, data);
        }

        /// <summary/>
        public void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) => _action(arg1, arg2, arg3, arg4, arg5, arg6, arg7);

        /// <summary>
        /// Implicit convert DiagnosticAction to Action
        /// </summary>
        public static implicit operator Action<T1, T2, T3, T4, T5, T6, T7>(DiagnosticAction<T1, T2, T3, T4, T5, T6, T7> action)
        {
            return action._action;
        }
    }
    
    /// <summary>
    /// Action diagnostic message
    /// </summary>
    public struct DiagnosticAction<T1, T2, T3, T4, T5, T6, T7, T8>
    {
        private readonly Action<T1, T2, T3, T4, T5, T6, T7, T8> _action;

        /// <summary/>
        public DiagnosticAction(Action<T1, T2, T3, T4, T5, T6, T7, T8> action) : this(null, null, action) { }

        /// <summary/>
        public DiagnosticAction(string? category, Action<T1, T2, T3, T4, T5, T6, T7, T8> action) : this(category, null, action) { }

        /// <summary/>
        public DiagnosticAction(string? category, object? data, Action<T1, T2, T3, T4, T5, T6, T7, T8> action)
        {
            _action = action.Diagnostic(category, data);
        }

        /// <summary/>
        public void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) => _action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);

        /// <summary>
        /// Implicit convert DiagnosticAction to Action
        /// </summary>
        public static implicit operator Action<T1, T2, T3, T4, T5, T6, T7, T8>(DiagnosticAction<T1, T2, T3, T4, T5, T6, T7, T8> action)
        {
            return action._action;
        }
    }
    
    /// <summary>
    /// Action diagnostic message
    /// </summary>
    public struct DiagnosticAction<T1, T2, T3, T4, T5, T6, T7, T8, T9>
    {
        private readonly Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> _action;

        /// <summary/>
        public DiagnosticAction(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action) : this(null, null, action) { }

        /// <summary/>
        public DiagnosticAction(string? category, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action) : this(category, null, action) { }

        /// <summary/>
        public DiagnosticAction(string? category, object? data, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action)
        {
            _action = action.Diagnostic(category, data);
        }

        /// <summary/>
        public void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) => _action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);

        /// <summary>
        /// Implicit convert DiagnosticAction to Action
        /// </summary>
        public static implicit operator Action<T1, T2, T3, T4, T5, T6, T7, T8, T9>(DiagnosticAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> action)
        {
            return action._action;
        }
    }
    
    /// <summary>
    /// Action diagnostic message
    /// </summary>
    public struct DiagnosticAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
    {
        private readonly Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> _action;

        /// <summary/>
        public DiagnosticAction(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action) : this(null, null, action) { }

        /// <summary/>
        public DiagnosticAction(string? category, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action) : this(category, null, action) { }

        /// <summary/>
        public DiagnosticAction(string? category, object? data, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action)
        {
            _action = action.Diagnostic(category, data);
        }

        /// <summary/>
        public void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) => _action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);

        /// <summary>
        /// Implicit convert DiagnosticAction to Action
        /// </summary>
        public static implicit operator Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(DiagnosticAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action)
        {
            return action._action;
        }
    }
    
    /// <summary>
    /// Action diagnostic message
    /// </summary>
    public struct DiagnosticAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
    {
        private readonly Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> _action;

        /// <summary/>
        public DiagnosticAction(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action) : this(null, null, action) { }

        /// <summary/>
        public DiagnosticAction(string? category, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action) : this(category, null, action) { }

        /// <summary/>
        public DiagnosticAction(string? category, object? data, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action)
        {
            _action = action.Diagnostic(category, data);
        }

        /// <summary/>
        public void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) => _action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);

        /// <summary>
        /// Implicit convert DiagnosticAction to Action
        /// </summary>
        public static implicit operator Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(DiagnosticAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action)
        {
            return action._action;
        }
    }
    
    /// <summary>
    /// Action diagnostic message
    /// </summary>
    public struct DiagnosticAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
    {
        private readonly Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> _action;

        /// <summary/>
        public DiagnosticAction(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action) : this(null, null, action) { }

        /// <summary/>
        public DiagnosticAction(string? category, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action) : this(category, null, action) { }

        /// <summary/>
        public DiagnosticAction(string? category, object? data, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action)
        {
            _action = action.Diagnostic(category, data);
        }

        /// <summary/>
        public void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) => _action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);

        /// <summary>
        /// Implicit convert DiagnosticAction to Action
        /// </summary>
        public static implicit operator Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(DiagnosticAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action)
        {
            return action._action;
        }
    }
    
    /// <summary>
    /// Action diagnostic message
    /// </summary>
    public struct DiagnosticAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
    {
        private readonly Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> _action;

        /// <summary/>
        public DiagnosticAction(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action) : this(null, null, action) { }

        /// <summary/>
        public DiagnosticAction(string? category, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action) : this(category, null, action) { }

        /// <summary/>
        public DiagnosticAction(string? category, object? data, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action)
        {
            _action = action.Diagnostic(category, data);
        }

        /// <summary/>
        public void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13) => _action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);

        /// <summary>
        /// Implicit convert DiagnosticAction to Action
        /// </summary>
        public static implicit operator Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(DiagnosticAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action)
        {
            return action._action;
        }
    }
    
    /// <summary>
    /// Action diagnostic message
    /// </summary>
    public struct DiagnosticAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
    {
        private readonly Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> _action;

        /// <summary/>
        public DiagnosticAction(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action) : this(null, null, action) { }

        /// <summary/>
        public DiagnosticAction(string? category, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action) : this(category, null, action) { }

        /// <summary/>
        public DiagnosticAction(string? category, object? data, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action)
        {
            _action = action.Diagnostic(category, data);
        }

        /// <summary/>
        public void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14) => _action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);

        /// <summary>
        /// Implicit convert DiagnosticAction to Action
        /// </summary>
        public static implicit operator Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(DiagnosticAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action)
        {
            return action._action;
        }
    }
    
    /// <summary>
    /// Action diagnostic message
    /// </summary>
    public struct DiagnosticAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
    {
        private readonly Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> _action;

        /// <summary/>
        public DiagnosticAction(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action) : this(null, null, action) { }

        /// <summary/>
        public DiagnosticAction(string? category, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action) : this(category, null, action) { }

        /// <summary/>
        public DiagnosticAction(string? category, object? data, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action)
        {
            _action = action.Diagnostic(category, data);
        }

        /// <summary/>
        public void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15) => _action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);

        /// <summary>
        /// Implicit convert DiagnosticAction to Action
        /// </summary>
        public static implicit operator Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(DiagnosticAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action)
        {
            return action._action;
        }
    }
    
    /// <summary>
    /// Action diagnostic message
    /// </summary>
    public struct DiagnosticAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>
    {
        private readonly Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> _action;

        /// <summary/>
        public DiagnosticAction(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action) : this(null, null, action) { }

        /// <summary/>
        public DiagnosticAction(string? category, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action) : this(category, null, action) { }

        /// <summary/>
        public DiagnosticAction(string? category, object? data, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action)
        {
            _action = action.Diagnostic(category, data);
        }

        /// <summary/>
        public void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16) => _action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);

        /// <summary>
        /// Implicit convert DiagnosticAction to Action
        /// </summary>
        public static implicit operator Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(DiagnosticAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action)
        {
            return action._action;
        }
    }
    
}