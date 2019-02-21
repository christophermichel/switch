using Switch.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Switch.Domain.Entities
{
    public class Usuario
    {
        public int Id { get; private set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string UrlFoto { get; set; }
        public SexoEnum Sexo { get; set; }
    }
}
