namespace KeySimulatorGUI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PatternModels", "PressDemension", c => c.Int(nullable: false));
            DropColumn("dbo.PatternModels", "Description");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PatternModels", "Description", c => c.String());
            DropColumn("dbo.PatternModels", "PressDemension");
        }
    }
}
