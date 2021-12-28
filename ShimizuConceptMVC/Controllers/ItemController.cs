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
            IEnumerable<Item> objectsList = _db.Items;
            return View(objectsList);
        }
    }
}
