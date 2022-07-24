using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using NEXTURN.REPOSITORY.Interface;
using NEXTURN.REPOSITORY.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEXTURN.REPOSITORY
{
   public class TraineeRepository : ITraineeRepository
    {
        private readonly NexturnContext _context;
        

        public TraineeRepository(NexturnContext context)
        {
            _context = context;
        }


        //READ
        public   List<Trainee> GetTrainees()
        {
            return  _context.Trainees.ToList();
            
        }

        //CREATE
        public Trainee AddTrainees(Trainee cus)
        {
           
            var result = _context.Trainees.Add(cus);
                _context.SaveChanges();
            return result.Entity;
           
        }

        //DELETE
        public Trainee Delete(int TrnId)
        {
            var cus = _context.Trainees.Where(x => x.TrnId == TrnId).SingleOrDefault();
            var result = _context.Trainees.Remove(cus);
            _context.SaveChanges();
            return result.Entity;
        }

        //Edit
        public Trainee FindTrainee(int TrnId)
        {
            var cus = _context.Trainees.Where(x => x.TrnId == TrnId).SingleOrDefault();
            
            
            return cus;
        }

        public Trainee UpdateTrainee(Trainee trn)
        {
            var student = _context.Trainees.Where(s => s.TrnId == trn.TrnId).FirstOrDefault();
            _context.Trainees.Remove(student);
            var result = _context.Trainees.Update(trn);
          /*  student.DeptId = trn.DeptId;
            student.Name = trn.Name;
            student.Email = trn.Email;
            student.Mobile = trn.Mobile;
            student.DeptId = trn.DeptId;*/
            _context.SaveChanges();

            return null;
        }
    }
}
