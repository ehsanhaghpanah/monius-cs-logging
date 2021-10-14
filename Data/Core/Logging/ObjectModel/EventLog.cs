/**
 * Copyright (C) moniüs, 2015.
 * All rights reserved.
 * E. Haghpanah; haghpanah@monius.net
 */

using System;

namespace monius.Logging.ObjectModel
{
	/// <summary>
	/// 
	/// </summary>
	public sealed class EventLog 
	{
		/// <summary>
		/// 
		/// </summary>
		public string ServerId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public DateTime LoggedAt { get; set; }
		
		/// <summary>
		/// 
		/// </summary>
		public string LogLevel { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public string LoggedBy { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public string CallSite { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public string Message { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public string Exception { get; set; }
	}
}