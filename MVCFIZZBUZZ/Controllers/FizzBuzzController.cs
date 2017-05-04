using System;   
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCFIZZBUZZ.Models;
using MVCFIZZBUZZ.Models.ViewModel;

namespace MVCFIZZBUZZ.Controllers
{   //FizzBuzz Controller
    public class FizzBuzzController : Controller
    {
        // GET: FizzBuzz
        public ActionResult Index()
        {
            return View();
        }

        // GET: FizzBuzz/Details/5
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Details(FizzBuzzViewModel model, int page = 0)
        {
            int userInputId = model.UserInputId;
            Session["UserInput"] = userInputId;
            DayOfWeek day = DateTime.Now.DayOfWeek;
            List<DetailsModel> finalresult = new List<DetailsModel>();
            for (int i = 1; i <= userInputId; i++)
            {
                DetailsModel results = new DetailsModel();
                if (i % 3 == 0)
                {
                    if (day == DayOfWeek.Wednesday)
                    {
                        results.Details = "wizz";
                    }
                    else
                    {
                        results.Details = "fizz";
                    }

                }
                if (i % 5 == 0)
                {
                    if (day == DayOfWeek.Wednesday)
                    {
                        results.Details = "wuzz";
                    }
                    else
                    {
                        results.Details = results.Details + "buzz";
                    }

                }
                if (string.IsNullOrEmpty(results.Details))
                {
                    results.Details = i.ToString();
                }
                results.DetailID = i;
                finalresult.Add(results);
            }
            
            const int PageSize = 20; 

            var count = finalresult.Count();

            var data = finalresult.Skip(page * PageSize).Take(PageSize).ToList();
            this.ViewBag.MaxPage = (count / PageSize) - (count % PageSize == 0 ? 1 : 0);
            this.ViewBag.Page = page;
            return View(data);
        }

        public ActionResult Details(int page = 0)
        {
            int userInputId = Convert.ToInt32(Session["UserInput"]);
             
            DayOfWeek day = DateTime.Now.DayOfWeek;
            List<DetailsModel> finalresult = new List<DetailsModel>();
            for (int i = 1; i <= userInputId; i++)
            {
                DetailsModel results = new DetailsModel();
                if (i % 3 == 0)
                {

                    if (day == DayOfWeek.Wednesday)
                    {
                        results.Details = "wizz";
                    }
                    else
                    {
                        results.Details = "fizz";
                    }

                }
                if (i % 5 == 0)
                {
                    if (day == DayOfWeek.Wednesday)
                    {
                        results.Details = "wuzz";
                    }
                    else
                    {
                        results.Details = results.Details + "buzz";
                    }

                }
                if (string.IsNullOrEmpty(results.Details))
                {
                    results.Details = i.ToString();
                }

                results.DetailID = i;
                finalresult.Add(results);
            }

            const int PageSize = 20; 

            var count = finalresult.Count();
            var data = finalresult.Skip(page * PageSize).Take(PageSize).ToList();
            this.ViewBag.MaxPage = (count / PageSize) - (count % PageSize == 0 ? 1 : 0);
            this.ViewBag.Page = page;
            return View(data);
        }
    }
}