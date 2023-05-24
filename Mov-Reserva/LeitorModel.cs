using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mov_Reserva
{
    [Table("mvtBibLeitor")]
    public class LeitorModel
    {
        [Key()]
        public string codLeitor { get; set; }
        public string nomeLeitor { get; set; }
    }
}
