using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Learn.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Applicaiton_StartUp(object s, StartupEventArgs e)
        {
            MainWindow window = new MainWindow();

            window.Title = "New Window";
            if (e.Args.Length > 0)
            {
                MessageBox.Show("1st Args :" + e.Args[0]);
            }

            window.Show();
        }
    }
}
