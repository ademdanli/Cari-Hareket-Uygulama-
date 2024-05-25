using Microsoft.AspNetCore.Mvc;
using NewCari.BLL.Abstract;
using NewCari.Core.Concrete;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace NewCariWebUI.Controllers
{
    public class MusteriController : Controller
    {
        private readonly IMusteriService _musteriService;

        public MusteriController(IMusteriService musteriService)
        {
            _musteriService = musteriService;
        }

        public IActionResult Index()
        {
            var musteriList = _musteriService.GetAll();
            return View(musteriList);
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.CariHareketTurleri = Enum.GetValues(typeof(CariHareketTuru))
                                             .Cast<CariHareketTuru>()
                                             .Select(e => new SelectListItem
                                             {
                                                 Value = e.ToString(),
                                                 Text = e.ToString()
                                             })
                                             .ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Add(Musteri musteri)
        {
            if (ModelState.IsValid)
            {
                _musteriService.Add(musteri);
                return RedirectToAction("Index");
            }

            ViewBag.CariHareketTurleri = Enum.GetValues(typeof(CariHareketTuru))
                                             .Cast<CariHareketTuru>()
                                             .Select(e => new SelectListItem
                                             {
                                                 Value = e.ToString(),
                                                 Text = e.ToString()
                                             })
                                             .ToList();
            return View(musteri);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var musteri = _musteriService.GetById(id);
            if (musteri == null)
            {
                return NotFound();
            }
            return View(musteri);
        }

        [HttpPost]
        public IActionResult Edit(Musteri musteri)
        {
            if (ModelState.IsValid)
            {
                _musteriService.Update(musteri);
                return RedirectToAction("Index");
            }
            return View(musteri);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var musteri = _musteriService.GetById(id);
            if (musteri == null)
            {
                return NotFound();
            }
            return View(musteri);
        }

        [HttpPost]
        public IActionResult Delete(Musteri musteri)
        {
            _musteriService.Delete(musteri.Id);
            return RedirectToAction("Index");
        }
    }
}