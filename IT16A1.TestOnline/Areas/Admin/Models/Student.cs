namespace IT16A1.TestOnline.Areas.Admin.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Student")]
    public partial class Student
    {
        public Guid ID { get; set; }

        public Guid? IDStudent { get; set; }

        public Guid? ExamineeID { get; set; }

        public Guid? MajorClassID { get; set; }

        public virtual Examinee Examinee { get; set; }

        public virtual MajorClass MajorClass { get; set; }
    }
}
