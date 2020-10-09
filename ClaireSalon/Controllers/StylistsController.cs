using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ClaireSalon.Models;
using System.Linq;

namespace ClaireSalon.Controllers
{
  public class ClaireSalonController : Controller
  {
    private readonly ClaireSalonContext _db;

    public StylistsController(ClaireSalonContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Stylist> model = _db.Stylist.ToList();
      return View(model);
    }
  }
}