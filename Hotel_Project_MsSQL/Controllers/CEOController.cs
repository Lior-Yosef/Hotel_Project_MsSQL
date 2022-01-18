using Hotel_Project_MsSQL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hotel_Project_MsSQL.Controllers
{
    public class CEOController : Controller
    {

        // GET: CEO

        public List<CEO> ListCEO = new List<CEO>()
        {
            new CEO(0,"liorYosef",24,"lior@gmail",45000),
            new CEO(1,"AviYosef",24,"avi@gmail",45000),
            new CEO(2,"EilyYosef",24,"eilay@gmail",45000),
            new CEO(3,"DanYosef",24,"dan@gmail",45000)
        };
        


           

        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ShowName()
        {
            return View();
        }
        public ActionResult showCEO()
        {
            return View();
        }
    }
}