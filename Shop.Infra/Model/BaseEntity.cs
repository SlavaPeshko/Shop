using System;

namespace Shop.Infra.Model
{
	/// <summary>
	/// Base class entities
	/// </summary>
	public abstract class BaseEntity
	{
		/// <summary>
		/// Unique key
		/// </summary>
		public int Id { get; set; }
	}
}