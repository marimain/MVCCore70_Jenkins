using Microsoft.AspNetCore.Mvc;
using MVCCore70_Jenkins.Models;

namespace MVCCore70_Jenkins.Controllers
{
    public class PatientController : Controller
    {
        List<PatientDetail> pats = new List<PatientDetail>();

        public ActionResult Index()
        {
            pats.Add(new PatientDetail { PatientID = 100, FirstName = "Mike", LastName = "Tyson", DOB = Convert.ToDateTime("2021-05-06") });
            pats.Add(new PatientDetail { PatientID = 200, FirstName = "Brind", LastName = "Smith", DOB = Convert.ToDateTime("2016-01-30") });
            pats.Add(new PatientDetail { PatientID = 300, FirstName = "Woo", LastName = "Micrare", DOB = Convert.ToDateTime("1968-12-06") });
            pats.Add(new PatientDetail { PatientID = 400, FirstName = "Lynch", LastName = "William", DOB = Convert.ToDateTime("1998-01-26") });

            PatientMetricsViewModel vm = new PatientMetricsViewModel();
            vm.Patients = pats;
            return View("Index", vm);

        }
    }
}
