using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mov_Reserva
{
    public partial class SelecionarLeitor : Form
    {
        public SelecionarLeitor()
        {
            InitializeComponent();
        }
        public string codLeitor { get; private set; }
        public string nomeLeitor { get; private set; }

        public void FecharFormulario() 
        {
            codLeitor = txtCodLeitor.Text;
            nomeLeitor = txtNomeLeitor.Text;

            this.Close();
        }
        private void CarregarUsuariosGrid()
        {
            dadosGrid.Rows.Clear();
            using (SqlConnection connection = DaoConnection.GetConexao())
            {
                LeitorDAO dao = new LeitorDAO(connection);
                List<LeitorModel> leitores = dao.GetLeitores();
                foreach (LeitorModel leitor in leitores)
                {
                    DataGridViewRow row = dadosGrid.Rows[dadosGrid.Rows.Add()];
                    row.Cells[colCodigoLeitor.Index].Value = leitor.codLeitor;
                    row.Cells[colNomeDoLeitor.Index].Value = leitor.nomeLeitor;
                }
            }
        }
        private void SelecionarLeitor_Load(object sender, EventArgs e)
        {
            CarregarUsuariosGrid();
        }

        private void dadosGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                txtCodLeitor.Text = dadosGrid.Rows[e.RowIndex].Cells[colCodigoLeitor.Index].Value + "";
                txtNomeLeitor.Text = dadosGrid.Rows[e.RowIndex].Cells[colNomeDoLeitor.Index].Value + "";
                FecharFormulario();
            }
        }

        private void txtCodLeitor_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtCodLeitor.Text.Trim();

            foreach (DataGridViewRow row in dadosGrid.Rows)
            {
                string codLeitor = row.Cells[colCodigoLeitor.Index].Value.ToString().Trim();
                bool exibir = codLeitor.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0;
                row.Visible = exibir;
            }
        }

        private void txtNomeLeitor_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtNomeLeitor.Text.Trim();

            foreach (DataGridViewRow row in dadosGrid.Rows)
            {
                string nomeLeitor = row.Cells[colNomeDoLeitor.Index].Value.ToString().Trim();
                bool exibir = nomeLeitor.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0;
                row.Visible = exibir;
            }
        }
    }
}
