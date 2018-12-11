using Moonlay.ExtCore.Mvc.Abstractions;

namespace ChartOfAccounts.Infrastructure
{
    public class WorkContext : IWorkContext
    {
        public WorkContext()
        {

        }

        public string CurrentUser { get; internal set; }
    }
}
