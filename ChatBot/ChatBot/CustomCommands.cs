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
    }
}