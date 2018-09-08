namespace IT16A1.TestOnline.Areas.Admin.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ExamPeriod")]
    public partial class ExamPeriod
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ExamPeriod()
        {
            AdvancedExamResults = new HashSet<AdvancedExamResult>();
            BasicExamResults = new HashSet<BasicExamResult>();
        }

        public Guid ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ExaminationDate { get; set; }

        [StringLength(20)]
        public string StartEndTime { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AdvancedExamResult> AdvancedExamResults { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BasicExamResult> BasicExamResults { get; set; }
    }
}
