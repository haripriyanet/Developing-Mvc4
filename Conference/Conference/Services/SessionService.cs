using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Conference.Models;

namespace Conference.Services
{

    class SessionService
    {

        public static List<Session> GetSessionList()
        {
            List<Session> sessions;
            using (ConferenceContext ctx = new ConferenceContext())
            {
                sessions = ctx.Sessions.ToList();
            }
            if (sessions == null)
            {
                return null;
            }
            return sessions;
        }

        public static void AddSession(Session session)
        {
            using (ConferenceContext ctx = new ConferenceContext())
            {
                ctx.Sessions.Add(session);
                ctx.SaveChanges();
            }
        }

    }

}
