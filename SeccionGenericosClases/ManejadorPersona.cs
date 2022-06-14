using SeccionGenericosClases.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeccionGenericosClases
{
    public class ManejadorPersona
    {
        private List<Persona> Lista = new List<Persona>();

        public void Agregar(Persona valor)
        {
            this.Lista.Add(valor);
        }

        public List<Persona> ObtenerTodos()
        {
            return this.Lista;
        }

        public void Eliminar(Predicate<Persona> condicion)
        {
            this.Lista.RemoveAll(condicion);
        }

        public Persona ObtenerPrimero(Predicate<Persona> condicion)
        {
            return this.Lista.FirstOrDefault(new Func<Persona, bool>(condicion));
        }
    }
}
