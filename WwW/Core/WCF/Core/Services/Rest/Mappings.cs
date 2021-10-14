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
using ukey = System.String;

namespace monius.Logging.WwW.Services.Rest
{
	/// <summary>
	/// 
	/// </summary>
	[ServiceContract(Namespace = "http://monius.logging/rest/mappings")]
	[ServiceBehavior(AddressFilterMode = AddressFilterMode.Any)]
	public sealed class Mappings
	{
		private static readonly NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

		#region GetOne

		/// <summary>
		/// 
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		[OperationContract(Name = "GetOneById")]
		[WebInvoke(Method = "GET", UriTemplate = "/GetOneById?id={id}", ResponseFormat = WebMessageFormat.Json)]
		public ObjectModel.Mapping GetOne(long id)
		{
			try
			{
				return Logging.Mappings.GetOne(id) as ObjectModel.Mapping;
			}
			catch (Exception p)
			{
				//
				// logging
				logger.Error(p);
				throw;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ky"></param>
		/// <returns></returns>
		[OperationContract(Name = "GetOneByKy")]
		[WebInvoke(Method = "GET", UriTemplate = "/GetOneByKy?ky={ky}", ResponseFormat = WebMessageFormat.Json)]
		public ObjectModel.Mapping GetOne(ukey ky)
		{
			try
			{
				return Logging.Mappings.GetOne(ky) as ObjectModel.Mapping;
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

		#region GetAll

		/// <summary>
		/// 
		/// </summary>
		/// <param name="count"></param>
		/// <returns></returns>
		[OperationContract(Name = "GetAll")]
		[WebInvoke(Method = "GET", UriTemplate = "/GetAll?count={count}", ResponseFormat = WebMessageFormat.Json)]
		public List<ObjectModel.Mapping> GetAll(int count)
		{
			try
			{
				return Logging.Mappings.GetAll(count).Select(o => (ObjectModel.Mapping) o).ToList();
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

		#region AddOne|Change|Remove

		#endregion
	}
}