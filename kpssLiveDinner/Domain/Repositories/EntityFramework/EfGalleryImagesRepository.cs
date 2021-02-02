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
    public class EfGalleryImagesRepository : IGalleryImagesRepository
    {
        private readonly AppDbContext _context;
        public EfGalleryImagesRepository(AppDbContext context) => _context = context;

        public void DeleteGalleryImage(GalleryImage image)
        {
            _context.GalleryImages.Remove(image);
            _context.SaveChanges();
        }

        public IQueryable<GalleryImage> GetGalleryImages()
        {
            return _context.GalleryImages;
        }

        public void SaveGalleryImage(GalleryImage image)
        {
            _context.Entry(image).State = (image.Id == default)
                  ? EntityState.Added
                  : EntityState.Modified;

            _context.SaveChanges();
        }
    }
}
