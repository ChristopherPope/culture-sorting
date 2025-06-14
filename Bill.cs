namespace ConsoleApp5
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Bill")]
    public partial class Bill
    {
        public int BillId { get; set; }

        public int BillCompanyId { get; set; }

        [Column(TypeName = "money")]
        public decimal AmountDue { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateDue { get; set; }

        public virtual BillCompany BillCompany { get; set; }
    }
}
