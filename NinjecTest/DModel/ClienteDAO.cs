using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NinjecTest.Datos;

namespace NinjecTest.DModel
{
    class ClienteDAO
    {
        private interfaces.IListarClientes _clientes;

        public ClienteDAO(interfaces.IListarClientes clientes)
        {
            _clientes = clientes;
        }

        public List<Clientes> listar()
        {
            return _clientes.getListado();
        }

    }
}
