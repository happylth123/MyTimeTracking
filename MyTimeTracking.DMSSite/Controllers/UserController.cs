using MyTimeTracking.DMSSite.BLL.Services;
using MyTimeTracking.DMSSite.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyTimeTracking.DMSSite.Controllers
{
    public class UserController : ControllerBase
    {
        //private readonly UserService userService;

        public UserController()
        {
            //this.userService = userService;
        }

        // GET: User
        public ActionResult Index()
        {
            //var models = userService.GetAll().Select(o => o.ToViewModel());
            return View();
        }
    }
}