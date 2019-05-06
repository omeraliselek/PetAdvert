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
    public class GeneralSettingController : Controller
    {
        GeneralSettingService  _generalSettingService;

        public GeneralSettingController()
        {
            _generalSettingService = new GeneralSettingService();
        }
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(GeneralSetting data)
        {
            _generalSettingService.Add(data);
            return Redirect("/Admin/GeneralSetting/List");
        }

        public ActionResult List()
        {
            List<GeneralSetting> model = _generalSettingService.GetActive();
            return View(model);
        }

        public ActionResult Update(Guid id)
        {
            //if (id == null)
            //{
            //    List<GeneralSetting> modelList = _generalSettingService.GetActive();
            //    return View("List", modelList);
            //}

            GeneralSetting General = _generalSettingService.GetByID(id);
            GeneralSettingDTO model = new GeneralSettingDTO();
            model.ID = General.ID;
            model.Email = General.Email;
            model.Telephone = General.Telephone;
            model.Facebook = General.Facebook;
            model.Twitter = General.Twitter;
            model.instagram = General.instagram;
            model.Pinterest = General.Pinterest;
            model.Youtube = General.Youtube;
            model.CopyrightText = General.CopyrightText;
            model.Googleplay = General.Googleplay;
            model.AppStore = General.AppStore;
            model.SeoTitle = General.SeoTitle;
            model.SeoDescription = General.SeoDescription;
            return View(model);
        }

        [HttpPost]
        public ActionResult Update(GeneralSettingDTO data)
        {
            GeneralSetting General = _generalSettingService.GetByID(data.ID);
            General.ID = data.ID;
            General.Email = data.Email;
            General.Telephone = data.Telephone;
            General.Facebook = data.Facebook;
            General.Twitter = data.Twitter;
            General.instagram = data.instagram;
            General.Pinterest = data.Pinterest;
            General.Youtube = data.Youtube;
            General.CopyrightText = data.CopyrightText;
            General.Googleplay = data.Googleplay;
            General.AppStore = data.AppStore;
            General.SeoTitle = General.SeoTitle;
            General.SeoDescription = General.SeoDescription;
            _generalSettingService.Update(General);
            TempData["Successful"] = "Transaction is successful.";
            //return Redirect("/Admin/GeneralSetting/Update");
            return RedirectToAction("List");
        }

        public ActionResult Delete(Guid id)
        {
            _generalSettingService.Remove(id);
            TempData["Successful"] = "Transaction is successful.";
            return Redirect("/Admin/GeneralSetting/List");

        }
    }
}