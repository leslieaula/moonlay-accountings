using Moonlay.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChartOfAccounts.Domain
{
    public interface IEntryRepository : IRepository<Entry>
    {
        void Update(Entry entry);
    }
}
