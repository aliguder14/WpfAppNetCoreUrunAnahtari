using Microsoft.Extensions.DependencyInjection;
using NetCoreUrunAnahatari.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace WpfAppNetCoreUrunAnahtari
{
    public class ServiceLoader
    {
        public ServiceProvider DepencyInjectionServisleriniYukle()
        {

            var services = new ServiceCollection();

            services.AddTransient<Window>();
            services.AddTransient<MainWindow>();
            services.AddTransient<UrunAnahtariIslemleri>();

            ServiceProvider provider = services.BuildServiceProvider();
            Window window = provider.GetService<MainWindow>();

            return provider;
            
        }

    }
}
