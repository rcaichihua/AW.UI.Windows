namespace AW.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTablas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BusinessEntities",
                c => new
                    {
                        BusinessEntityID = c.Int(nullable: false, identity: true),
                        rowguid = c.Guid(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.BusinessEntityID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BusinessEntities");
        }
    }
}
