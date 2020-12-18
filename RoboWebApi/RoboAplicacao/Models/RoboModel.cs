using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RoboAplicacao.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoboAplicacao.Models
{
    public class RoboModel
    {
        private string apiController = "Robo";
        public CabecaModel Cabeca { get; set; }
        public BracoModel BracoEsquerdo { get; set; }
        public BracoModel BracoDireito { get; set; }

        public RoboModel()
        {
            Cabeca = new CabecaModel();
            BracoEsquerdo = new BracoModel();
            BracoDireito = new BracoModel();
        }

        public RoboModel Get()
        {
            string json = WebApi.RequestGET(string.Concat(apiController, "/getrobo"), string.Empty);

            return JsonConvert.DeserializeObject<RoboModel>(json);
        }

        public void Put()
        {
            string json = WebApi.RequestPUT(string.Concat(apiController, "/atualizarrobo"),
                JsonConvert.SerializeObject(this));
        }
    }
}
