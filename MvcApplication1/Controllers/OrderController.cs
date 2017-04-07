using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class OrderController : Controller
    {
        //
        // GET: /Order/

        public ActionResult Index()
        {
            eSaleService.OrderService orderService = new eSaleService.OrderService();
            var data=orderService.GetOrderById("1");
            ViewBag.data = data.CustId+"."+data.Custname+"."+data.OrderId;
            return View();
        }

    }
}
