using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using tp3.Models;

namespace tp3.Controllers
{
    public class LivreController : Controller
    {
        public LivreController()
        {
            Livre l1 = new Livre(1, "L’étranger", "Albert Camus", "Cet\rouvrage\rmet en\rscène un\rpersonnage\rprincipal\rqui est\r\naussi le\rnarrateur,\rMeursault.", "1789654", new DateTime(1942 / 01 / 01), 25);
            Livre.Livres.Add(l1);
            Livre l2 = new Livre(2, "Voyage au\r\nbout de la\r\nnuit", "Louis-\r\nFerdinand\r\nCéline", "Cet\r\nouvrage est\r\nsouvent\r\nconsidéré\r\ncomme un\r\nexemple du\r\ncourant\r\nnihiliste.", "6593596", new DateTime(1932 / 01 / 01), 30);
            Livre.Livres.Add(l2);
        }
        // GET: LivreController
        public ActionResult Index()
        {
            return View(Livre.Livres);
        }

        // GET: LivreController/Details/5
        public ActionResult Details(int id)
        {
            Livre livre1 = null;
            foreach(Livre livre in Livre.Livres)
                if (livre.Id == id)
                {
                    livre1 = livre; break;  
                }
            return View(livre1);
        }

        // GET: LivreController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LivreController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LivreController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LivreController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LivreController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LivreController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
