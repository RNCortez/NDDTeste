using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Session;
using Microsoft.Extensions.Caching.Memory;
using RoboWebApi.Exceptions;
using RoboWebApi.Interfaces;
using RoboWebApi.Models;
using RoboWebApi.Services;
using RoboWebApi.Util;
using RoboWebApi.ViewModels;

namespace RoboWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoboController : ControllerBase
    {
        private readonly IRoboService _roboService;
        private Robo Robo { get; set; }
        
        public RoboController(IRoboService roboService)
        {
            _roboService = roboService;
        }

        [HttpGet]
        [Route("getrobo")]
        public IActionResult Get()
        {
            try
            {
                _roboService.GetRobo();
                RoboViewModel roboViewModel = _roboService.EntityToViewModel();
                return Ok(roboViewModel);
            }
            catch (Exception exception)
            {
                return BadRequest(new ApiException(exception.Message));
            }
        }

        [HttpPut]
        [Route("atualizarrobo")]
        public IActionResult Put([FromBody]RoboViewModel roboViewModel)
        {
            try
            {
                _roboService.UpdateRobo(roboViewModel);
                RoboViewModel roboViewModelAlterado = _roboService.EntityToViewModel();

                return Ok(roboViewModelAlterado);
            }
            catch (Exception exception)
            {
                return BadRequest(new ApiException(exception.Message));
            }
        }

    }
}
