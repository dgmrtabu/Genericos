using SeccionGenericosClases.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeccionGenericosClases
{
    public class ManejadorAutomovil
    {
        private List<Automovil> Lista = new List<Automovil>();

        public void Agregar(Automovil valor)
        {
            this.Lista.Add(valor);
        }

        public List<Automovil> ObtenerTodos()
        {
            return this.Lista;
        }

        public void Eliminar(Predicate<Automovil> condicion)
        {
            this.Lista.RemoveAll(condicion);
        }

        public Automovil ObtenerPrimero(Predicate<Automovil> condicion)
        {
            return this.Lista.FirstOrDefault(new Func<Automovil, bool>(condicion));
        }
    }
}
