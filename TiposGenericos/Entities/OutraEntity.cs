using System;
using System.Collections.Generic;
using System.Text;

namespace TiposGenericos.Entities
{
    public class OutraEntity
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataAtualizacao { get; set; }
    }
}
