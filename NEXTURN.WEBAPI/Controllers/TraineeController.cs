using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NEXTURN.BUSINESS.Interface;
using NEXTURN.MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NEXTURN.WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TraineeController : ControllerBase
    {

        private readonly ILogger<TraineeController> _logger;
        private readonly ITraineeBusiness _traineeBusiness;

        public TraineeController(ITraineeBusiness traineeBusiness)
        {
            _traineeBusiness = traineeBusiness;

        }

        [HttpGet]
        public IActionResult Display()
        {
            List<TraineeVM> cust = _traineeBusiness.GetTrainees();
            return Ok(cust);

        }

        

        [HttpPost]
        public IActionResult Create(TraineeVM cus)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var result = _traineeBusiness.AddTrainees(cus);
            return Ok(result);
        }

        [HttpDelete("{TrnId}")]
        public IActionResult Delete(int TrnId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
           var res = _traineeBusiness.Delete(TrnId);
            return Ok(res);
        }

    /*    [HttpGet("{TrnId}")]
        public IActionResult Edit(int TrnId)
        {
            var trn = _traineeBusiness.FindTrainee(TrnId);
            return Ok(trn);
        }*/
        [HttpPut]

        public IActionResult Edit(TraineeVM trn)
        {

           var res =  _traineeBusiness.UpdateTrainee(trn);
            return Ok(res) ;
        }
    }
}
