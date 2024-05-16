using AlmoxarifadoDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmoxarifadoDomain.Interfaces
{
    public interface IEstoqueService
    {
        bool VerificarEstoqueAbaixoMinimo(Estoque estoque, int qtdRetirada);
    }
}
