using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    { 
        // GET: /HelloWorld/
        public ActionResult Index()
        {
            return View();
        } 
[HttpPost]
public IActionResult Index(string full name, string address)
{
    string strOutput="xin chào"+full name+"đến từ"+ address;
    ViewBag.Message= strOutput;
    return View();
}
        // GET: /HelloWorld/Welcome/ 

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}

