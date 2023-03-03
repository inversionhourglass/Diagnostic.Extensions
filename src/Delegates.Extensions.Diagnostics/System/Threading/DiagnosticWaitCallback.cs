namespace System.Threading
{
    /// <summary>
    /// WaitCallback diagnostic message
    /// </summary>
    public struct DiagnosticWaitCallback
    {
        private readonly WaitCallback _callback;

        /// <summary/>
        public DiagnosticWaitCallback(WaitCallback callback) : this(null, null, callback) { }

        /// <summary/>
        public DiagnosticWaitCallback(string? category, WaitCallback callback) : this(category, null, callback) { }

        /// <summary/>
        public DiagnosticWaitCallback(string? category, object? data, WaitCallback callback)
        {
            _callback = callback.Diagnostic(category, data);
        }

        /// <summary>
        /// Implicit convert DiagnosticWaitCallback to WaitCallback
        /// </summary>
        public static implicit operator WaitCallback(DiagnosticWaitCallback callback)
        {
            return callback._callback;
        }
    }
}
