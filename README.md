# PH.Entities.Abstractions [![NuGet Badge](https://buildstats.info/nuget/PH.Entities.Abstractions)](https://www.nuget.org/packages/PH.Entities.Abstractions/)
Abstractions for Entities: simple collection of interfaces

## Data

 - `IEntity` and `IEntity<TKey>` 
 - `IDeleteableEntity` and `IDeleteableEntity<TKey>` 
 - `INamedEntity` and `INamedEntity<TKey>` 
 

### Examples


#### IEntity
```csharp

/// <summary>
/// Entity example using <see cref="IEntity{TKey}"/>
/// </summary>
/// <seealso cref="Guid" />
public class EntitySample : IEntity<Guid>
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

```
#### IDeleteableEntity
```csharp

public class MyClass : IDeleteableEntity<long>
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

```