namespace WFApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Member")]
    public partial class Member
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int? TeamId { get; set; }

        public virtual Team Team { get; set; }
    }
}
