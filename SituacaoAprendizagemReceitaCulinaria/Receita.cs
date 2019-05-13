using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SituacaoAprendizagemReceitaCulinaria
{
    class Receita
    {
        public string Nome { get; set; }
        public string NumPessoas { get; set; }
        public string TempoPreparo { get; set; }
        public string Categoria { get; set; }
        public string Dificuldade { get; set; }
        public string ModoPreparo { get; set; }
        public string Preco { get; set; }
        public int contador { get; set; }

        public Ingrediente[] Ingredientes { get; set; } = new Ingrediente[8];

    }
}
