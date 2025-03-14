using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;
namespace MvcMovie.Controllers
{
    public class PersionController:Controller
{
    public IActionResult Index()
    {
         return View();
    }
   [ HttpPost] 
   public IActionResult Index(Persion ps)
   {
    string strOutput =" Xin chao"+ ps.PersionId+ "-"+ps.Fullname +"-" + ps.Address;
    ViewBag.infoPerson= strOutput;
    return View();
   }
}
}