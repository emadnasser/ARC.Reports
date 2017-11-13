﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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



[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="WebmailClient")]
public partial class WebmailClientDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region Extensibility Method Definitions
  partial void OnCreated();
  partial void InsertDBContact(DBContact instance);
  partial void UpdateDBContact(DBContact instance);
  partial void DeleteDBContact(DBContact instance);
  partial void InsertDBMessage(DBMessage instance);
  partial void UpdateDBMessage(DBMessage instance);
  partial void DeleteDBMessage(DBMessage instance);
  #endregion
	
	public WebmailClientDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["WebmailClientConnectionString"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public WebmailClientDataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public WebmailClientDataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public WebmailClientDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public WebmailClientDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public System.Data.Linq.Table<DBContact> DBContacts
	{
		get
		{
			return this.GetTable<DBContact>();
		}
	}
	
	public System.Data.Linq.Table<DBMessage> DBMessages
	{
		get
		{
			return this.GetTable<DBMessage>();
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Contacts")]
public partial class DBContact : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ID;
	
	private string _Name;
	
	private string _Email;
	
	private string _Address;
	
	private string _Country;
	
	private string _City;
	
	private string _Phone;
	
	private string _PhotoUrl;
	
	private bool _Collected;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    partial void OnCountryChanging(string value);
    partial void OnCountryChanged();
    partial void OnCityChanging(string value);
    partial void OnCityChanged();
    partial void OnPhoneChanging(string value);
    partial void OnPhoneChanged();
    partial void OnPhotoUrlChanging(string value);
    partial void OnPhotoUrlChanged();
    partial void OnCollectedChanging(bool value);
    partial void OnCollectedChanged();
    #endregion
	
	public DBContact()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int ID
	{
		get
		{
			return this._ID;
		}
		set
		{
			if ((this._ID != value))
			{
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._ID = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50)")]
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
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
	public string Email
	{
		get
		{
			return this._Email;
		}
		set
		{
			if ((this._Email != value))
			{
				this.OnEmailChanging(value);
				this.SendPropertyChanging();
				this._Email = value;
				this.SendPropertyChanged("Email");
				this.OnEmailChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="NVarChar(50)")]
	public string Address
	{
		get
		{
			return this._Address;
		}
		set
		{
			if ((this._Address != value))
			{
				this.OnAddressChanging(value);
				this.SendPropertyChanging();
				this._Address = value;
				this.SendPropertyChanged("Address");
				this.OnAddressChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Country", DbType="NVarChar(50)")]
	public string Country
	{
		get
		{
			return this._Country;
		}
		set
		{
			if ((this._Country != value))
			{
				this.OnCountryChanging(value);
				this.SendPropertyChanging();
				this._Country = value;
				this.SendPropertyChanged("Country");
				this.OnCountryChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_City", DbType="NVarChar(50)")]
	public string City
	{
		get
		{
			return this._City;
		}
		set
		{
			if ((this._City != value))
			{
				this.OnCityChanging(value);
				this.SendPropertyChanging();
				this._City = value;
				this.SendPropertyChanged("City");
				this.OnCityChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone", DbType="NVarChar(32)")]
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
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PhotoUrl", DbType="NVarChar(128)")]
	public string PhotoUrl
	{
		get
		{
			return this._PhotoUrl;
		}
		set
		{
			if ((this._PhotoUrl != value))
			{
				this.OnPhotoUrlChanging(value);
				this.SendPropertyChanging();
				this._PhotoUrl = value;
				this.SendPropertyChanged("PhotoUrl");
				this.OnPhotoUrlChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Collected", DbType="Bit NOT NULL")]
	public bool Collected
	{
		get
		{
			return this._Collected;
		}
		set
		{
			if ((this._Collected != value))
			{
				this.OnCollectedChanging(value);
				this.SendPropertyChanging();
				this._Collected = value;
				this.SendPropertyChanged("Collected");
				this.OnCollectedChanged();
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

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Messages")]
public partial class DBMessage : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ID;
	
	private System.DateTime _Date;
	
	private string _Subject;
	
	private string _From;
	
	private string _To;
	
	private string _Text;
	
	private string _Folder;
	
	private bool _Unread;
	
	private bool _HasAttachment;
	
	private bool _IsReply;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnDateChanging(System.DateTime value);
    partial void OnDateChanged();
    partial void OnSubjectChanging(string value);
    partial void OnSubjectChanged();
    partial void OnFromChanging(string value);
    partial void OnFromChanged();
    partial void OnToChanging(string value);
    partial void OnToChanged();
    partial void OnTextChanging(string value);
    partial void OnTextChanged();
    partial void OnFolderChanging(string value);
    partial void OnFolderChanged();
    partial void OnUnreadChanging(bool value);
    partial void OnUnreadChanged();
    partial void OnHasAttachmentChanging(bool value);
    partial void OnHasAttachmentChanged();
    partial void OnIsReplyChanging(bool value);
    partial void OnIsReplyChanged();
    #endregion
	
	public DBMessage()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int ID
	{
		get
		{
			return this._ID;
		}
		set
		{
			if ((this._ID != value))
			{
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._ID = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date", DbType="DateTime NOT NULL")]
	public System.DateTime Date
	{
		get
		{
			return this._Date;
		}
		set
		{
			if ((this._Date != value))
			{
				this.OnDateChanging(value);
				this.SendPropertyChanging();
				this._Date = value;
				this.SendPropertyChanged("Date");
				this.OnDateChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Subject", DbType="NVarChar(128) NOT NULL", CanBeNull=false)]
	public string Subject
	{
		get
		{
			return this._Subject;
		}
		set
		{
			if ((this._Subject != value))
			{
				this.OnSubjectChanging(value);
				this.SendPropertyChanging();
				this._Subject = value;
				this.SendPropertyChanged("Subject");
				this.OnSubjectChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[From]", Storage="_From", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
	public string From
	{
		get
		{
			return this._From;
		}
		set
		{
			if ((this._From != value))
			{
				this.OnFromChanging(value);
				this.SendPropertyChanging();
				this._From = value;
				this.SendPropertyChanged("From");
				this.OnFromChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[To]", Storage="_To", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
	public string To
	{
		get
		{
			return this._To;
		}
		set
		{
			if ((this._To != value))
			{
				this.OnToChanging(value);
				this.SendPropertyChanging();
				this._To = value;
				this.SendPropertyChanged("To");
				this.OnToChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Text", DbType="NVarChar(MAX)")]
	public string Text
	{
		get
		{
			return this._Text;
		}
		set
		{
			if ((this._Text != value))
			{
				this.OnTextChanging(value);
				this.SendPropertyChanging();
				this._Text = value;
				this.SendPropertyChanged("Text");
				this.OnTextChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Folder", DbType="NVarChar(32)")]
	public string Folder
	{
		get
		{
			return this._Folder;
		}
		set
		{
			if ((this._Folder != value))
			{
				this.OnFolderChanging(value);
				this.SendPropertyChanging();
				this._Folder = value;
				this.SendPropertyChanged("Folder");
				this.OnFolderChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Unread", DbType="Bit NOT NULL")]
	public bool Unread
	{
		get
		{
			return this._Unread;
		}
		set
		{
			if ((this._Unread != value))
			{
				this.OnUnreadChanging(value);
				this.SendPropertyChanging();
				this._Unread = value;
				this.SendPropertyChanged("Unread");
				this.OnUnreadChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HasAttachment", DbType="Bit NOT NULL")]
	public bool HasAttachment
	{
		get
		{
			return this._HasAttachment;
		}
		set
		{
			if ((this._HasAttachment != value))
			{
				this.OnHasAttachmentChanging(value);
				this.SendPropertyChanging();
				this._HasAttachment = value;
				this.SendPropertyChanged("HasAttachment");
				this.OnHasAttachmentChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsReply", DbType="Bit NOT NULL")]
	public bool IsReply
	{
		get
		{
			return this._IsReply;
		}
		set
		{
			if ((this._IsReply != value))
			{
				this.OnIsReplyChanging(value);
				this.SendPropertyChanging();
				this._IsReply = value;
				this.SendPropertyChanged("IsReply");
				this.OnIsReplyChanged();
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