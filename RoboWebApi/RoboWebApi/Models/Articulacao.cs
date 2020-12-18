using RoboWebApi.Exceptions;
using RoboWebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace RoboWebApi.Models
{
    public abstract class Articulacao
    {
        private int estado;
        
        public string EstadoDescricao { get; set; }

        public readonly Dictionary<int, string> _Movimentos;
        public int Estado { get => estado; set => estado = ValidacaoMovimento(value); }
        public Articulacao(Dictionary<int, string> movimentos)
        {
            _Movimentos = movimentos;
        }
        public void Movimentar(int estado)
        {
            this.EstadoDescricao = this._Movimentos[estado];
            this.Estado = estado;
        }
        private int MovimentoProgressivo(int value)
        {
            if(Estado + 1 == value || Estado - 1 == value)
            {
                return value;
            }
            else
            {
                throw new ApiException("a progressão de estados deve seguir a ordem crescente ou decrescente");
            }
        }
        private int ValidacaoMovimento(int value)
        {
            if(this.estado == 0 || this.estado == value)
            {
                return value;
            }

            if(value <= 0 || value > this._Movimentos.Count)
            {
                throw new ApiException("O estado é inválido");
            }
            return Movimento(value);
        }

        public abstract int Movimento(int value);
        
    }
}
