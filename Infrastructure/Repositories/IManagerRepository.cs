using Domain.ManagerAggregate;
using Domain.SchoolAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public interface IManagerRepository
    {
        public IEnumerable<Manger> GetAllMangers();
        public void InsertManger(Manger manger);

    }
}
