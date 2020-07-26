using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vic.SportsStore.Domain.Concrete;
using Vic.SportsStore.Domain.Entities;

namespace Vic.SportsStore.DebugConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start.....");

            using(var ctx = new EFDbContext())
            {
                for (int i = 0; i < 50; i++)
                {
                    var product = new Product()
                    {
                        Name = $"football{i}",
                        Price = 12.35m + 0.1m,
                        Category = "ball",
                        Description = "this is a football"
                    };
                    ctx.Products.Add(product);
                }

                
                ctx.SaveChanges();
            }

            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}
