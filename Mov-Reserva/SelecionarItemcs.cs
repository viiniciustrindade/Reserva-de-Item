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
    public partial class SelecionarItemcs : Form
    {
        public SelecionarItemcs()
        {
            InitializeComponent();
        }
        public string codItem { get; private set; }
        public string nomeItem { get; private set; }
        public string exemplar { get; private set; }
        public string localizacao { get; private set; }
        public string tipoItem { get; private set; }
        public string tipoMovimento { get; set; }

        public void FecharFormulario()
        {
            codItem = txtCodItem.Text;
            nomeItem = txtNomeItem.Text;
            exemplar = txtExemplar.Text;
            tipoItem = txtTipoItem.Text;
            localizacao = txtLocalizacao.Text;

            this.Close();
        }
        private void CarregarUsuariosGrid()
        {
            dadosGrid.Rows.Clear();
            if (tipoMovimento == "Devolver")
            {
                using (SqlConnection connection = DaoConnection.GetConexao())
                {
                    ItemDAO dao = new ItemDAO(connection);
                    List<ItemModel> itens = dao.GetTipoItens();
                    foreach (ItemModel item in itens)
                    {
                        DataGridViewRow row = dadosGrid.Rows[dadosGrid.Rows.Add()];
                        row.Cells[colCodItem.Index].Value = item.codItem;
                        row.Cells[colNomeItem.Index].Value = item.nomeItem;
                        row.Cells[colNumExemplar.Index].Value = item.numExemplar;
                        row.Cells[colLocalizacao.Index].Value = item.localizacao;
                        row.Cells[colTipoItem.Index].Value = item.tipoItem;
                    }
                }
            }
            else {
                using (SqlConnection connection = DaoConnection.GetConexao())
                {
                    ItemDAO dao = new ItemDAO(connection);
                    List<ItemModel> itens = dao.GetItens();
                    foreach (ItemModel item in itens)
                    {
                        DataGridViewRow row = dadosGrid.Rows[dadosGrid.Rows.Add()];
                        row.Cells[colCodItem.Index].Value = item.codItem;
                        row.Cells[colNomeItem.Index].Value = item.nomeItem;
                        row.Cells[colNumExemplar.Index].Value = item.numExemplar;
                        row.Cells[colLocalizacao.Index].Value = item.localizacao;
                        row.Cells[colTipoItem.Index].Value = item.tipoItem;
                    }
                }

            }
        }
        private void SelecionarItemcs_Load(object sender, EventArgs e)
        {
            CarregarUsuariosGrid();
        }

        private void dadosGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                txtCodItem.Text = dadosGrid.Rows[e.RowIndex].Cells[colCodItem.Index].Value + "";
                txtNomeItem.Text = dadosGrid.Rows[e.RowIndex].Cells[colNomeItem.Index].Value + "";
                txtExemplar.Text = dadosGrid.Rows[e.RowIndex].Cells[colNumExemplar.Index].Value + "";
                txtTipoItem.Text = dadosGrid.Rows[e.RowIndex].Cells[colTipoItem.Index].Value + "";
                txtLocalizacao.Text = dadosGrid.Rows[e.RowIndex].Cells[colLocalizacao.Index].Value + "";

                FecharFormulario();
            }
        }

        private void txtCodItem_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtCodItem.Text.Trim();

            foreach (DataGridViewRow row in dadosGrid.Rows)
            {
                string nomeAutor = row.Cells[colCodItem.Index].Value.ToString().Trim();
                bool exibir = nomeAutor.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0;
                row.Visible = exibir;
            }
        }
        private void txtNomeItem_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtNomeItem.Text.Trim();

            foreach (DataGridViewRow row in dadosGrid.Rows)
            {
                string nomeAutor = row.Cells[colNomeItem.Index].Value.ToString().Trim();
                bool exibir = nomeAutor.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0;
                row.Visible = exibir;
            }
        }

        private void txtExemplar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtExemplar.Text.Trim();

            foreach (DataGridViewRow row in dadosGrid.Rows)
            {
                string nomeAutor = row.Cells[colNumExemplar.Index].Value.ToString().Trim();
                bool exibir = nomeAutor.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0;
                row.Visible = exibir;
            }
        }

        private void txtLocalizacao_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtLocalizacao.Text.Trim();

            foreach (DataGridViewRow row in dadosGrid.Rows)
            {
                string nomeAutor = row.Cells[colLocalizacao.Index].Value.ToString().Trim();
                bool exibir = nomeAutor.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0;
                row.Visible = exibir;
            }
        }
        private void txtTipoItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filtro = txtTipoItem.Text.Trim();

            foreach (DataGridViewRow row in dadosGrid.Rows)
            {
                string nomeAutor = row.Cells[colTipoItem.Index].Value.ToString().Trim();
                bool exibir = nomeAutor.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0;
                row.Visible = exibir;
            }
        }
    }
}
