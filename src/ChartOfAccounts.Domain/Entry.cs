using ChartOfAccounts.Domain.Entities;
using Moonlay.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ChartOfAccounts.Domain
{
    public class Entry : Entity, IAggregateRoot
    {
        public Entry(Guid identity, string number, DateTimeOffset date, List<EntryItem> items)
        {
            Identity = identity;

            Number = number;
            Date = date;
            Items = items;
        }

        public string Number { get; }

        public DateTimeOffset Date { get; }

        public IReadOnlyList<EntryItem> Items { get; private set; }

        public void AddItem(EntryItem item)
        {
            var list = Items.ToList();

            list.Add(item);

            Items = list;
        }
    }
}
