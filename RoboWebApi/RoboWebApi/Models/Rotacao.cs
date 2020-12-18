using RoboWebApi.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoboWebApi.Models
{
    public class Rotacao : Articulacao
    {
        public Cabeca Cabeca { get; set; }
        public Rotacao(Cabeca cabeca)
            : base(DictionaryMovimentos.MovRotacao)
        {
            Cabeca = cabeca;
        }

        public override int Movimento(int value)
        {
            if (!"Para Baixo".Equals(Cabeca.Inclinacao.EstadoDescricao))
            {
                return value;
            }
            else
            {
                throw new ApiException("O rotação não pode ser realizada enquanto a inclinação estiver Para baixo");
            }
        }
    }
}
