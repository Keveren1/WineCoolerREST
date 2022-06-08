using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WineCoolerLib;
using RestWineCooler.Managers;
using System;
using System.Linq;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;

namespace RestWineCooler.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class WineCoolersController : Controller
    {
        private WineCoolersManager _manager = new WineCoolersManager();

        [EnableCors(Startup.AllowAllCorsPolicy)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [HttpGet]
        public ActionResult<IEnumerable<Cooler>> GetAllCoolers()
        {
            IEnumerable<Cooler> coolers = _manager.GetAll();
            if (coolers.Count() == null)
            {
                return NoContent();
            }
            else
            {
                return Ok(coolers);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpGet("{id}")]
        public ActionResult GetCooler(int id)
        {
            Cooler cooler = _manager.GetById(id);
            if (cooler == null) return NotFound("Id not found");
            else
            {
                return Ok(cooler);
            }
        }

        [HttpPost]
        public Cooler AddCooler([FromBody] Cooler cooler)
        {
            return _manager.AddNewCooler(cooler);
        }

        [HttpDelete("{id}")]
        public Cooler Delete(int id)
        {
            Cooler cooler = _manager.GetById(id);
            return _manager.DeleteCooler(id);
        }


    }
}
