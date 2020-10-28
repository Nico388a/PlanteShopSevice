using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Plante.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PlanteShopService.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class PlanteController : ControllerBase
    {
        private static List<PlanteModel> _planter = new List<PlanteModel>()
        {
            new PlanteModel(1, "Baley", "Blomst", 22, 4),
            new PlanteModel(2, "Viol", "Blomst", 5, 1),
            new PlanteModel(3, "Fikus", "plante", 22, 3)
        };


        public static List<PlanteModel> Planter
        {
            get { return _planter; }
        }

        // GET: api/<PlanteController>
        [HttpGet]
        public IEnumerable<PlanteModel> GetAllPlants()
        {
            return _planter;
        }

        // GET api/<PlanteController>/5
        [HttpGet]
        [Route("{id}")]
        public PlanteModel Get(int id)
        {
            return _planter.Find(i => i.PlantId == id);
        }

        // POST api/<PlanteController>
        [HttpPost]
        [Route("")]
        public void PostPlant([FromBody] PlanteModel value)
        {
            _planter.Add(value);
        }

        // PUT api/<PlanteController>/5
        [HttpPut]
        [Route("{id}")]
        public void PutPlant(int id, [FromBody] PlanteModel value)
        {
            PlanteModel plante = Get(id);
            if (plante != null)
            {
                plante.PlantId = value.PlantId;
                plante.PlantType= value.PlantType;
                plante.PlanteNavn = value.PlanteNavn;
                plante.Price= value.Price;
                plante.MaxHigh = value.MaxHigh;
            }
        }

        // DELETE api/<PlanteController>/5
        [HttpDelete]
        [Route("{id}")]
        public void DeletePlante(int id)
        {
            PlanteModel plante = Get(id);
            _planter.Remove(plante);
        }
    }
}
