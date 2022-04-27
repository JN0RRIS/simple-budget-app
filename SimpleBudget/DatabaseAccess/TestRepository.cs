using SimpleBudget.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleBudget.DatabaseAccess
{
    public class TestRepository : IRepository<IEntry, int>
    {
        public IEntry Create(IEntry entity)
        {
            throw new NotImplementedException();
        }

        public IEntry Delete(IEntry entity)
        {
            throw new NotImplementedException();
        }

        public List<IEntry> ReadAll()
        {
            throw new NotImplementedException();
        }

        public IEntry GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEntry Update(IEntry entity)
        {
            throw new NotImplementedException();
        }
    }
}
