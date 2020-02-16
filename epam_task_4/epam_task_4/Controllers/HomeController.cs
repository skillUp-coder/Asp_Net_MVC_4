using epam_task_4.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using epam_task_4_data.Entities;
namespace epam_task_4.Controllers
{
    public class HomeController : Controller
    {
        private DataContext db = new DataContext();

        public ActionResult  Index()
        {
            //Articles Data
            IEnumerable<Article> _data =  db.Articles;
            ViewBag.Articles = _data;
            ViewBag.LoadMetaTag = BindMetaTag();

            return View();
        }

        [HttpGet]
        public ActionResult AddFeedback(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            var data = db.feedBackDatas;

            ViewBag.IdArticles = id;

            return View(data);
        }

        [HttpPost, ActionName("AddFeedback")]
        public ActionResult FeedBackConf(FeedBackData data)
        {

            db.feedBackDatas.Add(data);
            db.SaveChanges();

            return RedirectToAction("Display_FeedBack");
        }
        public ActionResult Display_FeedBack() 
        {
            
            var _allData = db.feedBackDatas;
            ViewBag.AllData = _allData;
            return View();
        }
        [HttpGet]
        public ActionResult Edit(int? id) 
        {
            if (id == null) 
            {
                return HttpNotFound();
            }
            var _id = db.feedBackDatas.Find(id);
            db.feedBackDatas.Remove(_id);
            db.SaveChanges();
            return View(_id);
        }
        [HttpPost]
        public ActionResult Edit(FeedBackData data) 
        {
            db.feedBackDatas.Add(data);
            db.SaveChanges();
            return RedirectToAction("Display_FeedBack");
        }

        public ActionResult Delete(int? id) 
        {
            if (id == null) 
            {
                return HttpNotFound();
            }
            var _id = db.feedBackDatas.Find(id);

            return View(_id);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteComment(int? id) 
        {
            if (id==null) 
            {
                return HttpNotFound();
            }
            var _id = db.feedBackDatas.Find(id);
            db.feedBackDatas.Remove(_id);
            db.SaveChanges();
            return RedirectToAction("Display_FeedBack");
        }


        public string Article_f(int? id)
        {
            Article _data = db.Articles.Find(id);

            return $@"<div>
                            
                        <h2>{_data.Title}</h2>
                        <br/>
                        <p>{_data.Text}</p>
                      </div>";
        }
        [HttpGet]
        public ActionResult Marks(int mark) 
        {
            string outdata = $"Mark: {mark}";
            return Content(outdata);
        }
        public string BindMetaTag()
        {
            System.Text.StringBuilder strDynamicMetaTag = new System.Text.StringBuilder();
            strDynamicMetaTag.AppendFormat(@"<meta content='{0}' name='Keywords'/>", "Dotnet-helpers");
            strDynamicMetaTag.AppendFormat(@"<meta content='{0}' name='Descption'/>", "creating meta tags dynamically in" + " asp.net mvc by dotnet-helpers.com");
            return strDynamicMetaTag.ToString();
        }
    }
}