using System;
using TiposGenericos.Entities;

namespace TiposGenericos
{
    public class Program
    {
        static void Main(string[] args)
        {
            //var lista = new GenericClassTypes<int>();
            //lista.MinhaLista.Add(1);
            //lista.MinhaLista.Add(2);

            //var lista2 = new GenericClassTypes<string>();
            //lista2.MinhaLista.Add("abc");
            //lista2.MinhaLista.Add("dfg");

            //Lista com objeto -> Genéricos de classe com Objeto.
            var listaObjetoPedido = new GenericClassTypes<PedidoEntity>(); //Aqui não deu erro por conta de que o PedidoEntity herda de EntityBase.
            listaObjetoPedido.MinhaLista.Add(new PedidoEntity() { Valor = 200 });
            listaObjetoPedido.MinhaLista.Add(new PedidoEntity() { Valor = 477 });


            var pedido = new PedidoEntity();
            GenericMethodsTypes.GeraId(pedido);

            var outra  = new OutraEntity();
            outra.Id = Guid.NewGuid();
            var datas = GenericMethodsTypes.GetCamposData(outra);
            var datasPedido = GenericMethodsTypes.GetCamposData(pedido); //-> Não apareceu nada, pois não há nenhuma propriedade do tipo DateTime.

            Console.ReadKey();
        }
    }
}
