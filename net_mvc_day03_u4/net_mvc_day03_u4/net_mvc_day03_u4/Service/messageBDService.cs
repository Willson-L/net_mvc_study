using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace net_mvc_day03_u4.Service
{
    public class messageBDService
    {
        public net_mvc_day03_u4.Models.messageEntities db = new Models.messageEntities();

        public List<Models.Article> GetData() {
            return db.Article.ToList();
        }
        public void DBSerivce(string Article_title,string Content) {
            Models.Article NewData = new Models.Article();
            NewData.Title = Article_title;
            NewData.Content = Content;
            NewData.time = DateTime.Now;

            db.Article.Add(NewData);
            db.SaveChanges();
        }
    }
}