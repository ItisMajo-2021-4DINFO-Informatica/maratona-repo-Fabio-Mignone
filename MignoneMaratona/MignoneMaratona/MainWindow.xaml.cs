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

namespace MignoneMaratona
{
    public partial class MainWindow : Window
    {
        Maratone maratone;
        public MainWindow()
        {
            InitializeComponent();
            maratone = new Maratone();
            DgVisualizza.ItemsSource = maratone.ElencoMaratona;
        }

        private void BtnCaricaDati_Click(object sender, RoutedEventArgs e)
        {
            maratone.LeggiDati();
            DgVisualizza.Items.Refresh();
        }

        private void BtnVerificaPresenza_Click(object sender, RoutedEventArgs e)
        {
            string citta = txtcitta.Text;
            lblcittàsrc.Content = maratone.Verificacitta(citta);
        }
    }
}
