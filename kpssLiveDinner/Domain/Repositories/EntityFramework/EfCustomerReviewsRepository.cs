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
    public class EfCustomerReviewsRepository : ICustomerReviewsRepository
    {
        private readonly AppDbContext _context;
        public EfCustomerReviewsRepository(AppDbContext context) => _context = context;

        public void DeleteCustomerReview(CustomerReview review)
        {
            _context.CustomerReviews.Remove(review);
            _context.SaveChanges();  
        }

        public IQueryable<CustomerReview> GetCustomerReviews()
        {
            return _context.CustomerReviews;
        }

        public IQueryable<CustomerReview> GetCustomerReviewsByName(string name)
        {
            return _context.CustomerReviews.Where(x => x.Name.Equals(name));
        }

        public void SaveCustomerReview(CustomerReview review)
        {
            _context.Entry(review).State = (review.Id == default)
                 ? EntityState.Added
                 : EntityState.Modified;

            _context.SaveChanges();
        }
    }
}
