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
    public class CityController : Controller
    {
        CityService _cityService;

        public CityController()
        {
            _cityService = new CityService();
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(City data)
        {
            _cityService.Add(data);
            return Redirect("/Admin/Category/List");
        }

        public ActionResult List()
        {
            List<City> model = _cityService.GetActive();
            return View(model);
        }

        public ActionResult Update(Guid id)
        {
             City city = _cityService.GetByID(id);
            CityDTO model = new CityDTO();
            model.ID = city.ID;
            model.Il = city.Il;
            model.SeoTitle = city.SeoTitle;
            model.SeoDescription = city.SeoDescription;
            return View(model);
}

        [HttpPost]
        public ActionResult Update(CityDTO data)
        {
            City city = _cityService.GetByID(data.ID);
            city.ID = data.ID;
            city.Il = data.Il;
            city.SeoTitle = data.SeoTitle;
            city.SeoDescription = data.SeoDescription;
           _cityService.Update(city);
            TempData["Successful"] = "Transaction is successful.";
            return Redirect("/Admin/City/List");
        }

        public ActionResult Delete(Guid id)
        {
            _cityService.Remove(id);
            TempData["Successful"] = "Transaction is successful.";
            return Redirect("/Admin/City/List");

        }
    }
}