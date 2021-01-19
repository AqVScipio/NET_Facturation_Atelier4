using Facturation.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Facturation.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardController : ControllerBase
    {
        private readonly IBusinessData _data;

        public DashboardController(IBusinessData data)
        {
            _data = data;
        }

        [HttpGet]
        public DashboardDto GetDashboard() => 
            new DashboardDto(_data);

        [HttpPost]
        public ActionResult<DashboardDto> GetDashboard([FromBody] DashboardResearch research)
        {
            if (ModelState.IsValid)
            {
                return new DashboardDto(_data.GetFactures(research.DateMin, research.DateMax));
            }
            else
            {
                return BadRequest("Facture non valide");
            }
        }
    }
}
