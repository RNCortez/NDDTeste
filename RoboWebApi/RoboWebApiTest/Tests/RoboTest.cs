//using Microsoft.VisualBasic.CompilerServices;
//using RoboWebApi.Models;
//using System;
//using System.Collections.Generic;
//using System.Text;
//using Xunit;
//using RoboWebApi.Util;
//using Utils = RoboWebApi.Util.Utils;

//namespace RoboWebApiTest.Tests
//{
//    public class RoboTest
//    {

//        private Robo _robo;

//        [Fact]
//        public void Inicializar()
//        {
//            _robo = new Robo();
//        }

//        /// <summary>
//        /// Só poderá movimentar o Pulso caso o Cotovelo esteja Fortemente Contraído.
//        /// </summary>
//        [Fact]
//        //[ExpectedException(typeof(exce), "Movimento de pulso não apropriado seria permitido")]
//        public void TestCotoveloFortementeContraido()
//        {
//            Assert.Equal(DictionaryMovimentos.MovCotovelo[1], _robo.BracoDireito.Cotovelo.EstadoDescricao);

//            // Cotovelo está diferente de Fortemente Contraído
//            Assert.NotEqual(DictionaryMovimentos.MovCotovelo[4], _robo.BracoDireito.Cotovelo.EstadoDescricao);

//            _robo.BracoDireito.Pulso.Estado = Utils.ValueMovimento(DictionaryMovimentos.MovPulso, "Rotação em -90º");
//        }

//        /// <summary>
//        /// Só poderá movimentar o Pulso caso o Cotovelo esteja Fortemente Contraído.
//        /// </summary>
//        [Fact]
//        public void TestRoboMovimentarPulsoAlteraQuandoCotoveloFortementeContraido()
//        {
//            Assert.Equal(Utils.ValueMovimento(DictionaryMovimentos.MovCotovelo, "Em Repouso"), _robo.BracoDireito.Cotovelo.Estado);

//            // Cotovelo deve ficar Fortemente Contraído
//            _robo.BracoDireito.Cotovelo = EnumCotovelo.LevementeContraido;
//            _robo.BracoDireito.Cotovelo = EnumCotovelo.Contraido;
//            _robo.BracoDireito.Cotovelo = EnumCotovelo.FortementeContraido;
//            Assert.AreEqual(EnumCotovelo.FortementeContraido, _robo.BracoDireito.Cotovelo);

//            // vai para o '2' devido restrição de progressão
//            _robo.BracoDireito.Pulso = EnumPulso.RotacaoMenos45;

//            Assert.AreEqual(EnumPulso.RotacaoMenos45, _robo.BracoDireito.Pulso);
//        }

//        /// <summary>
//        /// Só poderá Rotacionar a Cabeça caso sua Inclinação da Cabeça não esteja em estado Para Baixo
//        /// </summary>
//        [TestMethod]
//        [ExpectedException(typeof(RoboException), "Rotação de cabeça não apropriada seria permitida")]
//        public void TestRoboRotacionarCabecaDeveTerInclinacaoDiferenteDeParaBaixo()
//        {
//            _robo.Cabeca.Inclinacao = EnumInclinacao.ParaBaixo;

//            // Inclinação está Para Baixo
//            Assert.AreEqual(EnumInclinacao.ParaBaixo, _robo.Cabeca.Inclinacao);

//            _robo.Cabeca.Rotacao = EnumRotacao.Rotacao45;
//        }

//        /// <summary>
//        /// Só poderá Rotacionar a Cabeça caso sua Inclinação da Cabeça não esteja em estado Para Baixo
//        /// </summary>
//        [TestMethod]
//        public void TestRoboRotacionarCabecaAlteraQuandoInclinacaoDiferenteDeParaBaixo()
//        {
//            Assert.AreEqual(EnumInclinacao.EmRepouso, _robo.Cabeca.Inclinacao);

//            // Inclinação está diferente de Para Baixo
//            Assert.AreNotEqual(EnumInclinacao.ParaBaixo, _robo.Cabeca.Inclinacao);

//            _robo.Cabeca.Rotacao = EnumRotacao.Rotacao45;
//        }

//        #region TEST PROGRESSÃO DE ESTADOS
//        // ###############################################################################
//        // Ao realizar a progressão de estados, é necessário que sempre siga a ordem
//        // crescente ou decrescente, por exemplo, a partir do estado 4, pode-se ir para
//        // os estados 3 ou 5, nunca pulando um estado.
//        // ###############################################################################

//        [TestMethod]
//        public void TestProgressaoDeEstadosInclinacaoCabecaCrescenteDecrescente()
//        {
//            // 2
//            Assert.AreEqual(EnumInclinacao.EmRepouso, _robo.Cabeca.Inclinacao);

//            // 3
//            _robo.Cabeca.Inclinacao = EnumInclinacao.ParaBaixo;
//            Assert.AreEqual(EnumInclinacao.ParaBaixo, _robo.Cabeca.Inclinacao);

//            // Não deve permitir ir para o 1
//            Assert.ThrowsException<RoboException>(() =>
//            {
//                _robo.Cabeca.Inclinacao = EnumInclinacao.ParaCima;

//            }, "Progressão de Inclinação deve ser sequencial");

//            // 2
//            _robo.Cabeca.Inclinacao = EnumInclinacao.EmRepouso;
//            Assert.AreEqual(EnumInclinacao.EmRepouso, _robo.Cabeca.Inclinacao);

//            // 1
//            _robo.Cabeca.Inclinacao = EnumInclinacao.ParaCima;
//            Assert.AreEqual(EnumInclinacao.ParaCima, _robo.Cabeca.Inclinacao);

//            // Não deve permitir ir para o 3
//            Assert.ThrowsException<RoboException>(() =>
//            {
//                _robo.Cabeca.Inclinacao = EnumInclinacao.ParaBaixo;

//            }, "Progressão de Inclinação deve ser sequencial");
//        }

//        [TestMethod]
//        public void TestProgressaoDeEstadosRotacaoCabecaCrescenteDecrescente()
//        {
//            // 3
//            Assert.AreEqual(EnumRotacao.EmRepouso, _robo.Cabeca.Rotacao);

//            // Não deve permitir ir para o 1
//            Assert.ThrowsException<RoboException>(() =>
//            {
//                _robo.Cabeca.Rotacao = EnumRotacao.RotacaoMenos90;

//            }, "Progressão de Inclinação deve ser sequencial");
//            // Não deve permitir ir para o 5
//            Assert.ThrowsException<RoboException>(() =>
//            {
//                _robo.Cabeca.Rotacao = EnumRotacao.Rotacao90;

//            }, "Progressão de Inclinação deve ser sequencial");

//            // 4
//            _robo.Cabeca.Rotacao = EnumRotacao.Rotacao45;
//            Assert.AreEqual(EnumRotacao.Rotacao45, _robo.Cabeca.Rotacao);

//            // Não deve permitir ir para o 1
//            Assert.ThrowsException<RoboException>(() =>
//            {
//                _robo.Cabeca.Rotacao = EnumRotacao.RotacaoMenos90;

//            }, "Progressão de Inclinação deve ser sequencial");
//            // Não deve permitir ir para o 2
//            Assert.ThrowsException<RoboException>(() =>
//            {
//                _robo.Cabeca.Rotacao = EnumRotacao.RotacaoMenos45;

//            }, "Progressão de Inclinação deve ser sequencial");

//            // 5
//            _robo.Cabeca.Rotacao = EnumRotacao.Rotacao90;
//            Assert.AreEqual(EnumRotacao.Rotacao90, _robo.Cabeca.Rotacao);

//            // Não deve permitir ir para o 3
//            Assert.ThrowsException<RoboException>(() =>
//            {
//                _robo.Cabeca.Rotacao = EnumRotacao.EmRepouso;

//            }, "Progressão de Inclinação deve ser sequencial");
//            // Não deve permitir ir para o 2
//            Assert.ThrowsException<RoboException>(() =>
//            {
//                _robo.Cabeca.Rotacao = EnumRotacao.RotacaoMenos45;

//            }, "Progressão de Inclinação deve ser sequencial");
//            // Não deve permitir ir para o 1
//            Assert.ThrowsException<RoboException>(() =>
//            {
//                _robo.Cabeca.Rotacao = EnumRotacao.RotacaoMenos90;

//            }, "Progressão de Inclinação deve ser sequencial");

//            // 4
//            _robo.Cabeca.Rotacao = EnumRotacao.Rotacao45;
//            Assert.AreEqual(EnumRotacao.Rotacao45, _robo.Cabeca.Rotacao);

//            // 3
//            _robo.Cabeca.Rotacao = EnumRotacao.EmRepouso;
//            Assert.AreEqual(EnumRotacao.EmRepouso, _robo.Cabeca.Rotacao);

//            // 2
//            _robo.Cabeca.Rotacao = EnumRotacao.RotacaoMenos45;
//            Assert.AreEqual(EnumRotacao.RotacaoMenos45, _robo.Cabeca.Rotacao);

//            // Não deve permitir ir para o 4
//            Assert.ThrowsException<RoboException>(() =>
//            {
//                _robo.Cabeca.Rotacao = EnumRotacao.Rotacao45;

//            }, "Progressão de Inclinação deve ser sequencial");
//            // Não deve permitir ir para o 5
//            Assert.ThrowsException<RoboException>(() =>
//            {
//                _robo.Cabeca.Rotacao = EnumRotacao.Rotacao90;

//            }, "Progressão de Inclinação deve ser sequencial");

//            // 1
//            _robo.Cabeca.Rotacao = EnumRotacao.RotacaoMenos90;
//            Assert.AreEqual(EnumRotacao.RotacaoMenos90, _robo.Cabeca.Rotacao);

//            // Não deve permitir ir para o 3
//            Assert.ThrowsException<RoboException>(() =>
//            {
//                _robo.Cabeca.Rotacao = EnumRotacao.EmRepouso;

//            }, "Progressão de Inclinação deve ser sequencial");
//            // Não deve permitir ir para o 4
//            Assert.ThrowsException<RoboException>(() =>
//            {
//                _robo.Cabeca.Rotacao = EnumRotacao.Rotacao45;

//            }, "Progressão de Inclinação deve ser sequencial");
//            // Não deve permitir ir para o 5
//            Assert.ThrowsException<RoboException>(() =>
//            {
//                _robo.Cabeca.Rotacao = EnumRotacao.Rotacao90;

//            }, "Progressão de Inclinação deve ser sequencial");
//        }

//    }
//}
