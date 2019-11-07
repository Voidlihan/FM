namespace FarmersMarket.Domain
{
	public class ProfilesCategories : Entity
	{
		public virtual Profile Profile { get; set; }

		public virtual Category Category { get; set; }
	}
}