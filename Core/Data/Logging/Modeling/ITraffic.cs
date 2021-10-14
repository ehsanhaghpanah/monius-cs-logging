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
	/// <c>Traffic</c> interface,
	/// </summary>
	[ComImport]
	[Guid("93adaca2-8e49-478c-ba1d-5b3941ce6178")]
	[CoClass(typeof(TrafficImpl))]
	public interface ITraffic : Common.Data.Core.IEntity
	{
		/// <summary>
		/// 
		/// </summary>
		DateTime LoggedAt { get; set; }

		/// <summary>
		/// 
		/// </summary>
		string ClientIP { get; set; }

		/// <summary>
		/// 
		/// </summary>
		string ClientOS { get; set; }

		/// <summary>
		/// 
		/// </summary>
		long TimeSpan { get; set; }

		/// <summary>
		/// 
		/// </summary>
		string Request { get; set; }

		/// <summary>
		/// 
		/// </summary>
		string Respond { get; set; }
	}

	public class TrafficImpl : ITraffic
	{
		#region Default Implementation

		public TrafficImpl()
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

		public DateTime LoggedAt { get; set; }
		public string ClientIP { get; set; }
		public string ClientOS { get; set; }
		public long TimeSpan { get; set; }
		public string Request { get; set; }
		public string Respond { get; set; }
	}
}