using NPOI.SS.Formula.Functions;
using System.Collections.Generic;
using TiposGenericos.Entities;

namespace TiposGenericos
{                                  //Quando T for EntityBase
    public class GenericClassTypes<T> where T : EntityBase
    {                              // Ou seja, meu T só pode ser EntityBase
        public GenericClassTypes()
        {
            MinhaLista = new List<T>();
        }
        //O "T" pode ser qualquer coisa.
        //Lista de "T". -> É Genérico, pode ser strin, int, decimal...
        public List<T> MinhaLista { get; set; }
    }
}
