using System.Diagnostics;

namespace Delegates.Extensions.Diagnostics
{
    /// <summary>
    /// Delegates Diagnostician
    /// </summary>
    public static class Diagnostician
    {
        /// <summary>
        /// Listener name
        /// </summary>
        public const string LISTENER_NAME = "Delegates.Extensions";
        /// <summary>
        /// Default category name if category is absent
        /// </summary>
        public const string DEFAULT_CATEGORY = "Default";

        private static readonly DiagnosticListener _Listener = new DiagnosticListener(LISTENER_NAME);

        /// <summary>
        /// Write a diagnostic message
        /// </summary>
        /// <param name="category">a part of name, name format is {LISTENER_NAME}.{category}.{id}</param>
        /// <param name="id">a part of name, name format is {LISTENER_NAME}.{category}.{id}</param>
        /// <param name="data">diagnostic message data</param>
        public static void Write(string? category, string id, object? data)
        {
            category ??= DEFAULT_CATEGORY;

            var name = Name(category, id);

            Write(name, data);
        }

        /// <summary>
        /// Write a diagnostic message
        /// </summary>
        /// <param name="name">diagnostic message data</param>
        /// <param name="data">diagnostic message data</param>
        public static void Write(string name, object? data)
        {
            try
            {
                if (_Listener.IsEnabled() && _Listener.IsEnabled(name))
                {
                    _Listener.Write(name, data);
                }
            }
            catch
            {
                // ignore
            }
        }

        private static string Name(string category, string id) => $"{LISTENER_NAME}.{category}.{id}";

        /// <summary>
        /// buildin ids
        /// </summary>
        public static class Ids
        {
            /// <summary>
            /// preparing
            /// </summary>
            public const string PREPARING = "Preparing";

            /// <summary>
            /// prepared
            /// </summary>
            public const string PREPARED = "Prepared";

            /// <summary>
            /// executing
            /// </summary>
            public const string EXECUTING = "Executing";

            /// <summary>
            /// succeed
            /// </summary>
            public const string SUCCEED = "Succeed";

            /// <summary>
            /// exceptional
            /// </summary>
            public const string EXCEPTIONAL = "Exceptional";

            /// <summary>
            /// finished
            /// </summary>
            public const string FINISHED = "Finished";
        }

        /// <summary>
        /// buildin names
        /// </summary>
        public static class Names
        {
            /// <summary>
            /// default preparing
            /// </summary>
            public const string DEFAULT_PREPARING = $"{LISTENER_NAME}.{DEFAULT_CATEGORY}.{Ids.PREPARING}";

            /// <summary>
            /// default prepared
            /// </summary>
            public const string DEFAULT_PREPARED = $"{LISTENER_NAME}.{DEFAULT_CATEGORY}.{Ids.PREPARED}";

            /// <summary>
            /// default executing
            /// </summary>
            public const string DEFAULT_EXECUTING = $"{LISTENER_NAME}.{DEFAULT_CATEGORY}.{Ids.EXECUTING}";

            /// <summary>
            /// default succeed
            /// </summary>
            public const string DEFAULT_SUCCEED = $"{LISTENER_NAME}.{DEFAULT_CATEGORY}.{Ids.SUCCEED}";

            /// <summary>
            /// default exceptional
            /// </summary>
            public const string DEFAULT_EXCEPTIONAL = $"{LISTENER_NAME}.{DEFAULT_CATEGORY}.{Ids.EXCEPTIONAL}";

            /// <summary>
            /// default finished
            /// </summary>
            public const string DEFAULT_FINISHED = $"{LISTENER_NAME}.{DEFAULT_CATEGORY}.{Ids.FINISHED}";
        }
    }
}
