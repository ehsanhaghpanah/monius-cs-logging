/**
 * Copyright (C) moniüs, 2013.
 * All rights reserved.
 * E. Haghpanah; haghpanah@monius.net
 */

using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using monius.Logging.Data;
using monius.Logging.ObjectModel;

namespace monius.Logging
{
	/// <summary>
	/// 
	/// </summary>
	public static class Helper
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="ip"></param>
		/// <param name="os"></param>
		/// <returns></returns>
		public static List<Traffic> GetAll(string ip, string os)
		{
			using (var dc = new DataContext(ConfigurationManager.ConnectionStrings["monius"].ConnectionString))
			{
				return dc.SelectOnTrafficsAsGetAll(ip, os).ToList();
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="logLevel"></param>
		/// <param name="count"></param>
		/// <returns></returns>
		public static List<EventLog> NLogFilteredByLogLevel(string logLevel, int count)
		{
			using (var dc = new DataContext(ConfigurationManager.ConnectionStrings["monius"].ConnectionString))
			{
				return dc.SelectOnNLogAsFilteredByLogLevel(logLevel).Take(count).ToList();
			}
		}
	}
}