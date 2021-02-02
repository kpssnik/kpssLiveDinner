using kpssLiveDinner.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kpssLiveDinner.Domain.Repositories.Abstract
{
    public interface IGalleryImagesRepository
    {
        public IQueryable<GalleryImage> GetGalleryImages();
        public void SaveGalleryImage(GalleryImage image);
        public void DeleteGalleryImage(GalleryImage image);
    }
}
