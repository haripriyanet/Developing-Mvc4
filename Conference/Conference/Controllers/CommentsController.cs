using Conference.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Conference.Controllers
{
    
    public class CommentsController : Controller
    {
        ConferenceContext ctx = new ConferenceContext();
        // GET: Comments
        public PartialViewResult _GetForSession(int sessionId)
        {
            ViewBag.SessionId = sessionId;
            List<Comment> Comments = ctx.Comments
                .Where(c => c.SessionId == sessionId).ToList();
            return PartialView("_GetForSession", Comments);
        }

        [ChildActionOnly()]
        public PartialViewResult _CommentForm(int sessionId)
        {
            Comment comment = new Comment { SessionId = sessionId };
            return PartialView("_CommentForm", comment);
        }

        [ValidateAntiForgeryToken]
        public PartialViewResult _Submit(Comment comment)
        {
            ctx.Comments.Add(comment);
            ctx.SaveChanges();
            List<Comment> Comments = ctx.Comments
                .Where(c => c.SessionId == comment.SessionId).ToList();
            ViewBag.SessionId = comment.SessionId;
            return PartialView("_GetForSession", Comments);
        }
    }

}