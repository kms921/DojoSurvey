using System; 
using Microsoft.AspNetCore.Mvc; 
using DojoSurvey.Models; 

namespace DojoSurvey.Controllers
{
     public class HomeController : Controller 
    {
        [HttpGet("")]

        public ViewResult Index ()
        {
            return View("Index");
        }

        [HttpPost("submit")]
        public ViewResult Result(Survey FromForm)
       
        {
           if (ModelState.IsValid) 
            {
                return View("Results", FromForm);  
            }
            else
            {
                return Index();
            }
        }

       

    }
}