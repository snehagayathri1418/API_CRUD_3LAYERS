using NEXTURN.MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEXTURN.BUSINESS.Interface
{
    public interface ITraineeBusiness
    {

        List<TraineeVM> GetTrainees();
        TraineeVM AddTrainees(TraineeVM cus);

        TraineeVM Delete(int TrnId);

        TraineeVM FindTrainee(int TrnId);

        TraineeVM UpdateTrainee(TraineeVM trn);
    }
}
