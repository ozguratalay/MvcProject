using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;

namespace MvcProject.Controllers
{
    public class HeadingController : Controller
    {
        private Context db = new Context();
        HeadingManager hm = new HeadingManager(new EfHeadingDal());
        CategoryManager cm = new CategoryManager(new EfCategoryDal());

        // GET: Heading
        public ActionResult Index()
        {
            var headingValues = hm.GetList();
            return View(headingValues);
        }
        public ActionResult AddHeading()
        {
            //Dropdown list çekmek için 1.yöntem
            List<SelectListItem> valueCategory = (from x in cm.GetList()
                                                  select new SelectListItem
                                                  {
                                                      Text=x.Name,
                                                      Value=x.Id.ToString()
                                                  }).ToList();
            ViewBag.vlc = valueCategory;
            //Dropdown list çekmek için 2.yöntem
            ViewBag.writerId = new SelectList(db.Writers, "Id", "FullName");
            return View();
        }

        [HttpPost]
        public ActionResult AddHeading(Heading heading)
        {
            heading.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            hm.HeadingAdd(heading);
            return RedirectToAction("Index");
        }

        public ActionResult ContentByHeading()
        {
            return View();
        }
    }
}