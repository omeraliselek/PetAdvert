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
    public class PettypeController : Controller
    {
        PettypeService _pettypeService;

        public PettypeController()
        {
            _pettypeService = new PettypeService();
        }

        
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Pettype data)
        {
            _pettypeService.Add(data);
            return Redirect("/Admin/Pettype/List");
        }

        public ActionResult List()
        {
            List<Pettype> model =_pettypeService.GetActive();
            return View(model);
        }

        public ActionResult Update(Guid id)
        {
            Pettype pet = _pettypeService.GetByID(id);
            PettypeDTO model = new PettypeDTO();
            model.ID = pet.ID;
            model.PettypeName = pet.PettypeName;
            model.PettypeDescription = pet.PettypeDescription;
            model.SeoTitle = pet.SeoTitle;
            model.SeoDescription = pet.SeoDescription;
            return View(model);
           }

        [HttpPost]
        public ActionResult Update(PettypeDTO data)
        {
            Pettype pet = _pettypeService.GetByID(data.ID);
            pet.ID = data.ID;
            pet.PettypeName = data.PettypeName;
            pet.PettypeDescription = data.PettypeDescription;
            pet.SeoTitle = data.SeoTitle;
            pet.SeoDescription = data.SeoDescription;
            
           
          
            _pettypeService.Update(pet);
            TempData["Successful"] = "Transaction is successful.";
            return Redirect("/Admin/Pettype/List");
        }

        public ActionResult Delete(Guid id)
        {
            _pettypeService.Remove(id);
            TempData["Successful"] = "Transaction is successful.";
            return Redirect("/Admin/Pettype/List");

        }
    }
}