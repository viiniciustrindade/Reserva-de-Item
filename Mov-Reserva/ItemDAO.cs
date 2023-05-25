using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mov_Reserva
{
    public class ItemDAO
    {
        private SqlConnection Connection { get; }

        public ItemDAO(SqlConnection connection)
        {
            Connection = connection;
        }

        public List<ItemModel> GetItens()
        {
            List<ItemModel> itens = new List<ItemModel>();
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT codItem, nome, numExemplar, tipoItem, localização FROM mvtBibItemAcervo ORDER BY codItem");
                command.CommandText = sql.ToString();
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        itens.Add(PopulateDrItem(dr));
                    }
                }
            }
            return itens;
        }

        public ItemModel PopulateDrItem(SqlDataReader dr)
        {
            string codItem = "";
            string nome = "";
            string numExemplar = "";
            string tipoItem = "";
            string localizacao = "";

            if (DBNull.Value != dr["codItem"])
            {
                codItem = dr["codItem"] + "";
            }
            if (DBNull.Value != dr["nome"])
            {
                nome = dr["nome"] + "";
            }
            if (DBNull.Value != dr["numExemplar"])
            {
                numExemplar = dr["numExemplar"] + "";
            }
            if (DBNull.Value != dr["tipoItem"])
            {
                tipoItem = dr["tipoItem"] + "";
            }
            if (DBNull.Value != dr["localização"])
            {
                localizacao = dr["localização"] + "";
            }
            return new ItemModel()
            {
                codItem = codItem,
                nomeItem = nome,
                numExemplar = numExemplar,
                tipoItem = tipoItem,
                localizacao = localizacao,

            };
        }
    }
}
