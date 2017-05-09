using System;
using System.Collections.Generic;
using Shop.Infra.Model;

namespace Shop.Common.Models
{
	public class Category : BaseEntity
	{
		public string Name { get; set; }
		public DateTime DateCreated { get; set; }
		public DateTime DateUpdate { get; set; }

		public virtual ICollection<Product> Products { get; set; }

		public Category()
		{
			DateCreated = DateTime.Now;
		}
	}
}