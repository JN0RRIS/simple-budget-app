using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleBudget.Models.Interfaces
{
    public interface IEntry
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Amount { get; set; }
        public int OwnerId { get; set; }
    }
}
