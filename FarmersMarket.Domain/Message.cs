using System;
using System.Collections.Generic;
using System.Text;

namespace FarmersMarket.Domain
{
	public class Message : Entity
	{
		public Chat Chat { get; set; }
		public string Text { get; set; }
	}
}
