using RoboWebApi.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoboWebApi.Models
{
    public class Pulso : Articulacao
    {
        public Braco Braco { get; set; }
        public Pulso(Braco braco)
            : base(DictionaryMovimentos.MovPulso)
        {
            Braco = braco;
        }

        public override int Movimento(int value)
        {
            if("Fortemente Contraído".Equals(Braco.Cotovelo.EstadoDescricao))
            {
                return value;
            }
            else
            {
                throw new ApiException("O cotovelo deve estar Fortemente Contraído para realizar o movimento do pulso");
            }
        }
    }
}
