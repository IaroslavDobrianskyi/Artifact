namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Steps",
                c => new
                    {
                        StepId = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.StepId);
            
            CreateTable(
                "dbo.StepActions",
                c => new
                    {
                        StepActionId = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Step_StepId = c.Int(),
                    })
                .PrimaryKey(t => t.StepActionId)
                .ForeignKey("dbo.Steps", t => t.Step_StepId)
                .Index(t => t.Step_StepId);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.StepActions", new[] { "Step_StepId" });
            DropForeignKey("dbo.StepActions", "Step_StepId", "dbo.Steps");
            DropTable("dbo.StepActions");
            DropTable("dbo.Steps");
        }
    }
}
