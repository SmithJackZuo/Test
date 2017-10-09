using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CenterWebMake.Models;
using System.Data;
using System.Net;
using System.Data.Entity;
using CenterWebMake.Fliters;
using CenterWebMake.ViewModels;
using System.IO;
using CenterWebMake.ViewModels1;
using PagedList;
using CenterWebMake.ViewModels2;

namespace CenterWebMake.Controllers
{
    public class BackStageController : Controller
    {
        private Model123 db = new Model123();

        // GET: BackStage
        public ActionResult index()
        {
            //var model = db.CenterNewsCreate;//使CN接收数据
            //var model1 = db.Culturalexchanges;//使CN接收数据
            //var model2 = db.Culturalexchanges;//使CN接收数据
            //var model3 = db.Notice;//使CN接收数据
            //var model4 = db.AcademicExchange;//使CN接收数据
            //var model5 = db.PhotoControl;//使CN接收数据
            //var model6 = db.Labintroduce;//使CN接收数据
            Class17cs class17cs = new Class17cs();
            class17cs.CenterNewsCreate = db.CenterNewsCreate;
            class17cs.Culturalexchanges = db.Culturalexchanges;
            class17cs.AchievementShow = db.AchievementShows;
            class17cs.Notice = db.Notice;
            class17cs.AcademicExchange = db.AcademicExchange;
            class17cs.PhotoControl = db.PhotoControl;
            class17cs.Labintroduce = db.Labintroduce;
            return View(class17cs);
        }

        public ViewResult TestView()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [AuthorizePlus]
        public ActionResult Backindex()
        {
            Class17cs class17cs = new Class17cs();
            class17cs.Creater = Session["Creater"];
            var model = db.CenterNewsCreate;//使CN接收数据
            var model1 = db.Culturalexchanges;//使CN接收数据
            var model2 = db.AchievementShows;//使CN接收数据
            var model3 = db.Notice;//使CN接收数据
            var model4 = db.AcademicExchange;//使CN接收数据
            var model5 = db.PhotoControl;//使CN接收数据
            var model6 = db.Labintroduce;//使CN接收数据
            class17cs.CenterNewsCreate = model;
            class17cs.Culturalexchanges = model1;
            class17cs.AchievementShow = model2;
            class17cs.Notice = model3;
            class17cs.AcademicExchange = model4;
            class17cs.PhotoControl = model5;
            class17cs.Labintroduce = model6;
            Session["UserName"] = null;
            Session["password"] = null;
            return View(class17cs);
        }

        //[AuthorizePlus]
        //public ActionResult Backindex()
        //{
        //    //Class17cs class17cs = new Class17cs();
        //    //class17cs.Creater = Session["Creater"].ToString();
        //    return View();
        //}
        public ActionResult CenterNews()
        {
            return View();
        }

        public ActionResult LabIntroduce()
        {
            return View();
        }

        public ActionResult AchievementShow()
        {
            return View();
        }

        public ActionResult AcademicExchange()
        {
            return View();
        }

        public ActionResult CuturalActive()
        {
            return View();
        }

        public ActionResult Notice()
        {
            return View();
        }

        public ActionResult DataDisplay(string seletContent)
        {
            var mode0l6 = db.CenterNewsCreate;
            var mode0l7 = db.Culturalexchanges;
            var mode0l8 = db.AchievementShows;
            var mode0l9 = db.Notice;
            var mode020 = db.AcademicExchange;
            Class18 class18cs = new Class18();
            class18cs.CenterNewsCreate = mode0l6;
            class18cs.Culturalexchanges = mode0l7;
            class18cs.AchievementShow = mode0l8;
            class18cs.Notice = mode0l9;
            class18cs.AcademicExchange = mode020;
            return View(class18cs);
        }

        public ActionResult PhotoControl()
        {
            return View();
        }

        public ActionResult LeavingMessage()
        {
            return View();
        }

        public ActionResult TemplateViews(int Id, string type)
        {
            Class19cs class19cs = new Class19cs();
            switch (type)
            {
                case "News":
                    var model9 = db.CenterNewsCreate.FirstOrDefault(w => w.ID == Id); ;//使CN接收数据
                    class19cs.Title = model9.Title;
                    class19cs.PublishDate = model9.PublishDate;
                    class19cs.ContentText = model9.ContentText;
                    break;

                case "NOTICE":
                    var model1 = db.Notice.FirstOrDefault(w => w.ID == Id); ;//使CN接收数据
                    class19cs.Title = model1.Title;
                    class19cs.PublishDate = model1.PublishDate;
                    class19cs.ContentText = model1.ContentText;
                    break;

                case "AMTshow":
                    var model2 = db.AchievementShows.FirstOrDefault(w => w.ID == Id); ;//使CN接收数据
                    class19cs.Title = model2.Title;
                    class19cs.PublishDate = model2.PublishDate;
                    class19cs.ContentText = model2.ContentText;
                    break;

                case "AEC":
                    var model3 = db.AcademicExchange.FirstOrDefault(w => w.ID == Id); ;//使CN接收数据
                    class19cs.Title = model3.Title;
                    class19cs.PublishDate = model3.PublishDate;
                    class19cs.ContentText = model3.ContentText;
                    break;

                case "CActive":
                    var model4 = db.Culturalexchanges.FirstOrDefault(w => w.ID == Id); ;//使CN接收数据
                    class19cs.Title = model4.Title;
                    class19cs.PublishDate = model4.PublishDate;
                    class19cs.ContentText = model4.ContentText;
                    break;

                case "Lab":
                    var model5 = db.Labintroduce.FirstOrDefault(w => w.ID == Id); ;//使CN接收数据
                    class19cs.Title = model5.Title;
                    class19cs.PublishDate = model5.PublishDate;
                    class19cs.ContentText = model5.ContentText;
                    break;

                case "photo":
                    var model6 = db.PhotoControl.FirstOrDefault(w => w.ID == Id); ;//使CN接收数据
                    class19cs.Title = model6.Title;
                    class19cs.UploadDate = model6.UploadDate;
                    class19cs.LoadPosition = model6.LoadPosition;
                    break;

                default:
                    break;
            }
            return View(class19cs);
        }

        public ActionResult LeaderMessge()
        {
            return View();
        }

        public ActionResult LeaderIndex()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string UserName, string password)
        {
            var model = db.Login;//使CN接收数据
            //IDentityResult result
            var user = db.Login.Where(t => t.UserName == UserName & t.password == password);
            //bool model => model.UserName = db.Isequals(UserName);
            if (user.Count() > 0)
            {
                Session["UserName"] = UserName;
                Session["password"] = password;
                Session["Creater"] = user.ToList()[0].Creater;
                return RedirectToAction("Backindex");
            }
            else
            {
                ModelState.AddModelError("", "用户名或密码错误");
                return View();
            }
        }

        [HttpPost]
        public ActionResult CenterNews([Bind(Include = "ID,Title,ContentText,IsPublich,PublishDate,CreateUser,CreateDate,UpdateDate")] CenterNewsCreate centerNewsCreate)
        {
            if (ModelState.IsValid)
            {
                db.CenterNewsCreate.Add(centerNewsCreate);
                db.SaveChanges();
                return RedirectToAction("index");
            }
            return View(centerNewsCreate);
        }

        [HttpPost]
        public ActionResult LabIntroduced([Bind(Include = "ID,ContentText,PublishDate,CreateUser,CreateDate,UpdateDate")] Labintroduce labintroduce)
        {
            if (ModelState.IsValid)
            {
                db.Labintroduce.Add(labintroduce);
                db.SaveChanges();
                return RedirectToAction("index");
            }
            return View(labintroduce);
        }

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
        [HttpPost]
        public ActionResult CuturalActive([Bind(Include = "ID,Title,ContentText,IsPublich,PublishDate,CreateUser,CreateDate,UpdateDate")] Culturalexchanges culturalexchange)
        {
            if (ModelState.IsValid)
            {
                db.Culturalexchanges.Add(culturalexchange);
                db.SaveChanges();
                return RedirectToAction("index");
            }
            return View(culturalexchange);
        }

        [HttpPost]
        public ActionResult AchievementShow([Bind(Include = "ID,Title,ContentText,IsPublich,PublishDate,CreateUser,CreateDate,UpdateDate")] AchievementShow achievementShow)
        {
            if (ModelState.IsValid)
            {
                db.AchievementShows.Add(achievementShow);
                db.SaveChanges();
                return RedirectToAction("index");
            }
            return View(achievementShow);
        }

        [HttpPost]
        public ActionResult Notice([Bind(Include = "ID,Title,ContentText,IsPublich,PublishDate,CreateUser,CreateDate,UpdateDate")] Notice notice)
        {
            if (ModelState.IsValid)
            {
                db.Notice.Add(notice);
                db.SaveChanges();
                return RedirectToAction("index");
            }
            return View(notice);
        }

        [HttpPost]
        public ActionResult AcademicExchange([Bind(Include = "ID,Title,ContentText,IsPublich,PublishDate,CreateUser,CreateDate,UpdateDate")] AcademicExchange academicExchange)
        {
            if (ModelState.IsValid)
            {
                db.AcademicExchange.Add(academicExchange);
                db.SaveChanges();
                return RedirectToAction("index");
            }
            return View(academicExchange);
        }

        // 图片管理控制器
        private string _directory = @"/PhotoControl/";//@路径

        private Random rnd = new Random();

        [HttpPost]
        public ActionResult PhotoControl(HttpPostedFileBase file, PhotoControl photoControl)
        {
            if (file == null)
            {
                return Content("没有上传任何文件");
            }
            string fileExt = Path.GetExtension(Request.Files[0].FileName).ToLower();
            string fileName = Server.MapPath(_directory) + "\\" + DateTime.Now.ToString("yyyyMMddHHmmssfff") + rnd.Next(1, 9).ToString() + fileExt;

            try
            {
                file.SaveAs(fileName);
                DirectoryInfo df = new DirectoryInfo(fileName);
                photoControl.LoadPosition = _directory + df.Name;
                if (ModelState.IsValid)
                {
                    db.PhotoControl.Add(photoControl);
                    db.SaveChanges();
                    return RedirectToAction("index");
                }
                return View(photoControl);
            }
            catch (Exception ex)
            {
                return Content("上传异常 ！", "text/plain");
            }
        }

        //数据列表模态框调用视图控制器代码
        public ViewResult Editor(int id)
        {
            var model = db.CenterNewsCreate.FirstOrDefault(w => w.ID == id);
            return View(model);
        }

        public ViewResult MTcenterDelete(int id)
        {
            var model = db.CenterNewsCreate.FirstOrDefault(w => w.ID == id);
            return View(model);
        }

        public ViewResult MTAchieveShow(int id)
        {
            var model = db.AchievementShows.FirstOrDefault(w => w.ID == id);
            return View(model);
        }

        public ViewResult AchievementShowMTDelete(int id)
        {
            var model = db.AchievementShows.FirstOrDefault(w => w.ID == id);
            return View(model);
        }

        public ViewResult AcademicExchangeMT(int id)
        {
            var model = db.AcademicExchange.FirstOrDefault(w => w.ID == id);
            return View(model);
        }

        public ViewResult AcademicExchangeMTDelete(int id)
        {
            var model = db.AcademicExchange.FirstOrDefault(w => w.ID == id);
            return View(model);
        }

        public ViewResult CulturalexchangeMT(int id)
        {
            var model = db.Culturalexchanges.FirstOrDefault(w => w.ID == id);
            return View(model);
        }

        public ViewResult CulturalexchangeMTDelete(int id)
        {
            var model = db.Culturalexchanges.FirstOrDefault(w => w.ID == id);
            return View(model);
        }

        public ViewResult NoticeMT(int id)
        {
            var model = db.Notice.FirstOrDefault(w => w.ID == id);
            return View(model);
        }

        public ViewResult NoticeMTDelete(int id)
        {
            var model = db.Notice.FirstOrDefault(w => w.ID == id);
            return View(model);
        }

        public ViewResult LabintroduceMT(int id)
        {
            var model = db.Labintroduce.FirstOrDefault(w => w.ID == id);
            return View(model);
        }

        public ViewResult LabintroduceMTDelete(int id)
        {
            var model = db.Labintroduce.FirstOrDefault(w => w.ID == id);
            return View(model);
        }

        //数据列表模态框编辑控制器代码
        //public ActionResult EditorControl(Guid? ID)
        //{
        //    if (ID == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    CenterNewsCreate centerNewsCreate = db.CenterNewsCreate.Find(ID);
        //    if (centerNewsCreate == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(centerNewsCreate);
        //}
        //[HttpPost]
        public ActionResult EditorControl([Bind(Include = "ID, Title,IsPublich,PublishDate,ContentText,CreateUser,CreateDate,UpdateDate")]CenterNewsCreate centerNewsCreate)
        {
            if (ModelState.IsValid)
            {
                db.Entry(centerNewsCreate).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(centerNewsCreate);
        }

        public ActionResult EditorDelete(int ID)
        {
            CenterNewsCreate centerNewsCreate = db.CenterNewsCreate.Find(ID);
            db.CenterNewsCreate.Remove(centerNewsCreate);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult AchievementShowMT([Bind(Include = "ID, Title,IsPublich,PublishDate,ContentText,CreateUser,CreateDate,UpdateDate")]AchievementShow achievementShow)
        {
            if (ModelState.IsValid)
            {
                db.Entry(achievementShow).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(achievementShow);
        }

        public ActionResult AchievementShowMTDelete1(int ID)
        {
            AchievementShow achievementShow = db.AchievementShows.Find(ID);
            db.AchievementShows.Remove(achievementShow);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult LabintroduceTM1([Bind(Include = "ID,PublishDate,ContentText,CreateUser,CreateDate,UpdateDate")]Labintroduce labintroduce)
        {
            if (ModelState.IsValid)
            {
                db.Entry(labintroduce).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(labintroduce);
        }

        public ActionResult LabintroduceMTDelete1(int ID)
        {
            Labintroduce labintroduce = db.Labintroduce.Find(ID);
            db.Labintroduce.Remove(labintroduce);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult AcademicExchangeMT1([Bind(Include = "ID, Title,IsPublich,PublishDate,ContentText,CreateUser,CreateDate,UpdateDate")]AcademicExchange academicExchange)
        {
            if (ModelState.IsValid)
            {
                db.Entry(academicExchange).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(academicExchange);
        }

        public ActionResult AcademicExchangeMTDelete1(int ID)
        {
            AcademicExchange academicExchange = db.AcademicExchange.Find(ID);
            db.AcademicExchange.Remove(academicExchange);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult CulturalexchangeMT1([Bind(Include = "ID, Title,IsPublich,PublishDate,ContentText,CreateUser,CreateDate,UpdateDate")]Culturalexchanges culturalexchanges)
        {
            if (ModelState.IsValid)
            {
                db.Entry(culturalexchanges).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(culturalexchanges);
        }

        public ActionResult CulturalexchangeMTDelete1(int ID)
        {
            Culturalexchanges culturalexchanges = db.Culturalexchanges.Find(ID);
            db.Culturalexchanges.Remove(culturalexchanges);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult NoticeMT1([Bind(Include = "ID, Title,IsPublich,PublishDate,ContentText,CreateUser,CreateDate,UpdateDate")]Notice notice)
        {
            if (ModelState.IsValid)
            {
                db.Entry(notice).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(notice);
        }

        public ActionResult NoticeMTDelete1(int ID)
        {
            Notice notice = db.Notice.Find(ID);
            db.Notice.Remove(notice);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        //Bootstrap调用网页代码
        public JsonResult temp()
        {
            var result = db.CenterNewsCreate.OrderBy(x => x.ID);
            return Json(result.ToList(), JsonRequestBehavior.AllowGet);
        }

        public JsonResult achieve()
        {
            var result = db.AchievementShows.OrderBy(x => x.ID);
            return Json(result.ToList(), JsonRequestBehavior.AllowGet);
        }

        public JsonResult academic()
        {
            var result = db.AcademicExchange.OrderBy(x => x.ID);
            return Json(result.ToList(), JsonRequestBehavior.AllowGet);
        }

        public JsonResult cultural()
        {
            var result = db.Culturalexchanges.OrderBy(x => x.ID);
            return Json(result.ToList(), JsonRequestBehavior.AllowGet);
        }

        public JsonResult noticess()
        {
            var result = db.Notice.OrderBy(x => x.ID);
            return Json(result.ToList(), JsonRequestBehavior.AllowGet);
        }

        public JsonResult Labintro()
        {
            var result = db.Labintroduce.OrderBy(x => x.ID);
            return Json(result.ToList(), JsonRequestBehavior.AllowGet);
        }
    }
}