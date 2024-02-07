using Dashboard.Data;
using Dashboard.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Dashboard.Models;

namespace Dashboard.Repository
{
	public class _ItemRepository
	{
		private readonly MVCDbContext mvcDbContext;

		public _ItemRepository (MVCDbContext mvcDbContext)
		{
			this.mvcDbContext = mvcDbContext;
		}
		 public async Task<List<AddItem>> GetAllItems()
		 {
			var items = new List<AddItem>();
			var allitems = await mvcDbContext.Items.ToListAsync();
			if (allitems?.Any() == true)
			{
				foreach (var item in allitems)
				{
					items.Add(new AddItem()
					{
						ItemNameId = item.ItemNameId,
						ItemCodeId = item.ItemCodeId
					});
				}
			}
			return items;
		}


	}
}
