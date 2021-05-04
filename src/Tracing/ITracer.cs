using System;

namespace OpenTelemetryJaeger.Tracing
{
    public interface ITracer 
    {
        /// <summary>
        /// Creates a new trace scope for manually instrumentation, using the supplied operation name.
        /// If no trace scope exists, this becomes the parent, otherwise this trace scope becomes a child of the currently active trace scope.
        /// </summary>
        ITracerScope CreateTraceScope(string operationName);
       
        /// <summary>
        /// Adds an exception to the current active trace span (if one exists).
        /// </summary>
        void SetSpanException(Exception ex);

        /// <summary>
        /// Adds a tag (string) to the current active trace span (if one exists).
        /// </summary>
        void SetSpanTag(string key, string value);
    }
}