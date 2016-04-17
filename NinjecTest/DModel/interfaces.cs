using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NinjecTest.Datos;

namespace NinjecTest.DModel
{
    public class interfaces
    {
        public interface IListarClientes
        {
            List<Clientes> getListado();
        }
    }
}
