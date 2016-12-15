﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;



[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Music")]
public partial class DataDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region 可扩展性方法定义
  partial void OnCreated();
  partial void Insertmusic(music instance);
  partial void Updatemusic(music instance);
  partial void Deletemusic(music instance);
  #endregion
	
	public DataDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["MusicConnectionString"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public DataDataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public DataDataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public DataDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public DataDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public System.Data.Linq.Table<music> music
	{
		get
		{
			return this.GetTable<music>();
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.music")]
public partial class music : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _id;
	
	private string _name;
	
	private string _who;
	
	private string _url;
	
	private System.Nullable<System.DateTime> _date;
	
	private System.Nullable<bool> _checked;
	
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnwhoChanging(string value);
    partial void OnwhoChanged();
    partial void OnurlChanging(string value);
    partial void OnurlChanged();
    partial void OndateChanging(System.Nullable<System.DateTime> value);
    partial void OndateChanged();
    partial void OncheckedChanging(System.Nullable<bool> value);
    partial void OncheckedChanged();
    #endregion
	
	public music()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int id
	{
		get
		{
			return this._id;
		}
		set
		{
			if ((this._id != value))
			{
				this.OnidChanging(value);
				this.SendPropertyChanging();
				this._id = value;
				this.SendPropertyChanged("id");
				this.OnidChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NVarChar(50)")]
	public string name
	{
		get
		{
			return this._name;
		}
		set
		{
			if ((this._name != value))
			{
				this.OnnameChanging(value);
				this.SendPropertyChanging();
				this._name = value;
				this.SendPropertyChanged("name");
				this.OnnameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_who", DbType="NVarChar(20)")]
	public string who
	{
		get
		{
			return this._who;
		}
		set
		{
			if ((this._who != value))
			{
				this.OnwhoChanging(value);
				this.SendPropertyChanging();
				this._who = value;
				this.SendPropertyChanged("who");
				this.OnwhoChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_url", DbType="NVarChar(255)")]
	public string url
	{
		get
		{
			return this._url;
		}
		set
		{
			if ((this._url != value))
			{
				this.OnurlChanging(value);
				this.SendPropertyChanging();
				this._url = value;
				this.SendPropertyChanged("url");
				this.OnurlChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_date", DbType="DateTime")]
	public System.Nullable<System.DateTime> date
	{
		get
		{
			return this._date;
		}
		set
		{
			if ((this._date != value))
			{
				this.OndateChanging(value);
				this.SendPropertyChanging();
				this._date = value;
				this.SendPropertyChanged("date");
				this.OndateChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Name="checked", Storage="_checked", DbType="Bit")]
	public System.Nullable<bool> @checked
	{
		get
		{
			return this._checked;
		}
		set
		{
			if ((this._checked != value))
			{
				this.OncheckedChanging(value);
				this.SendPropertyChanging();
				this._checked = value;
				this.SendPropertyChanged("@checked");
				this.OncheckedChanged();
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
#pragma warning restore 1591