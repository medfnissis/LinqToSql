﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LinqToSql
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Ecole")]
	public partial class EcoleDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Définitions de méthodes d'extensibilité
    partial void OnCreated();
    partial void InsertSTAGIAIRE(STAGIAIRE instance);
    partial void UpdateSTAGIAIRE(STAGIAIRE instance);
    partial void DeleteSTAGIAIRE(STAGIAIRE instance);
    #endregion
		
		public EcoleDataContext() : 
				base(global::LinqToSql.Properties.Settings.Default.EcoleConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public EcoleDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public EcoleDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public EcoleDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public EcoleDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<STAGIAIRE> STAGIAIRE
		{
			get
			{
				return this.GetTable<STAGIAIRE>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.STAGIAIRE")]
	public partial class STAGIAIRE : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _CIN;
		
		private string _NOM;
		
		private string _PRENOM;
		
    #region Définitions de méthodes d'extensibilité
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCINChanging(string value);
    partial void OnCINChanged();
    partial void OnNOMChanging(string value);
    partial void OnNOMChanged();
    partial void OnPRENOMChanging(string value);
    partial void OnPRENOMChanged();
    #endregion
		
		public STAGIAIRE()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CIN", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string CIN
		{
			get
			{
				return this._CIN;
			}
			set
			{
				if ((this._CIN != value))
				{
					this.OnCINChanging(value);
					this.SendPropertyChanging();
					this._CIN = value;
					this.SendPropertyChanged("CIN");
					this.OnCINChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NOM", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string NOM
		{
			get
			{
				return this._NOM;
			}
			set
			{
				if ((this._NOM != value))
				{
					this.OnNOMChanging(value);
					this.SendPropertyChanging();
					this._NOM = value;
					this.SendPropertyChanged("NOM");
					this.OnNOMChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PRENOM", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string PRENOM
		{
			get
			{
				return this._PRENOM;
			}
			set
			{
				if ((this._PRENOM != value))
				{
					this.OnPRENOMChanging(value);
					this.SendPropertyChanging();
					this._PRENOM = value;
					this.SendPropertyChanged("PRENOM");
					this.OnPRENOMChanged();
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
