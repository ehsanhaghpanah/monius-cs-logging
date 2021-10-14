/**
 * Copyright (C) moniüs, 2013.
 * All rights reserved.
 * E. Haghpanah; haghpanah@monius.net
 */

using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Reflection;
using monius.Logging.ObjectModel;

namespace monius.Logging.Data
{
	internal partial class DataContext
	{
		[Function(Name = "[Logging].[Traffics_GetAll]")]
		public ISingleResult<Traffic> SelectOnTrafficsAsGetAll
		(
			[ParameterAttribute(Name = "ClientIP", DbType = "NVarChar(64)")] 
			string clientIP,
			[ParameterAttribute(Name = "ClientOS", DbType = "NVarChar(64)")] 
			string clientOS
		)
		{
			IExecuteResult result = ExecuteMethodCall(this, ((MethodInfo)(MethodBase.GetCurrentMethod())), clientIP, clientOS);
			if (result == null)
				return null;

			return (ISingleResult<Traffic>)(result.ReturnValue);
		}

		[FunctionAttribute(Name = "[Logging].[NLog_FilteredBy_LogLevel]")]
		public ISingleResult<EventLog> SelectOnNLogAsFilteredByLogLevel
		(
			[ParameterAttribute(Name = "LogLevel", DbType = "NVarChar(32)")] 
			string logLevel
		)
		{
			IExecuteResult result = ExecuteMethodCall(this, ((MethodInfo)(MethodBase.GetCurrentMethod())), logLevel);
			if (result == null)
				return null;

			return (ISingleResult<EventLog>)(result.ReturnValue);
		}
	}
}
