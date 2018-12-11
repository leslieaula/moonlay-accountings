using ChartOfAccounts.Domain;
using ChartOfAccounts.Infrastructure.ReadModels;
using Moonlay.ExtCore.EntityFrameworkCore;
using Moonlay.ExtCore.Mvc.Abstractions;
using Newtonsoft.Json;

namespace ChartOfAccounts.Infrastructure.Repositories
{
    public class EntryRepository : RepositoryMoonlay<EntryReadModel>, IEntryRepository
    {
        private readonly IWorkContext _workContext;

        public EntryRepository(IWorkContext workContext)
        {
            _workContext = workContext;
        }

        public void Update(Entry entry)
        {
            var readModel = dbSet.Find(entry.Identity);

            readModel.ItemsJson = JsonConvert.SerializeObject(entry.Items);
            readModel.Number = entry.Number;
            readModel.Date = entry.Date;
            readModel.ModifiedBy = _workContext.CurrentUser;

            this.dbSet.Update(readModel);
        }
    }
}
