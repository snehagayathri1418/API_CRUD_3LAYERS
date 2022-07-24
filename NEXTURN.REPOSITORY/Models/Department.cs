using System;
using System.Collections.Generic;

#nullable disable

namespace NEXTURN.REPOSITORY.Models
{
    public partial class Department
    {
        public Department()
        {
            Trainees = new HashSet<Trainee>();
        }

        public int DeptId { get; set; }
        public string DeptName { get; set; }

        public virtual ICollection<Trainee> Trainees { get; set; }
    }
}
