using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        // GET: /HelloWorld/

        public ActionResult Index()
        {
            // return "This is my <b>default</b> action...";
            // if we dont specify View name it will use Index from Views/HelloWorld 
            return View();
        }

        //
        // GET: /HelloWorld/Welcome/

        public string Welcome(string name, int ID = 1)
        {
            return HttpUtility.HtmlEncode("This is the Welcome action method..." + name + " " + ID);
        }
    }
}

