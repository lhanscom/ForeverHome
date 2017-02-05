using System.Collections.Generic;
using System.Web.Mvc;

namespace ForeverHomeNg.Controllers
{
    public class HomeController : Controller
    {
        public List<AdoptionStep> AdoptionSteps { get; set; }

        public ActionResult Index()
        {
            GetAdoptionSteps();
            return View(AdoptionSteps);
        }

        private void GetAdoptionSteps()
        {
            AdoptionSteps = new List<AdoptionStep>()
            {
                new AdoptionStep
                {
                    Order = 1,
                    Title = "Home Study",
                    Cost = 3000,
                    Description = ""
                },
                new AdoptionStep
                {
                    Order = 1,
                    Title = "Agency Sign off",
                    Cost = 1500,
                    Description = "Maybe?"
                },
                new AdoptionStep()
                {
                    Order = 2,
                    Title = "Be found Eligible (I600a)",
                    Cost = 750,
                    Description = ""
                },
                new AdoptionStep()
                {
                    Order = 2,
                    Title = "Child Medical Exam",
                    Cost = 110,
                    Description = ""
                },
                new AdoptionStep
                {
                    Order = 1,
                    Title = "Facilitator",
                    Cost = 0,
                    Description = "Ask about this cost Yana https://www.facebook.com/yana.deman.7"
                },
                new AdoptionStep
                {
                    Order = 1,
                    Title = "Child Matching (SDAPRC)",
                    Cost = 3000,
                    Description = "Unknown cost, 3000 is for travel really"
                },
                new AdoptionStep
                {
                    Order = 1,
                    Title = "Notarization",
                    Cost = 1500,
                    Description = ""
                },
                new AdoptionStep
                {
                    Order = 1,
                    Title = "Orphanage Donation",
                    Cost = 1000,
                    Description = ""
                },
                new AdoptionStep
                {
                    Order = 1,
                    Title = "Visas",
                    Cost = 230,
                    Description = ""
                },
                new AdoptionStep
                {
                    Order = 1,
                    Title = "Passports",
                    Cost = 300,
                    Description = ""
                },
                new AdoptionStep
                {
                    Order = 1,
                    Title = "Staying in Ukraine",
                    Cost = 3000,
                    Description = "No idea real cost here, but I think the stay will be about 1 month. Court, 10 day waiting period, and 2 weeks for the US Visa process."
                },
            };

        }

    }

    public class AdoptionStep
    {
        public int Order { get; set; }
        public string Title { get; set; }

        public decimal Cost { get; set; }

        public string Description { get; set; }
    }
}