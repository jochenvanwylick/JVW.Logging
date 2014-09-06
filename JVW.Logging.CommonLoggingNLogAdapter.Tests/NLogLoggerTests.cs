namespace JVW.Logging.CommonLoggingNLogAdapter.Tests
{
    using System;
    using System.Diagnostics;
    using System.Globalization;

    using Common.Logging;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class NLogLoggerTests
    {
        //private ILog log = Common.Logging.LogManager.GetLogger("TestLogger");
        private ILog log = new NLogLogger("TestLogger");

        public void HandleMessage()
        {
            log.Info("HandleMessage called");
        }

        [TestMethod]
        public void TestMethod1()
        {
            const string TestMessage = "This is testmessage";
            const string Format = "This is a testmessage with placeholder {0}";
            var args = new object[] { "[ARGS]" };
            var exception = new OkException("Exception is visible in log!");
            var formatProvider = CultureInfo.InvariantCulture.NumberFormat;
            Action<FormatMessageHandler> handler = h => h(Format, args);

            Trace.WriteLine("=== TRACE ==="); 
            this.TestTraceMethods(TestMessage, exception, Format, args, formatProvider, handler);

            Trace.WriteLine("=== DEBUG ==="); 
            this.TestDebugMethod(TestMessage, exception, Format, args, formatProvider, handler);

            Trace.WriteLine("=== INFO ==="); 
            this.TestInfoMethods(TestMessage, exception, Format, args, formatProvider, handler);

            Trace.WriteLine("=== WARNING ==="); 
            this.TestWarningMethods(TestMessage, exception, Format, args, formatProvider, handler);

            Trace.WriteLine("=== ERROR ==="); 
            this.TestErrorMethods(TestMessage, exception, Format, args, formatProvider, handler);

            Trace.WriteLine("=== FATAL ==="); 
            this.TestFatalMethods(TestMessage, exception, Format, args, formatProvider, handler);
        }

        private void TestFatalMethods(
            string TestMessage,
            OkException exception,
            string Format,
            object[] args,
            NumberFormatInfo formatProvider,
            Action<FormatMessageHandler> handler)
        {
            this.log.Fatal(TestMessage);
            this.log.Fatal(TestMessage, exception);
            this.log.FatalFormat(Format, args);
            this.log.FatalFormat(Format, exception, args);
            this.log.FatalFormat(formatProvider, Format, args);
            this.log.FatalFormat(formatProvider, Format, exception, args);
            this.log.Fatal(handler);
            //this.log.Fatal(handler, exception);
            this.log.Fatal(formatProvider, handler);
            //this.log.Fatal(formatProvider, handler, exception);
        }

        private void TestErrorMethods(
            string TestMessage,
            OkException exception,
            string Format,
            object[] args,
            NumberFormatInfo formatProvider,
            Action<FormatMessageHandler> handler)
        {
            this.log.Error(TestMessage);
            this.log.Error(TestMessage, exception);
            this.log.ErrorFormat(Format, args);
            this.log.ErrorFormat(Format, exception, args);
            this.log.ErrorFormat(formatProvider, Format, args);
            this.log.ErrorFormat(formatProvider, Format, exception, args);
            this.log.Error(handler);
            //this.log.Error(handler, exception);
            this.log.Error(formatProvider, handler);
            //this.log.Error(formatProvider, handler, exception);
        }

        private void TestWarningMethods(
            string TestMessage,
            OkException exception,
            string Format,
            object[] args,
            NumberFormatInfo formatProvider,
            Action<FormatMessageHandler> handler)
        {
            this.log.Warn(TestMessage);
            this.log.Warn(TestMessage, exception);
            this.log.WarnFormat(Format, args);
            this.log.WarnFormat(Format, exception, args);
            this.log.WarnFormat(formatProvider, Format, args);
            this.log.WarnFormat(formatProvider, Format, exception, args);
            this.log.Warn(handler);
            //this.log.Warn(handler, exception);
            this.log.Warn(formatProvider, handler);
            //this.log.Warn(formatProvider, handler, exception);
        }

        private void TestInfoMethods(
            string TestMessage,
            OkException exception,
            string Format,
            object[] args,
            NumberFormatInfo formatProvider,
            Action<FormatMessageHandler> handler)
        {
            this.log.Info(TestMessage);
            this.log.Info(TestMessage, exception);
            this.log.InfoFormat(Format, args);
            this.log.InfoFormat(Format, exception, args);
            this.log.InfoFormat(formatProvider, Format, args);
            this.log.InfoFormat(formatProvider, Format, exception, args);
            this.log.Info(handler);
            //this.log.Info(handler, exception);
            this.log.Info(formatProvider, handler);
            //this.log.Info(formatProvider, handler, exception);
        }

        private void TestDebugMethod(
            string TestMessage,
            OkException exception,
            string Format,
            object[] args,
            NumberFormatInfo formatProvider,
            Action<FormatMessageHandler> handler)
        {
            this.log.Debug(TestMessage);
            this.log.Debug(TestMessage, exception);
            this.log.DebugFormat(Format, args);
            this.log.DebugFormat(Format, exception, args);
            this.log.DebugFormat(formatProvider, Format, args);
            this.log.DebugFormat(formatProvider, Format, exception, args);
            this.log.Debug(handler);
            //this.log.Debug(handler, exception);
            this.log.Debug(formatProvider, handler);
            //this.log.Debug(formatProvider, handler, exception);
        }

        private void TestTraceMethods(
            string TestMessage,
            OkException exception,
            string Format,
            object[] args,
            NumberFormatInfo formatProvider,
            Action<FormatMessageHandler> handler)
        {
            this.log.Trace(TestMessage);
            this.log.Trace(TestMessage, exception);
            this.log.TraceFormat(Format, args);
            this.log.TraceFormat(Format, exception, args);
            this.log.TraceFormat(formatProvider, Format, args);
            this.log.TraceFormat(formatProvider, Format, exception, args);
            this.log.Trace(handler);
            //this.log.Trace(handler, exception);
            this.log.Trace(formatProvider, handler);
            //this.log.Trace(formatProvider, handler, exception);
        }
    }

    public class OkException : Exception
    {
        public OkException(string message) : base(message)
        {
        }
    }
}