using kpssLiveDinner.Domain.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kpssLiveDinner.Domain
{
    public class DataManager
    {
        public IBlogItemsRepository BlogItems { get; set; }
        public ICustomerReviewsRepository CustomerReviews { get; set; }
        public IGalleryImagesRepository GalleryImages { get; set; }
        public IStuffItemsRepository StuffItems { get; set; }

        public DataManager(IBlogItemsRepository blogItems, ICustomerReviewsRepository customerReviews, 
            IGalleryImagesRepository galleryImages, IStuffItemsRepository stuffItems)
        {
            BlogItems = blogItems;
            CustomerReviews = customerReviews;
            GalleryImages = galleryImages;
            StuffItems = stuffItems;
        }
    }
}
