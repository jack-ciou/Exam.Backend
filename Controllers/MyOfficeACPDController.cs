using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Exam.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MyOfficeACPDController : Controller
    {
        // GET: MyOfficeACPDController
        public ActionResult Index()
        {
            return View();
        }

        // GET: MyOfficeACPDController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MyOfficeACPDController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MyOfficeACPDController/Create
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

        // GET: MyOfficeACPDController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MyOfficeACPDController/Edit/5
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

        // GET: MyOfficeACPDController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MyOfficeACPDController/Delete/5
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
