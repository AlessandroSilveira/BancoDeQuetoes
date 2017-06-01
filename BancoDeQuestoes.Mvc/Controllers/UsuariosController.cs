using System;
using System.Web.Mvc;
using BancoDeQuestoes.Application.Interface.Repositories;
using BancoDeQuestoes.Domain.Interfaces.Repository;

namespace BancoDeQuestoes.Mvc.Controllers
{
    [Authorize]
    public class UsuariosController : Controller
    {

        private readonly IUsuarioAppService _usuarioAppService;

        public UsuariosController(IUsuarioAppService usuarioAppService)
        {
            _usuarioAppService = usuarioAppService;
        }

        // GET: Usuarios
        public ActionResult Index()
        {
            return View(_usuarioAppService.GetAll());
        }

        // GET: Usuarios/Details/5
        public ActionResult Details(Guid id)
        {
            return View(_usuarioAppService.GetById(id));
        }

        public ActionResult DesativarLock(Guid id)
        {
            _usuarioAppService.DesativarLock(id);
            return RedirectToAction("Index");
        }
    }
}
