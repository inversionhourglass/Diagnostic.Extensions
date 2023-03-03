namespace System.Threading
{
    /// <summary>
    /// TimerCallback diagnostic message
    /// </summary>
    public struct DiagnosticTimerCallback
    {
        private readonly TimerCallback _callback;

        /// <summary/>
        public DiagnosticTimerCallback(TimerCallback callback) : this(null, null, callback) { }

        /// <summary/>
        public DiagnosticTimerCallback(string? category, TimerCallback callback) : this(category, null, callback) { }

        /// <summary/>
        public DiagnosticTimerCallback(string? category, object? data, TimerCallback callback)
        {
            _callback = callback.Diagnostic(category, data);
        }

        /// <summary>
        /// Implicit convert DiagnosticTimerCallback to TimerCallback
        /// </summary>
        public static implicit operator TimerCallback(DiagnosticTimerCallback callback)
        {
            return callback._callback;
        }
    }
}
