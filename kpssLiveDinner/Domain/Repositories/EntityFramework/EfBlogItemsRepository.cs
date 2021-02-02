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
    public class EfBlogItemsRepository : IBlogItemsRepository
    {
        private readonly AppDbContext _context;
        public EfBlogItemsRepository(AppDbContext context) => _context = context;
       
        public void DeleteBlogItem(BlogItem item)
        {
            _context.BlogItems.Remove(item);
            _context.SaveChanges();
        }

        public IQueryable<BlogItem> GetBlogItems()
        {
            return _context.BlogItems;
        }

        public void SaveBlogItem(BlogItem item)
        {       
            _context.Entry(item).State = (item.Id == default)
                ? EntityState.Added
                : EntityState.Modified;

            _context.SaveChanges();
        }
    }
}
