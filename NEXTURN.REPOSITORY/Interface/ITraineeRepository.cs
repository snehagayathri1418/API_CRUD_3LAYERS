using NEXTURN.REPOSITORY.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEXTURN.REPOSITORY.Interface
{
    public interface ITraineeRepository
    {
       List<Trainee> GetTrainees();

        Trainee AddTrainees(Trainee cus);

        Trainee Delete(int TrnId);

        Trainee FindTrainee(int TrnId);

        Trainee UpdateTrainee(Trainee trn);
    }
}
