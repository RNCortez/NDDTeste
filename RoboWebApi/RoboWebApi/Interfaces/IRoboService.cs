using RoboWebApi.Models;
using RoboWebApi.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoboWebApi.Interfaces
{
    public interface IRoboService
    {
        Robo GetRobo();
        void UpdateRobo(RoboViewModel robo);
        RoboViewModel EntityToViewModel();
    }
}
