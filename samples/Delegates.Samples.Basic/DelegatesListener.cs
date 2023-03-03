using Delegates.Extensions.Diagnostics;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Delegates.Samples.Basic
{
    internal class DelegatesListener : IObserver<DiagnosticListener>
    {
        public void OnCompleted()
        {
        }

        public void OnError(Exception error)
        {
        }

        public void OnNext(DiagnosticListener value)
        {
            if (value.Name == Diagnostician.LISTENER_NAME)
            {
                value.Subscribe(new DetailListener());
            }
        }
    }
}
