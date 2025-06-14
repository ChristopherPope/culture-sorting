namespace ConsoleApp5
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UserSetting
    {
        [Key]
        public int UserSettingsId { get; set; }

        public int PaydayId { get; set; }

        public virtual Payday Payday { get; set; }
    }
}
