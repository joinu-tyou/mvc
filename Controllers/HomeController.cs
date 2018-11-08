using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using X.PagedList.Mvc.Common;
using X.PagedList.Mvc.Core;
using mvc.Models;
using X.PagedList;

namespace mvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        protected IPagedList<int> GetPagedNames(int? page)
		{
			// return a 404 if user browses to before the first page
			if (page.HasValue && page < 1)
				return null;

			// retrieve list from database/whereverand
			var listUnpaged = Enumerable.Range(1, 100);

			// page the list
			const int pageSize = 20;
			var listPaged = listUnpaged.ToPagedList(page ?? 1, pageSize);

			// return a 404 if user browses to pages beyond last page. special case first page if no items exist
			if (listPaged.PageNumber != 1 && page.HasValue && page > listPaged.PageCount)
				return null;

			return listPaged;
		}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {

            var item = Enumerable.Range(1, 100);

            var p = GetPagedNames(1);

            ViewBag.PageList = p;

            
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
