using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoboAplicacao.Models
{
    public class CabecaModel
    {
        public RotacaoModel Rotacao { get; set; }
        public InclinacaoModel Inclinacao { get; set; }

        public CabecaModel()
        {
            Rotacao = new RotacaoModel();
            Inclinacao = new InclinacaoModel();
        }
    }
}
