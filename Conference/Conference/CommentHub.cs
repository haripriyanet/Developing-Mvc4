﻿using Conference.Models;
using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conference
{

    public class CommentHub : Hub
    {

        public void AddComment(int sessionid, string content)
        {
            using (var ctx = new ConferenceContext())
            {
                Comment comment = new Comment { SessionId = sessionid, Content = content };
                ctx.Comments.Add(comment);
                ctx.SaveChanges();

                Clients.Group(sessionid.ToString()).AddNewComment(content);
            }
        }

        public void Register (int sessionid)
        {
            using (var ctx = new ConferenceContext())
            {
                Groups.Add(ctx.Database.Connection.ConnectionString, sessionid.ToString());
            }
        }

    }

}
