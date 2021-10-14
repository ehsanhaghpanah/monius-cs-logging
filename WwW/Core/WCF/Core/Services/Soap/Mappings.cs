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
	[ServiceContract(Namespace = "http://monius.logging/soap/mappings")]
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
		public ObjectModel.Mapping GetOne(long id)
		{
			try
			{
				return (ObjectModel.Mapping) Logging.Mappings.GetOne(id);
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
		public ObjectModel.Mapping GetOne(ukey ky)
		{
			try
			{
				return (ObjectModel.Mapping) Logging.Mappings.GetOne(ky);
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

		/// <summary>
		/// 
		/// </summary>
		/// <param name="code"></param>
		/// <param name="text"></param>
		/// <param name="comments"></param>
		/// <param name="mappedTo"></param>
		/// <returns></returns>
		[OperationContract(Name = "AddOne")]
		public ObjectModel.Mapping AddOne(string code, string text, string comments, string mappedTo)
		{
			try
			{
				return Logging.Mappings.AddOne(code, text, comments, mappedTo) as ObjectModel.Mapping;
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
		/// <param name="item"></param>
		/// <returns></returns>
		[OperationContract(Name = "Change")]
		public ObjectModel.Mapping Change(ObjectModel.Mapping item)
		{
			try
			{
				return Logging.Mappings.Change(item) as ObjectModel.Mapping;
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
		/// <param name="item"></param>
		[OperationContract(Name = "Remove")]
		public void Remove(ObjectModel.Mapping item)
		{
			try
			{
				Logging.Mappings.Remove(item);
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