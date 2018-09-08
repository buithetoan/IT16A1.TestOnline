namespace IT16A1.TestOnline.Areas.Admin.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Examinee")]
    public partial class Examinee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Examinee()
        {
            Students = new HashSet<Student>();
        }

        public Guid ID { get; set; }

        [StringLength(200)]
        public string Password { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(100)]
        public string FullName { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Birthday { get; set; }

        public bool? Gender { get; set; }

        [StringLength(15)]
        public string IdentityCard { get; set; }

        [StringLength(15)]
        public string Mobile { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [Column(TypeName = "text")]
        public string Note { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student> Students { get; set; }
    }
}
