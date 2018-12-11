using Moonlay.Domain;
using System;

namespace ChartOfAccounts.Domain.Entities
{
    public class Ledger : Entity
    {
        public Ledger(Guid identity)
        {
            Identity = identity;

        }
    }
}
