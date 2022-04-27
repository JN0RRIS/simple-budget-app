using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleBudget.Models
{
    public class Entry
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Amount { get; set; }
        public int OwnerId { get; set; }
        public DateTime Date { get; set; }
        public DateTime DateOfCreation { get; set; }
    }
}
