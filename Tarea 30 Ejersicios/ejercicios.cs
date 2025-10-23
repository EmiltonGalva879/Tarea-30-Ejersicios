using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_30_Ejersicios
{
  public class ejercicios
    {
        // ==================== EJERCICIOS ====================
        class Ejercicio1
        {
            public static void Ejecutar()
            {
                Console.Clear();
                Console.WriteLine("=== EJERCICIO 1 ===");
                double tarifa, horastrabajadas, horasextra, salario, tarifaextra;
                Console.WriteLine("Ingrese horas trabajadas:");
                horastrabajadas = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese tarifa:");
                tarifa = double.Parse(Console.ReadLine());

                if (horastrabajadas <= 40 && horastrabajadas >= 0)
                {
                    salario = horastrabajadas * tarifa;
                    Console.WriteLine("El salario es: " + salario);
                }
                else if (horastrabajadas > 40)
                {
                    horasextra = horastrabajadas - 40;
                    tarifaextra = tarifa + 0.5 * tarifa;
                    salario = horasextra * tarifaextra + 40 * tarifa;
                    Console.WriteLine("El salario es: " + salario);
                }
                else
                {
                    Console.WriteLine("Las horas trabajadas no pueden ser negativas");
                }
                Console.ReadLine();
            }
        }

        class Ejercicio2
        {
            public static void Ejecutar()
            {
                Console.Clear();
                Console.WriteLine("=== EJERCICIO 2 ===");
                double sueldo, sueldoneto, descuento;
                Console.WriteLine("Ingrese el sueldo:");
                sueldo = double.Parse(Console.ReadLine());

                if (sueldo <= 1000 && sueldo >= 0)
                {
                    descuento = sueldo * 0.1;
                    sueldoneto = sueldo - descuento;
                }
                else if (sueldo <= 2000 && sueldo > 1000)
                {
                    descuento = (sueldo - 1000) * 0.05 + (1000 * 0.1);
                    sueldoneto = sueldo - descuento;
                }
                else if (sueldo > 2000)
                {
                    descuento = (sueldo - 2000) * 0.03 + (1000 * 0.05) + (1000 * 0.10);
                    sueldoneto = sueldo - descuento;
                }
                else
                {
                    Console.WriteLine("Error: el sueldo no puede ser negativo");
                    Console.ReadLine();
                    return;
                }

                Console.WriteLine("El descuento es: {0} y el sueldo neto es: {1}", descuento, sueldoneto);
                Console.ReadLine();
            }
        }

        class Ejercicio3
        {
            public static void Ejecutar()
            {
                Console.Clear();
                Console.WriteLine("=== EJERCICIO 3 ===");
                double monto, descuento;
                Console.WriteLine("Ingrese monto:");
                monto = double.Parse(Console.ReadLine());

                if (monto > 100)
                {
                    descuento = monto * 0.1;
                    Console.WriteLine("El monto {0} tiene un descuento de {1}", monto, descuento);
                }
                else if (monto > 0 && monto <= 100)
                {
                    descuento = monto * 0.2;
                    Console.WriteLine("El monto {0} tiene un descuento de {1}", monto, descuento);
                }
                else
                {
                    Console.WriteLine("Error: el monto no puede ser negativo");
                }
                Console.ReadLine();
            }
        }

        class Ejercicio4
        {
            public static void Ejecutar()
            {
                Console.Clear();
                Console.WriteLine("=== EJERCICIO 4 ===");
                int tiemposegundos, minutos, segundosrestantes;
                Console.WriteLine("Ingrese el tiempo en segundos:");
                tiemposegundos = int.Parse(Console.ReadLine());

                if (tiemposegundos < 60 && tiemposegundos > 0)
                {
                    segundosrestantes = 60 - tiemposegundos;
                    Console.WriteLine("Le falta {0} segundos para convertirse en minuto", segundosrestantes);
                }
                else if (tiemposegundos >= 60)
                {
                    minutos = tiemposegundos / 60;
                    segundosrestantes = tiemposegundos % 60;
                    Console.WriteLine("Equivale a {0} minutos y {1} segundos restantes", minutos, segundosrestantes);
                }
                else
                {
                    Console.WriteLine("La cantidad de segundos debe ser un número positivo");
                }
                Console.ReadLine();
            }
        }

        class Ejercicio5
        {
            public static void Ejecutar()
            {
                Console.Clear();
                Console.WriteLine("=== EJERCICIO 5 ===");
                int tiempo, dias, horas, minutos, x;
                Console.WriteLine("Ingrese un tiempo en minutos:");
                tiempo = int.Parse(Console.ReadLine());

                if (tiempo >= 0)
                {
                    dias = tiempo / 1440;
                    x = tiempo % 1440;
                    horas = x / 60;
                    minutos = x % 60;
                    Console.WriteLine("Equivale a {0} días, {1} horas y {2} minutos", dias, horas, minutos);
                }
                else
                {
                    Console.WriteLine("El tiempo no puede ser negativo");
                }
                Console.ReadLine();
            }
        }

        class Ejercicio6
        {
            public static void Ejecutar()
            {
                Console.Clear();
                Console.WriteLine("=== EJERCICIO 6 ===");
                int x, numero, suma;
                Console.Write("Ingrese el número N: ");
                numero = int.Parse(Console.ReadLine());
                suma = 0;

                for (x = 1; x <= numero; x++)
                {
                    suma += x;
                    Console.WriteLine("n{0}: {1}", x, x);
                }

                Console.WriteLine("La suma de la serie es: {0}", suma);
                Console.ReadLine();
            }
        }

        class Ejercicio7
        {
            public static void Ejecutar()
            {
                Console.Clear();
                Console.WriteLine("=== EJERCICIO 7 ===");
                double x, salario, horastrabajadas, tarifa, suma, numerotrabajadores;
                suma = 0;
                Console.Write("Ingrese la cantidad de trabajadores: ");
                numerotrabajadores = double.Parse(Console.ReadLine());

                for (x = 1; x <= numerotrabajadores; x++)
                {
                    Console.WriteLine("Trabajador {0}:", x);
                    Console.Write("Horas trabajadas: ");
                    horastrabajadas = double.Parse(Console.ReadLine());
                    Console.Write("Tarifa: ");
                    tarifa = double.Parse(Console.ReadLine());
                    salario = horastrabajadas * tarifa;
                    suma += salario;
                }

                Console.WriteLine("La suma de los salarios es: {0}", suma);
                Console.ReadLine();
            }
        }

        class Ejercicio8
        {
            public static void Ejecutar()
            {
                Console.Clear();
                Console.WriteLine("=== EJERCICIO 8 ===");
                double horastrabajadas, tarifa, salario;
                Console.Write("Ingrese horas trabajadas: ");
                horastrabajadas = double.Parse(Console.ReadLine());
                Console.Write("Ingrese tarifa: ");
                tarifa = double.Parse(Console.ReadLine());
                salario = horastrabajadas * tarifa;
                Console.WriteLine("El salario del trabajador es: " + salario);
                Console.ReadLine();
            }
        }

        class Ejercicio9
        {
            public static void Ejecutar()
            {
                Console.Clear();
                Console.WriteLine("=== EJERCICIO 9 ===");
                double promedio, ca = 0, cd = 0, x = 0, nota, acumuladas = 0, acumuladasapro = 0, acumuladasdesapro = 0;
                double promedioaprobadas = 0, promediodesaprobadas = 0;
                string resp;

                do
                {
                    Console.Write("Introduce la nota: ");
                    nota = double.Parse(Console.ReadLine());
                    Console.Write("¿Deseas ingresar otra nota? (si/no): ");
                    resp = Console.ReadLine().ToLower();

                    if (nota <= 10.5 && nota >= 0)
                    {
                        cd++;
                        acumuladasdesapro += nota;
                    }
                    else if (nota > 10.5 && nota <= 20)
                    {
                        ca++;
                        acumuladasapro += nota;
                    }

                    acumuladas += nota;
                    x = ca + cd;
                    promedioaprobadas = ca > 0 ? Math.Round(acumuladasapro / ca, 1) : 0;
                    promediodesaprobadas = cd > 0 ? Math.Round(acumuladasdesapro / cd, 1) : 0;
                    promedio = x > 0 ? Math.Round(acumuladas / x, 1) : 0;

                } while (resp == "si");

                Console.Clear();
                Console.WriteLine("Cantidad de notas desaprobadas: " + cd);
                Console.WriteLine("Cantidad de notas aprobadas: " + ca);
                Console.WriteLine("Promedio de notas aprobadas: " + promedioaprobadas);
                Console.WriteLine("Promedio de notas desaprobadas: " + promediodesaprobadas);
                Console.WriteLine("Promedio final: " + promedio);
                Console.ReadLine();
            }
        }

        class Ejercicio10
        {
            public static void Ejecutar()
            {
                Console.Clear();
                Console.WriteLine("=== EJERCICIO 10 ===");
                int numero, residuo, suma = 0;
                Console.Write("Ingresar un número: ");
                numero = int.Parse(Console.ReadLine());

                int temp = numero;
                do
                {
                    residuo = temp % 10;
                    suma += residuo;
                    temp /= 10;
                } while (temp != 0);

                Console.WriteLine("La suma de los dígitos es: {0}", suma);
                Console.ReadLine();
            }
        }


        class Ejercicio11
        {
            public static void Ejecutar()
            {
                Console.Clear();
                Console.WriteLine("=== EJERCICIO 11 ===");
                int baseTriangulo, altura;
                double area;
                Console.Write("Ingrese la base del triángulo: ");
                baseTriangulo = int.Parse(Console.ReadLine());
                Console.Write("Ingrese la altura del triángulo: ");
                altura = int.Parse(Console.ReadLine());
                area = (baseTriangulo * altura) / 2.0;
                Console.WriteLine("El área del triángulo es: " + area);
                Console.ReadLine();
            }
        }

        class Ejercicio12
        {
            public static void Ejecutar()
            {
                Console.Clear();
                Console.WriteLine("=== EJERCICIO 12 ===");
                double peso, altura, imc;
                Console.Write("Ingrese el peso en kg: ");
                peso = double.Parse(Console.ReadLine());
                Console.Write("Ingrese la altura en m: ");
                altura = double.Parse(Console.ReadLine());
                imc = peso / (altura * altura);
                Console.WriteLine("El IMC es: " + Math.Round(imc, 2));
                if (imc < 18.5)
                    Console.WriteLine("Clasificación: Bajo peso");
                else if (imc >= 18.5 && imc <= 24.9)
                    Console.WriteLine("Clasificación: Normal");
                else if (imc >= 25 && imc <= 29.9)
                    Console.WriteLine("Clasificación: Sobrepeso");
                else
                    Console.WriteLine("Clasificación: Obesidad");
                Console.ReadLine();
            }
        }

        class Ejercicio13
        {
            public static void Ejecutar()
            {
                Console.Clear();
                Console.WriteLine("=== EJERCICIO 13 ===");
                double radio, area, perimetro;
                Console.Write("Ingrese el radio del círculo: ");
                radio = double.Parse(Console.ReadLine());
                area = Math.PI * Math.Pow(radio, 2);
                perimetro = 2 * Math.PI * radio;
                Console.WriteLine("Área: " + Math.Round(area, 2));
                Console.WriteLine("Perímetro: " + Math.Round(perimetro, 2));
                Console.ReadLine();
            }
        }

        class Ejercicio14
        {
            public static void Ejecutar()
            {
                Console.Clear();
                Console.WriteLine("=== EJERCICIO 14 ===");
                int numero, factorial = 1;
                Console.Write("Ingrese un número: ");
                numero = int.Parse(Console.ReadLine());

                for (int i = 1; i <= numero; i++)
                {
                    factorial *= i;
                }

                Console.WriteLine("El factorial de {0} es: {1}", numero, factorial);
                Console.ReadLine();
            }
        }

        class Ejercicio15
        {
            public static void Ejecutar()
            {
                Console.Clear();
                Console.WriteLine("=== EJERCICIO 15 ===");
                int n;
                Console.Write("Ingrese la cantidad de números a sumar: ");
                n = int.Parse(Console.ReadLine());
                double suma = 0, numero;

                for (int i = 1; i <= n; i++)
                {
                    Console.Write($"Ingrese el número {i}: ");
                    numero = double.Parse(Console.ReadLine());
                    suma += numero;
                }

                Console.WriteLine("La suma total es: " + suma);
                Console.ReadLine();
            }
        }

        class Ejercicio16
        {
            public static void Ejecutar()
            {
                Console.Clear();
                Console.WriteLine("=== EJERCICIO 16 ===");
                double numero, mayor = double.MinValue, menor = double.MaxValue;
                string resp;

                do
                {
                    Console.Write("Ingrese un número: ");
                    numero = double.Parse(Console.ReadLine());
                    if (numero > mayor) mayor = numero;
                    if (numero < menor) menor = numero;

                    Console.Write("¿Desea ingresar otro número? (si/no): ");
                    resp = Console.ReadLine().ToLower();
                } while (resp == "si");

                Console.WriteLine("Número mayor: " + mayor);
                Console.WriteLine("Número menor: " + menor);
                Console.ReadLine();
            }
        }

        class Ejercicio17
        {
            public static void Ejecutar()
            {
                Console.Clear();
                Console.WriteLine("=== EJERCICIO 17 ===");
                int n, suma = 0;
                Console.Write("Ingrese un número positivo: ");
                n = int.Parse(Console.ReadLine());

                for (int i = 1; i <= n; i++)
                {
                    if (i % 2 != 0)
                    {
                        suma += i;
                    }
                }

                Console.WriteLine("La suma de los números impares hasta {0} es: {1}", n, suma);
                Console.ReadLine();
            }
        }

        class Ejercicio18
        {
            public static void Ejecutar()
            {
                Console.Clear();
                Console.WriteLine("=== EJERCICIO 18 ===");
                int n, suma = 0;
                Console.Write("Ingrese un número: ");
                n = int.Parse(Console.ReadLine());

                for (int i = 1; i <= n; i++)
                {
                    suma += i * i;
                }

                Console.WriteLine("La suma de los cuadrados hasta {0} es: {1}", n, suma);
                Console.ReadLine();
            }
        }

        class Ejercicio19
        {
            public static void Ejecutar()
            {
                Console.Clear();
                Console.WriteLine("=== EJERCICIO 19 ===");
                int n, factorial = 1;
                Console.Write("Ingrese un número: ");
                n = int.Parse(Console.ReadLine());

                for (int i = 1; i <= n; i++)
                {
                    factorial *= i;
                }

                Console.WriteLine("El factorial de {0} es: {1}", n, factorial);
                Console.ReadLine();
            }
        }

        class Ejercicio20
        {
            public static void Ejecutar()
            {
                Console.Clear();
                Console.WriteLine("=== EJERCICIO 20 ===");
                int n, fibonacci1 = 0, fibonacci2 = 1, fibonacci;
                Console.Write("Ingrese cuántos términos de Fibonacci desea mostrar: ");
                n = int.Parse(Console.ReadLine());

                Console.Write(fibonacci1 + " " + fibonacci2 + " ");

                for (int i = 3; i <= n; i++)
                {
                    fibonacci = fibonacci1 + fibonacci2;
                    Console.Write(fibonacci + " ");
                    fibonacci1 = fibonacci2;
                    fibonacci2 = fibonacci;
                }

                Console.WriteLine();
                Console.ReadLine();
            }
        }

        class Ejercicio21
        {
            public static void Ejecutar()
            {
                Console.Clear();
                Console.WriteLine("=== EJERCICIO 21 ===");
                double baseTriangulo, altura, area;
                Console.Write("Ingrese la base del triángulo: ");
                baseTriangulo = double.Parse(Console.ReadLine());
                Console.Write("Ingrese la altura del triángulo: ");
                altura = double.Parse(Console.ReadLine());
                area = (baseTriangulo * altura) / 2;
                Console.WriteLine("El área del triángulo es: " + area);
                Console.ReadLine();
            }
        }

        class Ejercicio22
        {
            public static void Ejecutar()
            {
                Console.Clear();
                Console.WriteLine("=== EJERCICIO 22 ===");
                double catetoA, catetoB, hipotenusa;
                Console.Write("Ingrese el primer cateto: ");
                catetoA = double.Parse(Console.ReadLine());
                Console.Write("Ingrese el segundo cateto: ");
                catetoB = double.Parse(Console.ReadLine());
                hipotenusa = Math.Sqrt(catetoA * catetoA + catetoB * catetoB);
                Console.WriteLine("La hipotenusa es: " + Math.Round(hipotenusa, 2));
                Console.ReadLine();
            }
        }

        class Ejercicio23
        {
            public static void Ejecutar()
            {
                Console.Clear();
                Console.WriteLine("=== EJERCICIO 23 ===");
                double radio, area, volumen, longitud;
                const double PI = 3.1416;
                Console.Write("Ingrese el radio: ");
                radio = double.Parse(Console.ReadLine());
                longitud = 2 * PI * radio;
                area = PI * radio * radio;
                volumen = (4.0 / 3) * PI * Math.Pow(radio, 3);
                Console.WriteLine("Longitud de la circunferencia: " + Math.Round(longitud, 2));
                Console.WriteLine("Área de la circunferencia: " + Math.Round(area, 2));
                Console.WriteLine("Volumen de la esfera: " + Math.Round(volumen, 2));
                Console.ReadLine();
            }
        }

        class Ejercicio24
        {
            public static void Ejecutar()
            {
                Console.Clear();
                Console.WriteLine("=== EJERCICIO 24 ===");
                double consumo, descuento, total = 0;
                for (int i = 1; i <= 5; i++)
                {
                    Console.Write($"Ingrese el consumo {i}: ");
                    consumo = double.Parse(Console.ReadLine());
                    if (consumo > 130)
                        descuento = consumo * 0.15;
                    else
                        descuento = 0;
                    consumo -= descuento;
                    total += consumo;
                }
                Console.WriteLine("El total de los consumos es: " + total);
                Console.ReadLine();
            }
        }

        class Ejercicio25
        {
            public static void Ejecutar()
            {
                Console.Clear();
                Console.WriteLine("=== EJERCICIO 25 ===");
                int numero, suma = 0;
                Console.Write("Ingrese un número mayor o igual a 8: ");
                numero = int.Parse(Console.ReadLine());
                if (numero < 8)
                {
                    Console.WriteLine("Error, el número ingresado es menor a 8.");
                }
                else
                {
                    for (int i = 8; i <= numero; i++)
                    {
                        suma += i;
                    }
                    Console.WriteLine($"La suma de la serie de 8 hasta {numero} es: {suma}");
                }
                Console.ReadLine();
            }
        }

        class Ejercicio26
        {
            public static void Ejecutar()
            {
                Console.Clear();
                Console.WriteLine("=== EJERCICIO 26 ===");
                double caja = 371, egreso, totalEgresos = 0;
                int cont = 1;
                do
                {
                    Console.Write($"Ingrese egreso {cont} (-1 para terminar): ");
                    egreso = double.Parse(Console.ReadLine());
                    if (egreso == -1) break;
                    totalEgresos += egreso;
                    cont++;
                } while (true);

                Console.WriteLine("Total de egresos: " + totalEgresos);
                Console.WriteLine("Lo sobrante en caja es: " + (caja - totalEgresos));
                Console.ReadLine();
            }
        }

        class Ejercicio27
        {
            public static void Ejecutar()
            {
                Console.Clear();
                Console.WriteLine("=== EJERCICIO 27 ===");
                double nota1, nota2, promedio;
                Console.Write("Ingrese primera nota: ");
                nota1 = double.Parse(Console.ReadLine());
                Console.Write("Ingrese segunda nota: ");
                nota2 = double.Parse(Console.ReadLine());
                promedio = (nota1 + nota2) / 2;

                if (nota1 >= 0 && nota1 <= 20 && nota2 >= 0 && nota2 <= 20)
                {
                    if (promedio >= 10.5)
                        Console.WriteLine($"Promedio: {promedio} -> Aprobado");
                    else
                        Console.WriteLine($"Promedio: {promedio} -> Desaprobado");
                }
                else
                {
                    Console.WriteLine("Error: las notas ingresadas no están en el rango 0-20.");
                }

                Console.ReadLine();
            }
        }

        class Ejercicio28
        {
            public static void Ejecutar()
            {
                Console.Clear();
                Console.WriteLine("=== EJERCICIO 28 ===");
                string deporte;
                int voley = 0, futbol = 0, basquet = 0, ajedrez = 0;

                for (int i = 1; i <= 10; i++)
                {
                    Console.Write($"Ingrese deporte del {i}º alumno (voley/futbol/basquet/ajedrez): ");
                    deporte = Console.ReadLine().ToLower();
                    switch (deporte)
                    {
                        case "voley": voley++; break;
                        case "futbol": futbol++; break;
                        case "basquet": basquet++; break;
                        case "ajedrez": ajedrez++; break;
                        default:
                            Console.WriteLine("Error: deporte no válido"); i--;
                            break;
                    }
                }

                Console.WriteLine("\nCantidad de alumnos por deporte:");
                Console.WriteLine($"Voley: {voley}");
                Console.WriteLine($"Fútbol: {futbol}");
                Console.WriteLine($"Básquet: {basquet}");
                Console.WriteLine($"Ajedrez: {ajedrez}");
                Console.ReadLine();
            }
        }

        class Ejercicio29
        {
            public static void Ejecutar()
            {
                Console.Clear();
                Console.WriteLine("=== EJERCICIO 29 ===");
                string clave;
                string[] correctas = { "tienes", "que ser", "invitado", "para", "ingresar" };

                for (int i = 0; i < 5; i++)
                {
                    Console.Write($"Ingrese clave {i + 1}: ");
                    clave = Console.ReadLine();
                    if (clave != correctas[i])
                    {
                        Console.WriteLine("TE EQUIVOCASTE DE FIESTA");
                        Console.ReadLine();
                        return;
                    }
                }

                Console.WriteLine("¡Bienvenido a la fiesta!");
                Console.ReadLine();
            }
        }

        class Ejercicio30
        {
            public static void Ejecutar()
            {
                Console.Clear();
                Console.WriteLine("=== EJERCICIO 30 ===");
                double numero, cubo, raizcuadrada;

                do
                {
                    Console.Write("Ingrese un número (0 para salir): ");
                    numero = double.Parse(Console.ReadLine());
                    if (numero == 0) break;

                    cubo = Math.Pow(numero, 3);
                    raizcuadrada = Math.Sqrt(numero);
                    Console.WriteLine("Cubo: " + cubo);
                    Console.WriteLine("Raíz cuadrada: " + Math.Round(raizcuadrada, 2));
                    Console.WriteLine();
                } while (true);

                Console.WriteLine("FINAL DEL PROCESO");
                Console.ReadLine();
            }
        }
    
}
}
