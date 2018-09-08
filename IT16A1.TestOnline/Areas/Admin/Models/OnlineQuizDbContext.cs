namespace IT16A1.TestOnline.Areas.Admin.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class OnlineQuizDbContext : DbContext
    {
        public OnlineQuizDbContext()
            : base("name=OnlineQuizDbContext")
        {
        }

        public virtual DbSet<AdvancedExamResult> AdvancedExamResults { get; set; }
        public virtual DbSet<AdvancedExamResultDetail> AdvancedExamResultDetails { get; set; }
        public virtual DbSet<AdvancedModuleRegistration> AdvancedModuleRegistrations { get; set; }
        public virtual DbSet<BasicExamResult> BasicExamResults { get; set; }
        public virtual DbSet<BasicExamResultDetail> BasicExamResultDetails { get; set; }
        public virtual DbSet<Examination> Examinations { get; set; }
        public virtual DbSet<ExaminationModule> ExaminationModules { get; set; }
        public virtual DbSet<ExaminationQuestion> ExaminationQuestions { get; set; }
        public virtual DbSet<Examinee> Examinees { get; set; }
        public virtual DbSet<ExamPeriod> ExamPeriods { get; set; }
        public virtual DbSet<Faculty> Faculties { get; set; }
        public virtual DbSet<InformationTechnologySkill> InformationTechnologySkills { get; set; }
        public virtual DbSet<LocationExam> LocationExams { get; set; }
        public virtual DbSet<MajorClass> MajorClasses { get; set; }
        public virtual DbSet<Manager> Managers { get; set; }
        public virtual DbSet<Note> Notes { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<QuestionClassification> QuestionClassifications { get; set; }
        public virtual DbSet<QuestionModule> QuestionModules { get; set; }
        public virtual DbSet<Registration> Registrations { get; set; }
        public virtual DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdvancedExamResult>()
                .HasMany(e => e.AdvancedExamResultDetails)
                .WithOptional(e => e.AdvancedExamResult)
                .HasForeignKey(e => e.AdvancedExamResultD);

            modelBuilder.Entity<AdvancedExamResultDetail>()
                .Property(e => e.Answer)
                .IsUnicode(false);

            modelBuilder.Entity<BasicExamResultDetail>()
                .Property(e => e.Answer)
                .IsUnicode(false);

            modelBuilder.Entity<Examination>()
                .HasMany(e => e.ExaminationModules)
                .WithRequired(e => e.Examination)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ExaminationQuestion>()
                .Property(e => e.Answer)
                .IsUnicode(false);

            modelBuilder.Entity<Examinee>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Examinee>()
                .Property(e => e.IdentityCard)
                .IsUnicode(false);

            modelBuilder.Entity<Examinee>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<Examinee>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Examinee>()
                .Property(e => e.Note)
                .IsUnicode(false);

            modelBuilder.Entity<ExamPeriod>()
                .Property(e => e.StartEndTime)
                .IsUnicode(false);

            modelBuilder.Entity<MajorClass>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<MajorClass>()
                .Property(e => e.Course)
                .IsUnicode(false);

            modelBuilder.Entity<Manager>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<Manager>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Manager>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<Manager>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Manager>()
                .Property(e => e.Role)
                .IsUnicode(false);

            modelBuilder.Entity<Question>()
                .Property(e => e.Answer)
                .IsUnicode(false);

            modelBuilder.Entity<Question>()
                .HasMany(e => e.AdvancedExamResultDetails)
                .WithOptional(e => e.Question)
                .HasForeignKey(e => e.QuesionID);

            modelBuilder.Entity<Question>()
                .HasMany(e => e.BasicExamResultDetails)
                .WithOptional(e => e.Question)
                .HasForeignKey(e => e.QuesionID);

            modelBuilder.Entity<Question>()
                .HasMany(e => e.ExaminationQuestions)
                .WithOptional(e => e.Question)
                .HasForeignKey(e => e.QuesitionID);

            modelBuilder.Entity<QuestionModule>()
                .HasMany(e => e.ExaminationModules)
                .WithRequired(e => e.QuestionModule)
                .WillCascadeOnDelete(false);
        }
    }
}
