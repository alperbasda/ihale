namespace Ihale.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AboutUs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Decription = c.String(),
                        ImageUrl = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AuctionPhotoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AuctionId = c.Int(nullable: false),
                        PhotoPath = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Auctions", t => t.AuctionId, cascadeDelete: true)
                .Index(t => t.AuctionId);
            
            CreateTable(
                "dbo.Auctions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                        CityId = c.Int(nullable: false),
                        Title = c.String(),
                        Description = c.String(),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        MaxPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MinPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IsActive = c.Boolean(nullable: false),
                        Count = c.Int(nullable: false),
                        IsRetail = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.Cities", t => t.CityId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.CategoryId)
                .Index(t => t.CityId);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        UpCategoryId = c.Int(),
                        CategoryImageBig = c.String(),
                        CategoryImageSmall = c.String(),
                        Description = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.UpCategoryId)
                .Index(t => t.UpCategoryId);
            
            CreateTable(
                "dbo.CategoryFilterRelations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoryFilterId = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CategoryFilters", t => t.CategoryFilterId, cascadeDelete: true)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryFilterId)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.CategoryFilters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FilterName = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CategoryFilterDescriptionAuctionRelations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoryFilterDescriptionId = c.Int(nullable: false),
                        AuctionId = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CategoryFilterDescriptions", t => t.CategoryFilterDescriptionId, cascadeDelete: true)
                .ForeignKey("dbo.Auctions", t => t.AuctionId, cascadeDelete: true)
                .Index(t => t.CategoryFilterDescriptionId)
                .Index(t => t.AuctionId);
            
            CreateTable(
                "dbo.CategoryFilterDescriptions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoryFilterId = c.Int(nullable: false),
                        Description = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CategoryFilters", t => t.CategoryFilterId, cascadeDelete: true)
                .Index(t => t.CategoryFilterId);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CountryId = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.CountryId, cascadeDelete: true)
                .Index(t => t.CountryId);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        UserName = c.String(),
                        Gender = c.Int(nullable: false),
                        RegisterDate = c.DateTime(nullable: false),
                        LastSeenDate = c.DateTime(nullable: false),
                        RateCount = c.Int(nullable: false),
                        Rate = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserComments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Comment = c.String(),
                        Rate = c.Int(nullable: false),
                        IsAccepted = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.BlogComments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BlogId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Comment = c.String(),
                        Rate = c.Int(nullable: false),
                        IsAccepted = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Blogs", t => t.BlogId, cascadeDelete: true)
                .Index(t => t.BlogId);
            
            CreateTable(
                "dbo.Blogs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        ImageUrl = c.String(),
                        Date = c.DateTime(nullable: false),
                        RateCount = c.Int(nullable: false),
                        Rate = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MailNotifications",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.OfferPhotoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OfferId = c.Int(nullable: false),
                        PhotoPath = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Offers", t => t.OfferId, cascadeDelete: true)
                .Index(t => t.OfferId);
            
            CreateTable(
                "dbo.Offers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        AuctionId = c.Int(nullable: false),
                        OfferDate = c.DateTime(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AcceptedDate = c.DateTime(nullable: false),
                        IsAccepted = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Auctions", t => t.AuctionId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: false)
                .Index(t => t.UserId)
                .Index(t => t.AuctionId);
            
            CreateTable(
                "dbo.OurTeams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        FaceLink = c.String(),
                        InstagramLink = c.String(),
                        TwitterLink = c.String(),
                        Mission = c.String(),
                        Description = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SliderImages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Path = c.String(),
                        Alt = c.String(),
                        RedirectLink = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SSSes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        Date = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserAdresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        Title = c.String(),
                        Description = c.String(),
                        AdressType = c.Int(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.UserInRoles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        RoleId = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Roles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.UserMails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        MailAdress = c.Int(nullable: false),
                        Approved = c.Boolean(nullable: false),
                        Using = c.Boolean(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.UserPasswords",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        Password = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.UserTels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        TelephoneNumber = c.Int(nullable: false),
                        Approved = c.Boolean(nullable: false),
                        Using = c.Boolean(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserTels", "UserId", "dbo.Users");
            DropForeignKey("dbo.UserPasswords", "UserId", "dbo.Users");
            DropForeignKey("dbo.UserMails", "UserId", "dbo.Users");
            DropForeignKey("dbo.UserInRoles", "UserId", "dbo.Users");
            DropForeignKey("dbo.UserInRoles", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.UserAdresses", "UserId", "dbo.Users");
            DropForeignKey("dbo.OfferPhotoes", "OfferId", "dbo.Offers");
            DropForeignKey("dbo.Offers", "UserId", "dbo.Users");
            DropForeignKey("dbo.Offers", "AuctionId", "dbo.Auctions");
            DropForeignKey("dbo.MailNotifications", "UserId", "dbo.Users");
            DropForeignKey("dbo.BlogComments", "BlogId", "dbo.Blogs");
            DropForeignKey("dbo.AuctionPhotoes", "AuctionId", "dbo.Auctions");
            DropForeignKey("dbo.Auctions", "UserId", "dbo.Users");
            DropForeignKey("dbo.UserComments", "UserId", "dbo.Users");
            DropForeignKey("dbo.Auctions", "CityId", "dbo.Cities");
            DropForeignKey("dbo.Cities", "CountryId", "dbo.Countries");
            DropForeignKey("dbo.CategoryFilterDescriptionAuctionRelations", "AuctionId", "dbo.Auctions");
            DropForeignKey("dbo.CategoryFilterDescriptionAuctionRelations", "CategoryFilterDescriptionId", "dbo.CategoryFilterDescriptions");
            DropForeignKey("dbo.CategoryFilterDescriptions", "CategoryFilterId", "dbo.CategoryFilters");
            DropForeignKey("dbo.Auctions", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Categories", "UpCategoryId", "dbo.Categories");
            DropForeignKey("dbo.CategoryFilterRelations", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.CategoryFilterRelations", "CategoryFilterId", "dbo.CategoryFilters");
            DropIndex("dbo.UserTels", new[] { "UserId" });
            DropIndex("dbo.UserPasswords", new[] { "UserId" });
            DropIndex("dbo.UserMails", new[] { "UserId" });
            DropIndex("dbo.UserInRoles", new[] { "RoleId" });
            DropIndex("dbo.UserInRoles", new[] { "UserId" });
            DropIndex("dbo.UserAdresses", new[] { "UserId" });
            DropIndex("dbo.Offers", new[] { "AuctionId" });
            DropIndex("dbo.Offers", new[] { "UserId" });
            DropIndex("dbo.OfferPhotoes", new[] { "OfferId" });
            DropIndex("dbo.MailNotifications", new[] { "UserId" });
            DropIndex("dbo.BlogComments", new[] { "BlogId" });
            DropIndex("dbo.UserComments", new[] { "UserId" });
            DropIndex("dbo.Cities", new[] { "CountryId" });
            DropIndex("dbo.CategoryFilterDescriptions", new[] { "CategoryFilterId" });
            DropIndex("dbo.CategoryFilterDescriptionAuctionRelations", new[] { "AuctionId" });
            DropIndex("dbo.CategoryFilterDescriptionAuctionRelations", new[] { "CategoryFilterDescriptionId" });
            DropIndex("dbo.CategoryFilterRelations", new[] { "CategoryId" });
            DropIndex("dbo.CategoryFilterRelations", new[] { "CategoryFilterId" });
            DropIndex("dbo.Categories", new[] { "UpCategoryId" });
            DropIndex("dbo.Auctions", new[] { "CityId" });
            DropIndex("dbo.Auctions", new[] { "CategoryId" });
            DropIndex("dbo.Auctions", new[] { "UserId" });
            DropIndex("dbo.AuctionPhotoes", new[] { "AuctionId" });
            DropTable("dbo.UserTels");
            DropTable("dbo.UserPasswords");
            DropTable("dbo.UserMails");
            DropTable("dbo.UserInRoles");
            DropTable("dbo.UserAdresses");
            DropTable("dbo.SSSes");
            DropTable("dbo.SliderImages");
            DropTable("dbo.Roles");
            DropTable("dbo.OurTeams");
            DropTable("dbo.Offers");
            DropTable("dbo.OfferPhotoes");
            DropTable("dbo.MailNotifications");
            DropTable("dbo.Blogs");
            DropTable("dbo.BlogComments");
            DropTable("dbo.UserComments");
            DropTable("dbo.Users");
            DropTable("dbo.Countries");
            DropTable("dbo.Cities");
            DropTable("dbo.CategoryFilterDescriptions");
            DropTable("dbo.CategoryFilterDescriptionAuctionRelations");
            DropTable("dbo.CategoryFilters");
            DropTable("dbo.CategoryFilterRelations");
            DropTable("dbo.Categories");
            DropTable("dbo.Auctions");
            DropTable("dbo.AuctionPhotoes");
            DropTable("dbo.AboutUs");
        }
    }
}
