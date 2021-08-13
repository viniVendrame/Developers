namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateRelationShipDevelopers : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Developers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Address_Id = c.Int(),
                        Contact_Id = c.Int(),
                        Profile_Id = c.Int(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Addresses", t => t.Address_Id)
                .ForeignKey("dbo.Contacts", t => t.Contact_Id)
                .ForeignKey("dbo.Profiles", t => t.Profile_Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.Address_Id)
                .Index(t => t.Contact_Id)
                .Index(t => t.Profile_Id)
                .Index(t => t.User_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Developers", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Developers", "Profile_Id", "dbo.Profiles");
            DropForeignKey("dbo.Developers", "Contact_Id", "dbo.Contacts");
            DropForeignKey("dbo.Developers", "Address_Id", "dbo.Addresses");
            DropIndex("dbo.Developers", new[] { "User_Id" });
            DropIndex("dbo.Developers", new[] { "Profile_Id" });
            DropIndex("dbo.Developers", new[] { "Contact_Id" });
            DropIndex("dbo.Developers", new[] { "Address_Id" });
            DropTable("dbo.Developers");
        }
    }
}
