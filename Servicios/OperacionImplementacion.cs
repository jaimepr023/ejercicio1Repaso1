using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Repaso1.Servicios
{
    internal class OperacionImplementacion : OperacionInterfaz
    {
        public char afirmacion()
        {
            Console.WriteLine("¿Quieres volver a empezar?(s/n)");
            char afirmacion = Convert.ToChar(Console.ReadLine());
            return afirmacion;
        }

        public int pedirNumMin()
        {
            Console.WriteLine("Dame el numero de horas de un empleado(En minutos): ");
            int numMin = Int32.Parse(Console.ReadLine());
            return numMin;
        }

        public void operacion(int numMin)
        {
            int numHoras = numMin / 60;
            int numDias = numHoras / 8;
            int numHorasRest = numHoras % 8;
            int numMinRest = numMin % 60;
            Console.Write(numMin + "minutos son--> ");
            condicion(numHoras, numDias, numHorasRest, numMinRest);
        }

        private void condicion(int numHoras, int numDias, int numHorasRest, int numMinRest)
        {
            if(numDias > 1)
            {
               Console.Write(numDias + " dias ");
            }else if(numDias == 1) 
            {
                Console.Write(numDias + " dia ");
            }else 
            {

            }

            if (numHorasRest > 1)
            {
                Console.Write(numHorasRest + " Horas ");
            }else if( numMinRest == 1)
            {
                Console.Write(numHorasRest + " Hora ");
            }
            else
            {

            }

            if(numMinRest > 1)
            {
                Console.Write(numMinRest + " minutos ");
            }else if(numMinRest==1)
            {
                Console.Write(numMinRest + " minuto ");
            }
            else
            {

            }
        }
    }
}
