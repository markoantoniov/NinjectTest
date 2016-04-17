using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
using NinjecTest.Ninject;

namespace NinjecTest
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        private void Application_Startup(object sender, StartupEventArgs e)
        {   
            MainWindow mainView = new MainWindow();
            mainView.Show();
        }
    }
}
