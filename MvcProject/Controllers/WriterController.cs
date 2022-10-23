using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProject.Controllers
{
    public class WriterController : Controller
    {
        WriterManager wm=new WriterManager(new EfWriterDal());
        // GET: Writer
        public ActionResult Index()
        {
            var writerValues = wm.GetList();
            return View(writerValues);
        }
    }
}