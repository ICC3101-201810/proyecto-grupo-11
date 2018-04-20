﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioApp
{
    class Alumno : Persona
    {
        int Deuda;
        List<string> MaterialArrendado;

        public Alumno(int miDeuda, List<string> miMaterialArrendado, string miNombre, string miApellido, string miRut, string miUsuario, string miPassword) : base(miNombre, miApellido, miRut, miUsuario, miPassword)
        {
            Deuda = miDeuda;
            MaterialArrendado = miMaterialArrendado;
        }
    }
}