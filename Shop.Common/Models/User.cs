using System;
using Shop.Infra.Enums;
using Shop.Infra.Model;

namespace Shop.Common.Models
{
	public class User : BaseEntity
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Login { get; set; }
		public string Password { get; set; }
		public string Email { get; set; }
		public DateTime Registration { get; set; }
		public UserRoles UserRole { get; set; }
	}
}