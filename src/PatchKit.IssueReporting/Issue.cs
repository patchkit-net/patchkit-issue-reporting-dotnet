using System;
using System.Collections.Generic;

namespace PatchKit.IssueReporting
{
    public class Issue
    {
        public string Message { get; set; }

        public Exception Exception { get; set; }

        public IDictionary<string, string> Tags { get; set; }
    }
}