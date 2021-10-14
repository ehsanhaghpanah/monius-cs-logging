/**
 * Copyright (C) moniüs, 2017.
 * All rights reserved.
 * E. Haghpanah; haghpanah@monius.net
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using ukey = System.String;

namespace monius.Logging.WwW.Services.Soap
{
	/// <summary>
	/// 
	/// </summary>
	[ServiceContract(Namespace = "http://monius.logging/soap/traffics")]
	public sealed class Traffics
	{
		private static readonly NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

		#region GetAll

		[OperationContract(Name = "GetAll")]
		public List<ObjectModel.Traffic> GetAll(int count)
		{
			try
			{
				return Logging.Traffics.GetAll(count).Select(o => (ObjectModel.Traffic) o).ToList();
			}
			catch (Exception p)
			{
				//
				// logging
				logger.Error(p);
				throw;
			}
		}

		#endregion
	}
}