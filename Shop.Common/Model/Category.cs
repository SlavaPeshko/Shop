using System;
using System.Collections.Generic;
using Shop.Infra.Model;

namespace Shop.Common.Model
{
	public class Category : BaseEntity
	{
		public string Name { get; set; }
		public DateTime DateCreated { get; set; }
		public DateTime DateUpdate { get; set; }

		public virtual List<Gadget> Gadgets { get; set; }

		public Category()
		{
			DateCreated = DateTime.Now;
		}
	}
}