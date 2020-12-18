using Microsoft.VisualBasic.CompilerServices;
using RoboWebApi.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Utils = RoboWebApi.Util.Utils;

namespace RoboWebApi.Models
{
    public class Robo
    {
        
        public Cabeca Cabeca { get; set; }
        public Braco BracoEsquerdo { get; set; }
        public Braco BracoDireito { get; set; }

        public Robo()
        {
            Cabeca = new Cabeca();
            BracoEsquerdo = new Braco();
            BracoDireito = new Braco();
        }

        public void EstadoInicialRobo()
        {
            Cabeca.Inclinacao.Movimentar(Utils.ValueRepouso(Cabeca.Inclinacao._Movimentos));
            Cabeca.Rotacao.Movimentar(Utils.ValueRepouso(Cabeca.Rotacao._Movimentos));

            BracoEsquerdo.Pulso.Movimentar(Utils.ValueRepouso(BracoEsquerdo.Pulso._Movimentos));
            BracoEsquerdo.Cotovelo.Movimentar(Utils.ValueRepouso(BracoEsquerdo.Cotovelo._Movimentos));

            BracoDireito.Pulso.Movimentar(Utils.ValueRepouso(BracoDireito.Pulso._Movimentos));
            BracoDireito.Cotovelo.Movimentar(Utils.ValueRepouso(BracoDireito.Cotovelo._Movimentos));
        }

    }
}
