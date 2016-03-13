using Microsoft.AspNet.Mvc;

namespace ReactDotNet.Controllers {
    public class HomeController: Controller {

        public ActionResult Hello() {
            return View();
        }
    }
}