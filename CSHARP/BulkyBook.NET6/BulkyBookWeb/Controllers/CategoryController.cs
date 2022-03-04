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

    public IActionResult Index()
    {
        IEnumerable<Category> objcategoryList = _db.Categories.ToList();
        return View(objcategoryList);
    }
}