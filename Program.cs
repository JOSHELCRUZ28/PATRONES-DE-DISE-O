using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPOSITE
{
    class Program
    {
        static void Main(string[] args)
        {

            Componente computadora1 = new Directorio("COMPUTADORA LUJO");
            computadora1.AgregarHijo(new Archivo("Procesador", 12000, "Alto rendimiento extremo", "CPU"));
            computadora1.AgregarHijo(new Archivo("Tarjeta Grafica", 40000, "Gráficos ultra 4K", "GPU"));
            computadora1.AgregarHijo(new Archivo("Placa Madre", 8000, "Alta gama compatible", "Motherboard"));
            computadora1.AgregarHijo(new Archivo("Memoria Ram", 6000, "32GB alto rendimiento", "RAM"));
            computadora1.AgregarHijo(new Archivo("SSD Principal", 3500, "1TB ultra rápido", "Almacenamiento"));
            computadora1.AgregarHijo(new Archivo("Fuente de Poder", 4000, "850W certificada", "PSU"));
            computadora1.AgregarHijo(new Archivo("Refrigeracion Liquida", 5000, "Enfriamiento avanzado", "Cooling"));
            computadora1.AgregarHijo(new Archivo("Gabinete", 3500, "RGB premium", "Case"));
            computadora1.AgregarHijo(new Archivo("Ventilador Extra RGB", 1500, "Ventilación extra RGB", "Cooling"));


            Componente computadora2 = new Directorio("COMPUTADORA REGULAR");
            computadora2.AgregarHijo(new Archivo("Procesador", 3000, "Rendimiento medio", "CPU"));
            computadora2.AgregarHijo(new Archivo("Tarjeta Grafica", 7000, "Gráficos buenos", "GPU"));
            computadora2.AgregarHijo(new Archivo("Placa Madre", 2000, "Placa estándar", "Motherboard"));
            computadora2.AgregarHijo(new Archivo("Memoria Ram", 1200, "8GB RAM", "RAM"));
            computadora2.AgregarHijo(new Archivo("SSD Principal", 1200, "512GB SSD", "Almacenamiento"));
            computadora2.AgregarHijo(new Archivo("Fuente de Poder", 1200, "600W básica", "PSU"));
            computadora2.AgregarHijo(new Archivo("Refrigeracion Liquida", 0, "No incluida", "Cooling"));
            computadora2.AgregarHijo(new Archivo("Gabinete", 1500, "Gabinete estándar", "Case"));
            computadora2.AgregarHijo(new Archivo("Ventilador Extra RGB", 500, "Ventilador básico", "Cooling"));


            Componente computadora3 = new Directorio("COMPUTADORA HUMILDE");
            computadora3.AgregarHijo(new Archivo("Procesador", 2500, "Básico", "CPU"));
            computadora3.AgregarHijo(new Archivo("Tarjeta Grafica", 0, "Integrada", "GPU"));
            computadora3.AgregarHijo(new Archivo("Placa Madre", 1200, "Básica", "Motherboard"));
            computadora3.AgregarHijo(new Archivo("Fuente de Poder", 1200, "600W básica", "PSU"));
            computadora2.AgregarHijo(new Archivo("Refrigeracion Liquida", 0, "No incluida", "Cooling"));
            computadora3.AgregarHijo(new Archivo("Memoria Ram", 500, "4GB RAM", "RAM"));
            computadora2.AgregarHijo(new Archivo("SSD Principal", 1000, "512GB SSD", "Almacenamiento"));
            computadora3.AgregarHijo(new Archivo("Gabinete", 700, "Gabinete estándar", "Case"));
            computadora3.AgregarHijo(new Archivo("SSD Principal", 700, "256GB SSD", "Almacenamiento"));

            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("SELECCIONAR COMPUTADORA");
                Console.WriteLine("1. Computadora Lujo");
                Console.WriteLine("2. Computadora Regular");
                Console.WriteLine("3. Computadora Humilde");
                Console.WriteLine("0. Salir");
                Console.Write("Selecciona una opción: ");

                int opcion;
                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Entrada inválida...");
                    Console.ReadKey();
                    continue;
                }

                Componente seleccion = null;

                switch (opcion)
                {
                    case 1: seleccion = computadora1; break;
                    case 2: seleccion = computadora2; break;
                    case 3: seleccion = computadora3; break;
                    case 0:
                        continuar = false;
                        continue;
                    default:
                        Console.WriteLine("Opción inválida...");
                        Console.ReadKey();
                        continue;
                }

                MostrarComputadora(seleccion);

                Console.WriteLine("\nPresiona cualquier tecla para regresar al menú...");
                Console.ReadKey();
            }
        }
        static void MostrarComputadora(Componente comp)
        {
            Console.WriteLine("\n===============================");
            Console.WriteLine($" {comp.Nombre}");
            Console.WriteLine("===============================");

            var hijos = comp.ObtenerHijos();

            foreach (var item in hijos)
            {
                Archivo a = item as Archivo;

                Console.WriteLine($"- {a.Nombre}");
                Console.WriteLine($"  Tipo: {a.Tipo}");
                Console.WriteLine($"  Descripción: {a.Descripcion}");
                Console.WriteLine($"  Precio: ${a.ObtenerTamaño}");
                Console.WriteLine();
            }

            Console.WriteLine($"👉 PRECIO TOTAL: ${comp.ObtenerTamaño}");
        }
    }
}