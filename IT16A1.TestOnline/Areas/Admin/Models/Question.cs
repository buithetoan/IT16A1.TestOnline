namespace IT16A1.TestOnline.Areas.Admin.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Question")]
    public partial class Question
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Question()
        {
            AdvancedExamResultDetails = new HashSet<AdvancedExamResultDetail>();
            BasicExamResultDetails = new HashSet<BasicExamResultDetail>();
            ExaminationQuestions = new HashSet<ExaminationQuestion>();
        }

        public Guid ID { get; set; }

        public Guid? QuestionModuleID { get; set; }

        public Guid? QuestionClassificationID { get; set; }

        public string QuestionContent { get; set; }

        [StringLength(100)]
        public string AAnswer { get; set; }

        [StringLength(100)]
        public string BAnswer { get; set; }

        [StringLength(100)]
        public string CAnswer { get; set; }

        [StringLength(100)]
        public string DAnswer { get; set; }

        [StringLength(5)]
        public string Answer { get; set; }

        [StringLength(100)]
        public string ResultAswer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AdvancedExamResultDetail> AdvancedExamResultDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BasicExamResultDetail> BasicExamResultDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExaminationQuestion> ExaminationQuestions { get; set; }

        public virtual QuestionClassification QuestionClassification { get; set; }

        public virtual QuestionModule QuestionModule { get; set; }
    }
}
