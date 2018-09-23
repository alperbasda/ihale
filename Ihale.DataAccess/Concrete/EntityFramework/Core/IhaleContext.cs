using System.Data.Entity;
using Ihale.Entity.Concrete;

namespace Ihale.DataAccess.Concrete.EntityFramework.Core
{
    public class IhaleContext : DbContext
    {
        public DbSet<Auction> Auctions { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<AuctionPhoto> AuctionPhotos { get; set; }

        public DbSet<Blog> Blogs { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<CategoryFilter> CategoryFilters  { get; set; }

        public DbSet<CategoryFilterDescription> CategoryFilterDescriptions { get; set; }

        public DbSet<CategoryFilterDescriptionAuctionRelation> CategoryFilterDescriptionAuctionRelations { get; set; }

        public DbSet<CategoryFilterRelation> CategoryFilterRelations { get; set; }

        public DbSet<City> Cities { get; set; }

        public DbSet<MailNotification> MailNotifications { get; set; }

        public DbSet<Offer> Offers { get; set; }

        public DbSet<OfferPhoto> OfferPhotos { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<SSS> Ssss { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<UserAdress> UserAdresses { get; set; }

        public DbSet<UserInRole> UserInRoles { get; set; }

        public DbSet<UserMail> UserMails { get; set; }

        public DbSet<UserPassword> UserPasswords { get; set; }

        public DbSet<UserTel> UserTels { get; set; }

        public DbSet<SliderImage> SliderImages { get; set; }

        public DbSet<UserComment> UserComments { get; set; }

        public DbSet<BlogComment> BlogComments { get; set; }

        public DbSet<OurTeam> OurTeams { get; set; }

        public DbSet<AboutUs> AboutUses { get; set; }

        public IhaleContext()
        :base("MiknatislaDatabase")
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Configurations.Add(new CategoryCategoryPropertyRelationMap());
            //modelBuilder.Configurations.Add(new CategoryMap());
            //modelBuilder.Configurations.Add(new CategoryPropertyMap());
            //modelBuilder.Configurations.Add(new ExpiredProductMap());
            //modelBuilder.Configurations.Add(new OfferImageMap());
            //modelBuilder.Configurations.Add(new OfferMap());
            //modelBuilder.Configurations.Add(new ProductCategoryPropertyRelationMap());
            //modelBuilder.Configurations.Add(new ProductMap());
            //modelBuilder.Configurations.Add(new RoleMap());
            //modelBuilder.Configurations.Add(new UserMap());
            //modelBuilder.Configurations.Add(new UserInRoleMap());
            //modelBuilder.Configurations.Add(new UserPaidProductMap());

        }
    }
}