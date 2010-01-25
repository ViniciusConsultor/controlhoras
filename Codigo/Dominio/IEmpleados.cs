using System;
using System.Collections.Generic;
using System.Text;

namespace Logica
{
    interface IEmpleados
    {

        #region Empleado
            int altaEmpleado();
            void modificacionEmpleado();
            void bajaEmpleado();
            void buscarEmpleado();
            List<Empleado> obtenerEmpleados();
        #endregion

        #region ExtraLiquidacion
            void ingresarExtraLiquidacionEmpleado();
            void modificarExtraLiquidacionEmpleado();
            void bajaExtraLiquidacionEmpleado();
            List<ExtraLiquidacionEmpleado> obtenerExtrasLiquidacionEmpleado();
        #endregion

        #region EventoHistorial
            int ingresarEventoHistorialEmpleado();
            void modificarEventoHistorialEmpleado();
            void bajaEventoHistorialEmpleado();
            List<EventoHistorialEmpleado> obtenerEventosHistorialEmpleado();
        #endregion
    }
}
