using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TechStoreInventory.Models;
using TechStoreInventory.Data;

namespace TechStoreInventory.Controllers;

public class ProductsController(InventoryContext context) : Controller
{
    private readonly InventoryContext _context = context;

    // GET: PRODUCTSS
    public async Task<IActionResult> Index()    
    {
        return View(await _context.Products.ToListAsync());
    }

    // GET: PRODUCTSS/Details/5
    public async Task<IActionResult> Details(Guid? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var products = await _context.Products
            .FirstOrDefaultAsync(m => m.Id == id);
        if (products == null)
        {
            return NotFound();
        }

        return View(products);
    }

    // GET: PRODUCTSS/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: PRODUCTSS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,Name,Description,Type,Price")] Products products)
    {
        if (ModelState.IsValid)
        {
            _context.Add(products);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(products);
    }

    // GET: PRODUCTSS/Edit/5
    public async Task<IActionResult> Edit(Guid? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var products = await _context.Products.FindAsync(id);
        if (products == null)
        {
            return NotFound();
        }
        return View(products);
    }

    // POST: PRODUCTSS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(Guid? id, [Bind("Id,Name,Description,Type,Price")] Products products)
    {
        if (id != products.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(products);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductsExists(products.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction(nameof(Index));
        }
        return View(products);
    }

    // GET: PRODUCTSS/Delete/5
    public async Task<IActionResult> Delete(Guid? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var products = await _context.Products
            .FirstOrDefaultAsync(m => m.Id == id);
        if (products == null)
        {
            return NotFound();
        }

        return View(products);
    }

    // POST: PRODUCTSS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(Guid? id)
    {
        var products = await _context.Products.FindAsync(id);
        if (products != null)
        {
            _context.Products.Remove(products);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool ProductsExists(Guid? id)
    {
        return _context.Products.Any(e => e.Id == id);
    }
}
