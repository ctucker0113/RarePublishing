using System;
namespace RarePublishing.Models
{
	public class User
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set;  }
		public string Email { get; set; }
		public string Bio { get; set; }
		public string UserName { get; set; }
		public string Password { get; set; }
		public string ProfileImageUrl { get; set; }
		public string? CreatedOn { get; set; }
		public bool Active { get; set; }
	}
}

