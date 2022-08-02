using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Npgsql;
using petAdoptionApi.Models;
using petAdoptionApi.Models.Start_Model;
using PowerArgs;

namespace petAdoptionApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PetController : Controller
    {
        private readonly ILogger<PetController> _logger;
        private readonly PetAdoptionContext _context;

        public PetController(
            ILogger<PetController> logger,
            PetAdoptionContext context
        )
        {
            _context = context;
            _logger = logger;
        }


        /// <summary>
        /// Esta funcao serve para ver se vc fez merda ou nao 
        /// </summary>
        /// <param name="id">Identificator unique for each Pet</param>
        /// <returns></returns>
        [HttpGet("GetTest")]
        public Pet GetPet(int id)
        {
            Pet pet = _context.pets.Where(b => b.Id == id).FirstOrDefault();

            if (pet == null)
                throw new KeyNotFoundException($"Pet with id {id} not found");

            return pet;
        }

        [HttpPost("v1/create")]
        public HttpResponseMessage Create(Pet pet)
        {
            _context.pets.Add(pet);
            _context.SaveChanges();
            return new HttpResponseMessage(System.Net.HttpStatusCode.OK);
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
