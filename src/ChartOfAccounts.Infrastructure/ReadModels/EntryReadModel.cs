using System;
using ChartOfAccounts.Domain.ReadModels;

namespace ChartOfAccounts.Infrastructure.ReadModels
{
    public class EntryReadModel : CoaReadModel
    {
        public string ItemsJson { get; internal set; }
        public string Number { get; internal set; }
        public DateTimeOffset Date { get; internal set; }
    }
}
