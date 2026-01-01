using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ITAssetManagement.Data;
using ITAssetManagement.Models;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace ITAssetManagement.Controllers
{
  public class AssetsController : Controller
  {
    private readonly ApplicationDbContext _context;

    public AssetsController(ApplicationDbContext context)
    {
      _context = context;
    }

    // GET: Assets
    public async Task<IActionResult> Index()
    {
      var assets = _context.Assets
          .Include(a => a.Employee);

      return View(await assets.ToListAsync());
    }

    // GET: Assets/Details/5
    public async Task<IActionResult> Details(int? id)
    {
      if (id == null) return NotFound();

      var asset = await _context.Assets.FirstOrDefaultAsync(a => a.Id == id);
      if (asset == null) return NotFound();

      return View(asset);
    }

    // GET: Assets/Create
    public IActionResult Create()
    {
      ViewData["EmployeeId"] = new SelectList(
          _context.Employees, "Id", "FullName"
      );

      return View();
    }


    // POST: Assets/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Asset asset)
    {
      if (ModelState.IsValid)
      {
        _context.Add(asset);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
      }

      ViewData["EmployeeId"] = new SelectList(
          _context.Employees, "Id", "FullName", asset.EmployeeId
      );

      return View(asset);
    }


    // GET: Assets/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
      if (id == null) return NotFound();

      var asset = await _context.Assets.FindAsync(id);
      if (asset == null) return NotFound();

      ViewData["EmployeeId"] = new SelectList(
          _context.Employees, "Id", "FullName", asset.EmployeeId
      );

      return View(asset);
    }


    // POST: Assets/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, Asset asset)
    {
      if (id != asset.Id) return NotFound();

      if (ModelState.IsValid)
      {
        _context.Update(asset);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
      }

      ViewData["EmployeeId"] = new SelectList(
          _context.Employees, "Id", "FullName", asset.EmployeeId
      );

      return View(asset);
    }


    // GET: Assets/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
      if (id == null) return NotFound();

      var asset = await _context.Assets.FirstOrDefaultAsync(a => a.Id == id);
      if (asset == null) return NotFound();

      return View(asset);
    }

    // POST: Assets/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
      var asset = await _context.Assets.FindAsync(id);
      if (asset != null)
      {
        _context.Assets.Remove(asset);
        await _context.SaveChangesAsync();
      }
      return RedirectToAction(nameof(Index));
    }
  }
}
