using System;
using System.Collections.Generic;
using System.IO;

namespace GBX.NET
{
    public static class Log
    {
        public delegate void LoggedMain(string text, ConsoleColor color);
        public delegate void LoggedOther(string logName, string text, ConsoleColor color);

        public static event LoggedMain LoggedMainEvent;
        public static event LoggedOther LoggedOtherEvent;

        public static StringWriter MainLog { get; }
        public static Dictionary<string, StringWriter> OtherLogs { get; }

        static Log()
        {
            MainLog = new StringWriter();
            OtherLogs = new Dictionary<string, StringWriter>();
        }

        public static void Save(string fileName)
        {
            File.WriteAllText(fileName, MainLog.ToString());
        }

        public static void Save(string logName, string fileName)
        {
            if (string.IsNullOrEmpty(logName))
                Save(fileName);
            else if (OtherLogs.TryGetValue(logName, out StringWriter writer))
                File.WriteAllText(fileName, writer.ToString());
        }

        public static void Write(string text, ConsoleColor color = ConsoleColor.White)
        {
            MainLog.WriteLine(text);
            LoggedMainEvent?.Invoke(text, color);
        }

        public static void Write(string text, string logName, ConsoleColor color = ConsoleColor.White)
        {
            if (string.IsNullOrEmpty(logName))
            {
                MainLog.WriteLine(text);
                LoggedMainEvent?.Invoke(text, color);
            }
            else
            {
                if (!OtherLogs.TryGetValue(logName, out StringWriter writer))
                {
                    writer = new StringWriter();
                    OtherLogs[logName] = writer;
                }

                writer.WriteLine(text);

                LoggedOtherEvent?.Invoke(logName, text, color);
            }
        }

        /// <summary>
        /// Writes empty string to the main log.
        /// </summary>
        public static void Write()
        {
            Write("");
        }
    }
}
