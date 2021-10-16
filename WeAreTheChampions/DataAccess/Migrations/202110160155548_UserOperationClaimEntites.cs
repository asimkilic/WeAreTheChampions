namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserOperationClaimEntites : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OperationClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserOperationClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        OperationClaimId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.OperationClaims", t => t.OperationClaimId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.OperationClaimId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        PasswordHash = c.Binary(nullable: false),
                        PasswordSalt = c.Binary(nullable: false),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserOperationClaims", "UserId", "dbo.Users");
            DropForeignKey("dbo.UserOperationClaims", "OperationClaimId", "dbo.OperationClaims");
            DropIndex("dbo.UserOperationClaims", new[] { "OperationClaimId" });
            DropIndex("dbo.UserOperationClaims", new[] { "UserId" });
            DropTable("dbo.Users");
            DropTable("dbo.UserOperationClaims");
            DropTable("dbo.OperationClaims");
        }
    }
}
