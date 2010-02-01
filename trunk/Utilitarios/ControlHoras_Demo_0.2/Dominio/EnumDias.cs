using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio
{
    static public class EnumDias
    {
        public enum Dias  { Lunes, Martes, Miercoles, Jueves, Viernes, Sabado, Domingo };

        static public  Dias stringToDia(string strdia)
        {
            switch (strdia)
            {
                case "Lunes":
                    return Dias.Lunes;
                case "Martes":
                    return Dias.Martes;
                case "Miercoles":
                    return Dias.Miercoles;
                case "Jueves":
                    return Dias.Jueves;
                case "Viernes":
                    return Dias.Viernes;
                case "Sabado":
                    return Dias.Sabado;
                case "Domingo":
                    return Dias.Domingo;
                default:
                    throw new Exception("No existe el dia " + strdia);
            }
        }

           
    }

    
}
