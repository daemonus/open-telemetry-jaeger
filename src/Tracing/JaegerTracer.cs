using System;
using Microsoft.Extensions.Logging;

namespace OpenTelemetryJaeger.Tracing
{
    public class JaegerTracer : ITracer
    {
        private readonly ILogger<JaegerTracer> _logger;

        public JaegerTracer(ILogger<JaegerTracer> logger)
        {
            _logger = logger;
        }

        public ITracerScope CreateTraceScope(string operationName)
        {
            Scope scope = null;

            try
            {
                //scope = Tracer.Instance.StartActive(operationName);
            }
            catch (Exception ex)
            {
                _logger.LogError("An error occurred creating trace scope", ex);
            }

            return new JaegerTraceScope(scope); 
        }

        public void SetSpanException(Exception ex)
        {
            //Tracer.Instance?.ActiveScope?.Span?.SetException(ex);
        }

        public void SetSpanTag(string key, string value)
        {
            //Tracer.Instance?.ActiveScope?.Span?.SetTag(key, value);
        }
    }
}