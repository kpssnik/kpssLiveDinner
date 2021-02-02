using kpssLiveDinner.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kpssLiveDinner.Domain.Repositories.Abstract
{
    public interface ICustomerReviewsRepository
    {
        public IQueryable<CustomerReview> GetCustomerReviews();
        public IQueryable<CustomerReview> GetCustomerReviewsByName(string name);
        public void SaveCustomerReview(CustomerReview review);
        public void DeleteCustomerReview(CustomerReview review);
    }
}
