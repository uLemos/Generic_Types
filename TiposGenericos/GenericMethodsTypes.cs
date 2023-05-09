using System;
using System.Collections.Generic;
using System.Text;
using TiposGenericos.Entities;

namespace TiposGenericos
{
    public class GenericMethodsTypes
    {
       //Retornar T - método do tipo T. Nessa situação todos devem ter a mesma tipagem.
        public static T GeraId<T>(T data) where T : EntityBase
        {//                     Que espera data(um dado), que é um parâmetro, do tipo T.
            data.Id = Guid.NewGuid();
            return data; 
        }

        public static List<string> GetCamposData<T>(T data)
        {
            var output = new List<string>();

                                 //Estou pegando o tipo e a propriedade de data(Parametro)
            foreach (var item in data.GetType().GetProperties())
            {          //tipo da propiredade                         //Independente do tipo, ele pega as propriedades com "GetProperties".
                if (item.PropertyType == typeof(DateTime))
                                         //Tipo de "DateTime"
                    output.Add(item.Name);
            }
            return output;
        }
    }
}
