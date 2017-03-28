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
        private readonly UserService userService;


        public UserController(UserService userService)
        {
            this.userService = userService;
        }

        // GET: User
        public ActionResult Index(int page = 1, int pageSize = 6)
        {
            int totalCount = 0;
            var models = userService.GetAll(out totalCount, page - 1, pageSize).Select(o => o.ToViewModel());
            return View();
        }
    }
}