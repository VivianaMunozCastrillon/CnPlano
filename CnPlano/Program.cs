using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CnPlano
{
    internal class Program
    {
        /// <summary>
        /// Nombre:Viviana Muñoz
        /// Fecha:26/02/2023
        /// Descripcion:Programa que solicita un valor de un punto X y Y e imrime en que cuadrante se encuentra el punto.
        /// </summary>
        static void Main(string[] args)
        {
            //Instancia de clase
            ClsPlano plano = new ClsPlano();


            //Llamada de metodos
            plano.CargarValores();
            plano.Cuadrante();


            Console.ReadKey();
        }
    }
}
