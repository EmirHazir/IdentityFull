namespace MvcPot.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixedAnswerClass : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Feedbacks", "Answer", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Feedbacks", "Answer", c => c.Int(nullable: false));
        }
    }
}
