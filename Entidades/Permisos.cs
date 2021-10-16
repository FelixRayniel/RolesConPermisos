﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolesConPermisos.Entidades
{
    public class Permisos
    {
        [Key]
        public int PermisoID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int VecesAsingdo { get; set; }

    }
}
