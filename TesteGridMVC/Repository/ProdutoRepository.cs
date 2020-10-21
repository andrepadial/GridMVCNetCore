using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteGridMVC.Models;
using TesteGridMVC.Repository.Interfaces;
using Dapper;
using System.Data.SqlClient;
using TesteGridMVC.Repository.Connections;

namespace TesteGridMVC.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        public List<Produto> ObterProdutos()
        {
            throw new NotImplementedException();
        }

        public List<Produto> ObterProdutosPaginado(int? pageNumber, int pageSize)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionStringManager.Value))
            {
                conn.Open();

                var param = new DynamicParameters();
                param.Add("@PageNumber", pageNumber);
                param.Add("@Pagesize", pageSize);

                var data = conn.Query<Produto>("ObterProdutosPaginado", param, commandType: System.Data.CommandType.StoredProcedure).ToList();
                conn.Close();

                return data;

            }
        }

        public int ObterQtdProdutos()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionStringManager.Value))
            {
                conn.Open();

                var param = new DynamicParameters();                

                var data = conn.Query<int>("ObterProdutosCount", param, commandType: System.Data.CommandType.StoredProcedure).FirstOrDefault();
                conn.Close();

                return data;

            }
        }
    }
}
