﻿using System;
using System.Linq;
using System.Web.Mvc;
using BancoDeQuestoes.Application.Interface.Repositories;
using BancoDeQuestoes.Application.ViewModels;

namespace BancoDeQuestoes.Mvc.Controllers
{
    [Authorize(Roles = "Admin")]
    public class TopicoAtribuidoController : Controller
    {
        private readonly ITopicoAtribuidoAppService _topicoAtribuidoAppService;
        private readonly IStatusAppService _statusAppService;
        private readonly IConviteMestreAppService _conviteMestreAppService;
       

        public TopicoAtribuidoController(ITopicoAtribuidoAppService topicoAtribuidoAppService,
            IStatusAppService statusAppService, IConviteMestreAppService conviteMestreAppService)
        {
            _topicoAtribuidoAppService = topicoAtribuidoAppService;
            _statusAppService = statusAppService;
            _conviteMestreAppService = conviteMestreAppService;
        }

        public ActionResult Index()
        {
            return View(_topicoAtribuidoAppService.GetAll());
        }

        public ActionResult Details(Guid id)
        {
            var topico = _topicoAtribuidoAppService.GetById(id);
            return topico == null ? (ActionResult) HttpNotFound() : View(topico);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TopicoAtribuidoViewModel topicoAtribuidoViewModel)
        {
            if (!ModelState.IsValid) return View(topicoAtribuidoViewModel);
            _topicoAtribuidoAppService.Add(topicoAtribuidoViewModel);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(Guid id)
        {
            var topico = _topicoAtribuidoAppService.GetById(id);
            return View(topico);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(TopicoAtribuidoViewModel topicoAtribuidoViewModel)
        {
            if (!ModelState.IsValid) return View(topicoAtribuidoViewModel);
            _topicoAtribuidoAppService.Update(topicoAtribuidoViewModel);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(Guid id)
        {
            return View(_topicoAtribuidoAppService.GetById(id));
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            _topicoAtribuidoAppService.Remove(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult SalvarTopicoAtribuido(Guid ProjetoId, Guid AreaId, Guid MestreId, decimal inputValor,
            DateTime inputData,
            int inputNumQuestao, string Nivel, string inputObservacoes, string Disciplinas_selecionadas)
        {
            if (!ModelState.IsValid) return View();

            var idDiscipliina = Disciplinas_selecionadas.Split(',');
            var status = _statusAppService.ObterDescricaoStatus("Item sem confirmação de aceite pelo Elaborador");

            foreach (var dados in idDiscipliina)
            {
                var form = new TopicoAtribuidoViewModel
                {
                    ProjetoId = ProjetoId,
                    AreaId = AreaId,
                    MestreId = MestreId,
                    Valor = inputValor,
                    DataEntrega = inputData,
                    NumeroQuestao = inputNumQuestao,
                    Nivel = Nivel,
                    Observacao = inputObservacoes,
                    CodigoProjeto = _topicoAtribuidoAppService.ObterCodigoProjeto(ProjetoId).ToString(),
                    DataAtribuicao = DateTime.Now,
                    DisciplinaId = new Guid(dados),
                    Status = status.FirstOrDefault()?.Nome
                    
                };

                var dadosTopico = _topicoAtribuidoAppService.Add(form);


                var convite = new ConviteMestreViewModel()
                {
                    TopicoAtribuidoId = dadosTopico.TopicoAtribuidoId,
                    MestreId = dadosTopico.MestreId,
                    NumeroQuestao = inputNumQuestao,
                    Aceito = false,
                    TipoPagamento = "",
                    Valor = inputValor
                };

                _conviteMestreAppService.Add(convite);

                //

                // var questao = new QuestaoViewModel()
                // {
                //     TopicoAtribuidoId = dadosTopico.TopicoAtribuidoId,
                //     NumeroQuestao = inputNumQuestao,
                //     Status = status.FirstOrDefault()?.Nome,
                //     Arquivo = "",
                //     ConviteAceito = false,
                //     Descricao = "",
                //     Finalizar = 0,
                //     Imagem = "",
                //     Nivel = Nivel,
                //     NumeroDeRevisoes = 0
                // };
                // _questaoAppService.Add(questao);
            }

            return View();
        }
    }
}
