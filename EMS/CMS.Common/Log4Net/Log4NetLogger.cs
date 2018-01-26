using log4net;
using log4net.Config;
using System;

namespace CMS.Common.Log4Net
{
    public class Log4NetLogger
    {
        private readonly ILog _logger;

        public Log4NetLogger()
        {
            XmlConfigurator.Configure();
            _logger = LogManager.GetLogger(GetType());
        }

        public void Info(string message)
        {
            _logger.Info(message);
        }

        public void Info(string message, String userId)
        {
            log4net.ThreadContext.Properties["UserId"] = userId;
            _logger.Info(message);
        }

        public void Warn(string message)
        {

            _logger.Warn(message);
        }

        public void Warn(string message, String userId)
        {
            log4net.ThreadContext.Properties["UserId"] = userId;
            _logger.Warn(message);
        }

        public void Debug(string message)
        {
            _logger.Debug(message);
        }

        public void Debug(string message, String userId)
        {
            log4net.ThreadContext.Properties["UserId"] = userId;
            _logger.Debug(message);
        }

        public void Error(string message)
        {
            _logger.Error(message);
        }

        public void Error(string message, String userId)
        {
            log4net.ThreadContext.Properties["UserId"] = userId;
            _logger.Error(message);
        }

        public void Error(Exception x)
        {
            Error(BuildExceptionMessage(x));
        }

        public void Error(string message, Exception x)
        {
            _logger.Error(message, x);
        }

        public void Fatal(string message)
        {
            _logger.Fatal(message);
        }

        public void Fatal(string message, String userId)
        {
            log4net.ThreadContext.Properties["UserId"] = userId;
            _logger.Fatal(message);
        }

        public void Fatal(Exception x)
        {
            Fatal(BuildExceptionMessage(x));
        }

        private string BuildExceptionMessage(Exception x)
        {
            var logException = x;
            if (x.InnerException != null)
            {
                logException = x.InnerException;
            }

            // Get the error message
            var strErrorMsg = Environment.NewLine + "Message :" + logException.Message;

            // Source of the message
            strErrorMsg += Environment.NewLine + "Source :" + logException.Source;

            // Stack Trace of the error
            strErrorMsg += Environment.NewLine + "Stack Trace :" + logException.StackTrace;

            // Method where the error occurred
            strErrorMsg += Environment.NewLine + "TargetSite :" + logException.TargetSite;
            return strErrorMsg;

        }
    }

}
