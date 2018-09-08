namespace IT16A1.TestOnline.Areas.Admin.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ExaminationQuestion")]
    public partial class ExaminationQuestion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ExaminationQuestion()
        {
            BasicExamResults = new HashSet<BasicExamResult>();
        }

        public Guid ID { get; set; }

        public Guid? ExaminationID { get; set; }

        public int? ExamCode { get; set; }

        public Guid? QuesitionID { get; set; }

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
        public virtual ICollection<BasicExamResult> BasicExamResults { get; set; }

        public virtual Examination Examination { get; set; }

        public virtual Question Question { get; set; }
    }
}
