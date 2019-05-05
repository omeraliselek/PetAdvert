using PetAdvert.Service.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PetAdvert.UI.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        // GET: Admin/Home
        public ActionResult Index()
        {
            AdvertisementService  _advertisementService = new AdvertisementService();
            var model = _advertisementService.GetActive().OrderByDescending(x => x.CreatedDate).Take(5);
            return View(model);
            
        }
    }
}