#region Auto-generated classes for trustdb database on 2012-01-11 15:54:10Z

//
//  ____  _     __  __      _        _
// |  _ \| |__ |  \/  | ___| |_ __ _| |
// | | | | '_ \| |\/| |/ _ \ __/ _` | |
// | |_| | |_) | |  | |  __/ || (_| | |
// |____/|_.__/|_|  |_|\___|\__\__,_|_|
//
// Auto-generated from trustdb on 2012-01-11 15:54:10Z
// Please visit http://linq.to/db for more information

#endregion

using System;
using System.Data;
using System.Data.Linq.Mapping;
using System.Diagnostics;
using System.Reflection;
#if MONO_STRICT
using System.Data.Linq;
#else   // MONO_STRICT
using DbLinq.Data.Linq;
using DbLinq.Vendor;
#endif  // MONO_STRICT
using System.ComponentModel;

namespace Datos
{
	public partial class TrustDb : DataContext
	{
		#region Extensibility Method Definitions

		partial void OnCreated();

		#endregion

		public TrustDb(string connectionString)
			: base(connectionString)
		{
			OnCreated();
		}

		public TrustDb(IDbConnection connection)
		#if MONO_STRICT
			: base(connection)
		#else   // MONO_STRICT
			: base(connection, new DbLinq.MySql.MySqlVendor())
		#endif  // MONO_STRICT
		{
			OnCreated();
		}

		public TrustDb(string connection, MappingSource mappingSource)
			: base(connection, mappingSource)
		{
			OnCreated();
		}

		public TrustDb(IDbConnection connection, MappingSource mappingSource)
			: base(connection, mappingSource)
		{
			OnCreated();
		}

		#if !MONO_STRICT
		public TrustDb(IDbConnection connection, IVendor vendor)
			: base(connection, vendor)
		{
			OnCreated();
		}
		#endif  // !MONO_STRICT

		#if !MONO_STRICT
		public TrustDb(IDbConnection connection, MappingSource mappingSource, IVendor vendor)
			: base(connection, mappingSource, vendor)
		{
			OnCreated();
		}
		#endif  // !MONO_STRICT

		public Table<BanCos> BanCos { get { return GetTable<BanCos>(); } }
		public Table<BarrioS> BarrioS { get { return GetTable<BarrioS>(); } }
		public Table<CIudAdEs> CIudAdEs { get { return GetTable<CIudAdEs>(); } }
		public Table<ClientEs> ClientEs { get { return GetTable<ClientEs>(); } }
		public Table<ConsultAsClientEs> ConsultAsClientEs { get { return GetTable<ConsultAsClientEs>(); } }
		public Table<ConsultAsEmPleadOs> ConsultAsEmPleadOs { get { return GetTable<ConsultAsEmPleadOs>(); } }
		public Table<ContraToS> ContraToS { get { return GetTable<ContraToS>(); } }
		public Table<CuOtAsExtrasLiquidAcIon> CuOtAsExtrasLiquidAcIon { get { return GetTable<CuOtAsExtrasLiquidAcIon>(); } }
		public Table<DepartAmenToS> DepartAmenToS { get { return GetTable<DepartAmenToS>(); } }
		public Table<EmergeNcIasMedicA> EmergeNcIasMedicA { get { return GetTable<EmergeNcIasMedicA>(); } }
		public Table<EmPleadOs> EmPleadOs { get { return GetTable<EmPleadOs>(); } }
		public Table<EnterOs> EnterOs { get { return GetTable<EnterOs>(); } }
		public Table<EScalaFOn> EScalaFOn { get { return GetTable<EScalaFOn>(); } }
		public Table<EScalaFOneMpLeadO> EScalaFOneMpLeadO { get { return GetTable<EScalaFOneMpLeadO>(); } }
		public Table<EventOsHistOrIalEmPleadO> EventOsHistOrIalEmPleadO { get { return GetTable<EventOsHistOrIalEmPleadO>(); } }
		public Table<ExtrasLiquidAcIon> ExtrasLiquidAcIon { get { return GetTable<ExtrasLiquidAcIon>(); } }
		public Table<ExtrasLiquidAcIonEmPleadO> ExtrasLiquidAcIonEmPleadO { get { return GetTable<ExtrasLiquidAcIonEmPleadO>(); } }
		public Table<FeCHaEScalaFOncerRadO> FeCHaEScalaFOncerRadO { get { return GetTable<FeCHaEScalaFOncerRadO>(); } }
		public Table<FeRiAdoS> FeRiAdoS { get { return GetTable<FeRiAdoS>(); } }
		public Table<GRuPOs> GRuPOs { get { return GetTable<GRuPOs>(); } }
		public Table<HoRaRioDiA> HoRaRioDiA { get { return GetTable<HoRaRioDiA>(); } }
		public Table<HoRaRioEScalaFOn> HoRaRioEScalaFOn { get { return GetTable<HoRaRioEScalaFOn>(); } }
		public Table<HoRaSComUnescoNtRatOs> HoRaSComUnescoNtRatOs { get { return GetTable<HoRaSComUnescoNtRatOs>(); } }
		public Table<HoRaSGeneraDaSEScalaFOn> HoRaSGeneraDaSEScalaFOn { get { return GetTable<HoRaSGeneraDaSEScalaFOn>(); } }
		public Table<HsComUnEsAdICIonAleSLiquidAcIonEmPleadO> HsComUnEsAdICIonAleSLiquidAcIonEmPleadO { get { return GetTable<HsComUnEsAdICIonAleSLiquidAcIonEmPleadO>(); } }
		public Table<LineAshOrAs> LineAshOrAs { get { return GetTable<LineAshOrAs>(); } }
		public Table<LiquidAcIonEmPleadOs> LiquidAcIonEmPleadOs { get { return GetTable<LiquidAcIonEmPleadOs>(); } }
		public Table<ListAnEGRa> ListAnEGRa { get { return GetTable<ListAnEGRa>(); } }
		public Table<LogeVentO> LogeVentO { get { return GetTable<LogeVentO>(); } }
		public Table<MotIVOsCamBiosDiARioS> MotIVOsCamBiosDiARioS { get { return GetTable<MotIVOsCamBiosDiARioS>(); } }
		public Table<MutualIsTAs> MutualIsTAs { get { return GetTable<MutualIsTAs>(); } }
		public Table<PantAllAwInForm> PantAllAwInForm { get { return GetTable<PantAllAwInForm>(); } }
		public Table<PerMisOControl> PerMisOControl { get { return GetTable<PerMisOControl>(); } }
		public Table<PerMisOs> PerMisOs { get { return GetTable<PerMisOs>(); } }
		public Table<SERVicIoS> SERVicIoS { get { return GetTable<SERVicIoS>(); } }
		public Table<TipOContraToS> TipOContraToS { get { return GetTable<TipOContraToS>(); } }
		public Table<TipOeMpLeadO> TipOeMpLeadO { get { return GetTable<TipOeMpLeadO>(); } }
		public Table<TipOExtraLiquidAcIon> TipOExtraLiquidAcIon { get { return GetTable<TipOExtraLiquidAcIon>(); } }
		public Table<TipOscarGoS> TipOscarGoS { get { return GetTable<TipOscarGoS>(); } }
		public Table<TipOsDiAs> TipOsDiAs { get { return GetTable<TipOsDiAs>(); } }
		public Table<TipOsDocumentO> TipOsDocumentO { get { return GetTable<TipOsDocumentO>(); } }
		public Table<TipOsEventOHistOrIal> TipOsEventOHistOrIal { get { return GetTable<TipOsEventOHistOrIal>(); } }
		public Table<TipOsMotIVOCamBIoDiARio> TipOsMotIVOCamBIoDiARio { get { return GetTable<TipOsMotIVOCamBIoDiARio>(); } }
		public Table<UsUarIoS> UsUarIoS { get { return GetTable<UsUarIoS>(); } }
		public Table<UsUarIoSGRuPOs> UsUarIoSGRuPOs { get { return GetTable<UsUarIoSGRuPOs>(); } }

	}

	[Table(Name = "trustdb.bancos")]
	public partial class BanCos : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region INotifyPropertyChanging handling

		public event PropertyChangingEventHandler PropertyChanging;

		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs("");
		protected virtual void SendPropertyChanging()
		{
			if (PropertyChanging != null)
			{
				PropertyChanging(this, emptyChangingEventArgs);
			}
		}

		#endregion

		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void SendPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region Extensibility Method Definitions

		partial void OnCreated();
		partial void OnIDBancoChanged();
		partial void OnIDBancoChanging(byte value);
		partial void OnNombreChanged();
		partial void OnNombreChanging(string value);

		#endregion

		#region byte IDBanco

		private byte _idbAnco;
		[DebuggerNonUserCode]
		[Column(Storage = "_idbAnco", Name = "IdBanco", DbType = "tinyint(2) unsigned", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false)]
		public byte IDBanco
		{
			get
			{
				return _idbAnco;
			}
			set
			{
				if (value != _idbAnco)
				{
					OnIDBancoChanging(value);
					SendPropertyChanging();
					_idbAnco = value;
					SendPropertyChanged("IDBanco");
					OnIDBancoChanged();
				}
			}
		}

		#endregion

		#region string Nombre

		private string _nombre;
		[DebuggerNonUserCode]
		[Column(Storage = "_nombre", Name = "Nombre", DbType = "varchar(50)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public string Nombre
		{
			get
			{
				return _nombre;
			}
			set
			{
				if (value != _nombre)
				{
					OnNombreChanging(value);
					SendPropertyChanging();
					_nombre = value;
					SendPropertyChanged("Nombre");
					OnNombreChanged();
				}
			}
		}

		#endregion

		#region ctor

		public BanCos()
		{
			OnCreated();
		}

		#endregion

	}

	[Table(Name = "trustdb.barrios")]
	public partial class BarrioS : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region INotifyPropertyChanging handling

		public event PropertyChangingEventHandler PropertyChanging;

		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs("");
		protected virtual void SendPropertyChanging()
		{
			if (PropertyChanging != null)
			{
				PropertyChanging(this, emptyChangingEventArgs);
			}
		}

		#endregion

		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void SendPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region Extensibility Method Definitions

		partial void OnCreated();
		partial void OnIDBarrioChanged();
		partial void OnIDBarrioChanging(ushort value);
		partial void OnNombreChanged();
		partial void OnNombreChanging(string value);

		#endregion

		#region ushort IDBarrio

		private ushort _idbArrio;
		[DebuggerNonUserCode]
		[Column(Storage = "_idbArrio", Name = "IdBarrio", DbType = "smallint(5) unsigned", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false)]
		public ushort IDBarrio
		{
			get
			{
				return _idbArrio;
			}
			set
			{
				if (value != _idbArrio)
				{
					OnIDBarrioChanging(value);
					SendPropertyChanging();
					_idbArrio = value;
					SendPropertyChanged("IDBarrio");
					OnIDBarrioChanged();
				}
			}
		}

		#endregion

		#region string Nombre

		private string _nombre;
		[DebuggerNonUserCode]
		[Column(Storage = "_nombre", Name = "Nombre", DbType = "varchar(50)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public string Nombre
		{
			get
			{
				return _nombre;
			}
			set
			{
				if (value != _nombre)
				{
					OnNombreChanging(value);
					SendPropertyChanging();
					_nombre = value;
					SendPropertyChanged("Nombre");
					OnNombreChanged();
				}
			}
		}

		#endregion

		#region ctor

		public BarrioS()
		{
			OnCreated();
		}

		#endregion

	}

	[Table(Name = "trustdb.ciudades")]
	public partial class CIudAdEs : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region INotifyPropertyChanging handling

		public event PropertyChangingEventHandler PropertyChanging;

		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs("");
		protected virtual void SendPropertyChanging()
		{
			if (PropertyChanging != null)
			{
				PropertyChanging(this, emptyChangingEventArgs);
			}
		}

		#endregion

		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void SendPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region Extensibility Method Definitions

		partial void OnCreated();
		partial void OnIDCiudadesChanged();
		partial void OnIDCiudadesChanging(byte value);
		partial void OnNombreChanged();
		partial void OnNombreChanging(string value);

		#endregion

		#region byte IDCiudades

		private byte _idcIudades;
		[DebuggerNonUserCode]
		[Column(Storage = "_idcIudades", Name = "IdCiudades", DbType = "tinyint(2) unsigned", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false)]
		public byte IDCiudades
		{
			get
			{
				return _idcIudades;
			}
			set
			{
				if (value != _idcIudades)
				{
					OnIDCiudadesChanging(value);
					SendPropertyChanging();
					_idcIudades = value;
					SendPropertyChanged("IDCiudades");
					OnIDCiudadesChanged();
				}
			}
		}

		#endregion

		#region string Nombre

		private string _nombre;
		[DebuggerNonUserCode]
		[Column(Storage = "_nombre", Name = "Nombre", DbType = "varchar(50)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public string Nombre
		{
			get
			{
				return _nombre;
			}
			set
			{
				if (value != _nombre)
				{
					OnNombreChanging(value);
					SendPropertyChanging();
					_nombre = value;
					SendPropertyChanged("Nombre");
					OnNombreChanged();
				}
			}
		}

		#endregion

		#region ctor

		public CIudAdEs()
		{
			OnCreated();
		}

		#endregion

	}

	[Table(Name = "trustdb.clientes")]
	public partial class ClientEs : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region INotifyPropertyChanging handling

		public event PropertyChangingEventHandler PropertyChanging;

		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs("");
		protected virtual void SendPropertyChanging()
		{
			if (PropertyChanging != null)
			{
				PropertyChanging(this, emptyChangingEventArgs);
			}
		}

		#endregion

		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void SendPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region Extensibility Method Definitions

		partial void OnCreated();
		partial void OnActivoChanged();
		partial void OnActivoChanging(sbyte? value);
		partial void OnContactoCobroChanged();
		partial void OnContactoCobroChanging(string value);
		partial void OnDiaFinFacturacionChanged();
		partial void OnDiaFinFacturacionChanging(short value);
		partial void OnDiaHoraCobroChanged();
		partial void OnDiaHoraCobroChanging(string value);
		partial void OnDiaInicioFacturacionChanged();
		partial void OnDiaInicioFacturacionChanging(short value);
		partial void OnDireccionChanged();
		partial void OnDireccionChanging(string value);
		partial void OnDireccionDeCobroChanged();
		partial void OnDireccionDeCobroChanging(string value);
		partial void OnEmailChanged();
		partial void OnEmailChanging(string value);
		partial void OnFaxChanged();
		partial void OnFaxChanging(string value);
		partial void OnFechaAltaChanged();
		partial void OnFechaAltaChanging(DateTime? value);
		partial void OnFechaBajaChanged();
		partial void OnFechaBajaChanging(DateTime? value);
		partial void OnMotivoBajaChanged();
		partial void OnMotivoBajaChanging(string value);
		partial void OnNombreChanged();
		partial void OnNombreChanging(string value);
		partial void OnNombreFantasiaChanged();
		partial void OnNombreFantasiaChanging(string value);
		partial void OnNombrePersonaCobroChanged();
		partial void OnNombrePersonaCobroChanging(string value);
		partial void OnNumeroClienteChanged();
		partial void OnNumeroClienteChanging(uint value);
		partial void OnReferenciaChanged();
		partial void OnReferenciaChanging(string value);
		partial void OnRutChanged();
		partial void OnRutChanging(string value);
		partial void OnTelefonosChanged();
		partial void OnTelefonosChanging(string value);
		partial void OnTelefonosCobroChanged();
		partial void OnTelefonosCobroChanging(string value);

		#endregion

		#region sbyte? Activo

		private sbyte? _activo;
		[DebuggerNonUserCode]
		[Column(Storage = "_activo", Name = "Activo", DbType = "tinyint(1)", AutoSync = AutoSync.Never)]
		public sbyte? Activo
		{
			get
			{
				return _activo;
			}
			set
			{
				if (value != _activo)
				{
					OnActivoChanging(value);
					SendPropertyChanging();
					_activo = value;
					SendPropertyChanged("Activo");
					OnActivoChanged();
				}
			}
		}

		#endregion

		#region string ContactoCobro

		private string _contactoCobro;
		[DebuggerNonUserCode]
		[Column(Storage = "_contactoCobro", Name = "ContactoCobro", DbType = "varchar(100)", AutoSync = AutoSync.Never)]
		public string ContactoCobro
		{
			get
			{
				return _contactoCobro;
			}
			set
			{
				if (value != _contactoCobro)
				{
					OnContactoCobroChanging(value);
					SendPropertyChanging();
					_contactoCobro = value;
					SendPropertyChanged("ContactoCobro");
					OnContactoCobroChanged();
				}
			}
		}

		#endregion

		#region short DiaFinFacturacion

		private short _diaFinFacturacion;
		[DebuggerNonUserCode]
		[Column(Storage = "_diaFinFacturacion", Name = "DiaFinFacturacion", DbType = "smallint(6)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public short DiaFinFacturacion
		{
			get
			{
				return _diaFinFacturacion;
			}
			set
			{
				if (value != _diaFinFacturacion)
				{
					OnDiaFinFacturacionChanging(value);
					SendPropertyChanging();
					_diaFinFacturacion = value;
					SendPropertyChanged("DiaFinFacturacion");
					OnDiaFinFacturacionChanged();
				}
			}
		}

		#endregion

		#region string DiaHoraCobro

		private string _diaHoraCobro;
		[DebuggerNonUserCode]
		[Column(Storage = "_diaHoraCobro", Name = "DiaHoraCobro", DbType = "varchar(150)", AutoSync = AutoSync.Never)]
		public string DiaHoraCobro
		{
			get
			{
				return _diaHoraCobro;
			}
			set
			{
				if (value != _diaHoraCobro)
				{
					OnDiaHoraCobroChanging(value);
					SendPropertyChanging();
					_diaHoraCobro = value;
					SendPropertyChanged("DiaHoraCobro");
					OnDiaHoraCobroChanged();
				}
			}
		}

		#endregion

		#region short DiaInicioFacturacion

		private short _diaInicioFacturacion;
		[DebuggerNonUserCode]
		[Column(Storage = "_diaInicioFacturacion", Name = "DiaInicioFacturacion", DbType = "smallint(6)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public short DiaInicioFacturacion
		{
			get
			{
				return _diaInicioFacturacion;
			}
			set
			{
				if (value != _diaInicioFacturacion)
				{
					OnDiaInicioFacturacionChanging(value);
					SendPropertyChanging();
					_diaInicioFacturacion = value;
					SendPropertyChanged("DiaInicioFacturacion");
					OnDiaInicioFacturacionChanged();
				}
			}
		}

		#endregion

		#region string Direccion

		private string _direccion;
		[DebuggerNonUserCode]
		[Column(Storage = "_direccion", Name = "Direccion", DbType = "varchar(100)", AutoSync = AutoSync.Never)]
		public string Direccion
		{
			get
			{
				return _direccion;
			}
			set
			{
				if (value != _direccion)
				{
					OnDireccionChanging(value);
					SendPropertyChanging();
					_direccion = value;
					SendPropertyChanged("Direccion");
					OnDireccionChanged();
				}
			}
		}

		#endregion

		#region string DireccionDeCobro

		private string _direccionDeCobro;
		[DebuggerNonUserCode]
		[Column(Storage = "_direccionDeCobro", Name = "DireccionDeCobro", DbType = "varchar(100)", AutoSync = AutoSync.Never)]
		public string DireccionDeCobro
		{
			get
			{
				return _direccionDeCobro;
			}
			set
			{
				if (value != _direccionDeCobro)
				{
					OnDireccionDeCobroChanging(value);
					SendPropertyChanging();
					_direccionDeCobro = value;
					SendPropertyChanged("DireccionDeCobro");
					OnDireccionDeCobroChanged();
				}
			}
		}

		#endregion

		#region string Email

		private string _email;
		[DebuggerNonUserCode]
		[Column(Storage = "_email", Name = "email", DbType = "varchar(100)", AutoSync = AutoSync.Never)]
		public string Email
		{
			get
			{
				return _email;
			}
			set
			{
				if (value != _email)
				{
					OnEmailChanging(value);
					SendPropertyChanging();
					_email = value;
					SendPropertyChanged("Email");
					OnEmailChanged();
				}
			}
		}

		#endregion

		#region string Fax

		private string _fax;
		[DebuggerNonUserCode]
		[Column(Storage = "_fax", Name = "Fax", DbType = "varchar(50)", AutoSync = AutoSync.Never)]
		public string Fax
		{
			get
			{
				return _fax;
			}
			set
			{
				if (value != _fax)
				{
					OnFaxChanging(value);
					SendPropertyChanging();
					_fax = value;
					SendPropertyChanged("Fax");
					OnFaxChanged();
				}
			}
		}

		#endregion

		#region DateTime? FechaAlta

		private DateTime? _fechaAlta;
		[DebuggerNonUserCode]
		[Column(Storage = "_fechaAlta", Name = "FechaAlta", DbType = "date", AutoSync = AutoSync.Never)]
		public DateTime? FechaAlta
		{
			get
			{
				return _fechaAlta;
			}
			set
			{
				if (value != _fechaAlta)
				{
					OnFechaAltaChanging(value);
					SendPropertyChanging();
					_fechaAlta = value;
					SendPropertyChanged("FechaAlta");
					OnFechaAltaChanged();
				}
			}
		}

		#endregion

		#region DateTime? FechaBaja

		private DateTime? _fechaBaja;
		[DebuggerNonUserCode]
		[Column(Storage = "_fechaBaja", Name = "FechaBaja", DbType = "date", AutoSync = AutoSync.Never)]
		public DateTime? FechaBaja
		{
			get
			{
				return _fechaBaja;
			}
			set
			{
				if (value != _fechaBaja)
				{
					OnFechaBajaChanging(value);
					SendPropertyChanging();
					_fechaBaja = value;
					SendPropertyChanged("FechaBaja");
					OnFechaBajaChanged();
				}
			}
		}

		#endregion

		#region string MotivoBaja

		private string _motivoBaja;
		[DebuggerNonUserCode]
		[Column(Storage = "_motivoBaja", Name = "MotivoBaja", DbType = "varchar(255)", AutoSync = AutoSync.Never)]
		public string MotivoBaja
		{
			get
			{
				return _motivoBaja;
			}
			set
			{
				if (value != _motivoBaja)
				{
					OnMotivoBajaChanging(value);
					SendPropertyChanging();
					_motivoBaja = value;
					SendPropertyChanged("MotivoBaja");
					OnMotivoBajaChanged();
				}
			}
		}

		#endregion

		#region string Nombre

		private string _nombre;
		[DebuggerNonUserCode]
		[Column(Storage = "_nombre", Name = "Nombre", DbType = "varchar(100)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public string Nombre
		{
			get
			{
				return _nombre;
			}
			set
			{
				if (value != _nombre)
				{
					OnNombreChanging(value);
					SendPropertyChanging();
					_nombre = value;
					SendPropertyChanged("Nombre");
					OnNombreChanged();
				}
			}
		}

		#endregion

		#region string NombreFantasia

		private string _nombreFantasia;
		[DebuggerNonUserCode]
		[Column(Storage = "_nombreFantasia", Name = "NombreFantasia", DbType = "varchar(100)", AutoSync = AutoSync.Never)]
		public string NombreFantasia
		{
			get
			{
				return _nombreFantasia;
			}
			set
			{
				if (value != _nombreFantasia)
				{
					OnNombreFantasiaChanging(value);
					SendPropertyChanging();
					_nombreFantasia = value;
					SendPropertyChanged("NombreFantasia");
					OnNombreFantasiaChanged();
				}
			}
		}

		#endregion

		#region string NombrePersonaCobro

		private string _nombrePersonaCobro;
		[DebuggerNonUserCode]
		[Column(Storage = "_nombrePersonaCobro", Name = "NombrePersonaCobro", DbType = "varchar(100)", AutoSync = AutoSync.Never)]
		public string NombrePersonaCobro
		{
			get
			{
				return _nombrePersonaCobro;
			}
			set
			{
				if (value != _nombrePersonaCobro)
				{
					OnNombrePersonaCobroChanging(value);
					SendPropertyChanging();
					_nombrePersonaCobro = value;
					SendPropertyChanged("NombrePersonaCobro");
					OnNombrePersonaCobroChanged();
				}
			}
		}

		#endregion

		#region uint NumeroCliente

		private uint _numeroCliente;
		[DebuggerNonUserCode]
		[Column(Storage = "_numeroCliente", Name = "NumeroCliente", DbType = "mediumint unsigned", IsPrimaryKey = true, AutoSync = AutoSync.Never, CanBeNull = false)]
		public uint NumeroCliente
		{
			get
			{
				return _numeroCliente;
			}
			set
			{
				if (value != _numeroCliente)
				{
					OnNumeroClienteChanging(value);
					SendPropertyChanging();
					_numeroCliente = value;
					SendPropertyChanged("NumeroCliente");
					OnNumeroClienteChanged();
				}
			}
		}

		#endregion

		#region string Referencia

		private string _referencia;
		[DebuggerNonUserCode]
		[Column(Storage = "_referencia", Name = "Referencia", DbType = "varchar(100)", AutoSync = AutoSync.Never)]
		public string Referencia
		{
			get
			{
				return _referencia;
			}
			set
			{
				if (value != _referencia)
				{
					OnReferenciaChanging(value);
					SendPropertyChanging();
					_referencia = value;
					SendPropertyChanged("Referencia");
					OnReferenciaChanged();
				}
			}
		}

		#endregion

		#region string Rut

		private string _rut;
		[DebuggerNonUserCode]
		[Column(Storage = "_rut", Name = "RUT", DbType = "char(15)", AutoSync = AutoSync.Never)]
		public string Rut
		{
			get
			{
				return _rut;
			}
			set
			{
				if (value != _rut)
				{
					OnRutChanging(value);
					SendPropertyChanging();
					_rut = value;
					SendPropertyChanged("Rut");
					OnRutChanged();
				}
			}
		}

		#endregion

		#region string Telefonos

		private string _telefonos;
		[DebuggerNonUserCode]
		[Column(Storage = "_telefonos", Name = "Telefonos", DbType = "varchar(50)", AutoSync = AutoSync.Never)]
		public string Telefonos
		{
			get
			{
				return _telefonos;
			}
			set
			{
				if (value != _telefonos)
				{
					OnTelefonosChanging(value);
					SendPropertyChanging();
					_telefonos = value;
					SendPropertyChanged("Telefonos");
					OnTelefonosChanged();
				}
			}
		}

		#endregion

		#region string TelefonosCobro

		private string _telefonosCobro;
		[DebuggerNonUserCode]
		[Column(Storage = "_telefonosCobro", Name = "TelefonosCobro", DbType = "varchar(150)", AutoSync = AutoSync.Never)]
		public string TelefonosCobro
		{
			get
			{
				return _telefonosCobro;
			}
			set
			{
				if (value != _telefonosCobro)
				{
					OnTelefonosCobroChanging(value);
					SendPropertyChanging();
					_telefonosCobro = value;
					SendPropertyChanged("TelefonosCobro");
					OnTelefonosCobroChanged();
				}
			}
		}

		#endregion

		#region Children

		private EntitySet<SERVicIoS> _servIcIoS;
		[Association(Storage = "_servIcIoS", OtherKey = "NumeroCliente", ThisKey = "NumeroCliente", Name = "fk_NumeroCliente_Clientes_NumeroCliente")]
		[DebuggerNonUserCode]
		public EntitySet<SERVicIoS> SERVicIoS
		{
			get
			{
				return _servIcIoS;
			}
			set
			{
				_servIcIoS = value;
			}
		}


		#endregion

		#region Attachement handlers

		private void SERVicIoS_Attach(SERVicIoS entity)
		{
			entity.ClientEs = this;
		}

		private void SERVicIoS_Detach(SERVicIoS entity)
		{
			entity.ClientEs = null;
		}


		#endregion

		#region ctor

		public ClientEs()
		{
			_servIcIoS = new EntitySet<SERVicIoS>(SERVicIoS_Attach, SERVicIoS_Detach);
			OnCreated();
		}

		#endregion

	}

	[Table(Name = "trustdb.consultasclientes")]
	public partial class ConsultAsClientEs : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region INotifyPropertyChanging handling

		public event PropertyChangingEventHandler PropertyChanging;

		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs("");
		protected virtual void SendPropertyChanging()
		{
			if (PropertyChanging != null)
			{
				PropertyChanging(this, emptyChangingEventArgs);
			}
		}

		#endregion

		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void SendPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region Extensibility Method Definitions

		partial void OnCreated();
		partial void OnActivoChanged();
		partial void OnActivoChanging(sbyte value);
		partial void OnDescripcionChanged();
		partial void OnDescripcionChanging(string value);
		partial void OnIDConsultaClienteChanged();
		partial void OnIDConsultaClienteChanging(int value);
		partial void OnNombreChanged();
		partial void OnNombreChanging(string value);
		partial void OnQueryChanged();
		partial void OnQueryChanging(string value);

		#endregion

		#region sbyte Activo

		private sbyte _activo;
		[DebuggerNonUserCode]
		[Column(Storage = "_activo", Name = "Activo", DbType = "tinyint(1)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public sbyte Activo
		{
			get
			{
				return _activo;
			}
			set
			{
				if (value != _activo)
				{
					OnActivoChanging(value);
					SendPropertyChanging();
					_activo = value;
					SendPropertyChanged("Activo");
					OnActivoChanged();
				}
			}
		}

		#endregion

		#region string Descripcion

		private string _descripcion;
		[DebuggerNonUserCode]
		[Column(Storage = "_descripcion", Name = "Descripcion", DbType = "varchar(255)", AutoSync = AutoSync.Never)]
		public string Descripcion
		{
			get
			{
				return _descripcion;
			}
			set
			{
				if (value != _descripcion)
				{
					OnDescripcionChanging(value);
					SendPropertyChanging();
					_descripcion = value;
					SendPropertyChanged("Descripcion");
					OnDescripcionChanged();
				}
			}
		}

		#endregion

		#region int IDConsultaCliente

		private int _idcOnsultaCliente;
		[DebuggerNonUserCode]
		[Column(Storage = "_idcOnsultaCliente", Name = "idConsultaCliente", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false)]
		public int IDConsultaCliente
		{
			get
			{
				return _idcOnsultaCliente;
			}
			set
			{
				if (value != _idcOnsultaCliente)
				{
					OnIDConsultaClienteChanging(value);
					SendPropertyChanging();
					_idcOnsultaCliente = value;
					SendPropertyChanged("IDConsultaCliente");
					OnIDConsultaClienteChanged();
				}
			}
		}

		#endregion

		#region string Nombre

		private string _nombre;
		[DebuggerNonUserCode]
		[Column(Storage = "_nombre", Name = "Nombre", DbType = "varchar(100)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public string Nombre
		{
			get
			{
				return _nombre;
			}
			set
			{
				if (value != _nombre)
				{
					OnNombreChanging(value);
					SendPropertyChanging();
					_nombre = value;
					SendPropertyChanged("Nombre");
					OnNombreChanged();
				}
			}
		}

		#endregion

		#region string Query

		private string _query;
		[DebuggerNonUserCode]
		[Column(Storage = "_query", Name = "Query", DbType = "varchar(3000)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public string Query
		{
			get
			{
				return _query;
			}
			set
			{
				if (value != _query)
				{
					OnQueryChanging(value);
					SendPropertyChanging();
					_query = value;
					SendPropertyChanged("Query");
					OnQueryChanged();
				}
			}
		}

		#endregion

		#region ctor

		public ConsultAsClientEs()
		{
			OnCreated();
		}

		#endregion

	}

	[Table(Name = "trustdb.consultasempleados")]
	public partial class ConsultAsEmPleadOs : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region INotifyPropertyChanging handling

		public event PropertyChangingEventHandler PropertyChanging;

		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs("");
		protected virtual void SendPropertyChanging()
		{
			if (PropertyChanging != null)
			{
				PropertyChanging(this, emptyChangingEventArgs);
			}
		}

		#endregion

		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void SendPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region Extensibility Method Definitions

		partial void OnCreated();
		partial void OnActivoChanged();
		partial void OnActivoChanging(sbyte value);
		partial void OnDescripcionChanged();
		partial void OnDescripcionChanging(string value);
		partial void OnIDConsultaEmpleadoChanged();
		partial void OnIDConsultaEmpleadoChanging(int value);
		partial void OnNombreChanged();
		partial void OnNombreChanging(string value);
		partial void OnQueryChanged();
		partial void OnQueryChanging(string value);

		#endregion

		#region sbyte Activo

		private sbyte _activo;
		[DebuggerNonUserCode]
		[Column(Storage = "_activo", Name = "Activo", DbType = "tinyint(1)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public sbyte Activo
		{
			get
			{
				return _activo;
			}
			set
			{
				if (value != _activo)
				{
					OnActivoChanging(value);
					SendPropertyChanging();
					_activo = value;
					SendPropertyChanged("Activo");
					OnActivoChanged();
				}
			}
		}

		#endregion

		#region string Descripcion

		private string _descripcion;
		[DebuggerNonUserCode]
		[Column(Storage = "_descripcion", Name = "Descripcion", DbType = "varchar(500)", AutoSync = AutoSync.Never)]
		public string Descripcion
		{
			get
			{
				return _descripcion;
			}
			set
			{
				if (value != _descripcion)
				{
					OnDescripcionChanging(value);
					SendPropertyChanging();
					_descripcion = value;
					SendPropertyChanged("Descripcion");
					OnDescripcionChanged();
				}
			}
		}

		#endregion

		#region int IDConsultaEmpleado

		private int _idcOnsultaEmpleado;
		[DebuggerNonUserCode]
		[Column(Storage = "_idcOnsultaEmpleado", Name = "idConsultaEmpleado", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false)]
		public int IDConsultaEmpleado
		{
			get
			{
				return _idcOnsultaEmpleado;
			}
			set
			{
				if (value != _idcOnsultaEmpleado)
				{
					OnIDConsultaEmpleadoChanging(value);
					SendPropertyChanging();
					_idcOnsultaEmpleado = value;
					SendPropertyChanged("IDConsultaEmpleado");
					OnIDConsultaEmpleadoChanged();
				}
			}
		}

		#endregion

		#region string Nombre

		private string _nombre;
		[DebuggerNonUserCode]
		[Column(Storage = "_nombre", Name = "Nombre", DbType = "varchar(100)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public string Nombre
		{
			get
			{
				return _nombre;
			}
			set
			{
				if (value != _nombre)
				{
					OnNombreChanging(value);
					SendPropertyChanging();
					_nombre = value;
					SendPropertyChanged("Nombre");
					OnNombreChanged();
				}
			}
		}

		#endregion

		#region string Query

		private string _query;
		[DebuggerNonUserCode]
		[Column(Storage = "_query", Name = "Query", DbType = "varchar(12500)", AutoSync = AutoSync.Never)]
		public string Query
		{
			get
			{
				return _query;
			}
			set
			{
				if (value != _query)
				{
					OnQueryChanging(value);
					SendPropertyChanging();
					_query = value;
					SendPropertyChanged("Query");
					OnQueryChanged();
				}
			}
		}

		#endregion

		#region ctor

		public ConsultAsEmPleadOs()
		{
			OnCreated();
		}

		#endregion

	}

	[Table(Name = "trustdb.contratos")]
	public partial class ContraToS : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region INotifyPropertyChanging handling

		public event PropertyChangingEventHandler PropertyChanging;

		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs("");
		protected virtual void SendPropertyChanging()
		{
			if (PropertyChanging != null)
			{
				PropertyChanging(this, emptyChangingEventArgs);
			}
		}

		#endregion

		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void SendPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region Extensibility Method Definitions

		partial void OnCreated();
		partial void OnAjusteChanged();
		partial void OnAjusteChanging(string value);
		partial void OnCostoChanged();
		partial void OnCostoChanging(float? value);
		partial void OnCostoFijoChanged();
		partial void OnCostoFijoChanging(sbyte value);
		partial void OnDescPerfilChanged();
		partial void OnDescPerfilChanging(string value);
		partial void OnFechaFinChanged();
		partial void OnFechaFinChanging(DateTime? value);
		partial void OnFechaIniChanged();
		partial void OnFechaIniChanging(DateTime? value);
		partial void OnHorasComunesDeterminadasChanged();
		partial void OnHorasComunesDeterminadasChanging(sbyte value);
		partial void OnHorasExtrasChanged();
		partial void OnHorasExtrasChanging(sbyte value);
		partial void OnIDContratosChanged();
		partial void OnIDContratosChanging(uint value);
		partial void OnObservacionesChanged();
		partial void OnObservacionesChanging(string value);
		partial void OnPagaDescansoChanged();
		partial void OnPagaDescansoChanging(sbyte value);
		partial void OnPagarExtrasDespuesDeHsChanged();
		partial void OnPagarExtrasDespuesDeHsChanging(short? value);
		partial void OnPlanillaTrustChanged();
		partial void OnPlanillaTrustChanging(sbyte? value);
		partial void OnPuntualChanged();
		partial void OnPuntualChanging(sbyte? value);
		partial void OnTipodeContratoChanged();
		partial void OnTipodeContratoChanging(int value);
		partial void OnTotHorasExtrasChanged();
		partial void OnTotHorasExtrasChanging(int? value);
		partial void OnTotHorasNormalesChanged();
		partial void OnTotHorasNormalesChanging(int? value);
		partial void OnTotVigilantesChanged();
		partial void OnTotVigilantesChanging(int? value);

		#endregion

		#region string Ajuste

		private string _ajuste;
		[DebuggerNonUserCode]
		[Column(Storage = "_ajuste", Name = "Ajuste", DbType = "varchar(255)", AutoSync = AutoSync.Never)]
		public string Ajuste
		{
			get
			{
				return _ajuste;
			}
			set
			{
				if (value != _ajuste)
				{
					OnAjusteChanging(value);
					SendPropertyChanging();
					_ajuste = value;
					SendPropertyChanged("Ajuste");
					OnAjusteChanged();
				}
			}
		}

		#endregion

		#region float? Costo

		private float? _costo;
		[DebuggerNonUserCode]
		[Column(Storage = "_costo", Name = "Costo", DbType = "float", AutoSync = AutoSync.Never)]
		public float? Costo
		{
			get
			{
				return _costo;
			}
			set
			{
				if (value != _costo)
				{
					OnCostoChanging(value);
					SendPropertyChanging();
					_costo = value;
					SendPropertyChanged("Costo");
					OnCostoChanged();
				}
			}
		}

		#endregion

		#region sbyte CostoFijo

		private sbyte _costoFijo;
		[DebuggerNonUserCode]
		[Column(Storage = "_costoFijo", Name = "CostoFijo", DbType = "tinyint(1)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public sbyte CostoFijo
		{
			get
			{
				return _costoFijo;
			}
			set
			{
				if (value != _costoFijo)
				{
					OnCostoFijoChanging(value);
					SendPropertyChanging();
					_costoFijo = value;
					SendPropertyChanged("CostoFijo");
					OnCostoFijoChanged();
				}
			}
		}

		#endregion

		#region string DescPerfil

		private string _descPerfil;
		[DebuggerNonUserCode]
		[Column(Storage = "_descPerfil", Name = "DescPerfil", DbType = "varchar(255)", AutoSync = AutoSync.Never)]
		public string DescPerfil
		{
			get
			{
				return _descPerfil;
			}
			set
			{
				if (value != _descPerfil)
				{
					OnDescPerfilChanging(value);
					SendPropertyChanging();
					_descPerfil = value;
					SendPropertyChanged("DescPerfil");
					OnDescPerfilChanged();
				}
			}
		}

		#endregion

		#region DateTime? FechaFin

		private DateTime? _fechaFin;
		[DebuggerNonUserCode]
		[Column(Storage = "_fechaFin", Name = "FechaFin", DbType = "date", AutoSync = AutoSync.Never)]
		public DateTime? FechaFin
		{
			get
			{
				return _fechaFin;
			}
			set
			{
				if (value != _fechaFin)
				{
					OnFechaFinChanging(value);
					SendPropertyChanging();
					_fechaFin = value;
					SendPropertyChanged("FechaFin");
					OnFechaFinChanged();
				}
			}
		}

		#endregion

		#region DateTime? FechaIni

		private DateTime? _fechaIni;
		[DebuggerNonUserCode]
		[Column(Storage = "_fechaIni", Name = "FechaIni", DbType = "date", AutoSync = AutoSync.Never)]
		public DateTime? FechaIni
		{
			get
			{
				return _fechaIni;
			}
			set
			{
				if (value != _fechaIni)
				{
					OnFechaIniChanging(value);
					SendPropertyChanging();
					_fechaIni = value;
					SendPropertyChanged("FechaIni");
					OnFechaIniChanged();
				}
			}
		}

		#endregion

		#region sbyte HorasComunesDeterminadas

		private sbyte _horasComunesDeterminadas;
		[DebuggerNonUserCode]
		[Column(Storage = "_horasComunesDeterminadas", Name = "HorasComunesDeterminadas", DbType = "tinyint(1)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public sbyte HorasComunesDeterminadas
		{
			get
			{
				return _horasComunesDeterminadas;
			}
			set
			{
				if (value != _horasComunesDeterminadas)
				{
					OnHorasComunesDeterminadasChanging(value);
					SendPropertyChanging();
					_horasComunesDeterminadas = value;
					SendPropertyChanged("HorasComunesDeterminadas");
					OnHorasComunesDeterminadasChanged();
				}
			}
		}

		#endregion

		#region sbyte HorasExtras

		private sbyte _horasExtras;
		[DebuggerNonUserCode]
		[Column(Storage = "_horasExtras", Name = "HorasExtras", DbType = "tinyint(1)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public sbyte HorasExtras
		{
			get
			{
				return _horasExtras;
			}
			set
			{
				if (value != _horasExtras)
				{
					OnHorasExtrasChanging(value);
					SendPropertyChanging();
					_horasExtras = value;
					SendPropertyChanged("HorasExtras");
					OnHorasExtrasChanged();
				}
			}
		}

		#endregion

		#region uint IDContratos

		private uint _idcOntratos;
		[DebuggerNonUserCode]
		[Column(Storage = "_idcOntratos", Name = "idContratos", DbType = "mediumint unsigned", IsPrimaryKey = true, AutoSync = AutoSync.Never, CanBeNull = false)]
		public uint IDContratos
		{
			get
			{
				return _idcOntratos;
			}
			set
			{
				if (value != _idcOntratos)
				{
					OnIDContratosChanging(value);
					SendPropertyChanging();
					_idcOntratos = value;
					SendPropertyChanged("IDContratos");
					OnIDContratosChanged();
				}
			}
		}

		#endregion

		#region string Observaciones

		private string _observaciones;
		[DebuggerNonUserCode]
		[Column(Storage = "_observaciones", Name = "Observaciones", DbType = "varchar(255)", AutoSync = AutoSync.Never)]
		public string Observaciones
		{
			get
			{
				return _observaciones;
			}
			set
			{
				if (value != _observaciones)
				{
					OnObservacionesChanging(value);
					SendPropertyChanging();
					_observaciones = value;
					SendPropertyChanged("Observaciones");
					OnObservacionesChanged();
				}
			}
		}

		#endregion

		#region sbyte PagaDescanso

		private sbyte _pagaDescanso;
		[DebuggerNonUserCode]
		[Column(Storage = "_pagaDescanso", Name = "PagaDescanso", DbType = "tinyint(1)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public sbyte PagaDescanso
		{
			get
			{
				return _pagaDescanso;
			}
			set
			{
				if (value != _pagaDescanso)
				{
					OnPagaDescansoChanging(value);
					SendPropertyChanging();
					_pagaDescanso = value;
					SendPropertyChanged("PagaDescanso");
					OnPagaDescansoChanged();
				}
			}
		}

		#endregion

		#region short? PagarExtrasDespuesDeHs

		private short? _pagarExtrasDespuesDeHs;
		[DebuggerNonUserCode]
		[Column(Storage = "_pagarExtrasDespuesDeHs", Name = "PagarExtrasDespuesDeHs", DbType = "smallint(6)", AutoSync = AutoSync.Never)]
		public short? PagarExtrasDespuesDeHs
		{
			get
			{
				return _pagarExtrasDespuesDeHs;
			}
			set
			{
				if (value != _pagarExtrasDespuesDeHs)
				{
					OnPagarExtrasDespuesDeHsChanging(value);
					SendPropertyChanging();
					_pagarExtrasDespuesDeHs = value;
					SendPropertyChanged("PagarExtrasDespuesDeHs");
					OnPagarExtrasDespuesDeHsChanged();
				}
			}
		}

		#endregion

		#region sbyte? PlanillaTrust

		private sbyte? _planillaTrust;
		[DebuggerNonUserCode]
		[Column(Storage = "_planillaTrust", Name = "PlanillaTrust", DbType = "tinyint(1)", AutoSync = AutoSync.Never)]
		public sbyte? PlanillaTrust
		{
			get
			{
				return _planillaTrust;
			}
			set
			{
				if (value != _planillaTrust)
				{
					OnPlanillaTrustChanging(value);
					SendPropertyChanging();
					_planillaTrust = value;
					SendPropertyChanged("PlanillaTrust");
					OnPlanillaTrustChanged();
				}
			}
		}

		#endregion

		#region sbyte? Puntual

		private sbyte? _puntual;
		[DebuggerNonUserCode]
		[Column(Storage = "_puntual", Name = "Puntual", DbType = "tinyint(1)", AutoSync = AutoSync.Never)]
		public sbyte? Puntual
		{
			get
			{
				return _puntual;
			}
			set
			{
				if (value != _puntual)
				{
					OnPuntualChanging(value);
					SendPropertyChanging();
					_puntual = value;
					SendPropertyChanged("Puntual");
					OnPuntualChanged();
				}
			}
		}

		#endregion

		#region int TipodeContrato

		private int _tipodeContrato;
		[DebuggerNonUserCode]
		[Column(Storage = "_tipodeContrato", Name = "TipodeContrato", DbType = "int", AutoSync = AutoSync.Never, CanBeNull = false)]
		public int TipodeContrato
		{
			get
			{
				return _tipodeContrato;
			}
			set
			{
				if (value != _tipodeContrato)
				{
					if (_tipOcOntraToS.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					OnTipodeContratoChanging(value);
					SendPropertyChanging();
					_tipodeContrato = value;
					SendPropertyChanged("TipodeContrato");
					OnTipodeContratoChanged();
				}
			}
		}

		#endregion

		#region int? TotHorasExtras

		private int? _totHorasExtras;
		[DebuggerNonUserCode]
		[Column(Storage = "_totHorasExtras", Name = "TotHorasExtras", DbType = "mediumint(9)", AutoSync = AutoSync.Never)]
		public int? TotHorasExtras
		{
			get
			{
				return _totHorasExtras;
			}
			set
			{
				if (value != _totHorasExtras)
				{
					OnTotHorasExtrasChanging(value);
					SendPropertyChanging();
					_totHorasExtras = value;
					SendPropertyChanged("TotHorasExtras");
					OnTotHorasExtrasChanged();
				}
			}
		}

		#endregion

		#region int? TotHorasNormales

		private int? _totHorasNormales;
		[DebuggerNonUserCode]
		[Column(Storage = "_totHorasNormales", Name = "TotHorasNormales", DbType = "mediumint(9)", AutoSync = AutoSync.Never)]
		public int? TotHorasNormales
		{
			get
			{
				return _totHorasNormales;
			}
			set
			{
				if (value != _totHorasNormales)
				{
					OnTotHorasNormalesChanging(value);
					SendPropertyChanging();
					_totHorasNormales = value;
					SendPropertyChanged("TotHorasNormales");
					OnTotHorasNormalesChanged();
				}
			}
		}

		#endregion

		#region int? TotVigilantes

		private int? _totVigilantes;
		[DebuggerNonUserCode]
		[Column(Storage = "_totVigilantes", Name = "TotVigilantes", DbType = "mediumint(9)", AutoSync = AutoSync.Never)]
		public int? TotVigilantes
		{
			get
			{
				return _totVigilantes;
			}
			set
			{
				if (value != _totVigilantes)
				{
					OnTotVigilantesChanging(value);
					SendPropertyChanging();
					_totVigilantes = value;
					SendPropertyChanged("TotVigilantes");
					OnTotVigilantesChanged();
				}
			}
		}

		#endregion

		#region Children

		private EntitySet<HoRaSComUnescoNtRatOs> _hoRaScOmUnescoNtRatOs;
		[Association(Storage = "_hoRaScOmUnescoNtRatOs", OtherKey = "IDContraToS", ThisKey = "IDContratos", Name = "FK_Contrato")]
		[DebuggerNonUserCode]
		public EntitySet<HoRaSComUnescoNtRatOs> HoRaSComUnescoNtRatOs
		{
			get
			{
				return _hoRaScOmUnescoNtRatOs;
			}
			set
			{
				_hoRaScOmUnescoNtRatOs = value;
			}
		}

		private EntitySet<LineAshOrAs> _lineAshOrAs;
		[Association(Storage = "_lineAshOrAs", OtherKey = "IDContrato", ThisKey = "IDContratos", Name = "FK_Contratos")]
		[DebuggerNonUserCode]
		public EntitySet<LineAshOrAs> LineAshOrAs
		{
			get
			{
				return _lineAshOrAs;
			}
			set
			{
				_lineAshOrAs = value;
			}
		}


		#endregion

		#region Parents

		private EntityRef<TipOContraToS> _tipOcOntraToS;
		[Association(Storage = "_tipOcOntraToS", OtherKey = "ID", ThisKey = "TipodeContrato", Name = "Id", IsForeignKey = true)]
		[DebuggerNonUserCode]
		public TipOContraToS TipOContraToS
		{
			get
			{
				return _tipOcOntraToS.Entity;
			}
			set
			{
				if (value != _tipOcOntraToS.Entity)
				{
					if (_tipOcOntraToS.Entity != null)
					{
						var previousTipOContraToS = _tipOcOntraToS.Entity;
						_tipOcOntraToS.Entity = null;
						previousTipOContraToS.ContraToS.Remove(this);
					}
					_tipOcOntraToS.Entity = value;
					if (value != null)
					{
						value.ContraToS.Add(this);
						_tipodeContrato = value.ID;
					}
					else
					{
						_tipodeContrato = default(int);
					}
				}
			}
		}


		#endregion

		#region Attachement handlers

		private void HoRaSComUnescoNtRatOs_Attach(HoRaSComUnescoNtRatOs entity)
		{
			entity.ContraToS = this;
		}

		private void HoRaSComUnescoNtRatOs_Detach(HoRaSComUnescoNtRatOs entity)
		{
			entity.ContraToS = null;
		}

		private void LineAshOrAs_Attach(LineAshOrAs entity)
		{
			entity.ContraToS = this;
		}

		private void LineAshOrAs_Detach(LineAshOrAs entity)
		{
			entity.ContraToS = null;
		}


		#endregion

		#region ctor

		public ContraToS()
		{
			_hoRaScOmUnescoNtRatOs = new EntitySet<HoRaSComUnescoNtRatOs>(HoRaSComUnescoNtRatOs_Attach, HoRaSComUnescoNtRatOs_Detach);
			_lineAshOrAs = new EntitySet<LineAshOrAs>(LineAshOrAs_Attach, LineAshOrAs_Detach);
			_tipOcOntraToS = new EntityRef<TipOContraToS>();
			OnCreated();
		}

		#endregion

	}

	[Table(Name = "trustdb.cuotasextrasliquidacion")]
	public partial class CuOtAsExtrasLiquidAcIon : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region INotifyPropertyChanging handling

		public event PropertyChangingEventHandler PropertyChanging;

		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs("");
		protected virtual void SendPropertyChanging()
		{
			if (PropertyChanging != null)
			{
				PropertyChanging(this, emptyChangingEventArgs);
			}
		}

		#endregion

		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void SendPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region Extensibility Method Definitions

		partial void OnCreated();
		partial void OnFechaChanged();
		partial void OnFechaChanging(DateTime value);
		partial void OnIDExtraLiquidacionChanged();
		partial void OnIDExtraLiquidacionChanging(uint value);
		partial void OnLiquidadoChanged();
		partial void OnLiquidadoChanging(sbyte value);
		partial void OnNumeroCuotaChanged();
		partial void OnNumeroCuotaChanging(sbyte value);
		partial void OnValorCuotaChanged();
		partial void OnValorCuotaChanging(float value);

		#endregion

		#region DateTime Fecha

		private DateTime _fecha;
		[DebuggerNonUserCode]
		[Column(Storage = "_fecha", Name = "Fecha", DbType = "date", AutoSync = AutoSync.Never, CanBeNull = false)]
		public DateTime Fecha
		{
			get
			{
				return _fecha;
			}
			set
			{
				if (value != _fecha)
				{
					OnFechaChanging(value);
					SendPropertyChanging();
					_fecha = value;
					SendPropertyChanged("Fecha");
					OnFechaChanged();
				}
			}
		}

		#endregion

		#region uint IDExtraLiquidacion

		private uint _ideXtraLiquidacion;
		[DebuggerNonUserCode]
		[Column(Storage = "_ideXtraLiquidacion", Name = "IdExtraLiquidacion", DbType = "int unsigned", IsPrimaryKey = true, AutoSync = AutoSync.Never, CanBeNull = false)]
		public uint IDExtraLiquidacion
		{
			get
			{
				return _ideXtraLiquidacion;
			}
			set
			{
				if (value != _ideXtraLiquidacion)
				{
					OnIDExtraLiquidacionChanging(value);
					SendPropertyChanging();
					_ideXtraLiquidacion = value;
					SendPropertyChanged("IDExtraLiquidacion");
					OnIDExtraLiquidacionChanged();
				}
			}
		}

		#endregion

		#region sbyte Liquidado

		private sbyte _liquidado;
		[DebuggerNonUserCode]
		[Column(Storage = "_liquidado", Name = "Liquidado", DbType = "tinyint(1)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public sbyte Liquidado
		{
			get
			{
				return _liquidado;
			}
			set
			{
				if (value != _liquidado)
				{
					OnLiquidadoChanging(value);
					SendPropertyChanging();
					_liquidado = value;
					SendPropertyChanged("Liquidado");
					OnLiquidadoChanged();
				}
			}
		}

		#endregion

		#region sbyte NumeroCuota

		private sbyte _numeroCuota;
		[DebuggerNonUserCode]
		[Column(Storage = "_numeroCuota", Name = "NumeroCuota", DbType = "tinyint(2)", IsPrimaryKey = true, AutoSync = AutoSync.Never, CanBeNull = false)]
		public sbyte NumeroCuota
		{
			get
			{
				return _numeroCuota;
			}
			set
			{
				if (value != _numeroCuota)
				{
					OnNumeroCuotaChanging(value);
					SendPropertyChanging();
					_numeroCuota = value;
					SendPropertyChanged("NumeroCuota");
					OnNumeroCuotaChanged();
				}
			}
		}

		#endregion

		#region float ValorCuota

		private float _valorCuota;
		[DebuggerNonUserCode]
		[Column(Storage = "_valorCuota", Name = "ValorCuota", DbType = "float", AutoSync = AutoSync.Never, CanBeNull = false)]
		public float ValorCuota
		{
			get
			{
				return _valorCuota;
			}
			set
			{
				if (value != _valorCuota)
				{
					OnValorCuotaChanging(value);
					SendPropertyChanging();
					_valorCuota = value;
					SendPropertyChanged("ValorCuota");
					OnValorCuotaChanged();
				}
			}
		}

		#endregion

		#region Parents

		private EntityRef<ExtrasLiquidAcIon> _extrasLiquidAcIon;
		[Association(Storage = "_extrasLiquidAcIon", OtherKey = "IDExtraLiquidacion", ThisKey = "IDExtraLiquidacion", Name = "cuotasextrasliquidacion_ibfk_1", IsForeignKey = true)]
		[DebuggerNonUserCode]
		public ExtrasLiquidAcIon ExtrasLiquidAcIon
		{
			get
			{
				return _extrasLiquidAcIon.Entity;
			}
			set
			{
				if (value != _extrasLiquidAcIon.Entity)
				{
					if (_extrasLiquidAcIon.Entity != null)
					{
						var previousExtrasLiquidAcIon = _extrasLiquidAcIon.Entity;
						_extrasLiquidAcIon.Entity = null;
						previousExtrasLiquidAcIon.CuOtAsExtrasLiquidAcIon.Remove(this);
					}
					_extrasLiquidAcIon.Entity = value;
					if (value != null)
					{
						value.CuOtAsExtrasLiquidAcIon.Add(this);
						_ideXtraLiquidacion = value.IDExtraLiquidacion;
					}
					else
					{
						_ideXtraLiquidacion = default(uint);
					}
				}
			}
		}


		#endregion

		#region ctor

		public CuOtAsExtrasLiquidAcIon()
		{
			_extrasLiquidAcIon = new EntityRef<ExtrasLiquidAcIon>();
			OnCreated();
		}

		#endregion

	}

	[Table(Name = "trustdb.departamentos")]
	public partial class DepartAmenToS : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region INotifyPropertyChanging handling

		public event PropertyChangingEventHandler PropertyChanging;

		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs("");
		protected virtual void SendPropertyChanging()
		{
			if (PropertyChanging != null)
			{
				PropertyChanging(this, emptyChangingEventArgs);
			}
		}

		#endregion

		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void SendPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region Extensibility Method Definitions

		partial void OnCreated();
		partial void OnIDDepartamentoChanged();
		partial void OnIDDepartamentoChanging(byte value);
		partial void OnNombreChanged();
		partial void OnNombreChanging(string value);

		#endregion

		#region byte IDDepartamento

		private byte _iddEpartamento;
		[DebuggerNonUserCode]
		[Column(Storage = "_iddEpartamento", Name = "IdDepartamento", DbType = "tinyint(2) unsigned", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false)]
		public byte IDDepartamento
		{
			get
			{
				return _iddEpartamento;
			}
			set
			{
				if (value != _iddEpartamento)
				{
					OnIDDepartamentoChanging(value);
					SendPropertyChanging();
					_iddEpartamento = value;
					SendPropertyChanged("IDDepartamento");
					OnIDDepartamentoChanged();
				}
			}
		}

		#endregion

		#region string Nombre

		private string _nombre;
		[DebuggerNonUserCode]
		[Column(Storage = "_nombre", Name = "Nombre", DbType = "varchar(50)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public string Nombre
		{
			get
			{
				return _nombre;
			}
			set
			{
				if (value != _nombre)
				{
					OnNombreChanging(value);
					SendPropertyChanging();
					_nombre = value;
					SendPropertyChanged("Nombre");
					OnNombreChanged();
				}
			}
		}

		#endregion

		#region ctor

		public DepartAmenToS()
		{
			OnCreated();
		}

		#endregion

	}

	[Table(Name = "trustdb.emergenciasmedica")]
	public partial class EmergeNcIasMedicA : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region INotifyPropertyChanging handling

		public event PropertyChangingEventHandler PropertyChanging;

		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs("");
		protected virtual void SendPropertyChanging()
		{
			if (PropertyChanging != null)
			{
				PropertyChanging(this, emptyChangingEventArgs);
			}
		}

		#endregion

		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void SendPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region Extensibility Method Definitions

		partial void OnCreated();
		partial void OnIDEmergenciaMedicaChanged();
		partial void OnIDEmergenciaMedicaChanging(byte value);
		partial void OnNombreChanged();
		partial void OnNombreChanging(string value);

		#endregion

		#region byte IDEmergenciaMedica

		private byte _ideMergenciaMedica;
		[DebuggerNonUserCode]
		[Column(Storage = "_ideMergenciaMedica", Name = "IdEmergenciaMedica", DbType = "tinyint(2) unsigned", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false)]
		public byte IDEmergenciaMedica
		{
			get
			{
				return _ideMergenciaMedica;
			}
			set
			{
				if (value != _ideMergenciaMedica)
				{
					OnIDEmergenciaMedicaChanging(value);
					SendPropertyChanging();
					_ideMergenciaMedica = value;
					SendPropertyChanged("IDEmergenciaMedica");
					OnIDEmergenciaMedicaChanged();
				}
			}
		}

		#endregion

		#region string Nombre

		private string _nombre;
		[DebuggerNonUserCode]
		[Column(Storage = "_nombre", Name = "Nombre", DbType = "varchar(50)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public string Nombre
		{
			get
			{
				return _nombre;
			}
			set
			{
				if (value != _nombre)
				{
					OnNombreChanging(value);
					SendPropertyChanging();
					_nombre = value;
					SendPropertyChanged("Nombre");
					OnNombreChanged();
				}
			}
		}

		#endregion

		#region ctor

		public EmergeNcIasMedicA()
		{
			OnCreated();
		}

		#endregion

	}

	[Table(Name = "trustdb.empleados")]
	public partial class EmPleadOs : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region INotifyPropertyChanging handling

		public event PropertyChangingEventHandler PropertyChanging;

		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs("");
		protected virtual void SendPropertyChanging()
		{
			if (PropertyChanging != null)
			{
				PropertyChanging(this, emptyChangingEventArgs);
			}
		}

		#endregion

		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void SendPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region Extensibility Method Definitions

		partial void OnCreated();
		partial void OnActivoChanged();
		partial void OnActivoChanging(sbyte value);
		partial void OnAntecedentesChanged();
		partial void OnAntecedentesChanging(sbyte? value);
		partial void OnAntecedentesPolicialesOmIlitaresChanged();
		partial void OnAntecedentesPolicialesOmIlitaresChanging(sbyte value);
		partial void OnApellidoChanged();
		partial void OnApellidoChanging(string value);
		partial void OnBarrioChanged();
		partial void OnBarrioChanging(string value);
		partial void OnBpsaCumulacionLaboralChanged();
		partial void OnBpsaCumulacionLaboralChanging(byte? value);
		partial void OnBpseSBajaChanged();
		partial void OnBpseSBajaChanging(sbyte value);
		partial void OnBpsfEchaAltaChanged();
		partial void OnBpsfEchaAltaChanging(DateTime? value);
		partial void OnBpsfEchaBajaChanged();
		partial void OnBpsfEchaBajaChanging(DateTime? value);
		partial void OnCajfEchaEmisionChanged();
		partial void OnCajfEchaEmisionChanging(DateTime? value);
		partial void OnCajfEchaEntregaChanged();
		partial void OnCajfEchaEntregaChanging(DateTime? value);
		partial void OnCajnUmeroChanged();
		partial void OnCajnUmeroChanging(string value);
		partial void OnCantidadMenoresAcArgoChanged();
		partial void OnCantidadMenoresAcArgoChanging(sbyte? value);
		partial void OnCapacitadoPortarArmaChanged();
		partial void OnCapacitadoPortarArmaChanging(sbyte? value);
		partial void OnCelularChanged();
		partial void OnCelularChanging(string value);
		partial void OnCelularenConvenioChanged();
		partial void OnCelularenConvenioChanging(string value);
		partial void OnCiudadChanged();
		partial void OnCiudadChanging(string value);
		partial void OnCodigoPostalChanged();
		partial void OnCodigoPostalChanging(string value);
		partial void OnCombatienteMilitarChanged();
		partial void OnCombatienteMilitarChanging(sbyte? value);
		partial void OnConstanciaDomicilioChanged();
		partial void OnConstanciaDomicilioChanging(sbyte? value);
		partial void OnDireccionChanged();
		partial void OnDireccionChanging(string value);
		partial void OnDireccionDeEncuentroChanged();
		partial void OnDireccionDeEncuentroChanging(string value);
		partial void OnEdadChanged();
		partial void OnEdadChanging(sbyte? value);
		partial void OnEmailChanged();
		partial void OnEmailChanging(string value);
		partial void OnEnServicioArmadoChanged();
		partial void OnEnServicioArmadoChanging(sbyte? value);
		partial void OnEnSindicatoChanged();
		partial void OnEnSindicatoChanging(sbyte value);
		partial void OnEntreCallesChanged();
		partial void OnEntreCallesChanging(string value);
		partial void OnEstadoCivilChanged();
		partial void OnEstadoCivilChanging(string value);
		partial void OnFechaBajaChanged();
		partial void OnFechaBajaChanging(DateTime? value);
		partial void OnFechaEgresoPolicialoMilitarChanged();
		partial void OnFechaEgresoPolicialoMilitarChanging(DateTime? value);
		partial void OnFechaEntregaCelularChanged();
		partial void OnFechaEntregaCelularChanging(DateTime? value);
		partial void OnFechaIngresoChanged();
		partial void OnFechaIngresoChanging(DateTime? value);
		partial void OnFechaIngresoPolicialoMilitarChanged();
		partial void OnFechaIngresoPolicialoMilitarChanging(DateTime? value);
		partial void OnFechaNacimientoChanged();
		partial void OnFechaNacimientoChanging(DateTime? value);
		partial void OnFechaPagoEfectuadoChanged();
		partial void OnFechaPagoEfectuadoChanging(DateTime? value);
		partial void OnFechaPrevistaPagoChanged();
		partial void OnFechaPrevistaPagoChanging(DateTime? value);
		partial void OnFechaTestPsicologicoChanged();
		partial void OnFechaTestPsicologicoChanging(DateTime? value);
		partial void OnFechaVencimientoCarneDeSaludChanged();
		partial void OnFechaVencimientoCarneDeSaludChanging(DateTime? value);
		partial void OnFotoChanged();
		partial void OnFotoChanging(Byte[] value);
		partial void OnIDBarrioChanged();
		partial void OnIDBarrioChanging(sbyte? value);
		partial void OnIDCargoChanged();
		partial void OnIDCargoChanging(uint value);
		partial void OnIDCiudadChanged();
		partial void OnIDCiudadChanging(sbyte? value);
		partial void OnIDDepartamentoChanged();
		partial void OnIDDepartamentoChanging(sbyte? value);
		partial void OnIDEmergenciaMedicaChanged();
		partial void OnIDEmergenciaMedicaChanging(byte? value);
		partial void OnIDMutualistaChanged();
		partial void OnIDMutualistaChanging(byte? value);
		partial void OnIDTipoDocumentoChanged();
		partial void OnIDTipoDocumentoChanging(sbyte value);
		partial void OnLugarDeNacimientoChanged();
		partial void OnLugarDeNacimientoChanging(string value);
		partial void OnMotivoBajaChanged();
		partial void OnMotivoBajaChanging(string value);
		partial void OnNivelEducativoChanged();
		partial void OnNivelEducativoChanging(string value);
		partial void OnNoHabilitadoParaServicioChanged();
		partial void OnNoHabilitadoParaServicioChanging(sbyte value);
		partial void OnNoLlevaTicketsAlimentacionChanged();
		partial void OnNoLlevaTicketsAlimentacionChanging(sbyte value);
		partial void OnNombreChanged();
		partial void OnNombreChanging(string value);
		partial void OnNroEmpleadoChanged();
		partial void OnNroEmpleadoChanging(uint value);
		partial void OnNumeroDocumentoChanged();
		partial void OnNumeroDocumentoChanging(string value);
		partial void OnObservacionesChanged();
		partial void OnObservacionesChanging(string value);
		partial void OnObservacionesAntecedentesChanged();
		partial void OnObservacionesAntecedentesChanging(string value);
		partial void OnPolicialesoMilitarChanged();
		partial void OnPolicialesoMilitarChanging(sbyte? value);
		partial void OnRenaemsefEchaIngresoChanged();
		partial void OnRenaemsefEchaIngresoChanging(DateTime? value);
		partial void OnRenaemsenUmeroAsuntoChanged();
		partial void OnRenaemsenUmeroAsuntoChanging(string value);
		partial void OnServicioActualChanged();
		partial void OnServicioActualChanging(string value);
		partial void OnSexOChanged();
		partial void OnSexOChanging(string value);
		partial void OnSubEscalafonPolicialChanged();
		partial void OnSubEscalafonPolicialChanging(string value);
		partial void OnTalleCamisaChanged();
		partial void OnTalleCamisaChanging(string value);
		partial void OnTalleCamperaChanged();
		partial void OnTalleCamperaChanging(string value);
		partial void OnTallePantalonChanged();
		partial void OnTallePantalonChanging(string value);
		partial void OnTalleZapatosChanged();
		partial void OnTalleZapatosChanging(sbyte? value);
		partial void OnTelefonosChanged();
		partial void OnTelefonosChanging(string value);
		partial void OnTurnoChanged();
		partial void OnTurnoChanging(string value);
		partial void OnValorHoraChanged();
		partial void OnValorHoraChanging(float? value);

		#endregion

		#region sbyte Activo

		private sbyte _activo;
		[DebuggerNonUserCode]
		[Column(Storage = "_activo", Name = "Activo", DbType = "tinyint(1)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public sbyte Activo
		{
			get
			{
				return _activo;
			}
			set
			{
				if (value != _activo)
				{
					OnActivoChanging(value);
					SendPropertyChanging();
					_activo = value;
					SendPropertyChanged("Activo");
					OnActivoChanged();
				}
			}
		}

		#endregion

		#region sbyte? Antecedentes

		private sbyte? _antecedentes;
		[DebuggerNonUserCode]
		[Column(Storage = "_antecedentes", Name = "Antecedentes", DbType = "tinyint(1)", AutoSync = AutoSync.Never)]
		public sbyte? Antecedentes
		{
			get
			{
				return _antecedentes;
			}
			set
			{
				if (value != _antecedentes)
				{
					OnAntecedentesChanging(value);
					SendPropertyChanging();
					_antecedentes = value;
					SendPropertyChanged("Antecedentes");
					OnAntecedentesChanged();
				}
			}
		}

		#endregion

		#region sbyte AntecedentesPolicialesOmIlitares

		private sbyte _antecedentesPolicialesOmIlitares;
		[DebuggerNonUserCode]
		[Column(Storage = "_antecedentesPolicialesOmIlitares", Name = "AntecedentesPolicialesOMilitares", DbType = "tinyint(1)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public sbyte AntecedentesPolicialesOmIlitares
		{
			get
			{
				return _antecedentesPolicialesOmIlitares;
			}
			set
			{
				if (value != _antecedentesPolicialesOmIlitares)
				{
					OnAntecedentesPolicialesOmIlitaresChanging(value);
					SendPropertyChanging();
					_antecedentesPolicialesOmIlitares = value;
					SendPropertyChanged("AntecedentesPolicialesOmIlitares");
					OnAntecedentesPolicialesOmIlitaresChanged();
				}
			}
		}

		#endregion

		#region string Apellido

		private string _apellido;
		[DebuggerNonUserCode]
		[Column(Storage = "_apellido", Name = "Apellido", DbType = "varchar(50)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public string Apellido
		{
			get
			{
				return _apellido;
			}
			set
			{
				if (value != _apellido)
				{
					OnApellidoChanging(value);
					SendPropertyChanging();
					_apellido = value;
					SendPropertyChanged("Apellido");
					OnApellidoChanged();
				}
			}
		}

		#endregion

		#region string Barrio

		private string _barrio;
		[DebuggerNonUserCode]
		[Column(Storage = "_barrio", Name = "Barrio", DbType = "varchar(30)", AutoSync = AutoSync.Never)]
		public string Barrio
		{
			get
			{
				return _barrio;
			}
			set
			{
				if (value != _barrio)
				{
					OnBarrioChanging(value);
					SendPropertyChanging();
					_barrio = value;
					SendPropertyChanged("Barrio");
					OnBarrioChanged();
				}
			}
		}

		#endregion

		#region byte? BpsaCumulacionLaboral

		private byte? _bpsaCumulacionLaboral;
		[DebuggerNonUserCode]
		[Column(Storage = "_bpsaCumulacionLaboral", Name = "BPS_AcumulacionLaboral", DbType = "tinyint(2) unsigned", AutoSync = AutoSync.Never)]
		public byte? BpsaCumulacionLaboral
		{
			get
			{
				return _bpsaCumulacionLaboral;
			}
			set
			{
				if (value != _bpsaCumulacionLaboral)
				{
					OnBpsaCumulacionLaboralChanging(value);
					SendPropertyChanging();
					_bpsaCumulacionLaboral = value;
					SendPropertyChanged("BpsaCumulacionLaboral");
					OnBpsaCumulacionLaboralChanged();
				}
			}
		}

		#endregion

		#region sbyte BpseSBaja

		private sbyte _bpseSbAja;
		[DebuggerNonUserCode]
		[Column(Storage = "_bpseSbAja", Name = "BPSEsBaja", DbType = "tinyint(1)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public sbyte BpseSBaja
		{
			get
			{
				return _bpseSbAja;
			}
			set
			{
				if (value != _bpseSbAja)
				{
					OnBpseSBajaChanging(value);
					SendPropertyChanging();
					_bpseSbAja = value;
					SendPropertyChanged("BpseSBaja");
					OnBpseSBajaChanged();
				}
			}
		}

		#endregion

		#region DateTime? BpsfEchaAlta

		private DateTime? _bpsfEchaAlta;
		[DebuggerNonUserCode]
		[Column(Storage = "_bpsfEchaAlta", Name = "BPS_FechaAlta", DbType = "date", AutoSync = AutoSync.Never)]
		public DateTime? BpsfEchaAlta
		{
			get
			{
				return _bpsfEchaAlta;
			}
			set
			{
				if (value != _bpsfEchaAlta)
				{
					OnBpsfEchaAltaChanging(value);
					SendPropertyChanging();
					_bpsfEchaAlta = value;
					SendPropertyChanged("BpsfEchaAlta");
					OnBpsfEchaAltaChanged();
				}
			}
		}

		#endregion

		#region DateTime? BpsfEchaBaja

		private DateTime? _bpsfEchaBaja;
		[DebuggerNonUserCode]
		[Column(Storage = "_bpsfEchaBaja", Name = "BPS_FechaBaja", DbType = "date", AutoSync = AutoSync.Never)]
		public DateTime? BpsfEchaBaja
		{
			get
			{
				return _bpsfEchaBaja;
			}
			set
			{
				if (value != _bpsfEchaBaja)
				{
					OnBpsfEchaBajaChanging(value);
					SendPropertyChanging();
					_bpsfEchaBaja = value;
					SendPropertyChanged("BpsfEchaBaja");
					OnBpsfEchaBajaChanged();
				}
			}
		}

		#endregion

		#region DateTime? CajfEchaEmision

		private DateTime? _cajfEchaEmision;
		[DebuggerNonUserCode]
		[Column(Storage = "_cajfEchaEmision", Name = "CAJ_FechaEmision", DbType = "date", AutoSync = AutoSync.Never)]
		public DateTime? CajfEchaEmision
		{
			get
			{
				return _cajfEchaEmision;
			}
			set
			{
				if (value != _cajfEchaEmision)
				{
					OnCajfEchaEmisionChanging(value);
					SendPropertyChanging();
					_cajfEchaEmision = value;
					SendPropertyChanged("CajfEchaEmision");
					OnCajfEchaEmisionChanged();
				}
			}
		}

		#endregion

		#region DateTime? CajfEchaEntrega

		private DateTime? _cajfEchaEntrega;
		[DebuggerNonUserCode]
		[Column(Storage = "_cajfEchaEntrega", Name = "CAJ_FechaEntrega", DbType = "date", AutoSync = AutoSync.Never)]
		public DateTime? CajfEchaEntrega
		{
			get
			{
				return _cajfEchaEntrega;
			}
			set
			{
				if (value != _cajfEchaEntrega)
				{
					OnCajfEchaEntregaChanging(value);
					SendPropertyChanging();
					_cajfEchaEntrega = value;
					SendPropertyChanged("CajfEchaEntrega");
					OnCajfEchaEntregaChanged();
				}
			}
		}

		#endregion

		#region string CajnUmero

		private string _cajnUmero;
		[DebuggerNonUserCode]
		[Column(Storage = "_cajnUmero", Name = "CAJ_Numero", DbType = "varchar(20)", AutoSync = AutoSync.Never)]
		public string CajnUmero
		{
			get
			{
				return _cajnUmero;
			}
			set
			{
				if (value != _cajnUmero)
				{
					OnCajnUmeroChanging(value);
					SendPropertyChanging();
					_cajnUmero = value;
					SendPropertyChanged("CajnUmero");
					OnCajnUmeroChanged();
				}
			}
		}

		#endregion

		#region sbyte? CantidadMenoresAcArgo

		private sbyte? _cantidadMenoresAcArgo;
		[DebuggerNonUserCode]
		[Column(Storage = "_cantidadMenoresAcArgo", Name = "CantidadMenoresACargo", DbType = "tinyint(2)", AutoSync = AutoSync.Never)]
		public sbyte? CantidadMenoresAcArgo
		{
			get
			{
				return _cantidadMenoresAcArgo;
			}
			set
			{
				if (value != _cantidadMenoresAcArgo)
				{
					OnCantidadMenoresAcArgoChanging(value);
					SendPropertyChanging();
					_cantidadMenoresAcArgo = value;
					SendPropertyChanged("CantidadMenoresAcArgo");
					OnCantidadMenoresAcArgoChanged();
				}
			}
		}

		#endregion

		#region sbyte? CapacitadoPortarArma

		private sbyte? _capacitadoPortarArma;
		[DebuggerNonUserCode]
		[Column(Storage = "_capacitadoPortarArma", Name = "CapacitadoPortarArma", DbType = "tinyint(1)", AutoSync = AutoSync.Never)]
		public sbyte? CapacitadoPortarArma
		{
			get
			{
				return _capacitadoPortarArma;
			}
			set
			{
				if (value != _capacitadoPortarArma)
				{
					OnCapacitadoPortarArmaChanging(value);
					SendPropertyChanging();
					_capacitadoPortarArma = value;
					SendPropertyChanged("CapacitadoPortarArma");
					OnCapacitadoPortarArmaChanged();
				}
			}
		}

		#endregion

		#region string Celular

		private string _celular;
		[DebuggerNonUserCode]
		[Column(Storage = "_celular", Name = "Celular", DbType = "varchar(50)", AutoSync = AutoSync.Never)]
		public string Celular
		{
			get
			{
				return _celular;
			}
			set
			{
				if (value != _celular)
				{
					OnCelularChanging(value);
					SendPropertyChanging();
					_celular = value;
					SendPropertyChanged("Celular");
					OnCelularChanged();
				}
			}
		}

		#endregion

		#region string CelularenConvenio

		private string _celularenConvenio;
		[DebuggerNonUserCode]
		[Column(Storage = "_celularenConvenio", Name = "CelularenConvenio", DbType = "varchar(50)", AutoSync = AutoSync.Never)]
		public string CelularenConvenio
		{
			get
			{
				return _celularenConvenio;
			}
			set
			{
				if (value != _celularenConvenio)
				{
					OnCelularenConvenioChanging(value);
					SendPropertyChanging();
					_celularenConvenio = value;
					SendPropertyChanged("CelularenConvenio");
					OnCelularenConvenioChanged();
				}
			}
		}

		#endregion

		#region string Ciudad

		private string _ciudad;
		[DebuggerNonUserCode]
		[Column(Storage = "_ciudad", Name = "Ciudad", DbType = "varchar(50)", AutoSync = AutoSync.Never)]
		public string Ciudad
		{
			get
			{
				return _ciudad;
			}
			set
			{
				if (value != _ciudad)
				{
					OnCiudadChanging(value);
					SendPropertyChanging();
					_ciudad = value;
					SendPropertyChanged("Ciudad");
					OnCiudadChanged();
				}
			}
		}

		#endregion

		#region string CodigoPostal

		private string _codigoPostal;
		[DebuggerNonUserCode]
		[Column(Storage = "_codigoPostal", Name = "CodigoPostal", DbType = "varchar(10)", AutoSync = AutoSync.Never)]
		public string CodigoPostal
		{
			get
			{
				return _codigoPostal;
			}
			set
			{
				if (value != _codigoPostal)
				{
					OnCodigoPostalChanging(value);
					SendPropertyChanging();
					_codigoPostal = value;
					SendPropertyChanged("CodigoPostal");
					OnCodigoPostalChanged();
				}
			}
		}

		#endregion

		#region sbyte? CombatienteMilitar

		private sbyte? _combatienteMilitar;
		[DebuggerNonUserCode]
		[Column(Storage = "_combatienteMilitar", Name = "CombatienteMilitar", DbType = "tinyint(1)", AutoSync = AutoSync.Never)]
		public sbyte? CombatienteMilitar
		{
			get
			{
				return _combatienteMilitar;
			}
			set
			{
				if (value != _combatienteMilitar)
				{
					OnCombatienteMilitarChanging(value);
					SendPropertyChanging();
					_combatienteMilitar = value;
					SendPropertyChanged("CombatienteMilitar");
					OnCombatienteMilitarChanged();
				}
			}
		}

		#endregion

		#region sbyte? ConstanciaDomicilio

		private sbyte? _constanciaDomicilio;
		[DebuggerNonUserCode]
		[Column(Storage = "_constanciaDomicilio", Name = "ConstanciaDomicilio", DbType = "tinyint(1)", AutoSync = AutoSync.Never)]
		public sbyte? ConstanciaDomicilio
		{
			get
			{
				return _constanciaDomicilio;
			}
			set
			{
				if (value != _constanciaDomicilio)
				{
					OnConstanciaDomicilioChanging(value);
					SendPropertyChanging();
					_constanciaDomicilio = value;
					SendPropertyChanged("ConstanciaDomicilio");
					OnConstanciaDomicilioChanged();
				}
			}
		}

		#endregion

		#region string Direccion

		private string _direccion;
		[DebuggerNonUserCode]
		[Column(Storage = "_direccion", Name = "Direccion", DbType = "varchar(50)", AutoSync = AutoSync.Never)]
		public string Direccion
		{
			get
			{
				return _direccion;
			}
			set
			{
				if (value != _direccion)
				{
					OnDireccionChanging(value);
					SendPropertyChanging();
					_direccion = value;
					SendPropertyChanged("Direccion");
					OnDireccionChanged();
				}
			}
		}

		#endregion

		#region string DireccionDeEncuentro

		private string _direccionDeEncuentro;
		[DebuggerNonUserCode]
		[Column(Storage = "_direccionDeEncuentro", Name = "DireccionDeEncuentro", DbType = "varchar(100)", AutoSync = AutoSync.Never)]
		public string DireccionDeEncuentro
		{
			get
			{
				return _direccionDeEncuentro;
			}
			set
			{
				if (value != _direccionDeEncuentro)
				{
					OnDireccionDeEncuentroChanging(value);
					SendPropertyChanging();
					_direccionDeEncuentro = value;
					SendPropertyChanged("DireccionDeEncuentro");
					OnDireccionDeEncuentroChanged();
				}
			}
		}

		#endregion

		#region sbyte? Edad

		private sbyte? _edad;
		[DebuggerNonUserCode]
		[Column(Storage = "_edad", Name = "Edad", DbType = "tinyint(2)", AutoSync = AutoSync.Never)]
		public sbyte? Edad
		{
			get
			{
				return _edad;
			}
			set
			{
				if (value != _edad)
				{
					OnEdadChanging(value);
					SendPropertyChanging();
					_edad = value;
					SendPropertyChanged("Edad");
					OnEdadChanged();
				}
			}
		}

		#endregion

		#region string Email

		private string _email;
		[DebuggerNonUserCode]
		[Column(Storage = "_email", Name = "Email", DbType = "varchar(50)", AutoSync = AutoSync.Never)]
		public string Email
		{
			get
			{
				return _email;
			}
			set
			{
				if (value != _email)
				{
					OnEmailChanging(value);
					SendPropertyChanging();
					_email = value;
					SendPropertyChanged("Email");
					OnEmailChanged();
				}
			}
		}

		#endregion

		#region sbyte? EnServicioArmado

		private sbyte? _enServicioArmado;
		[DebuggerNonUserCode]
		[Column(Storage = "_enServicioArmado", Name = "EnServicioArmado", DbType = "tinyint(1)", AutoSync = AutoSync.Never)]
		public sbyte? EnServicioArmado
		{
			get
			{
				return _enServicioArmado;
			}
			set
			{
				if (value != _enServicioArmado)
				{
					OnEnServicioArmadoChanging(value);
					SendPropertyChanging();
					_enServicioArmado = value;
					SendPropertyChanged("EnServicioArmado");
					OnEnServicioArmadoChanged();
				}
			}
		}

		#endregion

		#region sbyte EnSindicato

		private sbyte _enSindicato;
		[DebuggerNonUserCode]
		[Column(Storage = "_enSindicato", Name = "EnSindicato", DbType = "tinyint(1)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public sbyte EnSindicato
		{
			get
			{
				return _enSindicato;
			}
			set
			{
				if (value != _enSindicato)
				{
					OnEnSindicatoChanging(value);
					SendPropertyChanging();
					_enSindicato = value;
					SendPropertyChanged("EnSindicato");
					OnEnSindicatoChanged();
				}
			}
		}

		#endregion

		#region string EntreCalles

		private string _entreCalles;
		[DebuggerNonUserCode]
		[Column(Storage = "_entreCalles", Name = "EntreCalles", DbType = "varchar(100)", AutoSync = AutoSync.Never)]
		public string EntreCalles
		{
			get
			{
				return _entreCalles;
			}
			set
			{
				if (value != _entreCalles)
				{
					OnEntreCallesChanging(value);
					SendPropertyChanging();
					_entreCalles = value;
					SendPropertyChanged("EntreCalles");
					OnEntreCallesChanged();
				}
			}
		}

		#endregion

		#region string EstadoCivil

		private string _estadoCivil;
		[DebuggerNonUserCode]
		[Column(Storage = "_estadoCivil", Name = "EstadoCivil", DbType = "varchar(11)", AutoSync = AutoSync.Never)]
		public string EstadoCivil
		{
			get
			{
				return _estadoCivil;
			}
			set
			{
				if (value != _estadoCivil)
				{
					OnEstadoCivilChanging(value);
					SendPropertyChanging();
					_estadoCivil = value;
					SendPropertyChanged("EstadoCivil");
					OnEstadoCivilChanged();
				}
			}
		}

		#endregion

		#region DateTime? FechaBaja

		private DateTime? _fechaBaja;
		[DebuggerNonUserCode]
		[Column(Storage = "_fechaBaja", Name = "FechaBaja", DbType = "date", AutoSync = AutoSync.Never)]
		public DateTime? FechaBaja
		{
			get
			{
				return _fechaBaja;
			}
			set
			{
				if (value != _fechaBaja)
				{
					OnFechaBajaChanging(value);
					SendPropertyChanging();
					_fechaBaja = value;
					SendPropertyChanged("FechaBaja");
					OnFechaBajaChanged();
				}
			}
		}

		#endregion

		#region DateTime? FechaEgresoPolicialoMilitar

		private DateTime? _fechaEgresoPolicialoMilitar;
		[DebuggerNonUserCode]
		[Column(Storage = "_fechaEgresoPolicialoMilitar", Name = "FechaEgresoPolicialoMilitar", DbType = "date", AutoSync = AutoSync.Never)]
		public DateTime? FechaEgresoPolicialoMilitar
		{
			get
			{
				return _fechaEgresoPolicialoMilitar;
			}
			set
			{
				if (value != _fechaEgresoPolicialoMilitar)
				{
					OnFechaEgresoPolicialoMilitarChanging(value);
					SendPropertyChanging();
					_fechaEgresoPolicialoMilitar = value;
					SendPropertyChanged("FechaEgresoPolicialoMilitar");
					OnFechaEgresoPolicialoMilitarChanged();
				}
			}
		}

		#endregion

		#region DateTime? FechaEntregaCelular

		private DateTime? _fechaEntregaCelular;
		[DebuggerNonUserCode]
		[Column(Storage = "_fechaEntregaCelular", Name = "FechaEntregaCelular", DbType = "date", AutoSync = AutoSync.Never)]
		public DateTime? FechaEntregaCelular
		{
			get
			{
				return _fechaEntregaCelular;
			}
			set
			{
				if (value != _fechaEntregaCelular)
				{
					OnFechaEntregaCelularChanging(value);
					SendPropertyChanging();
					_fechaEntregaCelular = value;
					SendPropertyChanged("FechaEntregaCelular");
					OnFechaEntregaCelularChanged();
				}
			}
		}

		#endregion

		#region DateTime? FechaIngreso

		private DateTime? _fechaIngreso;
		[DebuggerNonUserCode]
		[Column(Storage = "_fechaIngreso", Name = "FechaIngreso", DbType = "date", AutoSync = AutoSync.Never)]
		public DateTime? FechaIngreso
		{
			get
			{
				return _fechaIngreso;
			}
			set
			{
				if (value != _fechaIngreso)
				{
					OnFechaIngresoChanging(value);
					SendPropertyChanging();
					_fechaIngreso = value;
					SendPropertyChanged("FechaIngreso");
					OnFechaIngresoChanged();
				}
			}
		}

		#endregion

		#region DateTime? FechaIngresoPolicialoMilitar

		private DateTime? _fechaIngresoPolicialoMilitar;
		[DebuggerNonUserCode]
		[Column(Storage = "_fechaIngresoPolicialoMilitar", Name = "FechaIngresoPolicialoMilitar", DbType = "date", AutoSync = AutoSync.Never)]
		public DateTime? FechaIngresoPolicialoMilitar
		{
			get
			{
				return _fechaIngresoPolicialoMilitar;
			}
			set
			{
				if (value != _fechaIngresoPolicialoMilitar)
				{
					OnFechaIngresoPolicialoMilitarChanging(value);
					SendPropertyChanging();
					_fechaIngresoPolicialoMilitar = value;
					SendPropertyChanged("FechaIngresoPolicialoMilitar");
					OnFechaIngresoPolicialoMilitarChanged();
				}
			}
		}

		#endregion

		#region DateTime? FechaNacimiento

		private DateTime? _fechaNacimiento;
		[DebuggerNonUserCode]
		[Column(Storage = "_fechaNacimiento", Name = "FechaNacimiento", DbType = "date", AutoSync = AutoSync.Never)]
		public DateTime? FechaNacimiento
		{
			get
			{
				return _fechaNacimiento;
			}
			set
			{
				if (value != _fechaNacimiento)
				{
					OnFechaNacimientoChanging(value);
					SendPropertyChanging();
					_fechaNacimiento = value;
					SendPropertyChanged("FechaNacimiento");
					OnFechaNacimientoChanged();
				}
			}
		}

		#endregion

		#region DateTime? FechaPagoEfectuado

		private DateTime? _fechaPagoEfectuado;
		[DebuggerNonUserCode]
		[Column(Storage = "_fechaPagoEfectuado", Name = "FechaPagoEfectuado", DbType = "date", AutoSync = AutoSync.Never)]
		public DateTime? FechaPagoEfectuado
		{
			get
			{
				return _fechaPagoEfectuado;
			}
			set
			{
				if (value != _fechaPagoEfectuado)
				{
					OnFechaPagoEfectuadoChanging(value);
					SendPropertyChanging();
					_fechaPagoEfectuado = value;
					SendPropertyChanged("FechaPagoEfectuado");
					OnFechaPagoEfectuadoChanged();
				}
			}
		}

		#endregion

		#region DateTime? FechaPrevistaPago

		private DateTime? _fechaPrevistaPago;
		[DebuggerNonUserCode]
		[Column(Storage = "_fechaPrevistaPago", Name = "FechaPrevistaPago", DbType = "date", AutoSync = AutoSync.Never)]
		public DateTime? FechaPrevistaPago
		{
			get
			{
				return _fechaPrevistaPago;
			}
			set
			{
				if (value != _fechaPrevistaPago)
				{
					OnFechaPrevistaPagoChanging(value);
					SendPropertyChanging();
					_fechaPrevistaPago = value;
					SendPropertyChanged("FechaPrevistaPago");
					OnFechaPrevistaPagoChanged();
				}
			}
		}

		#endregion

		#region DateTime? FechaTestPsicologico

		private DateTime? _fechaTestPsicologico;
		[DebuggerNonUserCode]
		[Column(Storage = "_fechaTestPsicologico", Name = "FechaTestPsicologico", DbType = "date", AutoSync = AutoSync.Never)]
		public DateTime? FechaTestPsicologico
		{
			get
			{
				return _fechaTestPsicologico;
			}
			set
			{
				if (value != _fechaTestPsicologico)
				{
					OnFechaTestPsicologicoChanging(value);
					SendPropertyChanging();
					_fechaTestPsicologico = value;
					SendPropertyChanged("FechaTestPsicologico");
					OnFechaTestPsicologicoChanged();
				}
			}
		}

		#endregion

		#region DateTime? FechaVencimientoCarneDeSalud

		private DateTime? _fechaVencimientoCarneDeSalud;
		[DebuggerNonUserCode]
		[Column(Storage = "_fechaVencimientoCarneDeSalud", Name = "FechaVencimientoCarneDeSalud", DbType = "date", AutoSync = AutoSync.Never)]
		public DateTime? FechaVencimientoCarneDeSalud
		{
			get
			{
				return _fechaVencimientoCarneDeSalud;
			}
			set
			{
				if (value != _fechaVencimientoCarneDeSalud)
				{
					OnFechaVencimientoCarneDeSaludChanging(value);
					SendPropertyChanging();
					_fechaVencimientoCarneDeSalud = value;
					SendPropertyChanged("FechaVencimientoCarneDeSalud");
					OnFechaVencimientoCarneDeSaludChanged();
				}
			}
		}

		#endregion

		#region Byte[] Foto

		private Byte[] _foto;
		[DebuggerNonUserCode]
		[Column(Storage = "_foto", Name = "Foto", DbType = "blob", AutoSync = AutoSync.Never)]
		public Byte[] Foto
		{
			get
			{
				return _foto;
			}
			set
			{
				if (value != _foto)
				{
					OnFotoChanging(value);
					SendPropertyChanging();
					_foto = value;
					SendPropertyChanged("Foto");
					OnFotoChanged();
				}
			}
		}

		#endregion

		#region sbyte? IDBarrio

		private sbyte? _idbArrio;
		[DebuggerNonUserCode]
		[Column(Storage = "_idbArrio", Name = "IdBarrio", DbType = "tinyint(2)", AutoSync = AutoSync.Never)]
		public sbyte? IDBarrio
		{
			get
			{
				return _idbArrio;
			}
			set
			{
				if (value != _idbArrio)
				{
					OnIDBarrioChanging(value);
					SendPropertyChanging();
					_idbArrio = value;
					SendPropertyChanged("IDBarrio");
					OnIDBarrioChanged();
				}
			}
		}

		#endregion

		#region uint IDCargo

		private uint _idcArgo;
		[DebuggerNonUserCode]
		[Column(Storage = "_idcArgo", Name = "IdCargo", DbType = "mediumint unsigned", AutoSync = AutoSync.Never, CanBeNull = false)]
		public uint IDCargo
		{
			get
			{
				return _idcArgo;
			}
			set
			{
				if (value != _idcArgo)
				{
					OnIDCargoChanging(value);
					SendPropertyChanging();
					_idcArgo = value;
					SendPropertyChanged("IDCargo");
					OnIDCargoChanged();
				}
			}
		}

		#endregion

		#region sbyte? IDCiudad

		private sbyte? _idcIudad;
		[DebuggerNonUserCode]
		[Column(Storage = "_idcIudad", Name = "IdCiudad", DbType = "tinyint(2)", AutoSync = AutoSync.Never)]
		public sbyte? IDCiudad
		{
			get
			{
				return _idcIudad;
			}
			set
			{
				if (value != _idcIudad)
				{
					OnIDCiudadChanging(value);
					SendPropertyChanging();
					_idcIudad = value;
					SendPropertyChanged("IDCiudad");
					OnIDCiudadChanged();
				}
			}
		}

		#endregion

		#region sbyte? IDDepartamento

		private sbyte? _iddEpartamento;
		[DebuggerNonUserCode]
		[Column(Storage = "_iddEpartamento", Name = "IdDepartamento", DbType = "tinyint(2)", AutoSync = AutoSync.Never)]
		public sbyte? IDDepartamento
		{
			get
			{
				return _iddEpartamento;
			}
			set
			{
				if (value != _iddEpartamento)
				{
					OnIDDepartamentoChanging(value);
					SendPropertyChanging();
					_iddEpartamento = value;
					SendPropertyChanged("IDDepartamento");
					OnIDDepartamentoChanged();
				}
			}
		}

		#endregion

		#region byte? IDEmergenciaMedica

		private byte? _ideMergenciaMedica;
		[DebuggerNonUserCode]
		[Column(Storage = "_ideMergenciaMedica", Name = "IdEmergenciaMedica", DbType = "tinyint(2) unsigned", AutoSync = AutoSync.Never)]
		public byte? IDEmergenciaMedica
		{
			get
			{
				return _ideMergenciaMedica;
			}
			set
			{
				if (value != _ideMergenciaMedica)
				{
					OnIDEmergenciaMedicaChanging(value);
					SendPropertyChanging();
					_ideMergenciaMedica = value;
					SendPropertyChanged("IDEmergenciaMedica");
					OnIDEmergenciaMedicaChanged();
				}
			}
		}

		#endregion

		#region byte? IDMutualista

		private byte? _idmUtualista;
		[DebuggerNonUserCode]
		[Column(Storage = "_idmUtualista", Name = "IdMutualista", DbType = "tinyint(2) unsigned", AutoSync = AutoSync.Never)]
		public byte? IDMutualista
		{
			get
			{
				return _idmUtualista;
			}
			set
			{
				if (value != _idmUtualista)
				{
					OnIDMutualistaChanging(value);
					SendPropertyChanging();
					_idmUtualista = value;
					SendPropertyChanged("IDMutualista");
					OnIDMutualistaChanged();
				}
			}
		}

		#endregion

		#region sbyte IDTipoDocumento

		private sbyte _idtIpoDocumento;
		[DebuggerNonUserCode]
		[Column(Storage = "_idtIpoDocumento", Name = "IdTipoDocumento", DbType = "tinyint(4)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public sbyte IDTipoDocumento
		{
			get
			{
				return _idtIpoDocumento;
			}
			set
			{
				if (value != _idtIpoDocumento)
				{
					OnIDTipoDocumentoChanging(value);
					SendPropertyChanging();
					_idtIpoDocumento = value;
					SendPropertyChanged("IDTipoDocumento");
					OnIDTipoDocumentoChanged();
				}
			}
		}

		#endregion

		#region string LugarDeNacimiento

		private string _lugarDeNacimiento;
		[DebuggerNonUserCode]
		[Column(Storage = "_lugarDeNacimiento", Name = "LugarDeNacimiento", DbType = "varchar(50)", AutoSync = AutoSync.Never)]
		public string LugarDeNacimiento
		{
			get
			{
				return _lugarDeNacimiento;
			}
			set
			{
				if (value != _lugarDeNacimiento)
				{
					OnLugarDeNacimientoChanging(value);
					SendPropertyChanging();
					_lugarDeNacimiento = value;
					SendPropertyChanged("LugarDeNacimiento");
					OnLugarDeNacimientoChanged();
				}
			}
		}

		#endregion

		#region string MotivoBaja

		private string _motivoBaja;
		[DebuggerNonUserCode]
		[Column(Storage = "_motivoBaja", Name = "MotivoBaja", DbType = "varchar(100)", AutoSync = AutoSync.Never)]
		public string MotivoBaja
		{
			get
			{
				return _motivoBaja;
			}
			set
			{
				if (value != _motivoBaja)
				{
					OnMotivoBajaChanging(value);
					SendPropertyChanging();
					_motivoBaja = value;
					SendPropertyChanged("MotivoBaja");
					OnMotivoBajaChanged();
				}
			}
		}

		#endregion

		#region string NivelEducativo

		private string _nivelEducativo;
		[DebuggerNonUserCode]
		[Column(Storage = "_nivelEducativo", Name = "NivelEducativo", DbType = "varchar(10)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public string NivelEducativo
		{
			get
			{
				return _nivelEducativo;
			}
			set
			{
				if (value != _nivelEducativo)
				{
					OnNivelEducativoChanging(value);
					SendPropertyChanging();
					_nivelEducativo = value;
					SendPropertyChanged("NivelEducativo");
					OnNivelEducativoChanged();
				}
			}
		}

		#endregion

		#region sbyte NoHabilitadoParaServicio

		private sbyte _noHabilitadoParaServicio;
		[DebuggerNonUserCode]
		[Column(Storage = "_noHabilitadoParaServicio", Name = "NoHabilitadoParaServicio", DbType = "tinyint(1)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public sbyte NoHabilitadoParaServicio
		{
			get
			{
				return _noHabilitadoParaServicio;
			}
			set
			{
				if (value != _noHabilitadoParaServicio)
				{
					OnNoHabilitadoParaServicioChanging(value);
					SendPropertyChanging();
					_noHabilitadoParaServicio = value;
					SendPropertyChanged("NoHabilitadoParaServicio");
					OnNoHabilitadoParaServicioChanged();
				}
			}
		}

		#endregion

		#region sbyte NoLlevaTicketsAlimentacion

		private sbyte _noLlevaTicketsAlimentacion;
		[DebuggerNonUserCode]
		[Column(Storage = "_noLlevaTicketsAlimentacion", Name = "NoLlevaTicketsAlimentacion", DbType = "tinyint(1)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public sbyte NoLlevaTicketsAlimentacion
		{
			get
			{
				return _noLlevaTicketsAlimentacion;
			}
			set
			{
				if (value != _noLlevaTicketsAlimentacion)
				{
					OnNoLlevaTicketsAlimentacionChanging(value);
					SendPropertyChanging();
					_noLlevaTicketsAlimentacion = value;
					SendPropertyChanged("NoLlevaTicketsAlimentacion");
					OnNoLlevaTicketsAlimentacionChanged();
				}
			}
		}

		#endregion

		#region string Nombre

		private string _nombre;
		[DebuggerNonUserCode]
		[Column(Storage = "_nombre", Name = "Nombre", DbType = "varchar(50)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public string Nombre
		{
			get
			{
				return _nombre;
			}
			set
			{
				if (value != _nombre)
				{
					OnNombreChanging(value);
					SendPropertyChanging();
					_nombre = value;
					SendPropertyChanged("Nombre");
					OnNombreChanged();
				}
			}
		}

		#endregion

		#region uint NroEmpleado

		private uint _nroEmpleado;
		[DebuggerNonUserCode]
		[Column(Storage = "_nroEmpleado", Name = "NroEmpleado", DbType = "mediumint unsigned", IsPrimaryKey = true, AutoSync = AutoSync.Never, CanBeNull = false)]
		public uint NroEmpleado
		{
			get
			{
				return _nroEmpleado;
			}
			set
			{
				if (value != _nroEmpleado)
				{
					OnNroEmpleadoChanging(value);
					SendPropertyChanging();
					_nroEmpleado = value;
					SendPropertyChanged("NroEmpleado");
					OnNroEmpleadoChanged();
				}
			}
		}

		#endregion

		#region string NumeroDocumento

		private string _numeroDocumento;
		[DebuggerNonUserCode]
		[Column(Storage = "_numeroDocumento", Name = "NumeroDocumento", DbType = "varchar(30)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public string NumeroDocumento
		{
			get
			{
				return _numeroDocumento;
			}
			set
			{
				if (value != _numeroDocumento)
				{
					OnNumeroDocumentoChanging(value);
					SendPropertyChanging();
					_numeroDocumento = value;
					SendPropertyChanged("NumeroDocumento");
					OnNumeroDocumentoChanged();
				}
			}
		}

		#endregion

		#region string Observaciones

		private string _observaciones;
		[DebuggerNonUserCode]
		[Column(Storage = "_observaciones", Name = "Observaciones", DbType = "varchar(255)", AutoSync = AutoSync.Never)]
		public string Observaciones
		{
			get
			{
				return _observaciones;
			}
			set
			{
				if (value != _observaciones)
				{
					OnObservacionesChanging(value);
					SendPropertyChanging();
					_observaciones = value;
					SendPropertyChanged("Observaciones");
					OnObservacionesChanged();
				}
			}
		}

		#endregion

		#region string ObservacionesAntecedentes

		private string _observacionesAntecedentes;
		[DebuggerNonUserCode]
		[Column(Storage = "_observacionesAntecedentes", Name = "ObservacionesAntecedentes", DbType = "varchar(255)", AutoSync = AutoSync.Never)]
		public string ObservacionesAntecedentes
		{
			get
			{
				return _observacionesAntecedentes;
			}
			set
			{
				if (value != _observacionesAntecedentes)
				{
					OnObservacionesAntecedentesChanging(value);
					SendPropertyChanging();
					_observacionesAntecedentes = value;
					SendPropertyChanged("ObservacionesAntecedentes");
					OnObservacionesAntecedentesChanged();
				}
			}
		}

		#endregion

		#region sbyte? PolicialesoMilitar

		private sbyte? _policialesoMilitar;
		[DebuggerNonUserCode]
		[Column(Storage = "_policialesoMilitar", Name = "PolicialesoMilitar", DbType = "tinyint(1)", AutoSync = AutoSync.Never)]
		public sbyte? PolicialesoMilitar
		{
			get
			{
				return _policialesoMilitar;
			}
			set
			{
				if (value != _policialesoMilitar)
				{
					OnPolicialesoMilitarChanging(value);
					SendPropertyChanging();
					_policialesoMilitar = value;
					SendPropertyChanged("PolicialesoMilitar");
					OnPolicialesoMilitarChanged();
				}
			}
		}

		#endregion

		#region DateTime? RenaemsefEchaIngreso

		private DateTime? _renaemsefEchaIngreso;
		[DebuggerNonUserCode]
		[Column(Storage = "_renaemsefEchaIngreso", Name = "RENAEMSE_FechaIngreso", DbType = "date", AutoSync = AutoSync.Never)]
		public DateTime? RenaemsefEchaIngreso
		{
			get
			{
				return _renaemsefEchaIngreso;
			}
			set
			{
				if (value != _renaemsefEchaIngreso)
				{
					OnRenaemsefEchaIngresoChanging(value);
					SendPropertyChanging();
					_renaemsefEchaIngreso = value;
					SendPropertyChanged("RenaemsefEchaIngreso");
					OnRenaemsefEchaIngresoChanged();
				}
			}
		}

		#endregion

		#region string RenaemsenUmeroAsunto

		private string _renaemsenUmeroAsunto;
		[DebuggerNonUserCode]
		[Column(Storage = "_renaemsenUmeroAsunto", Name = "RENAEMSE_NumeroAsunto", DbType = "varchar(20)", AutoSync = AutoSync.Never)]
		public string RenaemsenUmeroAsunto
		{
			get
			{
				return _renaemsenUmeroAsunto;
			}
			set
			{
				if (value != _renaemsenUmeroAsunto)
				{
					OnRenaemsenUmeroAsuntoChanging(value);
					SendPropertyChanging();
					_renaemsenUmeroAsunto = value;
					SendPropertyChanged("RenaemsenUmeroAsunto");
					OnRenaemsenUmeroAsuntoChanged();
				}
			}
		}

		#endregion

		#region string ServicioActual

		private string _servicioActual;
		[DebuggerNonUserCode]
		[Column(Storage = "_servicioActual", Name = "ServicioActual", DbType = "varchar(100)", AutoSync = AutoSync.Never)]
		public string ServicioActual
		{
			get
			{
				return _servicioActual;
			}
			set
			{
				if (value != _servicioActual)
				{
					OnServicioActualChanging(value);
					SendPropertyChanging();
					_servicioActual = value;
					SendPropertyChanged("ServicioActual");
					OnServicioActualChanged();
				}
			}
		}

		#endregion

		#region string SexO

		private string _sexO;
		[DebuggerNonUserCode]
		[Column(Storage = "_sexO", Name = "sexo", DbType = "char(1)", AutoSync = AutoSync.Never)]
		public string SexO
		{
			get
			{
				return _sexO;
			}
			set
			{
				if (value != _sexO)
				{
					OnSexOChanging(value);
					SendPropertyChanging();
					_sexO = value;
					SendPropertyChanged("SexO");
					OnSexOChanged();
				}
			}
		}

		#endregion

		#region string SubEscalafonPolicial

		private string _subEscalafonPolicial;
		[DebuggerNonUserCode]
		[Column(Storage = "_subEscalafonPolicial", Name = "SubEscalafonPolicial", DbType = "varchar(30)", AutoSync = AutoSync.Never)]
		public string SubEscalafonPolicial
		{
			get
			{
				return _subEscalafonPolicial;
			}
			set
			{
				if (value != _subEscalafonPolicial)
				{
					OnSubEscalafonPolicialChanging(value);
					SendPropertyChanging();
					_subEscalafonPolicial = value;
					SendPropertyChanged("SubEscalafonPolicial");
					OnSubEscalafonPolicialChanged();
				}
			}
		}

		#endregion

		#region string TalleCamisa

		private string _talleCamisa;
		[DebuggerNonUserCode]
		[Column(Storage = "_talleCamisa", Name = "TalleCamisa", DbType = "varchar(4)", AutoSync = AutoSync.Never)]
		public string TalleCamisa
		{
			get
			{
				return _talleCamisa;
			}
			set
			{
				if (value != _talleCamisa)
				{
					OnTalleCamisaChanging(value);
					SendPropertyChanging();
					_talleCamisa = value;
					SendPropertyChanged("TalleCamisa");
					OnTalleCamisaChanged();
				}
			}
		}

		#endregion

		#region string TalleCampera

		private string _talleCampera;
		[DebuggerNonUserCode]
		[Column(Storage = "_talleCampera", Name = "TalleCampera", DbType = "varchar(4)", AutoSync = AutoSync.Never)]
		public string TalleCampera
		{
			get
			{
				return _talleCampera;
			}
			set
			{
				if (value != _talleCampera)
				{
					OnTalleCamperaChanging(value);
					SendPropertyChanging();
					_talleCampera = value;
					SendPropertyChanged("TalleCampera");
					OnTalleCamperaChanged();
				}
			}
		}

		#endregion

		#region string TallePantalon

		private string _tallePantalon;
		[DebuggerNonUserCode]
		[Column(Storage = "_tallePantalon", Name = "TallePantalon", DbType = "varchar(4)", AutoSync = AutoSync.Never)]
		public string TallePantalon
		{
			get
			{
				return _tallePantalon;
			}
			set
			{
				if (value != _tallePantalon)
				{
					OnTallePantalonChanging(value);
					SendPropertyChanging();
					_tallePantalon = value;
					SendPropertyChanged("TallePantalon");
					OnTallePantalonChanged();
				}
			}
		}

		#endregion

		#region sbyte? TalleZapatos

		private sbyte? _talleZapatos;
		[DebuggerNonUserCode]
		[Column(Storage = "_talleZapatos", Name = "TalleZapatos", DbType = "tinyint(2)", AutoSync = AutoSync.Never)]
		public sbyte? TalleZapatos
		{
			get
			{
				return _talleZapatos;
			}
			set
			{
				if (value != _talleZapatos)
				{
					OnTalleZapatosChanging(value);
					SendPropertyChanging();
					_talleZapatos = value;
					SendPropertyChanged("TalleZapatos");
					OnTalleZapatosChanged();
				}
			}
		}

		#endregion

		#region string Telefonos

		private string _telefonos;
		[DebuggerNonUserCode]
		[Column(Storage = "_telefonos", Name = "Telefonos", DbType = "varchar(50)", AutoSync = AutoSync.Never)]
		public string Telefonos
		{
			get
			{
				return _telefonos;
			}
			set
			{
				if (value != _telefonos)
				{
					OnTelefonosChanging(value);
					SendPropertyChanging();
					_telefonos = value;
					SendPropertyChanged("Telefonos");
					OnTelefonosChanged();
				}
			}
		}

		#endregion

		#region string Turno

		private string _turno;
		[DebuggerNonUserCode]
		[Column(Storage = "_turno", Name = "Turno", DbType = "varchar(10)", AutoSync = AutoSync.Never)]
		public string Turno
		{
			get
			{
				return _turno;
			}
			set
			{
				if (value != _turno)
				{
					OnTurnoChanging(value);
					SendPropertyChanging();
					_turno = value;
					SendPropertyChanged("Turno");
					OnTurnoChanged();
				}
			}
		}

		#endregion

		#region float? ValorHora

		private float? _valorHora;
		[DebuggerNonUserCode]
		[Column(Storage = "_valorHora", Name = "ValorHora", DbType = "float(8,2)", AutoSync = AutoSync.Never)]
		public float? ValorHora
		{
			get
			{
				return _valorHora;
			}
			set
			{
				if (value != _valorHora)
				{
					OnValorHoraChanging(value);
					SendPropertyChanging();
					_valorHora = value;
					SendPropertyChanged("ValorHora");
					OnValorHoraChanged();
				}
			}
		}

		#endregion

		#region Children

		private EntitySet<EScalaFOneMpLeadO> _esCalaFoNeMpLeadO;
		[Association(Storage = "_esCalaFoNeMpLeadO", OtherKey = "NroEmpleado", ThisKey = "NroEmpleado", Name = "escalafonempleado_ibfk_1")]
		[DebuggerNonUserCode]
		public EntitySet<EScalaFOneMpLeadO> EScalaFOneMpLeadO
		{
			get
			{
				return _esCalaFoNeMpLeadO;
			}
			set
			{
				_esCalaFoNeMpLeadO = value;
			}
		}

		private EntitySet<EventOsHistOrIalEmPleadO> _eventOsHistOrIalEmPleadO;
		[Association(Storage = "_eventOsHistOrIalEmPleadO", OtherKey = "IDEmpleado", ThisKey = "NroEmpleado", Name = "eventoshistorialempleado_ibfk_1")]
		[DebuggerNonUserCode]
		public EntitySet<EventOsHistOrIalEmPleadO> EventOsHistOrIalEmPleadO
		{
			get
			{
				return _eventOsHistOrIalEmPleadO;
			}
			set
			{
				_eventOsHistOrIalEmPleadO = value;
			}
		}

		private EntitySet<ExtrasLiquidAcIon> _extrasLiquidAcIon;
		[Association(Storage = "_extrasLiquidAcIon", OtherKey = "IDEmpleado", ThisKey = "NroEmpleado", Name = "extrasliquidacion_ibfk_1")]
		[DebuggerNonUserCode]
		public EntitySet<ExtrasLiquidAcIon> ExtrasLiquidAcIon
		{
			get
			{
				return _extrasLiquidAcIon;
			}
			set
			{
				_extrasLiquidAcIon = value;
			}
		}

		private EntitySet<HoRaRioEScalaFOn> _hoRaRioEsCalaFoN;
		[Association(Storage = "_hoRaRioEsCalaFoN", OtherKey = "NroEmpleado", ThisKey = "NroEmpleado", Name = "horarioescalafon_ibfk_2")]
		[DebuggerNonUserCode]
		public EntitySet<HoRaRioEScalaFOn> HoRaRioEScalaFOn
		{
			get
			{
				return _hoRaRioEsCalaFoN;
			}
			set
			{
				_hoRaRioEsCalaFoN = value;
			}
		}

		private EntitySet<HoRaSGeneraDaSEScalaFOn> _hoRaSgEneraDaSesCalaFoN;
		[Association(Storage = "_hoRaSgEneraDaSesCalaFoN", OtherKey = "NroEmpleado", ThisKey = "NroEmpleado", Name = "horasgeneradasescalafon_ibfk_3")]
		[DebuggerNonUserCode]
		public EntitySet<HoRaSGeneraDaSEScalaFOn> HoRaSGeneraDaSEScalaFOn
		{
			get
			{
				return _hoRaSgEneraDaSesCalaFoN;
			}
			set
			{
				_hoRaSgEneraDaSesCalaFoN = value;
			}
		}

		private EntitySet<MotIVOsCamBiosDiARioS> _motIvoSCamBiosDiArIoS;
		[Association(Storage = "_motIvoSCamBiosDiArIoS", OtherKey = "NroEmpleado", ThisKey = "NroEmpleado", Name = "motivoscambiosdiarios_ibfk_3")]
		[DebuggerNonUserCode]
		public EntitySet<MotIVOsCamBiosDiARioS> MotIVOsCamBiosDiARioS
		{
			get
			{
				return _motIvoSCamBiosDiArIoS;
			}
			set
			{
				_motIvoSCamBiosDiArIoS = value;
			}
		}


		#endregion

		#region Parents

		private EntityRef<TipOscarGoS> _tipOscarGoS;
		[Association(Storage = "_tipOscarGoS", OtherKey = "IDCargo", ThisKey = "IDCargo", Name = "empleados_ibfk_1", IsForeignKey = true)]
		[DebuggerNonUserCode]
		public TipOscarGoS TipOscarGoS
		{
			get
			{
				return _tipOscarGoS.Entity;
			}
			set
			{
				if (value != _tipOscarGoS.Entity)
				{
					if (_tipOscarGoS.Entity != null)
					{
						var previousTipOscarGoS = _tipOscarGoS.Entity;
						_tipOscarGoS.Entity = null;
						previousTipOscarGoS.EmPleadOs.Remove(this);
					}
					_tipOscarGoS.Entity = value;
					if (value != null)
					{
						value.EmPleadOs.Add(this);
						_idcArgo = value.IDCargo;
					}
					else
					{
						_idcArgo = default(uint);
					}
				}
			}
		}


		#endregion

		#region Attachement handlers

		private void EScalaFOneMpLeadO_Attach(EScalaFOneMpLeadO entity)
		{
			entity.EmPleadOs = this;
		}

		private void EScalaFOneMpLeadO_Detach(EScalaFOneMpLeadO entity)
		{
			entity.EmPleadOs = null;
		}

		private void EventOsHistOrIalEmPleadO_Attach(EventOsHistOrIalEmPleadO entity)
		{
			entity.EmPleadOs = this;
		}

		private void EventOsHistOrIalEmPleadO_Detach(EventOsHistOrIalEmPleadO entity)
		{
			entity.EmPleadOs = null;
		}

		private void ExtrasLiquidAcIon_Attach(ExtrasLiquidAcIon entity)
		{
			entity.EmPleadOs = this;
		}

		private void ExtrasLiquidAcIon_Detach(ExtrasLiquidAcIon entity)
		{
			entity.EmPleadOs = null;
		}

		private void HoRaRioEScalaFOn_Attach(HoRaRioEScalaFOn entity)
		{
			entity.EmPleadOs = this;
		}

		private void HoRaRioEScalaFOn_Detach(HoRaRioEScalaFOn entity)
		{
			entity.EmPleadOs = null;
		}

		private void HoRaSGeneraDaSEScalaFOn_Attach(HoRaSGeneraDaSEScalaFOn entity)
		{
			entity.EmPleadOs = this;
		}

		private void HoRaSGeneraDaSEScalaFOn_Detach(HoRaSGeneraDaSEScalaFOn entity)
		{
			entity.EmPleadOs = null;
		}

		private void MotIVOsCamBiosDiARioS_Attach(MotIVOsCamBiosDiARioS entity)
		{
			entity.EmPleadOs = this;
		}

		private void MotIVOsCamBiosDiARioS_Detach(MotIVOsCamBiosDiARioS entity)
		{
			entity.EmPleadOs = null;
		}


		#endregion

		#region ctor

		public EmPleadOs()
		{
			_esCalaFoNeMpLeadO = new EntitySet<EScalaFOneMpLeadO>(EScalaFOneMpLeadO_Attach, EScalaFOneMpLeadO_Detach);
			_eventOsHistOrIalEmPleadO = new EntitySet<EventOsHistOrIalEmPleadO>(EventOsHistOrIalEmPleadO_Attach, EventOsHistOrIalEmPleadO_Detach);
			_extrasLiquidAcIon = new EntitySet<ExtrasLiquidAcIon>(ExtrasLiquidAcIon_Attach, ExtrasLiquidAcIon_Detach);
			_hoRaRioEsCalaFoN = new EntitySet<HoRaRioEScalaFOn>(HoRaRioEScalaFOn_Attach, HoRaRioEScalaFOn_Detach);
			_hoRaSgEneraDaSesCalaFoN = new EntitySet<HoRaSGeneraDaSEScalaFOn>(HoRaSGeneraDaSEScalaFOn_Attach, HoRaSGeneraDaSEScalaFOn_Detach);
			_motIvoSCamBiosDiArIoS = new EntitySet<MotIVOsCamBiosDiARioS>(MotIVOsCamBiosDiARioS_Attach, MotIVOsCamBiosDiARioS_Detach);
			_tipOscarGoS = new EntityRef<TipOscarGoS>();
			OnCreated();
		}

		#endregion

	}

	[Table(Name = "trustdb.enteros")]
	public partial class EnterOs : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region INotifyPropertyChanging handling

		public event PropertyChangingEventHandler PropertyChanging;

		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs("");
		protected virtual void SendPropertyChanging()
		{
			if (PropertyChanging != null)
			{
				PropertyChanging(this, emptyChangingEventArgs);
			}
		}

		#endregion

		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void SendPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region Extensibility Method Definitions

		partial void OnCreated();
		partial void OnEnterOChanged();
		partial void OnEnterOChanging(int? value);

		#endregion

		#region int? EnterO

		private int? _enterO;
		[DebuggerNonUserCode]
		[Column(Storage = "_enterO", Name = "entero", DbType = "int", AutoSync = AutoSync.Never)]
		public int? EnterO
		{
			get
			{
				return _enterO;
			}
			set
			{
				if (value != _enterO)
				{
					OnEnterOChanging(value);
					SendPropertyChanging();
					_enterO = value;
					SendPropertyChanged("EnterO");
					OnEnterOChanged();
				}
			}
		}

		#endregion

		#region ctor

		public EnterOs()
		{
			OnCreated();
		}

		#endregion

	}

	[Table(Name = "trustdb.escalafon")]
	public partial class EScalaFOn : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region INotifyPropertyChanging handling

		public event PropertyChangingEventHandler PropertyChanging;

		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs("");
		protected virtual void SendPropertyChanging()
		{
			if (PropertyChanging != null)
			{
				PropertyChanging(this, emptyChangingEventArgs);
			}
		}

		#endregion

		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void SendPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region Extensibility Method Definitions

		partial void OnCreated();
		partial void OnCubiertoChanged();
		partial void OnCubiertoChanging(sbyte value);
		partial void OnIDContratoChanged();
		partial void OnIDContratoChanging(uint value);
		partial void OnIDEscalafonChanged();
		partial void OnIDEscalafonChanging(uint value);
		partial void OnNumeroClienteChanged();
		partial void OnNumeroClienteChanging(uint value);
		partial void OnNumeroServicioChanged();
		partial void OnNumeroServicioChanging(uint value);

		#endregion

		#region sbyte Cubierto

		private sbyte _cubierto;
		[DebuggerNonUserCode]
		[Column(Storage = "_cubierto", Name = "Cubierto", DbType = "tinyint(1)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public sbyte Cubierto
		{
			get
			{
				return _cubierto;
			}
			set
			{
				if (value != _cubierto)
				{
					OnCubiertoChanging(value);
					SendPropertyChanging();
					_cubierto = value;
					SendPropertyChanged("Cubierto");
					OnCubiertoChanged();
				}
			}
		}

		#endregion

		#region uint IDContrato

		private uint _idcOntrato;
		[DebuggerNonUserCode]
		[Column(Storage = "_idcOntrato", Name = "IdContrato", DbType = "mediumint unsigned", AutoSync = AutoSync.Never, CanBeNull = false)]
		public uint IDContrato
		{
			get
			{
				return _idcOntrato;
			}
			set
			{
				if (value != _idcOntrato)
				{
					OnIDContratoChanging(value);
					SendPropertyChanging();
					_idcOntrato = value;
					SendPropertyChanged("IDContrato");
					OnIDContratoChanged();
				}
			}
		}

		#endregion

		#region uint IDEscalafon

		private uint _ideScalafon;
		[DebuggerNonUserCode]
		[Column(Storage = "_ideScalafon", Name = "IdEscalafon", DbType = "int unsigned", IsPrimaryKey = true, AutoSync = AutoSync.Never, CanBeNull = false)]
		public uint IDEscalafon
		{
			get
			{
				return _ideScalafon;
			}
			set
			{
				if (value != _ideScalafon)
				{
					OnIDEscalafonChanging(value);
					SendPropertyChanging();
					_ideScalafon = value;
					SendPropertyChanged("IDEscalafon");
					OnIDEscalafonChanged();
				}
			}
		}

		#endregion

		#region uint NumeroCliente

		private uint _numeroCliente;
		[DebuggerNonUserCode]
		[Column(Storage = "_numeroCliente", Name = "NumeroCliente", DbType = "mediumint unsigned", AutoSync = AutoSync.Never, CanBeNull = false)]
		public uint NumeroCliente
		{
			get
			{
				return _numeroCliente;
			}
			set
			{
				if (value != _numeroCliente)
				{
					OnNumeroClienteChanging(value);
					SendPropertyChanging();
					_numeroCliente = value;
					SendPropertyChanged("NumeroCliente");
					OnNumeroClienteChanged();
				}
			}
		}

		#endregion

		#region uint NumeroServicio

		private uint _numeroServicio;
		[DebuggerNonUserCode]
		[Column(Storage = "_numeroServicio", Name = "NumeroServicio", DbType = "mediumint unsigned", AutoSync = AutoSync.Never, CanBeNull = false)]
		public uint NumeroServicio
		{
			get
			{
				return _numeroServicio;
			}
			set
			{
				if (value != _numeroServicio)
				{
					OnNumeroServicioChanging(value);
					SendPropertyChanging();
					_numeroServicio = value;
					SendPropertyChanged("NumeroServicio");
					OnNumeroServicioChanged();
				}
			}
		}

		#endregion

		#region Children

		private EntitySet<EScalaFOneMpLeadO> _esCalaFoNeMpLeadO;
		[Association(Storage = "_esCalaFoNeMpLeadO", OtherKey = "IDEscalafon", ThisKey = "IDEscalafon", Name = "FK_LineasEscalafon")]
		[DebuggerNonUserCode]
		public EntitySet<EScalaFOneMpLeadO> EScalaFOneMpLeadO
		{
			get
			{
				return _esCalaFoNeMpLeadO;
			}
			set
			{
				_esCalaFoNeMpLeadO = value;
			}
		}


		#endregion

		#region Attachement handlers

		private void EScalaFOneMpLeadO_Attach(EScalaFOneMpLeadO entity)
		{
			entity.EScalaFOn = this;
		}

		private void EScalaFOneMpLeadO_Detach(EScalaFOneMpLeadO entity)
		{
			entity.EScalaFOn = null;
		}


		#endregion

		#region ctor

		public EScalaFOn()
		{
			_esCalaFoNeMpLeadO = new EntitySet<EScalaFOneMpLeadO>(EScalaFOneMpLeadO_Attach, EScalaFOneMpLeadO_Detach);
			OnCreated();
		}

		#endregion

	}

	[Table(Name = "trustdb.escalafonempleado")]
	public partial class EScalaFOneMpLeadO : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region INotifyPropertyChanging handling

		public event PropertyChangingEventHandler PropertyChanging;

		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs("");
		protected virtual void SendPropertyChanging()
		{
			if (PropertyChanging != null)
			{
				PropertyChanging(this, emptyChangingEventArgs);
			}
		}

		#endregion

		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void SendPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region Extensibility Method Definitions

		partial void OnCreated();
		partial void OnAcArgoDeChanged();
		partial void OnAcArgoDeChanging(string value);
		partial void OnCodigoPuestoChanged();
		partial void OnCodigoPuestoChanging(string value);
		partial void OnHsLlamadaAntesHoraInicioChanged();
		partial void OnHsLlamadaAntesHoraInicioChanging(sbyte value);
		partial void OnIDEscalafonChanged();
		partial void OnIDEscalafonChanging(uint value);
		partial void OnIDEscalafonEmpleadoChanged();
		partial void OnIDEscalafonEmpleadoChanging(uint value);
		partial void OnNroEmpleadoChanged();
		partial void OnNroEmpleadoChanging(uint value);

		#endregion

		#region string AcArgoDe

		private string _acArgoDe;
		[DebuggerNonUserCode]
		[Column(Storage = "_acArgoDe", Name = "ACargoDe", DbType = "varchar(10)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public string AcArgoDe
		{
			get
			{
				return _acArgoDe;
			}
			set
			{
				if (value != _acArgoDe)
				{
					OnAcArgoDeChanging(value);
					SendPropertyChanging();
					_acArgoDe = value;
					SendPropertyChanged("AcArgoDe");
					OnAcArgoDeChanged();
				}
			}
		}

		#endregion

		#region string CodigoPuesto

		private string _codigoPuesto;
		[DebuggerNonUserCode]
		[Column(Storage = "_codigoPuesto", Name = "CodigoPuesto", DbType = "varchar(20)", AutoSync = AutoSync.Never)]
		public string CodigoPuesto
		{
			get
			{
				return _codigoPuesto;
			}
			set
			{
				if (value != _codigoPuesto)
				{
					OnCodigoPuestoChanging(value);
					SendPropertyChanging();
					_codigoPuesto = value;
					SendPropertyChanged("CodigoPuesto");
					OnCodigoPuestoChanged();
				}
			}
		}

		#endregion

		#region sbyte HsLlamadaAntesHoraInicio

		private sbyte _hsLlamadaAntesHoraInicio;
		[DebuggerNonUserCode]
		[Column(Storage = "_hsLlamadaAntesHoraInicio", Name = "HsLlamadaAntesHoraInicio", DbType = "tinyint(2)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public sbyte HsLlamadaAntesHoraInicio
		{
			get
			{
				return _hsLlamadaAntesHoraInicio;
			}
			set
			{
				if (value != _hsLlamadaAntesHoraInicio)
				{
					OnHsLlamadaAntesHoraInicioChanging(value);
					SendPropertyChanging();
					_hsLlamadaAntesHoraInicio = value;
					SendPropertyChanged("HsLlamadaAntesHoraInicio");
					OnHsLlamadaAntesHoraInicioChanged();
				}
			}
		}

		#endregion

		#region uint IDEscalafon

		private uint _ideScalafon;
		[DebuggerNonUserCode]
		[Column(Storage = "_ideScalafon", Name = "IdEscalafon", DbType = "int unsigned", IsPrimaryKey = true, AutoSync = AutoSync.Never, CanBeNull = false)]
		public uint IDEscalafon
		{
			get
			{
				return _ideScalafon;
			}
			set
			{
				if (value != _ideScalafon)
				{
					OnIDEscalafonChanging(value);
					SendPropertyChanging();
					_ideScalafon = value;
					SendPropertyChanged("IDEscalafon");
					OnIDEscalafonChanged();
				}
			}
		}

		#endregion

		#region uint IDEscalafonEmpleado

		private uint _ideScalafonEmpleado;
		[DebuggerNonUserCode]
		[Column(Storage = "_ideScalafonEmpleado", Name = "IdEscalafonEmpleado", DbType = "int unsigned", IsPrimaryKey = true, AutoSync = AutoSync.Never, CanBeNull = false)]
		public uint IDEscalafonEmpleado
		{
			get
			{
				return _ideScalafonEmpleado;
			}
			set
			{
				if (value != _ideScalafonEmpleado)
				{
					OnIDEscalafonEmpleadoChanging(value);
					SendPropertyChanging();
					_ideScalafonEmpleado = value;
					SendPropertyChanged("IDEscalafonEmpleado");
					OnIDEscalafonEmpleadoChanged();
				}
			}
		}

		#endregion

		#region uint NroEmpleado

		private uint _nroEmpleado;
		[DebuggerNonUserCode]
		[Column(Storage = "_nroEmpleado", Name = "NroEmpleado", DbType = "mediumint unsigned", AutoSync = AutoSync.Never, CanBeNull = false)]
		public uint NroEmpleado
		{
			get
			{
				return _nroEmpleado;
			}
			set
			{
				if (value != _nroEmpleado)
				{
					if (_emPleadOs.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					OnNroEmpleadoChanging(value);
					SendPropertyChanging();
					_nroEmpleado = value;
					SendPropertyChanged("NroEmpleado");
					OnNroEmpleadoChanged();
				}
			}
		}

		#endregion

		#region Children

		private EntitySet<HoRaRioEScalaFOn> _hoRaRioEsCalaFoN;
		[Association(Storage = "_hoRaRioEsCalaFoN", OtherKey = "IDEscalafon,IDEscalafonEmpleado", ThisKey = "IDEscalafon,IDEscalafonEmpleado", Name = "FK_horasEscalEmpleados")]
		[DebuggerNonUserCode]
		public EntitySet<HoRaRioEScalaFOn> HoRaRioEScalaFOn
		{
			get
			{
				return _hoRaRioEsCalaFoN;
			}
			set
			{
				_hoRaRioEsCalaFoN = value;
			}
		}


		#endregion

		#region Parents

		private EntityRef<EmPleadOs> _emPleadOs;
		[Association(Storage = "_emPleadOs", OtherKey = "NroEmpleado", ThisKey = "NroEmpleado", Name = "escalafonempleado_ibfk_1", IsForeignKey = true)]
		[DebuggerNonUserCode]
		public EmPleadOs EmPleadOs
		{
			get
			{
				return _emPleadOs.Entity;
			}
			set
			{
				if (value != _emPleadOs.Entity)
				{
					if (_emPleadOs.Entity != null)
					{
						var previousEmPleadOs = _emPleadOs.Entity;
						_emPleadOs.Entity = null;
						previousEmPleadOs.EScalaFOneMpLeadO.Remove(this);
					}
					_emPleadOs.Entity = value;
					if (value != null)
					{
						value.EScalaFOneMpLeadO.Add(this);
						_nroEmpleado = value.NroEmpleado;
					}
					else
					{
						_nroEmpleado = default(uint);
					}
				}
			}
		}

		private EntityRef<EScalaFOn> _esCalaFoN;
		[Association(Storage = "_esCalaFoN", OtherKey = "IDEscalafon", ThisKey = "IDEscalafon", Name = "FK_LineasEscalafon", IsForeignKey = true)]
		[DebuggerNonUserCode]
		public EScalaFOn EScalaFOn
		{
			get
			{
				return _esCalaFoN.Entity;
			}
			set
			{
				if (value != _esCalaFoN.Entity)
				{
					if (_esCalaFoN.Entity != null)
					{
						var previousEScalaFOn = _esCalaFoN.Entity;
						_esCalaFoN.Entity = null;
						previousEScalaFOn.EScalaFOneMpLeadO.Remove(this);
					}
					_esCalaFoN.Entity = value;
					if (value != null)
					{
						value.EScalaFOneMpLeadO.Add(this);
						_ideScalafon = value.IDEscalafon;
					}
					else
					{
						_ideScalafon = default(uint);
					}
				}
			}
		}


		#endregion

		#region Attachement handlers

		private void HoRaRioEScalaFOn_Attach(HoRaRioEScalaFOn entity)
		{
			entity.EScalaFOneMpLeadO = this;
		}

		private void HoRaRioEScalaFOn_Detach(HoRaRioEScalaFOn entity)
		{
			entity.EScalaFOneMpLeadO = null;
		}


		#endregion

		#region ctor

		public EScalaFOneMpLeadO()
		{
			_hoRaRioEsCalaFoN = new EntitySet<HoRaRioEScalaFOn>(HoRaRioEScalaFOn_Attach, HoRaRioEScalaFOn_Detach);
			_emPleadOs = new EntityRef<EmPleadOs>();
			_esCalaFoN = new EntityRef<EScalaFOn>();
			OnCreated();
		}

		#endregion

	}

	[Table(Name = "trustdb.eventoshistorialempleado")]
	public partial class EventOsHistOrIalEmPleadO : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region INotifyPropertyChanging handling

		public event PropertyChangingEventHandler PropertyChanging;

		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs("");
		protected virtual void SendPropertyChanging()
		{
			if (PropertyChanging != null)
			{
				PropertyChanging(this, emptyChangingEventArgs);
			}
		}

		#endregion

		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void SendPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region Extensibility Method Definitions

		partial void OnCreated();
		partial void OnBoRrAdoChanged();
		partial void OnBoRrAdoChanging(sbyte value);
		partial void OnDescripcionChanged();
		partial void OnDescripcionChanging(string value);
		partial void OnFechaFinChanged();
		partial void OnFechaFinChanging(DateTime value);
		partial void OnFechaInicioChanged();
		partial void OnFechaInicioChanging(DateTime value);
		partial void OnIDEmpleadoChanged();
		partial void OnIDEmpleadoChanging(uint value);
		partial void OnIDEventoHistorialEmpleadoChanged();
		partial void OnIDEventoHistorialEmpleadoChanging(uint value);
		partial void OnIDTipoEventoChanged();
		partial void OnIDTipoEventoChanging(int value);

		#endregion

		#region sbyte BoRrAdo

		private sbyte _boRrAdo;
		[DebuggerNonUserCode]
		[Column(Storage = "_boRrAdo", Name = "borrado", DbType = "tinyint(1)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public sbyte BoRrAdo
		{
			get
			{
				return _boRrAdo;
			}
			set
			{
				if (value != _boRrAdo)
				{
					OnBoRrAdoChanging(value);
					SendPropertyChanging();
					_boRrAdo = value;
					SendPropertyChanged("BoRrAdo");
					OnBoRrAdoChanged();
				}
			}
		}

		#endregion

		#region string Descripcion

		private string _descripcion;
		[DebuggerNonUserCode]
		[Column(Storage = "_descripcion", Name = "Descripcion", DbType = "varchar(255)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public string Descripcion
		{
			get
			{
				return _descripcion;
			}
			set
			{
				if (value != _descripcion)
				{
					OnDescripcionChanging(value);
					SendPropertyChanging();
					_descripcion = value;
					SendPropertyChanged("Descripcion");
					OnDescripcionChanged();
				}
			}
		}

		#endregion

		#region DateTime FechaFin

		private DateTime _fechaFin;
		[DebuggerNonUserCode]
		[Column(Storage = "_fechaFin", Name = "FechaFin", DbType = "date", AutoSync = AutoSync.Never, CanBeNull = false)]
		public DateTime FechaFin
		{
			get
			{
				return _fechaFin;
			}
			set
			{
				if (value != _fechaFin)
				{
					OnFechaFinChanging(value);
					SendPropertyChanging();
					_fechaFin = value;
					SendPropertyChanged("FechaFin");
					OnFechaFinChanged();
				}
			}
		}

		#endregion

		#region DateTime FechaInicio

		private DateTime _fechaInicio;
		[DebuggerNonUserCode]
		[Column(Storage = "_fechaInicio", Name = "FechaInicio", DbType = "date", AutoSync = AutoSync.Never, CanBeNull = false)]
		public DateTime FechaInicio
		{
			get
			{
				return _fechaInicio;
			}
			set
			{
				if (value != _fechaInicio)
				{
					OnFechaInicioChanging(value);
					SendPropertyChanging();
					_fechaInicio = value;
					SendPropertyChanged("FechaInicio");
					OnFechaInicioChanged();
				}
			}
		}

		#endregion

		#region uint IDEmpleado

		private uint _ideMpleado;
		[DebuggerNonUserCode]
		[Column(Storage = "_ideMpleado", Name = "IdEmpleado", DbType = "mediumint unsigned", AutoSync = AutoSync.Never, CanBeNull = false)]
		public uint IDEmpleado
		{
			get
			{
				return _ideMpleado;
			}
			set
			{
				if (value != _ideMpleado)
				{
					OnIDEmpleadoChanging(value);
					SendPropertyChanging();
					_ideMpleado = value;
					SendPropertyChanged("IDEmpleado");
					OnIDEmpleadoChanged();
				}
			}
		}

		#endregion

		#region uint IDEventoHistorialEmpleado

		private uint _ideVentoHistorialEmpleado;
		[DebuggerNonUserCode]
		[Column(Storage = "_ideVentoHistorialEmpleado", Name = "IdEventoHistorialEmpleado", DbType = "int unsigned", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false)]
		public uint IDEventoHistorialEmpleado
		{
			get
			{
				return _ideVentoHistorialEmpleado;
			}
			set
			{
				if (value != _ideVentoHistorialEmpleado)
				{
					OnIDEventoHistorialEmpleadoChanging(value);
					SendPropertyChanging();
					_ideVentoHistorialEmpleado = value;
					SendPropertyChanged("IDEventoHistorialEmpleado");
					OnIDEventoHistorialEmpleadoChanged();
				}
			}
		}

		#endregion

		#region int IDTipoEvento

		private int _idtIpoEvento;
		[DebuggerNonUserCode]
		[Column(Storage = "_idtIpoEvento", Name = "IdTipoEvento", DbType = "int", AutoSync = AutoSync.Never, CanBeNull = false)]
		public int IDTipoEvento
		{
			get
			{
				return _idtIpoEvento;
			}
			set
			{
				if (value != _idtIpoEvento)
				{
					OnIDTipoEventoChanging(value);
					SendPropertyChanging();
					_idtIpoEvento = value;
					SendPropertyChanged("IDTipoEvento");
					OnIDTipoEventoChanged();
				}
			}
		}

		#endregion

		#region Parents

		private EntityRef<EmPleadOs> _emPleadOs;
		[Association(Storage = "_emPleadOs", OtherKey = "NroEmpleado", ThisKey = "IDEmpleado", Name = "eventoshistorialempleado_ibfk_1", IsForeignKey = true)]
		[DebuggerNonUserCode]
		public EmPleadOs EmPleadOs
		{
			get
			{
				return _emPleadOs.Entity;
			}
			set
			{
				if (value != _emPleadOs.Entity)
				{
					if (_emPleadOs.Entity != null)
					{
						var previousEmPleadOs = _emPleadOs.Entity;
						_emPleadOs.Entity = null;
						previousEmPleadOs.EventOsHistOrIalEmPleadO.Remove(this);
					}
					_emPleadOs.Entity = value;
					if (value != null)
					{
						value.EventOsHistOrIalEmPleadO.Add(this);
						_ideMpleado = value.NroEmpleado;
					}
					else
					{
						_ideMpleado = default(uint);
					}
				}
			}
		}


		#endregion

		#region ctor

		public EventOsHistOrIalEmPleadO()
		{
			_emPleadOs = new EntityRef<EmPleadOs>();
			OnCreated();
		}

		#endregion

	}

	[Table(Name = "trustdb.extrasliquidacion")]
	public partial class ExtrasLiquidAcIon : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region INotifyPropertyChanging handling

		public event PropertyChangingEventHandler PropertyChanging;

		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs("");
		protected virtual void SendPropertyChanging()
		{
			if (PropertyChanging != null)
			{
				PropertyChanging(this, emptyChangingEventArgs);
			}
		}

		#endregion

		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void SendPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region Extensibility Method Definitions

		partial void OnCreated();
		partial void OnCantHsTipoExtraLlevaHsEnSegsChanged();
		partial void OnCantHsTipoExtraLlevaHsEnSegsChanging(int value);
		partial void OnCantidadCuotasChanged();
		partial void OnCantidadCuotasChanging(byte value);
		partial void OnCuotaActualChanged();
		partial void OnCuotaActualChanging(sbyte value);
		partial void OnDescripcionChanged();
		partial void OnDescripcionChanging(string value);
		partial void OnIDEmpleadoChanged();
		partial void OnIDEmpleadoChanging(uint value);
		partial void OnIDExtraLiquidacionChanged();
		partial void OnIDExtraLiquidacionChanging(uint value);
		partial void OnIDTipoExtraLiquidacionChanged();
		partial void OnIDTipoExtraLiquidacionChanging(byte value);
		partial void OnIDUsuarioChanged();
		partial void OnIDUsuarioChanging(int value);
		partial void OnPorcentajeChanged();
		partial void OnPorcentajeChanging(decimal value);
		partial void OnSignoChanged();
		partial void OnSignoChanging(int value);

		#endregion

		#region int CantHsTipoExtraLlevaHsEnSegs

		private int _cantHsTipoExtraLlevaHsEnSegs;
		[DebuggerNonUserCode]
		[Column(Storage = "_cantHsTipoExtraLlevaHsEnSegs", Name = "CantHs_TipoExtraLlevaHsEnSegs", DbType = "int", AutoSync = AutoSync.Never, CanBeNull = false)]
		public int CantHsTipoExtraLlevaHsEnSegs
		{
			get
			{
				return _cantHsTipoExtraLlevaHsEnSegs;
			}
			set
			{
				if (value != _cantHsTipoExtraLlevaHsEnSegs)
				{
					OnCantHsTipoExtraLlevaHsEnSegsChanging(value);
					SendPropertyChanging();
					_cantHsTipoExtraLlevaHsEnSegs = value;
					SendPropertyChanged("CantHsTipoExtraLlevaHsEnSegs");
					OnCantHsTipoExtraLlevaHsEnSegsChanged();
				}
			}
		}

		#endregion

		#region byte CantidadCuotas

		private byte _cantidadCuotas;
		[DebuggerNonUserCode]
		[Column(Storage = "_cantidadCuotas", Name = "CantidadCuotas", DbType = "tinyint(3) unsigned", AutoSync = AutoSync.Never, CanBeNull = false)]
		public byte CantidadCuotas
		{
			get
			{
				return _cantidadCuotas;
			}
			set
			{
				if (value != _cantidadCuotas)
				{
					OnCantidadCuotasChanging(value);
					SendPropertyChanging();
					_cantidadCuotas = value;
					SendPropertyChanged("CantidadCuotas");
					OnCantidadCuotasChanged();
				}
			}
		}

		#endregion

		#region sbyte CuotaActual

		private sbyte _cuotaActual;
		[DebuggerNonUserCode]
		[Column(Storage = "_cuotaActual", Name = "CuotaActual", DbType = "tinyint(2)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public sbyte CuotaActual
		{
			get
			{
				return _cuotaActual;
			}
			set
			{
				if (value != _cuotaActual)
				{
					OnCuotaActualChanging(value);
					SendPropertyChanging();
					_cuotaActual = value;
					SendPropertyChanged("CuotaActual");
					OnCuotaActualChanged();
				}
			}
		}

		#endregion

		#region string Descripcion

		private string _descripcion;
		[DebuggerNonUserCode]
		[Column(Storage = "_descripcion", Name = "Descripcion", DbType = "varchar(255)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public string Descripcion
		{
			get
			{
				return _descripcion;
			}
			set
			{
				if (value != _descripcion)
				{
					OnDescripcionChanging(value);
					SendPropertyChanging();
					_descripcion = value;
					SendPropertyChanged("Descripcion");
					OnDescripcionChanged();
				}
			}
		}

		#endregion

		#region uint IDEmpleado

		private uint _ideMpleado;
		[DebuggerNonUserCode]
		[Column(Storage = "_ideMpleado", Name = "IdEmpleado", DbType = "mediumint unsigned", AutoSync = AutoSync.Never, CanBeNull = false)]
		public uint IDEmpleado
		{
			get
			{
				return _ideMpleado;
			}
			set
			{
				if (value != _ideMpleado)
				{
					OnIDEmpleadoChanging(value);
					SendPropertyChanging();
					_ideMpleado = value;
					SendPropertyChanged("IDEmpleado");
					OnIDEmpleadoChanged();
				}
			}
		}

		#endregion

		#region uint IDExtraLiquidacion

		private uint _ideXtraLiquidacion;
		[DebuggerNonUserCode]
		[Column(Storage = "_ideXtraLiquidacion", Name = "IdExtraLiquidacion", DbType = "int unsigned", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false)]
		public uint IDExtraLiquidacion
		{
			get
			{
				return _ideXtraLiquidacion;
			}
			set
			{
				if (value != _ideXtraLiquidacion)
				{
					OnIDExtraLiquidacionChanging(value);
					SendPropertyChanging();
					_ideXtraLiquidacion = value;
					SendPropertyChanged("IDExtraLiquidacion");
					OnIDExtraLiquidacionChanged();
				}
			}
		}

		#endregion

		#region byte IDTipoExtraLiquidacion

		private byte _idtIpoExtraLiquidacion;
		[DebuggerNonUserCode]
		[Column(Storage = "_idtIpoExtraLiquidacion", Name = "IdTipoExtraLiquidacion", DbType = "tinyint(2) unsigned", AutoSync = AutoSync.Never, CanBeNull = false)]
		public byte IDTipoExtraLiquidacion
		{
			get
			{
				return _idtIpoExtraLiquidacion;
			}
			set
			{
				if (value != _idtIpoExtraLiquidacion)
				{
					OnIDTipoExtraLiquidacionChanging(value);
					SendPropertyChanging();
					_idtIpoExtraLiquidacion = value;
					SendPropertyChanged("IDTipoExtraLiquidacion");
					OnIDTipoExtraLiquidacionChanged();
				}
			}
		}

		#endregion

		#region int IDUsuario

		private int _iduSuario;
		[DebuggerNonUserCode]
		[Column(Storage = "_iduSuario", Name = "IdUsuario", DbType = "int", AutoSync = AutoSync.Never, CanBeNull = false)]
		public int IDUsuario
		{
			get
			{
				return _iduSuario;
			}
			set
			{
				if (value != _iduSuario)
				{
					OnIDUsuarioChanging(value);
					SendPropertyChanging();
					_iduSuario = value;
					SendPropertyChanged("IDUsuario");
					OnIDUsuarioChanged();
				}
			}
		}

		#endregion

		#region decimal Porcentaje

		private decimal _porcentaje;
		[DebuggerNonUserCode]
		[Column(Storage = "_porcentaje", Name = "Porcentaje", DbType = "decimal(4,2)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public decimal Porcentaje
		{
			get
			{
				return _porcentaje;
			}
			set
			{
				if (value != _porcentaje)
				{
					OnPorcentajeChanging(value);
					SendPropertyChanging();
					_porcentaje = value;
					SendPropertyChanged("Porcentaje");
					OnPorcentajeChanged();
				}
			}
		}

		#endregion

		#region int Signo

		private int _signo;
		[DebuggerNonUserCode]
		[Column(Storage = "_signo", Name = "Signo", DbType = "mediumint(9)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public int Signo
		{
			get
			{
				return _signo;
			}
			set
			{
				if (value != _signo)
				{
					OnSignoChanging(value);
					SendPropertyChanging();
					_signo = value;
					SendPropertyChanged("Signo");
					OnSignoChanged();
				}
			}
		}

		#endregion

		#region Children

		private EntitySet<CuOtAsExtrasLiquidAcIon> _cuOtAsExtrasLiquidAcIon;
		[Association(Storage = "_cuOtAsExtrasLiquidAcIon", OtherKey = "IDExtraLiquidacion", ThisKey = "IDExtraLiquidacion", Name = "cuotasextrasliquidacion_ibfk_1")]
		[DebuggerNonUserCode]
		public EntitySet<CuOtAsExtrasLiquidAcIon> CuOtAsExtrasLiquidAcIon
		{
			get
			{
				return _cuOtAsExtrasLiquidAcIon;
			}
			set
			{
				_cuOtAsExtrasLiquidAcIon = value;
			}
		}


		#endregion

		#region Parents

		private EntityRef<EmPleadOs> _emPleadOs;
		[Association(Storage = "_emPleadOs", OtherKey = "NroEmpleado", ThisKey = "IDEmpleado", Name = "extrasliquidacion_ibfk_1", IsForeignKey = true)]
		[DebuggerNonUserCode]
		public EmPleadOs EmPleadOs
		{
			get
			{
				return _emPleadOs.Entity;
			}
			set
			{
				if (value != _emPleadOs.Entity)
				{
					if (_emPleadOs.Entity != null)
					{
						var previousEmPleadOs = _emPleadOs.Entity;
						_emPleadOs.Entity = null;
						previousEmPleadOs.ExtrasLiquidAcIon.Remove(this);
					}
					_emPleadOs.Entity = value;
					if (value != null)
					{
						value.ExtrasLiquidAcIon.Add(this);
						_ideMpleado = value.NroEmpleado;
					}
					else
					{
						_ideMpleado = default(uint);
					}
				}
			}
		}

		private EntityRef<UsUarIoS> _usUarIoS;
		[Association(Storage = "_usUarIoS", OtherKey = "IDUsuario", ThisKey = "IDUsuario", Name = "extrasliquidacion_ibfk_2", IsForeignKey = true)]
		[DebuggerNonUserCode]
		public UsUarIoS UsUarIoS
		{
			get
			{
				return _usUarIoS.Entity;
			}
			set
			{
				if (value != _usUarIoS.Entity)
				{
					if (_usUarIoS.Entity != null)
					{
						var previousUsUarIoS = _usUarIoS.Entity;
						_usUarIoS.Entity = null;
						previousUsUarIoS.ExtrasLiquidAcIon.Remove(this);
					}
					_usUarIoS.Entity = value;
					if (value != null)
					{
						value.ExtrasLiquidAcIon.Add(this);
						_iduSuario = value.IDUsuario;
					}
					else
					{
						_iduSuario = default(int);
					}
				}
			}
		}

		private EntityRef<TipOExtraLiquidAcIon> _tipOeXtraLiquidAcIon;
		[Association(Storage = "_tipOeXtraLiquidAcIon", OtherKey = "IDTipoExtraLiquidacion", ThisKey = "IDTipoExtraLiquidacion", Name = "extrasliquidacion_ibfk_3", IsForeignKey = true)]
		[DebuggerNonUserCode]
		public TipOExtraLiquidAcIon TipOExtraLiquidAcIon
		{
			get
			{
				return _tipOeXtraLiquidAcIon.Entity;
			}
			set
			{
				if (value != _tipOeXtraLiquidAcIon.Entity)
				{
					if (_tipOeXtraLiquidAcIon.Entity != null)
					{
						var previousTipOExtraLiquidAcIon = _tipOeXtraLiquidAcIon.Entity;
						_tipOeXtraLiquidAcIon.Entity = null;
						previousTipOExtraLiquidAcIon.ExtrasLiquidAcIon.Remove(this);
					}
					_tipOeXtraLiquidAcIon.Entity = value;
					if (value != null)
					{
						value.ExtrasLiquidAcIon.Add(this);
						_idtIpoExtraLiquidacion = value.IDTipoExtraLiquidacion;
					}
					else
					{
						_idtIpoExtraLiquidacion = default(byte);
					}
				}
			}
		}


		#endregion

		#region Attachement handlers

		private void CuOtAsExtrasLiquidAcIon_Attach(CuOtAsExtrasLiquidAcIon entity)
		{
			entity.ExtrasLiquidAcIon = this;
		}

		private void CuOtAsExtrasLiquidAcIon_Detach(CuOtAsExtrasLiquidAcIon entity)
		{
			entity.ExtrasLiquidAcIon = null;
		}


		#endregion

		#region ctor

		public ExtrasLiquidAcIon()
		{
			_cuOtAsExtrasLiquidAcIon = new EntitySet<CuOtAsExtrasLiquidAcIon>(CuOtAsExtrasLiquidAcIon_Attach, CuOtAsExtrasLiquidAcIon_Detach);
			_emPleadOs = new EntityRef<EmPleadOs>();
			_usUarIoS = new EntityRef<UsUarIoS>();
			_tipOeXtraLiquidAcIon = new EntityRef<TipOExtraLiquidAcIon>();
			OnCreated();
		}

		#endregion

	}

	[Table(Name = "trustdb.extrasliquidacionempleado")]
	public partial class ExtrasLiquidAcIonEmPleadO : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region INotifyPropertyChanging handling

		public event PropertyChangingEventHandler PropertyChanging;

		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs("");
		protected virtual void SendPropertyChanging()
		{
			if (PropertyChanging != null)
			{
				PropertyChanging(this, emptyChangingEventArgs);
			}
		}

		#endregion

		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void SendPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region Extensibility Method Definitions

		partial void OnCreated();
		partial void OnCantidadCuotasChanged();
		partial void OnCantidadCuotasChanging(sbyte value);
		partial void OnCuotaActualChanged();
		partial void OnCuotaActualChanging(sbyte value);
		partial void OnDescripcionChanged();
		partial void OnDescripcionChanging(string value);
		partial void OnFechaChanged();
		partial void OnFechaChanging(DateTime value);
		partial void OnIDEmpleadoChanged();
		partial void OnIDEmpleadoChanging(uint value);
		partial void OnIDExtrasLiquidacionEmpleadoChanged();
		partial void OnIDExtrasLiquidacionEmpleadoChanging(uint value);
		partial void OnLiquidadoChanged();
		partial void OnLiquidadoChanging(sbyte value);
		partial void OnSignoChanged();
		partial void OnSignoChanging(int value);
		partial void OnValorChanged();
		partial void OnValorChanging(float value);

		#endregion

		#region sbyte CantidadCuotas

		private sbyte _cantidadCuotas;
		[DebuggerNonUserCode]
		[Column(Storage = "_cantidadCuotas", Name = "CantidadCuotas", DbType = "tinyint(2)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public sbyte CantidadCuotas
		{
			get
			{
				return _cantidadCuotas;
			}
			set
			{
				if (value != _cantidadCuotas)
				{
					OnCantidadCuotasChanging(value);
					SendPropertyChanging();
					_cantidadCuotas = value;
					SendPropertyChanged("CantidadCuotas");
					OnCantidadCuotasChanged();
				}
			}
		}

		#endregion

		#region sbyte CuotaActual

		private sbyte _cuotaActual;
		[DebuggerNonUserCode]
		[Column(Storage = "_cuotaActual", Name = "CuotaActual", DbType = "tinyint(2)", IsPrimaryKey = true, AutoSync = AutoSync.Never, CanBeNull = false)]
		public sbyte CuotaActual
		{
			get
			{
				return _cuotaActual;
			}
			set
			{
				if (value != _cuotaActual)
				{
					OnCuotaActualChanging(value);
					SendPropertyChanging();
					_cuotaActual = value;
					SendPropertyChanged("CuotaActual");
					OnCuotaActualChanged();
				}
			}
		}

		#endregion

		#region string Descripcion

		private string _descripcion;
		[DebuggerNonUserCode]
		[Column(Storage = "_descripcion", Name = "Descripcion", DbType = "varchar(255)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public string Descripcion
		{
			get
			{
				return _descripcion;
			}
			set
			{
				if (value != _descripcion)
				{
					OnDescripcionChanging(value);
					SendPropertyChanging();
					_descripcion = value;
					SendPropertyChanged("Descripcion");
					OnDescripcionChanged();
				}
			}
		}

		#endregion

		#region DateTime Fecha

		private DateTime _fecha;
		[DebuggerNonUserCode]
		[Column(Storage = "_fecha", Name = "Fecha", DbType = "date", AutoSync = AutoSync.Never, CanBeNull = false)]
		public DateTime Fecha
		{
			get
			{
				return _fecha;
			}
			set
			{
				if (value != _fecha)
				{
					OnFechaChanging(value);
					SendPropertyChanging();
					_fecha = value;
					SendPropertyChanged("Fecha");
					OnFechaChanged();
				}
			}
		}

		#endregion

		#region uint IDEmpleado

		private uint _ideMpleado;
		[DebuggerNonUserCode]
		[Column(Storage = "_ideMpleado", Name = "IdEmpleado", DbType = "mediumint unsigned", IsPrimaryKey = true, AutoSync = AutoSync.Never, CanBeNull = false)]
		public uint IDEmpleado
		{
			get
			{
				return _ideMpleado;
			}
			set
			{
				if (value != _ideMpleado)
				{
					OnIDEmpleadoChanging(value);
					SendPropertyChanging();
					_ideMpleado = value;
					SendPropertyChanged("IDEmpleado");
					OnIDEmpleadoChanged();
				}
			}
		}

		#endregion

		#region uint IDExtrasLiquidacionEmpleado

		private uint _ideXtrasLiquidacionEmpleado;
		[DebuggerNonUserCode]
		[Column(Storage = "_ideXtrasLiquidacionEmpleado", Name = "idExtrasLiquidacionEmpleado", DbType = "int unsigned", IsPrimaryKey = true, AutoSync = AutoSync.Never, CanBeNull = false)]
		public uint IDExtrasLiquidacionEmpleado
		{
			get
			{
				return _ideXtrasLiquidacionEmpleado;
			}
			set
			{
				if (value != _ideXtrasLiquidacionEmpleado)
				{
					OnIDExtrasLiquidacionEmpleadoChanging(value);
					SendPropertyChanging();
					_ideXtrasLiquidacionEmpleado = value;
					SendPropertyChanged("IDExtrasLiquidacionEmpleado");
					OnIDExtrasLiquidacionEmpleadoChanged();
				}
			}
		}

		#endregion

		#region sbyte Liquidado

		private sbyte _liquidado;
		[DebuggerNonUserCode]
		[Column(Storage = "_liquidado", Name = "Liquidado", DbType = "tinyint(1)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public sbyte Liquidado
		{
			get
			{
				return _liquidado;
			}
			set
			{
				if (value != _liquidado)
				{
					OnLiquidadoChanging(value);
					SendPropertyChanging();
					_liquidado = value;
					SendPropertyChanged("Liquidado");
					OnLiquidadoChanged();
				}
			}
		}

		#endregion

		#region int Signo

		private int _signo;
		[DebuggerNonUserCode]
		[Column(Storage = "_signo", Name = "Signo", DbType = "mediumint(9)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public int Signo
		{
			get
			{
				return _signo;
			}
			set
			{
				if (value != _signo)
				{
					OnSignoChanging(value);
					SendPropertyChanging();
					_signo = value;
					SendPropertyChanged("Signo");
					OnSignoChanged();
				}
			}
		}

		#endregion

		#region float Valor

		private float _valor;
		[DebuggerNonUserCode]
		[Column(Storage = "_valor", Name = "Valor", DbType = "float", AutoSync = AutoSync.Never, CanBeNull = false)]
		public float Valor
		{
			get
			{
				return _valor;
			}
			set
			{
				if (value != _valor)
				{
					OnValorChanging(value);
					SendPropertyChanging();
					_valor = value;
					SendPropertyChanged("Valor");
					OnValorChanged();
				}
			}
		}

		#endregion

		#region ctor

		public ExtrasLiquidAcIonEmPleadO()
		{
			OnCreated();
		}

		#endregion

	}

	[Table(Name = "trustdb.fechaescalafoncerrado")]
	public partial class FeCHaEScalaFOncerRadO : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region INotifyPropertyChanging handling

		public event PropertyChangingEventHandler PropertyChanging;

		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs("");
		protected virtual void SendPropertyChanging()
		{
			if (PropertyChanging != null)
			{
				PropertyChanging(this, emptyChangingEventArgs);
			}
		}

		#endregion

		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void SendPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region Extensibility Method Definitions

		partial void OnCreated();
		partial void OnControlDiarioCerradoChanged();
		partial void OnControlDiarioCerradoChanging(short value);
		partial void OnFeCHaCeRrAdaChanged();
		partial void OnFeCHaCeRrAdaChanging(DateTime? value);
		partial void OnIDFeCHaEScalaFOncerRadOChanged();
		partial void OnIDFeCHaEScalaFOncerRadOChanging(int value);

		#endregion

		#region short ControlDiarioCerrado

		private short _controlDiarioCerrado;
		[DebuggerNonUserCode]
		[Column(Storage = "_controlDiarioCerrado", Name = "ControlDiarioCerrado", DbType = "smallint(6)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public short ControlDiarioCerrado
		{
			get
			{
				return _controlDiarioCerrado;
			}
			set
			{
				if (value != _controlDiarioCerrado)
				{
					OnControlDiarioCerradoChanging(value);
					SendPropertyChanging();
					_controlDiarioCerrado = value;
					SendPropertyChanged("ControlDiarioCerrado");
					OnControlDiarioCerradoChanged();
				}
			}
		}

		#endregion

		#region DateTime? FeCHaCeRrAda

		private DateTime? _feChACeRrAda;
		[DebuggerNonUserCode]
		[Column(Storage = "_feChACeRrAda", Name = "fechacerrada", DbType = "date", AutoSync = AutoSync.Never)]
		public DateTime? FeCHaCeRrAda
		{
			get
			{
				return _feChACeRrAda;
			}
			set
			{
				if (value != _feChACeRrAda)
				{
					OnFeCHaCeRrAdaChanging(value);
					SendPropertyChanging();
					_feChACeRrAda = value;
					SendPropertyChanged("FeCHaCeRrAda");
					OnFeCHaCeRrAdaChanged();
				}
			}
		}

		#endregion

		#region int IDFeCHaEScalaFOncerRadO

		private int _idfEChAEsCalaFoNcerRadO;
		[DebuggerNonUserCode]
		[Column(Storage = "_idfEChAEsCalaFoNcerRadO", Name = "idfechaescalafoncerrado", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false)]
		public int IDFeCHaEScalaFOncerRadO
		{
			get
			{
				return _idfEChAEsCalaFoNcerRadO;
			}
			set
			{
				if (value != _idfEChAEsCalaFoNcerRadO)
				{
					OnIDFeCHaEScalaFOncerRadOChanging(value);
					SendPropertyChanging();
					_idfEChAEsCalaFoNcerRadO = value;
					SendPropertyChanged("IDFeCHaEScalaFOncerRadO");
					OnIDFeCHaEScalaFOncerRadOChanged();
				}
			}
		}

		#endregion

		#region ctor

		public FeCHaEScalaFOncerRadO()
		{
			OnCreated();
		}

		#endregion

	}

	[Table(Name = "trustdb.feriados")]
	public partial class FeRiAdoS : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region INotifyPropertyChanging handling

		public event PropertyChangingEventHandler PropertyChanging;

		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs("");
		protected virtual void SendPropertyChanging()
		{
			if (PropertyChanging != null)
			{
				PropertyChanging(this, emptyChangingEventArgs);
			}
		}

		#endregion

		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void SendPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region Extensibility Method Definitions

		partial void OnCreated();
		partial void OnDesCrIpcIonChanged();
		partial void OnDesCrIpcIonChanging(string value);
		partial void OnFeCHaChanged();
		partial void OnFeCHaChanging(DateTime value);

		#endregion

		#region string DesCrIpcIon

		private string _desCrIpcIon;
		[DebuggerNonUserCode]
		[Column(Storage = "_desCrIpcIon", Name = "descripcion", DbType = "varchar(45)", AutoSync = AutoSync.Never)]
		public string DesCrIpcIon
		{
			get
			{
				return _desCrIpcIon;
			}
			set
			{
				if (value != _desCrIpcIon)
				{
					OnDesCrIpcIonChanging(value);
					SendPropertyChanging();
					_desCrIpcIon = value;
					SendPropertyChanged("DesCrIpcIon");
					OnDesCrIpcIonChanged();
				}
			}
		}

		#endregion

		#region DateTime FeCHa

		private DateTime _feChA;
		[DebuggerNonUserCode]
		[Column(Storage = "_feChA", Name = "fecha", DbType = "date", IsPrimaryKey = true, AutoSync = AutoSync.Never, CanBeNull = false)]
		public DateTime FeCHa
		{
			get
			{
				return _feChA;
			}
			set
			{
				if (value != _feChA)
				{
					OnFeCHaChanging(value);
					SendPropertyChanging();
					_feChA = value;
					SendPropertyChanged("FeCHa");
					OnFeCHaChanged();
				}
			}
		}

		#endregion

		#region ctor

		public FeRiAdoS()
		{
			OnCreated();
		}

		#endregion

	}

	[Table(Name = "trustdb.grupos")]
	public partial class GRuPOs : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region INotifyPropertyChanging handling

		public event PropertyChangingEventHandler PropertyChanging;

		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs("");
		protected virtual void SendPropertyChanging()
		{
			if (PropertyChanging != null)
			{
				PropertyChanging(this, emptyChangingEventArgs);
			}
		}

		#endregion

		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void SendPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region Extensibility Method Definitions

		partial void OnCreated();
		partial void OnActivoChanged();
		partial void OnActivoChanging(sbyte value);
		partial void OnDescripcionChanged();
		partial void OnDescripcionChanging(string value);
		partial void OnIDGrupoChanged();
		partial void OnIDGrupoChanging(int value);
		partial void OnNombreChanged();
		partial void OnNombreChanging(string value);

		#endregion

		#region sbyte Activo

		private sbyte _activo;
		[DebuggerNonUserCode]
		[Column(Storage = "_activo", Name = "Activo", DbType = "tinyint(1)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public sbyte Activo
		{
			get
			{
				return _activo;
			}
			set
			{
				if (value != _activo)
				{
					OnActivoChanging(value);
					SendPropertyChanging();
					_activo = value;
					SendPropertyChanged("Activo");
					OnActivoChanged();
				}
			}
		}

		#endregion

		#region string Descripcion

		private string _descripcion;
		[DebuggerNonUserCode]
		[Column(Storage = "_descripcion", Name = "Descripcion", DbType = "varchar(45)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public string Descripcion
		{
			get
			{
				return _descripcion;
			}
			set
			{
				if (value != _descripcion)
				{
					OnDescripcionChanging(value);
					SendPropertyChanging();
					_descripcion = value;
					SendPropertyChanged("Descripcion");
					OnDescripcionChanged();
				}
			}
		}

		#endregion

		#region int IDGrupo

		private int _idgRupo;
		[DebuggerNonUserCode]
		[Column(Storage = "_idgRupo", Name = "idGrupo", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false)]
		public int IDGrupo
		{
			get
			{
				return _idgRupo;
			}
			set
			{
				if (value != _idgRupo)
				{
					OnIDGrupoChanging(value);
					SendPropertyChanging();
					_idgRupo = value;
					SendPropertyChanged("IDGrupo");
					OnIDGrupoChanged();
				}
			}
		}

		#endregion

		#region string Nombre

		private string _nombre;
		[DebuggerNonUserCode]
		[Column(Storage = "_nombre", Name = "Nombre", DbType = "varchar(45)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public string Nombre
		{
			get
			{
				return _nombre;
			}
			set
			{
				if (value != _nombre)
				{
					OnNombreChanging(value);
					SendPropertyChanging();
					_nombre = value;
					SendPropertyChanged("Nombre");
					OnNombreChanged();
				}
			}
		}

		#endregion

		#region Children

		private EntitySet<UsUarIoSGRuPOs> _usUarIoSgrUPoS;
		[Association(Storage = "_usUarIoSgrUPoS", OtherKey = "IDGrupo", ThisKey = "IDGrupo", Name = "FK_Grupos")]
		[DebuggerNonUserCode]
		public EntitySet<UsUarIoSGRuPOs> UsUarIoSGRuPOs
		{
			get
			{
				return _usUarIoSgrUPoS;
			}
			set
			{
				_usUarIoSgrUPoS = value;
			}
		}


		#endregion

		#region Attachement handlers

		private void UsUarIoSGRuPOs_Attach(UsUarIoSGRuPOs entity)
		{
			entity.GRuPOs = this;
		}

		private void UsUarIoSGRuPOs_Detach(UsUarIoSGRuPOs entity)
		{
			entity.GRuPOs = null;
		}


		#endregion

		#region ctor

		public GRuPOs()
		{
			_usUarIoSgrUPoS = new EntitySet<UsUarIoSGRuPOs>(UsUarIoSGRuPOs_Attach, UsUarIoSGRuPOs_Detach);
			OnCreated();
		}

		#endregion

	}

	[Table(Name = "trustdb.horariodia")]
	public partial class HoRaRioDiA : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region INotifyPropertyChanging handling

		public event PropertyChangingEventHandler PropertyChanging;

		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs("");
		protected virtual void SendPropertyChanging()
		{
			if (PropertyChanging != null)
			{
				PropertyChanging(this, emptyChangingEventArgs);
			}
		}

		#endregion

		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void SendPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region Extensibility Method Definitions

		partial void OnCreated();
		partial void OnDiaChanged();
		partial void OnDiaChanging(string value);
		partial void OnHoraFinChanged();
		partial void OnHoraFinChanging(string value);
		partial void OnHoraIniChanged();
		partial void OnHoraIniChanging(string value);
		partial void OnIDContratoChanged();
		partial void OnIDContratoChanging(uint value);
		partial void OnNroLineaChanged();
		partial void OnNroLineaChanging(sbyte value);

		#endregion

		#region string Dia

		private string _dia;
		[DebuggerNonUserCode]
		[Column(Storage = "_dia", Name = "Dia", DbType = "varchar(10)", IsPrimaryKey = true, AutoSync = AutoSync.Never, CanBeNull = false)]
		public string Dia
		{
			get
			{
				return _dia;
			}
			set
			{
				if (value != _dia)
				{
					OnDiaChanging(value);
					SendPropertyChanging();
					_dia = value;
					SendPropertyChanged("Dia");
					OnDiaChanged();
				}
			}
		}

		#endregion

		#region string HoraFin

		private string _horaFin;
		[DebuggerNonUserCode]
		[Column(Storage = "_horaFin", Name = "HoraFin", DbType = "varchar(10)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public string HoraFin
		{
			get
			{
				return _horaFin;
			}
			set
			{
				if (value != _horaFin)
				{
					OnHoraFinChanging(value);
					SendPropertyChanging();
					_horaFin = value;
					SendPropertyChanged("HoraFin");
					OnHoraFinChanged();
				}
			}
		}

		#endregion

		#region string HoraIni

		private string _horaIni;
		[DebuggerNonUserCode]
		[Column(Storage = "_horaIni", Name = "HoraIni", DbType = "varchar(10)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public string HoraIni
		{
			get
			{
				return _horaIni;
			}
			set
			{
				if (value != _horaIni)
				{
					OnHoraIniChanging(value);
					SendPropertyChanging();
					_horaIni = value;
					SendPropertyChanged("HoraIni");
					OnHoraIniChanged();
				}
			}
		}

		#endregion

		#region uint IDContrato

		private uint _idcOntrato;
		[DebuggerNonUserCode]
		[Column(Storage = "_idcOntrato", Name = "IdContrato", DbType = "mediumint unsigned", IsPrimaryKey = true, AutoSync = AutoSync.Never, CanBeNull = false)]
		public uint IDContrato
		{
			get
			{
				return _idcOntrato;
			}
			set
			{
				if (value != _idcOntrato)
				{
					OnIDContratoChanging(value);
					SendPropertyChanging();
					_idcOntrato = value;
					SendPropertyChanged("IDContrato");
					OnIDContratoChanged();
				}
			}
		}

		#endregion

		#region sbyte NroLinea

		private sbyte _nroLinea;
		[DebuggerNonUserCode]
		[Column(Storage = "_nroLinea", Name = "NroLinea", DbType = "tinyint(2)", IsPrimaryKey = true, AutoSync = AutoSync.Never, CanBeNull = false)]
		public sbyte NroLinea
		{
			get
			{
				return _nroLinea;
			}
			set
			{
				if (value != _nroLinea)
				{
					if (_lineAshOrAs.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					OnNroLineaChanging(value);
					SendPropertyChanging();
					_nroLinea = value;
					SendPropertyChanged("NroLinea");
					OnNroLineaChanged();
				}
			}
		}

		#endregion

		#region Parents

		private EntityRef<LineAshOrAs> _lineAshOrAs;
		[Association(Storage = "_lineAshOrAs", OtherKey = "IDContrato,NroLinea", ThisKey = "IDContrato,NroLinea", Name = "FK_IdContratoNroLinea", IsForeignKey = true)]
		[DebuggerNonUserCode]
		public LineAshOrAs LineAshOrAs
		{
			get
			{
				return _lineAshOrAs.Entity;
			}
			set
			{
				if (value != _lineAshOrAs.Entity)
				{
					if (_lineAshOrAs.Entity != null)
					{
						var previousLineAshOrAs = _lineAshOrAs.Entity;
						_lineAshOrAs.Entity = null;
						previousLineAshOrAs.HoRaRioDiA.Remove(this);
					}
					_lineAshOrAs.Entity = value;
					if (value != null)
					{
						value.HoRaRioDiA.Add(this);
						_idcOntrato = value.IDContrato;
						_nroLinea = value.NroLinea;
					}
					else
					{
						_idcOntrato = default(uint);
						_nroLinea = default(sbyte);
					}
				}
			}
		}


		#endregion

		#region ctor

		public HoRaRioDiA()
		{
			_lineAshOrAs = new EntityRef<LineAshOrAs>();
			OnCreated();
		}

		#endregion

	}

	[Table(Name = "trustdb.horarioescalafon")]
	public partial class HoRaRioEScalaFOn : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region INotifyPropertyChanging handling

		public event PropertyChangingEventHandler PropertyChanging;

		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs("");
		protected virtual void SendPropertyChanging()
		{
			if (PropertyChanging != null)
			{
				PropertyChanging(this, emptyChangingEventArgs);
			}
		}

		#endregion

		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void SendPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region Extensibility Method Definitions

		partial void OnCreated();
		partial void OnDiAChanged();
		partial void OnDiAChanging(string value);
		partial void OnHoRaFInChanged();
		partial void OnHoRaFInChanging(string value);
		partial void OnHoRaInIChanged();
		partial void OnHoRaInIChanging(string value);
		partial void OnIDEscalafonChanged();
		partial void OnIDEscalafonChanging(uint value);
		partial void OnIDEscalafonEmpleadoChanged();
		partial void OnIDEscalafonEmpleadoChanging(uint value);
		partial void OnNroEmpleadoChanged();
		partial void OnNroEmpleadoChanging(uint value);
		partial void OnSolapaChanged();
		partial void OnSolapaChanging(sbyte value);
		partial void OnTipoDiaChanged();
		partial void OnTipoDiaChanging(byte? value);

		#endregion

		#region string DiA

		private string _diA;
		[DebuggerNonUserCode]
		[Column(Storage = "_diA", Name = "dia", DbType = "varchar(10)", IsPrimaryKey = true, AutoSync = AutoSync.Never, CanBeNull = false)]
		public string DiA
		{
			get
			{
				return _diA;
			}
			set
			{
				if (value != _diA)
				{
					OnDiAChanging(value);
					SendPropertyChanging();
					_diA = value;
					SendPropertyChanged("DiA");
					OnDiAChanged();
				}
			}
		}

		#endregion

		#region string HoRaFIn

		private string _hoRaFiN;
		[DebuggerNonUserCode]
		[Column(Storage = "_hoRaFiN", Name = "horafin", DbType = "varchar(10)", AutoSync = AutoSync.Never)]
		public string HoRaFIn
		{
			get
			{
				return _hoRaFiN;
			}
			set
			{
				if (value != _hoRaFiN)
				{
					OnHoRaFInChanging(value);
					SendPropertyChanging();
					_hoRaFiN = value;
					SendPropertyChanged("HoRaFIn");
					OnHoRaFInChanged();
				}
			}
		}

		#endregion

		#region string HoRaInI

		private string _hoRaInI;
		[DebuggerNonUserCode]
		[Column(Storage = "_hoRaInI", Name = "horaini", DbType = "varchar(10)", AutoSync = AutoSync.Never)]
		public string HoRaInI
		{
			get
			{
				return _hoRaInI;
			}
			set
			{
				if (value != _hoRaInI)
				{
					OnHoRaInIChanging(value);
					SendPropertyChanging();
					_hoRaInI = value;
					SendPropertyChanged("HoRaInI");
					OnHoRaInIChanged();
				}
			}
		}

		#endregion

		#region uint IDEscalafon

		private uint _ideScalafon;
		[DebuggerNonUserCode]
		[Column(Storage = "_ideScalafon", Name = "idEscalafon", DbType = "int unsigned", IsPrimaryKey = true, AutoSync = AutoSync.Never, CanBeNull = false)]
		public uint IDEscalafon
		{
			get
			{
				return _ideScalafon;
			}
			set
			{
				if (value != _ideScalafon)
				{
					OnIDEscalafonChanging(value);
					SendPropertyChanging();
					_ideScalafon = value;
					SendPropertyChanged("IDEscalafon");
					OnIDEscalafonChanged();
				}
			}
		}

		#endregion

		#region uint IDEscalafonEmpleado

		private uint _ideScalafonEmpleado;
		[DebuggerNonUserCode]
		[Column(Storage = "_ideScalafonEmpleado", Name = "idEscalafonEmpleado", DbType = "int unsigned", IsPrimaryKey = true, AutoSync = AutoSync.Never, CanBeNull = false)]
		public uint IDEscalafonEmpleado
		{
			get
			{
				return _ideScalafonEmpleado;
			}
			set
			{
				if (value != _ideScalafonEmpleado)
				{
					OnIDEscalafonEmpleadoChanging(value);
					SendPropertyChanging();
					_ideScalafonEmpleado = value;
					SendPropertyChanged("IDEscalafonEmpleado");
					OnIDEscalafonEmpleadoChanged();
				}
			}
		}

		#endregion

		#region uint NroEmpleado

		private uint _nroEmpleado;
		[DebuggerNonUserCode]
		[Column(Storage = "_nroEmpleado", Name = "NroEmpleado", DbType = "mediumint unsigned", AutoSync = AutoSync.Never, CanBeNull = false)]
		public uint NroEmpleado
		{
			get
			{
				return _nroEmpleado;
			}
			set
			{
				if (value != _nroEmpleado)
				{
					if (_emPleadOs.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					OnNroEmpleadoChanging(value);
					SendPropertyChanging();
					_nroEmpleado = value;
					SendPropertyChanged("NroEmpleado");
					OnNroEmpleadoChanged();
				}
			}
		}

		#endregion

		#region sbyte Solapa

		private sbyte _solapa;
		[DebuggerNonUserCode]
		[Column(Storage = "_solapa", Name = "Solapa", DbType = "tinyint(1)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public sbyte Solapa
		{
			get
			{
				return _solapa;
			}
			set
			{
				if (value != _solapa)
				{
					OnSolapaChanging(value);
					SendPropertyChanging();
					_solapa = value;
					SendPropertyChanged("Solapa");
					OnSolapaChanged();
				}
			}
		}

		#endregion

		#region byte? TipoDia

		private byte? _tipoDia;
		[DebuggerNonUserCode]
		[Column(Storage = "_tipoDia", Name = "tipoDia", DbType = "tinyint(2) unsigned", AutoSync = AutoSync.Never)]
		public byte? TipoDia
		{
			get
			{
				return _tipoDia;
			}
			set
			{
				if (value != _tipoDia)
				{
					OnTipoDiaChanging(value);
					SendPropertyChanging();
					_tipoDia = value;
					SendPropertyChanged("TipoDia");
					OnTipoDiaChanged();
				}
			}
		}

		#endregion

		#region Parents

		private EntityRef<EScalaFOneMpLeadO> _esCalaFoNeMpLeadO;
		[Association(Storage = "_esCalaFoNeMpLeadO", OtherKey = "IDEscalafon,IDEscalafonEmpleado", ThisKey = "IDEscalafon,IDEscalafonEmpleado", Name = "FK_horasEscalEmpleados", IsForeignKey = true)]
		[DebuggerNonUserCode]
		public EScalaFOneMpLeadO EScalaFOneMpLeadO
		{
			get
			{
				return _esCalaFoNeMpLeadO.Entity;
			}
			set
			{
				if (value != _esCalaFoNeMpLeadO.Entity)
				{
					if (_esCalaFoNeMpLeadO.Entity != null)
					{
						var previousEScalaFOneMpLeadO = _esCalaFoNeMpLeadO.Entity;
						_esCalaFoNeMpLeadO.Entity = null;
						previousEScalaFOneMpLeadO.HoRaRioEScalaFOn.Remove(this);
					}
					_esCalaFoNeMpLeadO.Entity = value;
					if (value != null)
					{
						value.HoRaRioEScalaFOn.Add(this);
						_ideScalafon = value.IDEscalafon;
						_ideScalafonEmpleado = value.IDEscalafonEmpleado;
					}
					else
					{
						_ideScalafon = default(uint);
						_ideScalafonEmpleado = default(uint);
					}
				}
			}
		}

		private EntityRef<TipOsDiAs> _tipOsDiAs;
		[Association(Storage = "_tipOsDiAs", OtherKey = "ID", ThisKey = "TipoDia", Name = "horarioescalafon_ibfk_1", IsForeignKey = true)]
		[DebuggerNonUserCode]
		public TipOsDiAs TipOsDiAs
		{
			get
			{
				return _tipOsDiAs.Entity;
			}
			set
			{
				if (value != _tipOsDiAs.Entity)
				{
					if (_tipOsDiAs.Entity != null)
					{
						var previousTipOsDiAs = _tipOsDiAs.Entity;
						_tipOsDiAs.Entity = null;
						previousTipOsDiAs.HoRaRioEScalaFOn.Remove(this);
					}
					_tipOsDiAs.Entity = value;
					if (value != null)
					{
						value.HoRaRioEScalaFOn.Add(this);
						_tipoDia = value.ID;
					}
					else
					{
						_tipoDia = null;
					}
				}
			}
		}

		private EntityRef<EmPleadOs> _emPleadOs;
		[Association(Storage = "_emPleadOs", OtherKey = "NroEmpleado", ThisKey = "NroEmpleado", Name = "horarioescalafon_ibfk_2", IsForeignKey = true)]
		[DebuggerNonUserCode]
		public EmPleadOs EmPleadOs
		{
			get
			{
				return _emPleadOs.Entity;
			}
			set
			{
				if (value != _emPleadOs.Entity)
				{
					if (_emPleadOs.Entity != null)
					{
						var previousEmPleadOs = _emPleadOs.Entity;
						_emPleadOs.Entity = null;
						previousEmPleadOs.HoRaRioEScalaFOn.Remove(this);
					}
					_emPleadOs.Entity = value;
					if (value != null)
					{
						value.HoRaRioEScalaFOn.Add(this);
						_nroEmpleado = value.NroEmpleado;
					}
					else
					{
						_nroEmpleado = default(uint);
					}
				}
			}
		}


		#endregion

		#region ctor

		public HoRaRioEScalaFOn()
		{
			_esCalaFoNeMpLeadO = new EntityRef<EScalaFOneMpLeadO>();
			_tipOsDiAs = new EntityRef<TipOsDiAs>();
			_emPleadOs = new EntityRef<EmPleadOs>();
			OnCreated();
		}

		#endregion

	}

	[Table(Name = "trustdb.horascomunescontratos")]
	public partial class HoRaSComUnescoNtRatOs : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region INotifyPropertyChanging handling

		public event PropertyChangingEventHandler PropertyChanging;

		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs("");
		protected virtual void SendPropertyChanging()
		{
			if (PropertyChanging != null)
			{
				PropertyChanging(this, emptyChangingEventArgs);
			}
		}

		#endregion

		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void SendPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region Extensibility Method Definitions

		partial void OnCreated();
		partial void OnDomingoChanged();
		partial void OnDomingoChanging(string value);
		partial void OnIDContraToSChanged();
		partial void OnIDContraToSChanging(uint value);
		partial void OnJuevesChanged();
		partial void OnJuevesChanging(string value);
		partial void OnLunesChanged();
		partial void OnLunesChanging(string value);
		partial void OnMartesChanged();
		partial void OnMartesChanging(string value);
		partial void OnMiercolesChanged();
		partial void OnMiercolesChanging(string value);
		partial void OnSabadoChanged();
		partial void OnSabadoChanging(string value);
		partial void OnViernesChanged();
		partial void OnViernesChanging(string value);

		#endregion

		#region string Domingo

		private string _domingo;
		[DebuggerNonUserCode]
		[Column(Storage = "_domingo", Name = "Domingo", DbType = "varchar(10)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public string Domingo
		{
			get
			{
				return _domingo;
			}
			set
			{
				if (value != _domingo)
				{
					OnDomingoChanging(value);
					SendPropertyChanging();
					_domingo = value;
					SendPropertyChanged("Domingo");
					OnDomingoChanged();
				}
			}
		}

		#endregion

		#region uint IDContraToS

		private uint _idcOntraToS;
		[DebuggerNonUserCode]
		[Column(Storage = "_idcOntraToS", Name = "idcontratos", DbType = "mediumint unsigned", IsPrimaryKey = true, AutoSync = AutoSync.Never, CanBeNull = false)]
		public uint IDContraToS
		{
			get
			{
				return _idcOntraToS;
			}
			set
			{
				if (value != _idcOntraToS)
				{
					OnIDContraToSChanging(value);
					SendPropertyChanging();
					_idcOntraToS = value;
					SendPropertyChanged("IDContraToS");
					OnIDContraToSChanged();
				}
			}
		}

		#endregion

		#region string Jueves

		private string _jueves;
		[DebuggerNonUserCode]
		[Column(Storage = "_jueves", Name = "Jueves", DbType = "varchar(10)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public string Jueves
		{
			get
			{
				return _jueves;
			}
			set
			{
				if (value != _jueves)
				{
					OnJuevesChanging(value);
					SendPropertyChanging();
					_jueves = value;
					SendPropertyChanged("Jueves");
					OnJuevesChanged();
				}
			}
		}

		#endregion

		#region string Lunes

		private string _lunes;
		[DebuggerNonUserCode]
		[Column(Storage = "_lunes", Name = "Lunes", DbType = "varchar(10)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public string Lunes
		{
			get
			{
				return _lunes;
			}
			set
			{
				if (value != _lunes)
				{
					OnLunesChanging(value);
					SendPropertyChanging();
					_lunes = value;
					SendPropertyChanged("Lunes");
					OnLunesChanged();
				}
			}
		}

		#endregion

		#region string Martes

		private string _martes;
		[DebuggerNonUserCode]
		[Column(Storage = "_martes", Name = "Martes", DbType = "varchar(10)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public string Martes
		{
			get
			{
				return _martes;
			}
			set
			{
				if (value != _martes)
				{
					OnMartesChanging(value);
					SendPropertyChanging();
					_martes = value;
					SendPropertyChanged("Martes");
					OnMartesChanged();
				}
			}
		}

		#endregion

		#region string Miercoles

		private string _miercoles;
		[DebuggerNonUserCode]
		[Column(Storage = "_miercoles", Name = "Miercoles", DbType = "varchar(10)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public string Miercoles
		{
			get
			{
				return _miercoles;
			}
			set
			{
				if (value != _miercoles)
				{
					OnMiercolesChanging(value);
					SendPropertyChanging();
					_miercoles = value;
					SendPropertyChanged("Miercoles");
					OnMiercolesChanged();
				}
			}
		}

		#endregion

		#region string Sabado

		private string _sabado;
		[DebuggerNonUserCode]
		[Column(Storage = "_sabado", Name = "Sabado", DbType = "varchar(10)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public string Sabado
		{
			get
			{
				return _sabado;
			}
			set
			{
				if (value != _sabado)
				{
					OnSabadoChanging(value);
					SendPropertyChanging();
					_sabado = value;
					SendPropertyChanged("Sabado");
					OnSabadoChanged();
				}
			}
		}

		#endregion

		#region string Viernes

		private string _viernes;
		[DebuggerNonUserCode]
		[Column(Storage = "_viernes", Name = "Viernes", DbType = "varchar(10)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public string Viernes
		{
			get
			{
				return _viernes;
			}
			set
			{
				if (value != _viernes)
				{
					OnViernesChanging(value);
					SendPropertyChanging();
					_viernes = value;
					SendPropertyChanged("Viernes");
					OnViernesChanged();
				}
			}
		}

		#endregion

		#region Parents

		private EntityRef<ContraToS> _contraToS;
		[Association(Storage = "_contraToS", OtherKey = "IDContratos", ThisKey = "IDContraToS", Name = "FK_Contrato", IsForeignKey = true)]
		[DebuggerNonUserCode]
		public ContraToS ContraToS
		{
			get
			{
				return _contraToS.Entity;
			}
			set
			{
				if (value != _contraToS.Entity)
				{
					if (_contraToS.Entity != null)
					{
						var previousContraToS = _contraToS.Entity;
						_contraToS.Entity = null;
						previousContraToS.HoRaSComUnescoNtRatOs.Remove(this);
					}
					_contraToS.Entity = value;
					if (value != null)
					{
						value.HoRaSComUnescoNtRatOs.Add(this);
						_idcOntraToS = value.IDContratos;
					}
					else
					{
						_idcOntraToS = default(uint);
					}
				}
			}
		}


		#endregion

		#region ctor

		public HoRaSComUnescoNtRatOs()
		{
			_contraToS = new EntityRef<ContraToS>();
			OnCreated();
		}

		#endregion

	}

	[Table(Name = "trustdb.horasgeneradasescalafon")]
	public partial class HoRaSGeneraDaSEScalaFOn : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region INotifyPropertyChanging handling

		public event PropertyChangingEventHandler PropertyChanging;

		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs("");
		protected virtual void SendPropertyChanging()
		{
			if (PropertyChanging != null)
			{
				PropertyChanging(this, emptyChangingEventArgs);
			}
		}

		#endregion

		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void SendPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region Extensibility Method Definitions

		partial void OnCreated();
		partial void OnAcArgoDeLaEmpresaChanged();
		partial void OnAcArgoDeLaEmpresaChanging(sbyte value);
		partial void OnDescansoChanged();
		partial void OnDescansoChanging(sbyte value);
		partial void OnDiaHoraLlamadaAntesHoraEntradaChanged();
		partial void OnDiaHoraLlamadaAntesHoraEntradaChanging(DateTime value);
		partial void OnFechaCorrespondienteChanged();
		partial void OnFechaCorrespondienteChanging(DateTime value);
		partial void OnHoraEntradaChanged();
		partial void OnHoraEntradaChanging(DateTime value);
		partial void OnHoraSalidaChanged();
		partial void OnHoraSalidaChanging(DateTime value);
		partial void OnIDHorasGeneradasEscalafonChanged();
		partial void OnIDHorasGeneradasEscalafonChanging(long value);
		partial void OnNroEmpleadoChanged();
		partial void OnNroEmpleadoChanging(uint value);
		partial void OnNumeroClienteChanged();
		partial void OnNumeroClienteChanging(uint value);
		partial void OnNumeroServicioChanged();
		partial void OnNumeroServicioChanging(uint value);

		#endregion

		#region sbyte AcArgoDeLaEmpresa

		private sbyte _acArgoDeLaEmpresa;
		[DebuggerNonUserCode]
		[Column(Storage = "_acArgoDeLaEmpresa", Name = "ACargoDeLaEmpresa", DbType = "tinyint(1)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public sbyte AcArgoDeLaEmpresa
		{
			get
			{
				return _acArgoDeLaEmpresa;
			}
			set
			{
				if (value != _acArgoDeLaEmpresa)
				{
					OnAcArgoDeLaEmpresaChanging(value);
					SendPropertyChanging();
					_acArgoDeLaEmpresa = value;
					SendPropertyChanged("AcArgoDeLaEmpresa");
					OnAcArgoDeLaEmpresaChanged();
				}
			}
		}

		#endregion

		#region sbyte Descanso

		private sbyte _descanso;
		[DebuggerNonUserCode]
		[Column(Storage = "_descanso", Name = "Descanso", DbType = "tinyint(1)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public sbyte Descanso
		{
			get
			{
				return _descanso;
			}
			set
			{
				if (value != _descanso)
				{
					OnDescansoChanging(value);
					SendPropertyChanging();
					_descanso = value;
					SendPropertyChanged("Descanso");
					OnDescansoChanged();
				}
			}
		}

		#endregion

		#region DateTime DiaHoraLlamadaAntesHoraEntrada

		private DateTime _diaHoraLlamadaAntesHoraEntrada;
		[DebuggerNonUserCode]
		[Column(Storage = "_diaHoraLlamadaAntesHoraEntrada", Name = "DiaHoraLlamadaAntesHoraEntrada", DbType = "datetime", AutoSync = AutoSync.Never, CanBeNull = false)]
		public DateTime DiaHoraLlamadaAntesHoraEntrada
		{
			get
			{
				return _diaHoraLlamadaAntesHoraEntrada;
			}
			set
			{
				if (value != _diaHoraLlamadaAntesHoraEntrada)
				{
					OnDiaHoraLlamadaAntesHoraEntradaChanging(value);
					SendPropertyChanging();
					_diaHoraLlamadaAntesHoraEntrada = value;
					SendPropertyChanged("DiaHoraLlamadaAntesHoraEntrada");
					OnDiaHoraLlamadaAntesHoraEntradaChanged();
				}
			}
		}

		#endregion

		#region DateTime FechaCorrespondiente

		private DateTime _fechaCorrespondiente;
		[DebuggerNonUserCode]
		[Column(Storage = "_fechaCorrespondiente", Name = "FechaCorrespondiente", DbType = "date", AutoSync = AutoSync.Never, CanBeNull = false)]
		public DateTime FechaCorrespondiente
		{
			get
			{
				return _fechaCorrespondiente;
			}
			set
			{
				if (value != _fechaCorrespondiente)
				{
					OnFechaCorrespondienteChanging(value);
					SendPropertyChanging();
					_fechaCorrespondiente = value;
					SendPropertyChanged("FechaCorrespondiente");
					OnFechaCorrespondienteChanged();
				}
			}
		}

		#endregion

		#region DateTime HoraEntrada

		private DateTime _horaEntrada;
		[DebuggerNonUserCode]
		[Column(Storage = "_horaEntrada", Name = "HoraEntrada", DbType = "datetime", AutoSync = AutoSync.Never, CanBeNull = false)]
		public DateTime HoraEntrada
		{
			get
			{
				return _horaEntrada;
			}
			set
			{
				if (value != _horaEntrada)
				{
					OnHoraEntradaChanging(value);
					SendPropertyChanging();
					_horaEntrada = value;
					SendPropertyChanged("HoraEntrada");
					OnHoraEntradaChanged();
				}
			}
		}

		#endregion

		#region DateTime HoraSalida

		private DateTime _horaSalida;
		[DebuggerNonUserCode]
		[Column(Storage = "_horaSalida", Name = "HoraSalida", DbType = "datetime", AutoSync = AutoSync.Never, CanBeNull = false)]
		public DateTime HoraSalida
		{
			get
			{
				return _horaSalida;
			}
			set
			{
				if (value != _horaSalida)
				{
					OnHoraSalidaChanging(value);
					SendPropertyChanging();
					_horaSalida = value;
					SendPropertyChanged("HoraSalida");
					OnHoraSalidaChanged();
				}
			}
		}

		#endregion

		#region long IDHorasGeneradasEscalafon

		private long _idhOrasGeneradasEscalafon;
		[DebuggerNonUserCode]
		[Column(Storage = "_idhOrasGeneradasEscalafon", Name = "IdHorasGeneradasEscalafon", DbType = "bigint(20)", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false)]
		public long IDHorasGeneradasEscalafon
		{
			get
			{
				return _idhOrasGeneradasEscalafon;
			}
			set
			{
				if (value != _idhOrasGeneradasEscalafon)
				{
					OnIDHorasGeneradasEscalafonChanging(value);
					SendPropertyChanging();
					_idhOrasGeneradasEscalafon = value;
					SendPropertyChanged("IDHorasGeneradasEscalafon");
					OnIDHorasGeneradasEscalafonChanged();
				}
			}
		}

		#endregion

		#region uint NroEmpleado

		private uint _nroEmpleado;
		[DebuggerNonUserCode]
		[Column(Storage = "_nroEmpleado", Name = "NroEmpleado", DbType = "mediumint unsigned", AutoSync = AutoSync.Never, CanBeNull = false)]
		public uint NroEmpleado
		{
			get
			{
				return _nroEmpleado;
			}
			set
			{
				if (value != _nroEmpleado)
				{
					if (_emPleadOs.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					OnNroEmpleadoChanging(value);
					SendPropertyChanging();
					_nroEmpleado = value;
					SendPropertyChanged("NroEmpleado");
					OnNroEmpleadoChanged();
				}
			}
		}

		#endregion

		#region uint NumeroCliente

		private uint _numeroCliente;
		[DebuggerNonUserCode]
		[Column(Storage = "_numeroCliente", Name = "NumeroCliente", DbType = "mediumint unsigned", AutoSync = AutoSync.Never, CanBeNull = false)]
		public uint NumeroCliente
		{
			get
			{
				return _numeroCliente;
			}
			set
			{
				if (value != _numeroCliente)
				{
					if (_servIcIoS.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					OnNumeroClienteChanging(value);
					SendPropertyChanging();
					_numeroCliente = value;
					SendPropertyChanged("NumeroCliente");
					OnNumeroClienteChanged();
				}
			}
		}

		#endregion

		#region uint NumeroServicio

		private uint _numeroServicio;
		[DebuggerNonUserCode]
		[Column(Storage = "_numeroServicio", Name = "NumeroServicio", DbType = "mediumint unsigned", AutoSync = AutoSync.Never, CanBeNull = false)]
		public uint NumeroServicio
		{
			get
			{
				return _numeroServicio;
			}
			set
			{
				if (value != _numeroServicio)
				{
					if (_servIcIoS.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					OnNumeroServicioChanging(value);
					SendPropertyChanging();
					_numeroServicio = value;
					SendPropertyChanged("NumeroServicio");
					OnNumeroServicioChanged();
				}
			}
		}

		#endregion

		#region Parents

		private EntityRef<SERVicIoS> _servIcIoS;
		[Association(Storage = "_servIcIoS", OtherKey = "NumeroCliente,NumeroServicio", ThisKey = "NumeroCliente,NumeroServicio", Name = "horasgeneradasescalafon_ibfk_2", IsForeignKey = true)]
		[DebuggerNonUserCode]
		public SERVicIoS SERVicIoS
		{
			get
			{
				return _servIcIoS.Entity;
			}
			set
			{
				if (value != _servIcIoS.Entity)
				{
					if (_servIcIoS.Entity != null)
					{
						var previousSERVicIoS = _servIcIoS.Entity;
						_servIcIoS.Entity = null;
						previousSERVicIoS.HoRaSGeneraDaSEScalaFOn.Remove(this);
					}
					_servIcIoS.Entity = value;
					if (value != null)
					{
						value.HoRaSGeneraDaSEScalaFOn.Add(this);
						_numeroCliente = value.NumeroCliente;
						_numeroServicio = value.NumeroServicio;
					}
					else
					{
						_numeroCliente = default(uint);
						_numeroServicio = default(uint);
					}
				}
			}
		}

		private EntityRef<EmPleadOs> _emPleadOs;
		[Association(Storage = "_emPleadOs", OtherKey = "NroEmpleado", ThisKey = "NroEmpleado", Name = "horasgeneradasescalafon_ibfk_3", IsForeignKey = true)]
		[DebuggerNonUserCode]
		public EmPleadOs EmPleadOs
		{
			get
			{
				return _emPleadOs.Entity;
			}
			set
			{
				if (value != _emPleadOs.Entity)
				{
					if (_emPleadOs.Entity != null)
					{
						var previousEmPleadOs = _emPleadOs.Entity;
						_emPleadOs.Entity = null;
						previousEmPleadOs.HoRaSGeneraDaSEScalaFOn.Remove(this);
					}
					_emPleadOs.Entity = value;
					if (value != null)
					{
						value.HoRaSGeneraDaSEScalaFOn.Add(this);
						_nroEmpleado = value.NroEmpleado;
					}
					else
					{
						_nroEmpleado = default(uint);
					}
				}
			}
		}


		#endregion

		#region ctor

		public HoRaSGeneraDaSEScalaFOn()
		{
			_servIcIoS = new EntityRef<SERVicIoS>();
			_emPleadOs = new EntityRef<EmPleadOs>();
			OnCreated();
		}

		#endregion

	}

	[Table(Name = "trustdb.hscomunesadicionalesliquidacionempleado")]
	public partial class HsComUnEsAdICIonAleSLiquidAcIonEmPleadO : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region INotifyPropertyChanging handling

		public event PropertyChangingEventHandler PropertyChanging;

		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs("");
		protected virtual void SendPropertyChanging()
		{
			if (PropertyChanging != null)
			{
				PropertyChanging(this, emptyChangingEventArgs);
			}
		}

		#endregion

		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void SendPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region Extensibility Method Definitions

		partial void OnCreated();
		partial void OnClienteEmpleadoCorrespondienteChanged();
		partial void OnClienteEmpleadoCorrespondienteChanging(string value);
		partial void OnClienteOeMpleadoChanged();
		partial void OnClienteOeMpleadoChanging(string value);
		partial void OnHsAdicionalesEnSegsChanged();
		partial void OnHsAdicionalesEnSegsChanging(string value);
		partial void OnIDHsComunesAdicionalesLiquidacionEmpeladoChanged();
		partial void OnIDHsComunesAdicionalesLiquidacionEmpeladoChanging(int value);

		#endregion

		#region string ClienteEmpleadoCorrespondiente

		private string _clienteEmpleadoCorrespondiente;
		[DebuggerNonUserCode]
		[Column(Storage = "_clienteEmpleadoCorrespondiente", Name = "ClienteEmpleadoCorrespondiente", DbType = "varchar(20)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public string ClienteEmpleadoCorrespondiente
		{
			get
			{
				return _clienteEmpleadoCorrespondiente;
			}
			set
			{
				if (value != _clienteEmpleadoCorrespondiente)
				{
					OnClienteEmpleadoCorrespondienteChanging(value);
					SendPropertyChanging();
					_clienteEmpleadoCorrespondiente = value;
					SendPropertyChanged("ClienteEmpleadoCorrespondiente");
					OnClienteEmpleadoCorrespondienteChanged();
				}
			}
		}

		#endregion

		#region string ClienteOeMpleado

		private string _clienteOeMpleado;
		[DebuggerNonUserCode]
		[Column(Storage = "_clienteOeMpleado", Name = "ClienteOEmpleado", DbType = "varchar(8)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public string ClienteOeMpleado
		{
			get
			{
				return _clienteOeMpleado;
			}
			set
			{
				if (value != _clienteOeMpleado)
				{
					OnClienteOeMpleadoChanging(value);
					SendPropertyChanging();
					_clienteOeMpleado = value;
					SendPropertyChanged("ClienteOeMpleado");
					OnClienteOeMpleadoChanged();
				}
			}
		}

		#endregion

		#region string HsAdicionalesEnSegs

		private string _hsAdicionalesEnSegs;
		[DebuggerNonUserCode]
		[Column(Storage = "_hsAdicionalesEnSegs", Name = "HsAdicionalesEnSegs", DbType = "mediumtext", AutoSync = AutoSync.Never)]
		public string HsAdicionalesEnSegs
		{
			get
			{
				return _hsAdicionalesEnSegs;
			}
			set
			{
				if (value != _hsAdicionalesEnSegs)
				{
					OnHsAdicionalesEnSegsChanging(value);
					SendPropertyChanging();
					_hsAdicionalesEnSegs = value;
					SendPropertyChanged("HsAdicionalesEnSegs");
					OnHsAdicionalesEnSegsChanged();
				}
			}
		}

		#endregion

		#region int IDHsComunesAdicionalesLiquidacionEmpelado

		private int _idhSComunesAdicionalesLiquidacionEmpelado;
		[DebuggerNonUserCode]
		[Column(Storage = "_idhSComunesAdicionalesLiquidacionEmpelado", Name = "IdHsComunesAdicionalesLiquidacionEmpelado", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false)]
		public int IDHsComunesAdicionalesLiquidacionEmpelado
		{
			get
			{
				return _idhSComunesAdicionalesLiquidacionEmpelado;
			}
			set
			{
				if (value != _idhSComunesAdicionalesLiquidacionEmpelado)
				{
					OnIDHsComunesAdicionalesLiquidacionEmpeladoChanging(value);
					SendPropertyChanging();
					_idhSComunesAdicionalesLiquidacionEmpelado = value;
					SendPropertyChanged("IDHsComunesAdicionalesLiquidacionEmpelado");
					OnIDHsComunesAdicionalesLiquidacionEmpeladoChanged();
				}
			}
		}

		#endregion

		#region ctor

		public HsComUnEsAdICIonAleSLiquidAcIonEmPleadO()
		{
			OnCreated();
		}

		#endregion

	}

	[Table(Name = "trustdb.lineashoras")]
	public partial class LineAshOrAs : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region INotifyPropertyChanging handling

		public event PropertyChangingEventHandler PropertyChanging;

		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs("");
		protected virtual void SendPropertyChanging()
		{
			if (PropertyChanging != null)
			{
				PropertyChanging(this, emptyChangingEventArgs);
			}
		}

		#endregion

		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void SendPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region Extensibility Method Definitions

		partial void OnCreated();
		partial void OnArmadoChanged();
		partial void OnArmadoChanging(sbyte value);
		partial void OnCantHsExtrasChanged();
		partial void OnCantHsExtrasChanging(sbyte? value);
		partial void OnCantHsNormalesChanged();
		partial void OnCantHsNormalesChanging(sbyte? value);
		partial void OnCantidadChanged();
		partial void OnCantidadChanging(sbyte value);
		partial void OnIDContratoChanged();
		partial void OnIDContratoChanging(uint value);
		partial void OnNroLineaChanged();
		partial void OnNroLineaChanging(sbyte value);
		partial void OnPrecioXhOraChanged();
		partial void OnPrecioXhOraChanging(float? value);
		partial void OnPuestoChanged();
		partial void OnPuestoChanging(string value);

		#endregion

		#region sbyte Armado

		private sbyte _armado;
		[DebuggerNonUserCode]
		[Column(Storage = "_armado", Name = "Armado", DbType = "tinyint(1)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public sbyte Armado
		{
			get
			{
				return _armado;
			}
			set
			{
				if (value != _armado)
				{
					OnArmadoChanging(value);
					SendPropertyChanging();
					_armado = value;
					SendPropertyChanged("Armado");
					OnArmadoChanged();
				}
			}
		}

		#endregion

		#region sbyte? CantHsExtras

		private sbyte? _cantHsExtras;
		[DebuggerNonUserCode]
		[Column(Storage = "_cantHsExtras", Name = "CantHsExtras", DbType = "tinyint(3)", AutoSync = AutoSync.Never)]
		public sbyte? CantHsExtras
		{
			get
			{
				return _cantHsExtras;
			}
			set
			{
				if (value != _cantHsExtras)
				{
					OnCantHsExtrasChanging(value);
					SendPropertyChanging();
					_cantHsExtras = value;
					SendPropertyChanged("CantHsExtras");
					OnCantHsExtrasChanged();
				}
			}
		}

		#endregion

		#region sbyte? CantHsNormales

		private sbyte? _cantHsNormales;
		[DebuggerNonUserCode]
		[Column(Storage = "_cantHsNormales", Name = "CantHsNormales", DbType = "tinyint(3)", AutoSync = AutoSync.Never)]
		public sbyte? CantHsNormales
		{
			get
			{
				return _cantHsNormales;
			}
			set
			{
				if (value != _cantHsNormales)
				{
					OnCantHsNormalesChanging(value);
					SendPropertyChanging();
					_cantHsNormales = value;
					SendPropertyChanged("CantHsNormales");
					OnCantHsNormalesChanged();
				}
			}
		}

		#endregion

		#region sbyte Cantidad

		private sbyte _cantidad;
		[DebuggerNonUserCode]
		[Column(Storage = "_cantidad", Name = "Cantidad", DbType = "tinyint(3)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public sbyte Cantidad
		{
			get
			{
				return _cantidad;
			}
			set
			{
				if (value != _cantidad)
				{
					OnCantidadChanging(value);
					SendPropertyChanging();
					_cantidad = value;
					SendPropertyChanged("Cantidad");
					OnCantidadChanged();
				}
			}
		}

		#endregion

		#region uint IDContrato

		private uint _idcOntrato;
		[DebuggerNonUserCode]
		[Column(Storage = "_idcOntrato", Name = "IdContrato", DbType = "mediumint unsigned", IsPrimaryKey = true, AutoSync = AutoSync.Never, CanBeNull = false)]
		public uint IDContrato
		{
			get
			{
				return _idcOntrato;
			}
			set
			{
				if (value != _idcOntrato)
				{
					OnIDContratoChanging(value);
					SendPropertyChanging();
					_idcOntrato = value;
					SendPropertyChanged("IDContrato");
					OnIDContratoChanged();
				}
			}
		}

		#endregion

		#region sbyte NroLinea

		private sbyte _nroLinea;
		[DebuggerNonUserCode]
		[Column(Storage = "_nroLinea", Name = "NroLinea", DbType = "tinyint(2)", IsPrimaryKey = true, AutoSync = AutoSync.Never, CanBeNull = false)]
		public sbyte NroLinea
		{
			get
			{
				return _nroLinea;
			}
			set
			{
				if (value != _nroLinea)
				{
					OnNroLineaChanging(value);
					SendPropertyChanging();
					_nroLinea = value;
					SendPropertyChanged("NroLinea");
					OnNroLineaChanged();
				}
			}
		}

		#endregion

		#region float? PrecioXhOra

		private float? _precioXhOra;
		[DebuggerNonUserCode]
		[Column(Storage = "_precioXhOra", Name = "PrecioXHora", DbType = "float", AutoSync = AutoSync.Never)]
		public float? PrecioXhOra
		{
			get
			{
				return _precioXhOra;
			}
			set
			{
				if (value != _precioXhOra)
				{
					OnPrecioXhOraChanging(value);
					SendPropertyChanging();
					_precioXhOra = value;
					SendPropertyChanged("PrecioXhOra");
					OnPrecioXhOraChanged();
				}
			}
		}

		#endregion

		#region string Puesto

		private string _puesto;
		[DebuggerNonUserCode]
		[Column(Storage = "_puesto", Name = "Puesto", DbType = "varchar(50)", AutoSync = AutoSync.Never)]
		public string Puesto
		{
			get
			{
				return _puesto;
			}
			set
			{
				if (value != _puesto)
				{
					OnPuestoChanging(value);
					SendPropertyChanging();
					_puesto = value;
					SendPropertyChanged("Puesto");
					OnPuestoChanged();
				}
			}
		}

		#endregion

		#region Children

		private EntitySet<HoRaRioDiA> _hoRaRioDiA;
		[Association(Storage = "_hoRaRioDiA", OtherKey = "IDContrato,NroLinea", ThisKey = "IDContrato,NroLinea", Name = "FK_IdContratoNroLinea")]
		[DebuggerNonUserCode]
		public EntitySet<HoRaRioDiA> HoRaRioDiA
		{
			get
			{
				return _hoRaRioDiA;
			}
			set
			{
				_hoRaRioDiA = value;
			}
		}


		#endregion

		#region Parents

		private EntityRef<ContraToS> _contraToS;
		[Association(Storage = "_contraToS", OtherKey = "IDContratos", ThisKey = "IDContrato", Name = "FK_Contratos", IsForeignKey = true)]
		[DebuggerNonUserCode]
		public ContraToS ContraToS
		{
			get
			{
				return _contraToS.Entity;
			}
			set
			{
				if (value != _contraToS.Entity)
				{
					if (_contraToS.Entity != null)
					{
						var previousContraToS = _contraToS.Entity;
						_contraToS.Entity = null;
						previousContraToS.LineAshOrAs.Remove(this);
					}
					_contraToS.Entity = value;
					if (value != null)
					{
						value.LineAshOrAs.Add(this);
						_idcOntrato = value.IDContratos;
					}
					else
					{
						_idcOntrato = default(uint);
					}
				}
			}
		}


		#endregion

		#region Attachement handlers

		private void HoRaRioDiA_Attach(HoRaRioDiA entity)
		{
			entity.LineAshOrAs = this;
		}

		private void HoRaRioDiA_Detach(HoRaRioDiA entity)
		{
			entity.LineAshOrAs = null;
		}


		#endregion

		#region ctor

		public LineAshOrAs()
		{
			_hoRaRioDiA = new EntitySet<HoRaRioDiA>(HoRaRioDiA_Attach, HoRaRioDiA_Detach);
			_contraToS = new EntityRef<ContraToS>();
			OnCreated();
		}

		#endregion

	}

	[Table(Name = "trustdb.liquidacionempleados")]
	public partial class LiquidAcIonEmPleadOs : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region INotifyPropertyChanging handling

		public event PropertyChangingEventHandler PropertyChanging;

		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs("");
		protected virtual void SendPropertyChanging()
		{
			if (PropertyChanging != null)
			{
				PropertyChanging(this, emptyChangingEventArgs);
			}
		}

		#endregion

		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void SendPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region Extensibility Method Definitions

		partial void OnCreated();
		partial void OnFechaChanged();
		partial void OnFechaChanging(DateTime value);
		partial void OnHorasChanged();
		partial void OnHorasChanging(DateTime value);
		partial void OnNroClienteChanged();
		partial void OnNroClienteChanging(uint value);
		partial void OnNroEmpleadoChanged();
		partial void OnNroEmpleadoChanging(uint value);
		partial void OnNroServicioChanged();
		partial void OnNroServicioChanging(uint value);

		#endregion

		#region DateTime Fecha

		private DateTime _fecha;
		[DebuggerNonUserCode]
		[Column(Storage = "_fecha", Name = "Fecha", DbType = "date", IsPrimaryKey = true, AutoSync = AutoSync.Never, CanBeNull = false)]
		public DateTime Fecha
		{
			get
			{
				return _fecha;
			}
			set
			{
				if (value != _fecha)
				{
					OnFechaChanging(value);
					SendPropertyChanging();
					_fecha = value;
					SendPropertyChanged("Fecha");
					OnFechaChanged();
				}
			}
		}

		#endregion

		#region DateTime Horas

		private DateTime _horas;
		[DebuggerNonUserCode]
		[Column(Storage = "_horas", Name = "Horas", DbType = "datetime", AutoSync = AutoSync.Never, CanBeNull = false)]
		public DateTime Horas
		{
			get
			{
				return _horas;
			}
			set
			{
				if (value != _horas)
				{
					OnHorasChanging(value);
					SendPropertyChanging();
					_horas = value;
					SendPropertyChanged("Horas");
					OnHorasChanged();
				}
			}
		}

		#endregion

		#region uint NroCliente

		private uint _nroCliente;
		[DebuggerNonUserCode]
		[Column(Storage = "_nroCliente", Name = "NroCliente", DbType = "mediumint unsigned", IsPrimaryKey = true, AutoSync = AutoSync.Never, CanBeNull = false)]
		public uint NroCliente
		{
			get
			{
				return _nroCliente;
			}
			set
			{
				if (value != _nroCliente)
				{
					OnNroClienteChanging(value);
					SendPropertyChanging();
					_nroCliente = value;
					SendPropertyChanged("NroCliente");
					OnNroClienteChanged();
				}
			}
		}

		#endregion

		#region uint NroEmpleado

		private uint _nroEmpleado;
		[DebuggerNonUserCode]
		[Column(Storage = "_nroEmpleado", Name = "NroEmpleado", DbType = "mediumint unsigned", IsPrimaryKey = true, AutoSync = AutoSync.Never, CanBeNull = false)]
		public uint NroEmpleado
		{
			get
			{
				return _nroEmpleado;
			}
			set
			{
				if (value != _nroEmpleado)
				{
					OnNroEmpleadoChanging(value);
					SendPropertyChanging();
					_nroEmpleado = value;
					SendPropertyChanged("NroEmpleado");
					OnNroEmpleadoChanged();
				}
			}
		}

		#endregion

		#region uint NroServicio

		private uint _nroServicio;
		[DebuggerNonUserCode]
		[Column(Storage = "_nroServicio", Name = "NroServicio", DbType = "mediumint unsigned", IsPrimaryKey = true, AutoSync = AutoSync.Never, CanBeNull = false)]
		public uint NroServicio
		{
			get
			{
				return _nroServicio;
			}
			set
			{
				if (value != _nroServicio)
				{
					OnNroServicioChanging(value);
					SendPropertyChanging();
					_nroServicio = value;
					SendPropertyChanged("NroServicio");
					OnNroServicioChanged();
				}
			}
		}

		#endregion

		#region ctor

		public LiquidAcIonEmPleadOs()
		{
			OnCreated();
		}

		#endregion

	}

	[Table(Name = "trustdb.listanegra")]
	public partial class ListAnEGRa : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region INotifyPropertyChanging handling

		public event PropertyChangingEventHandler PropertyChanging;

		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs("");
		protected virtual void SendPropertyChanging()
		{
			if (PropertyChanging != null)
			{
				PropertyChanging(this, emptyChangingEventArgs);
			}
		}

		#endregion

		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void SendPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region Extensibility Method Definitions

		partial void OnCreated();
		partial void OnActivoChanged();
		partial void OnActivoChanging(sbyte? value);
		partial void OnApellidosChanged();
		partial void OnApellidosChanging(string value);
		partial void OnCIChanged();
		partial void OnCIChanging(string value);
		partial void OnFechaAltaChanged();
		partial void OnFechaAltaChanging(DateTime? value);
		partial void OnFechaBajaChanged();
		partial void OnFechaBajaChanging(DateTime? value);
		partial void OnMotivoRechazoChanged();
		partial void OnMotivoRechazoChanging(string value);
		partial void OnNombresChanged();
		partial void OnNombresChanging(string value);

		#endregion

		#region sbyte? Activo

		private sbyte? _activo;
		[DebuggerNonUserCode]
		[Column(Storage = "_activo", Name = "Activo", DbType = "tinyint(1)", AutoSync = AutoSync.Never)]
		public sbyte? Activo
		{
			get
			{
				return _activo;
			}
			set
			{
				if (value != _activo)
				{
					OnActivoChanging(value);
					SendPropertyChanging();
					_activo = value;
					SendPropertyChanged("Activo");
					OnActivoChanged();
				}
			}
		}

		#endregion

		#region string Apellidos

		private string _apellidos;
		[DebuggerNonUserCode]
		[Column(Storage = "_apellidos", Name = "Apellidos", DbType = "varchar(50)", AutoSync = AutoSync.Never)]
		public string Apellidos
		{
			get
			{
				return _apellidos;
			}
			set
			{
				if (value != _apellidos)
				{
					OnApellidosChanging(value);
					SendPropertyChanging();
					_apellidos = value;
					SendPropertyChanged("Apellidos");
					OnApellidosChanged();
				}
			}
		}

		#endregion

		#region string CI

		private string _ci;
		[DebuggerNonUserCode]
		[Column(Storage = "_ci", Name = "CI", DbType = "varchar(30)", IsPrimaryKey = true, AutoSync = AutoSync.Never, CanBeNull = false)]
		public string CI
		{
			get
			{
				return _ci;
			}
			set
			{
				if (value != _ci)
				{
					OnCIChanging(value);
					SendPropertyChanging();
					_ci = value;
					SendPropertyChanged("CI");
					OnCIChanged();
				}
			}
		}

		#endregion

		#region DateTime? FechaAlta

		private DateTime? _fechaAlta;
		[DebuggerNonUserCode]
		[Column(Storage = "_fechaAlta", Name = "FechaAlta", DbType = "date", AutoSync = AutoSync.Never)]
		public DateTime? FechaAlta
		{
			get
			{
				return _fechaAlta;
			}
			set
			{
				if (value != _fechaAlta)
				{
					OnFechaAltaChanging(value);
					SendPropertyChanging();
					_fechaAlta = value;
					SendPropertyChanged("FechaAlta");
					OnFechaAltaChanged();
				}
			}
		}

		#endregion

		#region DateTime? FechaBaja

		private DateTime? _fechaBaja;
		[DebuggerNonUserCode]
		[Column(Storage = "_fechaBaja", Name = "FechaBaja", DbType = "date", AutoSync = AutoSync.Never)]
		public DateTime? FechaBaja
		{
			get
			{
				return _fechaBaja;
			}
			set
			{
				if (value != _fechaBaja)
				{
					OnFechaBajaChanging(value);
					SendPropertyChanging();
					_fechaBaja = value;
					SendPropertyChanged("FechaBaja");
					OnFechaBajaChanged();
				}
			}
		}

		#endregion

		#region string MotivoRechazo

		private string _motivoRechazo;
		[DebuggerNonUserCode]
		[Column(Storage = "_motivoRechazo", Name = "MotivoRechazo", DbType = "varchar(100)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public string MotivoRechazo
		{
			get
			{
				return _motivoRechazo;
			}
			set
			{
				if (value != _motivoRechazo)
				{
					OnMotivoRechazoChanging(value);
					SendPropertyChanging();
					_motivoRechazo = value;
					SendPropertyChanged("MotivoRechazo");
					OnMotivoRechazoChanged();
				}
			}
		}

		#endregion

		#region string Nombres

		private string _nombres;
		[DebuggerNonUserCode]
		[Column(Storage = "_nombres", Name = "Nombres", DbType = "varchar(50)", AutoSync = AutoSync.Never)]
		public string Nombres
		{
			get
			{
				return _nombres;
			}
			set
			{
				if (value != _nombres)
				{
					OnNombresChanging(value);
					SendPropertyChanging();
					_nombres = value;
					SendPropertyChanged("Nombres");
					OnNombresChanged();
				}
			}
		}

		#endregion

		#region ctor

		public ListAnEGRa()
		{
			OnCreated();
		}

		#endregion

	}

	[Table(Name = "trustdb.logevento")]
	public partial class LogeVentO : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region INotifyPropertyChanging handling

		public event PropertyChangingEventHandler PropertyChanging;

		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs("");
		protected virtual void SendPropertyChanging()
		{
			if (PropertyChanging != null)
			{
				PropertyChanging(this, emptyChangingEventArgs);
			}
		}

		#endregion

		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void SendPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region Extensibility Method Definitions

		partial void OnCreated();
		partial void OnDescripcionChanged();
		partial void OnDescripcionChanging(string value);
		partial void OnEventoChanged();
		partial void OnEventoChanging(string value);
		partial void OnFechaChanged();
		partial void OnFechaChanging(DateTime value);
		partial void OnIDChanged();
		partial void OnIDChanging(long value);
		partial void OnUsernameChanged();
		partial void OnUsernameChanging(string value);

		#endregion

		#region string Descripcion

		private string _descripcion;
		[DebuggerNonUserCode]
		[Column(Storage = "_descripcion", Name = "Descripcion", DbType = "varchar(1000)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public string Descripcion
		{
			get
			{
				return _descripcion;
			}
			set
			{
				if (value != _descripcion)
				{
					OnDescripcionChanging(value);
					SendPropertyChanging();
					_descripcion = value;
					SendPropertyChanged("Descripcion");
					OnDescripcionChanged();
				}
			}
		}

		#endregion

		#region string Evento

		private string _evento;
		[DebuggerNonUserCode]
		[Column(Storage = "_evento", Name = "Evento", DbType = "varchar(100)", AutoSync = AutoSync.Never)]
		public string Evento
		{
			get
			{
				return _evento;
			}
			set
			{
				if (value != _evento)
				{
					OnEventoChanging(value);
					SendPropertyChanging();
					_evento = value;
					SendPropertyChanged("Evento");
					OnEventoChanged();
				}
			}
		}

		#endregion

		#region DateTime Fecha

		private DateTime _fecha;
		[DebuggerNonUserCode]
		[Column(Storage = "_fecha", Name = "Fecha", DbType = "datetime", AutoSync = AutoSync.Never, CanBeNull = false)]
		public DateTime Fecha
		{
			get
			{
				return _fecha;
			}
			set
			{
				if (value != _fecha)
				{
					OnFechaChanging(value);
					SendPropertyChanging();
					_fecha = value;
					SendPropertyChanged("Fecha");
					OnFechaChanged();
				}
			}
		}

		#endregion

		#region long ID

		private long _id;
		[DebuggerNonUserCode]
		[Column(Storage = "_id", Name = "Id", DbType = "bigint(20)", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false)]
		public long ID
		{
			get
			{
				return _id;
			}
			set
			{
				if (value != _id)
				{
					OnIDChanging(value);
					SendPropertyChanging();
					_id = value;
					SendPropertyChanged("ID");
					OnIDChanged();
				}
			}
		}

		#endregion

		#region string Username

		private string _username;
		[DebuggerNonUserCode]
		[Column(Storage = "_username", Name = "Username", DbType = "varchar(30)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public string Username
		{
			get
			{
				return _username;
			}
			set
			{
				if (value != _username)
				{
					OnUsernameChanging(value);
					SendPropertyChanging();
					_username = value;
					SendPropertyChanged("Username");
					OnUsernameChanged();
				}
			}
		}

		#endregion

		#region ctor

		public LogeVentO()
		{
			OnCreated();
		}

		#endregion

	}

	[Table(Name = "trustdb.motivoscambiosdiarios")]
	public partial class MotIVOsCamBiosDiARioS : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region INotifyPropertyChanging handling

		public event PropertyChangingEventHandler PropertyChanging;

		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs("");
		protected virtual void SendPropertyChanging()
		{
			if (PropertyChanging != null)
			{
				PropertyChanging(this, emptyChangingEventArgs);
			}
		}

		#endregion

		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void SendPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region Extensibility Method Definitions

		partial void OnCreated();
		partial void OnFechaCambioChanged();
		partial void OnFechaCambioChanging(DateTime value);
		partial void OnFechaCorrespondeChanged();
		partial void OnFechaCorrespondeChanging(DateTime value);
		partial void OnIDMotivoCambioDiarioChanged();
		partial void OnIDMotivoCambioDiarioChanging(int value);
		partial void OnIDTipoMotivoChanged();
		partial void OnIDTipoMotivoChanging(uint value);
		partial void OnNroEmpleadoChanged();
		partial void OnNroEmpleadoChanging(uint value);
		partial void OnNumeroClienteChanged();
		partial void OnNumeroClienteChanging(uint value);
		partial void OnNumeroServicioChanged();
		partial void OnNumeroServicioChanging(uint value);
		partial void OnObservacionesChanged();
		partial void OnObservacionesChanging(string value);

		#endregion

		#region DateTime FechaCambio

		private DateTime _fechaCambio;
		[DebuggerNonUserCode]
		[Column(Storage = "_fechaCambio", Name = "FechaCambio", DbType = "datetime", AutoSync = AutoSync.Never, CanBeNull = false)]
		public DateTime FechaCambio
		{
			get
			{
				return _fechaCambio;
			}
			set
			{
				if (value != _fechaCambio)
				{
					OnFechaCambioChanging(value);
					SendPropertyChanging();
					_fechaCambio = value;
					SendPropertyChanged("FechaCambio");
					OnFechaCambioChanged();
				}
			}
		}

		#endregion

		#region DateTime FechaCorresponde

		private DateTime _fechaCorresponde;
		[DebuggerNonUserCode]
		[Column(Storage = "_fechaCorresponde", Name = "FechaCorresponde", DbType = "date", AutoSync = AutoSync.Never, CanBeNull = false)]
		public DateTime FechaCorresponde
		{
			get
			{
				return _fechaCorresponde;
			}
			set
			{
				if (value != _fechaCorresponde)
				{
					OnFechaCorrespondeChanging(value);
					SendPropertyChanging();
					_fechaCorresponde = value;
					SendPropertyChanged("FechaCorresponde");
					OnFechaCorrespondeChanged();
				}
			}
		}

		#endregion

		#region int IDMotivoCambioDiario

		private int _idmOtivoCambioDiario;
		[DebuggerNonUserCode]
		[Column(Storage = "_idmOtivoCambioDiario", Name = "IdMotivoCambioDiario", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false)]
		public int IDMotivoCambioDiario
		{
			get
			{
				return _idmOtivoCambioDiario;
			}
			set
			{
				if (value != _idmOtivoCambioDiario)
				{
					OnIDMotivoCambioDiarioChanging(value);
					SendPropertyChanging();
					_idmOtivoCambioDiario = value;
					SendPropertyChanged("IDMotivoCambioDiario");
					OnIDMotivoCambioDiarioChanged();
				}
			}
		}

		#endregion

		#region uint IDTipoMotivo

		private uint _idtIpoMotivo;
		[DebuggerNonUserCode]
		[Column(Storage = "_idtIpoMotivo", Name = "IdTipoMotivo", DbType = "mediumint unsigned", AutoSync = AutoSync.Never, CanBeNull = false)]
		public uint IDTipoMotivo
		{
			get
			{
				return _idtIpoMotivo;
			}
			set
			{
				if (value != _idtIpoMotivo)
				{
					OnIDTipoMotivoChanging(value);
					SendPropertyChanging();
					_idtIpoMotivo = value;
					SendPropertyChanged("IDTipoMotivo");
					OnIDTipoMotivoChanged();
				}
			}
		}

		#endregion

		#region uint NroEmpleado

		private uint _nroEmpleado;
		[DebuggerNonUserCode]
		[Column(Storage = "_nroEmpleado", Name = "NroEmpleado", DbType = "mediumint unsigned", AutoSync = AutoSync.Never, CanBeNull = false)]
		public uint NroEmpleado
		{
			get
			{
				return _nroEmpleado;
			}
			set
			{
				if (value != _nroEmpleado)
				{
					if (_emPleadOs.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					OnNroEmpleadoChanging(value);
					SendPropertyChanging();
					_nroEmpleado = value;
					SendPropertyChanged("NroEmpleado");
					OnNroEmpleadoChanged();
				}
			}
		}

		#endregion

		#region uint NumeroCliente

		private uint _numeroCliente;
		[DebuggerNonUserCode]
		[Column(Storage = "_numeroCliente", Name = "NumeroCliente", DbType = "mediumint unsigned", AutoSync = AutoSync.Never, CanBeNull = false)]
		public uint NumeroCliente
		{
			get
			{
				return _numeroCliente;
			}
			set
			{
				if (value != _numeroCliente)
				{
					if (_servIcIoS.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					OnNumeroClienteChanging(value);
					SendPropertyChanging();
					_numeroCliente = value;
					SendPropertyChanged("NumeroCliente");
					OnNumeroClienteChanged();
				}
			}
		}

		#endregion

		#region uint NumeroServicio

		private uint _numeroServicio;
		[DebuggerNonUserCode]
		[Column(Storage = "_numeroServicio", Name = "NumeroServicio", DbType = "mediumint unsigned", AutoSync = AutoSync.Never, CanBeNull = false)]
		public uint NumeroServicio
		{
			get
			{
				return _numeroServicio;
			}
			set
			{
				if (value != _numeroServicio)
				{
					if (_servIcIoS.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					OnNumeroServicioChanging(value);
					SendPropertyChanging();
					_numeroServicio = value;
					SendPropertyChanged("NumeroServicio");
					OnNumeroServicioChanged();
				}
			}
		}

		#endregion

		#region string Observaciones

		private string _observaciones;
		[DebuggerNonUserCode]
		[Column(Storage = "_observaciones", Name = "Observaciones", DbType = "varchar(1000)", AutoSync = AutoSync.Never)]
		public string Observaciones
		{
			get
			{
				return _observaciones;
			}
			set
			{
				if (value != _observaciones)
				{
					OnObservacionesChanging(value);
					SendPropertyChanging();
					_observaciones = value;
					SendPropertyChanged("Observaciones");
					OnObservacionesChanged();
				}
			}
		}

		#endregion

		#region Parents

		private EntityRef<TipOsMotIVOCamBIoDiARio> _tipOsMotIvocAmBiODiArIo;
		[Association(Storage = "_tipOsMotIvocAmBiODiArIo", OtherKey = "IDTipoMotivo", ThisKey = "IDTipoMotivo", Name = "motivoscambiosdiarios_ibfk_1", IsForeignKey = true)]
		[DebuggerNonUserCode]
		public TipOsMotIVOCamBIoDiARio TipOsMotIVOCamBIoDiARio
		{
			get
			{
				return _tipOsMotIvocAmBiODiArIo.Entity;
			}
			set
			{
				if (value != _tipOsMotIvocAmBiODiArIo.Entity)
				{
					if (_tipOsMotIvocAmBiODiArIo.Entity != null)
					{
						var previousTipOsMotIVOCamBIoDiARio = _tipOsMotIvocAmBiODiArIo.Entity;
						_tipOsMotIvocAmBiODiArIo.Entity = null;
						previousTipOsMotIVOCamBIoDiARio.MotIVOsCamBiosDiARioS.Remove(this);
					}
					_tipOsMotIvocAmBiODiArIo.Entity = value;
					if (value != null)
					{
						value.MotIVOsCamBiosDiARioS.Add(this);
						_idtIpoMotivo = value.IDTipoMotivo;
					}
					else
					{
						_idtIpoMotivo = default(uint);
					}
				}
			}
		}

		private EntityRef<SERVicIoS> _servIcIoS;
		[Association(Storage = "_servIcIoS", OtherKey = "NumeroCliente,NumeroServicio", ThisKey = "NumeroCliente,NumeroServicio", Name = "motivoscambiosdiarios_ibfk_2", IsForeignKey = true)]
		[DebuggerNonUserCode]
		public SERVicIoS SERVicIoS
		{
			get
			{
				return _servIcIoS.Entity;
			}
			set
			{
				if (value != _servIcIoS.Entity)
				{
					if (_servIcIoS.Entity != null)
					{
						var previousSERVicIoS = _servIcIoS.Entity;
						_servIcIoS.Entity = null;
						previousSERVicIoS.MotIVOsCamBiosDiARioS.Remove(this);
					}
					_servIcIoS.Entity = value;
					if (value != null)
					{
						value.MotIVOsCamBiosDiARioS.Add(this);
						_numeroCliente = value.NumeroCliente;
						_numeroServicio = value.NumeroServicio;
					}
					else
					{
						_numeroCliente = default(uint);
						_numeroServicio = default(uint);
					}
				}
			}
		}

		private EntityRef<EmPleadOs> _emPleadOs;
		[Association(Storage = "_emPleadOs", OtherKey = "NroEmpleado", ThisKey = "NroEmpleado", Name = "motivoscambiosdiarios_ibfk_3", IsForeignKey = true)]
		[DebuggerNonUserCode]
		public EmPleadOs EmPleadOs
		{
			get
			{
				return _emPleadOs.Entity;
			}
			set
			{
				if (value != _emPleadOs.Entity)
				{
					if (_emPleadOs.Entity != null)
					{
						var previousEmPleadOs = _emPleadOs.Entity;
						_emPleadOs.Entity = null;
						previousEmPleadOs.MotIVOsCamBiosDiARioS.Remove(this);
					}
					_emPleadOs.Entity = value;
					if (value != null)
					{
						value.MotIVOsCamBiosDiARioS.Add(this);
						_nroEmpleado = value.NroEmpleado;
					}
					else
					{
						_nroEmpleado = default(uint);
					}
				}
			}
		}


		#endregion

		#region ctor

		public MotIVOsCamBiosDiARioS()
		{
			_tipOsMotIvocAmBiODiArIo = new EntityRef<TipOsMotIVOCamBIoDiARio>();
			_servIcIoS = new EntityRef<SERVicIoS>();
			_emPleadOs = new EntityRef<EmPleadOs>();
			OnCreated();
		}

		#endregion

	}

	[Table(Name = "trustdb.mutualistas")]
	public partial class MutualIsTAs : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region INotifyPropertyChanging handling

		public event PropertyChangingEventHandler PropertyChanging;

		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs("");
		protected virtual void SendPropertyChanging()
		{
			if (PropertyChanging != null)
			{
				PropertyChanging(this, emptyChangingEventArgs);
			}
		}

		#endregion

		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void SendPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region Extensibility Method Definitions

		partial void OnCreated();
		partial void OnIDMutualistaChanged();
		partial void OnIDMutualistaChanging(byte value);
		partial void OnNombreChanged();
		partial void OnNombreChanging(string value);

		#endregion

		#region byte IDMutualista

		private byte _idmUtualista;
		[DebuggerNonUserCode]
		[Column(Storage = "_idmUtualista", Name = "IdMutualista", DbType = "tinyint(2) unsigned", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false)]
		public byte IDMutualista
		{
			get
			{
				return _idmUtualista;
			}
			set
			{
				if (value != _idmUtualista)
				{
					OnIDMutualistaChanging(value);
					SendPropertyChanging();
					_idmUtualista = value;
					SendPropertyChanged("IDMutualista");
					OnIDMutualistaChanged();
				}
			}
		}

		#endregion

		#region string Nombre

		private string _nombre;
		[DebuggerNonUserCode]
		[Column(Storage = "_nombre", Name = "Nombre", DbType = "varchar(50)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public string Nombre
		{
			get
			{
				return _nombre;
			}
			set
			{
				if (value != _nombre)
				{
					OnNombreChanging(value);
					SendPropertyChanging();
					_nombre = value;
					SendPropertyChanged("Nombre");
					OnNombreChanged();
				}
			}
		}

		#endregion

		#region ctor

		public MutualIsTAs()
		{
			OnCreated();
		}

		#endregion

	}

	[Table(Name = "trustdb.pantallawinform")]
	public partial class PantAllAwInForm : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region INotifyPropertyChanging handling

		public event PropertyChangingEventHandler PropertyChanging;

		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs("");
		protected virtual void SendPropertyChanging()
		{
			if (PropertyChanging != null)
			{
				PropertyChanging(this, emptyChangingEventArgs);
			}
		}

		#endregion

		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void SendPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region Extensibility Method Definitions

		partial void OnCreated();
		partial void OnActivoChanged();
		partial void OnActivoChanging(sbyte value);
		partial void OnDescripcionChanged();
		partial void OnDescripcionChanging(string value);
		partial void OnIDPantallaWinFormChanged();
		partial void OnIDPantallaWinFormChanging(int value);
		partial void OnNombreChanged();
		partial void OnNombreChanging(string value);

		#endregion

		#region sbyte Activo

		private sbyte _activo;
		[DebuggerNonUserCode]
		[Column(Storage = "_activo", Name = "Activo", DbType = "tinyint(1)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public sbyte Activo
		{
			get
			{
				return _activo;
			}
			set
			{
				if (value != _activo)
				{
					OnActivoChanging(value);
					SendPropertyChanging();
					_activo = value;
					SendPropertyChanged("Activo");
					OnActivoChanged();
				}
			}
		}

		#endregion

		#region string Descripcion

		private string _descripcion;
		[DebuggerNonUserCode]
		[Column(Storage = "_descripcion", Name = "Descripcion", DbType = "varchar(100)", AutoSync = AutoSync.Never)]
		public string Descripcion
		{
			get
			{
				return _descripcion;
			}
			set
			{
				if (value != _descripcion)
				{
					OnDescripcionChanging(value);
					SendPropertyChanging();
					_descripcion = value;
					SendPropertyChanged("Descripcion");
					OnDescripcionChanged();
				}
			}
		}

		#endregion

		#region int IDPantallaWinForm

		private int _idpAntallaWinForm;
		[DebuggerNonUserCode]
		[Column(Storage = "_idpAntallaWinForm", Name = "idPantallaWinForm", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false)]
		public int IDPantallaWinForm
		{
			get
			{
				return _idpAntallaWinForm;
			}
			set
			{
				if (value != _idpAntallaWinForm)
				{
					OnIDPantallaWinFormChanging(value);
					SendPropertyChanging();
					_idpAntallaWinForm = value;
					SendPropertyChanged("IDPantallaWinForm");
					OnIDPantallaWinFormChanged();
				}
			}
		}

		#endregion

		#region string Nombre

		private string _nombre;
		[DebuggerNonUserCode]
		[Column(Storage = "_nombre", Name = "Nombre", DbType = "varchar(45)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public string Nombre
		{
			get
			{
				return _nombre;
			}
			set
			{
				if (value != _nombre)
				{
					OnNombreChanging(value);
					SendPropertyChanging();
					_nombre = value;
					SendPropertyChanged("Nombre");
					OnNombreChanged();
				}
			}
		}

		#endregion

		#region Children

		private EntitySet<PerMisOControl> _perMisOcOntrol;
		[Association(Storage = "_perMisOcOntrol", OtherKey = "IDPantallaWinForm", ThisKey = "IDPantallaWinForm", Name = "FK_idPantallaWinForm")]
		[DebuggerNonUserCode]
		public EntitySet<PerMisOControl> PerMisOControl
		{
			get
			{
				return _perMisOcOntrol;
			}
			set
			{
				_perMisOcOntrol = value;
			}
		}


		#endregion

		#region Attachement handlers

		private void PerMisOControl_Attach(PerMisOControl entity)
		{
			entity.PantAllAwInForm = this;
		}

		private void PerMisOControl_Detach(PerMisOControl entity)
		{
			entity.PantAllAwInForm = null;
		}


		#endregion

		#region ctor

		public PantAllAwInForm()
		{
			_perMisOcOntrol = new EntitySet<PerMisOControl>(PerMisOControl_Attach, PerMisOControl_Detach);
			OnCreated();
		}

		#endregion

	}

	[Table(Name = "trustdb.permisocontrol")]
	public partial class PerMisOControl : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region INotifyPropertyChanging handling

		public event PropertyChangingEventHandler PropertyChanging;

		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs("");
		protected virtual void SendPropertyChanging()
		{
			if (PropertyChanging != null)
			{
				PropertyChanging(this, emptyChangingEventArgs);
			}
		}

		#endregion

		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void SendPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region Extensibility Method Definitions

		partial void OnCreated();
		partial void OnIDPantallaWinFormChanged();
		partial void OnIDPantallaWinFormChanging(int value);
		partial void OnIDPermisoControlChanged();
		partial void OnIDPermisoControlChanging(int value);
		partial void OnNettYpeChanged();
		partial void OnNettYpeChanging(string value);
		partial void OnNombreChanged();
		partial void OnNombreChanging(string value);
		partial void OnNombreVisualChanged();
		partial void OnNombreVisualChanging(string value);

		#endregion

		#region int IDPantallaWinForm

		private int _idpAntallaWinForm;
		[DebuggerNonUserCode]
		[Column(Storage = "_idpAntallaWinForm", Name = "idPantallaWinForm", DbType = "int", AutoSync = AutoSync.Never, CanBeNull = false)]
		public int IDPantallaWinForm
		{
			get
			{
				return _idpAntallaWinForm;
			}
			set
			{
				if (value != _idpAntallaWinForm)
				{
					OnIDPantallaWinFormChanging(value);
					SendPropertyChanging();
					_idpAntallaWinForm = value;
					SendPropertyChanged("IDPantallaWinForm");
					OnIDPantallaWinFormChanged();
				}
			}
		}

		#endregion

		#region int IDPermisoControl

		private int _idpErmisoControl;
		[DebuggerNonUserCode]
		[Column(Storage = "_idpErmisoControl", Name = "idPermisoControl", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false)]
		public int IDPermisoControl
		{
			get
			{
				return _idpErmisoControl;
			}
			set
			{
				if (value != _idpErmisoControl)
				{
					OnIDPermisoControlChanging(value);
					SendPropertyChanging();
					_idpErmisoControl = value;
					SendPropertyChanged("IDPermisoControl");
					OnIDPermisoControlChanged();
				}
			}
		}

		#endregion

		#region string NettYpe

		private string _nettYpe;
		[DebuggerNonUserCode]
		[Column(Storage = "_nettYpe", Name = "NETType", DbType = "varchar(100)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public string NettYpe
		{
			get
			{
				return _nettYpe;
			}
			set
			{
				if (value != _nettYpe)
				{
					OnNettYpeChanging(value);
					SendPropertyChanging();
					_nettYpe = value;
					SendPropertyChanged("NettYpe");
					OnNettYpeChanged();
				}
			}
		}

		#endregion

		#region string Nombre

		private string _nombre;
		[DebuggerNonUserCode]
		[Column(Storage = "_nombre", Name = "Nombre", DbType = "varchar(45)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public string Nombre
		{
			get
			{
				return _nombre;
			}
			set
			{
				if (value != _nombre)
				{
					OnNombreChanging(value);
					SendPropertyChanging();
					_nombre = value;
					SendPropertyChanged("Nombre");
					OnNombreChanged();
				}
			}
		}

		#endregion

		#region string NombreVisual

		private string _nombreVisual;
		[DebuggerNonUserCode]
		[Column(Storage = "_nombreVisual", Name = "NombreVisual", DbType = "varchar(100)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public string NombreVisual
		{
			get
			{
				return _nombreVisual;
			}
			set
			{
				if (value != _nombreVisual)
				{
					OnNombreVisualChanging(value);
					SendPropertyChanging();
					_nombreVisual = value;
					SendPropertyChanged("NombreVisual");
					OnNombreVisualChanged();
				}
			}
		}

		#endregion

		#region Parents

		private EntityRef<PantAllAwInForm> _pantAllAwInForm;
		[Association(Storage = "_pantAllAwInForm", OtherKey = "IDPantallaWinForm", ThisKey = "IDPantallaWinForm", Name = "FK_idPantallaWinForm", IsForeignKey = true)]
		[DebuggerNonUserCode]
		public PantAllAwInForm PantAllAwInForm
		{
			get
			{
				return _pantAllAwInForm.Entity;
			}
			set
			{
				if (value != _pantAllAwInForm.Entity)
				{
					if (_pantAllAwInForm.Entity != null)
					{
						var previousPantAllAwInForm = _pantAllAwInForm.Entity;
						_pantAllAwInForm.Entity = null;
						previousPantAllAwInForm.PerMisOControl.Remove(this);
					}
					_pantAllAwInForm.Entity = value;
					if (value != null)
					{
						value.PerMisOControl.Add(this);
						_idpAntallaWinForm = value.IDPantallaWinForm;
					}
					else
					{
						_idpAntallaWinForm = default(int);
					}
				}
			}
		}


		#endregion

		#region ctor

		public PerMisOControl()
		{
			_pantAllAwInForm = new EntityRef<PantAllAwInForm>();
			OnCreated();
		}

		#endregion

	}

	[Table(Name = "trustdb.permisos")]
	public partial class PerMisOs : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region INotifyPropertyChanging handling

		public event PropertyChangingEventHandler PropertyChanging;

		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs("");
		protected virtual void SendPropertyChanging()
		{
			if (PropertyChanging != null)
			{
				PropertyChanging(this, emptyChangingEventArgs);
			}
		}

		#endregion

		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void SendPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region Extensibility Method Definitions

		partial void OnCreated();
		partial void OnActivoChanged();
		partial void OnActivoChanging(sbyte value);
		partial void OnIDControlChanged();
		partial void OnIDControlChanging(int value);
		partial void OnIDPermisoChanged();
		partial void OnIDPermisoChanging(int value);
		partial void OnUsuarioOrgRupoChanged();
		partial void OnUsuarioOrgRupoChanging(string value);
		partial void OnWinFormOrcOntrolChanged();
		partial void OnWinFormOrcOntrolChanging(string value);

		#endregion

		#region sbyte Activo

		private sbyte _activo;
		[DebuggerNonUserCode]
		[Column(Storage = "_activo", Name = "Activo", DbType = "tinyint(1)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public sbyte Activo
		{
			get
			{
				return _activo;
			}
			set
			{
				if (value != _activo)
				{
					OnActivoChanging(value);
					SendPropertyChanging();
					_activo = value;
					SendPropertyChanged("Activo");
					OnActivoChanged();
				}
			}
		}

		#endregion

		#region int IDControl

		private int _idcOntrol;
		[DebuggerNonUserCode]
		[Column(Storage = "_idcOntrol", Name = "idControl", DbType = "int", IsPrimaryKey = true, AutoSync = AutoSync.Never, CanBeNull = false)]
		public int IDControl
		{
			get
			{
				return _idcOntrol;
			}
			set
			{
				if (value != _idcOntrol)
				{
					OnIDControlChanging(value);
					SendPropertyChanging();
					_idcOntrol = value;
					SendPropertyChanged("IDControl");
					OnIDControlChanged();
				}
			}
		}

		#endregion

		#region int IDPermiso

		private int _idpErmiso;
		[DebuggerNonUserCode]
		[Column(Storage = "_idpErmiso", Name = "idPermiso", DbType = "int", IsPrimaryKey = true, AutoSync = AutoSync.Never, CanBeNull = false)]
		public int IDPermiso
		{
			get
			{
				return _idpErmiso;
			}
			set
			{
				if (value != _idpErmiso)
				{
					OnIDPermisoChanging(value);
					SendPropertyChanging();
					_idpErmiso = value;
					SendPropertyChanged("IDPermiso");
					OnIDPermisoChanged();
				}
			}
		}

		#endregion

		#region string UsuarioOrgRupo

		private string _usuarioOrgRupo;
		[DebuggerNonUserCode]
		[Column(Storage = "_usuarioOrgRupo", Name = "Usuario_OR_Grupo", DbType = "char(1)", IsPrimaryKey = true, AutoSync = AutoSync.Never, CanBeNull = false)]
		public string UsuarioOrgRupo
		{
			get
			{
				return _usuarioOrgRupo;
			}
			set
			{
				if (value != _usuarioOrgRupo)
				{
					OnUsuarioOrgRupoChanging(value);
					SendPropertyChanging();
					_usuarioOrgRupo = value;
					SendPropertyChanged("UsuarioOrgRupo");
					OnUsuarioOrgRupoChanged();
				}
			}
		}

		#endregion

		#region string WinFormOrcOntrol

		private string _winFormOrcOntrol;
		[DebuggerNonUserCode]
		[Column(Storage = "_winFormOrcOntrol", Name = "WinForm_OR_Control", DbType = "char(1)", IsPrimaryKey = true, AutoSync = AutoSync.Never, CanBeNull = false)]
		public string WinFormOrcOntrol
		{
			get
			{
				return _winFormOrcOntrol;
			}
			set
			{
				if (value != _winFormOrcOntrol)
				{
					OnWinFormOrcOntrolChanging(value);
					SendPropertyChanging();
					_winFormOrcOntrol = value;
					SendPropertyChanged("WinFormOrcOntrol");
					OnWinFormOrcOntrolChanged();
				}
			}
		}

		#endregion

		#region ctor

		public PerMisOs()
		{
			OnCreated();
		}

		#endregion

	}

	[Table(Name = "trustdb.servicios")]
	public partial class SERVicIoS : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region INotifyPropertyChanging handling

		public event PropertyChangingEventHandler PropertyChanging;

		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs("");
		protected virtual void SendPropertyChanging()
		{
			if (PropertyChanging != null)
			{
				PropertyChanging(this, emptyChangingEventArgs);
			}
		}

		#endregion

		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void SendPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region Extensibility Method Definitions

		partial void OnCreated();
		partial void OnActivoChanged();
		partial void OnActivoChanging(sbyte? value);
		partial void OnCelularChanged();
		partial void OnCelularChanging(string value);
		partial void OnCelularTrustChanged();
		partial void OnCelularTrustChanging(string value);
		partial void OnDireccionChanged();
		partial void OnDireccionChanging(string value);
		partial void OnEmailChanged();
		partial void OnEmailChanging(string value);
		partial void OnEntreCallesChanged();
		partial void OnEntreCallesChanging(string value);
		partial void OnFechaAltaChanged();
		partial void OnFechaAltaChanging(DateTime? value);
		partial void OnFechaBajaChanged();
		partial void OnFechaBajaChanging(DateTime? value);
		partial void OnMotivoBajaChanged();
		partial void OnMotivoBajaChanging(string value);
		partial void OnNombreChanged();
		partial void OnNombreChanging(string value);
		partial void OnNombreCobrarChanged();
		partial void OnNombreCobrarChanging(string value);
		partial void OnNumeroClienteChanged();
		partial void OnNumeroClienteChanging(uint value);
		partial void OnNumeroServicioChanged();
		partial void OnNumeroServicioChanging(uint value);
		partial void OnObservacionesChanged();
		partial void OnObservacionesChanging(string value);
		partial void OnPersonaContactoChanged();
		partial void OnPersonaContactoChanging(string value);
		partial void OnTareasAsignadasChanged();
		partial void OnTareasAsignadasChanging(string value);
		partial void OnTelefonosChanged();
		partial void OnTelefonosChanging(string value);

		#endregion

		#region sbyte? Activo

		private sbyte? _activo;
		[DebuggerNonUserCode]
		[Column(Storage = "_activo", Name = "Activo", DbType = "tinyint(1)", AutoSync = AutoSync.Never)]
		public sbyte? Activo
		{
			get
			{
				return _activo;
			}
			set
			{
				if (value != _activo)
				{
					OnActivoChanging(value);
					SendPropertyChanging();
					_activo = value;
					SendPropertyChanged("Activo");
					OnActivoChanged();
				}
			}
		}

		#endregion

		#region string Celular

		private string _celular;
		[DebuggerNonUserCode]
		[Column(Storage = "_celular", Name = "Celular", DbType = "varchar(50)", AutoSync = AutoSync.Never)]
		public string Celular
		{
			get
			{
				return _celular;
			}
			set
			{
				if (value != _celular)
				{
					OnCelularChanging(value);
					SendPropertyChanging();
					_celular = value;
					SendPropertyChanged("Celular");
					OnCelularChanged();
				}
			}
		}

		#endregion

		#region string CelularTrust

		private string _celularTrust;
		[DebuggerNonUserCode]
		[Column(Storage = "_celularTrust", Name = "CelularTrust", DbType = "varchar(50)", AutoSync = AutoSync.Never)]
		public string CelularTrust
		{
			get
			{
				return _celularTrust;
			}
			set
			{
				if (value != _celularTrust)
				{
					OnCelularTrustChanging(value);
					SendPropertyChanging();
					_celularTrust = value;
					SendPropertyChanged("CelularTrust");
					OnCelularTrustChanged();
				}
			}
		}

		#endregion

		#region string Direccion

		private string _direccion;
		[DebuggerNonUserCode]
		[Column(Storage = "_direccion", Name = "Direccion", DbType = "varchar(100)", AutoSync = AutoSync.Never)]
		public string Direccion
		{
			get
			{
				return _direccion;
			}
			set
			{
				if (value != _direccion)
				{
					OnDireccionChanging(value);
					SendPropertyChanging();
					_direccion = value;
					SendPropertyChanged("Direccion");
					OnDireccionChanged();
				}
			}
		}

		#endregion

		#region string Email

		private string _email;
		[DebuggerNonUserCode]
		[Column(Storage = "_email", Name = "Email", DbType = "varchar(50)", AutoSync = AutoSync.Never)]
		public string Email
		{
			get
			{
				return _email;
			}
			set
			{
				if (value != _email)
				{
					OnEmailChanging(value);
					SendPropertyChanging();
					_email = value;
					SendPropertyChanged("Email");
					OnEmailChanged();
				}
			}
		}

		#endregion

		#region string EntreCalles

		private string _entreCalles;
		[DebuggerNonUserCode]
		[Column(Storage = "_entreCalles", Name = "EntreCalles", DbType = "varchar(150)", AutoSync = AutoSync.Never)]
		public string EntreCalles
		{
			get
			{
				return _entreCalles;
			}
			set
			{
				if (value != _entreCalles)
				{
					OnEntreCallesChanging(value);
					SendPropertyChanging();
					_entreCalles = value;
					SendPropertyChanged("EntreCalles");
					OnEntreCallesChanged();
				}
			}
		}

		#endregion

		#region DateTime? FechaAlta

		private DateTime? _fechaAlta;
		[DebuggerNonUserCode]
		[Column(Storage = "_fechaAlta", Name = "FechaAlta", DbType = "date", AutoSync = AutoSync.Never)]
		public DateTime? FechaAlta
		{
			get
			{
				return _fechaAlta;
			}
			set
			{
				if (value != _fechaAlta)
				{
					OnFechaAltaChanging(value);
					SendPropertyChanging();
					_fechaAlta = value;
					SendPropertyChanged("FechaAlta");
					OnFechaAltaChanged();
				}
			}
		}

		#endregion

		#region DateTime? FechaBaja

		private DateTime? _fechaBaja;
		[DebuggerNonUserCode]
		[Column(Storage = "_fechaBaja", Name = "FechaBaja", DbType = "date", AutoSync = AutoSync.Never)]
		public DateTime? FechaBaja
		{
			get
			{
				return _fechaBaja;
			}
			set
			{
				if (value != _fechaBaja)
				{
					OnFechaBajaChanging(value);
					SendPropertyChanging();
					_fechaBaja = value;
					SendPropertyChanged("FechaBaja");
					OnFechaBajaChanged();
				}
			}
		}

		#endregion

		#region string MotivoBaja

		private string _motivoBaja;
		[DebuggerNonUserCode]
		[Column(Storage = "_motivoBaja", Name = "MotivoBaja", DbType = "varchar(255)", AutoSync = AutoSync.Never)]
		public string MotivoBaja
		{
			get
			{
				return _motivoBaja;
			}
			set
			{
				if (value != _motivoBaja)
				{
					OnMotivoBajaChanging(value);
					SendPropertyChanging();
					_motivoBaja = value;
					SendPropertyChanged("MotivoBaja");
					OnMotivoBajaChanged();
				}
			}
		}

		#endregion

		#region string Nombre

		private string _nombre;
		[DebuggerNonUserCode]
		[Column(Storage = "_nombre", Name = "Nombre", DbType = "varchar(100)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public string Nombre
		{
			get
			{
				return _nombre;
			}
			set
			{
				if (value != _nombre)
				{
					OnNombreChanging(value);
					SendPropertyChanging();
					_nombre = value;
					SendPropertyChanged("Nombre");
					OnNombreChanged();
				}
			}
		}

		#endregion

		#region string NombreCobrar

		private string _nombreCobrar;
		[DebuggerNonUserCode]
		[Column(Storage = "_nombreCobrar", Name = "NombreCobrar", DbType = "varchar(50)", AutoSync = AutoSync.Never)]
		public string NombreCobrar
		{
			get
			{
				return _nombreCobrar;
			}
			set
			{
				if (value != _nombreCobrar)
				{
					OnNombreCobrarChanging(value);
					SendPropertyChanging();
					_nombreCobrar = value;
					SendPropertyChanged("NombreCobrar");
					OnNombreCobrarChanged();
				}
			}
		}

		#endregion

		#region uint NumeroCliente

		private uint _numeroCliente;
		[DebuggerNonUserCode]
		[Column(Storage = "_numeroCliente", Name = "NumeroCliente", DbType = "mediumint unsigned", IsPrimaryKey = true, AutoSync = AutoSync.Never, CanBeNull = false)]
		public uint NumeroCliente
		{
			get
			{
				return _numeroCliente;
			}
			set
			{
				if (value != _numeroCliente)
				{
					if (_clientEs.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					OnNumeroClienteChanging(value);
					SendPropertyChanging();
					_numeroCliente = value;
					SendPropertyChanged("NumeroCliente");
					OnNumeroClienteChanged();
				}
			}
		}

		#endregion

		#region uint NumeroServicio

		private uint _numeroServicio;
		[DebuggerNonUserCode]
		[Column(Storage = "_numeroServicio", Name = "NumeroServicio", DbType = "mediumint unsigned", IsPrimaryKey = true, AutoSync = AutoSync.Never, CanBeNull = false)]
		public uint NumeroServicio
		{
			get
			{
				return _numeroServicio;
			}
			set
			{
				if (value != _numeroServicio)
				{
					OnNumeroServicioChanging(value);
					SendPropertyChanging();
					_numeroServicio = value;
					SendPropertyChanged("NumeroServicio");
					OnNumeroServicioChanged();
				}
			}
		}

		#endregion

		#region string Observaciones

		private string _observaciones;
		[DebuggerNonUserCode]
		[Column(Storage = "_observaciones", Name = "Observaciones", DbType = "varchar(255)", AutoSync = AutoSync.Never)]
		public string Observaciones
		{
			get
			{
				return _observaciones;
			}
			set
			{
				if (value != _observaciones)
				{
					OnObservacionesChanging(value);
					SendPropertyChanging();
					_observaciones = value;
					SendPropertyChanged("Observaciones");
					OnObservacionesChanged();
				}
			}
		}

		#endregion

		#region string PersonaContacto

		private string _personaContacto;
		[DebuggerNonUserCode]
		[Column(Storage = "_personaContacto", Name = "PersonaContacto", DbType = "varchar(50)", AutoSync = AutoSync.Never)]
		public string PersonaContacto
		{
			get
			{
				return _personaContacto;
			}
			set
			{
				if (value != _personaContacto)
				{
					OnPersonaContactoChanging(value);
					SendPropertyChanging();
					_personaContacto = value;
					SendPropertyChanged("PersonaContacto");
					OnPersonaContactoChanged();
				}
			}
		}

		#endregion

		#region string TareasAsignadas

		private string _tareasAsignadas;
		[DebuggerNonUserCode]
		[Column(Storage = "_tareasAsignadas", Name = "TareasAsignadas", DbType = "varchar(255)", AutoSync = AutoSync.Never)]
		public string TareasAsignadas
		{
			get
			{
				return _tareasAsignadas;
			}
			set
			{
				if (value != _tareasAsignadas)
				{
					OnTareasAsignadasChanging(value);
					SendPropertyChanging();
					_tareasAsignadas = value;
					SendPropertyChanged("TareasAsignadas");
					OnTareasAsignadasChanged();
				}
			}
		}

		#endregion

		#region string Telefonos

		private string _telefonos;
		[DebuggerNonUserCode]
		[Column(Storage = "_telefonos", Name = "Telefonos", DbType = "varchar(50)", AutoSync = AutoSync.Never)]
		public string Telefonos
		{
			get
			{
				return _telefonos;
			}
			set
			{
				if (value != _telefonos)
				{
					OnTelefonosChanging(value);
					SendPropertyChanging();
					_telefonos = value;
					SendPropertyChanged("Telefonos");
					OnTelefonosChanged();
				}
			}
		}

		#endregion

		#region Children

		private EntitySet<HoRaSGeneraDaSEScalaFOn> _hoRaSgEneraDaSesCalaFoN;
		[Association(Storage = "_hoRaSgEneraDaSesCalaFoN", OtherKey = "NumeroCliente,NumeroServicio", ThisKey = "NumeroCliente,NumeroServicio", Name = "horasgeneradasescalafon_ibfk_2")]
		[DebuggerNonUserCode]
		public EntitySet<HoRaSGeneraDaSEScalaFOn> HoRaSGeneraDaSEScalaFOn
		{
			get
			{
				return _hoRaSgEneraDaSesCalaFoN;
			}
			set
			{
				_hoRaSgEneraDaSesCalaFoN = value;
			}
		}

		private EntitySet<MotIVOsCamBiosDiARioS> _motIvoSCamBiosDiArIoS;
		[Association(Storage = "_motIvoSCamBiosDiArIoS", OtherKey = "NumeroCliente,NumeroServicio", ThisKey = "NumeroCliente,NumeroServicio", Name = "motivoscambiosdiarios_ibfk_2")]
		[DebuggerNonUserCode]
		public EntitySet<MotIVOsCamBiosDiARioS> MotIVOsCamBiosDiARioS
		{
			get
			{
				return _motIvoSCamBiosDiArIoS;
			}
			set
			{
				_motIvoSCamBiosDiArIoS = value;
			}
		}


		#endregion

		#region Parents

		private EntityRef<ClientEs> _clientEs;
		[Association(Storage = "_clientEs", OtherKey = "NumeroCliente", ThisKey = "NumeroCliente", Name = "fk_NumeroCliente_Clientes_NumeroCliente", IsForeignKey = true)]
		[DebuggerNonUserCode]
		public ClientEs ClientEs
		{
			get
			{
				return _clientEs.Entity;
			}
			set
			{
				if (value != _clientEs.Entity)
				{
					if (_clientEs.Entity != null)
					{
						var previousClientEs = _clientEs.Entity;
						_clientEs.Entity = null;
						previousClientEs.SERVicIoS.Remove(this);
					}
					_clientEs.Entity = value;
					if (value != null)
					{
						value.SERVicIoS.Add(this);
						_numeroCliente = value.NumeroCliente;
					}
					else
					{
						_numeroCliente = default(uint);
					}
				}
			}
		}


		#endregion

		#region Attachement handlers

		private void HoRaSGeneraDaSEScalaFOn_Attach(HoRaSGeneraDaSEScalaFOn entity)
		{
			entity.SERVicIoS = this;
		}

		private void HoRaSGeneraDaSEScalaFOn_Detach(HoRaSGeneraDaSEScalaFOn entity)
		{
			entity.SERVicIoS = null;
		}

		private void MotIVOsCamBiosDiARioS_Attach(MotIVOsCamBiosDiARioS entity)
		{
			entity.SERVicIoS = this;
		}

		private void MotIVOsCamBiosDiARioS_Detach(MotIVOsCamBiosDiARioS entity)
		{
			entity.SERVicIoS = null;
		}


		#endregion

		#region ctor

		public SERVicIoS()
		{
			_hoRaSgEneraDaSesCalaFoN = new EntitySet<HoRaSGeneraDaSEScalaFOn>(HoRaSGeneraDaSEScalaFOn_Attach, HoRaSGeneraDaSEScalaFOn_Detach);
			_motIvoSCamBiosDiArIoS = new EntitySet<MotIVOsCamBiosDiARioS>(MotIVOsCamBiosDiARioS_Attach, MotIVOsCamBiosDiARioS_Detach);
			_clientEs = new EntityRef<ClientEs>();
			OnCreated();
		}

		#endregion

	}

	[Table(Name = "trustdb.tipocontratos")]
	public partial class TipOContraToS : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region INotifyPropertyChanging handling

		public event PropertyChangingEventHandler PropertyChanging;

		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs("");
		protected virtual void SendPropertyChanging()
		{
			if (PropertyChanging != null)
			{
				PropertyChanging(this, emptyChangingEventArgs);
			}
		}

		#endregion

		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void SendPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region Extensibility Method Definitions

		partial void OnCreated();
		partial void OnDescripcionChanged();
		partial void OnDescripcionChanging(string value);
		partial void OnIDChanged();
		partial void OnIDChanging(int value);

		#endregion

		#region string Descripcion

		private string _descripcion;
		[DebuggerNonUserCode]
		[Column(Storage = "_descripcion", Name = "Descripcion", DbType = "varchar(50)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public string Descripcion
		{
			get
			{
				return _descripcion;
			}
			set
			{
				if (value != _descripcion)
				{
					OnDescripcionChanging(value);
					SendPropertyChanging();
					_descripcion = value;
					SendPropertyChanged("Descripcion");
					OnDescripcionChanged();
				}
			}
		}

		#endregion

		#region int ID

		private int _id;
		[DebuggerNonUserCode]
		[Column(Storage = "_id", Name = "Id", DbType = "int", IsPrimaryKey = true, AutoSync = AutoSync.Never, CanBeNull = false)]
		public int ID
		{
			get
			{
				return _id;
			}
			set
			{
				if (value != _id)
				{
					OnIDChanging(value);
					SendPropertyChanging();
					_id = value;
					SendPropertyChanged("ID");
					OnIDChanged();
				}
			}
		}

		#endregion

		#region Children

		private EntitySet<ContraToS> _contraToS;
		[Association(Storage = "_contraToS", OtherKey = "TipodeContrato", ThisKey = "ID", Name = "Id")]
		[DebuggerNonUserCode]
		public EntitySet<ContraToS> ContraToS
		{
			get
			{
				return _contraToS;
			}
			set
			{
				_contraToS = value;
			}
		}


		#endregion

		#region Attachement handlers

		private void ContraToS_Attach(ContraToS entity)
		{
			entity.TipOContraToS = this;
		}

		private void ContraToS_Detach(ContraToS entity)
		{
			entity.TipOContraToS = null;
		}


		#endregion

		#region ctor

		public TipOContraToS()
		{
			_contraToS = new EntitySet<ContraToS>(ContraToS_Attach, ContraToS_Detach);
			OnCreated();
		}

		#endregion

	}

	[Table(Name = "trustdb.tipoempleado")]
	public partial class TipOeMpLeadO : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region INotifyPropertyChanging handling

		public event PropertyChangingEventHandler PropertyChanging;

		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs("");
		protected virtual void SendPropertyChanging()
		{
			if (PropertyChanging != null)
			{
				PropertyChanging(this, emptyChangingEventArgs);
			}
		}

		#endregion

		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void SendPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region Custom type definition for TipoType

		public enum TipoType
		{
			MENSUAL,
			JORNALERO,
		}

		#endregion

		#region Extensibility Method Definitions

		partial void OnCreated();
		partial void OnCantidadHsComunesChanged();
		partial void OnCantidadHsComunesChanging(float value);
		partial void OnCobraHsExtrasChanged();
		partial void OnCobraHsExtrasChanging(sbyte? value);
		partial void OnDescripcionChanged();
		partial void OnDescripcionChanging(string value);
		partial void OnFulltimeChanged();
		partial void OnFulltimeChanging(sbyte? value);
		partial void OnIDTipoEmpleadoChanged();
		partial void OnIDTipoEmpleadoChanging(sbyte value);
		partial void OnNombreTipoChanged();
		partial void OnNombreTipoChanging(string value);
		partial void OnTipoChanged();
		partial void OnTipoChanging(TipoType value);

		#endregion

		#region float CantidadHsComunes

		private float _cantidadHsComunes;
		[DebuggerNonUserCode]
		[Column(Storage = "_cantidadHsComunes", Name = "CantidadHsComunes", DbType = "float", AutoSync = AutoSync.Never, CanBeNull = false)]
		public float CantidadHsComunes
		{
			get
			{
				return _cantidadHsComunes;
			}
			set
			{
				if (value != _cantidadHsComunes)
				{
					OnCantidadHsComunesChanging(value);
					SendPropertyChanging();
					_cantidadHsComunes = value;
					SendPropertyChanged("CantidadHsComunes");
					OnCantidadHsComunesChanged();
				}
			}
		}

		#endregion

		#region sbyte? CobraHsExtras

		private sbyte? _cobraHsExtras;
		[DebuggerNonUserCode]
		[Column(Storage = "_cobraHsExtras", Name = "CobraHsExtras", DbType = "tinyint(1)", AutoSync = AutoSync.Never)]
		public sbyte? CobraHsExtras
		{
			get
			{
				return _cobraHsExtras;
			}
			set
			{
				if (value != _cobraHsExtras)
				{
					OnCobraHsExtrasChanging(value);
					SendPropertyChanging();
					_cobraHsExtras = value;
					SendPropertyChanged("CobraHsExtras");
					OnCobraHsExtrasChanged();
				}
			}
		}

		#endregion

		#region string Descripcion

		private string _descripcion;
		[DebuggerNonUserCode]
		[Column(Storage = "_descripcion", Name = "Descripcion", DbType = "varchar(255)", AutoSync = AutoSync.Never)]
		public string Descripcion
		{
			get
			{
				return _descripcion;
			}
			set
			{
				if (value != _descripcion)
				{
					OnDescripcionChanging(value);
					SendPropertyChanging();
					_descripcion = value;
					SendPropertyChanged("Descripcion");
					OnDescripcionChanged();
				}
			}
		}

		#endregion

		#region sbyte? Fulltime

		private sbyte? _fulltime;
		[DebuggerNonUserCode]
		[Column(Storage = "_fulltime", Name = "Fulltime", DbType = "tinyint(1)", AutoSync = AutoSync.Never)]
		public sbyte? Fulltime
		{
			get
			{
				return _fulltime;
			}
			set
			{
				if (value != _fulltime)
				{
					OnFulltimeChanging(value);
					SendPropertyChanging();
					_fulltime = value;
					SendPropertyChanged("Fulltime");
					OnFulltimeChanged();
				}
			}
		}

		#endregion

		#region sbyte IDTipoEmpleado

		private sbyte _idtIpoEmpleado;
		[DebuggerNonUserCode]
		[Column(Storage = "_idtIpoEmpleado", Name = "IdTipoEmpleado", DbType = "tinyint(4)", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false)]
		public sbyte IDTipoEmpleado
		{
			get
			{
				return _idtIpoEmpleado;
			}
			set
			{
				if (value != _idtIpoEmpleado)
				{
					OnIDTipoEmpleadoChanging(value);
					SendPropertyChanging();
					_idtIpoEmpleado = value;
					SendPropertyChanged("IDTipoEmpleado");
					OnIDTipoEmpleadoChanged();
				}
			}
		}

		#endregion

		#region string NombreTipo

		private string _nombreTipo;
		[DebuggerNonUserCode]
		[Column(Storage = "_nombreTipo", Name = "NombreTipo", DbType = "varchar(50)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public string NombreTipo
		{
			get
			{
				return _nombreTipo;
			}
			set
			{
				if (value != _nombreTipo)
				{
					OnNombreTipoChanging(value);
					SendPropertyChanging();
					_nombreTipo = value;
					SendPropertyChanged("NombreTipo");
					OnNombreTipoChanged();
				}
			}
		}

		#endregion

		#region TipoType Tipo

		private TipoType _tipo;
		[DebuggerNonUserCode]
		[Column(Storage = "_tipo", Name = "Tipo", DbType = "enum('MENSUAL','JORNALERO')", AutoSync = AutoSync.Never, CanBeNull = false)]
		public TipoType Tipo
		{
			get
			{
				return _tipo;
			}
			set
			{
				if (value != _tipo)
				{
					OnTipoChanging(value);
					SendPropertyChanging();
					_tipo = value;
					SendPropertyChanged("Tipo");
					OnTipoChanged();
				}
			}
		}

		#endregion

		#region ctor

		public TipOeMpLeadO()
		{
			OnCreated();
		}

		#endregion

	}

	[Table(Name = "trustdb.tipoextraliquidacion")]
	public partial class TipOExtraLiquidAcIon : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region INotifyPropertyChanging handling

		public event PropertyChangingEventHandler PropertyChanging;

		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs("");
		protected virtual void SendPropertyChanging()
		{
			if (PropertyChanging != null)
			{
				PropertyChanging(this, emptyChangingEventArgs);
			}
		}

		#endregion

		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void SendPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region Extensibility Method Definitions

		partial void OnCreated();
		partial void OnAceptaPorcentajeChanged();
		partial void OnAceptaPorcentajeChanging(sbyte value);
		partial void OnActivoChanged();
		partial void OnActivoChanging(sbyte value);
		partial void OnIDTipoExtraLiquidacionChanged();
		partial void OnIDTipoExtraLiquidacionChanging(byte value);
		partial void OnLlevaHsChanged();
		partial void OnLlevaHsChanging(sbyte value);
		partial void OnNombreChanged();
		partial void OnNombreChanging(string value);

		#endregion

		#region sbyte AceptaPorcentaje

		private sbyte _aceptaPorcentaje;
		[DebuggerNonUserCode]
		[Column(Storage = "_aceptaPorcentaje", Name = "AceptaPorcentaje", DbType = "tinyint(1)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public sbyte AceptaPorcentaje
		{
			get
			{
				return _aceptaPorcentaje;
			}
			set
			{
				if (value != _aceptaPorcentaje)
				{
					OnAceptaPorcentajeChanging(value);
					SendPropertyChanging();
					_aceptaPorcentaje = value;
					SendPropertyChanged("AceptaPorcentaje");
					OnAceptaPorcentajeChanged();
				}
			}
		}

		#endregion

		#region sbyte Activo

		private sbyte _activo;
		[DebuggerNonUserCode]
		[Column(Storage = "_activo", Name = "Activo", DbType = "tinyint(1)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public sbyte Activo
		{
			get
			{
				return _activo;
			}
			set
			{
				if (value != _activo)
				{
					OnActivoChanging(value);
					SendPropertyChanging();
					_activo = value;
					SendPropertyChanged("Activo");
					OnActivoChanged();
				}
			}
		}

		#endregion

		#region byte IDTipoExtraLiquidacion

		private byte _idtIpoExtraLiquidacion;
		[DebuggerNonUserCode]
		[Column(Storage = "_idtIpoExtraLiquidacion", Name = "IdTipoExtraLiquidacion", DbType = "tinyint(2) unsigned", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false)]
		public byte IDTipoExtraLiquidacion
		{
			get
			{
				return _idtIpoExtraLiquidacion;
			}
			set
			{
				if (value != _idtIpoExtraLiquidacion)
				{
					OnIDTipoExtraLiquidacionChanging(value);
					SendPropertyChanging();
					_idtIpoExtraLiquidacion = value;
					SendPropertyChanged("IDTipoExtraLiquidacion");
					OnIDTipoExtraLiquidacionChanged();
				}
			}
		}

		#endregion

		#region sbyte LlevaHs

		private sbyte _llevaHs;
		[DebuggerNonUserCode]
		[Column(Storage = "_llevaHs", Name = "llevaHs", DbType = "tinyint(1)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public sbyte LlevaHs
		{
			get
			{
				return _llevaHs;
			}
			set
			{
				if (value != _llevaHs)
				{
					OnLlevaHsChanging(value);
					SendPropertyChanging();
					_llevaHs = value;
					SendPropertyChanged("LlevaHs");
					OnLlevaHsChanged();
				}
			}
		}

		#endregion

		#region string Nombre

		private string _nombre;
		[DebuggerNonUserCode]
		[Column(Storage = "_nombre", Name = "Nombre", DbType = "varchar(50)", AutoSync = AutoSync.Never)]
		public string Nombre
		{
			get
			{
				return _nombre;
			}
			set
			{
				if (value != _nombre)
				{
					OnNombreChanging(value);
					SendPropertyChanging();
					_nombre = value;
					SendPropertyChanged("Nombre");
					OnNombreChanged();
				}
			}
		}

		#endregion

		#region Children

		private EntitySet<ExtrasLiquidAcIon> _extrasLiquidAcIon;
		[Association(Storage = "_extrasLiquidAcIon", OtherKey = "IDTipoExtraLiquidacion", ThisKey = "IDTipoExtraLiquidacion", Name = "extrasliquidacion_ibfk_3")]
		[DebuggerNonUserCode]
		public EntitySet<ExtrasLiquidAcIon> ExtrasLiquidAcIon
		{
			get
			{
				return _extrasLiquidAcIon;
			}
			set
			{
				_extrasLiquidAcIon = value;
			}
		}


		#endregion

		#region Attachement handlers

		private void ExtrasLiquidAcIon_Attach(ExtrasLiquidAcIon entity)
		{
			entity.TipOExtraLiquidAcIon = this;
		}

		private void ExtrasLiquidAcIon_Detach(ExtrasLiquidAcIon entity)
		{
			entity.TipOExtraLiquidAcIon = null;
		}


		#endregion

		#region ctor

		public TipOExtraLiquidAcIon()
		{
			_extrasLiquidAcIon = new EntitySet<ExtrasLiquidAcIon>(ExtrasLiquidAcIon_Attach, ExtrasLiquidAcIon_Detach);
			OnCreated();
		}

		#endregion

	}

	[Table(Name = "trustdb.tiposcargos")]
	public partial class TipOscarGoS : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region INotifyPropertyChanging handling

		public event PropertyChangingEventHandler PropertyChanging;

		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs("");
		protected virtual void SendPropertyChanging()
		{
			if (PropertyChanging != null)
			{
				PropertyChanging(this, emptyChangingEventArgs);
			}
		}

		#endregion

		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void SendPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region Extensibility Method Definitions

		partial void OnCreated();
		partial void OnActivoChanged();
		partial void OnActivoChanging(sbyte value);
		partial void OnCantidadHsComunesChanged();
		partial void OnCantidadHsComunesChanging(sbyte value);
		partial void OnCobraHsExtrasChanged();
		partial void OnCobraHsExtrasChanging(sbyte value);
		partial void OnDescripcionChanged();
		partial void OnDescripcionChanging(string value);
		partial void OnFulltimeChanged();
		partial void OnFulltimeChanging(sbyte value);
		partial void OnIDCargoChanged();
		partial void OnIDCargoChanging(uint value);
		partial void OnNombreChanged();
		partial void OnNombreChanging(string value);
		partial void OnTipoFacturacionChanged();
		partial void OnTipoFacturacionChanging(string value);

		#endregion

		#region sbyte Activo

		private sbyte _activo;
		[DebuggerNonUserCode]
		[Column(Storage = "_activo", Name = "Activo", DbType = "tinyint(1)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public sbyte Activo
		{
			get
			{
				return _activo;
			}
			set
			{
				if (value != _activo)
				{
					OnActivoChanging(value);
					SendPropertyChanging();
					_activo = value;
					SendPropertyChanged("Activo");
					OnActivoChanged();
				}
			}
		}

		#endregion

		#region sbyte CantidadHsComunes

		private sbyte _cantidadHsComunes;
		[DebuggerNonUserCode]
		[Column(Storage = "_cantidadHsComunes", Name = "CantidadHsComunes", DbType = "tinyint(2)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public sbyte CantidadHsComunes
		{
			get
			{
				return _cantidadHsComunes;
			}
			set
			{
				if (value != _cantidadHsComunes)
				{
					OnCantidadHsComunesChanging(value);
					SendPropertyChanging();
					_cantidadHsComunes = value;
					SendPropertyChanged("CantidadHsComunes");
					OnCantidadHsComunesChanged();
				}
			}
		}

		#endregion

		#region sbyte CobraHsExtras

		private sbyte _cobraHsExtras;
		[DebuggerNonUserCode]
		[Column(Storage = "_cobraHsExtras", Name = "CobraHsExtras", DbType = "tinyint(1)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public sbyte CobraHsExtras
		{
			get
			{
				return _cobraHsExtras;
			}
			set
			{
				if (value != _cobraHsExtras)
				{
					OnCobraHsExtrasChanging(value);
					SendPropertyChanging();
					_cobraHsExtras = value;
					SendPropertyChanged("CobraHsExtras");
					OnCobraHsExtrasChanged();
				}
			}
		}

		#endregion

		#region string Descripcion

		private string _descripcion;
		[DebuggerNonUserCode]
		[Column(Storage = "_descripcion", Name = "Descripcion", DbType = "varchar(200)", AutoSync = AutoSync.Never)]
		public string Descripcion
		{
			get
			{
				return _descripcion;
			}
			set
			{
				if (value != _descripcion)
				{
					OnDescripcionChanging(value);
					SendPropertyChanging();
					_descripcion = value;
					SendPropertyChanged("Descripcion");
					OnDescripcionChanged();
				}
			}
		}

		#endregion

		#region sbyte Fulltime

		private sbyte _fulltime;
		[DebuggerNonUserCode]
		[Column(Storage = "_fulltime", Name = "Fulltime", DbType = "tinyint(1)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public sbyte Fulltime
		{
			get
			{
				return _fulltime;
			}
			set
			{
				if (value != _fulltime)
				{
					OnFulltimeChanging(value);
					SendPropertyChanging();
					_fulltime = value;
					SendPropertyChanged("Fulltime");
					OnFulltimeChanged();
				}
			}
		}

		#endregion

		#region uint IDCargo

		private uint _idcArgo;
		[DebuggerNonUserCode]
		[Column(Storage = "_idcArgo", Name = "IdCargo", DbType = "mediumint unsigned", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false)]
		public uint IDCargo
		{
			get
			{
				return _idcArgo;
			}
			set
			{
				if (value != _idcArgo)
				{
					OnIDCargoChanging(value);
					SendPropertyChanging();
					_idcArgo = value;
					SendPropertyChanged("IDCargo");
					OnIDCargoChanged();
				}
			}
		}

		#endregion

		#region string Nombre

		private string _nombre;
		[DebuggerNonUserCode]
		[Column(Storage = "_nombre", Name = "Nombre", DbType = "varchar(100)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public string Nombre
		{
			get
			{
				return _nombre;
			}
			set
			{
				if (value != _nombre)
				{
					OnNombreChanging(value);
					SendPropertyChanging();
					_nombre = value;
					SendPropertyChanged("Nombre");
					OnNombreChanged();
				}
			}
		}

		#endregion

		#region string TipoFacturacion

		private string _tipoFacturacion;
		[DebuggerNonUserCode]
		[Column(Storage = "_tipoFacturacion", Name = "TipoFacturacion", DbType = "varchar(10)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public string TipoFacturacion
		{
			get
			{
				return _tipoFacturacion;
			}
			set
			{
				if (value != _tipoFacturacion)
				{
					OnTipoFacturacionChanging(value);
					SendPropertyChanging();
					_tipoFacturacion = value;
					SendPropertyChanged("TipoFacturacion");
					OnTipoFacturacionChanged();
				}
			}
		}

		#endregion

		#region Children

		private EntitySet<EmPleadOs> _emPleadOs;
		[Association(Storage = "_emPleadOs", OtherKey = "IDCargo", ThisKey = "IDCargo", Name = "empleados_ibfk_1")]
		[DebuggerNonUserCode]
		public EntitySet<EmPleadOs> EmPleadOs
		{
			get
			{
				return _emPleadOs;
			}
			set
			{
				_emPleadOs = value;
			}
		}


		#endregion

		#region Attachement handlers

		private void EmPleadOs_Attach(EmPleadOs entity)
		{
			entity.TipOscarGoS = this;
		}

		private void EmPleadOs_Detach(EmPleadOs entity)
		{
			entity.TipOscarGoS = null;
		}


		#endregion

		#region ctor

		public TipOscarGoS()
		{
			_emPleadOs = new EntitySet<EmPleadOs>(EmPleadOs_Attach, EmPleadOs_Detach);
			OnCreated();
		}

		#endregion

	}

	[Table(Name = "trustdb.tiposdias")]
	public partial class TipOsDiAs : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region INotifyPropertyChanging handling

		public event PropertyChangingEventHandler PropertyChanging;

		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs("");
		protected virtual void SendPropertyChanging()
		{
			if (PropertyChanging != null)
			{
				PropertyChanging(this, emptyChangingEventArgs);
			}
		}

		#endregion

		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void SendPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region Extensibility Method Definitions

		partial void OnCreated();
		partial void OnDesCrIpcIonChanged();
		partial void OnDesCrIpcIonChanging(string value);
		partial void OnIDChanged();
		partial void OnIDChanging(byte value);
		partial void OnNoMbReChanged();
		partial void OnNoMbReChanging(string value);

		#endregion

		#region string DesCrIpcIon

		private string _desCrIpcIon;
		[DebuggerNonUserCode]
		[Column(Storage = "_desCrIpcIon", Name = "descripcion", DbType = "varchar(50)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public string DesCrIpcIon
		{
			get
			{
				return _desCrIpcIon;
			}
			set
			{
				if (value != _desCrIpcIon)
				{
					OnDesCrIpcIonChanging(value);
					SendPropertyChanging();
					_desCrIpcIon = value;
					SendPropertyChanged("DesCrIpcIon");
					OnDesCrIpcIonChanged();
				}
			}
		}

		#endregion

		#region byte ID

		private byte _id;
		[DebuggerNonUserCode]
		[Column(Storage = "_id", Name = "id", DbType = "tinyint(2) unsigned", IsPrimaryKey = true, AutoSync = AutoSync.Never, CanBeNull = false)]
		public byte ID
		{
			get
			{
				return _id;
			}
			set
			{
				if (value != _id)
				{
					OnIDChanging(value);
					SendPropertyChanging();
					_id = value;
					SendPropertyChanged("ID");
					OnIDChanged();
				}
			}
		}

		#endregion

		#region string NoMbRe

		private string _noMbRe;
		[DebuggerNonUserCode]
		[Column(Storage = "_noMbRe", Name = "nombre", DbType = "varchar(20)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public string NoMbRe
		{
			get
			{
				return _noMbRe;
			}
			set
			{
				if (value != _noMbRe)
				{
					OnNoMbReChanging(value);
					SendPropertyChanging();
					_noMbRe = value;
					SendPropertyChanged("NoMbRe");
					OnNoMbReChanged();
				}
			}
		}

		#endregion

		#region Children

		private EntitySet<HoRaRioEScalaFOn> _hoRaRioEsCalaFoN;
		[Association(Storage = "_hoRaRioEsCalaFoN", OtherKey = "TipoDia", ThisKey = "ID", Name = "horarioescalafon_ibfk_1")]
		[DebuggerNonUserCode]
		public EntitySet<HoRaRioEScalaFOn> HoRaRioEScalaFOn
		{
			get
			{
				return _hoRaRioEsCalaFoN;
			}
			set
			{
				_hoRaRioEsCalaFoN = value;
			}
		}


		#endregion

		#region Attachement handlers

		private void HoRaRioEScalaFOn_Attach(HoRaRioEScalaFOn entity)
		{
			entity.TipOsDiAs = this;
		}

		private void HoRaRioEScalaFOn_Detach(HoRaRioEScalaFOn entity)
		{
			entity.TipOsDiAs = null;
		}


		#endregion

		#region ctor

		public TipOsDiAs()
		{
			_hoRaRioEsCalaFoN = new EntitySet<HoRaRioEScalaFOn>(HoRaRioEScalaFOn_Attach, HoRaRioEScalaFOn_Detach);
			OnCreated();
		}

		#endregion

	}

	[Table(Name = "trustdb.tiposdocumento")]
	public partial class TipOsDocumentO : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region INotifyPropertyChanging handling

		public event PropertyChangingEventHandler PropertyChanging;

		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs("");
		protected virtual void SendPropertyChanging()
		{
			if (PropertyChanging != null)
			{
				PropertyChanging(this, emptyChangingEventArgs);
			}
		}

		#endregion

		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void SendPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region Extensibility Method Definitions

		partial void OnCreated();
		partial void OnIDTipoDocumentoChanged();
		partial void OnIDTipoDocumentoChanging(byte value);
		partial void OnNombreChanged();
		partial void OnNombreChanging(string value);

		#endregion

		#region byte IDTipoDocumento

		private byte _idtIpoDocumento;
		[DebuggerNonUserCode]
		[Column(Storage = "_idtIpoDocumento", Name = "IdTipoDocumento", DbType = "tinyint(1) unsigned", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false)]
		public byte IDTipoDocumento
		{
			get
			{
				return _idtIpoDocumento;
			}
			set
			{
				if (value != _idtIpoDocumento)
				{
					OnIDTipoDocumentoChanging(value);
					SendPropertyChanging();
					_idtIpoDocumento = value;
					SendPropertyChanged("IDTipoDocumento");
					OnIDTipoDocumentoChanged();
				}
			}
		}

		#endregion

		#region string Nombre

		private string _nombre;
		[DebuggerNonUserCode]
		[Column(Storage = "_nombre", Name = "Nombre", DbType = "varchar(50)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public string Nombre
		{
			get
			{
				return _nombre;
			}
			set
			{
				if (value != _nombre)
				{
					OnNombreChanging(value);
					SendPropertyChanging();
					_nombre = value;
					SendPropertyChanged("Nombre");
					OnNombreChanged();
				}
			}
		}

		#endregion

		#region ctor

		public TipOsDocumentO()
		{
			OnCreated();
		}

		#endregion

	}

	[Table(Name = "trustdb.tiposeventohistorial")]
	public partial class TipOsEventOHistOrIal : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region INotifyPropertyChanging handling

		public event PropertyChangingEventHandler PropertyChanging;

		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs("");
		protected virtual void SendPropertyChanging()
		{
			if (PropertyChanging != null)
			{
				PropertyChanging(this, emptyChangingEventArgs);
			}
		}

		#endregion

		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void SendPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region Extensibility Method Definitions

		partial void OnCreated();
		partial void OnActivoChanged();
		partial void OnActivoChanging(short value);
		partial void OnIDTipoEventoHistorialChanged();
		partial void OnIDTipoEventoHistorialChanging(ushort value);
		partial void OnNombreChanged();
		partial void OnNombreChanging(string value);

		#endregion

		#region short Activo

		private short _activo;
		[DebuggerNonUserCode]
		[Column(Storage = "_activo", Name = "Activo", DbType = "smallint(1)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public short Activo
		{
			get
			{
				return _activo;
			}
			set
			{
				if (value != _activo)
				{
					OnActivoChanging(value);
					SendPropertyChanging();
					_activo = value;
					SendPropertyChanged("Activo");
					OnActivoChanged();
				}
			}
		}

		#endregion

		#region ushort IDTipoEventoHistorial

		private ushort _idtIpoEventoHistorial;
		[DebuggerNonUserCode]
		[Column(Storage = "_idtIpoEventoHistorial", Name = "IdTipoEventoHistorial", DbType = "smallint(5) unsigned", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false)]
		public ushort IDTipoEventoHistorial
		{
			get
			{
				return _idtIpoEventoHistorial;
			}
			set
			{
				if (value != _idtIpoEventoHistorial)
				{
					OnIDTipoEventoHistorialChanging(value);
					SendPropertyChanging();
					_idtIpoEventoHistorial = value;
					SendPropertyChanged("IDTipoEventoHistorial");
					OnIDTipoEventoHistorialChanged();
				}
			}
		}

		#endregion

		#region string Nombre

		private string _nombre;
		[DebuggerNonUserCode]
		[Column(Storage = "_nombre", Name = "Nombre", DbType = "varchar(100)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public string Nombre
		{
			get
			{
				return _nombre;
			}
			set
			{
				if (value != _nombre)
				{
					OnNombreChanging(value);
					SendPropertyChanging();
					_nombre = value;
					SendPropertyChanged("Nombre");
					OnNombreChanged();
				}
			}
		}

		#endregion

		#region ctor

		public TipOsEventOHistOrIal()
		{
			OnCreated();
		}

		#endregion

	}

	[Table(Name = "trustdb.tiposmotivocambiodiario")]
	public partial class TipOsMotIVOCamBIoDiARio : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region INotifyPropertyChanging handling

		public event PropertyChangingEventHandler PropertyChanging;

		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs("");
		protected virtual void SendPropertyChanging()
		{
			if (PropertyChanging != null)
			{
				PropertyChanging(this, emptyChangingEventArgs);
			}
		}

		#endregion

		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void SendPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region Extensibility Method Definitions

		partial void OnCreated();
		partial void OnActivoChanged();
		partial void OnActivoChanging(short value);
		partial void OnDescripcionChanged();
		partial void OnDescripcionChanging(string value);
		partial void OnIDTipoMotivoChanged();
		partial void OnIDTipoMotivoChanging(uint value);

		#endregion

		#region short Activo

		private short _activo;
		[DebuggerNonUserCode]
		[Column(Storage = "_activo", Name = "Activo", DbType = "smallint(1)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public short Activo
		{
			get
			{
				return _activo;
			}
			set
			{
				if (value != _activo)
				{
					OnActivoChanging(value);
					SendPropertyChanging();
					_activo = value;
					SendPropertyChanged("Activo");
					OnActivoChanged();
				}
			}
		}

		#endregion

		#region string Descripcion

		private string _descripcion;
		[DebuggerNonUserCode]
		[Column(Storage = "_descripcion", Name = "Descripcion", DbType = "varchar(255)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public string Descripcion
		{
			get
			{
				return _descripcion;
			}
			set
			{
				if (value != _descripcion)
				{
					OnDescripcionChanging(value);
					SendPropertyChanging();
					_descripcion = value;
					SendPropertyChanged("Descripcion");
					OnDescripcionChanged();
				}
			}
		}

		#endregion

		#region uint IDTipoMotivo

		private uint _idtIpoMotivo;
		[DebuggerNonUserCode]
		[Column(Storage = "_idtIpoMotivo", Name = "IdTipoMotivo", DbType = "mediumint unsigned", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false)]
		public uint IDTipoMotivo
		{
			get
			{
				return _idtIpoMotivo;
			}
			set
			{
				if (value != _idtIpoMotivo)
				{
					OnIDTipoMotivoChanging(value);
					SendPropertyChanging();
					_idtIpoMotivo = value;
					SendPropertyChanged("IDTipoMotivo");
					OnIDTipoMotivoChanged();
				}
			}
		}

		#endregion

		#region Children

		private EntitySet<MotIVOsCamBiosDiARioS> _motIvoSCamBiosDiArIoS;
		[Association(Storage = "_motIvoSCamBiosDiArIoS", OtherKey = "IDTipoMotivo", ThisKey = "IDTipoMotivo", Name = "motivoscambiosdiarios_ibfk_1")]
		[DebuggerNonUserCode]
		public EntitySet<MotIVOsCamBiosDiARioS> MotIVOsCamBiosDiARioS
		{
			get
			{
				return _motIvoSCamBiosDiArIoS;
			}
			set
			{
				_motIvoSCamBiosDiArIoS = value;
			}
		}


		#endregion

		#region Attachement handlers

		private void MotIVOsCamBiosDiARioS_Attach(MotIVOsCamBiosDiARioS entity)
		{
			entity.TipOsMotIVOCamBIoDiARio = this;
		}

		private void MotIVOsCamBiosDiARioS_Detach(MotIVOsCamBiosDiARioS entity)
		{
			entity.TipOsMotIVOCamBIoDiARio = null;
		}


		#endregion

		#region ctor

		public TipOsMotIVOCamBIoDiARio()
		{
			_motIvoSCamBiosDiArIoS = new EntitySet<MotIVOsCamBiosDiARioS>(MotIVOsCamBiosDiARioS_Attach, MotIVOsCamBiosDiARioS_Detach);
			OnCreated();
		}

		#endregion

	}

	[Table(Name = "trustdb.usuarios")]
	public partial class UsUarIoS : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region INotifyPropertyChanging handling

		public event PropertyChangingEventHandler PropertyChanging;

		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs("");
		protected virtual void SendPropertyChanging()
		{
			if (PropertyChanging != null)
			{
				PropertyChanging(this, emptyChangingEventArgs);
			}
		}

		#endregion

		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void SendPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region Extensibility Method Definitions

		partial void OnCreated();
		partial void OnActivoChanged();
		partial void OnActivoChanging(sbyte value);
		partial void OnApellidoChanged();
		partial void OnApellidoChanging(string value);
		partial void OnFechaCreacionChanged();
		partial void OnFechaCreacionChanging(DateTime value);
		partial void OnIDUsuarioChanged();
		partial void OnIDUsuarioChanging(int value);
		partial void OnNombreChanged();
		partial void OnNombreChanging(string value);
		partial void OnPasswordChanged();
		partial void OnPasswordChanging(string value);
		partial void OnUserNameChanged();
		partial void OnUserNameChanging(string value);

		#endregion

		#region sbyte Activo

		private sbyte _activo;
		[DebuggerNonUserCode]
		[Column(Storage = "_activo", Name = "Activo", DbType = "tinyint(1)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public sbyte Activo
		{
			get
			{
				return _activo;
			}
			set
			{
				if (value != _activo)
				{
					OnActivoChanging(value);
					SendPropertyChanging();
					_activo = value;
					SendPropertyChanged("Activo");
					OnActivoChanged();
				}
			}
		}

		#endregion

		#region string Apellido

		private string _apellido;
		[DebuggerNonUserCode]
		[Column(Storage = "_apellido", Name = "Apellido", DbType = "varchar(100)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public string Apellido
		{
			get
			{
				return _apellido;
			}
			set
			{
				if (value != _apellido)
				{
					OnApellidoChanging(value);
					SendPropertyChanging();
					_apellido = value;
					SendPropertyChanged("Apellido");
					OnApellidoChanged();
				}
			}
		}

		#endregion

		#region DateTime FechaCreacion

		private DateTime _fechaCreacion;
		[DebuggerNonUserCode]
		[Column(Storage = "_fechaCreacion", Name = "FechaCreacion", DbType = "date", AutoSync = AutoSync.Never, CanBeNull = false)]
		public DateTime FechaCreacion
		{
			get
			{
				return _fechaCreacion;
			}
			set
			{
				if (value != _fechaCreacion)
				{
					OnFechaCreacionChanging(value);
					SendPropertyChanging();
					_fechaCreacion = value;
					SendPropertyChanged("FechaCreacion");
					OnFechaCreacionChanged();
				}
			}
		}

		#endregion

		#region int IDUsuario

		private int _iduSuario;
		[DebuggerNonUserCode]
		[Column(Storage = "_iduSuario", Name = "idUsuario", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true, AutoSync = AutoSync.Never, CanBeNull = false)]
		public int IDUsuario
		{
			get
			{
				return _iduSuario;
			}
			set
			{
				if (value != _iduSuario)
				{
					OnIDUsuarioChanging(value);
					SendPropertyChanging();
					_iduSuario = value;
					SendPropertyChanged("IDUsuario");
					OnIDUsuarioChanged();
				}
			}
		}

		#endregion

		#region string Nombre

		private string _nombre;
		[DebuggerNonUserCode]
		[Column(Storage = "_nombre", Name = "Nombre", DbType = "varchar(100)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public string Nombre
		{
			get
			{
				return _nombre;
			}
			set
			{
				if (value != _nombre)
				{
					OnNombreChanging(value);
					SendPropertyChanging();
					_nombre = value;
					SendPropertyChanged("Nombre");
					OnNombreChanged();
				}
			}
		}

		#endregion

		#region string Password

		private string _password;
		[DebuggerNonUserCode]
		[Column(Storage = "_password", Name = "Password", DbType = "char(32)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public string Password
		{
			get
			{
				return _password;
			}
			set
			{
				if (value != _password)
				{
					OnPasswordChanging(value);
					SendPropertyChanging();
					_password = value;
					SendPropertyChanged("Password");
					OnPasswordChanged();
				}
			}
		}

		#endregion

		#region string UserName

		private string _userName;
		[DebuggerNonUserCode]
		[Column(Storage = "_userName", Name = "UserName", DbType = "varchar(30)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public string UserName
		{
			get
			{
				return _userName;
			}
			set
			{
				if (value != _userName)
				{
					OnUserNameChanging(value);
					SendPropertyChanging();
					_userName = value;
					SendPropertyChanged("UserName");
					OnUserNameChanged();
				}
			}
		}

		#endregion

		#region Children

		private EntitySet<ExtrasLiquidAcIon> _extrasLiquidAcIon;
		[Association(Storage = "_extrasLiquidAcIon", OtherKey = "IDUsuario", ThisKey = "IDUsuario", Name = "extrasliquidacion_ibfk_2")]
		[DebuggerNonUserCode]
		public EntitySet<ExtrasLiquidAcIon> ExtrasLiquidAcIon
		{
			get
			{
				return _extrasLiquidAcIon;
			}
			set
			{
				_extrasLiquidAcIon = value;
			}
		}

		private EntitySet<UsUarIoSGRuPOs> _usUarIoSgrUPoS;
		[Association(Storage = "_usUarIoSgrUPoS", OtherKey = "IDUsuario", ThisKey = "IDUsuario", Name = "FK_Usuarios")]
		[DebuggerNonUserCode]
		public EntitySet<UsUarIoSGRuPOs> UsUarIoSGRuPOs
		{
			get
			{
				return _usUarIoSgrUPoS;
			}
			set
			{
				_usUarIoSgrUPoS = value;
			}
		}


		#endregion

		#region Attachement handlers

		private void ExtrasLiquidAcIon_Attach(ExtrasLiquidAcIon entity)
		{
			entity.UsUarIoS = this;
		}

		private void ExtrasLiquidAcIon_Detach(ExtrasLiquidAcIon entity)
		{
			entity.UsUarIoS = null;
		}

		private void UsUarIoSGRuPOs_Attach(UsUarIoSGRuPOs entity)
		{
			entity.UsUarIoS = this;
		}

		private void UsUarIoSGRuPOs_Detach(UsUarIoSGRuPOs entity)
		{
			entity.UsUarIoS = null;
		}


		#endregion

		#region ctor

		public UsUarIoS()
		{
			_extrasLiquidAcIon = new EntitySet<ExtrasLiquidAcIon>(ExtrasLiquidAcIon_Attach, ExtrasLiquidAcIon_Detach);
			_usUarIoSgrUPoS = new EntitySet<UsUarIoSGRuPOs>(UsUarIoSGRuPOs_Attach, UsUarIoSGRuPOs_Detach);
			OnCreated();
		}

		#endregion

	}

	[Table(Name = "trustdb.usuariosgrupos")]
	public partial class UsUarIoSGRuPOs : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region INotifyPropertyChanging handling

		public event PropertyChangingEventHandler PropertyChanging;

		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs("");
		protected virtual void SendPropertyChanging()
		{
			if (PropertyChanging != null)
			{
				PropertyChanging(this, emptyChangingEventArgs);
			}
		}

		#endregion

		#region INotifyPropertyChanged handling

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void SendPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region Extensibility Method Definitions

		partial void OnCreated();
		partial void OnIDGrupoChanged();
		partial void OnIDGrupoChanging(int value);
		partial void OnIDUsuarioChanged();
		partial void OnIDUsuarioChanging(int value);

		#endregion

		#region int IDGrupo

		private int _idgRupo;
		[DebuggerNonUserCode]
		[Column(Storage = "_idgRupo", Name = "idGrupo", DbType = "int", IsPrimaryKey = true, AutoSync = AutoSync.Never, CanBeNull = false)]
		public int IDGrupo
		{
			get
			{
				return _idgRupo;
			}
			set
			{
				if (value != _idgRupo)
				{
					OnIDGrupoChanging(value);
					SendPropertyChanging();
					_idgRupo = value;
					SendPropertyChanged("IDGrupo");
					OnIDGrupoChanged();
				}
			}
		}

		#endregion

		#region int IDUsuario

		private int _iduSuario;
		[DebuggerNonUserCode]
		[Column(Storage = "_iduSuario", Name = "idUsuario", DbType = "int", IsPrimaryKey = true, AutoSync = AutoSync.Never, CanBeNull = false)]
		public int IDUsuario
		{
			get
			{
				return _iduSuario;
			}
			set
			{
				if (value != _iduSuario)
				{
					OnIDUsuarioChanging(value);
					SendPropertyChanging();
					_iduSuario = value;
					SendPropertyChanged("IDUsuario");
					OnIDUsuarioChanged();
				}
			}
		}

		#endregion

		#region Parents

		private EntityRef<GRuPOs> _grUPoS;
		[Association(Storage = "_grUPoS", OtherKey = "IDGrupo", ThisKey = "IDGrupo", Name = "FK_Grupos", IsForeignKey = true)]
		[DebuggerNonUserCode]
		public GRuPOs GRuPOs
		{
			get
			{
				return _grUPoS.Entity;
			}
			set
			{
				if (value != _grUPoS.Entity)
				{
					if (_grUPoS.Entity != null)
					{
						var previousGRuPOs = _grUPoS.Entity;
						_grUPoS.Entity = null;
						previousGRuPOs.UsUarIoSGRuPOs.Remove(this);
					}
					_grUPoS.Entity = value;
					if (value != null)
					{
						value.UsUarIoSGRuPOs.Add(this);
						_idgRupo = value.IDGrupo;
					}
					else
					{
						_idgRupo = default(int);
					}
				}
			}
		}

		private EntityRef<UsUarIoS> _usUarIoS;
		[Association(Storage = "_usUarIoS", OtherKey = "IDUsuario", ThisKey = "IDUsuario", Name = "FK_Usuarios", IsForeignKey = true)]
		[DebuggerNonUserCode]
		public UsUarIoS UsUarIoS
		{
			get
			{
				return _usUarIoS.Entity;
			}
			set
			{
				if (value != _usUarIoS.Entity)
				{
					if (_usUarIoS.Entity != null)
					{
						var previousUsUarIoS = _usUarIoS.Entity;
						_usUarIoS.Entity = null;
						previousUsUarIoS.UsUarIoSGRuPOs.Remove(this);
					}
					_usUarIoS.Entity = value;
					if (value != null)
					{
						value.UsUarIoSGRuPOs.Add(this);
						_iduSuario = value.IDUsuario;
					}
					else
					{
						_iduSuario = default(int);
					}
				}
			}
		}


		#endregion

		#region ctor

		public UsUarIoSGRuPOs()
		{
			_grUPoS = new EntityRef<GRuPOs>();
			_usUarIoS = new EntityRef<UsUarIoS>();
			OnCreated();
		}

		#endregion

	}
}
