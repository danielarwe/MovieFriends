namespace MovieFriends.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedDatatAnnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Reviews", "Title", c => c.String(nullable: false));
            AlterColumn("dbo.Reviews", "ReviewerFirstName", c => c.String(nullable: false));
            AlterColumn("dbo.Reviews", "ReviewerLastName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Reviews", "ReviewerLastName", c => c.String());
            AlterColumn("dbo.Reviews", "ReviewerFirstName", c => c.String());
            AlterColumn("dbo.Reviews", "Title", c => c.String());
        }
    }
}
