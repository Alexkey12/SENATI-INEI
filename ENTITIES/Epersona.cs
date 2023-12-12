using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIES
{
    public class Epersona
    {
        public int idpersona { get; set; }
        public int IdDistrito { get; set; }
        public int IdDepartamento { get; set; }
        public int IdProvincia { get; set; }
        public int idreligion { get; set; }
        public string apellidos { get; set; }
        public string nombres { get; set; }
        public string tipodoc { get; set; }
        public int numdoc { get; set; }
        public string fechanac { get; set; }
    }
}
