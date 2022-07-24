using AutoMapper;
using NEXTURN.REPOSITORY.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NEXTURN.MODELS;

namespace NEXTURN.UTILITIES
{
    public class AutoMappingConfig : Profile
    {
        public AutoMappingConfig()
        {
            CreateMap<Trainee, TraineeVM>().ReverseMap();
            CreateMap<Department, DepartmentVM>().ReverseMap();
        }

    }
}
