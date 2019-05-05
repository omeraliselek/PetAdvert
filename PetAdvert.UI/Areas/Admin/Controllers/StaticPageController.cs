using PetAdvert.Model.Option;
using PetAdvert.Service.Option;
using PetAdvert.UI.Areas.Admin.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PetAdvert.UI.Areas.Admin.Controllers
{
    public class StaticPageController : Controller
    {
        StaticPageService _staticPageService;

        public StaticPageController()
        {
            _staticPageService = new StaticPageService();
        }
        
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(StaticPage data)
        {
            _staticPageService.Add(data);
            return Redirect("/Admin/StaticPage/List");
        }

        public ActionResult List()
        {
            List<StaticPage> model = _staticPageService.GetActive();
            return View(model);
        }

        public ActionResult Update(Guid id)
        {
            StaticPage page = _staticPageService.GetByID(id);
            StaticPageDTO model = new StaticPageDTO();
            model.ID = page.ID;
            model.PageName = page.PageName;
            model.Detail = page.Detail;
            model.SeoTitle = page.SeoTitle;
            model.SeoDescription = page.SeoDescription;


            return View(model);
}

        [HttpPost]
        public ActionResult Update(StaticPageDTO data)
        {
            StaticPage page = _staticPageService.GetByID(data.ID);
            page.ID = data.ID;
            page.PageName = data.PageName;
            page.Detail = data.Detail;
            page.SeoTitle = data.SeoTitle;
            page.SeoDescription = data.SeoDescription;

            _staticPageService.Update(page);
            TempData["Successful"] = "Transaction is successful.";
            return Redirect("/Admin/StaticPage/List");
        }

        public ActionResult Delete(Guid id)
        {
            _staticPageService.Remove(id);
            TempData["Successful"] = "Transaction is successful.";
            return Redirect("/Admin/StaticPage/List");

        }
    }
}