using Microsoft.AspNetCore.Mvc;
using ShimizuConceptMVC.Data;
using ShimizuConceptMVC.Models;

namespace ShimizuConceptMVC.Controllers
{
    public class ItemController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ItemController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<ItemModel> objectsList = _db.Items;
            return View(objectsList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ItemModel obj)
        {
            if (ModelState.IsValid)
            {
                _db.Items.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(ItemModel obj)
        {
            if (ModelState.IsValid)
            {
                _db.Items.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(obj);
        }


        public IActionResult UpdateView(int? id)
        {
            if (id == null || id == 0) return NotFound();
            var obj = _db.Items.Find(id);
            if (obj == null) return NotFound();

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int? id)
        {
            var obj = _db.Items.Find(id);
            if (obj == null) return NotFound();
            
            _db.Items.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        
        public IActionResult DeleteView(int? id)
        {
            if (id == null || id == 0) return NotFound();
            var obj = _db.Items.Find(id);
            if (obj == null) return NotFound();

            return View(obj);
        }


    }
}
