﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interdicilinar.Animais
{
    interface IAquatico
    {
        bool ViveEmAgua { get; }
        bool Mergulho { get;  }
        bool AguaDoce { get; }
    }
}
