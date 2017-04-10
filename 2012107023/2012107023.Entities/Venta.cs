using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012107023.Entities
{
    public class Venta
    {

        public List<string> _ventas = new List<string>();

        string cabecera = "Numero\t\tTipo Plan\tTipo Evaluacion\t\tEstado\tt\tCliente";
        
        //tp= tipoplan , te= tipoevaluacion, Ee= Estadoevaluacion

        TipoPlan _tp = new TipoPlan();
        TipoEvaluacion _te = new TipoEvaluacion();
        EstadoEvaluacion _Ee = new EstadoEvaluacion();



        public void Agregar(string numero, string tp, string te, string Ee, string cliente) 
        {
            try
            {
               
                if (tp == "pre")
                {
                    Console.WriteLine("Se agrego el numero :" + numero + " al cliente :" + cliente);
                    Console.WriteLine("Tipo de plan :" + _tp.tipoplan1);

                    string nuevoPrep = "";
                    nuevoPrep += numero.ToString();
                    nuevoPrep += "\t"+_tp.tipoplan1.ToString();
                    nuevoPrep += "\t\t";
                    nuevoPrep += "\t\t\t";
                    nuevoPrep += "\t\t" + cliente.ToString();
 
                    _ventas.Add(nuevoPrep);
                    
                   
                }

                if (tp == "post")
                {
                    string nuevoPost = "";
                    switch (te)
                    {
                        case "Renovacion por contrato":
                            if (Ee == "Aprobado")
                            {
                                _ventas.Add(cabecera);
                                nuevoPost += numero.ToString();
                                nuevoPost += "\t" + _tp.tipoplan2.ToString();
                                nuevoPost += "\t" + _te.tipev1.ToString();
                                nuevoPost += "\t" +_Ee.estado1.ToString();
                                nuevoPost += "\t" + cliente.ToString();
                            }
                            else if (Ee == "Desaprobado") 
                            {
                                nuevoPost += numero.ToString();
                                nuevoPost += "\t" + _tp.tipoplan2.ToString();
                                nuevoPost += "\t" + _te.tipev1.ToString();
                                nuevoPost += "\t" + _Ee.estado2.ToString();
                                nuevoPost += "\t" + cliente.ToString();
                            }
                            _ventas.Add(nuevoPost);
                            break;
                        case "Portabilidad":
                            if (Ee == "Aprobado")
                            {
                                nuevoPost += numero.ToString();
                                nuevoPost += "\t" + _tp.tipoplan2.ToString();
                                nuevoPost += "\t" + _te.tipev2.ToString();
                                nuevoPost += "\t\t" + _Ee.estado1.ToString();
                                nuevoPost += "\t" + cliente.ToString();
                                _ventas.Add(nuevoPost);
                            }
                            else if (Ee =="Desaprobado" )
                            {
                                nuevoPost += numero.ToString();
                                nuevoPost += "\t" + _tp.tipoplan2.ToString();
                                nuevoPost += "\t" + _te.tipev2.ToString();
                                nuevoPost += "\t\t" + _Ee.estado2.ToString();
                                nuevoPost += "\t" + cliente.ToString();
                                _ventas.Add(nuevoPost);
                            }
                            break;
                        case "Linea Nueva":
                            if (Ee == "Aprobado")
                            {
                                nuevoPost += numero.ToString();
                                nuevoPost += "\t" + _tp.tipoplan2.ToString();
                                nuevoPost += "\t" + _te.tipev3.ToString();
                                nuevoPost += "\t\t" + _Ee.estado1.ToString();
                                nuevoPost += "\t" + cliente.ToString();
                                _ventas.Add(nuevoPost);
                            }
                            else if (Ee == "Desaprobado")
                            {
                                nuevoPost += numero.ToString();
                                nuevoPost += "\t" + _tp.tipoplan2.ToString();
                                nuevoPost += "\t" + _te.tipev3.ToString();
                                nuevoPost += "\t\t" + _Ee.estado2.ToString();
                                nuevoPost += "\t" + cliente.ToString();
                                _ventas.Add(nuevoPost);
                            }
                            break;
                        
                    }
                    Console.WriteLine("Se agrego el numero :" + numero + " al cliente :" + cliente);
                    Console.WriteLine("Tipo de plan :" + _tp.tipoplan2);

                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            
                    
        }


      
  }

}
