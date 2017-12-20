using System;
using System.Collections.Generic;
using JetBrains.Annotations;

namespace PatchKit.IssueReporting
{
    public static class IssueReporterExtensions
    {
        public static void Report([NotNull] IIssueReporter @this, string message, Exception exception)
        {
            @this.Report(new Issue
            {
                Message = message,
                Exception = exception
            });
        }

        public static void Report([NotNull] IIssueReporter @this, Exception exception)
        {
            @this.Report(new Issue
            {
                Exception = exception
            });
        }

        public static void Report([NotNull] IIssueReporter @this, Exception exception, IDictionary<string, string> tags)
        {
            @this.Report(new Issue
            {
                Exception = exception,
                Tags = tags
            });
        }

        public static void Report([NotNull] IIssueReporter @this, string message, Exception exception, IDictionary<string, string> tags)
        {
            @this.Report(new Issue
            {
                Message = message,
                Exception = exception,
                Tags = tags
            });
        }
    }
}