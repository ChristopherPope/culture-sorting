namespace ConsoleApp5
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ledger")]
    public partial class Ledger
    {
        public int LedgerId { get; set; }

        public int BillCompanyId { get; set; }

        [Column(TypeName = "money")]
        public decimal Amount { get; set; }

        [Column(TypeName = "date")]
        public DateTime DatePaid { get; set; }

        public virtual BillCompany BillCompany { get; set; }
    }
}
