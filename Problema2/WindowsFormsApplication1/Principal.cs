using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.MisCodigos;

/*********************************
Autor: Moisés Campón García
Fecha creación: 27/03/2016
Última modificación: 2/03/2016
Versión: 1.00
***********************************/

namespace WindowsFormsApplication1
{
    public partial class Principal : Form
    {

        public Form1 Padre { get; set; }
        private Random azar = new Random();
        private Camara camara;


        public Principal()
        {
            InitializeComponent();
            camara = new Camara();
            ActSistema();
            camara.VarAmbiente();
            ActualizarSensores();
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Padre.Close();
        }

        #region Botones_Interfaz
        private void btnPausaM_Click(object sender, EventArgs e)
        {
            btnPausaM.Enabled = false;
            gbTemperatura.Enabled = false;
            gbModos.Enabled = false;

            timerPausa.Enabled = true;
        }

        private void btnAumentarT_Click(object sender, EventArgs e)
        {
            camara.AumentarTemp();
            ActualizarSensores();
        }

        private void btnReducirT_Click(object sender, EventArgs e)
        {
            camara.ReducirTemp();
            ActualizarSensores();
        }

        private void rdEncenderApagarC_CheckedChanged(object sender, EventArgs e)
        {
            ActSistema();
            ActualizarSensores();
        }

        private void rbFrigorifico_CheckedChanged(object sender, EventArgs e)
        {
            camara.ActivarModo(ModosFuncionamiento.Frigorifico);
            ActualizarSensores();
        }

        private void rbCongelador_CheckedChanged(object sender, EventArgs e)
        {
            camara.ActivarModo(ModosFuncionamiento.Congelador);
            ActualizarSensores();
        }

        private void rbVacaciones_CheckedChanged(object sender, EventArgs e)
        {
            camara.ActivarModo(ModosFuncionamiento.Vacaciones);
            ActualizarSensores();
        }

        private void rbEncenderNS_CheckedChanged(object sender, EventArgs e)
        {
            rbFrigorifico.Enabled = false;
            rbCongelador.Enabled = false;
            rbVacaciones.Enabled = false;

            camara.ActivarModo(ModosFuncionamiento.NonStop);
            ActualizarSensores();
        }

        private void rbApagarNS_CheckedChanged(object sender, EventArgs e)
        {
            rbFrigorifico.Enabled = true;
            rbCongelador.Enabled = true;
            rbVacaciones.Enabled = true;

            camara.ActivarModo(camara.ModoST);
            ActualizarSensores();

        }

        private void rbCentigrados_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarSensores();
        }

        private void rbFahrenheit_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarSensores();
        }
        #endregion



        /// <summary>
        /// Metodo encargado de apagar o encender los botones del sistema.
        /// </summary>
        private void ActSistema()
        {
            if (rdEncenderC.Checked == true)
            {
                btnPausaM.Enabled = true;
                gbTemperatura.Enabled = true;
                gbModos.Enabled = true;

                camara.ActivarModo(camara.ModoAnterior);
            }
            else
            {
                btnPausaM.Enabled = false;
                gbTemperatura.Enabled = false;
                gbModos.Enabled = false;
                timerPausa.Enabled = false;

                camara.ActivarModo(ModosFuncionamiento.Apagado);
            }
        }

        /// <summary>
        /// Metodo encargado de mostrar los datos por los sensores
        /// </summary>
        private void ActualizarSensores()
        {
            if (camara.Vta < 0)
            {
                tbVta.ForeColor = Color.LightSkyBlue;
            }
            else
            {
                if (camara.Vta == 0)
                {
                    tbVta.ForeColor = Color.Black;
                }
                else {
                    tbVta.ForeColor = Color.Red;
                }
            }

            if (camara.Vtc < 0)
            {
                tbVtc.ForeColor = Color.LightSkyBlue;
            }
            else
            {
                if (camara.Vtc == 0)
                {
                    tbVtc.ForeColor = Color.Black;
                }
                else {
                    tbVtc.ForeColor = Color.Red;
                }
            }

            if (camara.Vtm < 0)
            {
                tbVtm.ForeColor = Color.LightSkyBlue;
            }
            else
            {
                if (camara.Vtm == 0)
                {
                    tbVtm.ForeColor = Color.Black;
                }
                else {
                    tbVtm.ForeColor = Color.Red;
                }
            }

            if (camara.Modo == ModosFuncionamiento.Apagado)
            {
                tbPiloto.Text = "Apagado";
                tbPiloto.ForeColor = Color.Red;
            }
            else
            {
                tbPiloto.Text = "Enfriando";
                tbPiloto.ForeColor = Color.LightSkyBlue;
            }

            if (rbFahrenheit.Checked)
            {
                float vtaF = Estatica.ConvvertirAFahrenheit(camara.Vta);
                float vtcF = Estatica.ConvvertirAFahrenheit(camara.Vtc);
                float vtmF = Estatica.ConvvertirAFahrenheit(camara.Vtm);

                tbVta.Text = vtaF.ToString("00.00");
                tbVtc.Text = vtcF.ToString("00.00");
                tbVtm.Text = vtmF.ToString("00.00");
            }
            else
            {
                tbVta.Text = camara.Vta.ToString("00.00");
                tbVtc.Text = camara.Vtc.ToString("00.00");
                tbVtm.Text = camara.Vtm.ToString("00.00");
            }

            

        }

        /// <summary>
        /// Timer encargado de la actualizacion de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick(object sender, EventArgs e)
        {
            camara.VarAmbiente();
            camara.VarCamara();
            ActualizarSensores();
        }

        /// <summary>
        /// Timer encargado de la pausa de 10 minutos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerPausa_Tick(object sender, EventArgs e)
        {
            btnPausaM.Enabled = true;
            gbTemperatura.Enabled = true;
            gbModos.Enabled = true;

            timerPausa.Enabled = false;
        }
    }
}
