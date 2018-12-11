using ChartOfAccounts.Domain;
using ChartOfAccounts.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ChartOfAccounts.Application
{
    public interface IEntryService
    {
        Task<Entry> PostEntryAsync(string number, DateTimeOffset date, List<EntryItem> items);

        Task<Entry> RetrieveEntryAsync(string number);

        Task ApplyAsync(Entry entry);
    }
}
