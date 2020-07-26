using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vic.SportsStore.Domain.Abstract;
using Vic.SportsStore.Domain.Concrete;

namespace Vic.SportsStore.WebApp.Controllers
{
    public class ProductController : Controller
    {
        //属性注入
        public IProductsRepository ProductsRepository { get; set; }

        //Construct 注入
        //private readonly IProductsRepository _productsRepository;

        //public ProductController(IProductsRepository productsRepository)
        //{
        //    _productsRepository = productsRepository;
        //}
        public ViewResult List()
        {
            return View(ProductsRepository.Products);
        }
    }
}