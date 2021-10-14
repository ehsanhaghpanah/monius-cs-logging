/**
 * Copyright (C) moniüs, 2016.
 * All rights reserved.
 * E. Haghpanah; haghpanah@monius.net
 */

using monius.Logging.ObjectModel;

namespace monius.Logging.WwW.Data.Compatability
{
	/// <summary>
	/// 
	/// </summary>
	public sealed class TrafficRepository : Common.WwW.Data.Compatability.Data.Repository<Traffic>
	{
		/// <summary>
		/// 
		/// </summary>
		public TrafficRepository()
			: base(new TrafficServiceProxy())
		{
		}
	}
}