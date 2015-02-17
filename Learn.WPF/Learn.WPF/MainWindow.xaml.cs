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

namespace Learn.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();

            Button btn = new Button()
            {
                Height = 50,
                Width = 200
            };
            btn.FontWeight = FontWeights.Bold;

            WrapPanel wpnl = new WrapPanel();

            TextBlock txt = new TextBlock();
            txt.Text = "Yellow";
            txt.Foreground = Brushes.Yellow;

            wpnl.Children.Add(txt);

            txt = new TextBlock();

            txt.Text = "Red";
            txt.Foreground = Brushes.Red;
            wpnl.Children.Add(txt);

            txt = new TextBlock()
            {
                Text = "No Color"
            };
            wpnl.Children.Add(txt);

            btn.Content = wpnl;
            pnlMain.Children.Add(btn);

            pnlMain.MouseDown += pnlMain_MouseUp;

        }

        private void pnlMain_MouseUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Clicked at position " + e.GetPosition(this).ToString());
        }

        private void Btn1_OnClick(object sender, RoutedEventArgs e)
        {
            lstBox.Items.Add(this.FindResource("Test").ToString());
            lstBox.Items.Add(Application.Current.FindResource("GlobalResourceString").ToString());
        }
    }
}
