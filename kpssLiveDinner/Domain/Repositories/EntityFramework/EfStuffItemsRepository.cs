using kpssLiveDinner.Domain.Entities;
using kpssLiveDinner.Domain.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kpssLiveDinner.Domain.Repositories.EntityFramework
{
    public class EfStuffItemsRepository : IStuffItemsRepository
    {
        private readonly AppDbContext _context;
        public EfStuffItemsRepository(AppDbContext context) => _context = context;

        public void DeleteStuffItem(StuffItem item)
        {
            _context.StuffItems.Remove(item);
            _context.SaveChanges();
        }

        public IQueryable<StuffItem> GetStuffItemByName(string name)
        {
            return _context.StuffItems.Where(x => x.Name.Equals(name));
        }

        public IQueryable<StuffItem> GetStuffItems()
        {
            return _context.StuffItems;
        }

        public IQueryable<StuffItem> GetStuffItemsByRole(string role)
        {
            return _context.StuffItems.Where(x => x.Role.Equals(role));
        }

        public void SaveStuffItem(StuffItem item)
        {
            _context.Entry(item).State = (item.Id == default)
                  ? EntityState.Added
                  : EntityState.Modified;

            _context.SaveChanges();
        }
    }
}
