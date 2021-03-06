﻿using System;
using System.Configuration;

namespace openSourceC.NetCoreLibrary.Configuration
{
	/// <summary>
	///		Represents a collection of database provider configuration elements.
	///	</summary>
	[ConfigurationCollection(typeof(DbProviderElement))]
	public class DbProviderElementCollection : NamedProviderElementCollection<DbProviderElement> { }
}
