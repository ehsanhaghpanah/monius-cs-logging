/**
 * Copyright (C) moniüs, 2017.
 * All rights reserved.
 * E. Haghpanah; haghpanah@monius.net
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace monius.Logging.WwW.Services.Rest
{
	/// <summary>
	/// 
	/// </summary>
	[ServiceContract(Namespace = "http://monius.logging/rest/traffics")]
	[ServiceBehavior(AddressFilterMode = AddressFilterMode.Any)]
	public sealed class Traffics
	{
		private static readonly NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

		#region GetAll

		/// <summary>
		/// 
		/// </summary>
		/// <param name="count"></param>
		/// <returns></returns>
		[OperationContract(Name = "GetAll")]
		[WebInvoke(Method = "GET", UriTemplate = "/GetAll?count={count}", ResponseFormat = WebMessageFormat.Json)]
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