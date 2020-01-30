using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using net_mvc_day04_u6.Models;
namespace net_mvc_day04_u6.Controllers
{
    public class temp
    {
        GuestbookEntities report = new GuestbookEntities();
        public class GuestbookDB {
            GuestbookEntities db = new GuestbookEntities();

            public void Create(string name, string content)
            {
                Contents NewData = new Contents();
                NewData.name = name;
                NewData.comtents = content;
                db.Contents.Add(NewData);
                db.SaveChanges();
            }
            public void Create(Contents NewData)
            {
                db.Contents.Add(NewData);
                db.SaveChanges();
            }
            public bool Update(int id, string name, string content)
            {
                Contents Data = db.Contents.Find(id);
                if (Data != null)
                {
                    Data.name = name;
                    Data.comtents =content;
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
            public bool Update(Contents UpdataData) {
                Contents Data = db.Contents.Find(UpdataData);
                if (Data != null)
                {
                    Data.name = UpdataData.name;
                    Data.comtents = UpdataData.comtents;
                    db.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            public bool Delete(int id)
            {
                Contents DeleteData = db.Contents.Find(id);
                if (DeleteData != null)
                {
                    db.Contents.Remove(DeleteData);
                    db.SaveChanges();
                    return true;
                }
                else {
                    return false;
                }
            }
            public List<Contents> GetList() {
                List<Contents> ContentList = db.Contents.ToList();
                return ContentList;
            }
            public Contents GetContent(int id) {
                Contents Data = db.Contents.Find();
                return Data;
            }
        }
    }
}