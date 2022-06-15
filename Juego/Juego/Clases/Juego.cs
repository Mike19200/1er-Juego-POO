using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juego.Clases
{
    public class JuegoClase
    {
        public int contadorJugador1 = 15;
        public int contadorJugador2 = 15;

        public bool Boton1Activado = true;
        public bool Boton2Activado = false;
        JuegoClase(int contadorJugador1, int contadorJugador2, bool Boton1Activado, bool Boton2Activado)
        {
            this.contadorJugador1 = contadorJugador1;
            this.contadorJugador2 = contadorJugador2;

            this.Boton1Activado = Boton1Activado;
            this.Boton2Activado = Boton2Activado;

        }
    }
}
