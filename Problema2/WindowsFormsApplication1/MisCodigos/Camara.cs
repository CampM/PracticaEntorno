using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*********************************
Autor: Moisés Campón García
Fecha creación: 27/03/2016
Última modificación: 2/03/2016
Versión: 1.00
***********************************/

namespace WindowsFormsApplication1.MisCodigos
{
    public class Camara
    {
        private Random azar = new Random();
        private float vtc, vta, vtm;
        private ModosFuncionamiento modo, modoAnterior, modoNS;

        #region Propiedades
        /// <summary>
        /// Propiedad que devuelve vtc
        /// </summary>
        public float Vtc
        {
            get
            {
                return vtc;
            }
        }

        /// <summary>
        /// Propiedad que devuelve vta
        /// </summary>
        public float Vta
        {
            get
            {
                return vta;
            }
        }

        /// <summary>
        /// Propiedad que devuelve vtm
        /// </summary>
        public float Vtm
        {
            get
            {
                return vtm;
            }
        }

        /// <summary>
        /// Propiedad que devuelve el modo anterior de funcionamiento
        /// </summary>
        public ModosFuncionamiento ModoAnterior
        {
            get
            {
                return modoAnterior;
            }
        }

        /// <summary>
        /// Propiedad que devuelve el modo actual de funcionamiento
        /// </summary>
        public ModosFuncionamiento Modo
        {
            get
            {
                return modo;
            }
        }

        /// <summary>
        /// Propiedad que devuelve el modo de funcionamiento que se tenia antes de entrar al modo NonStop
        /// </summary>
        public ModosFuncionamiento ModoST
        {
            get
            {
                return modoNS;
            }
        }
        #endregion

        /// <summary>
        /// Constructor
        /// </summary>
        public Camara()
        {
            modo = ModosFuncionamiento.Apagado;
            modoAnterior = ModosFuncionamiento.Frigorifico;
            vta = (float)azar.NextDouble() * 15 + 20;
            vtc = vta;
        }

        /// <summary>
        /// Metodo encargado de controlar el modo de funcionamiento activo
        /// </summary>
        /// <param name="modo">Modo de funcionamiento introducido</param>
        public void ActivarModo(ModosFuncionamiento modo)
        {
            if (this.modo != ModosFuncionamiento.Apagado)
            {
                modoAnterior = this.modo;
                
            }

            this.modo = modo;

            switch (modo)
            {
                case ModosFuncionamiento.Frigorifico:
                    vtm = 2;
                    break;

                case ModosFuncionamiento.Congelador:
                    vtm = -18;
                    break;

                case ModosFuncionamiento.Vacaciones:
                    vtm = 10;
                    break;

                case ModosFuncionamiento.NonStop:
                    vtm = -28;
                    break;
            }

            if (this.modo != ModosFuncionamiento.NonStop && this.modo != ModosFuncionamiento.Apagado)
            {
                modoNS = this.modo;
            }
        }

        /// <summary>
        /// Metodo encargado de devolver la variacion de la temperatura ambiente segun la hora
        /// </summary>
        /// <returns>Variacion degún la hora</returns>
        public void VarAmbiente()
        {
            var hora = DateTime.Now;
            var maniana = DateTime.Today.AddHours(10);
            var tarde = DateTime.Today.AddHours(19);
            float num;

            if (hora >= maniana && hora < tarde)
            {
                num = (float)azar.NextDouble() * 29 + 1;
            }
            else
            {
                num = (float)-(azar.NextDouble() * 14 + 1);
            }

            vta += num / 1000.0f;
        }

        /// <summary>
        /// Metodo encargado de calcular la temperatura simulada
        /// </summary>
        public void VarCamara()
        {
            float n;
            if (vtc < vta && modo != ModosFuncionamiento.NonStop)
            {
                n = (float)azar.NextDouble() * 14 + 1;
                vtc -= (vta / 100.0f) - ((1.0f / vta) * (n / 5.0f));
            }

            if (modo == ModosFuncionamiento.Apagado || vtc <= vtm)
            {
                n = (float)azar.NextDouble() * 14 + 1;
                vtc += (vta / 100.0f) - ((1.0f / vta) * (n / 5.0f));
            }
            else
            {
                float d = (float)azar.NextDouble() * 29 + 1;
                vtc -= (vta / 20.0f) - ((1.0f / vta) * (d / 2.0f));
            }
        }

        /// <summary>
        /// Metodo encargado de aumentar la temperatura modificada
        /// </summary>
        public void AumentarTemp()
        {
            vtm++;
            if (vtm >= vta + 1)
            {
                vtm = vta + 1;
            }
        }

        /// <summary>
        /// Metodo encargado de reducir la temperatura modificada
        /// </summary>
        public void ReducirTemp()
        {
            vtm--;
            if (vtm < -29)
            {
                vtm = -29;
            }
        }
    }
}
