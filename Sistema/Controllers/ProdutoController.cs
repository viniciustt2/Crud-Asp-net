using Sistema.Context;
using Sistema.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sistema.Controllers
{
    public class ProdutoController : Controller
    {
        private LojaContext db = new LojaContext();
        
       
        
        // GET: Produto
        public ActionResult Index()
        {   
            return View(db.Produto.ToList());
        }

        // GET: Produto/Details/5
        public ActionResult Details(int id)
        {
            var produto = db.Produto.Find(id);
            return View(produto);
        }

        // GET: Produto/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Produto/Create
        [HttpPost]
        public ActionResult Create(Produto produto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Produto.Add(produto);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

                return View(produto);

            }
            catch
            {
                return View(produto);
            }
        }

        // GET: Produto/Edit/5
        public ActionResult Edit(int id)
        {
            var produto = db.Produto.Find(id);
            return View(produto);
        }

        // POST: Produto/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Produto produto
            )
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(produto).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(produto);
            }
            catch
            {
                return View(produto);
            }
        }

        // GET: Produto/Delete/5
        public ActionResult Delete(int id)
        {
            var produto = db.Produto.Find(id);
            return View(produto);

        }

        // POST: Produto/Delete/5
        [HttpPost]
        public ActionResult Delete(int id , Produto produto1)
        {
            try
            {
                Produto produto = db.Produto.Find(id);
                db.Produto.Remove(produto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View(produto1);
            }
        }
    }
}
