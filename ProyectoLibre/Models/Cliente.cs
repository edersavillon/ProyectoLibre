using System;
using System.Collections.Generic;

#nullable disable

namespace ProyectoLibre.Models
{
    public partial class Cliente
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Telefono { get; set; }
        public string Direccion { get; set; }
    }
}
