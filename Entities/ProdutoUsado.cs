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

        public override string TagPrice()
        {
            
            return Nome + " (usado) R$ " + Preco.ToString("F2") + $"(Data de fabricação {Fabricaçao.ToString("dd/MM/yyyy")})";
        }
       
    }
}
