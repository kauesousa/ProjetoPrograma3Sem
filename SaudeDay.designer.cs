#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SaudeDay.DAL
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="db_saudeday")]
	public partial class SaudeDayDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertRemedioo(Remedioo instance);
    partial void UpdateRemedioo(Remedioo instance);
    partial void DeleteRemedioo(Remedioo instance);
    #endregion
		
		public SaudeDayDataContext() : 
				base(global::SaudeDay.DAL.Properties.Settings.Default.db_saudedayConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public SaudeDayDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SaudeDayDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SaudeDayDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SaudeDayDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Remedioo> Remedioo
		{
			get
			{
				return this.GetTable<Remedioo>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tb_remedio")]
	public partial class Remedioo : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Codigo;
		
		private string _Remedio;
		
		private string _HoraMarcada;
		
		private string _Descricao;
		
		private string _HoraTomou;
		
		private string _Quantidade;
		
		private string _Medida;
		
		private System.Nullable<System.DateTime> _DataMarcada;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCodigoChanging(int value);
    partial void OnCodigoChanged();
    partial void OnRemedioChanging(string value);
    partial void OnRemedioChanged();
    partial void OnHoraMarcadaChanging(string value);
    partial void OnHoraMarcadaChanged();
    partial void OnDescricaoChanging(string value);
    partial void OnDescricaoChanged();
    partial void OnHoraTomouChanging(string value);
    partial void OnHoraTomouChanged();
    partial void OnQuantidadeChanging(string value);
    partial void OnQuantidadeChanged();
    partial void OnMedidaChanging(string value);
    partial void OnMedidaChanged();
    partial void OnDataMarcadaChanging(System.Nullable<System.DateTime> value);
    partial void OnDataMarcadaChanged();
    #endregion
		
		public Remedioo()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="id_remedio", Storage="_Codigo", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Codigo
		{
			get
			{
				return this._Codigo;
			}
			set
			{
				if ((this._Codigo != value))
				{
					this.OnCodigoChanging(value);
					this.SendPropertyChanging();
					this._Codigo = value;
					this.SendPropertyChanged("Codigo");
					this.OnCodigoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="nome_remedio", Storage="_Remedio", DbType="VarChar(50)")]
		public string Remedio
		{
			get
			{
				return this._Remedio;
			}
			set
			{
				if ((this._Remedio != value))
				{
					this.OnRemedioChanging(value);
					this.SendPropertyChanging();
					this._Remedio = value;
					this.SendPropertyChanged("Remedio");
					this.OnRemedioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="hora_marcada", Storage="_HoraMarcada", DbType="VarChar(50)")]
		public string HoraMarcada
		{
			get
			{
				return this._HoraMarcada;
			}
			set
			{
				if ((this._HoraMarcada != value))
				{
					this.OnHoraMarcadaChanging(value);
					this.SendPropertyChanging();
					this._HoraMarcada = value;
					this.SendPropertyChanged("HoraMarcada");
					this.OnHoraMarcadaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="descricao", Storage="_Descricao", DbType="VarChar(50)")]
		public string Descricao
		{
			get
			{
				return this._Descricao;
			}
			set
			{
				if ((this._Descricao != value))
				{
					this.OnDescricaoChanging(value);
					this.SendPropertyChanging();
					this._Descricao = value;
					this.SendPropertyChanged("Descricao");
					this.OnDescricaoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="hora_tomou", Storage="_HoraTomou", DbType="VarChar(50)")]
		public string HoraTomou
		{
			get
			{
				return this._HoraTomou;
			}
			set
			{
				if ((this._HoraTomou != value))
				{
					this.OnHoraTomouChanging(value);
					this.SendPropertyChanging();
					this._HoraTomou = value;
					this.SendPropertyChanged("HoraTomou");
					this.OnHoraTomouChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="quantidade", Storage="_Quantidade", DbType="VarChar(10)")]
		public string Quantidade
		{
			get
			{
				return this._Quantidade;
			}
			set
			{
				if ((this._Quantidade != value))
				{
					this.OnQuantidadeChanging(value);
					this.SendPropertyChanging();
					this._Quantidade = value;
					this.SendPropertyChanged("Quantidade");
					this.OnQuantidadeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="medida", Storage="_Medida", DbType="VarChar(20)")]
		public string Medida
		{
			get
			{
				return this._Medida;
			}
			set
			{
				if ((this._Medida != value))
				{
					this.OnMedidaChanging(value);
					this.SendPropertyChanging();
					this._Medida = value;
					this.SendPropertyChanged("Medida");
					this.OnMedidaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="data_marcada", Storage="_DataMarcada", DbType="Date")]
		public System.Nullable<System.DateTime> DataMarcada
		{
			get
			{
				return this._DataMarcada;
			}
			set
			{
				if ((this._DataMarcada != value))
				{
					this.OnDataMarcadaChanging(value);
					this.SendPropertyChanging();
					this._DataMarcada = value;
					this.SendPropertyChanged("DataMarcada");
					this.OnDataMarcadaChanged();
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
