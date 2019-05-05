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
    public class QuestionAnswerController : Controller
    {
        QuestionAnswerService _questionAnswerService;

        public QuestionAnswerController()
        {
            _questionAnswerService = new QuestionAnswerService();
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(QuestionAnswer data)
        {
            _questionAnswerService.Add(data);
            return Redirect("/Admin/QuestionAnswer/List");
        }

        public ActionResult List()
        {
            List<QuestionAnswer> model =_questionAnswerService.GetActive();
            return View(model);
        }

        public ActionResult Update(Guid id)
        {
            QuestionAnswer answer = _questionAnswerService.GetByID(id);
            QuestionAnswerDTO model = new QuestionAnswerDTO();
            model.ID = answer.ID;
            model.Question = answer.Question;
            model.Reply = answer.Reply;
            model.SeoTitle = answer.SeoTitle;
            model.SeoDescription = answer.SeoDescription;
            return View(model);
        }

        [HttpPost]
        public ActionResult Update(QuestionAnswerDTO data)
        {
            QuestionAnswer answer = _questionAnswerService.GetByID(data.ID);
            answer.ID = data.ID;
            answer.Question = data.Question;
            answer.Reply = data.Reply;
            answer.SeoTitle = data.SeoTitle;
            answer.SeoDescription = data.SeoDescription;
            
            _questionAnswerService.Update(answer);
            TempData["Successful"] = "Transaction is successful.";
            return Redirect("/Admin/QuestionAnswer/List");
        }

        public ActionResult Delete(Guid id)
        {
            _questionAnswerService.Remove(id);
            TempData["Successful"] = "Transaction is successful.";
            return Redirect("/Admin/QuestionAnswer/List");

        }

    }
}