
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CarInsurance.Models;
using CarInsurance.Data;

namespace CarInsurance.Controllers;

public class InsureesController(CarInsuranceContext context) : Controller
{
    private readonly CarInsuranceContext _context = context;

    // GET: INSUREES
    public async Task<IActionResult> Index()    
    {
        return View(await _context.Insurees.ToListAsync());
    }

    // GET: INSUREES/Details/5
    public async Task<IActionResult> Details(System.Guid? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var insuree = await _context.Insurees
            .FirstOrDefaultAsync(m => m.Id == id);
        if (insuree == null)
        {
            return NotFound();
        }

        return View(insuree);
    }

    // GET: INSUREES/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: INSUREES/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insurees insuree)
    {
        if (ModelState.IsValid)
        {
            insuree.Quote = CalculateQuote(insuree);

            _context.Add(insuree);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(insuree);
    }

    // GET: INSUREES/Edit/5
    public async Task<IActionResult> Edit(System.Guid? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var insuree = await _context.Insurees.FindAsync(id);
        if (insuree == null)
        {
            return NotFound();
        }
        return View(insuree);
    }

    // POST: INSUREES/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(System.Guid? id, [Bind("Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insurees insuree)
    {
        if (id != insuree.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                insuree.Quote = CalculateQuote(insuree);

                _context.Update(insuree);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InsureeExists(insuree.Id))
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
        return View(insuree);
    }

    // GET: INSUREES/Delete/5
    public async Task<IActionResult> Delete(System.Guid? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var insuree = await _context.Insurees
            .FirstOrDefaultAsync(m => m.Id == id);
        if (insuree == null)
        {
            return NotFound();
        }

        return View(insuree);
    }

    // POST: INSUREES/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(System.Guid? id)
    {
        var insuree = await _context.Insurees.FindAsync(id);
        if (insuree != null)
        {
            _context.Insurees.Remove(insuree);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool InsureeExists(System.Guid? id)
    {
        return _context.Insurees.Any(e => e.Id == id);
    }

    private static decimal CalculateQuote(Insurees insuree)
    {
        decimal quote = 50;

        // Age
        DateOnly today = DateOnly.FromDateTime(DateTime.Today);

        int age = today.Year - insuree.DateOfBirth.Year;

        if (today < insuree.DateOfBirth.AddYears(age))
            age--;

        if (age <= 18)
            quote += 100;
        else if (age >= 19 && age <= 25)
            quote += 50;
        else
            quote += 25;

        // Car Year
        if (insuree.CarYear < 2000)
            quote += 25;

        if (insuree.CarYear > 2015)
            quote += 25;

        // Porsche
        if (!string.IsNullOrEmpty(insuree.CarMake) &&
            insuree.CarMake.Equals("Porsche", StringComparison.OrdinalIgnoreCase))
        {
            quote += 25;

            if (!string.IsNullOrEmpty(insuree.CarModel) &&
                insuree.CarModel.Equals("911 Carrera", StringComparison.OrdinalIgnoreCase))
            {
                quote += 25;
            }
        }

        // Speeding Tickets
        quote += insuree.SpeedingTickets * 10;

        // DUI
        if (insuree.DUI)
            quote *= 1.25m;

        // Full Coverage
        if (insuree.CoverageType)
            quote *= 1.50m;

        return Math.Round(quote, 2);
    }

    public async Task<IActionResult> Admin()
    {
        var insurees = await _context.Insurees.ToListAsync();

        return View(insurees);
    }
}
