namespace ConsoleApp5
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OtherBill")]
    public partial class OtherBill
    {
        public int OtherBillId { get; set; }

        [Required]
        [StringLength(50)]
        public string Payee { get; set; }

        [StringLength(50)]
        public string For { get; set; }

        [Column(TypeName = "money")]
        public decimal Amount { get; set; }

        [StringLength(50)]
        public string AccountNumber { get; set; }
    }
}
