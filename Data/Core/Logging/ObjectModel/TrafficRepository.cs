/**
 * Copyright (C) moniüs, 2014.
 * All rights reserved.
 * E. Haghpanah; haghpanah@monius.net
 */

using System;
using ukey = System.String;

namespace monius.Logging.ObjectModel
{
	/// <summary>
	/// 
	/// </summary>
	internal sealed class TrafficRepository : Common.Data.Corn.Repository<Traffic>
	{
		#region —— Ctor(New) ——

		public TrafficRepository()
		{
		}

		public TrafficRepository(Data.DataContext dataContext)
			: base(dataContext)
		{
		}

		#endregion

		#region —— Overrides ——

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ky"></param>
		/// <returns></returns>
		public override Traffic this[ukey ky]
		{
			get { throw new NotSupportedException(); }
		}

		public override void Remove(Traffic item, bool saveChanges)
		{
			throw new NotSupportedException("TrafficRecordIsNotRemovable");
		}

		#endregion
	}
}