using kpssLiveDinner.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kpssLiveDinner.Domain
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<BlogItem> BlogItems { get; set; }
        public DbSet<CustomerReview> CustomerReviews { get; set; }
        public DbSet<GalleryImage> GalleryImages { get; set; }
        public DbSet<StuffItem> StuffItems { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Initial BlogItems
            builder.Entity<BlogItem>().HasData(new BlogItem()
            {
                Author = "Nikita Andreevich",
                Date = DateTime.UtcNow,
                Heading = "So good for real...",
                Message = "Nikita says that this web-application is so good yeah boy shit some text to fill kakakaka lorem ipsum ge ka"
            });
            builder.Entity<BlogItem>().HasData(new BlogItem()
            {
                Author = "Oleg Dubovoy",
                Date = DateTime.UtcNow,
                Heading = "So bad shit god damn...",
                Message = "Oleg says thah this is full shit bitch fuck yeah ahahaha"
            });

            // Initial CustomerReviews
            builder.Entity<CustomerReview>().HasData(new CustomerReview()
            {
                Name = "Paul Mitchel",
                Role = "Web Designer",
                Message = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam eu sem tempor, varius quam at, luctus dui. Mauris magna metus, dapibus nec turpis vel, semper malesuada ante. Idac bibendum scelerisque non non purus. Suspendisse varius nibh non aliquet."
            });
            builder.Entity<CustomerReview>().HasData(new CustomerReview()
            {
                Name = "Redo Mufasa",
                Role = "True rapper",
                Message = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam eu sem tempor, varius quam at, luctus dui. Mauris magna metus, dapibus nec turpis vel, semper malesuada ante. Idac bibendum scelerisque non non purus. Suspendisse varius nibh non aliquet."
            });
            builder.Entity<CustomerReview>().HasData(new CustomerReview()
            {
                Name = "John Wick",
                Role = "Killer",
                Message = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam eu sem tempor, varius quam at, luctus dui. Mauris magna metus, dapibus nec turpis vel, semper malesuada ante. Idac bibendum scelerisque non non purus. Suspendisse varius nibh non aliquet."
            });

            // Initial StuffItems
            builder.Entity<StuffItem>().HasData(new StuffItem()
            {
                Name = "Nikita Andreevich",
                Role = "Master chief",
                ImagePath = "stuff-img-01.jpg"
            });
            builder.Entity<StuffItem>().HasData(new StuffItem()
            {
                Name = "Oleg Anatolievich",
                Role = "Loh Killer",
                ImagePath = "stuff-img-02.jpg"
            });
            builder.Entity<StuffItem>().HasData(new StuffItem()
            {
                Name = "Valeriya Olegovna",
                Role = "Killer sex doll",
                ImagePath = "stuff-img-03.jpg"
            });

            // Initial GalleryImages
            builder.Entity<GalleryImage>().HasData(new GalleryImage()
            {
                ImagePath = "gallery-img-01.jpg"
            }); ;
            builder.Entity<GalleryImage>().HasData(new GalleryImage()
            {
                ImagePath = "gallery-img-02.jpg"
            }); ;
            builder.Entity<GalleryImage>().HasData(new GalleryImage()
            {
                ImagePath = "gallery-img-03.jpg"
            }); ;
            builder.Entity<GalleryImage>().HasData(new GalleryImage()
            {
                ImagePath = "gallery-img-04.jpg"
            }); ;
            builder.Entity<GalleryImage>().HasData(new GalleryImage()
            {
                ImagePath = "gallery-img-05.jpg"
            }); ;
        }

    }
}
