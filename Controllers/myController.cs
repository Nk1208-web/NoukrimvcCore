using aspdotnetcore.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using noukri.Repositry;

namespace NoukrimvcCore.Controllers
{
    public class myController : Controller
    {
        // GET: myController
        private readonly Noukri_IRepostry _iRepostry1;
        public myController(Noukri_IRepostry iRepostry)
        {
            _iRepostry1= iRepostry;

        }
        public ActionResult Index(methodDTO methodDTO)
        {
            var obj = _iRepostry1.GetData();
            return View(obj);
        }

        // GET: myController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: myController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: myController/Create
        [HttpPost]
      
        public ActionResult Create(methodDTO dto)
        {
            _iRepostry1.addData(dto);
            return RedirectToAction("Create","my");
        }

        // GET: myController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: myController/Edit/5
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

        // GET: myController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: myController/Delete/5
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
