﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    internal class Guitarra : InstrumentoMusical
    {
        public override void Tocar()
        {
            Console.WriteLine("El instrumento que esta sonando es una Guitarra.");
        }
    }
}
