using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot
{
    class Mensaje
    {
        public String icono { get; set; }

        public String texto { get; set; }

        public String emisor { get; set; }

        public String color { get; set; }

        public String alignment { get; set;}


        public Mensaje() {

        }

        public Mensaje(String icono, String texto, String emisor, String color, String alignment) {

            this.icono = icono;
            this.texto = texto;
            this.emisor = emisor;
            this.color = color;
            this.alignment = alignment;
        }

        public Mensaje(String texto, String emisor) {

            this.texto = texto;
            this.emisor = emisor;

            if (emisor == "Usuario")
            {
                this.icono = "Recursos\\user.ico";
                this.alignment = "left";
                this.color = Properties.Settings.Default.colorUsuario;
            }
            else
            {
                this.icono = "Recursos\\robot.ico";
                this.alignment = "right";
                this.color = Properties.Settings.Default.colorRobot;
            }
        }
    }
}
