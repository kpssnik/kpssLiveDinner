using kpssLiveDinner.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kpssLiveDinner.Domain.Repositories.Abstract
{
    public interface IStuffItemsRepository
    {
        public IQueryable<StuffItem> GetStuffItems();
        public IQueryable<StuffItem> GetStuffItemByName(string name);
        public IQueryable<StuffItem> GetStuffItemsByRole(string role);
        public void SaveStuffItem(StuffItem item);
        public void DeleteStuffItem(StuffItem item);
        
    }
}
