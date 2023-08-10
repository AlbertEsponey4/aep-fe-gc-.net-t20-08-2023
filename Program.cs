using System;

namespace Tarea19
{
    class Program
    {
        static void Ejercicio1()
        {
            Console.WriteLine("Ejercicio 1:\n");

            int A = 3;
            int B = 4;
            int C = 5;

            Console.WriteLine($"A = {A} \nB = {B} \nC = {C}");
            int suma = A + B + C;
            Console.WriteLine("Suma: " + suma);
        }

        static void Ejercicio2()
        {
            Console.WriteLine("Ejercicio 2:\n");

            Console.WriteLine("Ingrese un nombre:");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese una ciudad:");
            string ciudad = Console.ReadLine();

            Console.WriteLine($"Hola {nombre}, bienvenido a {ciudad}");
        }

        static void Ejercicio3()
        {
            Console.WriteLine("Ejercicio 3:\n");

            Console.WriteLine("Ingresa el nombre:");
            string nombre = Console.ReadLine() ;

            Console.WriteLine("Ingresa la edad:"); 
            int edad = int.Parse(Console.ReadLine() );

            Console.WriteLine($"Te llamas {nombre} y tienes {edad}");
        }

        static void Ejercicio4()
        {
            Console.WriteLine("Ejercicio 4:\n");

            Console.WriteLine("Ingresa priemr numero:");
            int A = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa segundo numero:");
            int B = int.Parse(Console.ReadLine());

            if (A > B)
            {
                Console.WriteLine("El más grande es " + A);
            }
            else
            {
                Console.WriteLine("El mas grande es " + B);
            }
        }

        static void Ejercicio5()
        {
            Console.WriteLine("Ejercicio 5:\n");

            Console.WriteLine("Ingresa un dia de la semana: (en minusculas)");
            string dia = Console.ReadLine();

            if (dia == "sabado" || dia == "sábado" || dia == "domingo")
            {
                Console.WriteLine("Es fin de semana");
            }
            else if (dia == "lunes" || dia == "martes" || dia == "miércoles" || dia == "miercoles" ||
                     dia == "jueves" || dia == "viernes")
            {
                Console.WriteLine("No es fin de semana");
            }
            else
            {
                Console.WriteLine("El nombre que has introducido no es valido");
            }
        }
        static void Ejercicio6()
        {
            Console.WriteLine("Ejercicio 6:\n");

            Console.Write("Ingresa el precio del producto: ");
            double precioProducto = double.Parse(Console.ReadLine());

            if (precioProducto < 0)
            {
                Console.WriteLine("Error: precio negativo");
            } 
            else
            {
                Console.WriteLine("Ingrese la forma de pago: \nE: efectivo\nT: targeta");
                string formaPago = Console.ReadLine();

                if (formaPago == "E")
                {
                    Console.WriteLine("pagando en efectivo");
                }
                else if (formaPago == "T")
                {
                    Console.Write("Ingrese el número de cuenta: ");
                    string numeroCuenta = Console.ReadLine();

                    Console.WriteLine("pagando en targeta en: " + numeroCuenta);
                }
                else
                {
                    Console.WriteLine("Has introducido una forma de pago que no es ni E ni T");
                }
            }
        }

        static void Ejercicio7()
        {
            Console.WriteLine("Ejercicio 7:\n");

            for (int i = 1; i <= 100; i++)
            {
                Console.Write(i + ", ");
            }

            Console.WriteLine("\n");
        }

        static void Ejercicio8()
        {
            Console.WriteLine("Ejercicio 8:\n");

            int i = 1;
            while (i <= 100)
            {
                Console.Write(i + ", ");
                i++;
            }
            Console.WriteLine("\n");
        }

        static void Ejercicio9()
        {
            Console.WriteLine("Ejercicio 9:\n");

            for (int i = 2; i <= 100; i = i + 2)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine("\n");
        }

        static void Ejercicio10()
        {
            Console.WriteLine("Ejercicio 10:\n");

            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0 || i % 3 == 0)
                {
                    Console.Write(i + ", ");
                }
            }
            Console.WriteLine("\n");
        }

        static void Ejercicio11()
        {
            Console.WriteLine("Ejercicio 11:\n");

            int A = 23;
            int B = 555;

            if (A > B)
            {
                Console.WriteLine("El mayor es " + A);
            }
            else if (B > A)
            {
                Console.WriteLine("El mayor es " + B);
            }
            else
            {
                Console.WriteLine("Los numeros son iguales");
            }


        }

        static void Ejercicio12()
        {
            Console.WriteLine("Ejercicio 12:\n");

            string nombre = "Fernando";
            Console.WriteLine("Bienvenido " + nombre);

        }

        static void Ejercicio13()
        {
            Console.WriteLine("Ejercicio 13:\n");

            Console.Write("Por favor, introduce tu nombre: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Bienvenido " + nombre);

        }

        static void Ejercicio14()
        {
            Console.WriteLine("Ejercicio 14:\n");

            Console.WriteLine("AREA CIRCULO");

            Console.Write("radio: ");
            double radio = double.Parse(Console.ReadLine());

            double area = Math.PI * Math.Pow(radio, 2);

            Console.WriteLine("El area del circulo es: " + area);


        }

        static void Ejercicio15()
        {
            Console.WriteLine("Ejercicio 15:\n");

            Console.Write("Introduce un numero: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("Es divisible entre 2.");
            }
            else
            {
                Console.WriteLine("NO es divisible entre 2.");
            }

        }

        static void Ejercicio16()
        {
            Console.WriteLine("Ejercicio 16:\n");
            const int IVA = 21;

            Console.Write("Precio del producto: ");
            double precio = double.Parse(Console.ReadLine());

            double soloIVA = (precio * (IVA)) / 100;
            double precioConIVA = soloIVA + precio;

            Console.WriteLine("El precio con IVA es: " + precioConIVA);
        }

        static void Ejercicio17()
        {
            Console.WriteLine("Ejercicio 17:\n");

            int i = 1;
            while (i <= 100)
            {
                Console.Write(i + ", ");
                i++;
            }
            Console.WriteLine("\n");
        }

        static void Ejercicio18()
        {
            Console.WriteLine("Ejercici 18:\n");

            for (int i = 1; i <= 100; i++)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine("\n");
        }

        static void Ejercicio19()
        {
            Console.WriteLine("Ejercicio 19:\n");

            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0 || i % 3 == 0)
                {
                    Console.Write(i + ", ");
                }
            }
            Console.WriteLine("\n");
        }

        static void Ejercicio20()
        {
            Console.WriteLine("Ejercicio 20:\n");

            Console.Write("Numero de ventas: ");
            int numeroVentas = int.Parse(Console.ReadLine());

            double suma = 0;
            for (int i = 1; i <= numeroVentas; i++)
            {
                Console.Write("Precio de la venta " + i + ": ");
                double venta = double.Parse(Console.ReadLine());
                suma += venta;
            }

            Console.WriteLine("Precio total de todas las ventas: " + suma);
        }

        static void Ejercicio21()
        {
            Console.WriteLine("Ejercicio 21:\n");

            Console.Write("Ingresa un dia de la semana en minsculas: ");
            string dia = Console.ReadLine();

            switch (dia)
            {
                case "lunes":
                    Console.WriteLine("El un lunes es un dia laboral");
                    break;
                case "martes":
                    Console.WriteLine("El un martes es un dia laboral");
                    break;
                case "miércoles":
                    Console.WriteLine("El un miercoles es un dia laboral");
                    break;
                case "miercoles":
                    Console.WriteLine("El un miercoles es un dia laboral");
                    break;
                case "jueves":
                    Console.WriteLine("El un jueves es un dia laboral");
                    break;
                case "viernes":
                    Console.WriteLine("El un viernes es un dia laboral");
                    break;
                case "sábado":
                    Console.WriteLine("El sabado NO es un dia laboral");
                    break;
                case "sabado":
                    Console.WriteLine("El sabado NO es un dia laboral");
                    break;
                case "domingo":
                    Console.WriteLine("El domingo NO es un dia laboral");
                    break;
                default:
                    Console.WriteLine("Has introducido mal el dia");
                    break;
            }

        }

        static void Ejercicio22()
        {
            Console.WriteLine("Ejercicio 22:\n");

            string pass = "12345";

            int intentos = 3;

            Console.Write("Introduce la contraseña: ");
            string passIntroducida = Console.ReadLine();

            while (intentos > 0 && passIntroducida != pass)
            {
                intentos--;
                Console.WriteLine("Contraseña incorrecta. Intentos: " + intentos);

                Console.Write("Introduce la contraseña: ");
                passIntroducida = Console.ReadLine();
            }

            if (intentos == 0)
            {
                Console.WriteLine("Has agotado tus intentos. Acceso denegado.");
            }
            else
            {
                Console.WriteLine("¡Enhorabuena!");
            }
        }

        static void Ejercicio23()
        {
            Console.WriteLine("Ejercicio 23:\n");

            Console.Write("Ingrese el primer numero: ");
            int operando1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo numero: ");
            int operando2 = int.Parse(Console.ReadLine());

            Console.Write("Escoge la operacion introduciendo el signo: (+, -, *, /, ^, %): ");
            string signo = Console.ReadLine();

            double resultado = 0;
            switch (signo)
            {
                case "+":
                    resultado = operando1 + operando2;
                    break;
                case "-":
                    resultado = operando1 - operando2;
                    break;
                case "*":
                    resultado = operando1 * operando2;
                    break;
                case "/":
                    resultado = (double)operando1 / operando2;
                    break;
                case "^":
                    resultado = Math.Pow(operando1, operando2);
                    break;
                case "%":
                    resultado = operando1 % operando2;
                    break;
                default:
                    Console.WriteLine("error en el signo");
                    break;
            }

            Console.WriteLine("Resultado: " + resultado);
        }
        static void Main(string[] args)
        {
            Ejercicio1();
            Console.WriteLine("----------------------\n\n");
            Ejercicio2();
            Console.WriteLine("----------------------\n\n");
            Ejercicio3();
            Console.WriteLine("----------------------\n\n");
            Ejercicio4();
            Console.WriteLine("----------------------\n\n");
            Ejercicio5();
            Console.WriteLine("----------------------\n\n");
            Ejercicio6();
            Console.WriteLine("----------------------\n\n");
            Ejercicio7();
            Console.WriteLine("----------------------\n\n");
            Ejercicio8();
            Console.WriteLine("----------------------\n\n");
            Ejercicio9();
            Console.WriteLine("----------------------\n\n");
            Ejercicio10();
            Console.WriteLine("----------------------\n\n");
            Ejercicio11();
            Console.WriteLine("----------------------\n\n");
            Ejercicio12();
            Console.WriteLine("----------------------\n\n");
            Ejercicio13();
            Console.WriteLine("----------------------\n\n");
            Ejercicio14();
            Console.WriteLine("----------------------\n\n");
            Ejercicio15();
            Console.WriteLine("----------------------\n\n");
            Ejercicio16();
            Console.WriteLine("----------------------\n\n");
            Ejercicio17();
            Console.WriteLine("----------------------\n\n\n");
            Ejercicio18();
            Console.WriteLine("----------------------\n\n");
            Ejercicio19();
            Console.WriteLine("----------------------\n\n");
            Ejercicio20();
            Console.WriteLine("----------------------\n\n");
            Ejercicio21();
            Console.WriteLine("----------------------\n\n");
            Ejercicio22();
            Console.WriteLine("----------------------\n\n");
            Ejercicio23();
            
        }
    }
}