namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCatalog : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Colors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ColorName = c.String(),
                        Red = c.Byte(nullable: false),
                        Green = c.Byte(nullable: false),
                        Blue = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => new { t.Red, t.Green, t.Blue }, unique: true);
            
            CreateTable(
                "dbo.TeamColors",
                c => new
                    {
                        ColorId = c.Int(nullable: false),
                        TeamId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ColorId, t.TeamId })
                .ForeignKey("dbo.Colors", t => t.ColorId, cascadeDelete: true)
                .ForeignKey("dbo.Teams", t => t.TeamId, cascadeDelete: true)
                .Index(t => t.ColorId)
                .Index(t => t.TeamId);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TeamName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Matches",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MatchTime = c.DateTime(nullable: false),
                        Score1 = c.Byte(),
                        Score2 = c.Byte(),
                        ResultId = c.Int(),
                        HomeTeamId = c.Int(nullable: false),
                        AwayTeamId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Teams", t => t.AwayTeamId)
                .ForeignKey("dbo.Teams", t => t.HomeTeamId)
                .Index(t => t.HomeTeamId)
                .Index(t => t.AwayTeamId);
            
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PlayerName = c.String(),
                        TeamId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Teams", t => t.TeamId)
                .Index(t => t.TeamId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TeamColors", "TeamId", "dbo.Teams");
            DropForeignKey("dbo.Players", "TeamId", "dbo.Teams");
            DropForeignKey("dbo.Matches", "HomeTeamId", "dbo.Teams");
            DropForeignKey("dbo.Matches", "AwayTeamId", "dbo.Teams");
            DropForeignKey("dbo.TeamColors", "ColorId", "dbo.Colors");
            DropIndex("dbo.Players", new[] { "TeamId" });
            DropIndex("dbo.Matches", new[] { "AwayTeamId" });
            DropIndex("dbo.Matches", new[] { "HomeTeamId" });
            DropIndex("dbo.TeamColors", new[] { "TeamId" });
            DropIndex("dbo.TeamColors", new[] { "ColorId" });
            DropIndex("dbo.Colors", new[] { "Red", "Green", "Blue" });
            DropTable("dbo.Players");
            DropTable("dbo.Matches");
            DropTable("dbo.Teams");
            DropTable("dbo.TeamColors");
            DropTable("dbo.Colors");
        }
    }
}
