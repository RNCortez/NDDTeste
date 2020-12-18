using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoboWebApi.Interfaces
{
    public interface IEstado
    {
        int Estado { get; set; }
        string Descricao { get; set; }
    }
}
