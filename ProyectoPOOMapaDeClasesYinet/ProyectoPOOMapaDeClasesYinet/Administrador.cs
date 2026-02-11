using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPOOMapaDeClasesYinet
{
    public class Administrador : Docente 
    {
        public override void MostrarRol() 
        
        {
            Console.WriteLine("Soy un administrador académico.");
        }
    }
}
