# Tema: Patrón de diseño Composite - aplicado a venta de máquinas armadas

### ALUMNO: LEON CRUZ JORGE JOSHEL 

### N.CONTROL: 22210772

### PROFESOR/A: MARIBEL GUERRERO LUIS

### Fecha: 18/03/2026

---

### CODIGO COMPLETO PROGRAM.CS

```sql
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
            // 🖥️ COMPUTADORA LUJO
            computadora1.AgregarHijo(new Archivo("Procesador", 12000, "Intel Core i9 13900K", "CPU"));
            computadora1.AgregarHijo(new Archivo("Tarjeta Grafica", 40000, "NVIDIA RTX 4090", "GPU"));
            computadora1.AgregarHijo(new Archivo("Placa Madre", 8000, "ASUS ROG Strix Z790-E", "Motherboard"));
            computadora1.AgregarHijo(new Archivo("Memoria Ram", 6000, "Corsair Vengeance 32GB DDR5", "RAM"));
            computadora1.AgregarHijo(new Archivo("SSD Principal", 3500, "Samsung 980 Pro 1TB NVMe", "Almacenamiento"));
            computadora1.AgregarHijo(new Archivo("Fuente de Poder", 4000, "Corsair RM850x 850W Gold", "PSU"));
            computadora1.AgregarHijo(new Archivo("Refrigeracion Liquida", 5000, "NZXT Kraken X73 RGB", "Cooling"));
            computadora1.AgregarHijo(new Archivo("Gabinete", 3500, "NZXT H9 Flow RGB", "Case"));
            computadora1.AgregarHijo(new Archivo("Ventilador Extra RGB", 1500, "Corsair iCUE SP120 RGB Elite", "Cooling"));


            // 🖥️ COMPUTADORA REGULAR
            Componente computadora2 = new Directorio("COMPUTADORA REGULAR");
            computadora2.AgregarHijo(new Archivo("Procesador", 3000, "Intel Core i5 12400F", "CPU"));
            computadora2.AgregarHijo(new Archivo("Tarjeta Grafica", 7000, "NVIDIA RTX 3060", "GPU"));
            computadora2.AgregarHijo(new Archivo("Placa Madre", 2000, "MSI B660M PRO", "Motherboard"));
            computadora2.AgregarHijo(new Archivo("Memoria Ram", 1200, "Kingston Fury 8GB DDR4", "RAM"));
            computadora2.AgregarHijo(new Archivo("SSD Principal", 1200, "Kingston NV2 500GB NVMe", "Almacenamiento"));
            computadora2.AgregarHijo(new Archivo("Fuente de Poder", 1200, "EVGA 600W 80+ Bronze", "PSU"));
            computadora2.AgregarHijo(new Archivo("Refrigeracion Liquida", 0, "No incluida", "Cooling"));
            computadora2.AgregarHijo(new Archivo("Gabinete", 1500, "AeroCool Bolt Mini", "Case"));
            computadora2.AgregarHijo(new Archivo("Ventilador Extra RGB", 500, "Cooler Master SickleFlow 120", "Cooling"));


            // 🖥️ COMPUTADORA HUMILDE
            Componente computadora3 = new Directorio("COMPUTADORA HUMILDE");
            computadora3.AgregarHijo(new Archivo("Procesador", 2500, "AMD Ryzen 3 3200G", "CPU"));
            computadora3.AgregarHijo(new Archivo("Tarjeta Grafica", 0, "Gráficos integrados Radeon Vega", "GPU"));
            computadora3.AgregarHijo(new Archivo("Placa Madre", 1200, "Gigabyte A320M-S2H", "Motherboard"));
            computadora3.AgregarHijo(new Archivo("Memoria Ram", 500, "ADATA 4GB DDR4", "RAM"));
            computadora3.AgregarHijo(new Archivo("SSD Principal", 700, "Kingston A400 240GB SSD", "Almacenamiento"));
            computadora3.AgregarHijo(new Archivo("Fuente de Poder", 600, "Acteck 400W básica", "PSU"));
            computadora3.AgregarHijo(new Archivo("Refrigeracion Liquida", 0, "No incluida", "Cooling"));
            computadora3.AgregarHijo(new Archivo("Gabinete", 700, "Vorago Slim Case", "Case"));
            computadora3.AgregarHijo(new Archivo("Ventilador Extra RGB", 0, "No incluido", "Cooling"));

            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("SELECCIONAR COMPUTADORA");
                Console.WriteLine("1. Computadora Lujo");
                Console.WriteLine("2. Computadora Regular");
                Console.WriteLine("3. Computadora Humilde");
                Console.WriteLine("0. Salir");

                int opcion = int.Parse(Console.ReadLine());

                Componente seleccion = null;

                switch (opcion)
                {
                    case 1: seleccion = computadora1; break;
                    case 2: seleccion = computadora2; break;
                    case 3: seleccion = computadora3; break;
                    case 0: continuar = false; continue;
                }

                MostrarComputadora(seleccion);

                Console.WriteLine("\nPresiona una tecla para regresar...");
                Console.ReadKey();
            }
        }

        static void MostrarComputadora(Componente comp)
        {
            Console.Clear();
            Console.WriteLine($"\n=== {comp.Nombre} ===");

            int total = 0;

            foreach (var item in comp.ObtenerHijos())
            {
                Archivo baseComp = item as Archivo;

                Archivo op1 = baseComp;
                Archivo op2;

                switch (baseComp.Nombre)
                {
                    case "Procesador":
                        op2 = new Archivo("Procesador", baseComp.ObtenerTamaño + 3000,
                            "AMD Ryzen 7 / Intel i7", "CPU");
                        break;

                    case "Tarjeta Grafica":
                        op2 = new Archivo("Tarjeta Grafica", baseComp.ObtenerTamaño + 8000,
                            "NVIDIA RTX 4080 / AMD RX 7900", "GPU");
                        break;

                    case "Placa Madre":
                        op2 = new Archivo("Placa Madre", baseComp.ObtenerTamaño + 2000,
                            "Placa premium gaming", "Motherboard");
                        break;

                    case "Memoria Ram":
                        op2 = new Archivo("Memoria Ram", baseComp.ObtenerTamaño + 1500,
                            "64GB RAM alto rendimiento", "RAM");
                        break;

                    case "SSD Principal":
                        op2 = new Archivo("SSD Principal", baseComp.ObtenerTamaño + 2000,
                            "2TB SSD NVMe ultra rápido", "Almacenamiento");
                        break;

                    case "Fuente de Poder":
                        op2 = new Archivo("Fuente de Poder", baseComp.ObtenerTamaño + 1500,
                            "1000W certificación Gold", "PSU");
                        break;

                    case "Refrigeracion Liquida":
                        op2 = new Archivo("Refrigeracion Liquida", baseComp.ObtenerTamaño + 2000,
                            "Refrigeración líquida RGB avanzada", "Cooling");
                        break;

                    case "Gabinete":
                        op2 = new Archivo("Gabinete", baseComp.ObtenerTamaño + 1000,
                            "Gabinete gamer premium RGB", "Case");
                        break;

                    case "Ventilador Extra RGB":
                        op2 = new Archivo("Ventilador Extra RGB", baseComp.ObtenerTamaño + 800,
                            "Kit ventiladores RGB alto flujo", "Cooling");
                        break;

                    default:
                        op2 = baseComp;
                        break;
                }

                Console.WriteLine($"\n===============================");
                Console.WriteLine($"🔧 COMPONENTE: {baseComp.Nombre}");
                Console.WriteLine("===============================");

                // 🔹 OPCIÓN 1
                Console.WriteLine("1️⃣ OPCIÓN 1:");
                Console.WriteLine($"   Tipo: {op1.Tipo}");
                Console.WriteLine($"   Descripción: {op1.Descripcion}");
                Console.WriteLine($"   Precio: ${op1.ObtenerTamaño}");
                Console.WriteLine();

                // 🔹 OPCIÓN 2
                Console.WriteLine("2️⃣ OPCIÓN 2:");
                Console.WriteLine($"   Tipo: {op2.Tipo}");
                Console.WriteLine($"   Descripción: {op2.Descripcion}");
                Console.WriteLine($"   Precio: ${op2.ObtenerTamaño}");
                Console.WriteLine();

                // Selección
                Console.Write("Selecciona una opción (1 o 2): ");
                int opcion = int.Parse(Console.ReadLine());


                Archivo elegido = (opcion == 2) ? op2 : op1;

                Console.WriteLine($" Elegiste: {elegido.Nombre} - ${elegido.ObtenerTamaño}");

                total += elegido.ObtenerTamaño;
            }

            Console.WriteLine("\n===============================");
            Console.WriteLine($"PRECIO TOTAL ARMADO: ${total}");
        }
    }
}
```
<p align="justify"> DEL CODIGO QUE MIRAMOS EN CLASE, USAMOS EJEMPLO LAS MISMAS CLASES QUE SE ENCONTRABA EN EL ARCHIVO, COMO UN RECICLADO, LA DIFERENCIA DEL CODIGO USADO EN EL EJEMPLO, SE MODIFICO LOS ARCHIVOS Y LO CAMBIAMOS POR 3 TIPOS DE COMPUTADORAS QUE SON: "LUJO, REGULAR Y HUMILDE", APARTE SE AGREGO DIRECTAMENTE LOS HIJOS DE MANERA QUE SE ACOMODA POR LOS COMPONENTES QUE TIENE CADA COMPUTADORA, CON EL NOMBRE DE "COMPUTADORA1, COMPUTADORA2, COMPUTADORA3", ESO AYUDA SI UN FUTURO SE PODRIA AGREGAR MAS COMPONENTES CON FACILIDAD, SE AGREGO LA DESCRIPCION Y TIPO DE DATO, QUE NOS AYUDA A TENER MAS INFORMACION, LO ULTIMO SE AGREGO UN MENU DONDE SE PUEDE SELECCIONAR UNA COMPUTADORA CON DEPENDE EL PRESUPUESTO DE QUE QUIERA UNA COMPUTADORA, CON LA FUNCION DE REGRESAR Y FINALIZAR, AGREGAMOS UN CASE DONDE PUEDE SELECCIONAR COMPONENTES DE SEGUNDA OPCION PARA UNA MEJOR COMPUTADORA PARA TODAS LAS COMPUTADORAS, ES UN MISMO CASES, PARA TODAS LAS COMPUTADORAS (COMO SEGUNDA OPCION). </p>

---

# CODIGO COMPLETO ARCHIVO.CS

```sql
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPOSITE
{
    public class Archivo : Componente
    {
        int _tamaño;
        string _descripcion;
        string _tipo;

        public Archivo(string nombre, int tamaño, string descripcion, string tipo) : base(nombre)
        {
            _tamaño = tamaño;
            _descripcion = descripcion;
            _tipo = tipo;
        }

        public string Descripcion => _descripcion;
        public string Tipo => _tipo;

        public override void AgregarHijo(Componente c) { }

        public override IList<Componente> ObtenerHijos()
        {
            return null;
        }

        public override int ObtenerTamaño => _tamaño;
    }
    public class OpcionComponente
    {
        public Archivo Opcion1 { get; set; }
        public Archivo Opcion2 { get; set; }

        public OpcionComponente(Archivo op1, Archivo op2)
        {
            Opcion1 = op1;
            Opcion2 = op2;
        }

        public Archivo Seleccionar()
        {
            Console.WriteLine($"\nSelecciona opción para {Opcion1.Nombre}:");
            Console.WriteLine($"1. {Opcion1.Descripcion} (${Opcion1.ObtenerTamaño})");
            Console.WriteLine($"2. {Opcion2.Descripcion} (${Opcion2.ObtenerTamaño})");

            int opcion = int.Parse(Console.ReadLine());
            return opcion == 2 ? Opcion2 : Opcion1;
        }
    }

}
```

SE AGREGO LAS VARIABLES "_tamaño, _tipo", DONDE PUEDE EXTENTER LOS DATOS DE LOS HIJOS Y PODAMOS REALIZAR LOS DATOS COMPLETOS DEL CODIGO PRINCIPAL, APARTE SE REALIZO UNA CLASE ESPECIAL PARA REALIZAR 2 O MAS OPCIONES PARA LOS COMPONENTES, EN ESTE CASO 2.

---

# CODIGO COMPLETO COMPONENTE.CS

```sql
namespace COMPOSITE
{
    public abstract class Componente
    {
        string _nombre;

        public Componente(string nombre)
        {
            _nombre = nombre;
        }

        public string Nombre
        {
            get { return _nombre; }
        }

        public abstract void AgregarHijo(Componente c);
        public abstract IList<Componente> ObtenerHijos();
        public abstract int ObtenerTamaño { get; }
    }
}
```

SE MANTIENE EL CODIGO ORIGINAL

---

# CODIGO COMPLETO DIRECTORIO.CS

```sql
namespace COMPOSITE
{
    public class Directorio : Componente
    {
        private List<Componente> _hijos;

        public Directorio(string nombre) : base(nombre)
        {
            _hijos = new List<Componente>();
        }

        public override void AgregarHijo(Componente c)
        {
            _hijos.Add(c);
        }

        public override IList<Componente> ObtenerHijos()
        {
            return _hijos.ToArray();
        }

        public override int ObtenerTamaño
        {
            get
            {
                int t = 0;
                foreach (var item in _hijos)
                {
                    t += item.ObtenerTamaño;
                }
                return t;
            }
        }
    }
}
```

SE MANTIENE EL CODIGO ORIGINAL

---

# MENU DEL COMPOSITE

<img width="1484" height="759" alt="image" src="https://github.com/user-attachments/assets/dde7402d-75a0-476f-9b18-7d109419f34a" />

### DATOS DE LA PRIMERA COMPUTADORA

<img width="1919" height="991" alt="image" src="https://github.com/user-attachments/assets/66cbd49b-0512-4ae4-b73d-f6dcb1929127" />
<img width="1919" height="977" alt="image" src="https://github.com/user-attachments/assets/6cba021c-0791-4d93-84af-0af7e170550e" />
<img width="1918" height="975" alt="image" src="https://github.com/user-attachments/assets/8089f482-456a-4803-80dc-88ca938d8f50" />
<img width="1919" height="888" alt="image" src="https://github.com/user-attachments/assets/5a118882-0435-4818-ae81-7a115085f979" />


---

### DATOS DE LA SEGUNDA COMPUTADORA

<img width="1919" height="977" alt="image" src="https://github.com/user-attachments/assets/064e04b7-b16b-4aff-9505-5a26540cc87e" />
<img width="1919" height="978" alt="image" src="https://github.com/user-attachments/assets/80997e20-fce4-4e20-8cb1-f9616d9a941a" />
<img width="1919" height="978" alt="image" src="https://github.com/user-attachments/assets/27363d67-396a-40f0-8b05-7294d7f53062" />
<img width="1919" height="980" alt="image" src="https://github.com/user-attachments/assets/1028dbb9-a998-44db-bd42-ad9d6e5fe4c2" />
<img width="1919" height="529" alt="image" src="https://github.com/user-attachments/assets/5545efc6-80e4-4250-861b-d8b2f9cf47ae" />


---
### DATOS DE LA TERCERA COMPUTADORA

<img width="1919" height="957" alt="image" src="https://github.com/user-attachments/assets/1fdd5121-5f5c-4cf7-8463-df9ef185feed" />
<img width="1919" height="965" alt="image" src="https://github.com/user-attachments/assets/944b3121-698e-4535-b289-72b8ca9d70ac" />
<img width="1919" height="974" alt="image" src="https://github.com/user-attachments/assets/8137d8eb-1e47-43ef-b1c5-31b99234f2b6" />
<img width="1917" height="971" alt="image" src="https://github.com/user-attachments/assets/d231a829-d006-45fa-a0a4-565ef2b348cd" />
<img width="1919" height="527" alt="image" src="https://github.com/user-attachments/assets/2be27bc1-fb20-4742-a1af-722ddaa5772f" />


### FIN DEL PROGRAMA

<img width="1480" height="755" alt="image" src="https://github.com/user-attachments/assets/2f717a2e-2703-424d-b3ae-b5286c8a83e8" />

---

# CONCLUSION

<p align="justify"> Se implementó el patrón Composite para representar computadoras y sus componentes de forma estructurada, permitiendo manejar tanto elementos individuales como conjuntos de manera uniforme. Además, se mejoró la aplicación agregando características como descripción, tipo de componente y una interfaz interactiva, logrando un sistema más organizado, reutilizable y cercano a un caso real. </p>

---

### FUENTES

https://spartangeek.com/?srsltid=AfmBOoro649kYInTD80cxXLDffDge-PMW6EeIWFr03QV32NtUeCtpszq

https://www.xtremepc.com.mx/?srsltid=AfmBOorcz-MXu5hWa4ES7V0pln_wRi5nJ6AtrDVRapX80R0pyFMWbg7j
