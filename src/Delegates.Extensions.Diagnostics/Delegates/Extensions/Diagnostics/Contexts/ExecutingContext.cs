﻿using System.Collections.Generic;

namespace Delegates.Extensions.Diagnostics.Contexts
{
    /// <summary/>
    public struct ExecutingContext
    {
        /// <summary/>
        public ExecutingContext(object? data, IDictionary<string, object> cabinet)
        {
            Data = data;
            Cabinet = cabinet;
        }

        /// <summary>
        /// incoming data from outside
        /// </summary>
        public object? Data { get; }

        /// <summary>
        /// The data is shared within the lifetime
        /// </summary>
        public IDictionary<string, object> Cabinet { get; }
    }
}
