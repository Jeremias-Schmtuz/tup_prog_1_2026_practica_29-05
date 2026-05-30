using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1
{
    internal class ExpedienteService
    {
        #region Variables "GLOBALES"
        string[] nombres;
        string[] DNIs;
        double[] montos;
        int contadorIngresados;
        #endregion

        #region CONSTRUCTOR
        public ExpedienteService()
        {
            nombres = new string [100];
            DNIs = new string [100];
            montos = new double [100];
            contadorIngresados = 0;
        }
        #endregion

        #region REGISTRAR EXPEDIENTE
        public void RegistrarExpediente(string nombre, string dni, double monto)
        {
            nombres[contadorIngresados] = nombre;
            DNIs[contadorIngresados] = dni;
            montos[contadorIngresados] = monto;
            contadorIngresados++;
        }
        #endregion

        #region CALCULAR TOTAL
        public double CaluclarTotal()
        {
            if (contadorIngresados != 0)
            {
                double acumuladorMontos = 0;
                for (int i = 0; i < contadorIngresados; i++)
                {
                    acumuladorMontos += montos[i];

                }
                return acumuladorMontos;
            }
            else
            {
                return 0;
            }
        }
        #endregion

        #region VER MAYOR MONTO
        public double VerMayor()
        {
            double mayor = 0;
            for (int i = 0; i < contadorIngresados; i++)
            {
                if (montos[i] > mayor)
                {
                    mayor = montos[i];
                }
            }
            return mayor;
        }
        #endregion

        #region VER CANTIDAD DE INGRESADOS
        public int VerCantidadDeIngresados()
        {
            return contadorIngresados;
        }
        #endregion

        #region VER EXPEDIENTE
        public string VerExpediente(int idx)
        {
            return "Nombre: " + nombres[idx] + "| DNI: " + DNIs[idx] + "| Monto: " + montos[idx];
        }
        #endregion

        #region VER EXPEDIENTES
        public string[] VerExpedientes()
        {
            string[] expedientes = new string[contadorIngresados];
            for (int i = 0; i < contadorIngresados; i++)
            {
                expedientes[i] = "Nombre: " + nombres[i] + "   |   DNI: " + DNIs[i] + "   |   Monto: " + montos[i];
            }
            return expedientes;
        }
        #endregion
    }
}