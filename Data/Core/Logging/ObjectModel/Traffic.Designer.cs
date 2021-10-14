/**
 * Copyright (C) moniüs, 2013.
 * All rights reserved.
 * E. Haghpanah; haghpanah@monius.net
 */

using System;
using System.ComponentModel;
using System.Data.Linq.Mapping;
using System.Runtime.Serialization;
using ukey = System.String;

namespace monius.Logging.ObjectModel
{
	[TableAttribute(Name = "[Logging].[Traffics]")]
	partial class Traffic : INotifyPropertyChanging, INotifyPropertyChanged
	{
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		private readonly Data.DataContext _DataContext;

		/// <summary>
		/// 
		/// </summary>
		public Traffic()
		{
			OnCreated();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="dataContext">External DataContext to support Transactional Operations</param>
		public Traffic(System.Data.Linq.DataContext dataContext)
			: this()
		{
			if (dataContext is Data.DataContext)
				_DataContext = (Data.DataContext)dataContext;
			else
				_DataContext = new Data.DataContext(dataContext.Connection);
		}

		#region Extensibility Method Definitions
		partial void OnLoaded();
		partial void OnValidate(System.Data.Linq.ChangeAction action);
		partial void OnCreated();
		#endregion

		#region Id

		private long _Id = default(long);

		[DataMember]
		[ColumnAttribute(Storage = "_Id", AutoSync = AutoSync.OnInsert, IsPrimaryKey = true, IsDbGenerated = true, UpdateCheck = UpdateCheck.Never)]
		public override long Id
		{
			get
			{
				return _Id;
			}
			protected set
			{
				if ((_Id != value))
				{
					OnPropertyChanging();
					_Id = value;
					OnPropertyChanged("Id");
				}
			}
		}

		#endregion

		#region Ky

		[DataMember]
		public override ukey Ky
		{
			get
			{
				return _ClientIP + "@" + _LoggedAt.ToString();
			}
			protected set
			{
				// just for compatability
			}
		}

		#endregion

		#region LoggedAt

		private DateTime _LoggedAt;

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		[ColumnAttribute(Name = "LoggedAt", Storage = "_LoggedAt", IsDbGenerated = true, UpdateCheck = UpdateCheck.Never)]
		public DateTime LoggedAt
		{
			get
			{
				return _LoggedAt;
			}
			set
			{
				if ((_LoggedAt != value))
				{
					OnPropertyChanging();
					_LoggedAt = value;
					OnPropertyChanged("LoggedAt");
				}
			}
		}

		#endregion

		#region ClientIP

		private string _ClientIP;

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		[ColumnAttribute(Name = "ClientIP", Storage = "_ClientIP", CanBeNull = false)]
		public string ClientIP
		{
			get
			{
				return _ClientIP;
			}
			set
			{
				if ((_ClientIP != value))
				{
					OnPropertyChanging();
					_ClientIP = value;
					OnPropertyChanged("ClientIP");
				}
			}
		}

		#endregion

		#region ClientOS

		private string _ClientOS;

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		[ColumnAttribute(Name = "ClientOS", Storage = "_ClientOS", CanBeNull = false)]
		public string ClientOS
		{
			get
			{
				return _ClientOS;
			}
			set
			{
				if ((_ClientOS != value))
				{
					OnPropertyChanging();
					_ClientOS = value;
					OnPropertyChanged("ClientOS");
				}
			}
		}

		#endregion

		#region TimeSpan

		private long _TimeSpan;

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		[ColumnAttribute(Name = "TimeSpan", Storage = "_TimeSpan")]
		public long TimeSpan
		{
			get
			{
				return _TimeSpan;
			}
			set
			{
				if ((_TimeSpan != value))
				{
					OnPropertyChanging();
					_TimeSpan = value;
					OnPropertyChanged("TimeSpan");
				}
			}
		}

		#endregion

		#region Request

		private string _Request;

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		[ColumnAttribute(Name = "Request", Storage = "_Request")]
		public string Request
		{
			get
			{
				return _Request;
			}
			set
			{
				if ((_Request != value))
				{
					OnPropertyChanging();
					_Request = value;
					OnPropertyChanged("Request");
				}
			}
		}

		#endregion

		#region Respond

		private string _Respond;

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		[ColumnAttribute(Name = "Respond", Storage = "_Respond")]
		public string Respond
		{
			get
			{
				return _Respond;
			}
			set
			{
				if ((_Respond != value))
				{
					OnPropertyChanging();
					_Respond = value;
					OnPropertyChanged("Respond");
				}
			}
		}

		#endregion

		#region NotifyPropertyChanging, NotifyProperyChanged

		/// <summary>
		/// 
		/// </summary>
		public event PropertyChangingEventHandler PropertyChanging;

		/// <summary>
		/// 
		/// </summary>
		public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
		/// 
		/// </summary>
		private void OnPropertyChanging()
		{
			if ((PropertyChanging != null))
			{
				PropertyChanging(this, emptyChangingEventArgs);
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="propertyName"></param>
		private void OnPropertyChanged(String propertyName)
		{
			if ((PropertyChanged != null))
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion
	}
}
