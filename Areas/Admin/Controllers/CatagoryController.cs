using Fiorello.DAL;
using Fiorello.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Fiorello.Areas.Admin.Controllers
{
    [Area("admin")]
    public class CatagoryController : Controller
    {
        private readonly FiorelloDbContext _fiorelloDbContext;
        public CatagoryController(FiorelloDbContext fiorelloDbContext)
        {
            _fiorelloDbContext = fiorelloDbContext;
        }
        public IActionResult Index()
        {

            return View(_fiorelloDbContext.products);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Product product)
        {
            if (!ModelState.IsValid) { return View(product); }
            await _fiorelloDbContext.products.AddAsync(product);
            await _fiorelloDbContext.SaveChangesAsync();
            return View();
        }
        public async Task<IActionResult> Details(int id) { 
            Product? product =await _fiorelloDbContext.products.FindAsync(id);
            if (product==null)
            {
                return NotFound();
            }
            return View(product); 
        }
        public async Task<IActionResult> Delete(int id)
        {
            Product? product = await _fiorelloDbContext.products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            _fiorelloDbContext.products.Remove(product);
            await _fiorelloDbContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Edit(int id)
        {
            Product? product = await _fiorelloDbContext.products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id,Product product)
        {
            Product? productToUpdate = await _fiorelloDbContext.products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
        }
    }
}
