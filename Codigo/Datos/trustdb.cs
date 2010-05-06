#region Auto-generated classes for trustdb database on 2010-05-05 15:06:50Z

//
//  ____  _     __  __      _        _
// |  _ \| |__ |  \/  | ___| |_ __ _| |
// | | | | '_ \| |\/| |/ _ \ __/ _` | |
// | |_| | |_) | |  | |  __/ || (_| | |
// |____/|_.__/|_|  |_|\___|\__\__,_|_|
//
// Auto-generated from trustdb on 2010-05-05 15:06:50Z
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
		public Table<ClientEs> ClientEs { get { return GetTable<ClientEs>(); } }
		public Table<ConsultAsClientEs> ConsultAsClientEs { get { return GetTable<ConsultAsClientEs>(); } }
		public Table<ConsultAsEmPleadOs> ConsultAsEmPleadOs { get { return GetTable<ConsultAsEmPleadOs>(); } }
		public Table<ContraToS> ContraToS { get { return GetTable<ContraToS>(); } }
		public Table<DepartAmenToS> DepartAmenToS { get { return GetTable<DepartAmenToS>(); } }
		public Table<EmergeNcIasMedicA> EmergeNcIasMedicA { get { return GetTable<EmergeNcIasMedicA>(); } }
		public Table<EmPleadOs> EmPleadOs { get { return GetTable<EmPleadOs>(); } }
		public Table<EventOsHistOrIalEmPleadO> EventOsHistOrIalEmPleadO { get { return GetTable<EventOsHistOrIalEmPleadO>(); } }
		public Table<ExtrasLiquidAcIonEmPleadO> ExtrasLiquidAcIonEmPleadO { get { return GetTable<ExtrasLiquidAcIonEmPleadO>(); } }
		public Table<HoRaRioDiA> HoRaRioDiA { get { return GetTable<HoRaRioDiA>(); } }
		public Table<LineAshOrAs> LineAshOrAs { get { return GetTable<LineAshOrAs>(); } }
		public Table<ListAnEGRa> ListAnEGRa { get { return GetTable<ListAnEGRa>(); } }
		public Table<MutualIsTAs> MutualIsTAs { get { return GetTable<MutualIsTAs>(); } }
		public Table<SERVicIoS> SERVicIoS { get { return GetTable<SERVicIoS>(); } }
		public Table<TipOContraToS> TipOContraToS { get { return GetTable<TipOContraToS>(); } }
		public Table<TipOeMpLeadO> TipOeMpLeadO { get { return GetTable<TipOeMpLeadO>(); } }
		public Table<TipOscarGoS> TipOscarGoS { get { return GetTable<TipOscarGoS>(); } }
		public Table<TipOsDocumentO> TipOsDocumentO { get { return GetTable<TipOsDocumentO>(); } }
		public Table<TipOsEventOHistOrIal> TipOsEventOHistOrIal { get { return GetTable<TipOsEventOHistOrIal>(); } }

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
		partial void OnNumeroClienteChanged();
		partial void OnNumeroClienteChanging(uint value);
		partial void OnRutChanged();
		partial void OnRutChanging(string value);
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
		[Column(Storage = "_query", Name = "query", DbType = "varchar(255)", AutoSync = AutoSync.Never, CanBeNull = false)]
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
		[Column(Storage = "_query", Name = "Query", DbType = "varchar(500)", AutoSync = AutoSync.Never, CanBeNull = false)]
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
		partial void OnHorasExtrasChanged();
		partial void OnHorasExtrasChanging(sbyte value);
		partial void OnIDContratosChanged();
		partial void OnIDContratosChanging(uint value);
		partial void OnObservacionesChanged();
		partial void OnObservacionesChanging(string value);
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
			_lineAshOrAs = new EntitySet<LineAshOrAs>(LineAshOrAs_Attach, LineAshOrAs_Detach);
			_tipOcOntraToS = new EntityRef<TipOContraToS>();
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
		partial void OnIDCargoChanged();
		partial void OnIDCargoChanging(short value);
		partial void OnIDDepartamentoChanged();
		partial void OnIDDepartamentoChanging(sbyte? value);
		partial void OnIDEmergenciaMedicaChanged();
		partial void OnIDEmergenciaMedicaChanging(byte? value);
		partial void OnIDEmpleadoChanged();
		partial void OnIDEmpleadoChanging(uint value);
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
		partial void OnNombreChanged();
		partial void OnNombreChanging(string value);
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

		#region short IDCargo

		private short _idcArgo;
		[DebuggerNonUserCode]
		[Column(Storage = "_idcArgo", Name = "IdCargo", DbType = "smallint(6)", AutoSync = AutoSync.Never, CanBeNull = false)]
		public short IDCargo
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

		private EntitySet<EventOsHistOrIalEmPleadO> _eventOsHistOrIalEmPleadO;
		[Association(Storage = "_eventOsHistOrIalEmPleadO", OtherKey = "IDEmpleado", ThisKey = "IDEmpleado", Name = "eventoshistorialempleado_ibfk_1")]
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

		private EntitySet<ExtrasLiquidAcIonEmPleadO> _extrasLiquidAcIonEmPleadO;
		[Association(Storage = "_extrasLiquidAcIonEmPleadO", OtherKey = "IDEmpleado", ThisKey = "IDEmpleado", Name = "extrasliquidacionempleado_ibfk_1")]
		[DebuggerNonUserCode]
		public EntitySet<ExtrasLiquidAcIonEmPleadO> ExtrasLiquidAcIonEmPleadO
		{
			get
			{
				return _extrasLiquidAcIonEmPleadO;
			}
			set
			{
				_extrasLiquidAcIonEmPleadO = value;
			}
		}


		#endregion

		#region Attachement handlers

		private void EventOsHistOrIalEmPleadO_Attach(EventOsHistOrIalEmPleadO entity)
		{
			entity.EmPleadOs = this;
		}

		private void EventOsHistOrIalEmPleadO_Detach(EventOsHistOrIalEmPleadO entity)
		{
			entity.EmPleadOs = null;
		}

		private void ExtrasLiquidAcIonEmPleadO_Attach(ExtrasLiquidAcIonEmPleadO entity)
		{
			entity.EmPleadOs = this;
		}

		private void ExtrasLiquidAcIonEmPleadO_Detach(ExtrasLiquidAcIonEmPleadO entity)
		{
			entity.EmPleadOs = null;
		}


		#endregion

		#region ctor

		public EmPleadOs()
		{
			_eventOsHistOrIalEmPleadO = new EntitySet<EventOsHistOrIalEmPleadO>(EventOsHistOrIalEmPleadO_Attach, EventOsHistOrIalEmPleadO_Detach);
			_extrasLiquidAcIonEmPleadO = new EntitySet<ExtrasLiquidAcIonEmPleadO>(ExtrasLiquidAcIonEmPleadO_Attach, ExtrasLiquidAcIonEmPleadO_Detach);
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
		[Association(Storage = "_emPleadOs", OtherKey = "IDEmpleado", ThisKey = "IDEmpleado", Name = "eventoshistorialempleado_ibfk_1", IsForeignKey = true)]
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
						_ideMpleado = value.IDEmpleado;
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

		#region Parents

		private EntityRef<EmPleadOs> _emPleadOs;
		[Association(Storage = "_emPleadOs", OtherKey = "IDEmpleado", ThisKey = "IDEmpleado", Name = "extrasliquidacionempleado_ibfk_1", IsForeignKey = true)]
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
						previousEmPleadOs.ExtrasLiquidAcIonEmPleadO.Remove(this);
					}
					_emPleadOs.Entity = value;
					if (value != null)
					{
						value.ExtrasLiquidAcIonEmPleadO.Add(this);
						_ideMpleado = value.IDEmpleado;
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

		public ExtrasLiquidAcIonEmPleadO()
		{
			_emPleadOs = new EntityRef<EmPleadOs>();
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
		[Association(Storage = "_lineAshOrAs", OtherKey = "IDContrato", ThisKey = "IDContrato", Name = "`FK IdContrato HD`", IsForeignKey = true)]
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
					}
					else
					{
						_idcOntrato = default(uint);
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
		[Association(Storage = "_hoRaRioDiA", OtherKey = "IDContrato", ThisKey = "IDContrato", Name = "`FK IdContrato HD`")]
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
		partial void OnFechaAltaChanged();
		partial void OnFechaAltaChanging(DateTime? value);
		partial void OnFechaBajaChanged();
		partial void OnFechaBajaChanging(DateTime? value);
		partial void OnMotivoBajaChanged();
		partial void OnMotivoBajaChanging(string value);
		partial void OnNombreChanged();
		partial void OnNombreChanging(string value);
		partial void OnNumeroClienteChanged();
		partial void OnNumeroClienteChanging(uint value);
		partial void OnNumeroServicioChanged();
		partial void OnNumeroServicioChanging(uint value);
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

		#region ctor

		public SERVicIoS()
		{
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

		#region ctor

		public TipOscarGoS()
		{
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
}
