﻿using Database;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Text;

namespace Business
{
    public class Usuario : Base
    {
        public Usuario(string _nome, string _telefone, string _CPF)
        {
            this.Nome = _nome;
            this.Telefone = _telefone;
            this.CPF = _CPF;
        }

       

        public Usuario() { }

    }
}