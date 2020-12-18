using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Consola
{
    class Program
    {
        

        static void Main(string[] args)
        {
            
            double base1 = 0;
            double altura = 0;
            double lado = 0;
            double lado2 = 0;
            double lado3 = 0;
            double radio = 0;
            double basemayor =0;
            double basemenor = 0;
            double resultado;
            double n = 0;
            do
            {
                Console.WriteLine(n);
                n++;
                Console.WriteLine("           Calcular perimetros de las figuras");
                Console.WriteLine("Elegir una figura");
                Console.WriteLine("1.Cuadrado");
                Console.WriteLine("2.Rectangulo");
                Console.WriteLine("3.Triangulo");
                Console.WriteLine("4.Circulo");
                Console.WriteLine("5.Romboide");
                Console.WriteLine("6.Trapecio");
                Console.WriteLine("7.Pentagono");
                Console.WriteLine("8.Hexagono");
                Console.WriteLine("");
                resultado = double.Parse(Console.ReadLine());
                switch (resultado)
                {
                    case 1:
                        Console.WriteLine("Cuadrado");
                        Console.WriteLine("Ingrese un número");
                        lado = Convert.ToInt32(Console.ReadLine());
                        double cuadrado = (lado * 4);
                        Console.WriteLine(("El perimetro es: ") + cuadrado);
                        break;
                    case 2:
                        Console.WriteLine("Rectangulo");
                        Console.WriteLine("Ingrese primer número");
                        base1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese primer número");
                        altura = Convert.ToInt32(Console.ReadLine());
                        double rectangulo = ((base1 * 2) + (altura * 2));
                        Console.WriteLine(("El perimetro es: ") + rectangulo);
                        break;
                    case 3:
                        Console.WriteLine("Triangulo");
                        Console.WriteLine("Ingrese primer número");
                        lado = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese segundo número");
                        lado2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese tercer número");
                        lado3 = Convert.ToInt32(Console.ReadLine());
                        double triangulo = lado + lado2 + lado3;
                        Console.WriteLine(("El perimetro es: ") + triangulo);
                        break;
                    case 4:
                        Console.WriteLine("Circulo");
                        Console.WriteLine("Ingrese primer número");
                        radio = Convert.ToInt32(Console.ReadLine());
                        double circulo = (2 * Math.PI) * radio;
                        Console.WriteLine(("El perimetro es: ") + circulo);
                        break;
                    case 5:
                        Console.WriteLine("Romboide");
                        Console.WriteLine("Ingrese primer número");
                        base1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese segundo número");
                        altura = Convert.ToInt32(Console.ReadLine());
                        double romboide = base1 * altura;
                        Console.WriteLine(("El perimetro es: ") + romboide);
                        break;
                    case 6:
                        Console.WriteLine("Trapecio");
                        Console.WriteLine("Ingrese primer número");
                        basemayor= Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese segundo número");
                        basemenor = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese tercer número");
                        lado = Convert.ToInt32(Console.ReadLine());
                       double trapecio = basemayor + basemenor+(lado*2);
                        Console.WriteLine(("El perimetro es: ") + trapecio);
                        break;
                    case 7:
                        Console.WriteLine("Pentagono");
                        Console.WriteLine("Ingrese un número");
                        lado = Convert.ToInt32(Console.ReadLine());
                        double pentagono = (lado * 5);
                        Console.WriteLine(("El perimetro es: ") + pentagono);
                        break;
                    case 8:
                        Console.WriteLine("Hexagono");
                        Console.WriteLine("Ingrese un número");
                        lado = Convert.ToInt32(Console.ReadLine());
                        double hexagono = (lado * 6);
                        Console.WriteLine(("El perimetro es: ") + hexagono);
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Seleccione cualquier tecla para poder escojer otra figura");
                Console.ReadKey();
                
            }
            while (n < 9);
            
        
        }
        

        
    }
}
