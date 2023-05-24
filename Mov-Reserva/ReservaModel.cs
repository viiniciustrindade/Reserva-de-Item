using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mov_Reserva
{
    public class ReservaModel
    {
        public string tipoMovimento { get; set; }
        public string situacao { get; set; }
        public string dataReserva { get; set; }
        public string prazoReserva { get; set; }
        public string encerrar { get; set; }


        [ForeignKey("mvtBibItemAcervo")]
        [Column("codItem")]
        public string itemId { get; set; }
        public virtual ItemModel ItemModel { get; set; }

        [ForeignKey("mvtBibLeitor")]
        [Column("codLeitor")]
        public string leitorId { get; set; }
        public virtual LeitorModel LeitorModel { get; set; }


    }
}
