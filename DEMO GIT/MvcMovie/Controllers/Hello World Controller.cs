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
    //GET:/HelloWorld/Welcome/
    public string Welcome()
    {
        return "this is the  Welcom action method...";

    }
}
}