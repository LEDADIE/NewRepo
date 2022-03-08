using BulkyBookWeb.Data;
using BulkyBookWeb.Models;

using Microsoft.AspNetCore.Mvc;

namespace BulkyBookWeb.Controllers;

public class CategoryController : Controller
{
    private readonly ApplicationDbContext _db;

    public CategoryController(ApplicationDbContext db)
    {
        _db = db;
    }

    //GET
    public IActionResult Create()
    {
        return View();
    }

    //POST
    [HttpPost]
    [AutoValidateAntiforgeryToken]
    public IActionResult Create(Category obj)
    {
        if (obj.Name == obj.Displayorder.ToString())
        {
            ModelState.AddModelError("name", "The Displayorder cannot exactly match the Name.");
        }

        if (ModelState.IsValid)
        {
            _db.Categories.Add(obj);
            _db.SaveChanges();

            TempData["success"] = "Category created successfully";

            return RedirectToAction("Index");
        }
        return View(obj);
    }

    //GET
    public IActionResult Delete(int? Id)
    {
        if (Id == null || Id == 0) return NotFound();

        var categoryFromDB = _db.Categories.Find(Id);
        //var categoryFromDbFirst = _db.Categories.FirstOrDefault(u => u.CategoryId == id);
        //var categoryFromDbSingle = _db.Categories.SingleOrDefault(u => u.CategoryId == id);

        if (categoryFromDB == null) return NotFound();

        return View(categoryFromDB);
    }

    //POST
    [HttpPost, ActionName("Delete")]
    [AutoValidateAntiforgeryToken]
    public IActionResult DeletePOST(int? CategoryId)
    {
        var obj = _db.Categories.Find(CategoryId);

        if (obj == null) return NotFound();

        _db.Categories.Remove(obj);
        _db.SaveChanges();

        TempData["success"] = "Category deleted successfully";

        return RedirectToAction("Index");
    }

    //GET
    public IActionResult Edit(int? Id)
    {
        if (Id == null || Id == 0) return NotFound();

        var categoryFromDB = _db.Categories.Find(Id);
        //var categoryFromDbFirst = _db.Categories.FirstOrDefault(u => u.CategoryId == id);
        //var categoryFromDbSingle = _db.Categories.SingleOrDefault(u => u.CategoryId == id);

        if (categoryFromDB == null) return NotFound();

        return View(categoryFromDB);
    }

    //POST
    [HttpPost]
    [AutoValidateAntiforgeryToken]
    public IActionResult Edit(Category obj)
    {
        if (obj.Name == obj.Displayorder.ToString())
        {
            ModelState.AddModelError("name", "The Displayorder cannot exactly match the Name.");
        }

        if (ModelState.IsValid)
        {
            _db.Categories.Update(obj);
            _db.SaveChanges();

            TempData["success"] = "Category updated successfully";

            return RedirectToAction("Index");
        }
        return View(obj);
    }

    public IActionResult Index()
    {
        IEnumerable<Category> objcategoryList = _db.Categories.ToList();
        return View(objcategoryList);
    }
}