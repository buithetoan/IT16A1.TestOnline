namespace IT16A1.TestOnline.Areas.Admin.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LocationExam")]
    public partial class LocationExam
    {
        public Guid ID { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public bool? State { get; set; }
    }
}
