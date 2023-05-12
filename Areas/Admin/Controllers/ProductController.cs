using Fiorello.DAL;
using Fiorello.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Fiorello.Areas.Admin.Controllers
{
    [Area("admin")]
    public class ProductController : Controller
    {
        private readonly FiorelloDbContext _fiorelloDbContext;
        public ProductController(FiorelloDbContext fiorelloDbContext)
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
            if (!ModelState.IsValid) { return View(); }
            await _fiorelloDbContext.products.AddAsync(product);
            await _fiorelloDbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
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
            Product? productToUpdate = await _fiorelloDbContext.products
                .AsNoTracking().Where(p=>p.Id==id).FirstOrDefaultAsync();
            if (productToUpdate == null)
            {
                return NotFound();
            }
            product.Id = productToUpdate.Id;
            _fiorelloDbContext.products.Update(product);
            _fiorelloDbContext.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
