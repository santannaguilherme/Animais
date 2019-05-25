﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interdicilinar.Animais
{
    interface IVoar
    {
        string Voar();
        int AltitudeMaximaEmMetros { get; set; }
        double VelocidadeDoVoo { get; set; }
    }
}
