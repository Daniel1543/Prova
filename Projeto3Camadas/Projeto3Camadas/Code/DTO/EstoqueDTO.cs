using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto3Camadas.Code.DTO
{
    class EstoqueDTO
    {
        private int _id;
        private string _produto;
        private string _preco;

        public int Id { get => _id; set => _id = value; }
        public string Produto { get => _produto; set => _produto = value; }
        public string Preco { get => _preco; set => _preco = value; }
    }
}
