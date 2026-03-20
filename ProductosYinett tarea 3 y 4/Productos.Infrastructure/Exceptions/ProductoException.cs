using System;
using System.Collections.Generic;
using System.Text;

namespace Productos.Infrastructure.Exceptions
{
    public class ProductoException : Exception
    {
        public ProductoException(string message) : base(message) { }
    }
}
