using System.Linq;
using System.Threading.Tasks;

namespace System
{
    partial class FuncExtensions
    {
        private static dynamic? TryTaskDiagnostic(dynamic func, string? category = null, object? data = null)
        {
            var funcType = func.GetType();
            var taskType = ((Type[])funcType.GetGenericArguments()).Last();

            if (typeof(Task) == taskType || typeof(ValueTask) == taskType)
            {
                return TaskFuncExtensions.Diagnostic(func, category, data);
            }
            if (taskType.IsGenericType)
            {
                var defType = taskType.GetGenericTypeDefinition();
                if (defType == typeof(Task<>) || defType == typeof(ValueTask<>))
                {
                    return GenericTaskFuncExtensions.Diagnostic(func, category, data);
                }
            }

            return null;
        }
    }
}
