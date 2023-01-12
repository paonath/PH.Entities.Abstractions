using System;

namespace PH.Entities.Abstractions
{
	/// <summary>
	/// Sample class just for write docs
	/// </summary>
	internal class Sample
	{
		/// <summary>
		/// Entity example using <see cref="IEntity{TKey}"/>
		/// </summary>
		/// <seealso cref="Guid" />
		internal class EntitySample : IEntity<Guid>
		{
			/// <summary>
			///   Gets or sets the primary key identifier.
			/// </summary>
			/// <value>
			///   The identifier.
			/// </value>
			public Guid Id { get; set; }

			/// <summary>
			/// Gets or sets a nullable date. Just for add another prop...
			/// </summary>
			/// <value>
			/// a nullable date.
			/// </value>
			public DateTime? ANullableDate { get; set; }
		}


		internal class MyClass : IDeleteableEntity<long>
		{
			/// <summary>
			///   Gets or sets the primary key identifier.
			/// </summary>
			/// <value>
			///   The identifier.
			/// </value>
			public long Id      { get; set; }

			/// <summary>
			///   Gets or sets a value indicating whether this <see cref="IDeleteableEntity{TKey}" /> is deleted.
			/// </summary>
			/// <value>
			///   <c>true</c> if deleted; otherwise, <c>false</c>.
			/// </value>
			public bool Deleted { get; set; }
		}

	}
}