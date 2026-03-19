# Tema: Patrón de diseño Composite - aplicado a venta de máquinas armadas

### ALUMNO: LEON CRUZ JORGE JOSHEL 

### N.CONTROL: 22210772

### PROFESOR/A: MARIBEL GUERRERO LUIS

### Fecha: 18/03/2026

---

### CODIGO COMPLETO PROGRAM.CS

```sql

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
```
<p align="justify"> DEL CODIGO QUE MIRAMOS EN CLASE, USAMOS EJEMPLO LAS MISMAS CLASES QUE SE ENCONTRABA EN EL ARCHIVO, COMO UN RECICLADO, LA DIFERENCIA DEL CODIGO USADO EN EL EJEMPLO, SE MODIFICO LOS ARCHIVOS Y LO CAMBIAMOS POR 3 TIPOS DE COMPUTADORAS QUE SON: "LUJO, REGULAR Y HUMILDE", APARTE SE AGREGO DIRECTAMENTE LOS HIJOS DE MANERA QUE SE ACOMODA POR LOS COMPONENTES QUE TIENE CADA COMPUTADORA, CON EL NOMBRE DE "COMPUTADORA1, COMPUTADORA2, COMPUTADORA3", ESO AYUDA SI UN FUTURO SE PODRIA AGREGAR MAS COMPONENTES CON FACILIDAD, SE AGREGO LA DESCRIPCION Y TIPO DE DATO, QUE NOS AYUDA A TENER MAS INFORMACION, LO ULTIMO SE AGREGO UN MENU DONDE SE PUEDE SELECCIONAR UNA COMPUTADORA CON DEPENDE EL PRESUPUESTO DE QUE QUIERA UNA COMPUTADORA, CON LA FUNCION DE REGRESAR Y FINALIZAR. </p>

---

# CODIGO COMPLETO ARCHIVO.CS

```sql

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

        public override void AgregarHijo(Componente c)
        {
  
        }

        public override IList<Componente> ObtenerHijos()
        {
            return null;
        }

        public override int ObtenerTamaño
        {
            get { return _tamaño; }
        }
    }
}
```

SE AGREGO LAS VARIABLES "_tamaño, _tipo", DONDE PUEDE EXTENTER LOS DATOS DE LOS HIJOS Y PODAMOS REALIZAR LOS DATOS COMPLETOS DEL CODIGO PRINCIPAL

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

<img width="1479" height="711" alt="image" src="https://github.com/user-attachments/assets/aa912a9f-8225-4131-9340-e791d87f6167" />
<img width="1479" height="709" alt="image" src="https://github.com/user-attachments/assets/3484fc3a-a17f-40f3-8403-6c2790aa7b8c" />

---

### DATOS DE LA SEGUNDA COMPUTADORA

<img width="1472" height="707" alt="image" src="https://github.com/user-attachments/assets/095e995e-6fef-4065-ad21-837c8da05b0b" />
<img width="1473" height="707" alt="image" src="https://github.com/user-attachments/assets/ba71ca37-0721-4049-ad57-25ff5538a718" />

---
### DATOS DE LA TERCERA COMPUTADORA

<img width="1484" height="636" alt="image" src="https://github.com/user-attachments/assets/291d7718-8127-4b9b-a762-e4bba8e19e36" />
<img width="1478" height="351" alt="image" src="https://github.com/user-attachments/assets/db4ff803-c5ff-4104-853e-bf93abe2f69a" />

### FIN DEL PROGRAMA

<img width="1480" height="755" alt="image" src="https://github.com/user-attachments/assets/2f717a2e-2703-424d-b3ae-b5286c8a83e8" />

---

# CONCLUSION

<p align="justify"> Se implementó el patrón Composite para representar computadoras y sus componentes de forma estructurada, permitiendo manejar tanto elementos individuales como conjuntos de manera uniforme. Además, se mejoró la aplicación agregando características como descripción, tipo de componente y una interfaz interactiva, logrando un sistema más organizado, reutilizable y cercano a un caso real. </p>

---

### FUENTES

https://spartangeek.com/?srsltid=AfmBOoro649kYInTD80cxXLDffDge-PMW6EeIWFr03QV32NtUeCtpszq

https://www.xtremepc.com.mx/?srsltid=AfmBOorcz-MXu5hWa4ES7V0pln_wRi5nJ6AtrDVRapX80R0pyFMWbg7j
