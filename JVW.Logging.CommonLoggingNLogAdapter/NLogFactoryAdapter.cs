namespace JVW.Logging.CommonLoggingNLogAdapter
{
    using System;

    using Common.Logging;
    using Common.Logging.Configuration;

    public class NLogFactoryAdapter : ILoggerFactoryAdapter
    {
        public NLogFactoryAdapter()
        {
        }

        public NLogFactoryAdapter(NameValueCollection configCollection)
        {
        }

        public ILog GetLogger(Type type)
        {
            return new NLogLogger(type);
        }

        public ILog GetLogger(string name)
        {
            return new NLogLogger(name);
        }
    }
}