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

        public string PriceTag()
        {
            return $"{Nome} R$ {Preco} (Taxa Alfandegária R$ {TaxaAlfandegária})";
        }
    }
}
