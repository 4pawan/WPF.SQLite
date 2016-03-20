namespace WPF.SQLite.EF.PerfectSmile
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Patient")]
    public partial class Patient
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Patient()
        {
            PatientHistories = new HashSet<PatientHistory>();
        }

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int? Phone { get; set; }

        public string Remark { get; set; }

        public string CreatedBy { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CreatedAt { get; set; }

        public string ModifiedBy { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ModifiedAt { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PatientHistory> PatientHistories { get; set; }
    }
}
