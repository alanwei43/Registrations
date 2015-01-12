﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Registrations.Models
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="AlanTest")]
	public partial class RegistrationModel : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCollege(College instance);
    partial void UpdateCollege(College instance);
    partial void DeleteCollege(College instance);
    partial void InsertRegistration(Registration instance);
    partial void UpdateRegistration(Registration instance);
    partial void DeleteRegistration(Registration instance);
    #endregion
    public RegistrationModel() :
            base(global::System.Configuration.ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString, mappingSource)
        {
            OnCreated();
        }
		
		public RegistrationModel(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public RegistrationModel(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public RegistrationModel(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public RegistrationModel(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<College> Colleges
		{
			get
			{
				return this.GetTable<College>();
			}
		}
		
		public System.Data.Linq.Table<Registration> Registrations
		{
			get
			{
				return this.GetTable<Registration>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Colleges")]
	public partial class College : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private System.Guid _Gid;
		
		private string _Name;
		
		private System.Nullable<bool> _CanRegistrate;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnGidChanging(System.Guid value);
    partial void OnGidChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnCanRegistrateChanging(System.Nullable<bool> value);
    partial void OnCanRegistrateChanged();
    #endregion
		
		public College()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gid", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid Gid
		{
			get
			{
				return this._Gid;
			}
			set
			{
				if ((this._Gid != value))
				{
					this.OnGidChanging(value);
					this.SendPropertyChanging();
					this._Gid = value;
					this.SendPropertyChanged("Gid");
					this.OnGidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(500) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CanRegistrate", DbType="Bit")]
		public System.Nullable<bool> CanRegistrate
		{
			get
			{
				return this._CanRegistrate;
			}
			set
			{
				if ((this._CanRegistrate != value))
				{
					this.OnCanRegistrateChanging(value);
					this.SendPropertyChanging();
					this._CanRegistrate = value;
					this.SendPropertyChanged("CanRegistrate");
					this.OnCanRegistrateChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Registrations")]
	public partial class Registration : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private System.DateTime _RegistrateDate;
		
		private string _Name;
		
		private bool _Gender;
		
		private string _Phone;
		
		private decimal _Price;
		
		private string _CourseClass;
		
		private string _RegistrationAddress;
		
		private string _HomeAddress;
		
		private string _Payee;
		
		private string _CurrentGrade;
		
		private string _EducationDegree;
		
		private string _Note;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnRegistrateDateChanging(System.DateTime value);
    partial void OnRegistrateDateChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnGenderChanging(bool value);
    partial void OnGenderChanged();
    partial void OnPhoneChanging(string value);
    partial void OnPhoneChanged();
    partial void OnPriceChanging(decimal value);
    partial void OnPriceChanged();
    partial void OnCourseClassChanging(string value);
    partial void OnCourseClassChanged();
    partial void OnRegistrationAddressChanging(string value);
    partial void OnRegistrationAddressChanged();
    partial void OnHomeAddressChanging(string value);
    partial void OnHomeAddressChanged();
    partial void OnPayeeChanging(string value);
    partial void OnPayeeChanged();
    partial void OnCurrentGradeChanging(string value);
    partial void OnCurrentGradeChanged();
    partial void OnEducationDegreeChanging(string value);
    partial void OnEducationDegreeChanged();
    partial void OnNoteChanging(string value);
    partial void OnNoteChanged();
    #endregion
		
		public Registration()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RegistrateDate", DbType="DateTime NOT NULL")]
		public System.DateTime RegistrateDate
		{
			get
			{
				return this._RegistrateDate;
			}
			set
			{
				if ((this._RegistrateDate != value))
				{
					this.OnRegistrateDateChanging(value);
					this.SendPropertyChanging();
					this._RegistrateDate = value;
					this.SendPropertyChanged("RegistrateDate");
					this.OnRegistrateDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(500) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gender", DbType="Bit NOT NULL")]
		public bool Gender
		{
			get
			{
				return this._Gender;
			}
			set
			{
				if ((this._Gender != value))
				{
					this.OnGenderChanging(value);
					this.SendPropertyChanging();
					this._Gender = value;
					this.SendPropertyChanged("Gender");
					this.OnGenderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone", DbType="VarChar(500)")]
		public string Phone
		{
			get
			{
				return this._Phone;
			}
			set
			{
				if ((this._Phone != value))
				{
					this.OnPhoneChanging(value);
					this.SendPropertyChanging();
					this._Phone = value;
					this.SendPropertyChanged("Phone");
					this.OnPhoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Money NOT NULL")]
		public decimal Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this.OnPriceChanging(value);
					this.SendPropertyChanging();
					this._Price = value;
					this.SendPropertyChanged("Price");
					this.OnPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CourseClass", DbType="VarChar(500) NOT NULL", CanBeNull=false)]
		public string CourseClass
		{
			get
			{
				return this._CourseClass;
			}
			set
			{
				if ((this._CourseClass != value))
				{
					this.OnCourseClassChanging(value);
					this.SendPropertyChanging();
					this._CourseClass = value;
					this.SendPropertyChanged("CourseClass");
					this.OnCourseClassChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RegistrationAddress", DbType="VarChar(500) NOT NULL", CanBeNull=false)]
		public string RegistrationAddress
		{
			get
			{
				return this._RegistrationAddress;
			}
			set
			{
				if ((this._RegistrationAddress != value))
				{
					this.OnRegistrationAddressChanging(value);
					this.SendPropertyChanging();
					this._RegistrationAddress = value;
					this.SendPropertyChanged("RegistrationAddress");
					this.OnRegistrationAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HomeAddress", DbType="VarChar(500)")]
		public string HomeAddress
		{
			get
			{
				return this._HomeAddress;
			}
			set
			{
				if ((this._HomeAddress != value))
				{
					this.OnHomeAddressChanging(value);
					this.SendPropertyChanging();
					this._HomeAddress = value;
					this.SendPropertyChanged("HomeAddress");
					this.OnHomeAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Payee", DbType="VarChar(500)")]
		public string Payee
		{
			get
			{
				return this._Payee;
			}
			set
			{
				if ((this._Payee != value))
				{
					this.OnPayeeChanging(value);
					this.SendPropertyChanging();
					this._Payee = value;
					this.SendPropertyChanged("Payee");
					this.OnPayeeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CurrentGrade", DbType="VarChar(500)")]
		public string CurrentGrade
		{
			get
			{
				return this._CurrentGrade;
			}
			set
			{
				if ((this._CurrentGrade != value))
				{
					this.OnCurrentGradeChanging(value);
					this.SendPropertyChanging();
					this._CurrentGrade = value;
					this.SendPropertyChanged("CurrentGrade");
					this.OnCurrentGradeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EducationDegree", DbType="VarChar(500)")]
		public string EducationDegree
		{
			get
			{
				return this._EducationDegree;
			}
			set
			{
				if ((this._EducationDegree != value))
				{
					this.OnEducationDegreeChanging(value);
					this.SendPropertyChanging();
					this._EducationDegree = value;
					this.SendPropertyChanged("EducationDegree");
					this.OnEducationDegreeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Note", DbType="VarChar(MAX)", UpdateCheck=UpdateCheck.Never)]
		public string Note
		{
			get
			{
				return this._Note;
			}
			set
			{
				if ((this._Note != value))
				{
					this.OnNoteChanging(value);
					this.SendPropertyChanging();
					this._Note = value;
					this.SendPropertyChanged("Note");
					this.OnNoteChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
