using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPOOMapaDeClasesYinet
{
    public class Empleado : MiembroDeLaComunidad
    {
        public string Departamento { get; set; } = string.Empty;

        public override void MostrarRol()
        {
            Console.WriteLine("Soy un empleado.");
        }
    }
}
