using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using RoboWebApi.Controllers;
using System.ComponentModel;
using RoboWebApi.Services;
using Microsoft.AspNetCore.Mvc;
using RoboWebApi.ViewModels;
using RoboWebApi.Models;
using RoboWebApi.Util;

namespace RoboWebApiTest.Tests
{
    public class RoboControllerTest
    {
        // O estado inicial dos movimentos é Em Repouso.
        // Só poderá movimentar o Pulso caso o Cotovelo esteja Fortemente Contraído.
        // Só poderá Rotacionar a Cabeça caso sua Inclinação da Cabeça não esteja em
        //estado Para Baixo.
        // Ao realizar a progressão de estados, é necessário que sempre siga a ordem
        //crescente ou decrescente, por exemplo, a partir do estado 4, pode-se ir para
        //os estados 3 ou 5, nunca pulando um estado.
        // Atenção aos limites! Se tentar enviar um estado inválido você irá corromper o
        //sistema do R.O.B.O.
        private RoboController _roboController;
        
        public RoboControllerTest()
        {
            _roboController = new RoboController(new RoboService());
        }

        [Fact]
        public void TestGetRobo()
        {
            Assert.NotNull(_roboController);
            var result = _roboController.Get();
            Assert.NotNull(result);
            Assert.IsType(result.GetType(), typeof(OkObjectResult));
            var robo = (result as OkObjectResult)?.Value;
            Assert.IsType(robo.GetType(), typeof(RoboViewModel));
        }

        [Fact]
        public void TestUpdatesRobo()
        {
            Assert.NotNull(_roboController);
            var result = _roboController.Get();
            Assert.IsType(result.GetType(), typeof(OkObjectResult));
            var robo = (result as OkObjectResult)?.Value;
            Assert.IsType(robo.GetType(), typeof(RoboViewModel));
            RoboViewModel roboViewModel = (RoboViewModel)robo;

            string movimento = "Para Baixo";

            roboViewModel.Cabeca.Inclinacao.Estado = Utils.ValueMovimento(DictionaryMovimentos.MovInclinacao, movimento);
            var resultUpdate = _roboController.Put(roboViewModel);
            Assert.NotNull(resultUpdate);
            Assert.IsType(resultUpdate.GetType(), typeof(OkObjectResult));

            RoboViewModel roboViewModelAtualizado = (_roboController.Get() as OkObjectResult)?.Value as RoboViewModel;

            Assert.Equal(movimento, roboViewModelAtualizado.Cabeca.Inclinacao.EstadoDescricao);
        }


        

    }
}
