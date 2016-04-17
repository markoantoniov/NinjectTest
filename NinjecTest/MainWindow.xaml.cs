using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Ninject;
using NinjecTest.Ninject;
using NinjecTest.DModel;
using NinjecTest.Datos;

namespace NinjecTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnDatosJSON_Click(object sender, RoutedEventArgs e)
        {
            Contenedor cnt = Contenedor.getInstance();
            cnt.kernel.Rebind<interfaces.IListarClientes>().To<iListarClientesDep.lFromJSON>();
            ClienteDAO clienteDAO = cnt.kernel.Get<ClienteDAO>();

            List<Clientes> lClientes = clienteDAO.listar();
            grdClientes.Items.Clear();
            foreach (Clientes cliente in lClientes)
            {
                grdClientes.Items.Add(cliente);
            }

            Console.WriteLine("Cargar datos en grid desde JSON");
        }

        private void btnDatosXML_Click(object sender, RoutedEventArgs e)
        {
            Contenedor cnt = Contenedor.getInstance();
            cnt.kernel.Rebind<interfaces.IListarClientes>().To<iListarClientesDep.lFromXML>();
            ClienteDAO clienteDAO = cnt.kernel.Get<ClienteDAO>();

            List<Clientes> lClientes = clienteDAO.listar();

            grdClientes.Items.Clear();
            foreach (Clientes cliente in lClientes)
            {
                grdClientes.Items.Add(cliente);
            }

            Console.WriteLine("Cargar datos en grid desde XML");
        }
    }
}
