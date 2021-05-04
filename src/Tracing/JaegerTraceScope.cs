using System;

namespace OpenTelemetryJaeger.Tracing
{
    public class JaegerTraceScope : ITracerScope, IDisposable
    {
        private readonly Scope _scope;

        internal JaegerTraceScope(Scope scope)
        {
            _scope = scope;
        }

        public void SetSpanException(Exception ex)
        {
            //_scope.Span.SetException(ex);
        }

        public void SetSpanTag(string key, string value)
        {
            //_scope.Span.SetTag(key, value);
        }

        public void Dispose()
        {
            //_scope?.Dispose();
        }
    }
}