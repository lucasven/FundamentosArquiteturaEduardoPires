﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.DIP.Violacao
{
    public class Email
    {
        public string Endereco { get; set; }
        public bool Validar()
        {
            return Endereco.Contains("@");
        }
    }
}
