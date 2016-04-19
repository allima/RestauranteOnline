using RestauranteOnline.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestauranteOnline.Controllers
{
    public class RestauranteController : Controller
    {
        private RestauranteBDEntities db = new RestauranteBDEntities();

        public ActionResult Index()
        {
            var restaurantes = db.Restaurante.Include("Bairro").Include("Genero").ToList();
            return View(restaurantes);
        }

        public ActionResult Inserir()
        {
            ViewBag.IDBairro = new SelectList(db.Bairro, "IDBairro", "Nome");
            ViewBag.IDGenero = new SelectList(db.Genero, "IDGenero", "Descricao");
            return View();

        }
        [HttpPost]
        public ActionResult Inserir(Restaurante restaurante)
        {
            if (ModelState.IsValid)
            {
                db.Restaurante.Add(restaurante);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IDBairro = new SelectList(db.Bairro, "IDBairro", "Nome", restaurante.IDBairro);
            ViewBag.IDGenero = new SelectList(db.Genero, "IDGenero", "Descricao", restaurante.IDGenero);
            return View(restaurante);
        }

        public ActionResult Alterar(long id)
        {

            Restaurante restaurante = db.Restaurante.Find(id);
            ViewBag.IDBairro = new SelectList(db.Bairro, "IDBairro", "Nome", restaurante.IDBairro);
            ViewBag.IDGenero = new SelectList(db.Genero, "IDGenero", "Descricao", restaurante.IDGenero);
            return View(restaurante);

        }
        [HttpPost]
        public ActionResult Alterar(Restaurante restaurante)
        {
            if (ModelState.IsValid)
            {
                db.Entry(restaurante).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IDBairro = new SelectList(db.Bairro, "IDBairro", "Nome", restaurante.IDBairro);
            ViewBag.IDGenero = new SelectList(db.Genero, "IDGenero", "Descricao", restaurante.IDGenero);
            return View(restaurante);

        }

        public ActionResult Excluir(long id)
        {
            Restaurante restaurante = db.Restaurante.Find(id);

            return View(restaurante);

        }
        [HttpPost, ActionName("Excluir")]
        public ActionResult EfetivaExcluisao(long id)
        {
            try
            {
                Restaurante restaurante = db.Restaurante.Find(id);
                db.Restaurante.Remove(restaurante);
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