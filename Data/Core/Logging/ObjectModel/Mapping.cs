/**
 * Copyright (C) moniüs, 2015.
 * All rights reserved.
 * E. Haghpanah; haghpanah@monius.net
 */

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
	public sealed partial class Mapping : Entity, Modeling.IMapping
	{
		#region —— Overrides ——

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return (_Code);
		}

		protected override IEnumerable<RuleViolation> CatchRuleViolations(ChangeAction action)
		{
			//
			// Code
			//
			if (string.IsNullOrEmpty(_Code))
				yield return (new RuleViolation("Required", "Code"));
		}

		public override bool CanChange()
		{
			return true;
		}

		public override bool CanRemove()
		{
			return true;
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
	}
}