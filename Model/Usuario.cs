using System;
using System.Collections.Generic;

namespace AppBootstrap.Model
{
    public  class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apodo { get; set; }
        public string Contrasena { get; set; }
        public string Rol { get; set; }
    }

}
