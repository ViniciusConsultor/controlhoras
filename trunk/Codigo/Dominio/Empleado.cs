using System;
using System.Collections.Generic;
using System.Text;

namespace Logica
{
    public class Empleado
    {
        #region Properties

        #region NumeroEmpleado
        public int NumeroEmpleado
        {
            get
            {
                return NumeroEmpleado;
            }
            set
            {
                NumeroEmpleado = value;
            }
        } 
        #endregion

        public string Nombre
        {
            get
            {
                return Nombre;
            }
            set
            {
                Nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return Apellido;
            }
            set
            {
                Apellido = value;
            }
        }

        public char Sexo
        {
            get
            {
                return Sexo;
            }
            set
            {
                Sexo = value;
            }
        }
        
        public Int16 TipoDocumento
        {
            get
            {
                return TipoDocumento;
            }
            set
            {
                TipoDocumento = value;
            }
        }

        public string NumeroDocumento
        {
            get
            {
                return NumeroDocumento;
            }
            set
            {
                NumeroDocumento = value;
            }
        }
        public Int16 Departamento
        {
            get
            {
                return Departamento;
            }
            set
            {
                Departamento = value;
            }
        }
        public string Ciudad
        {
            get
            {
                return Ciudad;
            }
            set
            {
                Ciudad = value;
            }
        }
        public string Barrio
        {
            get
            {
                return Barrio;
            }
            set
            {
                Barrio = value;
            }
        }
        public string Direccion
        {
            get
            {
                return Direccion;
            }
            set
            {
                Direccion = value;
            }
        }
        public string EstadoCivil
        {
            get
            {
                return EstadoCivil;
            }
            set
            {
                EstadoCivil = value;
            }
        }
        public string EntreCalles
        {
            get
            {
                return EntreCalles;
            }
            set
            {
                EntreCalles = value;
            }
        }
        public string Telefonos
        {
            get
            {
                return Telefonos;
            }
            set
            {
                Telefonos = value;
            }
        }
        public string Celular
        {
            get
            {
                return Celular;
            }
            set
            {
                Celular = value;
            }
        }
        public string CelularEnConvenio
        {
            get
            {
                return CelularEnConvenio;
            }
            set
            {
                CelularEnConvenio = value;
            }
        }
        public string DireccionDeEncuentro
        {
            get
            {
                return DireccionDeEncuentro;
            }
            set
            {
                DireccionDeEncuentro= value;
            }
        }
        public string Email
        {
            get
            {
                return Email;
            }
            set
            {
                Email = value;
            }
        }
        public byte[] Foto
        {
            get
            {
                return Foto;
            }
            set
            {
                Foto = value;
            }
        }
        public Int16 Edad
        {
            get
            {
                return Edad;
            }
            set
            {
                Edad = value;
            }
        }
        public DateTime FechaNacimiento
        {
            get
            {
                return FechaNacimiento;
            }
            set
            {
                FechaNacimiento = value;
            }
        }
        public string LugarNacimiento
        {
            get
            {
                return LugarNacimiento;
            }
            set
            {
                LugarNacimiento = value;
            }
        }
        public string Nacionalidad
        {
            get
            {
                return Nacionalidad;
            }
            set
            {
               Nacionalidad  = value;
            }
        }
        public DateTime FechaIngreso
        {
            get
            {
                return FechaIngreso;
            }
            set
            {
                FechaIngreso = value;
            }
        }
        public DateTime FechaVencimientoCarneSalud
        {
            get
            {
                return FechaVencimientoCarneSalud;
            }
            set
            {
                FechaVencimientoCarneSalud = value;
            }
        }
        public string Mutualista
        {
            get
            {
                return Mutualista;
            }
            set
            {
                Mutualista = value;
            }
        }
        public string EmergenciaMedica
        {
            get
            {
                return EmergenciaMedica;
            }
            set
            {
                EmergenciaMedica = value;
            }
        }
        public Int16 CantidadHijos
        {
            get
            {
                return CantidadHijos;
            }
            set
            {
                CantidadHijos = value;
            }
        }
        public Int16 TalleCamisa
        {
            get
            {
                return TalleCamisa;
            }
            set
            {
                TalleCamisa = value;
            }
        }
        public Int16 TallePantalon
        {
            get
            {
                return TallePantalon;
            }
            set
            {
                TallePantalon = value;
            }
        }
        public Int16 TalleZapatos
        {
            get
            {
                return TalleZapatos;
            }
            set
            {
                TalleZapatos = value;
            }
        }
        public Int16 TalleCampera
        {
            get
            {
                return TalleCampera;
            }
            set
            {
                TalleCampera = value;
            }
        }
        public DateTime FechaEgreso
        {
            get
            {
                return FechaEgreso;
            }
            set
            {
                FechaEgreso = value;
            }
        }
        public string MotivoEgreso
        {
            get
            {
                return MotivoEgreso;
            }
            set
            {
                MotivoEgreso = value;
            }
        }
        public bool CapacitadoPorteArma
        {
            get
            {
                return CapacitadoPorteArma;
            }
            set
            {
                CapacitadoPorteArma = value;
            }
        }
        public bool ServicioArmado // Marca si esta actualmente en un servicio armado.
        {
            get
            {
                return ServicioArmado;
            }
            set
            {
                ServicioArmado = value;
            }
        }
        public bool Antecedentes // S/A o C/A
        {
            get
            {
                return Antecedentes;
            }
            set
            {
                Antecedentes = value;
            }
        }
        public string ObservacionesAntecedentes
        {
            get
            {
                return ObservacionesAntecedentes;
            }
            set
            {
                ObservacionesAntecedentes = value;
            }
        }
        public float Sueldo
        {
            get
            {
                return Sueldo;
            }
            set
            {
                Sueldo = value;
            }
        }
        public string Banco
        {
            get
            {
                return Banco;
            }
            set
            {
                Banco = value;
            }
        }
        public string NumeroCuenta
        {
            get
            {
                return NumeroCuenta;
            }
            set
            {
                NumeroCuenta = value;
            }
        }
        public string Observaciones
        {
            get
            {
                return Observaciones;
            }
            set
            {
                Observaciones = value;
            }
        }
        public int CAJ_Numero
        {
            get
            {
                return CAJ_Numero;
            }
            set
            {
                CAJ_Numero = value;
            }
        }
        public DateTime CAJ_FechaEmision
        {
            get
            {
                return CAJ_FechaEmision;
            }
            set
            {
                CAJ_FechaEmision = value;
            }
        }
        public DateTime CAJ_FechaEntrega
        {
            get
            {
                return CAJ_FechaEntrega;
            }
            set
            {
                CAJ_FechaEntrega = value;
            }
        }
        public DateTime BPS_FechaAltaEnBPS
        {
            get
            {
                return BPS_FechaAltaEnBPS;
            }
            set
            {
                BPS_FechaAltaEnBPS = value;
            }
        }
        public DateTime BPS_FechaBaja
        {
            get
            {
                return BPS_FechaBaja;
            }
            set
            {
                BPS_FechaBaja = value;
            }
        }
        public int BPS_AcumulacionLaboral
        {
            get
            {
                return BPS_AcumulacionLaboral;
            }
            set
            {
                BPS_AcumulacionLaboral = value;
            }
        }
        public DateTime FechaTestPsicologico
        {
            get
            {
                return FechaTestPsicologico;
            }
            set
            {
                FechaTestPsicologico = value;
            }
        }
        public bool AntecedentesPolicialesOMilitares
        {
            get
            {
                return AntecedentesPolicialesOMilitares;
            }
            set
            {
                AntecedentesPolicialesOMilitares = value;
            }
        }
        public DateTime FechaIngresoPolicialOMilitar
        {
            get
            {
                return FechaIngresoPolicialOMilitar;
            }
            set
            {
                FechaIngresoPolicialOMilitar = value;
            }
        }
        public DateTime FechaEgresoPolicialOMilitar
        {
            get
            {
                return FechaEgresoPolicialOMilitar;
            }
            set
            {
                FechaEgresoPolicialOMilitar = value;
            }
        }
        public string SubEscalafon // Si fue Policial
        {
            get
            {
                return SubEscalafon;
            }
            set
            {
                SubEscalafon = value;
            }
        }
        public string Combatiente // Si fue Militar
        {
            get
            {
                return Combatiente;
            }
            set
            {
                Combatiente = value;
            }
        }
        public DateTime FechaIngresoMesaRENAEMSE
{
            get
            {
                return FechaIngresoMesaRENAEMSE;
            }
            set
            {
                FechaIngresoMesaRENAEMSE = value;
            }
        }
        public int NumeroAsuntoRENAEMSE
        {
            get
            {
                return NumeroAsuntoRENAEMSE;
            }
            set
            {
                NumeroAsuntoRENAEMSE = value;
            }
        }
        
        #endregion

        




        
    }
}
