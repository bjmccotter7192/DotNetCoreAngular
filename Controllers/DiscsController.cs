using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreAngular.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreAngular.Controllers
{
    [Route("api/[controller]")]
    public class DiscsController : Controller
    {
        private DiscsRepo _discRepo;
        public DiscsController()
        {
            _discRepo = new DiscsRepo();
        }

        [HttpGet("[action]")]
        public IEnumerable<Disc> GetAllDiscs()
        {
            try
            {
                return _discRepo.GetAllDiscs();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}