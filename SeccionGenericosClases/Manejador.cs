using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeccionGenericosClases
{
    public class Manejador<TInput>
    {
        private List<TInput> Lista = new List<TInput>();

        public void Agregar(TInput valor)
        {
            this.Lista.Add(valor);
        }

        public List<TInput> ObtenerTodos()
        {
            return this.Lista;
        }

        public void Eliminar(Predicate<TInput> condicion)
        {
            this.Lista.RemoveAll(condicion);
        }

        public TInput ObtenerPrimero(Predicate<TInput> condicion)
        {
            return this.Lista.FirstOrDefault(new Func<TInput, bool>(condicion));
        }
    }
}
