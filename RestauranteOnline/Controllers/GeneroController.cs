using RestauranteOnline.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        public ActionResult Inserir()
        {
            return View();

        }
        [HttpPost]
        public ActionResult Inserir(Genero genero)
        {
            if (ModelState.IsValid)
            {
                db.Genero.Add(genero);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(genero);
        }

        public ActionResult Alterar(long id)
        {
            Genero genero = db.Genero.Find(id);

            return View(genero);

        }
        [HttpPost]
        public ActionResult Alterar(Genero genero)
        {
            if (ModelState.IsValid)
            {
                db.Entry(genero).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(genero);

        }

        public ActionResult Excluir(long id)
        {
            Genero genero = db.Genero.Find(id);

            return View(genero);

        }
        [HttpPost, ActionName("Excluir")]
        public ActionResult EfetivaExcluisao(long id)
        {
            try
            {
                Genero genero = db.Genero.Find(id);
                db.Genero.Remove(genero);
                db.SaveChanges();
                return RedirectToAction("Index");

            }
            catch
            {
                return RedirectToAction("ErroExcluir");

            }

        }
        public ActionResult ErroExcluir()
        {
            return View();

        }
    }
}