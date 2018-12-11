using Moonlay.Domain;
using System;

namespace ChartOfAccounts.Domain.ReadModels
{
    public abstract class CoaReadModel : ReadModelExtCore, IAuditTrail, ISoftDelete
    {
        public CoaReadModel()
        {
            CreatedDate = DateTime.Now;
        }

        public string CreatedBy { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public string ModifiedBy { get; set; }

        public DateTimeOffset? ModifiedDate { get; set; }

        public bool? Deleted { get; set; }

        public DateTimeOffset? DeletedDate { get; set; }

        public string DeletedBy { get; set; }
    }
}
