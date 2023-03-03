using System;
using System.Collections.Generic;

namespace Delegates.Extensions.Diagnostics.Contexts
{
    /// <summary/>
    public struct ExceptionalContext
    {
        /// <summary/>
        public ExceptionalContext(Exception exception, object? data, IDictionary<string, object> cabinet)
        {
            Data = data;
            Cabinet = cabinet;
            Exception = exception;
        }

        /// <summary>
        /// incoming data from outside
        /// </summary>
        public object? Data { get; }

        /// <summary>
        /// The data is shared within the lifetime
        /// </summary>
        public IDictionary<string, object> Cabinet { get; }

        /// <summary>
        /// exception
        /// </summary>
        public Exception Exception { get; set; }
    }
}
