using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoboWebApi.ViewModels
{
    public class CabecaViewModel
    {
        public RotacaoViewModel Rotacao { get; set; }
        public InclinacaoViewModel Inclinacao { get; set; }

        public CabecaViewModel()
        {
            Rotacao = new RotacaoViewModel();
            Inclinacao = new InclinacaoViewModel();
        }
    }
}
