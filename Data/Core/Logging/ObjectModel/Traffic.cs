/**
 * Copyright (C) moniüs, 2013.
 * All rights reserved.
 * E. Haghpanah; haghpanah@monius.net
 */

using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Runtime.Serialization;
using monius.Common.Core.Data.Validation;
using monius.Common.Data;

namespace monius.Logging.ObjectModel
{
	/// <summary>
	/// 
	/// </summary>
	[DataContract]
	public sealed partial class Traffic : Entity, Modeling.ITraffic
	{
		#region —— Overrides ——

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return (_LoggedAt.ToString());
		}

		protected override IEnumerable<RuleViolation> CatchRuleViolations(ChangeAction action)
		{
			//
			// ClientIP
			//
			if (string.IsNullOrEmpty(_ClientIP))
				yield return (new RuleViolation("Required", "ClientIP"));

			//
			// ClientOS
			//
			if (string.IsNullOrEmpty(_ClientOS))
				yield return (new RuleViolation("Required", "ClientOS"));
		}

		public override bool CanChange()
		{
			return false;
		}

		public override bool CanRemove()
		{
			return false;
		}

		public override void SaveChanges()
		{
		}

		#endregion

		#region —— Partials  ——

		/// <summary>
		/// 
		/// </summary>
		/// <param name="action"></param>
		partial void OnValidate(ChangeAction action)
		{
			var ls = CatchRuleViolations(action);
			var violations = ls as RuleViolation[] ?? ls.ToArray();
			if (violations.Count() != 0)
				throw new RuleViolationException(violations);
		}

		#endregion

		/// <summary>
		/// 
		/// </summary>
		public TimeSpan Duration
		{
			get
			{
				return new TimeSpan(_TimeSpan);
			}
		}
	}
}