using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace System.Threading
{
    /// <summary>
    /// That we can await <see cref="DiagnosticTaskFunc"/> and <see cref="DiagnosticGenericTaskFunc{TResult}"/> directly.
    /// </summary>
    public static class AsyncDelegateExtensions
    {
        /// <summary>
        /// Get inner task's awaiter
        /// </summary>
        public static TaskAwaiter GetAwaiter(this DiagnosticTaskFunc func)
        {
            return ((Func<Task>)func)().GetAwaiter();
        }

        /// <summary>
        /// Get inner task's awaiter
        /// </summary>
        public static TaskAwaiter<TResult> GetAwaiter<TResult>(this DiagnosticGenericTaskFunc<TResult> func)
        {
            return ((Func<Task<TResult>>)func)().GetAwaiter();
        }
    }
}
