using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using System.Threading;

namespace Presentacion
{
    public partial class Splash : Form
    {
        public enum StartConexion { SinConexion, Fallo, Ok }
        Thread hilos;
        NSplash splash1 = new NSplash();
        Configuracion configuracion = new Configuracion();
        StartConexion PruebaConex = StartConexion.SinConexion;
        public Splash()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hilos = new Thread(StartHilo);
            hilos.Start();

            Timer.Start();
        }

        private void StartHilo()
        {  
            if (!splash1.PruebaConexion())
            {
                PruebaConex = StartConexion.Fallo;
            }
            else
            {
                PruebaConex = StartConexion.Ok;
            }
            hilos.Abort();
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void Start()
        {
            if (PruebaConex.Equals(StartConexion.Ok))
            {
                lbDetalles.Text = "Conexion :" + PruebaConex.ToString();
                //login
            }
            else if (PruebaConex.Equals(StartConexion.Fallo))
            {
                if (configuracion.ShowDialog().Equals(DialogResult.OK))
                {
                    Application.Exit();                 
                    Application.Restart();
                    Timer.Stop();
                }
                else
                {
                    a = -1;
                    Timer.Start();
                }
            }
        }
        int a = 0;
        private void Timer_Tick(object sender, EventArgs e)
        {
            switch (a)
            {
                case 0:
                    lbDetalles.Text = "Validando...";
                    break;
                case 1:
                    lbDetalles.Text = "Conexion : " + PruebaConex.ToString();
                    break;
                case 2:                    
                    Timer.Stop();
                    Start();
                    break;
            }
            a++;
        }

        
    }
}
