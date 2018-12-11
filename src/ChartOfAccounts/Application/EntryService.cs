using ChartOfAccounts.Domain;
using ChartOfAccounts.Domain.Entities;
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

        public async Task Save(Entry entry)
        {
            _entryRepository.Update(entry);

            await _entryRepository.UnitOfWork.SaveChangesAsync();
        }

        public async Task<Entry> PostEntryAsync(string number, DateTimeOffset date, List<EntryItem> items)
        {
            var entry = new Entry(Guid.NewGuid(), number, date, items);

            await this.Save(entry);

            return entry;
        }

        public Task<Entry> RetrieveEntryAsync(string number)
        {
            throw new NotImplementedException();
        }
    }
}
