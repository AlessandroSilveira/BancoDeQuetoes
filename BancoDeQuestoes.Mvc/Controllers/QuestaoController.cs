using System;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using BancoDeQuestoes.Application.Interface.Repositories;
using BancoDeQuestoes.Application.ViewModels;

namespace BancoDeQuestoes.Mvc.Controllers
{
    public class QuestaoController : Controller
    {
        private readonly IQuestaoAppService _questaoAppService;
        private readonly IStatusAppService _statusAppService;

        public QuestaoController(IQuestaoAppService questaoAppService, IStatusAppService statusAppService)
        {
            _questaoAppService = questaoAppService;
            _statusAppService = statusAppService;
        }

        // GET: Questao
        public ActionResult Index()
        {
            var questaoViewModels = _questaoAppService.GetAll();
            return View(questaoViewModels.ToList());
           
        }

        // GET: Questao/Details/5
        public ActionResult Details(Guid id)
        {
          
            var questaoViewModel = _statusAppService.GetById(id);
            if (questaoViewModel == null)
            {
                return HttpNotFound();
            }
            return View(questaoViewModel);
            
        }

        // GET: Questao/Create
        public ActionResult Create()
        {
            //ViewBag.TopicoAtribuidoId = new SelectList(db.TopicoAtribuidoes, "TopicoAtribuidoId", "CodigoProjeto");
            return View();
        }

        // POST: Questao/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "QuestaoId,TopicoAtribuidoId,NumeroQuestao,Descricao,Arquivo,Status,NumeroDeRevisoes,Finalizar,Nivel,Imagem,ConviteAceito")] QuestaoViewModel questaoViewModel)
        {
            //if (ModelState.IsValid)
            //{
            //    questaoViewModel.QuestaoId = Guid.NewGuid();
            //    db.QuestaoViewModels.Add(questaoViewModel);
            //    db.SaveChanges();
            //    return RedirectToAction("Index");
            //}

            //ViewBag.TopicoAtribuidoId = new SelectList(db.TopicoAtribuidoes, "TopicoAtribuidoId", "CodigoProjeto", questaoViewModel.TopicoAtribuidoId);
            //return View(questaoViewModel);
            return View();
        }

        // GET: Questao/Edit/5
        public ActionResult Edit(Guid? id)
        {
            //    if (id == null)
            //    {
            //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //    }
            //    QuestaoViewModel questaoViewModel = db.QuestaoViewModels.Find(id);
            //    if (questaoViewModel == null)
            //    {
            //        return HttpNotFound();
            //    }
            //    ViewBag.TopicoAtribuidoId = new SelectList(db.TopicoAtribuidoes, "TopicoAtribuidoId", "CodigoProjeto", questaoViewModel.TopicoAtribuidoId);

            return View();
            //return View(questaoViewModel);
        }

        // POST: Questao/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "QuestaoId,TopicoAtribuidoId,NumeroQuestao,Descricao,Arquivo,Status,NumeroDeRevisoes,Finalizar,Nivel,Imagem,ConviteAceito")] QuestaoViewModel questaoViewModel)
        {
            //if (ModelState.IsValid)
            //{
            //    db.Entry(questaoViewModel).State = EntityState.Modified;
            //    db.SaveChanges();
            //    return RedirectToAction("Index");
            //}
            //ViewBag.TopicoAtribuidoId = new SelectList(db.TopicoAtribuidoes, "TopicoAtribuidoId", "CodigoProjeto", questaoViewModel.TopicoAtribuidoId);
            //return View(questaoViewModel);
            return View();
        }

        // GET: Questao/Delete/5
        public ActionResult Delete(Guid? id)
        {
            //if (id == null)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //}
            //QuestaoViewModel questaoViewModel = db.QuestaoViewModels.Find(id);
            //if (questaoViewModel == null)
            //{
            //    return HttpNotFound();
            //}

            //return View(questaoViewModel);

            return View();
        }

        // POST: Questao/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            //QuestaoViewModel questaoViewModel = db.QuestaoViewModels.Find(id);
            //db.QuestaoViewModels.Remove(questaoViewModel);
            //db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            //if (disposing)
            //{
            //    db.Dispose();
            //}
            //base.Dispose(disposing);
        }

        public ActionResult AtualizarQuestaoConviteAceito(string listaIds, string listaAceite)
        {
            var questoesId = listaIds.Split(',');
            var questoesAceitas = listaAceite.Split(',');
           // var status = _statusAppService.Search(a=>a.NumeroStatus.Equals("2"));
           var status = _statusAppService.ObterDescricaoStatus("Convite Aceito");
            for (var i = 0; i < questoesId.Length; i++)
            {
               
                var dadosQuestoes = _questaoAppService.GetById(new Guid(questoesId[i]));
                dadosQuestoes.ConviteAceito = questoesAceitas[i] == "1";
                dadosQuestoes.Status = status.Nome;
                _questaoAppService.Update(dadosQuestoes);
            }
            return RedirectToAction("ListaConvites", "Mestre");
        }
    }
}
