using Microsoft.AspNetCore.Mvc;

namespace FLW.Controllers
{
	public class MusicsController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
