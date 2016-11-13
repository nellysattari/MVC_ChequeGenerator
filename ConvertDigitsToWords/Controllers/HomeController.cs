using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Utility;
using ViewModel;

namespace ConvertDigitsToWords.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Convert digits to words in order to print it out on the cheque";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "@Nelly_Sattar";

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public PartialViewResult Convert(Model model)
        {
            if (ModelState.IsValid)
            {
                model.ConvertedWords = model.InitialValue.TryParseDecimalToWords(MidpointRounding.ToEven);
                return PartialView("_ShowWords", model);
            }
            else
            { return PartialView("_ShowWords", null); }
        }


    }
}
