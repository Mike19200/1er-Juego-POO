using System;
using Juego.Clases;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juego
{
    public partial class Juego : Form
    {
        JuegoClase juegoClase;
        juegoinicia = new JuegoClase( 15, 15, true, false);
        public Juego()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Juego Juego = Owner as Juego;
            Juego.Add(new Clases.JuegoClase(int contadorJugador1, int contadorJugador2,bool Boton1Activado, bool Boton2Activado));
            if (Boton1Activado == true)
            {
                Random random = new Random();
                int seleccion = random.Next(1, 4);
                if (Juego.contadorJugador1 > 0)
                {
                    if (seleccion == 1)
                    {
                        btnCartaJugador2.Text = "Piedra";
                        lblCCartas1.Text = $"{contadorJugador1 = contadorJugador1 - 1}";
                        Boton2Activado = true;
                        Boton1Activado = false;
                        return;
                    }
                    if (seleccion == 2)
                    {
                        btnCartaJugador2.Text = "Papel";
                        lblCCartas1.Text = $"{contadorJugador1 = contadorJugador1 - 1}";
                        Boton2Activado = true;
                        Boton1Activado = false;
                        return;
                    }
                    if (seleccion == 3)
                    {
                        btnCartaJugador2.Text = "Tijera";
                        lblCCartas1.Text = $"{contadorJugador1 = contadorJugador1 - 1}";
                        Boton2Activado = true;
                        Boton1Activado = false;
                        return;
                    }
                }
            }
        }
    }
}
