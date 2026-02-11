using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPOOMapaDeClasesYinet
{
    internal class Administrativo : Empleado
    {
        public string Area { get; set; } = string.Empty;
        public override void MostrarRol()
        
        {
            Console.WriteLine("Soy un administrativo.");
        }
    }
}
