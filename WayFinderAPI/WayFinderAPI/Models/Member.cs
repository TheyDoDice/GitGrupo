using System;
using System.Collections.Generic;

namespace WayFinderAPI.Models
{
    public partial class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? TeamId { get; set; }

        public virtual Team Team { get; set; }
    }
}
