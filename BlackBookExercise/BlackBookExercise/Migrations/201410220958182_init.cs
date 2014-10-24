namespace BlackBookExercise.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Debitors",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        FirstName = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Exchanges",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Date = c.DateTime(nullable: false),
                        Debitor_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Debitors", t => t.Debitor_Id)
                .Index(t => t.Debitor_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Exchanges", "Debitor_Id", "dbo.Debitors");
            DropIndex("dbo.Exchanges", new[] { "Debitor_Id" });
            DropTable("dbo.Exchanges");
            DropTable("dbo.Debitors");
        }
    }
}
