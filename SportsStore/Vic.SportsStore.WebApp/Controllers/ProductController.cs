using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using Vic.SportsStore.Domain.Abstract;
using Vic.SportsStore.Domain.Concrete;
using Vic.SportsStore.WebApp.Models;

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
        public const int PageSize = 5;
        public ViewResult List(int page = 1)
        {
            ProductsListViewModel model = new ProductsListViewModel
            {
                Products = ProductsRepository
                .Products
                .OrderBy(p => p.ProductId)
                .Skip((page - 1) * PageSize)
                .Take(PageSize),
                    PagingInfo = new PagingInfo
                    {
                        CurrentPage = page,
                        ItemsPerPage = PageSize,
                        TotalItems = ProductsRepository.Products.Count()
                    }
            };
            return View(model);
        }
    }
}