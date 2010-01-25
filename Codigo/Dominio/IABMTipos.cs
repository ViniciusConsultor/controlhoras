using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logica
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
