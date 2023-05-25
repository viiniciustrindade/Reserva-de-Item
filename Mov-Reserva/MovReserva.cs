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
    public partial class MovReserva : Form
    {
        public MovReserva()
        {
            InitializeComponent();
        }
        public void AbrirSelecaoItem()
        { 
            SelecionarItemcs selecionar = new SelecionarItemcs();
            selecionar.ShowDialog();
            txtCodItem.Text = selecionar.codItem;
            txtNomeItem.Text = selecionar.nomeItem;
            txtExemplar.Text = selecionar.exemplar;
            txtLocalizacao.Text = selecionar.localizacao;
            txtTipoItem.Text = selecionar.tipoItem;
        }
        public void AbrirSelecaoLeitor()
        {
            SelecionarLeitor selecionar = new SelecionarLeitor();
            selecionar.ShowDialog();
            txtCodLeitor.Text = selecionar.codLeitor;
            txtNomeLeitor.Text = selecionar.nomeLeitor;

        }
        private void CarregarUsuariosGrid()
        {
            dadosGrid.Rows.Clear();
            using (SqlConnection connection = DaoConnection.GetConexao())
            {
                ReservaDAO dao = new ReservaDAO(connection);
                List<ReservaModel> reservas = dao.GetReservas();
                foreach (ReservaModel reserva in reservas)
                {
                    DataGridViewRow row = dadosGrid.Rows[dadosGrid.Rows.Add()];
                    row.Cells[colCodItem.Index].Value = reserva.ItemModel.codItem;
                    row.Cells[colNomeItem.Index].Value = reserva.ItemModel.nomeItem;
                    row.Cells[colNumExemplar.Index].Value = reserva.ItemModel.numExemplar;
                    row.Cells[colLocalizacao.Index].Value = reserva.ItemModel.localizacao;
                    row.Cells[colTipoMovimento.Index].Value = reserva.tipoMovimento;
                    row.Cells[colSituacao.Index].Value = reserva.situacao;
                    row.Cells[colCodLeitor.Index].Value = reserva.LeitorModel.codLeitor;
                    row.Cells[colNomeLeitor.Index].Value = reserva.LeitorModel.nomeLeitor;
                    row.Cells[colTipoItem.Index].Value = reserva.ItemModel.tipoItem;
                    row.Cells[colPrazoReserva.Index].Value = reserva.prazoReserva.Substring(0, 10);
                    row.Cells[colDataRes.Index].Value = reserva.dataReserva.Substring(0, 10);
                }
            }
        }
        private void MovReserva_Load(object sender, EventArgs e)
        {
            CarregarUsuariosGrid();
        }

        private void cbxTipoMovimento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTipoMovimento.Text == "Reservar")
            {
                cbxSituacao.Text = "Reservado";
            }
            else if (cbxTipoMovimento.Text == "Devolver")
            {
                cbxSituacao.Text = "Disponivel";
            }
        }

        private void btnCarregarItem_Click_1(object sender, EventArgs e)
        {
            AbrirSelecaoItem();
        }

        private void btnCarregarLeitor_Click(object sender, EventArgs e)
        {
            AbrirSelecaoLeitor();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = DaoConnection.GetConexao())
                {
                    ReservaDAO dao = new ReservaDAO(connection);
                    bool verificaRegistros = dao.Validacoes(new ReservaModel()
                    {
                        tipoMovimento = cbxTipoMovimento.Text,
                        dataReserva = dtpDataReserva.Text,
                        prazoReserva = dtpPrazoReserva.Text

                    }, new LeitorModel()
                    {
                        codLeitor = txtCodLeitor.Text
                        
                    }, new ItemModel()
                    {
                        codItem = txtCodItem.Text
                    });
                    txtNomeLeitor.Text = dao.GetNomeLeitor(new LeitorModel()
                    {
                        codLeitor = txtCodLeitor.Text
                    });

                    txtNomeItem.Text = dao.GetNomeItem(new ItemModel()
                    {
                        codItem = txtCodItem.Text
                    });

                    txtExemplar.Text = dao.GetNumExemplar(new ItemModel()
                    {
                        codItem = txtCodItem.Text
                    });

                    txtTipoItem.Text = dao.GetTipoItem(new ItemModel()
                    {
                        codItem = txtCodItem.Text
                    });

                    txtLocalizacao.Text = dao.GetLocalizacao(new ItemModel()
                    {
                        codItem = txtCodItem.Text
                    });

                    if (verificaRegistros)
                    {
                        int count = dao.Verifica(new ItemModel()
                        {
                            codItem = txtCodItem.Text
                        });
                                               
                            dao.Salvar(new ReservaModel()
                            {
                                tipoMovimento = cbxTipoMovimento.Text,
                                dataReserva = dtpDataReserva.Value.Date.ToString(),
                                prazoReserva = dtpPrazoReserva.Value.Date.ToString(),
                                situacao = cbxSituacao.Text

                            }, new LeitorModel()
                            {
                                codLeitor = txtCodLeitor.Text,
                                nomeLeitor = txtNomeLeitor.Text

                            }, new ItemModel()
                            {
                                codItem = txtCodItem.Text,
                                nomeItem = txtNomeItem.Text,
                                numExemplar = txtExemplar.Text,
                                tipoItem = txtTipoItem.Text,
                                localizacao = txtLocalizacao.Text

                            });
                        MessageBox.Show("Reserva registrada com sucesso!");
                        LimpaCampos();


                    }
                    CarregarUsuariosGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Houve um problema ao salvar o item do acervo!\n{ex.Message}");
            }
        }

        private void dadosGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodItem.Text = dadosGrid.Rows[e.RowIndex].Cells[colCodItem.Index].Value + "";
            cbxTipoMovimento.Text = dadosGrid.Rows[e.RowIndex].Cells[colTipoMovimento.Index].Value + "";
            txtExemplar.Text = dadosGrid.Rows[e.RowIndex].Cells[colNumExemplar.Index].Value + "";
            cbxSituacao.Text = dadosGrid.Rows[e.RowIndex].Cells[colSituacao.Index].Value + "";
            txtNomeItem.Text = dadosGrid.Rows[e.RowIndex].Cells[colNomeItem.Index].Value + "";
            txtLocalizacao.Text = dadosGrid.Rows[e.RowIndex].Cells[colLocalizacao.Index].Value + "";
            txtTipoItem.Text = dadosGrid.Rows[e.RowIndex].Cells[colTipoItem.Index].Value + "";
            txtCodLeitor.Text = dadosGrid.Rows[e.RowIndex].Cells[colCodLeitor.Index].Value + "";
            txtNomeLeitor.Text = dadosGrid.Rows[e.RowIndex].Cells[colNomeLeitor.Index].Value + "";
            dtpDataReserva.Text = dadosGrid.Rows[e.RowIndex].Cells[colDataRes.Index].Value + "";
            dtpPrazoReserva.Text = dadosGrid.Rows[e.RowIndex].Cells[colPrazoReserva.Index].Value + "";
        }
        public void LimpaCampos()
        {
            txtCodItem.Text = "";
            cbxTipoMovimento.SelectedIndex = -1;
            txtExemplar.Text = "";
            cbxSituacao.SelectedIndex = -1;
            txtNomeItem.Text = "";
            txtLocalizacao.Text = "";
            txtTipoItem.Text = "";
            txtCodLeitor.Text = "";
            txtNomeLeitor.Text = "";
            dtpDataReserva.Text = null;
            dtpPrazoReserva.Text = null;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }
    }
}
