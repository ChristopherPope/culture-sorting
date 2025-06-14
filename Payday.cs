namespace ConsoleApp5
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Payday")]
    public partial class Payday
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Payday()
        {
            BillCompanies = new HashSet<BillCompany>();
            UserSettings = new HashSet<UserSetting>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PaydayId { get; set; }

        [Column("Payday")]
        public int Payday1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillCompany> BillCompanies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserSetting> UserSettings { get; set; }
    }
}
