namespace KeySimulatorGUI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Intial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PatternModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        InitalDelay = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.KeyModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Keycode = c.Int(),
                        Presstime = c.Int(nullable: false),
                        Delay = c.Int(nullable: false),
                        PatternModel_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PatternModels", t => t.PatternModel_Id)
                .Index(t => t.PatternModel_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.KeyModels", "PatternModel_Id", "dbo.PatternModels");
            DropIndex("dbo.KeyModels", new[] { "PatternModel_Id" });
            DropTable("dbo.KeyModels");
            DropTable("dbo.PatternModels");
        }
    }
}
