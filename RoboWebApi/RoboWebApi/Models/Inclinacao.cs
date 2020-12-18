using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoboWebApi.Models
{
    public class Inclinacao : Articulacao
    {
        public Cabeca Cabeca { get; set; }
        public Inclinacao(Cabeca cabeca)
            : base(DictionaryMovimentos.MovInclinacao)
        {
            Cabeca = cabeca;
        }

        public override int Movimento(int value)
        {
            return value;
        }
    }
}
