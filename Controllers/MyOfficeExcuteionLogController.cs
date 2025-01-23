using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Exam.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MyOfficeExcuteionLogController : Controller
    {
        // GET: MyOfficeExcuteionLogController
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        // GET: MyOfficeExcuteionLogController/Details/5
        [HttpGet]
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MyOfficeExcuteionLogController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MyOfficeExcuteionLogController/Create
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

        // GET: MyOfficeExcuteionLogController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MyOfficeExcuteionLogController/Edit/5
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

        // GET: MyOfficeExcuteionLogController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MyOfficeExcuteionLogController/Delete/5
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
