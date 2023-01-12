#region

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

#endregion

namespace PH.Entities.Abstractions
{
	/// <summary>
	///   Entity with <see cref="Deleted" /> property for "soft-deleting"
	/// </summary>
	/// <seealso cref="PH.Entities.Abstractions.IEntity&lt;TKey&gt;" />
	public interface IDeleteableEntity : IEntity
	{
		/// <summary>
		///   Gets or sets a value indicating whether this <see cref="IDeleteableEntity{TKey}" /> is deleted.
		/// </summary>
		/// <value>
		///   <c>true</c> if deleted; otherwise, <c>false</c>.
		/// </value>
		bool Deleted { get; set; }
	}

	/// <summary>
	///   Entity with <see cref="IDeleteableEntity.Deleted" /> property for "soft-deleting"
	/// </summary>
	/// <typeparam name="TKey">The type of the key.</typeparam>
	/// <seealso cref="PH.Entities.Abstractions.IEntity&lt;TKey&gt;" />
	public interface IDeleteableEntity<TKey> : IEntity<TKey> , IDeleteableEntity where TKey : IEquatable<TKey>
	{
		
	}
}