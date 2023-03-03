namespace System.Threading
{
    /// <summary>
    /// ParameterizedThreadStart diagnostic message
    /// </summary>
    public struct DiagnosticParameterizedThreadStart
    {
        private readonly ParameterizedThreadStart _threadStart;

        /// <summary/>
        public DiagnosticParameterizedThreadStart(ParameterizedThreadStart threadStart) : this(null, null, threadStart) { }

        /// <summary/>
        public DiagnosticParameterizedThreadStart(string? category, ParameterizedThreadStart threadStart) : this(category, null, threadStart) { }

        /// <summary/>
        public DiagnosticParameterizedThreadStart(string? category, object? data, ParameterizedThreadStart threadStart)
        {
            _threadStart = threadStart.Diagnostic(category, data);
        }

        /// <summary>
        /// Implicit convert DiagnosticParameterizedThreadStart to ParameterizedThreadStart
        /// </summary>
        public static implicit operator ParameterizedThreadStart(DiagnosticParameterizedThreadStart threadStart)
        {
            return threadStart._threadStart;
        }
    }
}
