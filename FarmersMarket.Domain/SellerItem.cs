using System;
using System.Collections.Generic;
using System.Text;

namespace FarmersMarket.Domain
{
	public class SellerItem : Entity
	{
		public Category Category { get; set; }
		public Product Product { get; set; }
		public Profile Profile { get; set; }
		public int Quantity { get; set; }
		public int Price { get; set; }
	}
}
