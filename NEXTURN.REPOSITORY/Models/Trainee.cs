using System;
using System.Collections.Generic;

#nullable disable

namespace NEXTURN.REPOSITORY.Models
{
    public partial class Trainee
    {
        public int TrnId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public int? DeptId { get; set; }

        public virtual Department Dept { get; set; }
    }
}
