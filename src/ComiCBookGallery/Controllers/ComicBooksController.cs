using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComiCBookGallery.Controllers
{
	public class ComicBooksController: Controller
	{
			public ActionResult Detail()
			{
				if(DateTime.Today.DayOfWeek == DayOfWeek.Friday)
				{
					return new RedirectResult("/");
				}
					else return new ContentResult()
				{
					Content = "Hello from Controller"
				};

			}

	}
}