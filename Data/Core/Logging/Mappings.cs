/**
 * Copyright (C) moniüs, 2015.
 * All rights reserved.
 * E. Haghpanah; haghpanah@monius.net
 */

using System;
using System.Collections.Generic;
using System.Linq;
using ukey = System.String;

namespace monius.Logging
{
	/// <summary>
	/// 
	/// </summary>
	static public class Mappings
	{
		private static readonly NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

		#region GetOne

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ky"></param>
		/// <param name="dataContext"></param>
		/// <returns></returns>
		internal static Modeling.IMapping GetOne(ukey ky, Data.DataContext dataContext)
		{
			try
			{
				var list = new ObjectModel.MappingDepository(dataContext);
				return list[ky];
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
		/// <param name="id"></param>
		/// <returns></returns>
		public static Modeling.IMapping GetOne(long id)
		{
			try
			{
				var list = new ObjectModel.MappingDepository();
				return list[id];
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
		public static Modeling.IMapping GetOne(ukey ky)
		{
			try
			{
				var list = new ObjectModel.MappingDepository();
				return list[ky];
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
		public static IEnumerable<Modeling.IMapping> GetAll()
		{
			return GetAll(int.MaxValue);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="count"></param>
		/// <returns></returns>
		public static IEnumerable<Modeling.IMapping> GetAll(int count)
		{
			try
			{
				var list = new ObjectModel.MappingDepository();
				return list.OrderBy(o => o.Code).Take(count);
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
		/// <param name="query"></param>
		/// <returns></returns>
		public static IEnumerable<Modeling.IMapping> GetAll(string query)
		{
			throw new NotImplementedException();
		}

		#endregion

		#region AddOne|Change|Remove|Delete

		/// <summary>
		/// 
		/// </summary>
		/// <param name="code"></param>
		/// <param name="text"></param>
		/// <param name="comments"></param>
		/// <param name="mappedTo"></param>
		/// <returns></returns>
		public static Modeling.IMapping AddOne(string code, string text, string comments, string mappedTo)
		{
			try
			{
				var list = new ObjectModel.MappingDepository();
				var item = new ObjectModel.Mapping
				{
					Code = code,
					Text = text,
					Comments = comments,
					MappedTo = mappedTo,
				};
				return list.Add(item);
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
		public static Modeling.IMapping AddOne(Modeling.IMapping item)
		{
			try
			{
				if (!item.Id.Equals(default(long)))
					return Change(item);

				var list = new ObjectModel.MappingDepository();
				return list.Add((ObjectModel.Mapping) item);
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
		public static Modeling.IMapping Change(Modeling.IMapping item)
		{
			try
			{
				var list = new ObjectModel.MappingDepository();
				return list.Change((ObjectModel.Mapping) item, onItemSaveChanges: false);
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
		public static void Remove(Modeling.IMapping item)
		{
			try
			{
				var list = new ObjectModel.MappingDepository();
				var idol = item.Id.Equals(default(long)) ? list[item.Ky] : list[item.Id];
				if (idol == null)
					throw new Common.Core.Data.SeekedItemNotFoundException("ItemNotExistsOrIdentifiersAreNotValid");

				list.Remove(idol);
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
		public static void Delete(Modeling.IMapping item)
		{
			Remove(item);
		}

		#endregion
	}
}