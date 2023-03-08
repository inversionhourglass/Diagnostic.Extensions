# New feature
- Add `Invoke` method to `DiagnosticAction` and `DiagnosticFunc`, that we can execute it directly by call `Invoke`
  ```csharp
  // without wrap
  Task.Delay(100);

  // with wrap, you must call Invoke, otherwise Task.Delay(100) will never executes.
  new DiagnosticFunc<Task>("my-category", () => Task.Delay(100)).Invoke();
  ```
- Add `GetAwaiter` extension method to `DiagnosticFunc<Task>` and `DiagnosticFunc<Task<T>>`, that we can await it directly.
  ```csharp
  await new DiagnosticFunc<Task>("my-category", () => Task.Delay(100));
  ```

# Deprecated
- `DiagnosticTaskFunc` is obsolete, use `DiagnosticFunc<Task>` to instead.
- `DiagnosticGenericTaskFunc` is obsolete, use `DiagnosticFunc<Task<T>>` to instead.

# Fixes
- Fix diagnostics `OnPrepared`, `OnSucceed`, `OnExceptional` and `OnFinished` get null value of `context` parameter.