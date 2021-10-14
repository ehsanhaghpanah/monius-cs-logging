/**
 * Copyright (C) moniüs, 2013.
 * All rights reserved.
 * E. Haghpanah; haghpanah@monius.net
 */

using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace monius.Logging.Data
{
	partial class DataContext : System.Data.Linq.DataContext
	{
		private static readonly MappingSource mappingSource = new AttributeMappingSource();

		public DataContext(string connection)
			: base(connection, mappingSource)
		{
			OnCreated();
		}

		public DataContext(IDbConnection connection)
			: base(connection, mappingSource)
		{
			OnCreated();
		}

		public DataContext(string connection, MappingSource mappingSource)
			: base(connection, mappingSource)
		{
			OnCreated();
		}

		public DataContext(IDbConnection connection, MappingSource mappingSource)
			: base(connection, mappingSource)
		{
			OnCreated();
		}

		#region Extensibility Method Definitions
		partial void OnCreated();
		#endregion

		public Table<monius.Logging.ObjectModel.Traffic> Traffics
		{
			get
			{
				return GetTable<monius.Logging.ObjectModel.Traffic>();
			}
		}
	}
}