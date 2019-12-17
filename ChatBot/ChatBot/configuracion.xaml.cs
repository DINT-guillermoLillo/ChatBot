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
using System.Windows.Shapes;

namespace ChatBot
{
    /// <summary>
    /// Lógica de interacción para configuracion.xaml
    /// </summary>
    public partial class configuracion : Window
    {
        public configuracion()
        {
            InitializeComponent();

            var colores = typeof(Colors).GetProperties();

            colorfondoComboBox.ItemsSource = colores;
            colorusuarioComboBox.ItemsSource = colores;
            colorrobotComboBox.ItemsSource = colores;

        }

        private void CancelarButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void AceptarButton_Click(object sender, RoutedEventArgs e)
        {
            //Properties.Settings.Default.colorFondo = ;
            //Properties.Settings.Default.Save();

            Close();

        }
    }
}
