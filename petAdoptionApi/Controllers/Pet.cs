using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace petAdoptionApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PetController : Controller
    {
        private readonly ILogger<PetController> _logger;

        public PetController(ILogger<PetController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetTest")]
        public string Get()
        {
            _logger.LogError("ola");
            return "Testing please work, I just wanna coffee";
        }

        //// GET: Pet
        //public ActionResult Index()
        //{
        //    return View();
        //}

        //// GET: Pet/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: Pet/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Pet/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Pet/Edit/5
        //[HttpGet(Name = "Pet")]
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: Pet/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Pet/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: Pet/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
