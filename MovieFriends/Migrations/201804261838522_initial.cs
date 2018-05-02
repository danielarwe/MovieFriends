namespace MovieFriends.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        ReviewId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Actors = c.String(),
                        Rating = c.Int(nullable: false),
                        Summary = c.String(),
                        Genre = c.String(),
                        ReviewerFirstName = c.String(),
                        ReviewerLastName = c.String(),
                        ReviewerRating = c.Int(nullable: false),
                        Comments = c.String(),
                    })
                .PrimaryKey(t => t.ReviewId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Reviews");
        }
    }
}
