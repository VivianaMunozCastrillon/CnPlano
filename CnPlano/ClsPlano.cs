using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CnPlano
{
    internal class ClsPlano
    {
        //Declaracion de variables
        private double x;
        private double y;



        public double X { get; set; }
        public double Y { get; set; }

        //Metodos
        public void CargarValores()
        {
            Console.Write("Ingrese el valor de X : ");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de Y");
            y = double.Parse(Console.ReadLine());




        }


        public void Cuadrante()
        {
            if (x > 0 & y > 0)
            {
                Console.WriteLine("El punto esta en el primer cuadrante");
            }
            else if (x < 0 & y > 0)
            {
                Console.WriteLine("El punto esta en el segundo cuadrante");
            }

            else if (x < 0 & y < 0)
            {
                Console.WriteLine("El punto esta en el tercer cuadrante");
            }
            else if (x > 0 & y < 0)
            {
                Console.WriteLine("El punto esta en el cuarto cuadrante");

            }
            else
            {
                Console.WriteLine("El punto esta en el origen");
            }
        }
    }
}
