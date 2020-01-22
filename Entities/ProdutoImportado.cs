using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioPordutos.Entities
{
    class ProdutoImportado : Produto
    {
        public double TaxaAlfandegária { get; set; }

        public ProdutoImportado(string nome, double preco, double taxaAlfandegária):base(nome,preco)
        {
            TaxaAlfandegária = taxaAlfandegária;
        }


        public double PrecoTotal()
        {
            return Preco + TaxaAlfandegária;
        }
        public override string TagPrice()
        {
            return $"{Nome} R$ {PrecoTotal().ToString("F2")}  (Taxa Alfandegária R$ {TaxaAlfandegária.ToString("F2")})";
        }
     
    }
}
