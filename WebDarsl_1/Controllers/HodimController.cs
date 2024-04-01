using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebDarsl_1.AddDbContext;
using WebDarsl_1.Models;

namespace WebDarsl_1.Controllers
{
	public class HodimController : Controller
	{
		private readonly MyDbContext myDbContext;

		public HodimController(MyDbContext myDbContext)
		{
			this.myDbContext = myDbContext;
		}
		[HttpGet]
		public async Task<IActionResult> Index() 
		{
			var hodim = await myDbContext.Hodims.ToListAsync();
			return View(hodim);
		}
		[HttpGet]
		public IActionResult Add()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Add(AddHodimViewModel addHodimViewModel)
		{
			var hodim = new Hodim()
			{
				Id = Guid.NewGuid(),
				familya = addHodimViewModel.familya,
				ism = addHodimViewModel.ism,
				yosh = addHodimViewModel.yosh,
				jins = addHodimViewModel.jins,
				maosh = addHodimViewModel.maosh,
			};
			await myDbContext.Hodims.AddAsync(hodim);
			await myDbContext.SaveChangesAsync();
			return RedirectToAction("Add");
		}
		[HttpGet]
		public async Task<IActionResult> View(Guid id)
		{
			var hodim = await myDbContext.Hodims.SingleOrDefaultAsync(h => h.Id == id);
			if (hodim != null)
			{
				var viwModel = new HodimniYangilash()
				{
					Id = hodim.Id,
					familya = hodim.familya,
					ism = hodim.ism,
					yosh = hodim.yosh,
					jins = hodim.jins,
					maosh = hodim.maosh,
				};
				return await Task.Run(() => View("View",viwModel));
			}
			return RedirectToAction("Index");
		}

		[HttpPost]
		public async Task<IActionResult> View(HodimniYangilash model)
		{
			var hodim = await myDbContext.Hodims.FindAsync(model.Id);
			if (hodim != null)
			{
				hodim.familya = model.familya;
				hodim.ism = model.ism;
				hodim.yosh = model.yosh;
				hodim.jins = model.jins;
				hodim.maosh = model.maosh;

				await myDbContext.SaveChangesAsync();

				return RedirectToAction("Index");
			}
				return RedirectToAction("Index");
			}

		[HttpPost]
		public async Task<IActionResult>Delete(HodimniYangilash model) 
		{
			var hodim = await myDbContext.Hodims.FindAsync(model.Id);
			if (hodim != null)
			{
				myDbContext.Hodims.Remove(hodim);
				await myDbContext.SaveChangesAsync();

				return RedirectToAction("Index");
			}
			return RedirectToAction("Index");
		}


	}

}
