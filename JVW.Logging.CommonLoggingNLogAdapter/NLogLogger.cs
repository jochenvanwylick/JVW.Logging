namespace JVW.Logging.CommonLoggingNLogAdapter
{
    using System;

    using Common.Logging;

    public class NLogLogger : ILog
    {
        private NLog.Logger log;

        public NLogLogger(string name)
        {
            this.log = NLog.LogManager.GetLogger(name);
        }

        public NLogLogger(Type type)
        {
            this.log = NLog.LogManager.GetLogger(type.FullName);
        }

        public void Trace(object message)
        {
            this.log.Trace(message);
        }

        public void Trace(object message, Exception exception)
        {
            this.log.Trace(message: message.ToString(), exception: exception);
        }

        public void TraceFormat(string format, params object[] args)
        {
            this.log.Trace(format, args);
        }

        public void TraceFormat(string format, Exception exception, params object[] args)
        {
            this.log.Trace(format, exception, args);
        }

        public void TraceFormat(IFormatProvider formatProvider, string format, params object[] args)
        {
            this.log.Trace(formatProvider, format, args);
        }

        public void TraceFormat(IFormatProvider formatProvider, string format, Exception exception, params object[] args)
        {
            this.log.Trace(formatProvider, format, exception, args);
        }

        public void Trace(Action<FormatMessageHandler> formatMessageCallback)
        {
            this.log.Trace(
                () =>
                    {
                        var result = string.Empty;
                        formatMessageCallback((format, args) => result = string.Format(format, args));
                        return result;
                    });
        }

        public void Trace(Action<FormatMessageHandler> formatMessageCallback, Exception exception)
        {
            throw new NotImplementedException("No suitable NLOG method maps on this method.");
        }

        public void Trace(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback)
        {
            this.log.Trace(
                () =>
                    {
                        var result = string.Empty;
                        formatMessageCallback((format, args) => result = string.Format(formatProvider, format, args));
                        return result;
                    });
        }

        public void Trace(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback, Exception exception)
        {
            throw new NotImplementedException("No suitable NLOG method maps on this method.");
        }

        public void Debug(object message)
        {
            this.log.Debug(message);
        }

        public void Debug(object message, Exception exception)
        {
            this.log.Debug(message.ToString(), exception);
        }

        public void DebugFormat(string format, params object[] args)
        {
            this.log.Debug(format, args);
        }

        public void DebugFormat(string format, Exception exception, params object[] args)
        {
            this.log.Debug(format, exception, args);
        }

        public void DebugFormat(IFormatProvider formatProvider, string format, params object[] args)
        {
            this.log.Debug(formatProvider, format, args);
        }

        public void DebugFormat(IFormatProvider formatProvider, string format, Exception exception, params object[] args)
        {
            this.log.Debug(formatProvider, format, exception, args);
        }

        public void Debug(Action<FormatMessageHandler> formatMessageCallback)
        {
            this.log.Debug(
                () =>
                    {
                        var result = string.Empty;
                        formatMessageCallback((format, args) => result = string.Format(format, args));
                        return result;
                    });
        }

        public void Debug(Action<FormatMessageHandler> formatMessageCallback, Exception exception)
        {
            throw new NotImplementedException("No suitable NLOG method maps on this method.");
        }

        public void Debug(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback)
        {
            this.log.Debug(
                () =>
                    {
                        var result = string.Empty;
                        formatMessageCallback((format, args) => result = string.Format(formatProvider, format, args));
                        return result;
                    });
        }

        public void Debug(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback, Exception exception)
        {
            throw new NotImplementedException("No suitable NLOG method maps on this method.");
        }

        public void Info(object message)
        {
            this.log.Info(message);
        }

        public void Info(object message, Exception exception)
        {
            this.log.Info(message.ToString(), exception);
        }

        public void InfoFormat(string format, params object[] args)
        {
            this.log.Info(format, args);
        }

        public void InfoFormat(string format, Exception exception, params object[] args)
        {
            this.log.Info(format, exception, args);
        }

        public void InfoFormat(IFormatProvider formatProvider, string format, params object[] args)
        {
            this.log.Info(formatProvider, format, args);
        }

        public void InfoFormat(IFormatProvider formatProvider, string format, Exception exception, params object[] args)
        {
            this.log.Info(formatProvider, format, exception, args);
        }

        public void Info(Action<FormatMessageHandler> formatMessageCallback)
        {
            this.log.Info(
                () =>
                {
                    var result = string.Empty;
                    formatMessageCallback((format, args) => result = string.Format(format, args));
                    return result;
                });

        }

        public void Info(Action<FormatMessageHandler> formatMessageCallback, Exception exception)
        {
            throw new NotImplementedException("No suitable NLOG method maps on this method.");
        }

        public void Info(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback)
        {
            this.log.Info(
                () =>
                    {
                        var result = string.Empty;
                        formatMessageCallback((format, args) => result = string.Format(formatProvider, format, args));
                        return result;
                    });
        }

        public void Info(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback, Exception exception)
        {
            throw new NotImplementedException("No suitable NLOG method maps on this method.");
        }

        public void Warn(object message)
        {
            this.log.Warn(message);
        }

        public void Warn(object message, Exception exception)
        {
            this.log.Warn(message.ToString(), exception);
        }

        public void WarnFormat(string format, params object[] args)
        {
            this.log.Warn(format, args);
        }

        public void WarnFormat(string format, Exception exception, params object[] args)
        {
            this.log.Warn(format, exception, args);
        }

        public void WarnFormat(IFormatProvider formatProvider, string format, params object[] args)
        {
            this.log.Warn(formatProvider, format, args);
        }

        public void WarnFormat(IFormatProvider formatProvider, string format, Exception exception, params object[] args)
        {
            this.log.Warn(formatProvider, format, exception, args);
        }

        public void Warn(Action<FormatMessageHandler> formatMessageCallback)
        {
            this.log.Warn(
                () =>
                    {
                        var result = string.Empty;
                        formatMessageCallback((format, args) => result = string.Format(format, args));
                        return result;
                    });
        }

        public void Warn(Action<FormatMessageHandler> formatMessageCallback, Exception exception)
        {
            throw new NotImplementedException("No suitable NLOG method maps on this method.");
        }

        public void Warn(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback)
        {
            this.log.Warn(
                () =>
                    {
                        var result = string.Empty;
                        formatMessageCallback((format, args) => result = string.Format(formatProvider, format, args));
                        return result;
                    });
        }

        public void Warn(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback, Exception exception)
        {
            throw new NotImplementedException("No suitable NLOG method maps on this method.");
        }

        public void Error(object message)
        {
            this.log.Error(message);
        }

        public void Error(object message, Exception exception)
        {
            this.log.Error(message.ToString(), exception);
        }

        public void ErrorFormat(string format, params object[] args)
        {
            this.log.Error(format, args);
        }

        public void ErrorFormat(string format, Exception exception, params object[] args)
        {
            this.log.Error(format, exception, args);
        }

        public void ErrorFormat(IFormatProvider formatProvider, string format, params object[] args)
        {
            this.log.Error(formatProvider, format, args);
        }

        public void ErrorFormat(IFormatProvider formatProvider, string format, Exception exception, params object[] args)
        {
            this.log.Error(formatProvider, format, exception, args);
        }

        public void Error(Action<FormatMessageHandler> formatMessageCallback)
        {
            this.log.Error(
                () =>
                    {
                        var result = string.Empty;
                        formatMessageCallback((format, args) => result = string.Format(format, args));
                        return result;
                    });
        }

        public void Error(Action<FormatMessageHandler> formatMessageCallback, Exception exception)
        {
            throw new NotImplementedException("No suitable NLOG method maps on this method.");
        }

        public void Error(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback)
        {
            this.log.Error(
                () =>
                    {
                        var result = string.Empty;
                        formatMessageCallback((format, args) => result = string.Format(formatProvider, format, args));
                        return result;
                    });
        }

        public void Error(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback, Exception exception)
        {
            throw new NotImplementedException("No suitable NLOG method maps on this method.");
        }

        public void Fatal(object message)
        {
            this.log.Fatal(message);
        }

        public void Fatal(object message, Exception exception)
        {
            this.log.Fatal(message.ToString(), exception);
        }

        public void FatalFormat(string format, params object[] args)
        {
            this.log.Fatal(format, args);
        }

        public void FatalFormat(string format, Exception exception, params object[] args)
        {
            this.log.Fatal(format, exception, args);
        }

        public void FatalFormat(IFormatProvider formatProvider, string format, params object[] args)
        {
            this.log.Fatal(formatProvider, format, args);
        }

        public void FatalFormat(IFormatProvider formatProvider, string format, Exception exception, params object[] args)
        {
            this.log.Fatal(formatProvider, format, exception, args);
        }

        public void Fatal(Action<FormatMessageHandler> formatMessageCallback)
        {
            this.log.Fatal(
                () =>
                    {
                        var result = string.Empty;
                        formatMessageCallback((format, args) => result = string.Format(format, args));
                        return result;
                    });
        }

        public void Fatal(Action<FormatMessageHandler> formatMessageCallback, Exception exception)
        {
            throw new NotImplementedException("No suitable NLOG method maps on this method.");
        }

        public void Fatal(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback)
        {
            this.log.Fatal(
                () =>
                    {
                        var result = string.Empty;
                        formatMessageCallback((format, args) => result = string.Format(formatProvider, format, args));
                        return result;
                    });
        }

        public void Fatal(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback, Exception exception)
        {
            throw new NotImplementedException("No suitable NLOG method maps on this method.");
        }

        public bool IsTraceEnabled { get; private set; }

        public bool IsDebugEnabled { get; private set; }

        public bool IsErrorEnabled { get; private set; }

        public bool IsFatalEnabled { get; private set; }

        public bool IsInfoEnabled { get; private set; }

        public bool IsWarnEnabled { get; private set; }

        public IVariablesContext GlobalVariablesContext
        {
            get
            {
                // Not supported
                throw new NotImplementedException();
            }
        }

        public IVariablesContext ThreadVariablesContext
        {
            get
            {
                // Not supported
                throw new NotImplementedException();
            }
        }
    }
}