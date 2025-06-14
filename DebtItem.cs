namespace ConsoleApp5
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DebtItem
    {
        public int DebtItemId { get; set; }

        [Required]
        [StringLength(50)]
        public string Payee { get; set; }

        [StringLength(50)]
        public string URL { get; set; }

        [Column(TypeName = "money")]
        public decimal Amount { get; set; }
    }
}
