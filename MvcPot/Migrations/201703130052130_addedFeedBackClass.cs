namespace MvcPot.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedFeedBackClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Feedbacks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Answer = c.Int(nullable: false),
                        Comment = c.String(maxLength: 500),
                        FullName = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 120),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Feedbacks");
        }
    }
}
