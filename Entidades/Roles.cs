using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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


        [ForeignKey("RolID")]
        public virtual List<RolesDetalles> RolesDetalle { get; set; } = new List<RolesDetalles>();
    }
}
