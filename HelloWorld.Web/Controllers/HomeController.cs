namespace HelloWorld.Web.Controllers
{
    using System.Web.Mvc;
    using Models;

    /// <summary>
    /// Контроллер нашего приложения.
    /// </summary>
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        /// <summary>
        /// Отображаем нашу страницу.
        /// </summary>
        /// <returns>Представление нашего приложения.</returns>
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Home/World

        /// <summary>
        /// Получить имя пользователя, обработать его и вернуть готовый JSON-объект.
        /// </summary>
        /// <param name="name">Имя пользователя.</param>
        /// <returns>Готовый JSON-объект.</returns>
        public JsonResult World(string name)
        {
            return Json(new Hello(name), JsonRequestBehavior.AllowGet);
        }
    }
}
