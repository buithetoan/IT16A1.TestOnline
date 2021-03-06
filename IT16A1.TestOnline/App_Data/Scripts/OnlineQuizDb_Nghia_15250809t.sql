USE [master]
GO
/****** Object:  Database [OnlineQuizDB]    Script Date: 09/08/2018 15:26:04 ******/
CREATE DATABASE [OnlineQuizDB] ON  PRIMARY 
( NAME = N'OnlineQuizDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\OnlineQuizDB.mdf' , SIZE = 2304KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'OnlineQuizDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\OnlineQuizDB_log.LDF' , SIZE = 768KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [OnlineQuizDB] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [OnlineQuizDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [OnlineQuizDB] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [OnlineQuizDB] SET ANSI_NULLS OFF
GO
ALTER DATABASE [OnlineQuizDB] SET ANSI_PADDING OFF
GO
ALTER DATABASE [OnlineQuizDB] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [OnlineQuizDB] SET ARITHABORT OFF
GO
ALTER DATABASE [OnlineQuizDB] SET AUTO_CLOSE ON
GO
ALTER DATABASE [OnlineQuizDB] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [OnlineQuizDB] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [OnlineQuizDB] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [OnlineQuizDB] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [OnlineQuizDB] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [OnlineQuizDB] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [OnlineQuizDB] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [OnlineQuizDB] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [OnlineQuizDB] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [OnlineQuizDB] SET  ENABLE_BROKER
GO
ALTER DATABASE [OnlineQuizDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [OnlineQuizDB] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [OnlineQuizDB] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [OnlineQuizDB] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [OnlineQuizDB] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [OnlineQuizDB] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [OnlineQuizDB] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [OnlineQuizDB] SET  READ_WRITE
GO
ALTER DATABASE [OnlineQuizDB] SET RECOVERY SIMPLE
GO
ALTER DATABASE [OnlineQuizDB] SET  MULTI_USER
GO
ALTER DATABASE [OnlineQuizDB] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [OnlineQuizDB] SET DB_CHAINING OFF
GO
USE [OnlineQuizDB]
GO
/****** Object:  Table [dbo].[QuestionClassification]    Script Date: 09/08/2018 15:26:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuestionClassification](
	[ID] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Note]    Script Date: 09/08/2018 15:26:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Note](
	[ID] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](255) NULL,
	[State] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Manager]    Script Date: 09/08/2018 15:26:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Manager](
	[ID] [uniqueidentifier] NOT NULL,
	[UserName] [varchar](100) NULL,
	[Password] [varchar](255) NULL,
	[LastName] [nvarchar](100) NULL,
	[FirstName] [nvarchar](100) NULL,
	[Mobile] [varchar](20) NULL,
	[Email] [varchar](50) NULL,
	[Role] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LocationExam]    Script Date: 09/08/2018 15:26:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LocationExam](
	[ID] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](100) NULL,
	[State] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InformationTechnologySkill]    Script Date: 09/08/2018 15:26:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InformationTechnologySkill](
	[ID] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Faculty]    Script Date: 09/08/2018 15:26:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Faculty](
	[ID] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ExamPeriod]    Script Date: 09/08/2018 15:26:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ExamPeriod](
	[ID] [uniqueidentifier] NOT NULL,
	[ExaminationDate] [date] NULL,
	[StartEndTime] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Examinee]    Script Date: 09/08/2018 15:26:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Examinee](
	[ID] [uniqueidentifier] NOT NULL,
	[Password] [varchar](200) NULL,
	[LastName] [nvarchar](50) NULL,
	[FirstName] [nvarchar](50) NULL,
	[FullName] [nvarchar](100) NULL,
	[Birthday] [date] NULL,
	[Gender] [bit] NULL,
	[IdentityCard] [varchar](15) NULL,
	[Mobile] [varchar](15) NULL,
	[Email] [varchar](50) NULL,
	[Note] [text] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Examination]    Script Date: 09/08/2018 15:26:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Examination](
	[ID] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](50) NULL,
	[ExaminationDate] [date] NULL,
	[Duration] [int] NULL,
	[QuestionNumber] [int] NULL,
	[TestNumber] [int] NULL,
	[ExellentNumber] [int] NULL,
	[VeryGoodNumber] [int] NULL,
	[GoodNumber] [int] NULL,
	[AverageNumber] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AdvancedExamResult]    Script Date: 09/08/2018 15:26:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AdvancedExamResult](
	[ID] [uniqueidentifier] NOT NULL,
	[ExamPeriodID] [uniqueidentifier] NULL,
	[AdvancedModuleRegistrationID] [uniqueidentifier] NULL,
	[ExaminationQuestionID] [uniqueidentifier] NULL,
	[ExamCode] [int] NULL,
	[Duration] [int] NULL,
	[TrueQuestion] [int] NULL,
	[Point] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MajorClass]    Script Date: 09/08/2018 15:26:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MajorClass](
	[ID] [uniqueidentifier] NOT NULL,
	[Name] [varchar](50) NULL,
	[Course] [varchar](20) NULL,
	[FacultyID] [uniqueidentifier] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Registration]    Script Date: 09/08/2018 15:26:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Registration](
	[ID] [uniqueidentifier] NOT NULL,
	[ExamineeID] [uniqueidentifier] NULL,
	[InformationTechnologySkillID] [uniqueidentifier] NULL,
	[RegistrationDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuestionModule]    Script Date: 09/08/2018 15:26:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuestionModule](
	[ID] [uniqueidentifier] NOT NULL,
	[InformationTechnologySkillID] [uniqueidentifier] NULL,
	[Name] [nvarchar](100) NULL,
	[Quantity] [int] NULL,
	[Remark] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 09/08/2018 15:26:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[ID] [uniqueidentifier] NOT NULL,
	[IDStudent] [uniqueidentifier] NULL,
	[ExamineeID] [uniqueidentifier] NULL,
	[MajorClassID] [uniqueidentifier] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ExaminationModule]    Script Date: 09/08/2018 15:26:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ExaminationModule](
	[ExaminationID] [uniqueidentifier] NOT NULL,
	[QuestionModuleID] [uniqueidentifier] NOT NULL,
	[ExellentNumber] [int] NULL,
	[VeryGoodNumber] [int] NULL,
	[GoodNumber] [int] NULL,
	[AverageNumber] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ExaminationID] ASC,
	[QuestionModuleID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Question]    Script Date: 09/08/2018 15:26:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Question](
	[ID] [uniqueidentifier] NOT NULL,
	[QuestionModuleID] [uniqueidentifier] NULL,
	[QuestionClassificationID] [uniqueidentifier] NULL,
	[QuestionContent] [nvarchar](max) NULL,
	[AAnswer] [nvarchar](100) NULL,
	[BAnswer] [nvarchar](100) NULL,
	[CAnswer] [nvarchar](100) NULL,
	[DAnswer] [nvarchar](100) NULL,
	[Answer] [varchar](5) NULL,
	[ResultAswer] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[AdvancedModuleRegistration]    Script Date: 09/08/2018 15:26:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AdvancedModuleRegistration](
	[ID] [uniqueidentifier] NOT NULL,
	[RegistrationID] [uniqueidentifier] NULL,
	[QuestionModuleID] [uniqueidentifier] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ExaminationQuestion]    Script Date: 09/08/2018 15:26:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ExaminationQuestion](
	[ID] [uniqueidentifier] NOT NULL,
	[ExaminationID] [uniqueidentifier] NULL,
	[ExamCode] [int] NULL,
	[QuesitionID] [uniqueidentifier] NULL,
	[QuestionContent] [nvarchar](max) NULL,
	[AAnswer] [nvarchar](100) NULL,
	[BAnswer] [nvarchar](100) NULL,
	[CAnswer] [nvarchar](100) NULL,
	[DAnswer] [nvarchar](100) NULL,
	[Answer] [varchar](5) NULL,
	[ResultAswer] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[AdvancedExamResultDetail]    Script Date: 09/08/2018 15:26:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AdvancedExamResultDetail](
	[ID] [uniqueidentifier] NOT NULL,
	[AdvancedExamResultD] [uniqueidentifier] NULL,
	[QuesionID] [uniqueidentifier] NULL,
	[Answer] [varchar](5) NULL,
	[ResultAswer] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[BasicExamResultDetail]    Script Date: 09/08/2018 15:26:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BasicExamResultDetail](
	[ID] [uniqueidentifier] NOT NULL,
	[BasicExamResultID] [uniqueidentifier] NULL,
	[QuesionID] [uniqueidentifier] NULL,
	[Answer] [varchar](5) NULL,
	[ResultAswer] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[BasicExamResult]    Script Date: 09/08/2018 15:26:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BasicExamResult](
	[ID] [uniqueidentifier] NOT NULL,
	[ExamPeriodID] [uniqueidentifier] NULL,
	[RegistrationID] [uniqueidentifier] NULL,
	[ExaminationQuestionID] [uniqueidentifier] NULL,
	[ExamCode] [int] NULL,
	[Duration] [int] NULL,
	[TrueQuestion] [int] NULL,
	[Point] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_AdvancedExamResult_ExamPeriod]    Script Date: 09/08/2018 15:26:05 ******/
ALTER TABLE [dbo].[AdvancedExamResult]  WITH CHECK ADD  CONSTRAINT [FK_AdvancedExamResult_ExamPeriod] FOREIGN KEY([ExamPeriodID])
REFERENCES [dbo].[ExamPeriod] ([ID])
GO
ALTER TABLE [dbo].[AdvancedExamResult] CHECK CONSTRAINT [FK_AdvancedExamResult_ExamPeriod]
GO
/****** Object:  ForeignKey [FK_MajorClass_Faculty]    Script Date: 09/08/2018 15:26:05 ******/
ALTER TABLE [dbo].[MajorClass]  WITH CHECK ADD  CONSTRAINT [FK_MajorClass_Faculty] FOREIGN KEY([FacultyID])
REFERENCES [dbo].[Faculty] ([ID])
GO
ALTER TABLE [dbo].[MajorClass] CHECK CONSTRAINT [FK_MajorClass_Faculty]
GO
/****** Object:  ForeignKey [FK_Registration_InformationTechnologySkill]    Script Date: 09/08/2018 15:26:05 ******/
ALTER TABLE [dbo].[Registration]  WITH CHECK ADD  CONSTRAINT [FK_Registration_InformationTechnologySkill] FOREIGN KEY([InformationTechnologySkillID])
REFERENCES [dbo].[InformationTechnologySkill] ([ID])
GO
ALTER TABLE [dbo].[Registration] CHECK CONSTRAINT [FK_Registration_InformationTechnologySkill]
GO
/****** Object:  ForeignKey [FK_QuestionModule_InformationTechnologySkill]    Script Date: 09/08/2018 15:26:05 ******/
ALTER TABLE [dbo].[QuestionModule]  WITH CHECK ADD  CONSTRAINT [FK_QuestionModule_InformationTechnologySkill] FOREIGN KEY([InformationTechnologySkillID])
REFERENCES [dbo].[InformationTechnologySkill] ([ID])
GO
ALTER TABLE [dbo].[QuestionModule] CHECK CONSTRAINT [FK_QuestionModule_InformationTechnologySkill]
GO
/****** Object:  ForeignKey [FK_Student_Examinee]    Script Date: 09/08/2018 15:26:05 ******/
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_Examinee] FOREIGN KEY([ExamineeID])
REFERENCES [dbo].[Examinee] ([ID])
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_Examinee]
GO
/****** Object:  ForeignKey [FK_Student_MajorClass]    Script Date: 09/08/2018 15:26:05 ******/
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_MajorClass] FOREIGN KEY([MajorClassID])
REFERENCES [dbo].[MajorClass] ([ID])
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_MajorClass]
GO
/****** Object:  ForeignKey [FK_ExaminationModule_Examination]    Script Date: 09/08/2018 15:26:05 ******/
ALTER TABLE [dbo].[ExaminationModule]  WITH CHECK ADD  CONSTRAINT [FK_ExaminationModule_Examination] FOREIGN KEY([ExaminationID])
REFERENCES [dbo].[Examination] ([ID])
GO
ALTER TABLE [dbo].[ExaminationModule] CHECK CONSTRAINT [FK_ExaminationModule_Examination]
GO
/****** Object:  ForeignKey [FK_ExaminationModule_QuestionModule]    Script Date: 09/08/2018 15:26:05 ******/
ALTER TABLE [dbo].[ExaminationModule]  WITH CHECK ADD  CONSTRAINT [FK_ExaminationModule_QuestionModule] FOREIGN KEY([QuestionModuleID])
REFERENCES [dbo].[QuestionModule] ([ID])
GO
ALTER TABLE [dbo].[ExaminationModule] CHECK CONSTRAINT [FK_ExaminationModule_QuestionModule]
GO
/****** Object:  ForeignKey [FK_Question_QuestionClassification]    Script Date: 09/08/2018 15:26:05 ******/
ALTER TABLE [dbo].[Question]  WITH CHECK ADD  CONSTRAINT [FK_Question_QuestionClassification] FOREIGN KEY([QuestionClassificationID])
REFERENCES [dbo].[QuestionClassification] ([ID])
GO
ALTER TABLE [dbo].[Question] CHECK CONSTRAINT [FK_Question_QuestionClassification]
GO
/****** Object:  ForeignKey [FK_Question_QuestionModule1]    Script Date: 09/08/2018 15:26:05 ******/
ALTER TABLE [dbo].[Question]  WITH CHECK ADD  CONSTRAINT [FK_Question_QuestionModule1] FOREIGN KEY([QuestionModuleID])
REFERENCES [dbo].[QuestionModule] ([ID])
GO
ALTER TABLE [dbo].[Question] CHECK CONSTRAINT [FK_Question_QuestionModule1]
GO
/****** Object:  ForeignKey [FK_AdvancedModuleRegistration_QuestionModule]    Script Date: 09/08/2018 15:26:05 ******/
ALTER TABLE [dbo].[AdvancedModuleRegistration]  WITH CHECK ADD  CONSTRAINT [FK_AdvancedModuleRegistration_QuestionModule] FOREIGN KEY([QuestionModuleID])
REFERENCES [dbo].[QuestionModule] ([ID])
GO
ALTER TABLE [dbo].[AdvancedModuleRegistration] CHECK CONSTRAINT [FK_AdvancedModuleRegistration_QuestionModule]
GO
/****** Object:  ForeignKey [FK_AdvancedModuleRegistration_Registration]    Script Date: 09/08/2018 15:26:05 ******/
ALTER TABLE [dbo].[AdvancedModuleRegistration]  WITH CHECK ADD  CONSTRAINT [FK_AdvancedModuleRegistration_Registration] FOREIGN KEY([RegistrationID])
REFERENCES [dbo].[Registration] ([ID])
GO
ALTER TABLE [dbo].[AdvancedModuleRegistration] CHECK CONSTRAINT [FK_AdvancedModuleRegistration_Registration]
GO
/****** Object:  ForeignKey [FK_ExaminationQuestion_Examination]    Script Date: 09/08/2018 15:26:05 ******/
ALTER TABLE [dbo].[ExaminationQuestion]  WITH CHECK ADD  CONSTRAINT [FK_ExaminationQuestion_Examination] FOREIGN KEY([ExaminationID])
REFERENCES [dbo].[Examination] ([ID])
GO
ALTER TABLE [dbo].[ExaminationQuestion] CHECK CONSTRAINT [FK_ExaminationQuestion_Examination]
GO
/****** Object:  ForeignKey [FK_ExaminationQuestion_Question]    Script Date: 09/08/2018 15:26:05 ******/
ALTER TABLE [dbo].[ExaminationQuestion]  WITH CHECK ADD  CONSTRAINT [FK_ExaminationQuestion_Question] FOREIGN KEY([QuesitionID])
REFERENCES [dbo].[Question] ([ID])
GO
ALTER TABLE [dbo].[ExaminationQuestion] CHECK CONSTRAINT [FK_ExaminationQuestion_Question]
GO
/****** Object:  ForeignKey [FK_AdvancedExamResultDetail_AdvancedExamResult]    Script Date: 09/08/2018 15:26:05 ******/
ALTER TABLE [dbo].[AdvancedExamResultDetail]  WITH CHECK ADD  CONSTRAINT [FK_AdvancedExamResultDetail_AdvancedExamResult] FOREIGN KEY([AdvancedExamResultD])
REFERENCES [dbo].[AdvancedExamResult] ([ID])
GO
ALTER TABLE [dbo].[AdvancedExamResultDetail] CHECK CONSTRAINT [FK_AdvancedExamResultDetail_AdvancedExamResult]
GO
/****** Object:  ForeignKey [FK_AdvancedExamResultDetail_Question]    Script Date: 09/08/2018 15:26:05 ******/
ALTER TABLE [dbo].[AdvancedExamResultDetail]  WITH CHECK ADD  CONSTRAINT [FK_AdvancedExamResultDetail_Question] FOREIGN KEY([QuesionID])
REFERENCES [dbo].[Question] ([ID])
GO
ALTER TABLE [dbo].[AdvancedExamResultDetail] CHECK CONSTRAINT [FK_AdvancedExamResultDetail_Question]
GO
/****** Object:  ForeignKey [FK_BasicExamResultDetail_Question]    Script Date: 09/08/2018 15:26:05 ******/
ALTER TABLE [dbo].[BasicExamResultDetail]  WITH CHECK ADD  CONSTRAINT [FK_BasicExamResultDetail_Question] FOREIGN KEY([QuesionID])
REFERENCES [dbo].[Question] ([ID])
GO
ALTER TABLE [dbo].[BasicExamResultDetail] CHECK CONSTRAINT [FK_BasicExamResultDetail_Question]
GO
/****** Object:  ForeignKey [FK_BasicExamResult_ExaminationQuestion]    Script Date: 09/08/2018 15:26:05 ******/
ALTER TABLE [dbo].[BasicExamResult]  WITH CHECK ADD  CONSTRAINT [FK_BasicExamResult_ExaminationQuestion] FOREIGN KEY([ExaminationQuestionID])
REFERENCES [dbo].[ExaminationQuestion] ([ID])
GO
ALTER TABLE [dbo].[BasicExamResult] CHECK CONSTRAINT [FK_BasicExamResult_ExaminationQuestion]
GO
/****** Object:  ForeignKey [FK_BasicExamResult_ExamPeriod]    Script Date: 09/08/2018 15:26:05 ******/
ALTER TABLE [dbo].[BasicExamResult]  WITH CHECK ADD  CONSTRAINT [FK_BasicExamResult_ExamPeriod] FOREIGN KEY([ExamPeriodID])
REFERENCES [dbo].[ExamPeriod] ([ID])
GO
ALTER TABLE [dbo].[BasicExamResult] CHECK CONSTRAINT [FK_BasicExamResult_ExamPeriod]
GO
/****** Object:  ForeignKey [FK_BasicExamResult_Registration]    Script Date: 09/08/2018 15:26:05 ******/
ALTER TABLE [dbo].[BasicExamResult]  WITH CHECK ADD  CONSTRAINT [FK_BasicExamResult_Registration] FOREIGN KEY([RegistrationID])
REFERENCES [dbo].[Registration] ([ID])
GO
ALTER TABLE [dbo].[BasicExamResult] CHECK CONSTRAINT [FK_BasicExamResult_Registration]
GO
