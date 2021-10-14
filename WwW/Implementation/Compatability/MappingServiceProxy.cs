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
	public sealed class MappingServiceProxy : Common.WwW.Data.Compatability.Core.IDataServiceProxy<Mapping>
	{
		private static readonly NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

		#region GetOne

		/// <summary>
		/// 
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public Mapping GetOne(long id)
		{
			try
			{
				//
				// creating service proxy client
				using (var client = new ServiceProxys.MappingsClient())
				{
					//
					// calling service api
					return client.GetOneById(id);
				}
			}
			catch (Exception p)
			{
				logger.Error(p);
				throw;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ky"></param>
		/// <returns></returns>
		public Mapping GetOne(ukey ky)
		{
			try
			{
				//
				// creating service proxy client
				using (var client = new ServiceProxys.MappingsClient())
				{
					//
					// calling service api
					return client.GetOneByKy(ky);
				}
			}
			catch (Exception p)
			{
				logger.Error(p);
				throw;
			}
		}

		#endregion

		#region GetAll

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public IEnumerable<Mapping> GetAll()
		{
			return GetAll(int.MaxValue);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="count"></param>
		/// <returns></returns>
		public IEnumerable<Mapping> GetAll(int count)
		{
			try
			{
				//
				// creating service proxy client
				using (var client = new ServiceProxys.MappingsClient())
				{
					//
					// calling service api
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

		/// <summary>
		/// 
		/// </summary>
		/// <param name="item"></param>
		/// <returns></returns>
		public Mapping AddOne(Mapping item)
		{
			try
			{
				//
				// creating service proxy client,
				using (var client = new ServiceProxys.MappingsClient())
				{
					//
					// calling service api,
					return client.AddOne(item.Code, item.Text, item.Comments, item.MappedTo);
				}
			}
			catch (Exception p)
			{
				logger.Error(p);
				throw;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="item"></param>
		/// <returns></returns>
		public void Remove(Mapping item)
		{
			try
			{
				//
				// creating service proxy client,
				using (var client = new ServiceProxys.MappingsClient())
				{
					//
					// calling service api,
					client.Remove(item);
				}
			}
			catch (Exception p)
			{
				logger.Error(p);
				throw;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="item"></param>
		/// <returns></returns>
		public Mapping Change(Mapping item)
		{
			try
			{
				//
				// creating service proxy client,
				using (var client = new ServiceProxys.MappingsClient())
				{
					//
					// calling service api,
					return client.Change(item);
				}
			}
			catch (Exception p)
			{
				logger.Error(p);
				throw;
			}
		}

		#endregion
	}
}