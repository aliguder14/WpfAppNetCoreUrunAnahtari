using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using NetCoreUrunAnahatari.Core;

namespace WpfAppNetCoreUrunAnahtari
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly UrunAnahtariIslemleri _urunAnahtariIslemleri;
        public MainWindow(UrunAnahtariIslemleri urunAnahtariIslemleri)
        {
            InitializeComponent();
            _urunAnahtariIslemleri = urunAnahtariIslemleri;

            //Deneme1 deneme1 = new Deneme1();
            string productKey = $"Ürün Anahtarı: {_urunAnahtariIslemleri.GetWindowsProductKey()}";
            txtBlkKey.Text = productKey;
            txtKey.Text = productKey;
        }
    }
}
