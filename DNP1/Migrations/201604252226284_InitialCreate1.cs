namespace DNP1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Seats",
                c => new
                    {
                        SeatId = c.Int(nullable: false, identity: true),
                        Number = c.Int(nullable: false),
                        StageId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SeatId)
                .ForeignKey("dbo.Stages", t => t.StageId, cascadeDelete: true)
                .Index(t => t.StageId);
            
            CreateTable(
                "dbo.Stages",
                c => new
                    {
                        StageId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.StageId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Seats", "StageId", "dbo.Stages");
            DropIndex("dbo.Seats", new[] { "StageId" });
            DropTable("dbo.Stages");
            DropTable("dbo.Seats");
        }
    }
}
