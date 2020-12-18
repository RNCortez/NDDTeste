using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoboWebApi.Models
{
    public class Braco
    {
        public Articulacao Cotovelo { get; set; }
        public Articulacao Pulso { get; set; }
        
        public Braco()
        {
            Cotovelo = new Cotovelo(this);
            Pulso = new Pulso(this);
        }
    }
}
