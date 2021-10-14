/**
 * Copyright (C) moniüs, 2017.
 * All rights reserved.
 * E. Haghpanah; haghpanah@monius.net
 */

using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Renegade.Demote
{
	[TestClass]
	public class Traffics
	{
		[TestMethod]
		public void test_log()
		{
			var l1 = monius.Logging.Traffics.GetAll();
			var n1 = l1.Count();

			var client_ip = Generator.get_ip();
			var client_os = Generator.get_os();
			var time_span = Generator.get_timeSpan();
			var request = Generator.get_string(8);
			var respond = Generator.get_string(8);
			
			monius.Logging.Traffics.Log(client_ip, client_os, time_span, request, respond);

			var l2 = monius.Logging.Traffics.GetAll();
			var n2 = l2.Count();

			Assert.IsTrue(n2 == n1 + 1);
		}
	}
}