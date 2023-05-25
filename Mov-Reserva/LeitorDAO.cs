using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mov_Reserva
{
    public class LeitorDAO
    {
        private SqlConnection Connection { get; }

        public LeitorDAO(SqlConnection connection)
        {
            Connection = connection;
        }

        public List<LeitorModel> GetLeitores()
        {
            List<LeitorModel> leitores = new List<LeitorModel>();
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT codLeitor, Leitor FROM mvtBibLeitor ORDER BY codLeitor");
                command.CommandText = sql.ToString();
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        leitores.Add(PopulateDrLeitores(dr));
                    }
                }
            }
            return leitores;
        }

        public LeitorModel PopulateDrLeitores(SqlDataReader dr)
        {
            string codLeitor = "";
            string nomeLeitor = "";

            if (DBNull.Value != dr["codLeitor"])
            {
                codLeitor = dr["codLeitor"] + "";
            }
            if (DBNull.Value != dr["Leitor"])
            {
                nomeLeitor = dr["Leitor"] + "";
            }
            return new LeitorModel()
            {
                codLeitor = codLeitor,
                nomeLeitor = nomeLeitor,
            };
        }
    }
}
