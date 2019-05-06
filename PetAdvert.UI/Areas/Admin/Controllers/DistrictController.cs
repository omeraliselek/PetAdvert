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
    public class DistrictController : Controller
    {
        public CityService _cityService;
        public DistrictService _districtService;

        public DistrictController()
        {
            _cityService = new CityService();
            _districtService = new DistrictService();
        }

        public ActionResult Index()
        {
            AddDistrictWM model = new AddDistrictWM()
                {

                Cities = _cityService.GetActive(),
                Districts= _districtService.GetActive(),
                    };

                return View(model);
            }

        [HttpPost]
        public ActionResult Add(District data)
        {
            _districtService.Add(data);
            return Redirect("/Admin/Saying/List");
        }

        public ActionResult List()
        {
            List<District> model = _districtService.GetActive();
            return View(model);
        }

        public ActionResult Update(Guid id)
        {
            UpdateDistrictWM model = new UpdateDistrictWM();

            District district = _districtService.GetByID(id);
            model.districtDTO.ID = district.ID;
            model.districtDTO.Ilce = district.Ilce;
            model.Cities = _cityService.GetActive();


            return View(model);
        }

        [HttpPost]
        public ActionResult Update(DistrictDTO data)
        {
            District district = _districtService.GetByID(data.ID);
            district.ID = data.ID;
            district.Ilce = data.Ilce;
            district.CityID = data.CityID;



            _districtService.Update(district);

            return Redirect("/Admin/Saying/List");
        }

        public ActionResult Delete(Guid id)
        {
            _districtService.Remove(id);
            TempData["Successful"] = "Transaction is successful.";
            return Redirect("/Admin/Saying/List");
        }


    }

}
 
