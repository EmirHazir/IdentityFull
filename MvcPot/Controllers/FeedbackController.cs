using MvcPot.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MvcPot.Controllers
{
    public class FeedbackController : Controller
    {
        ApplicationDbContext context;
        public FeedbackController()
        {
            context = new ApplicationDbContext();
        }

        // GET: Feedback
        public ActionResult Index()
        {
            return View(context.Feedbacks.ToList());
        }

        public ActionResult Create()
        {
            FeedbackViewModel model = new FeedbackViewModel();
            model.Answers = Common.GetAnswers();
            return View(model);
        }

        [HttpPost]
        public async Task<ActionResult> Create(FeedbackViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    context.Feedbacks.Add(new Feedback { Answer = model.Select, Comment = model.Comment, Email = model.Email, FullName = model.FullName });
                    await context.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
                model.Answers = Common.GetAnswers();
                return View(model);
            }
            catch (DbEntityValidationException dbValExp)
            {

                var outPutLines = new StringBuilder();
                foreach (var item in dbValExp.EntityValidationErrors)
                {
                    outPutLines.AppendFormat("{0}:Entity tipi {1} içinde durum {2} validation hatası var", DateTime.Now, item.Entry.Entity.GetType().Name, item.Entry);
                    foreach (var item2 in item.ValidationErrors)
                    {
                        outPutLines.AppendFormat(" - Property: {0}, Error{1}", item2.PropertyName, item2.ErrorMessage);
                    }
                }
                throw new DbEntityValidationException(string.Format("Validation errorsrn{0}"
    , outPutLines.ToString()), dbValExp);
            }
        }
    }
}