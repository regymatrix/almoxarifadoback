using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmoxarifadoDomain.Models
{
    public class Produto
    {
        public int ID_PRO { get; set; }
        public string DESCRICAO { get; set; }
        public virtual int ESTOQUE_MIN { get; set; }
    }
}
