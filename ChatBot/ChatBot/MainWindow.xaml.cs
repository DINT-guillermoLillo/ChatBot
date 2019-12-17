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

namespace ChatBot
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

    //VentanaConfig ------------------------------------------------------------------------------------------------------------------------------------------

        private void VentanaConfig_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            configuracion conf = new configuracion();

            conf.Owner = this;

            conf.ShowDialog();
        }

        private void VentanaConfig_CanExecuted(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }


    //Salir ------------------------------------------------------------------------------------------------------------------------------------------

        private void Salir_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Close();
        }

        private void Salir_CanExecuted(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }


    //Guardar Conversación ------------------------------------------------------------------------------------------------------------------------------------------

        private void GuardarConversacion_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            
        }

        private void GuardarConversacion_CanExecuted(object sender, CanExecuteRoutedEventArgs e)
        {
            ItemsControl itemsControl = new ItemsControl();
            itemsControl = mensajesItemsControl;

            if (itemsControl != null && mensajesItemsControl.HasItems)
                e.CanExecute = true;
            else
                e.CanExecute = false;

        }

    //Nueva Conversación ------------------------------------------------------------------------------------------------------------------------------------------
        private void NuevaConversacion_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            mensajesItemsControl.Items.Clear();

        }

        private void NuevaConversacion_CanExecuted(object sender, CanExecuteRoutedEventArgs e)
        {
            ItemsControl itemsControl = new ItemsControl();
            itemsControl = mensajesItemsControl;

            if (itemsControl != null && mensajesItemsControl.HasItems)
                e.CanExecute = true;
            else
                e.CanExecute = false;
        }

    //Conexión ------------------------------------------------------------------------------------------------------------------------------------------

        private void Conexion_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            //if ()
            //    MessageBox.Show("La conexión con el robot realizada", "Conexión", MessageBoxButton.OK, MessageBoxImage.Information);
            //else
            //    MessageBox.Show("La conexión con el robot no a sido efectiva", "Conexión Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void Conexion_CanExecuted(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

    //Boton Enviar ------------------------------------------------------------------------------------------------------------------------------------------

        private void enviarButton_Click(object sender, RoutedEventArgs e)
        {
            escribirTextBox.Clear();
        }
    }
}
