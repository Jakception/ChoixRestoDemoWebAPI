using ChoixRestoDemoWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ChoixRestoDemoWebAPI.Controllers
{
    public class RestaurantController : ApiController
    {
        public IEnumerable<Resto> GetTousLesRestos()
        {
            return new Restos().ChargerRestaurants();
        }

        public IHttpActionResult GetResto(int id)
        {
            Resto resto = new Restos().ChargerRestaurants().FirstOrDefault(r => r.Id == id);
            if (resto == null)
            {
                return NotFound();
            }
            return Ok(resto);
        }

        [HttpGet]
        public IHttpActionResult TrouveResto(int id)
        {
            Resto resto = new Restos().ChargerRestaurants().FirstOrDefault(r => r.Id == id);
            if (resto == null)
            {
                return NotFound();
            }
            return Ok(resto);
        }
    }
}
