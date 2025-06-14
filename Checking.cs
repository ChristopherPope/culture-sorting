namespace ConsoleApp5
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Checking")]
    public partial class Checking
    {
        [Column(TypeName = "money")]
        public decimal Balance { get; set; }

        public int CheckingId { get; set; }
    }
}
