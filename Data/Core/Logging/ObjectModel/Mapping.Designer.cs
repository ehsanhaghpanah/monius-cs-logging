/**
 * Copyright (C) moniüs, 2015.
 * All rights reserved.
 * E. Haghpanah; haghpanah@monius.net
 */

using System;
using System.ComponentModel;
using System.Data.Linq.Mapping;
using System.Runtime.Serialization;
using monius.Common.Data;
using ukey = System.String;

namespace monius.Logging.ObjectModel
{
	[Table(Name = "[Logging].[Mappings]")]
	partial class Mapping : INotifyPropertyChanging, INotifyPropertyChanged
	{
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		private readonly Data.DataContext _DataContext;

		/// <summary>
		/// 
		/// </summary>
		public Mapping()
		{
			OnCreated();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="dataContext">External DataContext to support Transactional Operations</param>
		public Mapping(System.Data.Linq.DataContext dataContext)
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
				return _Code;
			}
			protected set
			{
				if ((_Code != value))
				{
					OnPropertyChanging();
					_Code = value;
					OnPropertyChanged("Code");
				}
			}
		}

		#endregion

		#region Code

		private string _Code;

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		[ColumnAttribute(Name = "Code", Storage = "_Code", CanBeNull = false)]
		public string Code
		{
			get
			{
				return _Code;
			}
			set
			{
				if ((_Code != value))
				{
					OnPropertyChanging();
					_Code = value;
					OnPropertyChanged("Code");
				}
			}
		}

		#endregion

		#region Text

		private string _Text;

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		[Changeable]
		[ColumnAttribute(Name = "Text", Storage = "_Text", CanBeNull = false)]
		public string Text
		{
			get
			{
				return _Text;
			}
			set
			{
				if ((_Text != value))
				{
					OnPropertyChanging();
					_Text = value;
					OnPropertyChanged("Text");
				}
			}
		}

		#endregion

		#region Comments

		private string _Comments;

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		[Changeable]
		[ColumnAttribute(Name = "Comments", Storage = "_Comments")]
		public string Comments
		{
			get
			{
				return _Comments;
			}
			set
			{
				if ((_Comments != value))
				{
					OnPropertyChanging();
					_Comments = value;
					OnPropertyChanged("Comments");
				}
			}
		}

		#endregion

		#region MappedTo

		private string _MappedTo;

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		[Changeable]
		[ColumnAttribute(Name = "MappedTo", Storage = "_MappedTo")]
		public string MappedTo
		{
			get
			{
				return _MappedTo;
			}
			set
			{
				if ((_MappedTo != value))
				{
					OnPropertyChanging();
					_MappedTo = value;
					OnPropertyChanged("MappedTo");
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