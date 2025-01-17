namespace CW.Backend.DAL.CRUD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CategoryChildOptional : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Categories", new[] { "ParentId" });
            AlterColumn("dbo.Categories", "ParentId", c => c.Int());
            CreateIndex("dbo.Categories", "ParentId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Categories", new[] { "ParentId" });
            AlterColumn("dbo.Categories", "ParentId", c => c.Int(nullable: false));
            CreateIndex("dbo.Categories", "ParentId");
        }
    }
}
