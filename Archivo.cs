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