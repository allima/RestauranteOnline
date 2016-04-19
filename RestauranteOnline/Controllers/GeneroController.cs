using RestauranteOnline.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestauranteOnline.Controllers
{
    public class GeneroController : Controller
    {
        private RestauranteBDEntities db = new RestauranteBDEntities();

        public ActionResult Index()
        {
            var restaurantes = db.Genero.ToList();
            return View(restaurantes);
        }
    }
}