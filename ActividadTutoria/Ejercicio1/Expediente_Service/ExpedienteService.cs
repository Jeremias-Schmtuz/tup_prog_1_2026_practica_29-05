using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1
{
    internal class ExpedienteService
    {
        string[100] nombres;
        string[100] DNIs;
        double[100] montos;
        int contadorIngresados;

        public ExpedienteService()
        {
            nombres = new string [100];
            DNIs = new string [100];
            montos = new double [100];
            contadorIngresados = 0;
        }

        public void RegistrarExpediente(string nombre, string dni, double monto)
        {
            nombres[contadorIngresados] = nombre;
            DNIs[contadorIngresados] = dni;
            montos[contadorIngresados] = monto;
        }
        public double CaluclarTotal()
        {
            if (contadorIngresados != 0)
            {
                double acumuladorMontos = 0;
                for (int i = 0; i < contadorIngresados; i++)
                {
                    acumuladorMontos += montos[contadorIngresados];

                }
                return acumuladorMontos;
            }
            else
            {
                return 0;
            }
        }

    }
}