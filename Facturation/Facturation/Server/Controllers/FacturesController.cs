using Facturation.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Facturation.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FacturesController : ControllerBase
    {
        private readonly ILogger<FacturesController> _logger;
        private readonly IBusinessData _data;

        public FacturesController(ILogger<FacturesController> logger, IBusinessData data)
        {
            _logger = logger;
            _data = data;
        }

        [HttpGet]
        public IEnumerable<Facture> Get()
            => _data.Factures;

        [HttpGet("{numero}")]
        public ActionResult<Facture> Get(string numero)
        {
            var facture = _data.Factures.Where(f => f.Numero == numero).FirstOrDefault();

            if(facture == null)
            {
                return NotFound("Aucune facture avec ce numero");
            }
            else
            {
                return facture;
            }
        }

        [HttpGet("{element}/{asc}")]
        public ActionResult<IEnumerable<Facture>> Get(string element, string asc)
        {
            if(element.MatchesFactureElement() && asc.MatchesSortOrder())
                return Ok(_data.GetFactures(element, asc));
            else
                return NotFound("Les entrées ne sont pas correctes.");
        }

        [HttpPost]
        public ActionResult<Facture> CreateFacture([FromBody] Facture nouvelleFacture)
        {
            if(ModelState.IsValid)
            {
                _data.Add(nouvelleFacture);
                return nouvelleFacture;
            }
            else
            {
                return BadRequest("Facture non valide");
            }
        }
        [HttpPost("edit")]
        public ActionResult<Facture> EditerFacture([FromBody] Facture nouvelleFacture)
        {
            if (ModelState.IsValid)
            {
                _data.Edit(nouvelleFacture);
                return nouvelleFacture;
            }
            else
            {
                return BadRequest("Facture non valide");
            }
        }
    }
}
