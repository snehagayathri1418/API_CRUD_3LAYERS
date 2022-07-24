using AutoMapper;
using NEXTURN.BUSINESS.Interface;
using NEXTURN.MODELS;
using NEXTURN.REPOSITORY;
using NEXTURN.REPOSITORY.Interface;
using NEXTURN.REPOSITORY.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEXTURN.BUSINESS
{
    public class TraineeBusiness : ITraineeBusiness
    {
        private readonly ITraineeRepository _traineeRepository;

        private readonly IMapper _mapper;
        public TraineeBusiness (ITraineeRepository repository, IMapper mapper)
        {
            _traineeRepository = repository;
            _mapper = mapper;
        }

        public   List<TraineeVM> GetTrainees()
        {
            List<Trainee> list =   _traineeRepository.GetTrainees();
            return _mapper.Map<List<TraineeVM>>(list);

        }

        public TraineeVM AddTrainees(TraineeVM cus)
        {
            var result = _traineeRepository.AddTrainees(_mapper.Map<Trainee>(cus));
            return _mapper.Map<TraineeVM>(result);
            
        }

        public TraineeVM Delete(int TrnId)
        {
            var result = _traineeRepository.Delete(TrnId);
            return _mapper.Map<TraineeVM>(result);
        }

        

        public TraineeVM FindTrainee(int TrnId)
        {
            var result = _traineeRepository.FindTrainee(TrnId);
            return _mapper.Map<TraineeVM>(result);
        }

        public TraineeVM UpdateTrainee(TraineeVM trn)
        {
            var result = _traineeRepository.UpdateTrainee(_mapper.Map<Trainee>(trn));
            return _mapper.Map<TraineeVM>(result);

        }

    }
}
