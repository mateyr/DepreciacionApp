﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOApps.service
{
    public class SDADecremental : IDpreciacion
    {
        public decimal[] CalcularDepreciacion(decimal valor, decimal valorR, int vidaUtil)
        {
            int factor = (vidaUtil * (vidaUtil + 1)) / 2;
            decimal[] dep = new decimal[vidaUtil];

            for (int i = 0, k = vidaUtil; i < vidaUtil; i++)
            {
                dep[i] = (valor - valorR) * k-- / factor;
            }

            return dep;
        }
    }
}
