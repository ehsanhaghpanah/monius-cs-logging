/**
 * Copyright (C) moniüs, 2017.
 * All rights reserved.
 * E. Haghpanah; haghpanah@monius.net
 */

using System;
using System.ServiceModel;

namespace BackEnd
{
	/// <summary>
	/// 
	/// </summary>
	public sealed class Program
	{
		private static readonly NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

		[STAThread]
		static void Main()
		{
			//
			// getting list of available services,
			var list = new[]
			{
				new ServiceHost(typeof(monius.Logging.WwW.Services.Rest.Traffics)), 
				new ServiceHost(typeof(monius.Logging.WwW.Services.Soap.Traffics)), 
				new ServiceHost(typeof(monius.Logging.WwW.Services.Rest.Mappings)), 
				new ServiceHost(typeof(monius.Logging.WwW.Services.Soap.Mappings)),
			};

			try
			{
				//
				// iterating through the service host(s),
				foreach (var host in list)
				{
					//
					// opening service host,
					host.Open(new TimeSpan(0, 0, 0, 0));
				}

				logger.Info("PayPass WwW BackEnd Server Started!");
				logger.Info("Press Enter to Quit,");
				Console.ReadLine();
			}
			catch (Exception p)
			{
				logger.Error(p);
			}
			finally
			{
				//
				// iterating through the service host(s),
				foreach (var host in list)
				{
					//
					// closing service host,
					if (host != null)
						host.Close(new TimeSpan(0, 0, 0, 0));
				}
			}
		}
	}
}