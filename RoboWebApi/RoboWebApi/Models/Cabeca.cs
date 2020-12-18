using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoboWebApi.Models
{
    public class Cabeca
    {
        public Articulacao Rotacao { get; set; }
        public Articulacao Inclinacao { get; set; }

        public Cabeca()
        {
            Rotacao = new Rotacao(this);
            Inclinacao = new Inclinacao(this);
        }
    }
}
