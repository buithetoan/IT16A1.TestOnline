namespace IT16A1.TestOnline.Areas.Admin.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BasicExamResult")]
    public partial class BasicExamResult
    {
        public Guid ID { get; set; }

        public Guid? ExamPeriodID { get; set; }

        public Guid? RegistrationID { get; set; }

        public Guid? ExaminationQuestionID { get; set; }

        public int? ExamCode { get; set; }

        public int? Duration { get; set; }

        public int? TrueQuestion { get; set; }

        public double? Point { get; set; }

        public virtual ExaminationQuestion ExaminationQuestion { get; set; }

        public virtual ExamPeriod ExamPeriod { get; set; }

        public virtual Registration Registration { get; set; }
    }
}
