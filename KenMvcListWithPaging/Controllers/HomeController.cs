using KenMvcListWithPaging.Data;
using KenMvcListWithPaging.Models;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace KenMvcListWithPaging.Controllers {
	public class HomeController:Controller {
		//private readonly ILogger<HomeController> _logger;

		private readonly AppDbContext _context;

		public HomeController(AppDbContext context) { _context = context; }

		public async Task<IActionResult> IndexAsync(int? id) {
			const int pageSize = 10;
			var pageNbr = id ?? 1;
			var logs = _context.Logs.Skip(pageSize * (pageNbr - 1)).Take(pageSize).ToListAsync();
			//ViewBag.Logs = await logs;
			var Logs = await logs;
			return View(Logs);
		}

		public IActionResult Privacy() {
			return View();
		}

		public IActionResult Greg(int id = 0, int xid = 99) {
			ViewBag.Lastname = "Doud";
			ViewBag.Id = id;
			ViewBag.Xid = xid;
			return View();
		}

		[ResponseCache(Duration = 0,Location = ResponseCacheLocation.None,NoStore = true)]
		public IActionResult Error() {
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
