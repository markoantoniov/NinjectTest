using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;

namespace NinjecTest.Ninject
{
    public class Contenedor
    {
        private static Contenedor instance = null;

        public IKernel kernel;

        private Contenedor()
        {
            kernel = new StandardKernel(new Dependencias());
        }

        public static Contenedor getInstance()
        {
            if (instance == null)
            {
                instance = new Contenedor();
            }
            return instance;
        }
    }
}
