using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    class ExtraLiquidacionEmpleado
    {
        DateTime Fecha;
        string Descripcion;
        float Valor;
        char Signo; // + o - 
        bool Liquidado;
        Int16 CantidadCuotas;
        Int16 CuotaActual;
    }
}
