using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplication
{
    public class DTOAutor
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public List<string> NombresAlternativos { get; set; }
        
    }
}