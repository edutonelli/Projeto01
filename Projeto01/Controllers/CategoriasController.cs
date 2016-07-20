using Projeto01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projeto01.Controllers
{
    public class CategoriasController : Controller
    {
        private static IList<Categoria> categorias = new List<Categoria>()
        {
            new Categoria() {CategoriaId = 1, Nome = "Notebook" },
            new Categoria() {CategoriaId = 2, Nome = "Impressora" },
            new Categoria() {CategoriaId = 3, Nome = "Tablet" },
            new Categoria() {CategoriaId = 4, Nome = "Cabo" },
            new Categoria() {CategoriaId = 5, Nome = "bola" },
        };

        // GET: Categorias
        public ActionResult Index()
        {
            return View(categorias);
        }
    }
}