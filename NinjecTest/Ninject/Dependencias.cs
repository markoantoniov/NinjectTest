using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject.Modules;
using NinjecTest.DModel;

namespace NinjecTest.Ninject
{
    public class Dependencias : NinjectModule
    {
        public override void Load()
        {
            Bind<interfaces.IListarClientes>().To<iListarClientesDep.lFromJSON>();
            //throw new NotImplementedException();
        }
    }
}
