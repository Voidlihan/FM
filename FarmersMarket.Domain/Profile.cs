﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FarmersMarket.Domain
{
	public class Profile : Entity
	{
		User User { get; set; }
		List<ProfilesCategories> ProfilesCategories { get; set; }

	}
}
