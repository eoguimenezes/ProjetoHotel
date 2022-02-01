using ProjetoHotel.Models;
using System;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace ProjetoHotel.Controllers
{
    public class QuartoController : Controller
    {
        QuartoDbContext db;
        public QuartoController()
        {
            db = new QuartoDbContext();
        }
        // GET: Quartos
        public ActionResult Index()
        {
            var Quarto = db.Quarto.ToList();
            return View(Quarto);
        }
    }
}