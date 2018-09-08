namespace IT16A1.TestOnline.Areas.Admin.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AdvancedModuleRegistration")]
    public partial class AdvancedModuleRegistration
    {
        public Guid ID { get; set; }

        public Guid? RegistrationID { get; set; }

        public Guid? QuestionModuleID { get; set; }

        public virtual QuestionModule QuestionModule { get; set; }

        public virtual Registration Registration { get; set; }
    }
}
