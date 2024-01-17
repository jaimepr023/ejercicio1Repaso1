using Ejercicio1Repaso1.Servicios;

namespace Ejercicio1Repaso1.Controladores
{
    class program
    {
        public static void Main(string[] args)
        {
            OperacionInterfaz op = new OperacionImplementacion();
            char afirmacion;
            do
            {
                int numMin = op.pedirNumMin();
                op.operacion(numMin);
                afirmacion= op.afirmacion();
            } while (afirmacion=='s');
        }
    }
}