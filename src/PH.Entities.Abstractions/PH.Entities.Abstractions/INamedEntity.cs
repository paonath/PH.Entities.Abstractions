using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PH.Entities.Abstractions
{
	/// <summary>
	/// Entity interface with <see cref="Name"/> property.
	/// </summary>
	/// <seealso cref="PH.Entities.Abstractions.IEntity" />
	public interface INamedEntity : IEntity
	{
		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		/// <value>
		/// The name.
		/// </value>
		string Name { get; set; }
	}

	/// <summary>
	/// Entity interface with <see cref="INamedEntity.Name"/> property.
	/// </summary>
	/// <typeparam name="TKey">The type of the key.</typeparam>
	/// <seealso cref="PH.Entities.Abstractions.IEntity" />
	public interface INamedEntity<TKey> : IEntity<TKey>, INamedEntity where TKey : IEquatable<TKey>
	{
	}
}