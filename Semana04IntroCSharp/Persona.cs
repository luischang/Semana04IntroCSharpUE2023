﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Semana04IntroCSharp
{
    public class Persona
    {
        public int dni { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public bool active { get; set; }
        public Persona(int dni, string name, string phone, bool active)
        {
            this.dni = dni;
            this.name = name;
            this.phone = phone;
            this.active = active;
        }
        public Persona()
        {
                
        }
    }
}
