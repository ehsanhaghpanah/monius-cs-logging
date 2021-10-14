/**
 * Copyright (C) moniüs, 2016.
 * All rights reserved.
 * E. Haghpanah; haghpanah@monius.net
 */

using System;
using System.Collections.Generic;
using monius.Logging.ObjectModel;
using ukey = System.String;

namespace monius.Logging.WwW.Data.Compatability
{
	/// <summary>
	/// 
	/// </summary>
	public sealed class TrafficServiceProxy : Common.WwW.Data.Compatability.Core.IDataServiceProxy<Traffic>
	{
		private static readonly NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

		#region GetOne

		public Traffic GetOne(long id)
		{
			throw new NotImplementedException();
		}

		public Traffic GetOne(ukey ky)
		{
			throw new NotImplementedException();
		}

		#endregion

		#region GetAll

		public IEnumerable<Traffic> GetAll()
		{
			return GetAll(int.MaxValue);
		}

		public IEnumerable<Traffic> GetAll(int count)
		{
			try
			{
				//
				// creating service proxy client,
				using (var client = new ServiceProxys.TrafficsClient())
				{
					//
					// calling service api,
					return client.GetAll(count);
				}
			}
			catch (Exception p)
			{
				logger.Error(p);
				throw;
			}
		}

		#endregion

		#region AddOne|Change|Remove

		public Traffic AddOne(Traffic item)
		{
			throw new NotImplementedException();
		}

		public Traffic Change(Traffic item)
		{
			throw new NotImplementedException();
		}

		public void Remove(Traffic item)
		{
			throw new NotImplementedException();
		}

		#endregion
	}
}