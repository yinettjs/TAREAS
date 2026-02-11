using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPOOMapaDeClasesYinet
{
    public class Docente : Empleado 
    { public string Materia { get; set; } = string.Empty;
        public override void MostrarRol() 

        {
            Console.WriteLine("Soy un docente.");
        }
    }
}