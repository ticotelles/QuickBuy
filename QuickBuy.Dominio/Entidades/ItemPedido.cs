namespace QuickBuy.Dominio.Entidades
{
    public class ItemPedido : Entidade
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }

        public override void Validade()
        {
            if (ProdutoId == 0)
                AdicionarCritica("Não foi foi identificado qual a referência.");

            if (Quantidade == 0)
                AdicionarCritica("Quantidade não foi informado");
        }
    }
}
