using System;
using System.Collections.Generic;
using System.Text;

namespace Logica
{
    public class Empleado
    {
       
        private uint MyNumeroEmpleado;
        private string MyNombre;

        private string MyApellido;

        private char  MySexo;
        
        private Int16 MyTipoDocumento;

        private string MyNumeroDocumento;
        private Int16 MyDepartamento;
        private string MyCiudad;
        private string MyBarrio;
        private string MyDireccion;
        private string MyEstadoCivil;
        private string MyEntreCalles;
        private string MyTelefonos;
        private string MyCelular;
        private string MyCelularEnConvenio;
        private string MyDireccionDeEncuentro;
        private string MyEmail;
        private byte[] MyFoto;
        private Int16 MyEdad;
        private DateTime MyFechaNacimiento;
        private string MyLugarNacimiento;
        private string MyNacionalidad;
        private DateTime MyFechaIngreso;
        private DateTime MyFechaVencimientoCarneSalud;
        private Int16 MyMutualista;
        private Int16 MyIdEmergenciaMedica;
        private Int16 MyCantidadHijos;
        private string MyTalleCamisa;
        private string MyTallePantalon;
        private Int16 MyTalleZapatos;
        private string MyTalleCampera;
        private DateTime MyFechaEgreso;
        private string MyMotivoEgreso;
        private bool MyCapacitadoPorteArma;
        private bool MyServicioArmado; // Marca si esta actualmente en un servicio armado.
        private bool MyAntecedentes; // S/A o C/A
        private string MyObservacionesAntecedentes;
        private float MySueldo;
        private Int16 MyIdBanco;
        private string MyNumeroCuenta;
        private string MyObservaciones;
        private string MyCAJ_Numero;
        private DateTime MyCAJ_FechaEmision;
        private DateTime MyCAJ_FechaEntrega;
        private DateTime MyBPS_FechaAltaEnBPS;
        private DateTime MyBPS_FechaBaja;
        private int MyBPS_AcumulacionLaboral;
        private DateTime MyFechaTestPsicologico;
        private bool MyAntecedentesPolicialesOMilitares;
        private DateTime MyFechaIngresoPolicialOMilitar;
        private DateTime MyFechaEgresoPolicialOMilitar;
        private string MySubEscalafon; // Si fue Policial
        private bool MyCombatiente; // Si fue Militar
        private DateTime MyFechaIngresoMesaRENAEMSE;
        private string MyNumeroAsuntoRENAEMSE;
        private bool MyActivo;
        
        
        #region Properties

        #region NumeroEmpleado
        public uint NumeroEmpleado
        {
            get
            {
                return MyNumeroEmpleado;
            }
            set
            {
                MyNumeroEmpleado = value;
            }
        } 
        #endregion

        public string Nombre
        {
            get
            {
                return MyNombre;
            }
            set
            {
                MyNombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return MyApellido;
            }
            set
            {
                MyApellido = value;
            }
        }

        public char Sexo
        {
            get
            {
                return MySexo;
            }
            set
            {
                MySexo = value;
            }
        }
        
        public Int16 TipoDocumento
        {
            get
            {
                return MyTipoDocumento;
            }
            set
            {
                MyTipoDocumento = value;
            }
        }

        public string NumeroDocumento
        {
            get
            {
                return MyNumeroDocumento;
            }
            set
            {
                MyNumeroDocumento = value;
            }
        }
        public Int16 Departamento
        {
            get
            {
                return MyDepartamento;
            }
            set
            {
                MyDepartamento = value;
            }
        }
        public string Ciudad
        {
            get
            {
                return MyCiudad;
            }
            set
            {
                MyCiudad = value;
            }
        }
        public string Barrio
        {
            get
            {
                return MyBarrio;
            }
            set
            {
                MyBarrio = value;
            }
        }
        public string Direccion
        {
            get
            {
                return MyDireccion;
            }
            set
            {
                MyDireccion = value;
            }
        }
        public string EstadoCivil
        {
            get
            {
                return MyEstadoCivil;
            }
            set
            {
                MyEstadoCivil = value;
            }
        }
        public string EntreCalles
        {
            get
            {
                return MyEntreCalles;
            }
            set
            {
                MyEntreCalles = value;
            }
        }
        public string Telefonos
        {
            get
            {
                return MyTelefonos;
            }
            set
            {
                MyTelefonos = value;
            }
        }
        public string Celular
        {
            get
            {
                return MyCelular;
            }
            set
            {
                MyCelular = value;
            }
        }
        public string CelularEnConvenio
        {
            get
            {
                return MyCelularEnConvenio;
            }
            set
            {
                MyCelularEnConvenio = value;
            }
        }
        public string DireccionDeEncuentro
        {
            get
            {
                return MyDireccionDeEncuentro;
            }
            set
            {
                MyDireccionDeEncuentro= value;
            }
        }
        public string Email
        {
            get
            {
                return MyEmail;
            }
            set
            {
                MyEmail = value;
            }
        }
        public byte[] Foto
        {
            get
            {
                return MyFoto;
            }
            set
            {
                MyFoto = value;
            }
        }
        public Int16 Edad
        {
            get
            {
                return MyEdad;
            }
            set
            {
                MyEdad = value;
            }
        }
        public DateTime FechaNacimiento
        {
            get
            {
                return MyFechaNacimiento;
            }
            set
            {
                MyFechaNacimiento = value;
            }
        }
        public string LugarNacimiento
        {
            get
            {
                return MyLugarNacimiento;
            }
            set
            {
                MyLugarNacimiento = value;
            }
        }
        public string Nacionalidad
        {
            get
            {
                return MyNacionalidad;
            }
            set
            {
               MyNacionalidad = value;
            }
        }
        public DateTime FechaIngreso
        {
            get
            {
                return MyFechaIngreso;
            }
            set
            {
                MyFechaIngreso = value;
            }
        }
        public DateTime FechaVencimientoCarneSalud
        {
            get
            {
                return MyFechaVencimientoCarneSalud;
            }
            set
            {
                MyFechaVencimientoCarneSalud = value;
            }
        }
        public Int16 Mutualista
        {
            get
            {
                return MyMutualista;
            }
            set
            {
                MyMutualista = value;
            }
        }
        public Int16 IdEmergenciaMedica
        {
            get
            {
                return MyIdEmergenciaMedica;
            }
            set
            {
                MyIdEmergenciaMedica = value;
            }
        }
        public Int16 CantidadHijos
        {
            get
            {
                return MyCantidadHijos;
            }
            set
            {
                MyCantidadHijos = value;
            }
        }
        public string TalleCamisa
        {
            get
            {
                return MyTalleCamisa;
            }
            set
            {
                MyTalleCamisa = value;
            }
        }
        public string TallePantalon
        {
            get
            {
                return MyTallePantalon;
            }
            set
            {
                MyTallePantalon = value;
            }
        }
        public Int16 TalleZapatos
        {
            get
            {
                return MyTalleZapatos;
            }
            set
            {
                MyTalleZapatos = value;
            }
        }
        public string TalleCampera
        {
            get
            {
                return MyTalleCampera;
            }
            set
            {
                MyTalleCampera = value;
            }
        }
        public DateTime FechaEgreso
        {
            get
            {
                return MyFechaEgreso;
            }
            set
            {
                MyFechaEgreso = value;
            }
        }
        public string MotivoEgreso
        {
            get
            {
                return MyMotivoEgreso;
            }
            set
            {
                MyMotivoEgreso = value;
            }
        }
        public bool CapacitadoPorteArma
        {
            get
            {
                return MyCapacitadoPorteArma;
            }
            set
            {
                MyCapacitadoPorteArma = value;
            }
        }
        public bool ServicioArmado // Marca si esta actualmente en un servicio armado.
        {
            get
            {
                return MyServicioArmado;
            }
            set
            {
                MyServicioArmado = value;
            }
        }
        public bool Antecedentes // S/A o C/A
        {
            get
            {
                return MyAntecedentes;
            }
            set
            {
                MyAntecedentes = value;
            }
        }
        public string ObservacionesAntecedentes
        {
            get
            {
                return MyObservacionesAntecedentes;
            }
            set
            {
                MyObservacionesAntecedentes = value;
            }
        }
        public float Sueldo
        {
            get
            {
                return MySueldo;
            }
            set
            {
                MySueldo = value;
            }
        }
        public Int16 IdBanco
        {
            get
            {
                return MyIdBanco;
            }
            set
            {
                MyIdBanco = value;
            }
        }
        public string NumeroCuenta
        {
            get
            {
                return MyNumeroCuenta;
            }
            set
            {
                MyNumeroCuenta = value;
            }
        }
        public string Observaciones
        {
            get
            {
                return MyObservaciones;
            }
            set
            {
                MyObservaciones = value;
            }
        }
        public string CAJ_Numero
        {
            get
            {
                return MyCAJ_Numero;
            }
            set
            {
                MyCAJ_Numero = value;
            }
        }
        public DateTime CAJ_FechaEmision
        {
            get
            {
                return MyCAJ_FechaEmision;
            }
            set
            {
                MyCAJ_FechaEmision = value;
            }
        }
        public DateTime CAJ_FechaEntrega
        {
            get
            {
                return MyCAJ_FechaEntrega;
            }
            set
            {
                MyCAJ_FechaEntrega = value;
            }
        }
        public DateTime BPS_FechaAltaEnBPS
        {
            get
            {
                return MyBPS_FechaAltaEnBPS;
            }
            set
            {
                MyBPS_FechaAltaEnBPS = value;
            }
        }
        public DateTime BPS_FechaBaja
        {
            get
            {
                return MyBPS_FechaBaja;
            }
            set
            {
                MyBPS_FechaBaja = value;
            }
        }
        public int BPS_AcumulacionLaboral
        {
            get
            {
                return MyBPS_AcumulacionLaboral;
            }
            set
            {
                MyBPS_AcumulacionLaboral = value;
            }
        }
        public DateTime FechaTestPsicologico
        {
            get
            {
                return MyFechaTestPsicologico;
            }
            set
            {
                MyFechaTestPsicologico = value;
            }
        }
        public bool AntecedentesPolicialesOMilitares
        {
            get
            {
                return MyAntecedentesPolicialesOMilitares;
            }
            set
            {
                MyAntecedentesPolicialesOMilitares = value;
            }
        }
        public DateTime FechaIngresoPolicialOMilitar
        {
            get
            {
                return MyFechaIngresoPolicialOMilitar;
            }
            set
            {
                MyFechaIngresoPolicialOMilitar = value;
            }
        }
        public DateTime FechaEgresoPolicialOMilitar
        {
            get
            {
                return MyFechaEgresoPolicialOMilitar;
            }
            set
            {
                MyFechaEgresoPolicialOMilitar = value;
            }
        }
        public string SubEscalafon // Si fue Policial
        {
            get
            {
                return MySubEscalafon;
            }
            set
            {
                MySubEscalafon = value;
            }
        }
        public bool Combatiente // Si fue Militar
        {
            get
            {
                return MyCombatiente;
            }
            set
            {
                MyCombatiente = value;
            }
        }
        public DateTime FechaIngresoMesaRENAEMSE
{
            get
            {
                return MyFechaIngresoMesaRENAEMSE;
            }
            set
            {
                MyFechaIngresoMesaRENAEMSE = value;
            }
        }
        public string NumeroAsuntoRENAEMSE
        {
            get
            {
                return MyNumeroAsuntoRENAEMSE;
            }
            set
            {
                MyNumeroAsuntoRENAEMSE = value;
            }
        }

        public bool Activo
        {
            get
            {
                return MyActivo;
            }
            set
            {
                MyActivo = value;
            }
        }
        
        #endregion

        




        
    }
}
