namespace BigSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Courses", "CategoryID", "dbo.Categories");
            DropIndex("dbo.Courses", new[] { "CategoryID" });
            AddColumn("dbo.Courses", "Caterogy_Id", c => c.Byte());
            CreateIndex("dbo.Courses", "Caterogy_Id");
            AddForeignKey("dbo.Courses", "Caterogy_Id", "dbo.Categories", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "Caterogy_Id", "dbo.Categories");
            DropIndex("dbo.Courses", new[] { "Caterogy_Id" });
            DropColumn("dbo.Courses", "Caterogy_Id");
            CreateIndex("dbo.Courses", "CategoryID");
            AddForeignKey("dbo.Courses", "CategoryID", "dbo.Categories", "Id", cascadeDelete: true);
        }
    }
}
