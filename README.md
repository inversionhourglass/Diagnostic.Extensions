# Diagnostic.Extensions

## Delegates.Extensions.Diagnostics
What did it do.
```csharp
public static Action Diagnostic(this Action action, string? category = null, object? data = null)
{
    DiagnosticListener.Write("Delegates.Extensions.{category}.Preparing");
    Action wrapped = () =>
    {
        DiagnosticListener.Write("Delegates.Extensions.{category}.Executing");
        try
        {
            action();
            DiagnosticListener.Write("Delegates.Extensions.{category}.Succeed");
        }
        catch (Exception ex)
        {
            DiagnosticListener.Write("Delegates.Extensions.{category}.Exceptional");
            throw;
        }
        finally
        {
            DiagnosticListener.Write("Delegates.Extensions.{category}.Finished");
        }
    };
    DiagnosticListener.Write("Delegates.Extensions.{category}.Prepared");

    return wrapped;
}
```

What you can do.
```csharp
Task.Run(((Action)Call).Diagnostic("Timing"));
// or
Task.Run(new DiagnosticAction("Timing", Call));


void Call() { }

internal class Listener : IObserver<KeyValuePair<string, object>>
{
    public void OnNext(KeyValuePair<string, object> value)
    {
        switch (value.Key)
        {
            case "Delegates.Extensions.Timing.Preparing":
                ((PreparingContext)value.Value).Cabinet["prepare"] = Stopwatch.StartNew();;
                break;
            case "Delegates.Extensions.Timing.Executing":
                var stopwatch = (Stopwatch)((ExecutingContext)value.Value).Cabinet["prepare"];
                stopwatch.Stop();
                Console.WriteLine($"enqueue task costs {prepare.ElapsedMilliseconds}ms");
                break;
        }
    }
}
```