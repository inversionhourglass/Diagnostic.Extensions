using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace System.Threading
{
    /// <summary>
    /// That we can await DiagnosticFunc&lt;Task&gt; and DiagnosticFunc&lt;Task&lt;TResult&gt;&gt; directly.
    /// </summary>
    public static class AsyncDelegateExtensions
    {
        /// <summary>
        /// Get inner task's awaiter
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Infact we don't need DiagnosticTaskFunc, DiagnosticFunc is enough")]
        public static TaskAwaiter GetAwaiter(this DiagnosticTaskFunc func)
        {
            return ((Func<Task>)func)().GetAwaiter();
        }

        /// <summary>
        /// Get inner task's awaiter
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Infact we don't need DiagnosticGenericTaskFunc, DiagnosticFunc is enough")]
        public static TaskAwaiter<TResult> GetAwaiter<TResult>(this DiagnosticGenericTaskFunc<TResult> func)
        {
            return ((Func<Task<TResult>>)func)().GetAwaiter();
        }
    }
}
