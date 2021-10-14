/**
 * Copyright (C) moniüs, 2017.
 * All rights reserved.
 * E. Haghpanah; haghpanah@monius.net
 */

using System;
using System.Runtime.InteropServices;
using ukey = System.String;

namespace monius.Logging.Modeling
{
	/// <summary>
	/// <c>Mapping</c> interface,
	/// </summary>
	[ComImport]
	[Guid("276f3cb7-8a4a-4c04-88f0-d232cefb5c91")]
	[CoClass(typeof(MappingImpl))]
	public interface IMapping : Common.Data.Core.IEntity
	{
		/// <summary>
		/// 
		/// </summary>
		string Code { get; set; }

		/// <summary>
		/// 
		/// </summary>
		string Text { get; set; }

		/// <summary>
		/// 
		/// </summary>
		string Comments { get; set; }

		/// <summary>
		/// 
		/// </summary>
		string MappedTo { get; set; }
	}

	public class MappingImpl : IMapping
	{
		#region Default Implementation

		public MappingImpl()
		{
			Id = default(long);
			Ky = default(ukey);
		}

		public void SaveChanges()
		{
			throw new NotSupportedException(Common.ResourceObjects.NotSupportedOnModelingDefaultImplementation);
		}

		public void Change(Common.Data.Core.IEntity item, bool onSaveChanges = false)
		{
			throw new NotSupportedException(Common.ResourceObjects.NotSupportedOnModelingDefaultImplementation);
		}

		public long Id
		{
			get;
			private set;
		}

		public ukey Ky
		{
			get;
			private set;
		}

		#endregion

		public string Code { get; set; }
		public string Text { get; set; }
		public string Comments { get; set; }
		public string MappedTo { get; set; }
	}
}