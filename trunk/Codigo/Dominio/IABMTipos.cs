using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio
{
    interface IABMTipos
    {

        #region TipoEmpleado
        int altaTipoEmpleado();
        void modificacionTipoEmpleado();
        void bajaTipoEmpleado();
        List<TipoEmpleado> obtenerTiposEmpleado();

        #endregion
    }
}
