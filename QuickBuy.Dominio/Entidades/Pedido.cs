﻿using QuickBuy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido : Entidade
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }

        public DateTime DataPrevisaoEntrega { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string EnderecoCompleto { get; set; }
        public int NumeroEndereco { get; set; }
        public int FormaPagamentoId { get; set; }


        public FormaPagamento  FormaPagamento { get; set; }



        //um pedido deve ter pelo menos um item de pedido ou muitos itens de pedidos
        public ICollection<ItemPedido> ItensPedido { get; set; }

        public override void Validade()
        {
            LimparMensagensValidacao();

            if (!ItensPedido.Any())
                AdicionarCritica("Critical - Pedido não pode ficar sem item de pedido!");

            if (string.IsNullOrEmpty(CEP))
                AdicionarCritica("Critical - CEP deve estar preenchido!");

            if (FormaPagamentoId == 0)
                AdicionarCritica("Critical - Não foi informado a forma de pagamento");
        }
    }
}
