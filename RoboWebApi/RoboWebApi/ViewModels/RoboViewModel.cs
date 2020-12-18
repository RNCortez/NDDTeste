using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoboWebApi.ViewModels
{
    public class RoboViewModel
    {
        public CabecaViewModel Cabeca { get; set; }
        public BracoViewModel BracoEsquerdo { get; set; }
        public BracoViewModel BracoDireito { get; set; }

        public RoboViewModel()
        {
            Cabeca = new CabecaViewModel();
            BracoEsquerdo = new BracoViewModel();
            BracoDireito = new BracoViewModel();
        }
    }
}
