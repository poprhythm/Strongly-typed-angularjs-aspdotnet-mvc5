using System;
using Heroic.AutoMapper;
using HeroicCRM.Web.Core;

namespace HeroicCRM.Web.Models
{
	public class ProductViewModel : IMapFrom<Product>
	{
		public int CustomerId { get; set; }

		public string Title { get; set; }

		public string Description { get; set; }

		public DateTime CreateDate { get; set; }

		public string CustomerName { get; set; }
	}
}