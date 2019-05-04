using PetAdvert.Model.Option;
using PetAdvert.Service.Option;
using PetAdvert.UI.Areas.Admin.Models.DTO;
using PetAdvert.UI.Areas.Admin.Models.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PetAdvert.UI.Areas.Admin.Controllers
{
    public class AdvertisementController : Controller
    {
        public AppUserService _appUserService;
        public CityService _cityService;
        public DistrictService _districtService;
        public PettypeService _pettypeService;
        public RaceService _raceService;
        public AdvertisementService _advertisementService;

        public AdvertisementController()
        {
            _appUserService = new AppUserService();
            _cityService = new CityService();
            _districtService = new DistrictService();
            _pettypeService = new PettypeService();
            _raceService = new RaceService();
            _advertisementService = new AdvertisementService();
        }

        public ActionResult Add()
        {
            AddAdvertisementVM model = new AddAdvertisementVM()
            {
                appUsers = _appUserService.GetActive(),
                Cities = _cityService.GetActive(),
                Districts = _districtService.GetActive(),
                Pettypes = _pettypeService.GetActive(),
                Races = _raceService.GetActive(),
                advertisements = _advertisementService.GetActive(),
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult Add(Advertisement data)
        {
            _advertisementService.Add(data);
            return Redirect("/Admin/Saying/List");
        }

        public ActionResult List()
        {
            List<Advertisement> model = _advertisementService.GetActive();
            return View(model);
        }
        
       public ActionResult Update(Guid id)
        {
            UpdateAdvertisementVM model = new UpdateAdvertisementVM();

           Advertisement advertisement = _advertisementService.GetByID(id);
            model.advertisements.ID = advertisement.ID;
            model.advertisements.AdTitle = advertisement.AdTitle;
            model.advertisements.adtype = advertisement.adtype;
            model.advertisements.gender = advertisement.gender;
            model.advertisements.role = advertisement.role;
            model.advertisements.Age = advertisement.Age;
            model.advertisements.Detail = advertisement.Detail;
            model.advertisements.SeoTitle = advertisement.SeoTitle;
            model.advertisements.SeoDescription = advertisement.SeoDescription;
            model.appUsers = _appUserService.GetActive();
            model.Cities = _cityService.GetActive();
            model.Districts = _districtService.GetActive();
            model.Pettypes = _pettypeService.GetActive();
            model.Races = _raceService.GetActive();
            return View(model);
        }

        [HttpPost]
        public ActionResult Update(AdvertisementDTO data)
        {
            Advertisement advertisement = _advertisementService.GetByID(data.ID);
            advertisement.ID = data.ID;
            advertisement.AdTitle = data.AdTitle;
            advertisement.adtype = data.adtype;
            advertisement.gender = data.gender;
            advertisement.role = data.role;
            advertisement.Age = data.Age;
            advertisement.Detail = data.Detail;
            advertisement.SeoTitle = data.SeoTitle;
            advertisement.SeoDescription = data.SeoDescription;
            advertisement.AppUserID = data.AppUserID;
            advertisement.DistrictID = data.DistrictID;
            advertisement.RaceID = data.RaceID;
           _advertisementService.Update(advertisement);
           return Redirect("/Admin/Advertisement/List");
        }

        public ActionResult Delete(Guid id)
        {
            _advertisementService.Remove(id);
            TempData["Successful"] = "Transaction is successful.";
            return Redirect("/Admin/Advertisement/List");
        }
    }
}