namespace ConsoleApp5
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BillCompany")]
    public partial class BillCompany
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BillCompany()
        {
            Bills = new HashSet<Bill>();
            Ledgers = new HashSet<Ledger>();
        }

        public int BillCompanyId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public bool IsAuto { get; set; }

        public int RecurringId { get; set; }

        public bool IsAmountDueConstant { get; set; }

        public int PaydayId { get; set; }

        [StringLength(50)]
        public string Url { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bill> Bills { get; set; }

        public virtual BillCompany BillCompany1 { get; set; }

        public virtual BillCompany BillCompany2 { get; set; }

        public virtual Payday Payday { get; set; }

        public virtual Recurring Recurring { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ledger> Ledgers { get; set; }
    }
}
