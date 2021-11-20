using System.Data;
using Projeto3Camadas.Code.DTO; 
using Projeto3Camadas.Code.DAL; 

namespace Projeto3Camadas.Code.BLL
{
    class EstoqueBLL
    {

        
        AcessoBancoDados conexao = new AcessoBancoDados();
        string tabela = "tbl_produto";


        
        public void Inserir (EstoqueDTO epaDto)
        {
            string inserir = $"insert into {tabela} values(null,'{epaDto.Produto}','{epaDto.Preco}')";
            conexao.ExecutarComando(inserir);
        }

        public DataTable Listar()     
        {
            string sql = $"select * from {tabela} order by id;";
            return conexao.ExecutarConsulta(sql);
        }

        public void Editar(EstoqueDTO epaDto)
        {
            string alterar = $"update {tabela} set produto = '{epaDto.Produto}', preco = '{epaDto.Preco}' where id = '{epaDto.Id}';";
            conexao.ExecutarComando(alterar);
        }


        public void Excluir(EstoqueDTO epaDto)
        {
            string excluir = $"delete from {tabela} where id = '{epaDto.Id}';";
            conexao.ExecutarComando(excluir);
        }
    }
}
