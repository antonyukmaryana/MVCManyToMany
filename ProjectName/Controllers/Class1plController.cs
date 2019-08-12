using Microsoft.AspNetCore.Mvc;
using ProjectName.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ProjectName.Controllers
{
  public class Class1PlController : Controller
  {
    private readonly ProjectNameContext _db;

    public Class1plController(ProjectNameContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Class1> model = _db.Class2.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Class1 class1)
    {
      _db.Class1pl.Add(class1);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
{
    var thisClass1 = _db.Class1pl
        .Include(category => category.Items)
        .ThenInclude(join => join.Item)
        .FirstOrDefault(category => category.CategoryId == id);
    return View(thisCategory);
}

    public ActionResult Edit(int id)
    {
      var thisCategory = _db.Categories.FirstOrDefault(category => category.CategoryId == id);
      return View(thisCategory);
    }

    [HttpPost]
    public ActionResult Edit(Category category)
    {
      _db.Entry(category).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var thisCategory = _db.Categories.FirstOrDefault(category => category.CategoryId == id);
      return View(thisCategory);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisCategory = _db.Categories.FirstOrDefault(category => category.CategoryId == id);
      _db.Categories.Remove(thisCategory);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}
