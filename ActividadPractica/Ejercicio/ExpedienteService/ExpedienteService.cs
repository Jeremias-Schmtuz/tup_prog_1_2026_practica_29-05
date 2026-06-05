using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio.ExpedienteService
{
    internal class ExpedienteService
    {
        private string[] nombres = new string[100];
        private string[] DNIs = new string[100];
        private double[] montos = new double[100];
        private int contadorIngresados;

        public ExpedienteService()
        {

        }
        public void RegistrarExpediente(string nombre, string dni, double monto)
        {
            int idx = -1;
            int cont = 0;
            while (idx == -1 && cont < contadorIngresados)
            {
                if (DNIs[cont] == dni)
                {
                    idx = cont;
                }
                else
                {
                    nombres[contadorIngresados] = nombre;
                    DNIs[contadorIngresados] = dni;
                    montos[contadorIngresados] = monto;
                    contadorIngresados++;
                }
                cont++;
            }
        }
        public double CalcularTotal()
        {
            double montoTotal = 0;
            for (int i = 0; i < contadorIngresados; i++)
            {
                montoTotal += montos[i];
            }
            return montoTotal;
        }
        public double VerMayor()
        {
            double mayor = 0;
            for (int i = 0; i < contadorIngresados;i++)
            {
                if (montos[i] > mayor)
                {
                    mayor = montos[i];
                }
            }
            return mayor;
        }
        public int VerCantidadIngresados()
        {
            return contadorIngresados;
        }
        public string VerExpediente(int idx)
        {
            return $"{nombres[idx]}  |  {DNIs[idx]}  |  {montos[idx]}";
        }
        public void OrdenarPorDNIAcendiente()
        {
            double aux = 0;
            for (int i = 0; i < contadorIngresados; i++)
            {
                for (int j = 0; j < contadorIngresados - 1; j++)
                {
                    if (montos[i] > montos[j])
                    {
                        montos[i] > montos[j];
                    }
                }
            }
        }
    }
}