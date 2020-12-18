using RoboWebApi.Interfaces;
using RoboWebApi.Models;
using RoboWebApi.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoboWebApi.Services
{
    public class RoboService : IRoboService
    {
        private readonly Robo _robo;

        public RoboService()
        {
            if (_robo == null)
            {
                _robo = new Robo();

                _robo.EstadoInicialRobo();
            }
        }

        public Robo GetRobo()
        {
            return _robo;
        }

        public void UpdateRobo(RoboViewModel robo)
        {
            _robo.BracoDireito.Cotovelo.Movimentar(robo.BracoDireito.Cotovelo.Estado);
            _robo.BracoDireito.Pulso.Movimentar(robo.BracoDireito.Pulso.Estado);

            _robo.BracoEsquerdo.Cotovelo.Movimentar(robo.BracoEsquerdo.Cotovelo.Estado);
            _robo.BracoEsquerdo.Pulso.Movimentar(robo.BracoEsquerdo.Pulso.Estado);

            _robo.Cabeca.Inclinacao.Movimentar(robo.Cabeca.Inclinacao.Estado);
            _robo.Cabeca.Rotacao.Movimentar(robo.Cabeca.Rotacao.Estado);
        }

        public RoboViewModel EntityToViewModel()
        {
            RoboViewModel viewModel = new RoboViewModel();
            viewModel.BracoDireito.Cotovelo.Estado = _robo.BracoDireito.Cotovelo.Estado;
            viewModel.BracoDireito.Cotovelo.EstadoDescricao = _robo.BracoDireito.Cotovelo.EstadoDescricao;
            viewModel.BracoDireito.Pulso.Estado = _robo.BracoDireito.Pulso.Estado;
            viewModel.BracoDireito.Pulso.EstadoDescricao = _robo.BracoDireito.Pulso.EstadoDescricao;

            viewModel.BracoEsquerdo.Cotovelo.Estado = _robo.BracoEsquerdo.Cotovelo.Estado;
            viewModel.BracoEsquerdo.Cotovelo.EstadoDescricao = _robo.BracoEsquerdo.Cotovelo.EstadoDescricao;
            viewModel.BracoEsquerdo.Pulso.Estado = _robo.BracoEsquerdo.Pulso.Estado;
            viewModel.BracoEsquerdo.Pulso.EstadoDescricao = _robo.BracoEsquerdo.Pulso.EstadoDescricao;

            viewModel.Cabeca.Inclinacao.Estado = _robo.Cabeca.Inclinacao.Estado;
            viewModel.Cabeca.Inclinacao.EstadoDescricao = _robo.Cabeca.Inclinacao.EstadoDescricao;
            viewModel.Cabeca.Rotacao.Estado = _robo.Cabeca.Rotacao.Estado;
            viewModel.Cabeca.Rotacao.EstadoDescricao = _robo.Cabeca.Rotacao.EstadoDescricao;

            return viewModel;
        }

        public RoboViewModel EntityToViewModel(Robo robo)
        {
            RoboViewModel viewModel = new RoboViewModel();
            viewModel.BracoDireito.Cotovelo.Estado = robo.BracoDireito.Cotovelo.Estado;
            viewModel.BracoDireito.Cotovelo.EstadoDescricao = robo.BracoDireito.Cotovelo.EstadoDescricao;
            viewModel.BracoDireito.Pulso.Estado = robo.BracoDireito.Pulso.Estado;
            viewModel.BracoDireito.Pulso.EstadoDescricao = robo.BracoDireito.Pulso.EstadoDescricao;

            viewModel.BracoEsquerdo.Cotovelo.Estado = robo.BracoEsquerdo.Cotovelo.Estado;
            viewModel.BracoEsquerdo.Cotovelo.EstadoDescricao = robo.BracoEsquerdo.Cotovelo.EstadoDescricao;
            viewModel.BracoEsquerdo.Pulso.Estado = robo.BracoEsquerdo.Pulso.Estado;
            viewModel.BracoEsquerdo.Pulso.EstadoDescricao = robo.BracoEsquerdo.Pulso.EstadoDescricao;

            viewModel.Cabeca.Inclinacao.Estado = robo.Cabeca.Inclinacao.Estado;
            viewModel.Cabeca.Inclinacao.EstadoDescricao = robo.Cabeca.Inclinacao.EstadoDescricao;
            viewModel.Cabeca.Rotacao.Estado = robo.Cabeca.Rotacao.Estado;
            viewModel.Cabeca.Rotacao.EstadoDescricao = robo.Cabeca.Rotacao.EstadoDescricao;

            return viewModel;
        }
    }
}