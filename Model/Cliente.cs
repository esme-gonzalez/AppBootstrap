using System;
using System.Collections.Generic;



namespace AppBootstrap.Model
{
    public partial class Cliente
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Celular { get; set; }
    }
}
