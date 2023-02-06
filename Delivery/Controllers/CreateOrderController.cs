using DataBase;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Mvc;

namespace Delivery.Controllers
{
	public class CreateOrderController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
        public IActionResult Check(string[] args, Base @base)
        {
			if (ModelState.IsValid)
			{
                var host = BuildWebHost(args);

                using (var scope = host.Services.CreateScope())
                {
                    var services = scope.ServiceProvider;
                    var context = services.GetRequiredService<EFDBContext>();
                    FillingData.Fill(context, @base);
                }
				return Redirect("/");
			}
            return View("Index");
        }
        public static IWebHost BuildWebHost(string[] args) =>
        WebHost.CreateDefaultBuilder(args)
        .UseStartup<Startup>().Build();
    }
}
