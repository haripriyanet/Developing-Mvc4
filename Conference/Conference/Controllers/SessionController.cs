using Conference.Models;
using Conference.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Conference.Controllers
{

    public class SessionController : Controller
    {
        // GET: Session
        public ActionResult Index()
        {
            List<Session> sessions = SessionService.GetSessionList();
            return View(sessions);
        }

        //  Get: Session/Create
        public ActionResult Create()
        {
            return View();
        }

        //  Post: Session/Create
        [HttpPost]
        public ActionResult Create(Session session)
        {
            if (!ModelState.IsValid)
            {
                return View(session);
            }
            using (var ctx = new ConferenceContext())
            {
                try
                {
                    SessionService.AddSession(session);
                    TempData["Message"] = "Created" + session.Title;
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("Error", ex.Message);
                    return View(session);
                }
            }
            return RedirectToAction("Index");
        }

    }

}