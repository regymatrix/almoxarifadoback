using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmoxarifadoDomain.Models
{
    public class Estoque
    {
        public virtual Secretaria secretaria { get; set; }
        public virtual  Produto produto { get; set; }
        public virtual int Quantidade { get; set; } 
    }
}
