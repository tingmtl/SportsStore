using Autofac;
using Autofac.Integration.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vic.SportsStore.Domain.Abstract;
using Vic.SportsStore.Domain.Concrete;

namespace Vic.SportsStore.WebApp
{
    public class IocConfig
    {
        public static void ConfigIoc()
        {
            var builder = new ContainerBuilder();

            //所有的MVC controller都放到盒子里
            builder.RegisterControllers(typeof(MvcApplication).Assembly).PropertiesAutowired();

            //
            builder.RegisterInstance<IProductsRepository>(new InMemoryProductRepository()).PropertiesAutowired();

            //把这个盒子告诉框架，以后用这个盒子解析
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}