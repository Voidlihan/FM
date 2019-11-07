using System;
using System.Collections.Generic;
using System.Text;

namespace FarmersMarket.Domain
{
	public class Product : Entity
	{
		public Category Category { get; set; }
		public string Name { get; set; }
	}
}
