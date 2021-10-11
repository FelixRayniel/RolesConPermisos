using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolesConPermisos.Entidades
{
    public class RolesDetalles
    {
        [Key]
        public int Id { get; set; }
        public int RolID { get; set; }
        public int PermisoId { get; set; }
        public bool esAsignado { get; set; }

    }
}
