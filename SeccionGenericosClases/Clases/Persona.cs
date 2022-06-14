using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeccionGenericosClases.Clases
{
    public class Persona
    {
        public Guid Identificador { get; private set; } = Guid.NewGuid();
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}
