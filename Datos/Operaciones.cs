using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculadora00.Modelo;



namespace Calculadora00.Datos
{
    public class Operaciones
    {
        public int Sumar(NumeroModel modelo){
            return modelo.NumeroA + modelo.NumeroB;        
        }public int Restar(NumeroModel modelo){
            return modelo.NumeroA - modelo.NumeroB;        
        }public int Multiplicar(NumeroModel modelo){
            return modelo.NumeroA * modelo.NumeroB;        
        }public int Dividir(NumeroModel modelo){
            return modelo.NumeroA / modelo.NumeroB;        
        }
    }
}
