using Domain.ManagerAggregate;
using Domain.SchoolAggregate;
using Infrastructure.Context;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class ManagerRepository : IManagerRepository
    {
        private readonly AppDbContext _context;

        public ManagerRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Manger> GetAllMangers()
        {
            return _context.Managers.ToList();
        }

        public void InsertManger(Manger manger)
        {
            _context.Managers.Add(manger);

        }


    }
}
