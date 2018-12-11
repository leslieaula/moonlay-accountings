using ChartOfAccounts.Domain;
using ChartOfAccounts.Domain.Entities;
using ChartOfAccounts.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ChartOfAccounts.Application
{
    public class EntryService : IEntryService
    {
        private readonly IEntryRepository _entryRepository;

        public EntryService(IEntryRepository entryRepository)
        {
            _entryRepository = entryRepository;

        }

        public async Task ApplyAsync(Entry entry)
        {

            _entryRepository.Update(entry);

            await _entryRepository.UnitOfWork.SaveChangesAsync();
        }

        public Task<Entry> PostEntryAsync(string number, DateTimeOffset date, List<EntryItem> items)
        {
            throw new NotImplementedException();
        }

        public Task<Entry> RetrieveEntryAsync(string number)
        {
            throw new NotImplementedException();
        }
    }
}
