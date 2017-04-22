using System;
using System.Web.Mvc;
using BancoDeQuestoes.Application.Interface;
using BancoDeQuestoes.Application.ViewModels;

namespace BancoDeQuestoes.Mvc.Controllers
{
    public class AreaController : Controller
    {
        private readonly AreaAppService _areaAppService;

        public AreaController(AreaAppService areaAppService)
        {
            _areaAppService = areaAppService;
        }


        public ActionResult Index()
        {
			
			return View(_areaAppService.GetAll());
        }
       
        public ActionResult Details(Guid id)
        {

            return View(_areaAppService.GetById(id));
        }
        
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AreaViewModel areaViewModel)
        {
	        if (!ModelState.IsValid) return View(areaViewModel);
	      
	        _areaAppService.Add(areaViewModel);

	        return RedirectToAction("Index");
        }
       
        public ActionResult Edit(Guid id)
        {
           
			var area = _areaAppService.GetById(id);
		
			return View(area);
		}
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit( AreaViewModel areaViewModel)
        {
			_areaAppService.Update(areaViewModel);

	        return RedirectToAction("Index");
        }
       
        public ActionResult Delete(Guid id)
        {
			var area = _areaAppService.GetById(id);
			
			return View(area);
		}
      
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
			_areaAppService.Remove(id);
			return RedirectToAction("Index");
		}
    }
}
