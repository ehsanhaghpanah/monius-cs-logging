/**
 * Copyright (C) moniüs, 2015.
 * All rights reserved.
 * E. Haghpanah; haghpanah@monius.net
 */

namespace monius.Logging.ObjectModel
{
	/// <summary>
	/// 
	/// </summary>
	public sealed class MappingDepository : Common.Data.Corn.Depository<Mapping>
	{
		#region —— Ctor(New) ——

		/// <summary>
		/// 
		/// </summary>
		public MappingDepository()
		{
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="dataContext"></param>
		public MappingDepository(System.Data.Linq.DataContext dataContext)
			: base(dataContext)
		{
		}

		#endregion
	}
}