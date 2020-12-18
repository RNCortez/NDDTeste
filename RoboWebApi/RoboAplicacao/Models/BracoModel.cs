using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoboAplicacao.Models
{
    public class BracoModel
    {
        public CotoveloModel Cotovelo { get; set; }
        public PulsoModel Pulso { get; set; }
        public BracoModel()
        {
            Cotovelo = new CotoveloModel();
            Pulso = new PulsoModel();
        }
    }
}
