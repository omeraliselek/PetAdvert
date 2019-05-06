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
    public class RaceController : Controller
    {
        public PettypeService _PettypeService;
        public RaceService _raceService;

        public RaceController()
        {
            _PettypeService = new PettypeService();
            _raceService = new RaceService();
        }
        
        
        // GET: Admin/Race
        public ActionResult Index()
        {
            AddRaceWM model = new AddRaceWM()
            {
                Pettypes =_PettypeService.GetActive(),
                Races= _raceService.GetActive(),
              };

            return View(model);
          
        }

        [HttpPost]
        public ActionResult Add(Race data)
        {
           _raceService.Add(data);
            return Redirect("/Admin/Race/List");
        }

        public ActionResult List()
        {
            List<Race> model = _raceService.GetActive();
            return View(model);
        }

        public ActionResult Update(Guid id)
        {
            UpdateRaceWM model = new UpdateRaceWM();

            Race cins = _raceService.GetByID(id);

            model.ID = cins.ID;
            model.raceDTO.RaceName = cins.RaceName;
            model.raceDTO.SeoTitle = cins.SeoTitle;
            model.raceDTO.SeoDescription = cins.SeoDescription;
            model.Pettypes = _PettypeService.GetActive();
            return View(model);


        }

        [HttpPost]
        public ActionResult Update(RaceDTO data)
        {
            Race cins = _raceService.GetByID(data.ID);
            cins.ID = data.ID;
            cins.RaceName = data.RaceName;
            cins.SeoTitle = data.SeoTitle;
            cins.SeoDescription = data.SeoDescription;
            cins.PettypeID = data.PettypeID;
            


            _raceService.Update(cins);

            return Redirect("/Admin/Saying/List");
        }

        public ActionResult Delete(Guid id)
        {
            _raceService.Remove(id);
            TempData["Successful"] = "Transaction is successful.";
            return Redirect("/Admin/Saying/List");
        }
    }
}