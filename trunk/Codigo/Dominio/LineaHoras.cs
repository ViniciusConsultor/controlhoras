﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio
{
    public class LineaHoras
    {
        private string Puesto;
        private bool Armado;
        private List<HorarioXDia> Horario;
        private int CantidadEmpleado;
        private int CantidadHsNormales;
        private int CantidadHSExtras;
    }
}