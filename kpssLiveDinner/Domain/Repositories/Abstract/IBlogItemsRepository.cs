using kpssLiveDinner.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kpssLiveDinner.Domain.Repositories.Abstract
{
    public interface IBlogItemsRepository
    {
        public IQueryable<BlogItem> GetBlogItems();
        public void SaveBlogItem(BlogItem item);
        public void DeleteBlogItem(BlogItem item);

    }
}
