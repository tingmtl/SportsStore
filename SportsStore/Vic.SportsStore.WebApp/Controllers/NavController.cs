using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vic.SportsStore.Domain.Abstract;

namespace Vic.SportsStore.WebApp.Controllers
{
    public class NavController : Controller
    { 

        public IProductsRepository ProductRepository { get; set; }

        public PartialViewResult Menu(string category = null)
        {
            //动态添加一个SelectedCategory
            ViewBag.SelectedCategory = category;

            IEnumerable<string> categories = ProductRepository
            .Products
            .Select(x => x.Category)
            .Distinct()
            .OrderBy(x => x);
            return PartialView(categories);
        }
    }
}