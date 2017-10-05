namespace KeySimulatorGUI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OrderModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EndDelay = c.Int(nullable: false),
                        Title = c.String(),
                        PatternModel_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PatternModels", t => t.PatternModel_Id)
                .Index(t => t.PatternModel_Id);
            
            CreateTable(
                "dbo.KeyModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Keycode = c.Int(nullable: false),
                        Presstime = c.Int(nullable: false),
                        Delay = c.Int(nullable: false),
                        Title = c.String(),
                        OrderModel_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.OrderModels", t => t.OrderModel_Id)
                .Index(t => t.OrderModel_Id);
            
            CreateTable(
                "dbo.PatternModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        InitalDelay = c.Int(nullable: false),
                        AdditonalBetweenDelay = c.Int(nullable: false),
                        Title = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderModels", "PatternModel_Id", "dbo.PatternModels");
            DropForeignKey("dbo.KeyModels", "OrderModel_Id", "dbo.OrderModels");
            DropIndex("dbo.KeyModels", new[] { "OrderModel_Id" });
            DropIndex("dbo.OrderModels", new[] { "PatternModel_Id" });
            DropTable("dbo.PatternModels");
            DropTable("dbo.KeyModels");
            DropTable("dbo.OrderModels");
        }
    }
}
