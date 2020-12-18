using RoboWebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoboWebApi.Models
{
    public class Cotovelo : Articulacao
    {
        public Braco Braco { get; set; }
        public Cotovelo(Braco braco)
            : base(DictionaryMovimentos.MovCotovelo)
        {
            Braco = braco;
        }

        public override int Movimento(int value)
        {
            return value;
        }
    }
}
