/**
 * Copyright (C) moniüs, 2015.
 * All rights reserved.
 * E. Haghpanah; haghpanah@monius.net
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace monius.Logging
{
	/// <summary>
	/// 
	/// </summary>
	static public class Traffics
	{
		private static readonly NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

		#region GetOne

		#endregion

		#region GetAll

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public static IEnumerable<Modeling.ITraffic> GetAll()
		{
			return GetAll(int.MaxValue);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="count"></param>
		/// <returns></returns>
		public static IEnumerable<Modeling.ITraffic> GetAll(int count)
		{
			try
			{
				var list = new ObjectModel.TrafficRepository();
				return list.OrderByDescending(o => o.LoggedAt).Take(count);
			}
			catch (Exception p)
			{
				logger.Error(p);
				throw;
			}
		}

		#endregion

		#region AddOne|Change|Remove

		#endregion

		/// <summary>
		/// 
		/// </summary>
		/// <param name="clientIP"></param>
		/// <param name="clientOS"></param>
		/// <param name="timeSpan"></param>
		/// <param name="request"></param>
		/// <param name="respond"></param>
		static public void Log(string clientIP, string clientOS, TimeSpan timeSpan, string request, string respond)
		{
			var list = new ObjectModel.TrafficRepository();
			var item = new ObjectModel.Traffic
			{
				ClientIP = clientIP,
				ClientOS = clientOS,
				TimeSpan = timeSpan.Ticks,
				Request = request,
				Respond = respond,
			};
			list.Add(item);
		}
	}
}