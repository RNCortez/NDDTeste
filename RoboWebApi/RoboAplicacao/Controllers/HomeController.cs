using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoboAplicacao.Models;

namespace RoboAplicacao.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            try
            {
                ViewBag.robo = new RoboModel().Get();
            }
            catch(Exception ex)
            {
                ViewBag.Exception = ex.Message;
            }

            return View();
        }
        [HttpPost]
        public IActionResult Index(IFormCollection form)
        {
            try
            {
                RoboModel robo = new RoboModel();
                robo.Cabeca.Inclinacao.Estado = ValueIntForm(form, "inclinacao");
                robo.Cabeca.Rotacao.Estado = ValueIntForm(form, "rotacao"); ;
                robo.BracoDireito.Cotovelo.Estado = ValueIntForm(form, "cotovelo_dir"); ;
                robo.BracoEsquerdo.Cotovelo.Estado = ValueIntForm(form, "cotovelo_esq"); ;
                robo.BracoDireito.Pulso.Estado = ValueIntForm(form, "pulso_dir"); ;
                robo.BracoEsquerdo.Pulso.Estado = ValueIntForm(form, "pulso_esq"); ;
                robo.Put();
                
                ViewBag.robo = new RoboModel().Get();

                ViewBag.Message = "Robo Atualizado";
            }
            catch (Exception ex)
            {
                ViewBag.Exception = "Não foi possivel atualizar o Robo";

                ViewBag.robo = new RoboModel().Get();
            }
            return View();
        }

        public int ValueIntForm(IFormCollection form, string key)
        {
            int valorInt = -1;
            try
            {
                valorInt = Convert.ToInt32(form[key].ToString().Trim());

            }
            catch (Exception) { }

            return valorInt;
        }

        public string ValueStringForm(IFormCollection form, string key)
        {
            string valorString = string.Empty;
            try
            {
                valorString = form[key].ToString().Trim();
            }
            catch (Exception) { }

            return valorString;
        }
    }
}
