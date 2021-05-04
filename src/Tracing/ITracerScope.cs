using System;

namespace OpenTelemetryJaeger.Tracing
{
    public interface ITracerScope
    {
        void SetSpanException(Exception ex);

        void SetSpanTag(string key, string value);
    }
}