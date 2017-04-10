using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _2012107023.Entities;
using System.Threading.Tasks;

namespace _2012107023
{
    class Program
    {
        static void Main(string[] args)
        {
            //numeros de telefono
           var fono1 = "969697627";
           var fono2 = "923517625";
           var fono3 = "943693786";
           var fono4 = "969583357";
           var fono5 = "924877628";
           var fono6 = "937459709";
            
            
            var venta = new Venta () ;

            venta.Agregar(fono1, "post", "Renovacion por contrato", "Aprobado", "Frank Flores");  
            venta.Agregar(fono2, "post", "Portabilidad", "Aprobado", "Frank Flores");
            venta.Agregar(fono3, "post", "Linea Nueva", "Aprobado", "Frank Flores");
            venta.Agregar(fono4, "post", "Linea Nueva", "Desaprobado", "Frank Flores");
            venta.Agregar(fono5, "post", "Renovacion por contrato", "Desaprobado", "Frank Flores");
            venta.Agregar(fono6, "pre", "Renovacion por contrato", "-", "Frank Flores");

            Console.WriteLine("Ingresar nombre del cliente");

            string buscar= Console.ReadLine();
            switch (buscar)
            {
                case "Frank Flores": for (int i = 0; i < 7; i++)
                    {
                        Console.WriteLine(venta._ventas[i]);
                    }
                        break;

                default: Console.WriteLine("Ninguna coincidencia");
                    break;

            }

        }
    }
}
