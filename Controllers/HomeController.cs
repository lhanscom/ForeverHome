using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace ForeverHomeNg.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(GetModel());
        }

        private HomeModel GetModel()
        {
            var AdoptionSteps = new List<AdoptionStep>()
            {
                new AdoptionStep
                {
                    Order = 0,
                    Title = "First Meet With Adoption Agency",
                    Cost = 150,
                    Description = "",
                    Completed = true
                },

                new AdoptionStep
                {
                    Order = 1,
                    Title = "Home Study",
                    Cost = 3000,
                    Description = "",
                    Completed = false
                },
                new AdoptionStep
                {
                    Order = 3,
                    Title = "Agency Sign off",
                    Cost = 1500,
                    Description = "The HAGUE approved adoption agency needs to give it's blessing."
                },
                new AdoptionStep()
                {
                    Order = 2,
                    Title = "Be found Eligible (I600a)",
                    Cost = 750,
                    Description = "The US governement determines if you meet their requirements"
                },
                new AdoptionStep()
                {
                    Order = 6,
                    Title = "Child Medical Exam",
                    Cost = 110,
                    Description = ""
                },
                new AdoptionStep
                {
                    Order = 4,
                    Title = "Facilitator",
                    Cost = 0,
                    Description = "Ask about this cost Yana https://www.facebook.com/yana.deman.7"
                },
                new AdoptionStep
                {
                    Order = 5,
                    Title = "Child Matching (SDAPRC)",
                    Cost = 3000,
                    Description = "Unknown cost, 3000 is for travel really"
                },
                new AdoptionStep
                {
                    Order = 4,
                    Title = "Notarization",
                    Cost = 1500,
                    Description = ""
                },
                new AdoptionStep
                {
                    Order = 5,
                    Title = "Orphanage Donation",
                    Cost = 1000,
                    Description = ""
                },
                new AdoptionStep
                {
                    Order = 7,
                    Title = "Visas",
                    Cost = 230,
                    Description = ""
                },
                new AdoptionStep
                {
                    Order = 4,
                    Title = "Passports",
                    Cost = 300,
                    Description = ""
                },
                new AdoptionStep
                {
                    Order = 5,
                    Title = "Staying in Ukraine",
                    Cost = 3000,
                    Description = "No idea real cost here, but I think the stay will be about 1 month. Court, 10 day waiting period, and 2 weeks for the US Visa process."
                }
            };


            decimal completedAmt = AdoptionSteps.Where(s => s.Completed).Sum(s => s.Cost);
            decimal totalAmt = AdoptionSteps.Sum(s => s.Cost);

            return new HomeModel() { AdoptionSteps = AdoptionSteps.OrderBy(s => s.Order).ToList(), CompletedPercent = ((completedAmt / totalAmt) * 100) };

        }

    }

    public class HomeModel
    {
        public List<AdoptionStep> AdoptionSteps { get; set; }

        public decimal CompletedPercent { get; set; }

    }

    public class AdoptionStep
    {
        public int Order { get; set; }
        public string Title { get; set; }

        public decimal Cost { get; set; }

        public string Description { get; set; }

        public bool Completed { get; set; }
        
    }
}