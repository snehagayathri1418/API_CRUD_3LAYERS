using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NEXTURN.BUSINESS;
using NEXTURN.BUSINESS.Interface;
using NEXTURN.MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NEXTURN.MVC.Controllers
{
    public class TraineeController : Controller
    {
        private readonly ILogger<TraineeController> _logger;
        private readonly ITraineeBusiness _traineeBusiness;

        public TraineeController(ITraineeBusiness traineeBusiness )
        {
            _traineeBusiness = traineeBusiness;
           
        }

        public IActionResult Success()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
        //Read
        public IActionResult Display()
        {
            List<TraineeVM> cust =  _traineeBusiness.GetTrainees();
            return View(cust);
  
        }

        //Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
           /* List<DepartmentVM> items = _traineeBusiness.DepartmentVMs.ToList();
            ViewBag.data = items;*/
        }

        [HttpPost]
        public IActionResult Create(TraineeVM cus)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var result = _traineeBusiness.AddTrainees(cus);
            return View(result);
        }

        //Delete

        public IActionResult Delete(int TrnId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            _traineeBusiness.Delete(TrnId);
            return RedirectToAction("GetAllCars");
        }

        //Edit
        [HttpGet]
        public IActionResult Edit(int TrnId)
        {
            var trn = _traineeBusiness.FindTrainee(TrnId);
            return View(trn);
        }
        [HttpPost]

        public IActionResult Edit(TraineeVM trn)
        {

              _traineeBusiness.UpdateTrainee(trn);
            return RedirectToAction("Display");
        }
    }

}
