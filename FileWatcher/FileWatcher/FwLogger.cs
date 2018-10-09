using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;

namespace FileWatcher
{
    public sealed class FwLogger
    {
        public static void Error(string message, Exception exception, 
            [CallerMemberName] string methodName = "", [CallerLineNumber] int lineNumber = 0, [CallerFilePath] string filePath ="")
        {
            Trace.WriteLine($"{DateTime.UtcNow} ERROR[at {methodName}:{lineNumber} in {Path.GetFileName(filePath)}]: {message}");
            Trace.Indent();
            Trace.WriteLine(exception.Message);
            Trace.WriteLine(exception.StackTrace);
            Trace.Unindent();
        }

        public static void Message(string message)
        {
            Trace.WriteLine($"{DateTime.UtcNow}: {message}");
        }
    }
}
