using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoboWebApi.ViewModels
{
    public class BracoViewModel
    {
        public CotoveloViewModel Cotovelo { get; set; }
        public PulsoViewModel Pulso { get; set; }
        public BracoViewModel()
        {
            Cotovelo = new CotoveloViewModel();
            Pulso = new PulsoViewModel();
        }
    }
}
