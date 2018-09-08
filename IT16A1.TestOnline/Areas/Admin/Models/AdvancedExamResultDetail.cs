namespace IT16A1.TestOnline.Areas.Admin.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AdvancedExamResultDetail")]
    public partial class AdvancedExamResultDetail
    {
        public Guid ID { get; set; }

        public Guid? AdvancedExamResultD { get; set; }

        public Guid? QuesionID { get; set; }

        [StringLength(5)]
        public string Answer { get; set; }

        [StringLength(100)]
        public string ResultAswer { get; set; }

        public virtual AdvancedExamResult AdvancedExamResult { get; set; }

        public virtual Question Question { get; set; }
    }
}
