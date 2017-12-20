using JetBrains.Annotations;

namespace PatchKit.IssueReporting
{
    public interface IIssueReporter
    {
        void Report([NotNull] Issue issue);
    }
}