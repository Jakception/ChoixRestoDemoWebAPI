using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChoixRestoDemoWebAPI.Models
{
    public class Resto
    {
        public int Id { get; set; }
        public string Nom { get; set; }
    }

    public class Restos
    {
        public List<Resto> ChargerRestaurants()
        {
            return new List<Resto>
            {
                new Resto { Id = 1, Nom = "Resto pinière"},
                new Resto { Id = 2, Nom = "Resto pinambour"},
                new Resto { Id = 3, Nom = "Resto ride"},
            };
        }
    }
}