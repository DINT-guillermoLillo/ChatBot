using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ChatBot
{
    public static class CustomCommands
    {
        public static readonly RoutedUICommand VentanaConfig = new RoutedUICommand(
            "VentanaConfig",
            "VentanaConfig",
            typeof(CustomCommands),
            new InputGestureCollection(){
                new KeyGesture(Key.C,ModifierKeys.Control)
            }
        );
        public static readonly RoutedUICommand Salir = new RoutedUICommand(
            "Salir",
            "Salir",
            typeof(CustomCommands),
            new InputGestureCollection(){
                new KeyGesture(Key.S,ModifierKeys.Control)
            }
        );
        public static readonly RoutedUICommand GuardarConversacion = new RoutedUICommand(
            "GuardarConversacion",
            "GuardarConversacion",
            typeof(CustomCommands),
            new InputGestureCollection(){
                new KeyGesture(Key.G,ModifierKeys.Control)
            }
        );
        public static readonly RoutedUICommand NuevaConversacion = new RoutedUICommand(
            "NuevaConversacion",
            "NuevaConversacion",
            typeof(CustomCommands),
            new InputGestureCollection(){
                new KeyGesture(Key.N,ModifierKeys.Control)
            }
        );
        public static readonly RoutedUICommand Conexion = new RoutedUICommand(
            "Conexion",
            "Conexion",
            typeof(CustomCommands),
            new InputGestureCollection(){
                new KeyGesture(Key.O,ModifierKeys.Control)
            }
        );
    }
}