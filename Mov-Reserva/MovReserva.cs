using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void MovReserva_Load(object sender, EventArgs e)
        {

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
    }
}
