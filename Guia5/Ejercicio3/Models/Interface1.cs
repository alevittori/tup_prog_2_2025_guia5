using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3.Models
{
    internal interface IImportable
    {
        bool Importar(string xml);
    }
}
