using System;

namespace ExercicioPordutos.Entities
{
    class ProdutoUsado : Produto
    {
        public DateTime Fabricaçao { get; set; }

        public ProdutoUsado(string nome,double preco,DateTime fabricaçao) : base (nome, preco)
        {
            Fabricaçao = fabricaçao;
        }

        public string PriceTag()
        {
            return Nome + " (usado) R$ " + Preco + $"(Data de fabricação {Fabricaçao})";
        }
    }
}
