using System;
using Tarea_30_Ejersicios;

namespace Tarea_30_Ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion;

            do
            {
                ejercicios v = new ejercicios();

                Menu.MostrarMenu();
                Console.Write("Seleccione una opción: ");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1": Ejercicio1.Ejecutar(); break;
                    case "2": Ejercicio2.Ejecutar(); break;
                    case "3": Ejercicio3.Ejecutar(); break;
                    case "4": Ejercicio4.Ejecutar(); break;
                    case "5": Ejercicio5.Ejecutar(); break;
                    case "6": Ejercicio6.Ejecutar(); break;
                    case "7": Ejercicio7.Ejecutar(); break;
                    case "8": Ejercicio8.Ejecutar(); break;
                    case "9": Ejercicio9.Ejecutar(); break;
                    case "10": Ejercicio10.Ejecutar(); break;
                    case "11": Ejercicio11.Ejecutar(); break;
                    case "12": Ejercicio12.Ejecutar(); break;
                    case "13": Ejercicio13.Ejecutar(); break;
                    case "14": Ejercicio14.Ejecutar(); break;
                    case "15": Ejercicio15.Ejecutar(); break;
                    case "16": Ejercicio16.Ejecutar(); break;
                    case "17": Ejercicio17.Ejecutar(); break;
                    case "18": Ejercicio18.Ejecutar(); break;
                    case "19": Ejercicio19.Ejecutar(); break;
                    case "20": Ejercicio20.Ejecutar(); break;
                    case "21": Ejercicio21.Ejecutar(); break;
                    case "22": Ejercicio22.Ejecutar(); break;
                    case "23": Ejercicio23.Ejecutar(); break;
                    case "24": Ejercicio24.Ejecutar(); break;
                    case "25": Ejercicio25.Ejecutar(); break;
                    case "26": Ejercicio26.Ejecutar(); break;
                    case "27": Ejercicio27.Ejecutar(); break;
                    case "28": Ejercicio28.Ejecutar(); break;
                    case "29": Ejercicio29.Ejecutar(); break;
                    case "30": Ejercicio30.Ejecutar(); break;

                    case "0": Console.WriteLine("Saliendo del programa..."); break;
                    default: Console.WriteLine("Opción no válida."); break;
                }

                if (opcion != "0")
                {
                    Console.WriteLine("\nPresione una tecla para volver al menú...");
                    Console.ReadKey();
                }

            } while (opcion != "0");
        }
    }

    // ==================== MENÚ ====================
    class Menu
    {
        public static void MostrarMenu()
        {
            Console.Clear();
            Console.WriteLine("========= MENÚ DE EJERCICIOS =========\n" +
                "Ejercicio1\n" +
                "Ejercicio2\n" +
                "Ejercicio3\n" +
                "Ejercicio4\n" +
                "Ejercicio5\n" +
                "Ejercicio6\n" +
                "Ejercicio7\n" +
                "Ejercicio8\n" +
                "Ejercicio9\n" +
                "Ejercicio10\n" +
                "Ejercicio11\n" +
                "Ejercicio12\n" +
                "Ejercicio13\n" +
                "Ejercicio14\n" +
                "Ejercicio15\n" +
                "Ejercicio16\n" +
                "Ejercicio17\n" +
                "Ejercicio18\n" +
                "Ejercicio19\n" +
                "Ejercicio20\n" +
                "Ejercicio21\n" +
                "Ejercicio22\n" +
                "Ejercicio23\n" +
                "Ejercicio24\n" +
                "Ejercicio25\n" +
                "Ejercicio26\n" +
                "Ejercicio27\n" +
                "Ejercicio28\n" +
                "Ejercicio29\n" +
                "Ejercicio30\n" +
                "Digite el munero de Ejercicio que desea ejecutar:");
            for (int i = 1; i <= 30; i++)
            {
                Console.WriteLine($"{i}. Ejercicio {i}");
            }
            Console.WriteLine("0. Salir");
            Console.WriteLine("======================================");
        }
    }

}