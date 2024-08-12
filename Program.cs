using System.Security.Claims;
using Calculadora00.Datos;
using Calculadora00.Modelo;

namespace caculadora00

// .::CALCULADORA::. Renee Toapanta, III nivel de Desarrollo Software/ Distancia

{
    class Program
    {
        static void Main(String [] args)
        {
            Ejecutar();
        }
        private static void Ejecutar(){

            bool continuar=true;
            while (continuar == true) {

                Operaciones operar = new Operaciones();
                NumeroModel modelo = new NumeroModel();

               
                Console.WriteLine("Ingrese la operación que desea realizar: SUMA (s), RESTA(r), MULTIPLICACION (m), DIVISION (d)");
                String operacion = Console.ReadLine();

                Console.WriteLine("Digita el primer número");
                modelo.NumeroA = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digita el segundo número");
                modelo.NumeroB = Convert.ToInt32(Console.ReadLine());

                switch (operacion) {
                    case "s":
                        Console.WriteLine("La suma de estos numeros es:" + operar.Sumar(modelo));
                        goto case "SALIR";
                        break;

                    case "r":
                        Console.WriteLine("La resta de estos numeros es:" + operar.Restar(modelo));
                        goto case "SALIR";
                        break;

                    case "m":
                        Console.WriteLine("La multiplicación de estos numeros es:" + operar.Multiplicar(modelo));
                        goto case "SALIR";
                        break;
                    case "d":
                        Console.WriteLine("La división de estos numeros es:" + operar.Dividir(modelo));
                        goto case "SALIR";
                        break;
                    case "SALIR":
                        Console.WriteLine();
                        Console.WriteLine("Desea continuar SI (s) o NO (n)");
                        string decide = Console.ReadLine();
                        if (decide == "n")
                        {
                            continuar = false;
                        }
                        break;

                    default:
                        Console.WriteLine("La opción seleccionada no es aceptada, intentelo nuevamente");
                        break;
                }
            }

        }
        
    }
 
}
