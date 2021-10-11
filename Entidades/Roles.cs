using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolesConPermisos.Entidades
{
    public class Roles
    {
        [Key]
        public int RolID { get; set; }
        public string Descripcion { get; set; }
        public bool esActivo { get; set; }

    }
}
