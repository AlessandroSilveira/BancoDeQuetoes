using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using BancoDeQuestoes.Application.Interface.Repositories;
using BancoDeQuestoes.Domain.Entities;
using BancoDeQuestoes.Mvc.ViewModels;

namespace BancoDeQuestoes.Mvc.Controllers
{
	public class GerenciamentoQuestoesController : Controller
	{
		

		// GET: GerenciamentoQuestoes
        public ActionResult Index()
        {
	       ViewBag.Lista = 
            return View(listaQuestao);
        }
    }
}