﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WGApi;

namespace WotStatsTool
{
    class Logger : ILogger
    {
        void ILogger.CriticalError(string message)
        {
            Write(message);
        }

        void ILogger.CriticalError(string format, params object[] args)
        {
            Write(format, args);
        }

        void ILogger.Error(string message)
        {
            Write(message);
        }

        void ILogger.Error(string format, params object[] args)
        {
            Write(format, args);
        }

        void ILogger.Info(string message)
        {
            Write(message);
        }

        void ILogger.Info(string format, params object[] args)
        {
            Write(format, args);
        }

        void ILogger.Verbose(string message)
        {
            Write(message);
        }

        void ILogger.Verbose(string format, params object[] args)
        {
            Write(format, args);
        }

        void ILogger.VVerbose(string message)
        {
            Write(message);
        }

        void ILogger.VVerbose(string format, params object[] args)
        {
            Write(format, args);
        }

        void ILogger.VVVerbose(string message)
        {
            Write(message);
        }

        void ILogger.VVVerbose(string format, params object[] args)
        {
            Write(format, args);
        }

        private void Write(string message)
        {
            Debug.WriteLine(message);
        }

        private void Write(string format, object[] args)
        {
            Debug.WriteLine(format, args);
        }
    }
}