#region

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

#endregion

namespace PH.Entities.Abstractions
{
	/// <summary>
	/// Entity interface
	/// </summary>
	public interface IEntity
	{
	}

	/// <summary>
	///   Entity with <see cref="Id" /> property as Primary Key
	/// </summary>
	/// <typeparam name="TKey">The type of the key.</typeparam>
	public interface IEntity<TKey> : IEntity where TKey : IEquatable<TKey>
	{
		/// <summary>
		///   Gets or sets the primary key identifier.
		/// </summary>
		/// <value>
		///   The identifier.
		/// </value>
		TKey Id { get; set; }
	}
}