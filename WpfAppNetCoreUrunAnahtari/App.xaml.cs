using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WpfAppNetCoreUrunAnahtari
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            ServiceLoader serviceLoader = new ServiceLoader();
            ServiceProvider serviceProvider = serviceLoader.DepencyInjectionServisleriniYukle();
            Window mainWindow = serviceProvider.GetService<MainWindow>();
            Current.MainWindow = mainWindow;
            mainWindow.Show();
        }
    }
}
