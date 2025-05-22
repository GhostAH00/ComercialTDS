using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Data;

namespace ComercialTDSClass
{
    public class ItemPedido
    {
        public int Id { get; set; }
        public int PedidoId { get; set; }
        public Produto Produto { get; set; }
        public double ValorUnit { get; set; }
        public double Quantidade { get; set; }
        public double Desconto { get; set; }
        public ItemPedido()
        {
            Produto = new();
        }
        public ItemPedido(int id, int pedidoId, Produto produto, double valorUnit, double quantidade, double desconto)
        {
            Id = id;
            PedidoId = pedidoId;
            Produto = produto;
            ValorUnit = valorUnit;
            Quantidade = quantidade;
            Desconto = desconto;
        }
        public ItemPedido(int pedidoId, Produto produto, double quantidade, double desconto)
        {           
            PedidoId = pedidoId;
            Produto = produto;           
            Quantidade = quantidade;
            Desconto = desconto;
        }
        public ItemPedido(int id, double quantidade, double desconto)
        {
            Id = id;           
            Quantidade = quantidade;
            Desconto = desconto;
        }
        public void Deletar(int id)
        {

        }
        public void Inserir()
        {
            
        }
        public bool Atualizar()
        {
            return true;
        }
        public static ItemPedido ObterPorId(int id) // id do item de pedido
        {
            ItemPedido itemPedido = new();
            return itemPedido;
        }
        public static List<ItemPedido> ObterListaPorPedidoId(int pedidoId) 
        { 
            

        
        }
    }
}
