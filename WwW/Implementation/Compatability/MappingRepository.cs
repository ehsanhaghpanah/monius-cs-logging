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
	public sealed class MappingRepository : Common.WwW.Data.Compatability.Data.Repository<Mapping>
	{
		/// <summary>
		/// 
		/// </summary>
		public MappingRepository()
			: base(new MappingServiceProxy())
		{
		}
	}
}