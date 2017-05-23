using System;
using System.Web.Mvc;
using BancoDeQuestoes.Application.Interface.Repositories;
using BancoDeQuestoes.Application.ViewModels;

namespace BancoDeQuestoes.Mvc.Controllers
{
    public class TopicoAtribuidoController : Controller
    {
        private readonly ITopicoAtribuidoAppService _topicoAtribuidoAppService;

        public TopicoAtribuidoController(ITopicoAtribuidoAppService topicoAtribuidoAppService)
        {
            _topicoAtribuidoAppService = topicoAtribuidoAppService;
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
        public ActionResult SalvarTopicoAtribuido(Guid ProjetoId, Guid AreaId, Guid MestreId, decimal inputValor, DateTime inputData,
            int inputNumQuestao, string Nivel, string inputObservacoes, string Disciplinas_selecionadas)
        {
            if (!ModelState.IsValid) return View();

            var id_discipliina = Disciplinas_selecionadas.Split(',');

            foreach (var dados in id_discipliina)
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
                    DisciplinaId = new Guid(dados)
                   
                };
                _topicoAtribuidoAppService.Add(form);
            }

           
            return View();
        }
    }
}
