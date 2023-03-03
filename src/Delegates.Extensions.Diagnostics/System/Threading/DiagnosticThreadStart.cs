namespace System.Threading
{
    /// <summary>
    /// ParameterizedThreadStart diagnostic message
    /// </summary>
    public struct DiagnosticThreadStart
    {
        private readonly ThreadStart _threadStart;

        /// <summary/>
        public DiagnosticThreadStart(ThreadStart threadStart) : this(null, null, threadStart) { }

        /// <summary/>
        public DiagnosticThreadStart(string? category, ThreadStart threadStart) : this(category, null, threadStart) { }

        /// <summary/>
        public DiagnosticThreadStart(string? category, object? data, ThreadStart threadStart)
        {
            _threadStart = threadStart.Diagnostic(category, data);
        }

        /// <summary>
        /// Implicit convert DiagnosticThreadStart to ThreadStart
        /// </summary>
        public static implicit operator ThreadStart(DiagnosticThreadStart threadStart)
        {
            return threadStart._threadStart;
        }
    }
}
