using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using lab_10_finale_ori00.Models;
using lab_10_finale_ori00.Data;

namespace lab_10_finale_ori00.Controllers
{
    public class HotelController : Controller
    {
        private readonly AppDbContext _context;

        public HotelController(AppDbContext context) 
        {
            _context = context;
        }
        [HttpGet]
        // GET: HotelController
        public ActionResult Index()
        {
            //ViewBag.hotels = _context.Hotel.ToList();
            var hotel = _context.Hotel.OrderBy(d => d.id).ToList();
            return View("index.cshtml");
        }

        // GET: HotelController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
        [HttpGet]
        public ActionResult CreateHotel() 
        {
            return View("createHotel.cshtml");
        }
        [HttpPost]
        // GET: HotelController/Create
        public async Task<ActionResult> Create(Hotel hotel)
        {
            if (ModelState.IsValid)
            {
                _context.Hotel.Add(hotel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hotel);
        }

        // POST: HotelController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HotelController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HotelController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        [HttpPost]
        // GET: HotelController/Delete/5
        public ActionResult Delete(int id)
        {
            Hotel hotel = _context.Hotel.Find(id);
            _context.Hotel.Remove(hotel);
            _context.SaveChanges();
            return RedirectToAction("index.cshtml");
        }

        // POST: HotelController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
