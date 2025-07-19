using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;
using CarInsurance.ViewModels;

namespace CarInsurance.Controllers
{

    public class AdminController : Controller
    {

        public ActionResult Index()
        {

            using (InsuranceEntities db = new InsuranceEntities())
            {

                var quotes = (from column in db.Insurees
                              select column).ToList();

                var quotesVms = new List<QuotesVm>();

                foreach (var quote in quotes)
                {

                    var quotesVm = new QuotesVm();

                    quotesVm.FirstName = quote.FirstName;
                    quotesVm.LastName = quote.LastName;
                    quotesVm.EmailAddress = quote.EmailAddress;
                    quotesVm.Quote = quote.Quote;

                    quotesVms.Add(quotesVm);

                }

                return View(quotesVms);

            }

        }

    }

}