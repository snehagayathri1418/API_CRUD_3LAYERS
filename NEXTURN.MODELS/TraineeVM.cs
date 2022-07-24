using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEXTURN.MODELS
{
   public class TraineeVM
    {
        public int TrnId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public int? DeptId { get; set; }
    }
}
