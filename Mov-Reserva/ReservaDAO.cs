using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mov_Reserva
{
    public class ReservaDAO
    {
        private SqlConnection Connection { get; }
        public ReservaDAO(SqlConnection connection)
        {
            Connection = connection;
        }
        public void Salvar(ReservaModel reserva, LeitorModel leitor, ItemModel item)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                SqlTransaction t = Connection.BeginTransaction();
                try
                {
                    StringBuilder sql = new StringBuilder();
                    sql.AppendLine($"INSERT INTO mvtBibReserva(codItem, situacao, nomeItem, numExemplar, tipoItem, localizacao, codLeitor, nomeLeitor, dataReserva, prazoReserva, tipoMovimento) VALUES(@codItem, @situacao, @nomeItem, @numExemplar, @tipoItem, @localizacao, @codLeitor, @nomeLeitor, @dataReserva, @prazoReserva, @tipoMovimento)");
                    command.CommandText = sql.ToString();
                    command.Parameters.Add(new SqlParameter("@codItem", item.codItem));
                    command.Parameters.Add(new SqlParameter("@situacao", reserva.situacao));
                    command.Parameters.Add(new SqlParameter("@nomeItem", item.nomeItem));
                    command.Parameters.Add(new SqlParameter("@numExemplar", item.numExemplar));
                    command.Parameters.Add(new SqlParameter("@tipoItem", item.tipoItem));
                    command.Parameters.Add(new SqlParameter("@localizacao", item.localizacao));
                    command.Parameters.Add(new SqlParameter("@codLeitor", leitor.codLeitor));
                    command.Parameters.Add(new SqlParameter("@nomeLeitor", leitor.nomeLeitor));
                    command.Parameters.Add(new SqlParameter("@dataReserva", reserva.dataReserva));
                    command.Parameters.Add(new SqlParameter("@prazoReserva", reserva.prazoReserva));
                    command.Parameters.Add(new SqlParameter("@tipoMovimento", reserva.prazoReserva));
                    command.Transaction = t;
                    command.ExecuteNonQuery();
                    t.Commit();
                }

                catch (Exception ex)
                {
                    t.Rollback();
                    throw ex;
                }
            }
        }
        public void AlterarStatusItem(ItemModel item, ReservaModel reserva)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                SqlTransaction t = Connection.BeginTransaction();
                try
                {
                    StringBuilder sql = new StringBuilder();
                    sql.AppendLine($"UPDATE mvtBibItemAcervo SET tipoStatus = @situacao WHERE codItem = @codItem");
                    command.CommandText = sql.ToString();
                    command.Parameters.Add(new SqlParameter("@codItem", item.codItem));
                    command.Parameters.Add(new SqlParameter("@situacao", reserva.situacao));
                    command.Transaction = t;
                    command.ExecuteNonQuery();
                    t.Commit();
                }

                catch (Exception ex)
                {
                    t.Rollback();
                    throw ex;
                }
            }
        }
        public bool Validacoes(ReservaModel reserva, LeitorModel leitor, ItemModel item)
        {
            if (string.IsNullOrEmpty(reserva.tipoMovimento) || string.IsNullOrWhiteSpace(reserva.tipoMovimento))
            {
                MessageBox.Show("Informe o campo [Tipo movimento!]", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (string.IsNullOrEmpty(item.codItem) || string.IsNullOrWhiteSpace(item.codItem))
            {
                MessageBox.Show("Informe o campo [Codigo Item]", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (string.IsNullOrEmpty(leitor.codLeitor) || string.IsNullOrWhiteSpace(leitor.codLeitor))
            {
                MessageBox.Show("Informe o campo [Codigo Leitor]", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (string.IsNullOrEmpty(reserva.dataReserva) || string.IsNullOrWhiteSpace(reserva.dataReserva))
            {
                MessageBox.Show("Informe o campo [Data reserva]", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (string.IsNullOrEmpty(reserva.prazoReserva) || string.IsNullOrWhiteSpace(reserva.prazoReserva))
            {
                MessageBox.Show("Informe o campo [Prazo Reserva]", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }
        public int Verifica(ItemModel item)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine($"SELECT COUNT(codItem) FROM mvtBibReserva WHERE codItem = @codItem");
                command.CommandText = sql.ToString();
                command.Parameters.AddWithValue("@codItem", item.codItem);
                int count = Convert.ToInt32(command.ExecuteScalar());
                return count;
            }
        }
        public string GetLeitorAuto(ItemModel item)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine($"SELECT nomeLeitor FROM mvtBibReserva WHERE  situacao = 'Reservado' and codItem = @codItem");
                command.CommandText = sql.ToString();
                command.Parameters.AddWithValue("@codItem", item.codItem);
                string result = Convert.ToString(command.ExecuteScalar());

                if (result != null)
                {
                    return result.ToString();
                }
            }
            return string.Empty;
        }
        public string GetCodLeitorAuto(ItemModel item)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine($"SELECT codLeitor FROM mvtBibReserva WHERE  situacao = 'Reservado' and codItem = @codItem");
                command.CommandText = sql.ToString();
                command.Parameters.AddWithValue("@codItem", item.codItem);
                string result = Convert.ToString(command.ExecuteScalar());

                if (result != null)
                {
                    return result.ToString();
                }
            }
            return string.Empty;
        }
        public string GetNomeLeitor(LeitorModel leitor)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine($"SELECT Leitor FROM mvtBibLeitor WHERE  codLeitor = @codLeitor");
                command.CommandText = sql.ToString();
                command.Parameters.AddWithValue("@codLeitor", leitor.codLeitor);
                string result = Convert.ToString(command.ExecuteScalar());

                if (result != null)
                {
                    return result.ToString();
                }
            }
            return string.Empty;
        }
        public string GetNomeItem(ItemModel item)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine($"SELECT nome FROM mvtBibItemAcervo WHERE codItem = @codItem");
                command.CommandText = sql.ToString();
                command.Parameters.AddWithValue("@codItem", item.codItem);
                string result = Convert.ToString(command.ExecuteScalar());

                if (result != null)
                {
                    return result.ToString();
                }
            }
            return string.Empty;
        }
        public string GetNumExemplar(ItemModel item)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine($"SELECT numExemplar FROM mvtBibItemAcervo WHERE codItem = @codItem");
                command.CommandText = sql.ToString();
                command.Parameters.AddWithValue("@codItem", item.codItem);
                string result = Convert.ToString(command.ExecuteScalar());

                if (result != null)
                {
                    return result.ToString();
                }
            }
            return string.Empty;
        }
        public string GetTipoItem(ItemModel item)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine($"SELECT tipoItem FROM mvtBibItemAcervo WHERE codItem = @codItem");
                command.CommandText = sql.ToString();
                command.Parameters.AddWithValue("@codItem", item.codItem);
                string result = Convert.ToString(command.ExecuteScalar());

                if (result != null)
                {
                    return result.ToString();
                }
            }
            return string.Empty;
        }
        public string GetLocalizacao(ItemModel item)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine($"SELECT nomeLocal FROM mvtBibItemAcervo WHERE codItem = @codItem");
                command.CommandText = sql.ToString();
                command.Parameters.AddWithValue("@codItem", item.codItem);
                string result = Convert.ToString(command.ExecuteScalar());

                if (result != null)
                {
                    return result.ToString();
                }
            }
            return string.Empty;
        }
        public List<ReservaModel> GetReservas()
        {
            List<ReservaModel> reservas = new List<ReservaModel>();
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT codItem, situacao, nomeItem, numExemplar, tipoItem, localizacao, codLeitor, nomeLeitor, dataReserva, prazoReserva, encerrar, tipoMovimento FROM mvtBibReserva ORDER BY codItem");
                command.CommandText = sql.ToString();
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        reservas.Add(PopulateDrReserva(dr));
                    }
                }
            }
            return reservas;
        }
        public ReservaModel PopulateDrReserva(SqlDataReader dr)
        {
            string dataReserva = "";
            string prazoReserva = "";
            string encerrar = "";
            string tipoMovimento = "";
            string situacao = "";
            LeitorModel codLeitor = null;
            ItemModel codItem = null;

            if (DBNull.Value != dr["dataReserva"])
            {
                dataReserva = dr["dataReserva"] + "";
            }
            if (DBNull.Value != dr["prazoReserva"])
            {
                prazoReserva = dr["prazoReserva"] + "";
            }
            if (DBNull.Value != dr["encerrar"])
            {
                encerrar = dr["encerrar"] + "";
            }
            if (DBNull.Value != dr["tipoMovimento"])
            {
                tipoMovimento = dr["tipoMovimento"] + "";
            }
            if (DBNull.Value != dr["situacao"])
            {
                situacao = dr["situacao"] + "";
            }
            if (DBNull.Value != dr["codLeitor"])
            {
                string leitorCod = dr["codLeitor"] + "";
                string nomeLeitor = dr["nomeLeitor"] + "";
                codLeitor = new LeitorModel()
                {
                    codLeitor = leitorCod,
                    nomeLeitor = nomeLeitor
                };
            }
            if (DBNull.Value != dr["codItem"])
            {
                string itemCod = dr["codItem"] + "";
                string nomeItem = dr["nomeItem"] + "";
                string numExemplar = dr["numExemplar"] + "";
                string tipoItem = dr["tipoItem"] + "";
                string localizacao = dr["localizacao"] + "";
                codItem = new ItemModel()
                {
                    codItem = itemCod,
                    nomeItem = nomeItem,
                    numExemplar = numExemplar,
                    tipoItem = tipoItem,
                    localizacao = localizacao
                };
            }

            return new ReservaModel()
            {
                dataReserva = dataReserva,
                prazoReserva = prazoReserva,
                encerrar = encerrar,
                tipoMovimento = tipoMovimento,
                situacao = situacao,
                LeitorModel = codLeitor,
                ItemModel = codItem
            };
        }

    }
}
