using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Web.Script.Serialization;
using System.Xml.Serialization;
using NinjecTest.Datos;

namespace NinjecTest.DModel
{
    public class iListarClientesDep
    {
        public class lFromJSON : interfaces.IListarClientes
        {
            public List<Clientes> getListado()
            {
                StreamReader sRdr = null;
                JavaScriptSerializer serializador = new JavaScriptSerializer();
                List<Clientes> clientes = new List<Clientes>();
                Console.WriteLine("Listado de Clientes desde JSON");
                try
                {
                    sRdr = new StreamReader("clientes.json");
                    string json = sRdr.ReadToEnd();
                    clientes = serializador.Deserialize<List<Clientes>>(json);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error al leer el fichero JSON:" + e.Message);
                }
                finally
                {
                    if (sRdr != null)
                        sRdr.Dispose();
                }
                return clientes;
            }
        }
        public class lFromXML : interfaces.IListarClientes
        {
            public List<Clientes> getListado()
            {
                StreamReader sRdr = null;
                XmlSerializer serializador = new XmlSerializer(typeof(List<Clientes>));
                List<Clientes> clientes = new List<Clientes>();
                Console.WriteLine("Listado de Clientes desde XML");
                try
                {
                    sRdr = new StreamReader("clientes.xml");
                    clientes = (List<Clientes>)serializador.Deserialize(sRdr);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error al leer el fichero XML:" + e.Message);
                }
                finally
                {
                    if (sRdr != null)
                        sRdr.Dispose();
                }
                return clientes;
            }
        }
    }
}
