using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment3.Models
{
    public class EFphones1Repository : IMockphones1Repository
    {
        private Model1 db = new Model1();
        public IQueryable<phones1> Phones1 { get { return db.phones1; } }

        public void Delete(phones1 phones)
        {
            throw new NotImplementedException();
        }

        public phones1 Save(phones1 phones)
        {
            throw new NotImplementedException();
        }
    }
}