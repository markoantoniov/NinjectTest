using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace NinjecTest.Datos
{
    [Serializable]
    public class Clientes
    {
        public string nombre { get; set; }
        public string apellidos { get; set; }
    }

}
