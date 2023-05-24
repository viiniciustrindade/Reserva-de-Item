using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mov_Reserva
{
    [Table("mvtBibItemAcervo")]
    
    public class ItemModel
    {
        [Key()]
        public string codItem { get; set; }
        public string nomeItem { get; set; }
        public string numExemplar { get; set; }
        public string tipoItem { get; set; }
        public string localizacao { get; set; }
    }
}
