﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoClasses
{
    public interface IVeiculo
    {
        string Ligar();
        string Desligar();
        string Abastecer();
        string Desabastecer();
    }
}
