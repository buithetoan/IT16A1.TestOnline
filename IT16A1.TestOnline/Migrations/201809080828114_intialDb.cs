namespace IT16A1.TestOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class intialDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AdvancedExamResultDetail",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        AdvancedExamResultD = c.Guid(),
                        QuesionID = c.Guid(),
                        Answer = c.String(maxLength: 5, unicode: false),
                        ResultAswer = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.AdvancedExamResult", t => t.AdvancedExamResultD)
                .ForeignKey("dbo.Question", t => t.QuesionID)
                .Index(t => t.AdvancedExamResultD)
                .Index(t => t.QuesionID);
            
            CreateTable(
                "dbo.AdvancedExamResult",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        ExamPeriodID = c.Guid(),
                        AdvancedModuleRegistrationID = c.Guid(),
                        ExaminationQuestionID = c.Guid(),
                        ExamCode = c.Int(),
                        Duration = c.Int(),
                        TrueQuestion = c.Int(),
                        Point = c.Double(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ExamPeriod", t => t.ExamPeriodID)
                .Index(t => t.ExamPeriodID);
            
            CreateTable(
                "dbo.ExamPeriod",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        ExaminationDate = c.DateTime(storeType: "date"),
                        StartEndTime = c.String(maxLength: 20, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.BasicExamResult",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        ExamPeriodID = c.Guid(),
                        RegistrationID = c.Guid(),
                        ExaminationQuestionID = c.Guid(),
                        ExamCode = c.Int(),
                        Duration = c.Int(),
                        TrueQuestion = c.Int(),
                        Point = c.Double(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ExaminationQuestion", t => t.ExaminationQuestionID)
                .ForeignKey("dbo.Registration", t => t.RegistrationID)
                .ForeignKey("dbo.ExamPeriod", t => t.ExamPeriodID)
                .Index(t => t.ExamPeriodID)
                .Index(t => t.RegistrationID)
                .Index(t => t.ExaminationQuestionID);
            
            CreateTable(
                "dbo.ExaminationQuestion",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        ExaminationID = c.Guid(),
                        ExamCode = c.Int(),
                        QuesitionID = c.Guid(),
                        QuestionContent = c.String(),
                        AAnswer = c.String(maxLength: 100),
                        BAnswer = c.String(maxLength: 100),
                        CAnswer = c.String(maxLength: 100),
                        DAnswer = c.String(maxLength: 100),
                        Answer = c.String(maxLength: 5, unicode: false),
                        ResultAswer = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Question", t => t.QuesitionID)
                .ForeignKey("dbo.Examination", t => t.ExaminationID)
                .Index(t => t.ExaminationID)
                .Index(t => t.QuesitionID);
            
            CreateTable(
                "dbo.Examination",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Name = c.String(maxLength: 50),
                        ExaminationDate = c.DateTime(storeType: "date"),
                        Duration = c.Int(),
                        QuestionNumber = c.Int(),
                        TestNumber = c.Int(),
                        ExellentNumber = c.Int(),
                        VeryGoodNumber = c.Int(),
                        GoodNumber = c.Int(),
                        AverageNumber = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ExaminationModule",
                c => new
                    {
                        ExaminationID = c.Guid(nullable: false),
                        QuestionModuleID = c.Guid(nullable: false),
                        ExellentNumber = c.Int(),
                        VeryGoodNumber = c.Int(),
                        GoodNumber = c.Int(),
                        AverageNumber = c.Int(),
                    })
                .PrimaryKey(t => new { t.ExaminationID, t.QuestionModuleID })
                .ForeignKey("dbo.QuestionModule", t => t.QuestionModuleID)
                .ForeignKey("dbo.Examination", t => t.ExaminationID)
                .Index(t => t.ExaminationID)
                .Index(t => t.QuestionModuleID);
            
            CreateTable(
                "dbo.QuestionModule",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        InformationTechnologySkillID = c.Guid(),
                        Name = c.String(maxLength: 100),
                        Quantity = c.Int(),
                        Remark = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.AdvancedModuleRegistration",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        RegistrationID = c.Guid(),
                        QuestionModuleID = c.Guid(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.QuestionModule", t => t.QuestionModuleID)
                .ForeignKey("dbo.Registration", t => t.RegistrationID)
                .Index(t => t.RegistrationID)
                .Index(t => t.QuestionModuleID);
            
            CreateTable(
                "dbo.Registration",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        ExamineeID = c.Guid(),
                        InformationTechnologySkillID = c.Guid(),
                        RegistrationDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.InformationTechnologySkill", t => t.InformationTechnologySkillID)
                .Index(t => t.InformationTechnologySkillID);
            
            CreateTable(
                "dbo.InformationTechnologySkill",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Name = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Question",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        QuestionModuleID = c.Guid(),
                        QuestionClassificationID = c.Guid(),
                        QuestionContent = c.String(),
                        AAnswer = c.String(maxLength: 100),
                        BAnswer = c.String(maxLength: 100),
                        CAnswer = c.String(maxLength: 100),
                        DAnswer = c.String(maxLength: 100),
                        Answer = c.String(maxLength: 5, unicode: false),
                        ResultAswer = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.QuestionClassification", t => t.QuestionClassificationID)
                .ForeignKey("dbo.QuestionModule", t => t.QuestionModuleID)
                .Index(t => t.QuestionModuleID)
                .Index(t => t.QuestionClassificationID);
            
            CreateTable(
                "dbo.BasicExamResultDetail",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        BasicExamResultID = c.Guid(),
                        QuesionID = c.Guid(),
                        Answer = c.String(maxLength: 5, unicode: false),
                        ResultAswer = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Question", t => t.QuesionID)
                .Index(t => t.QuesionID);
            
            CreateTable(
                "dbo.QuestionClassification",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Name = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Examinee",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Password = c.String(maxLength: 200, unicode: false),
                        LastName = c.String(maxLength: 50),
                        FirstName = c.String(maxLength: 50),
                        FullName = c.String(maxLength: 100),
                        Birthday = c.DateTime(storeType: "date"),
                        Gender = c.Boolean(),
                        IdentityCard = c.String(maxLength: 15, unicode: false),
                        Mobile = c.String(maxLength: 15, unicode: false),
                        Email = c.String(maxLength: 50, unicode: false),
                        Note = c.String(unicode: false, storeType: "text"),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        IDStudent = c.Guid(),
                        ExamineeID = c.Guid(),
                        MajorClassID = c.Guid(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Examinee", t => t.ExamineeID)
                .ForeignKey("dbo.MajorClass", t => t.MajorClassID)
                .Index(t => t.ExamineeID)
                .Index(t => t.MajorClassID);
            
            CreateTable(
                "dbo.MajorClass",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Name = c.String(maxLength: 50, unicode: false),
                        Course = c.String(maxLength: 20, unicode: false),
                        FacultyID = c.Guid(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Faculty", t => t.FacultyID)
                .Index(t => t.FacultyID);
            
            CreateTable(
                "dbo.Faculty",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Name = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.LocationExam",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Name = c.String(maxLength: 100),
                        State = c.Boolean(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Manager",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        UserName = c.String(maxLength: 100, unicode: false),
                        Password = c.String(maxLength: 255, unicode: false),
                        LastName = c.String(maxLength: 100),
                        FirstName = c.String(maxLength: 100),
                        Mobile = c.String(maxLength: 20, unicode: false),
                        Email = c.String(maxLength: 50, unicode: false),
                        Role = c.String(maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Note",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Name = c.String(maxLength: 255),
                        State = c.Boolean(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Student", "MajorClassID", "dbo.MajorClass");
            DropForeignKey("dbo.MajorClass", "FacultyID", "dbo.Faculty");
            DropForeignKey("dbo.Student", "ExamineeID", "dbo.Examinee");
            DropForeignKey("dbo.BasicExamResult", "ExamPeriodID", "dbo.ExamPeriod");
            DropForeignKey("dbo.ExaminationQuestion", "ExaminationID", "dbo.Examination");
            DropForeignKey("dbo.ExaminationModule", "ExaminationID", "dbo.Examination");
            DropForeignKey("dbo.Question", "QuestionModuleID", "dbo.QuestionModule");
            DropForeignKey("dbo.Question", "QuestionClassificationID", "dbo.QuestionClassification");
            DropForeignKey("dbo.ExaminationQuestion", "QuesitionID", "dbo.Question");
            DropForeignKey("dbo.BasicExamResultDetail", "QuesionID", "dbo.Question");
            DropForeignKey("dbo.AdvancedExamResultDetail", "QuesionID", "dbo.Question");
            DropForeignKey("dbo.ExaminationModule", "QuestionModuleID", "dbo.QuestionModule");
            DropForeignKey("dbo.Registration", "InformationTechnologySkillID", "dbo.InformationTechnologySkill");
            DropForeignKey("dbo.BasicExamResult", "RegistrationID", "dbo.Registration");
            DropForeignKey("dbo.AdvancedModuleRegistration", "RegistrationID", "dbo.Registration");
            DropForeignKey("dbo.AdvancedModuleRegistration", "QuestionModuleID", "dbo.QuestionModule");
            DropForeignKey("dbo.BasicExamResult", "ExaminationQuestionID", "dbo.ExaminationQuestion");
            DropForeignKey("dbo.AdvancedExamResult", "ExamPeriodID", "dbo.ExamPeriod");
            DropForeignKey("dbo.AdvancedExamResultDetail", "AdvancedExamResultD", "dbo.AdvancedExamResult");
            DropIndex("dbo.MajorClass", new[] { "FacultyID" });
            DropIndex("dbo.Student", new[] { "MajorClassID" });
            DropIndex("dbo.Student", new[] { "ExamineeID" });
            DropIndex("dbo.BasicExamResultDetail", new[] { "QuesionID" });
            DropIndex("dbo.Question", new[] { "QuestionClassificationID" });
            DropIndex("dbo.Question", new[] { "QuestionModuleID" });
            DropIndex("dbo.Registration", new[] { "InformationTechnologySkillID" });
            DropIndex("dbo.AdvancedModuleRegistration", new[] { "QuestionModuleID" });
            DropIndex("dbo.AdvancedModuleRegistration", new[] { "RegistrationID" });
            DropIndex("dbo.ExaminationModule", new[] { "QuestionModuleID" });
            DropIndex("dbo.ExaminationModule", new[] { "ExaminationID" });
            DropIndex("dbo.ExaminationQuestion", new[] { "QuesitionID" });
            DropIndex("dbo.ExaminationQuestion", new[] { "ExaminationID" });
            DropIndex("dbo.BasicExamResult", new[] { "ExaminationQuestionID" });
            DropIndex("dbo.BasicExamResult", new[] { "RegistrationID" });
            DropIndex("dbo.BasicExamResult", new[] { "ExamPeriodID" });
            DropIndex("dbo.AdvancedExamResult", new[] { "ExamPeriodID" });
            DropIndex("dbo.AdvancedExamResultDetail", new[] { "QuesionID" });
            DropIndex("dbo.AdvancedExamResultDetail", new[] { "AdvancedExamResultD" });
            DropTable("dbo.Note");
            DropTable("dbo.Manager");
            DropTable("dbo.LocationExam");
            DropTable("dbo.Faculty");
            DropTable("dbo.MajorClass");
            DropTable("dbo.Student");
            DropTable("dbo.Examinee");
            DropTable("dbo.QuestionClassification");
            DropTable("dbo.BasicExamResultDetail");
            DropTable("dbo.Question");
            DropTable("dbo.InformationTechnologySkill");
            DropTable("dbo.Registration");
            DropTable("dbo.AdvancedModuleRegistration");
            DropTable("dbo.QuestionModule");
            DropTable("dbo.ExaminationModule");
            DropTable("dbo.Examination");
            DropTable("dbo.ExaminationQuestion");
            DropTable("dbo.BasicExamResult");
            DropTable("dbo.ExamPeriod");
            DropTable("dbo.AdvancedExamResult");
            DropTable("dbo.AdvancedExamResultDetail");
        }
    }
}
