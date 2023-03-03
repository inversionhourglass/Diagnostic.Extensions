using System.Diagnostics;

namespace Delegates.Extensions.Diagnostics
{
    public static class Diagnostician
    {
        public const string LISTENER_NAME = "Delegates.Extensions";
        public const string DEFAULT_CATEGORY = LISTENER_NAME + ".Default";

        private static readonly DiagnosticListener _Listener = new DiagnosticListener(LISTENER_NAME);

        public static void Write(string? category, string id, object? data)
        {
            category ??= DEFAULT_CATEGORY;

            var name = Name(category, id);
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

        public static class Ids
        {
            public const string PREPARING = "Preparing";

            public const string PREPARED = "Prepared";

            public const string EXECUTING = "Executing";

            public const string SUCCEED = "Succeed";

            public const string EXCEPTIONAL = "Exceptional";

            public const string FINISHED = "Finished";
        }
    }
}
