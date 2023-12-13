using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBilding.Shared
{
    public class AreaComun
    {
        public int  Id { get; set; }
        public string Nombre { get; set; }=string.Empty;
        public string Description { get; set; }= string.Empty;
        public int NumeroSolicitude { get; set; }
        public int Habilitado { get; set; } = 1;
        public string NombreImagen { get; set; } = string.Empty;
    }
}
