namespace Home_Work.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initialmigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contact_Message",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Message = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Contact_Messanger",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MessageID = c.Int(),
                        SenderID = c.Int(),
                        RecieverID = c.Int(),
                        Date = c.DateTime(),
                        Contact_Message_ID = c.Int(),
                        Profile_User_ID = c.Int(),
                        Profile_User_ID1 = c.Int(),
                        Profile_User_ID2 = c.Int(),
                        Profile_User1_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Contact_Message", t => t.Contact_Message_ID)
                .ForeignKey("dbo.Profile_User", t => t.Profile_User_ID)
                .ForeignKey("dbo.Profile_User", t => t.Profile_User_ID1)
                .ForeignKey("dbo.Profile_User", t => t.Profile_User_ID2)
                .ForeignKey("dbo.Profile_User", t => t.Profile_User1_ID)
                .Index(t => t.Contact_Message_ID)
                .Index(t => t.Profile_User_ID)
                .Index(t => t.Profile_User_ID1)
                .Index(t => t.Profile_User_ID2)
                .Index(t => t.Profile_User1_ID);
            
            CreateTable(
                "dbo.Profile_User",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                        LastLoginDate = c.DateTime(),
                        FirstName = c.String(),
                        MiddleName = c.String(),
                        LastName = c.String(),
                        Gender = c.String(),
                        Nationality = c.String(),
                        Address = c.String(),
                        Email = c.String(),
                        Phone = c.Decimal(precision: 18, scale: 2),
                        CountryCode = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Job_Post",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        Price = c.String(),
                        Requirement = c.String(),
                        WorkingHour = c.String(),
                        WorkingTypeId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        SkillTypeId = c.Int(nullable: false),
                        Job_SkillType_Id = c.Int(),
                        Job_WorkType_Id = c.Int(),
                        Profile_User_ID = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Job_SkillType", t => t.Job_SkillType_Id)
                .ForeignKey("dbo.Job_WorkType", t => t.Job_WorkType_Id)
                .ForeignKey("dbo.Profile_User", t => t.Profile_User_ID)
                .Index(t => t.Job_SkillType_Id)
                .Index(t => t.Job_WorkType_Id)
                .Index(t => t.Profile_User_ID);
            
            CreateTable(
                "dbo.Job_HomeBase",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PostId = c.Int(),
                        JobLocation = c.String(),
                        ContactNo = c.Decimal(precision: 18, scale: 2),
                        CountryCode = c.Decimal(precision: 18, scale: 2),
                        Date = c.DateTime(),
                        Job_Post_Id = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Job_Post", t => t.Job_Post_Id)
                .Index(t => t.Job_Post_Id);
            
            CreateTable(
                "dbo.Job_SkillType",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Job_WorkType",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Profile_WorkStatus",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserId = c.Int(),
                        JobId = c.Int(),
                        Status = c.String(),
                        Approved = c.String(),
                        Job_Post_Id = c.Int(),
                        Profile_User_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Job_Post", t => t.Job_Post_Id)
                .ForeignKey("dbo.Profile_User", t => t.Profile_User_ID)
                .Index(t => t.Job_Post_Id)
                .Index(t => t.Profile_User_ID);
            
            CreateTable(
                "dbo.Portfolio_Image",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ImageCaption = c.String(),
                        UserID = c.Int(),
                        Photo = c.String(),
                        PortfolioID = c.Int(),
                        Profile_Portfolio_ID = c.Int(),
                        Profile_User_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Profile_Portfolio", t => t.Profile_Portfolio_ID)
                .ForeignKey("dbo.Profile_User", t => t.Profile_User_ID)
                .Index(t => t.Profile_Portfolio_ID)
                .Index(t => t.Profile_User_ID);
            
            CreateTable(
                "dbo.Profile_Portfolio",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Project_Name = c.String(),
                        Date = c.DateTime(),
                        ProjectDescription = c.String(),
                        ToolsUsed = c.String(),
                        UserID = c.Int(),
                        Profile_User_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Profile_User", t => t.Profile_User_ID)
                .Index(t => t.Profile_User_ID);
            
            CreateTable(
                "dbo.Profile_Education",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        SchoolName = c.String(),
                        Affiliation = c.String(),
                        Level = c.String(),
                        PassOutDate = c.DateTime(),
                        UserID = c.Int(),
                        Profile_User_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Profile_User", t => t.Profile_User_ID)
                .Index(t => t.Profile_User_ID);
            
            CreateTable(
                "dbo.Profile_Training",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CertificationName = c.String(),
                        InstituteName = c.String(),
                        Skills = c.String(),
                        ComletedDate = c.DateTime(),
                        UserID = c.Int(),
                        Profile_User_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Profile_User", t => t.Profile_User_ID)
                .Index(t => t.Profile_User_ID);
            
            CreateTable(
                "dbo.Profile_Work",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(),
                        Position = c.String(),
                        Responsibility = c.String(),
                        StartDate = c.DateTime(),
                        UserID = c.Int(),
                        Profile_User_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Profile_User", t => t.Profile_User_ID)
                .Index(t => t.Profile_User_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Contact_Messanger", "Profile_User1_ID", "dbo.Profile_User");
            DropForeignKey("dbo.Contact_Messanger", "Profile_User_ID2", "dbo.Profile_User");
            DropForeignKey("dbo.Profile_Work", "Profile_User_ID", "dbo.Profile_User");
            DropForeignKey("dbo.Profile_Training", "Profile_User_ID", "dbo.Profile_User");
            DropForeignKey("dbo.Profile_Education", "Profile_User_ID", "dbo.Profile_User");
            DropForeignKey("dbo.Portfolio_Image", "Profile_User_ID", "dbo.Profile_User");
            DropForeignKey("dbo.Profile_Portfolio", "Profile_User_ID", "dbo.Profile_User");
            DropForeignKey("dbo.Portfolio_Image", "Profile_Portfolio_ID", "dbo.Profile_Portfolio");
            DropForeignKey("dbo.Profile_WorkStatus", "Profile_User_ID", "dbo.Profile_User");
            DropForeignKey("dbo.Profile_WorkStatus", "Job_Post_Id", "dbo.Job_Post");
            DropForeignKey("dbo.Job_Post", "Profile_User_ID", "dbo.Profile_User");
            DropForeignKey("dbo.Job_Post", "Job_WorkType_Id", "dbo.Job_WorkType");
            DropForeignKey("dbo.Job_Post", "Job_SkillType_Id", "dbo.Job_SkillType");
            DropForeignKey("dbo.Job_HomeBase", "Job_Post_Id", "dbo.Job_Post");
            DropForeignKey("dbo.Contact_Messanger", "Profile_User_ID1", "dbo.Profile_User");
            DropForeignKey("dbo.Contact_Messanger", "Profile_User_ID", "dbo.Profile_User");
            DropForeignKey("dbo.Contact_Messanger", "Contact_Message_ID", "dbo.Contact_Message");
            DropIndex("dbo.Profile_Work", new[] { "Profile_User_ID" });
            DropIndex("dbo.Profile_Training", new[] { "Profile_User_ID" });
            DropIndex("dbo.Profile_Education", new[] { "Profile_User_ID" });
            DropIndex("dbo.Profile_Portfolio", new[] { "Profile_User_ID" });
            DropIndex("dbo.Portfolio_Image", new[] { "Profile_User_ID" });
            DropIndex("dbo.Portfolio_Image", new[] { "Profile_Portfolio_ID" });
            DropIndex("dbo.Profile_WorkStatus", new[] { "Profile_User_ID" });
            DropIndex("dbo.Profile_WorkStatus", new[] { "Job_Post_Id" });
            DropIndex("dbo.Job_HomeBase", new[] { "Job_Post_Id" });
            DropIndex("dbo.Job_Post", new[] { "Profile_User_ID" });
            DropIndex("dbo.Job_Post", new[] { "Job_WorkType_Id" });
            DropIndex("dbo.Job_Post", new[] { "Job_SkillType_Id" });
            DropIndex("dbo.Contact_Messanger", new[] { "Profile_User1_ID" });
            DropIndex("dbo.Contact_Messanger", new[] { "Profile_User_ID2" });
            DropIndex("dbo.Contact_Messanger", new[] { "Profile_User_ID1" });
            DropIndex("dbo.Contact_Messanger", new[] { "Profile_User_ID" });
            DropIndex("dbo.Contact_Messanger", new[] { "Contact_Message_ID" });
            DropTable("dbo.Profile_Work");
            DropTable("dbo.Profile_Training");
            DropTable("dbo.Profile_Education");
            DropTable("dbo.Profile_Portfolio");
            DropTable("dbo.Portfolio_Image");
            DropTable("dbo.Profile_WorkStatus");
            DropTable("dbo.Job_WorkType");
            DropTable("dbo.Job_SkillType");
            DropTable("dbo.Job_HomeBase");
            DropTable("dbo.Job_Post");
            DropTable("dbo.Profile_User");
            DropTable("dbo.Contact_Messanger");
            DropTable("dbo.Contact_Message");
        }
    }
}
