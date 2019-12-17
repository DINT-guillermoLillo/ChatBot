using Microsoft.Azure.CognitiveServices.Knowledge.QnAMaker;
using Microsoft.Azure.CognitiveServices.Knowledge.QnAMaker.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        ObservableCollection<Mensaje> listaMensajes = new ObservableCollection<Mensaje>();

        public MainWindow()
        {
            InitializeComponent();
            mensajesItemsControl.DataContext = listaMensajes;
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
            listaMensajes.Clear();

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

        private async void Conexion() {
            string EndPoint = "https://botsergio.azurewebsites.net";
            string Key = "164b4f7b-d067-439f-9ef9-20d58c3d5ec8";
            string Id = "69e93d1d-6ccd-493d-8314-19e007646cf2";
            var cliente = new QnAMakerRuntimeClient(new EndpointKeyServiceClientCredentials(Key)) { RuntimeEndpoint = EndPoint };

            //Realizamos la pregunta a la API
            string pregunta = "Your question";
            QnASearchResultList response = await cliente.Runtime.GenerateAnswerAsync(Id, new QueryDTO { Question = pregunta });
            string respuesta = response.Answers[0].Answer;
        }


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
            listaMensajes.Add(new Mensaje (escribirTextBox.Text,"Usuario"));

            escribirTextBox.Clear();
        }
    }
}
