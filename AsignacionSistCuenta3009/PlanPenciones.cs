﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsignacionSistCuenta3009
{
    class PlanPenciones:Cuenta
    {
        public DateTime vencimiento { get; set; }
        public float cotización { get; set; }
        public string numCuentaOrigen { get; set; }

    }
}
